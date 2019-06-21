using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl.Forms
{
    public partial class Settings : Form
    {
        SaveData saveData = new SaveData();
        public Settings()
        {
            saveData = (SaveData)StructMethods.LoadData(ProgramData.settingsPath);
            InitializeComponent();
        }

        private void button_newPIN_Save_Click(object sender, EventArgs e)
        {
            if(maskedTextBox_newPIN.Text == maskedTextBox_newPIN_Confirmation.Text)
            {
                saveData.passCode = maskedTextBox_newPIN.Text;
                StructMethods.SaveData(ProgramData.settingsPath, saveData);
                MessageBox.Show("New passcode has been saved!");
                maskedTextBox_newPIN.Text = "";
                maskedTextBox_newPIN_Confirmation.Text = "";
            }
            else
            {
                MessageBox.Show("Passcodes did not match, unable to save new passcode.");
            }
        }

        private void button_SessionLimit_Decrease_Click(object sender, EventArgs e)
        {

            Int32.TryParse(textBox_SessionLimit.Text, out int limit);
            textBox_SessionLimit.Text = (limit - 1).ToString();
        }

        private void button_SessionLimit_Increase_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox_SessionLimit.Text, out int limit);
            textBox_SessionLimit.Text = (limit + 1).ToString();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox_SessionLimit.Text, out saveData.sessionLimit);
            StructMethods.SaveData(ProgramData.settingsPath, saveData);
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_SessionLimit_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBox_SessionLimit.Text, out int limit);
            if (limit == 0)
            {
                MessageBox.Show("Limit set to 0. Which is no limit.");
                textBox_SessionLimit.Text = limit.ToString();
            }
            else
            {
                textBox_SessionLimit.Text = limit.ToString();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox_SessionLimit.Text = saveData.sessionLimit.ToString();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
