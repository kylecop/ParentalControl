using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl
{
    class WindowsCommandOverrides
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public static bool WindowsLogOff()
        {
            return ExitWindowsEx(0 | 0x00000004, 0);
        }
    }
}
