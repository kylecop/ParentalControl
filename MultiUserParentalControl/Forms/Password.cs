using ParentalControl.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl
{
    public partial class Password : Form
    {
        SaveData saveData = new SaveData();
        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            saveData = (SaveData)StructMethods.LoadData();
            maskedTextBox1.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);
        }

        private bool validate()
        {
            bool result = false;
            if ((saveData.passCode == maskedTextBox1.Text) || (saveData.passCode == null && (maskedTextBox1.Text == "9999")))
            {
                //MessageBox.Show("good");
                result = true;
                maskedTextBox1.Text = "";

                WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                bool formIsOpen = false;
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm is Settings)
                    {
                        formIsOpen = true;
                        frm.BringToFront();
                        RestoreFromMinimize rst = new RestoreFromMinimize();
                        rst.RestoreFromMinimzied(frm);
                    }

                }
                if (formIsOpen == false)
                {
                    Settings newForm = new Settings();
                    //settings.FormClosed += (s, args) => ReloadAllApps();
                    newForm.Show();

                    RestoreFromMinimize rst = new RestoreFromMinimize();
                    rst.RestoreFromMinimzied(newForm);
                    //Close();
                    newForm.BringToFront();
                }
            }
            else
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
            return result;
        }
        private void button15_Click(object sender, EventArgs e)
        {
        }
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "1";
        }


        private void button2_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "0";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
