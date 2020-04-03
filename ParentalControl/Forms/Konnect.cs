using ParentalControl;
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
    public partial class Konnect : Form
    {
        public Konnect()
        {
            InitializeComponent();
        }

        private void Konnect_Load(object sender, EventArgs e)
        {

            try
            {
                string imageTemp = SqlMethods.getSqlString("SELECT value FROM settings WHERE `settingName`='currentPicture'");
                Image image1 = Image.FromFile("c:\\xampp\\Local-Point-Manager\\" + imageTemp);
                pictureBox1.Image = image1;
                pictureBox1.Size = image1.Size;
                this.Size = image1.Size;
                
            }
            catch { }
        }
    }
}
