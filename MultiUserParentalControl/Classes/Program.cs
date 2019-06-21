using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiUserParentalControl
{
    [Serializable]
    public struct SaveData
    {
        public int sessionLimit;
        public string passCode;
    }
    public class ProgramData
    {
        public static DateTime startTime = DateTime.Now;
        // folder path depends on environment but is typically c:\programdata\MultiUserParentalControl\MultiuserParentalControl\
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
            Application.Run(new MultiUserParentalControl());
        }
    }
}
