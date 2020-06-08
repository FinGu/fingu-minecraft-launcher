using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace fingu_minecraft_launcher
{
    class api
    {
        private static string api_link = "your api link, if you dont want the api, remove by yourself";
        public static string version = "1.4";
        
        public static void version_check() {
            if (new WebClient().DownloadString(api_link + "?vc") != version) {
                MessageBox.Show("Outdated Version!, Please download the newest one", "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public static string logs() => new WebClient().DownloadString(api_link + "?lg");
    }
}
