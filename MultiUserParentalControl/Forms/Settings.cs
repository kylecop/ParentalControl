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
            InitializeComponent();
        }

        private void button_newPIN_Save_Click(object sender, EventArgs e)
        {
            if(maskedTextBox_newPIN.Text == maskedTextBox_newPIN_Confirmation.Text)
            {
                saveData.passCode = maskedTextBox_newPIN.Text;
                StructMethods.SaveData(saveData);
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
            Int32.TryParse(textBox_numCoins.Text, out int temp);
            Int32.TryParse(textBox_requiredCoins.Text, out saveData.numCoinsRequired);
            CoinMethods.setCoins(Environment.UserName, temp);
            StructMethods.SaveData(saveData);
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
            saveData = (SaveData)StructMethods.LoadData();
            SqlMethods.writeToPointsLog("has opened the Settings.");
            textBox_SessionLimit.Text = saveData.sessionLimit.ToString();
            textBox_numCoins.Text = CoinMethods.getCoins(Environment.UserName).ToString();
            textBox_requiredCoins.Text = saveData.numCoinsRequired.ToString();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            SqlMethods.writeToPointsLog("has closed the program.");
            Environment.Exit(1);
        }

        private void Button_decreaseCoins_Click(object sender, EventArgs e)
        {
            int temp = 0;
            Int32.TryParse(textBox_numCoins.Text, out temp);

            textBox_numCoins.Text = (temp - 20).ToString();
        }

        private void Button_increaseCoins_Click(object sender, EventArgs e)
        {

            int temp = 0;
            Int32.TryParse(textBox_numCoins.Text, out temp);

            textBox_numCoins.Text = (temp + 20).ToString();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            checkedListBox1.Items.Add(openFileDialog1.FileName);
        }

        private void Button_findExecutable_Click(object sender, EventArgs e)
        {
            checkedListBox1.Show();
        }

        private void Button_decreaseRequiredCoins_Click(object sender, EventArgs e)
        {


            int temp = 0;
            Int32.TryParse(textBox_requiredCoins.Text, out temp);

            textBox_requiredCoins.Text = (temp - 20).ToString();
        }

        private void Button_increaseRequiredCoins_Click(object sender, EventArgs e)
        {


            int temp = 0;
            Int32.TryParse(textBox_requiredCoins.Text, out temp);

            textBox_requiredCoins.Text = (temp + 20).ToString();
        }

        private void TextBox_numCoins_TextChanged(object sender, EventArgs e)
        {

            Int32.TryParse(textBox_numCoins.Text, out int temp);
            if (temp == 0)
            {
                MessageBox.Show("Invalid number entered, Number of Coins set to 0.");
                textBox_numCoins.Text = temp.ToString();
            }
            else
            {
                textBox_numCoins.Text = temp.ToString();
            }
        }

        private void TextBox_requiredCoins_TextChanged(object sender, EventArgs e)
        {

            Int32.TryParse(textBox_requiredCoins.Text, out int temp);
            if (temp == 0)
            {
                MessageBox.Show("Invalid number entered, Number of Required Coins set to 0. Which makes it free.");
                textBox_requiredCoins.Text = temp.ToString();
            }
            else
            {
                textBox_requiredCoins.Text = temp.ToString();
            }
        }
    }
}
