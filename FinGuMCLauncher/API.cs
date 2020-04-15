using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace FinGuMCLauncher
{
    class API
    {
        private static string APILink = "your api link, if you dont want the api, remove by yourself";
        public static string version = "1.3";
        public static void VersionCheck() {
            if (new WebClient().DownloadString(APILink + "?vc") != version) {
                MessageBox.Show("Outdated Version!, Please download the newest one", "FinGuMCLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public static string Logs() => new WebClient().DownloadString(APILink + "?lg");
    }
}
