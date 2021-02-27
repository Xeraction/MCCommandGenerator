using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MCCommandGenerator.util
{
    public static class SetIcon
    {
        public static void addIcon()
        {
            if (!File.Exists("/resources/icon.ico"))
            {
                try
                {
                    Directory.CreateDirectory("resources");
                    var client = new WebClient();
                    client.DownloadFile("http://xeraction.7m.pl/mccg/icon.ico", "resources/icon.ico");
                }
                catch
                {
                    MessageBox.Show("Couldn't set the icon because of missing internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
