using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCommandGenerator
{
    static class Program
    {
        public static string Version = "EarlyAlpha-0.3";
        public static bool IsDownloading = false;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Update.CheckForUpdates();
            if (!IsDownloading) Application.Run(new Form1());
        }
    }
}
