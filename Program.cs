using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace ScreenClock
{
    internal static class Program
    {
        internal static Form FormMain;
        
        


        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain = new WinMain();
            Application.Run(FormMain);
        }
    }
}
