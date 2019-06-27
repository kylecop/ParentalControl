using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl
{
    [Serializable]
    public struct SaveData
    {
        public int sessionLimit;
        public string passCode;
        public int numCoinsRequired;
        public int isSessionDisabled;
    }
    [Serializable()]
    public class ProgramData
    {
        public static int tempSessionLimit = 0;
        public List<String> listOfExesRequiringCoins = new List<String>();
        public static DateTime startTime = DateTime.Now;
        // folder path depends on environment but is typically c:\programdata\ParentalControl\MultiuserParentalControl\
        public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + Application.CompanyName + "\\" + Application.ProductName + "\\";
        public static string settingsPath = folderPath + "settings.ini";
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParentalControl());
        }
    }
}
