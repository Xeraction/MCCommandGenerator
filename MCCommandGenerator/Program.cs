using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCCommandGenerator.util;

namespace MCCommandGenerator
{
    static class Program
    {
        public static string Version = "EarlyAlpha-0.4";
        public static bool IsDownloading = false;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Update.CheckForUpdates();
            if (!IsDownloading)
            {
                SetIcon.addIcon();
                Application.Run(new Form1());
            }
        }
    }
}
