using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiUserParentalControl
{
    public partial class MultiUserParentalControl : Form
    {

        private SaveData saveData = new SaveData(); // create the struct
        private int sessionLimitArchive = 0;
        public MultiUserParentalControl()
        {
            InitializeComponent();
        }

        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label_userName.Text = Environment.UserName;
            if (!File.Exists(ProgramData.settingsPath)) // file does not exist
            {
                if (!Directory.Exists(ProgramData.folderPath)) { // file and folder do not exist
                    Directory.CreateDirectory(ProgramData.folderPath); // create the folder
                    // more operations, like creating the file and saving the struct
                    StructMethods.SaveData(ProgramData.settingsPath, saveData); // create the file with default struct 
                    GrantAccess(ProgramData.settingsPath); // grant full access to the built in users group
                }
                else // file does not exist but folder exists
                {
                    StructMethods.SaveData(ProgramData.settingsPath, saveData); // create the file with default struct 
                    GrantAccess(ProgramData.settingsPath); // grant full access to the built in users group
                }
            }
            else if (File.Exists(ProgramData.settingsPath)) // file exists, then lets load it in
            {
                using (var tw = new StreamWriter(ProgramData.settingsPath, true))
                {
                    // load the struct
                    saveData = (SaveData)StructMethods.LoadData(ProgramData.settingsPath); // loads the struct
                }
            }

            sessionLimitArchive = saveData.sessionLimit;

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            //this.ShowInTaskbar = minimizeToTray;
            e.Cancel = true;
            //if (!minimizeToTray)
            //    Hide();
            //else
            //    WindowState = FormWindowState.Minimized;
            MessageBox.Show("Open the settings in order to close the program.");
        }
        private void button_Logoff_Click(object sender, EventArgs e)
        {
            WindowsCommandOverrides.WindowsLogOff();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {

            Password newForm = new Password();
            newForm.Show();
        }

        private void timer_1_sec_Tick(object sender, EventArgs e)
        {
            saveData = (SaveData)StructMethods.LoadData(ProgramData.settingsPath);
            label_sessionTimeLeft.Text = CalcTimeLeft(saveData);
            if (sessionLimitArchive != 0)
            {
                if (DateTime.Now > ProgramData.startTime.AddMinutes(saveData.sessionLimit))
                    WindowsCommandOverrides.WindowsLogOff();
                if (sessionLimitArchive != saveData.sessionLimit)
                {
                    sessionLimitArchive = saveData.sessionLimit;
                    ProgramData.startTime = DateTime.Now;
                }
            }
        }
        private string CalcTimeLeft(SaveData saveData)
        {
            string minutesLeft = (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Minutes.ToString();
            string secondsLeftString = (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Seconds.ToString();
            if ((ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Seconds < 10)
                secondsLeftString = "0" + (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Seconds.ToString();
            return minutesLeft + ":" + secondsLeftString;
        }
    }
}
