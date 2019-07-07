using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl
{
    class CoinMethods
    {

        public static int getCoins(string userName)
        {
            int userCoins = 0;
            try
            {
                //string fileName = @"c:\\" + Environment.UserName.ToString() + "AppsRequiringCoins.txt";
                string fileName = "C:\\Program Files (x86)\\EasyBits For Kids\\_Users.dat";
                string fileLine;
                if (File.Exists(fileName))
                {
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader file = new StreamReader(fs);

                    //file = new StreamReader(fileName);
                    try
                    {
                        while ((fileLine = file.ReadLine()) != null)
                        {
                            string[] fileLine2 = fileLine.Split('=');
                            if (fileLine2[0].ToString() == "UserName")
                            {
                                if (fileLine2[1].ToString() == userName)
                                {
                                    while (!(fileLine = file.ReadLine()).StartsWith("["))
                                    {
                                        string[] fileLine4 = fileLine.Split('=');
                                        if (fileLine4[0].ToString() == "Bonus")
                                            int.TryParse(fileLine4[1], out userCoins);
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                    file.Close();
                }
            }
            catch { }
            return userCoins;
        }
        public static void setCoins(string userName, int newNumOfCoins)
        {
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines(@"C:\\Program Files (x86)\\EasyBits For Kids\\_Users.dat");


            try
            {
                for(int i = 0; i < file.Length; i++)
                {
                    string line = file[i];
                    if (line.Contains("UserName"))
                    {
                        newFile.Append(line + "\n");
                        string[] fileLine2 = line.Split('=');
                        if (fileLine2[1].ToString() == userName)
                        {
                            int j = i;
                            for(j = i; j < file.Length; j++)
                            {
                                line = file[j];
                                if ((line.StartsWith("[")))
                                {
                                    j--;
                                    break;
                                }

                                string[] fileLine4 = line.Split('=');
                                if (fileLine4[0].ToString() == "Bonus")
                                {
                                    Int32.TryParse(fileLine4[1], out int numCoins);
                                    temp = line.Replace(line, "Bonus=" + newNumOfCoins.ToString());

                                    newFile.Append(temp + "\n");
                                }
                                else if(fileLine4[0].ToString() != "UserName")
                                    newFile.Append(line + "\n" );
                            }
                            i = j;
                        }
                    }
                    else
                    {
                        newFile.Append(line + "\n");
                    }
                }
            }
            catch { }

            //MessageBox.Show(newFile.ToString());
            File.WriteAllText(@"C:\\Program Files (x86)\\EasyBits For Kids\\_Users.dat", newFile.ToString());
        }
        public static void decreaseCoinsForExe(int numCoins, int numCoinsRequired)
        {
            //SqlMethods.writeToPointsLog("has spent " + numCoinsRequired.ToString() + " coins.");
            setCoins(Environment.UserName, numCoins - numCoinsRequired);
        }
    }
}
