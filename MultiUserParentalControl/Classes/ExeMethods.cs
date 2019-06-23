using MultiUserParentalControl.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl
{
    class ExeMethods
    {
        static public bool payForExe(int numCoins, int numCoinsRequired, int sessionLimit)
        {
            bool result = false;
            if (numCoins >= numCoinsRequired)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to pay " + numCoinsRequired.ToString() + " to play?", "Pay To Play", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ProgramData.startTime.AddMinutes(sessionLimit - (sessionLimit * .4)) < DateTime.Now) // do not play
                    {
                        result = false;
                        DialogResult dialogResult2 = MessageBox.Show("You do not have enough time to play, do you want to play anyway?", "Pay To Play", MessageBoxButtons.YesNo);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            result = true;
                        }
                        else if (dialogResult2 == DialogResult.No)
                        {
                            result = false;
                        }
                    }
                    else // ok play
                    {
                        result = true;
                    }
                    //do something
                }
                else if (dialogResult == DialogResult.No)
                {
                    result = false;
                    //do something else
                }
            }
            else
                MessageBox.Show("You do not have enough coins to play. You need to earn " + (numCoinsRequired - numCoins).ToString() + " more coins.");

            if(result)
                CoinMethods.decreaseCoinsForExe(numCoins, numCoinsRequired);

            return result;
        }

        static public void checkForAndKillProcess(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                try
                {
                    process.Kill();
                    process.Kill();
                    process.Kill();
                }
                catch { }

                Notify formNotify = new Notify();
                formNotify.Show();
            }
        }
    }
}
