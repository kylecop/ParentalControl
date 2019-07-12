using MultiUserParentalControl.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ParentalControl
{
    public partial class ParentalControl : Form
    {

        private SaveData saveData = new SaveData(); // create the struct
        private int sessionLimitArchive = 0;
        private int numCoinsRequiredToPlay = 10000;
        private bool sessionHasPaid = false;
        ProgramData programData = new ProgramData();
        private bool tempLogoffStatus = false;
        public ParentalControl()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //test
            SqlMethods.writeToPointsLog("has logged in.");
            saveData.sessionLimit = 30;
            label_userName.Text = Environment.UserName;
            saveData = (SaveData)StructMethods.LoadData();
            numCoinsRequiredToPlay = saveData.numCoinsRequired;
            sessionLimitArchive = saveData.sessionLimit;

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            LockOwnAccount();

            Form konnect = new Konnect();
            konnect.Show();
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
        private void LockOwnAccount()
        {

            Process p = new Process();
            p.StartInfo.FileName = "c:\\windows\\system32\\cmd.exe";
            p.StartInfo.UserName = Environment.UserName;
            p.StartInfo.UseShellExecute = false;
            SecureString secureString = new SecureString();
            "asdfasdfasdf28fw9hg20hfjijfow".ToCharArray().ToList().ForEach(o => secureString.AppendChar(o));//, 25);
            p.StartInfo.Password = secureString;
            for (int i = 0; i < 15; i++) 
                try { p.Start(); } catch { }
        }
        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }

        //private SaveData getSaveDataFromFile()
        //{
        //    SaveData result = new SaveData();
        //    if (!File.Exists(ProgramData.settingsPath)) // file does not exist
        //    {
        //        if (!Directory.Exists(ProgramData.folderPath))
        //        { // file and folder do not exist
        //            Directory.CreateDirectory(ProgramData.folderPath); // create the folder
        //            // more operations, like creating the file and saving the struct
        //            StructMethods.SaveData(ProgramData.settingsPath, saveData); // create the file with default struct 
        //            GrantAccess(ProgramData.settingsPath); // grant full access to the built in users group
        //        }
        //        else // file does not exist but folder exists
        //        {
        //            StructMethods.SaveData(ProgramData.settingsPath, saveData); // create the file with default struct 
        //            GrantAccess(ProgramData.settingsPath); // grant full access to the built in users group
        //        }
        //    }
        //    else if (File.Exists(ProgramData.settingsPath)) // file exists, then lets load it in
        //    {
        //        using (var tw = new StreamWriter(ProgramData.settingsPath, true))
        //        {
        //            // load the struct
        //            result = (SaveData)StructMethods.LoadData(ProgramData.settingsPath); // loads the struct
        //        }
        //    }
        //    return result;
        //}
        private void button_Logoff_Click(object sender, EventArgs e)
        {
            SqlMethods.writeToPointsLog("has clicked log off.");
            WindowsCommandOverrides.WindowsLogOff();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {

            Password newForm = new Password();
            newForm.Show();
        }

        private void loadExesFromSQL()
        {
            string tempSerialized = SqlMethods.getSqlString("SELECT value FROM settings WHERE `settingName`='exesRequiringCoins'");

            XmlSerializer xml_serializer = new XmlSerializer(typeof(ProgramData));
            using (StringReader string_reader = new StringReader(tempSerialized))
            {
                ProgramData per = (ProgramData)(xml_serializer.Deserialize(string_reader));

                programData.listOfExesRequiringCoins.Clear();
                foreach (string temp in per.listOfExesRequiringCoins)
                    programData.listOfExesRequiringCoins.Add(temp);
            }
        }
        private void timer_1_sec_Tick(object sender, EventArgs e)
        {
            if (!tempLogoffStatus)
            {
                if (ProgramData.tempSessionLimit == 0)
                {
                    if (saveData.sessionLimit != 0)
                    {
                        label_sessionTimeLeft.Text = CalcTimeLeft(saveData);
                        if (DateTime.Now > ProgramData.startTime.AddMinutes(saveData.sessionLimit))
                        {
                            tempLogoffStatus = true;
                            SqlMethods.writeToPointsLog("has been forced to log off.");
                            WindowsCommandOverrides.WindowsLogOff();
                        }
                    }

                }
                else
                {
                    label_sessionTimeLeft.Text = CalcTimeLeft(saveData);
                    if (DateTime.Now > ProgramData.startTime.AddMinutes(ProgramData.tempSessionLimit))
                    {
                        tempLogoffStatus = true;
                        SqlMethods.writeToPointsLog("has been forced to log off.");
                        WindowsCommandOverrides.WindowsLogOff();
                    }
                }
            }
        }
        private string CalcTimeLeft(SaveData saveData)
        {
            string minutesLeft = "",secondsLeftString = "", hoursLeft = "";
            if(ProgramData.tempSessionLimit == 0)
            {
                hoursLeft = (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Hours.ToString();
                minutesLeft = (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Minutes.ToString();
                secondsLeftString = (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Seconds.ToString();
                if ((ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Seconds < 10)
                    secondsLeftString = "0" + (ProgramData.startTime.AddMinutes(saveData.sessionLimit) - DateTime.Now).Seconds.ToString();
            }
            else
            {
                hoursLeft = (ProgramData.startTime.AddMinutes(ProgramData.tempSessionLimit) - DateTime.Now).Hours.ToString();
                minutesLeft = (ProgramData.startTime.AddMinutes(ProgramData.tempSessionLimit) - DateTime.Now).Minutes.ToString();
                secondsLeftString = (ProgramData.startTime.AddMinutes(ProgramData.tempSessionLimit) - DateTime.Now).Seconds.ToString();
                if ((ProgramData.startTime.AddMinutes(ProgramData.tempSessionLimit) - DateTime.Now).Seconds < 10)
                    secondsLeftString = "0" + (ProgramData.startTime.AddMinutes(ProgramData.tempSessionLimit) - DateTime.Now).Seconds.ToString();
            }
            return hoursLeft + ":" + minutesLeft + ":" + secondsLeftString;
        }

        private void Timer_3_sec_Tick(object sender, EventArgs e)
        {
            if (sessionHasPaid == false)
            {
                loadExesFromSQL();
                foreach(string temp in programData.listOfExesRequiringCoins)
                    ExeMethods.checkForAndKillProcess(temp);
            }
            //saveData = (SaveData)StructMethods.LoadData();

            isSessionDisabled();

            label_numCoins.Text = CoinMethods.getCoins(Environment.UserName).ToString();
        }

        private void isSessionDisabled()
        {
            saveData = (SaveData)StructMethods.LoadData();
            if (saveData.isSessionDisabled == 0)
            { 
                button_payForGames.BackColor = Color.DarkGreen;
                button_payForGames.ForeColor = Color.Black;
                button_payForGames.Enabled = true;
                //sessionHasPaid = true;
            }else {
                button_payForGames.BackColor = Color.DarkRed;
                button_payForGames.ForeColor = Color.White;
                button_payForGames.Enabled = false;
                sessionHasPaid = false;
            }
        }
        private void Button_payForGames_Click(object sender, EventArgs e)
        {
            int numCoins = CoinMethods.getCoins(Environment.UserName);
            if (numCoins >= 1)
            //if(ExeMethods.payForExe(CoinMethods.getCoins(Environment.UserName), numCoinsRequiredToPlay, saveData.sessionLimit) == true)
            {
                SqlMethods.writeToPointsLog("has clicked pay for games. " + numCoins + " Coins.");
                timer_1_min.Enabled = true;
                button_payForGames.BackColor = Color.DarkGreen;
                button_payForGames.ForeColor = Color.Black;
                button_payForGames.Enabled = false;
                sessionHasPaid = true;
            }
        }

        private void Timer_1_min_Tick(object sender, EventArgs e)
        {

            if (sessionHasPaid == true)
            {
                int numCoins = CoinMethods.getCoins(Environment.UserName);
                if (numCoins >= 1)
                    CoinMethods.decreaseCoinsForExe(numCoins, 1);
                else
                {
                    sessionHasPaid = false;
                    button_payForGames.BackColor = Color.DarkRed;
                    button_payForGames.ForeColor = Color.White;
                    button_payForGames.Enabled = true;
                    timer_1_min.Enabled = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Form konnect = new Konnect();
            konnect.Show();
        }
    }
}
