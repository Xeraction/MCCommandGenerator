using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace MCCommandGenerator
{
    public static class Update
    {
        public static bool CheckConnection()
        {
            try
            {
                var client = new WebClient();
                client.OpenRead("http://google.com/generate_204");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void CheckForUpdates()
        {
            if (CheckConnection())
            {
                try
                {
                    var client = new WebClient();
                    string ver = client.DownloadString("http://xeraction.7m.pl/mccg/currentVersion.txt");
                    if (Program.Version != ver)
                    {
                        DialogResult result = MessageBox.Show("A new version of this program is available. Do you want to download it now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                string download = client.DownloadString("http://xeraction.7m.pl/mccg/downloadNewVersion.txt");
                                Process.Start(download);
                                Program.IsDownloading = true;
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Error: Could not open the download page. (" + e.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Program.IsDownloading = false;
                            }
                        }
                    }
                }
                catch { }
            }
        }
    }
}
