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
            if (!File.Exists("C:/ProgramData/MCCG"))
            {
                try
                {
                    try
                    {
                        Directory.CreateDirectory("C:/ProgramData/MCCG");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Couldn't create program folder. (" + e.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                    var client = new WebClient();
                    client.DownloadFile("http://xeraction.7m.pl/mccg/icon.ico", "C:/ProgramData/MCCG/icon.ico");
                }
                catch
                {
                    MessageBox.Show("Couldn't set the icon because of missing internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }
            }
        }
    }
}
