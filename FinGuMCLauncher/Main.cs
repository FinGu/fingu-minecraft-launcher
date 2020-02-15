using CmlLib.Launcher;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Utils;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Security;
using System.Collections;

namespace FinGuMCLauncher
{
    public partial class Main : MaterialForm
    {
        [DllImport("user32.dll")]
        static public extern bool ShowScrollBar(System.IntPtr hWnd, int wBar, bool bShow);

        private const uint SB_HORZ = 0;

        private const uint SB_VERT = 1;

        private const uint ESB_DISABLE_BOTH = 0x3;

        private const uint ESB_ENABLE_BOTH = 0x0;

        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            VersionListView.Scrollable = false;
            ShowScrollBar(VersionListView.Handle, (int)SB_VERT, true);

            if (!File.Exists("config.json"))
                ConfigSystem.Create();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            JavaPath.Text = "javaw.exe";
            RAMAmmount.Text = "1024";
            MCPath.Text = Environment.GetEnvironmentVariable("APPDATA") + "\\.minecraft";
            LoadProfiles();
            materialLabel9.Text = API.version;
            LogS.Text = API.Logs();
            if (!Login.Offline)
            {
                var session = Login.login.GetLocalToken();
                user.Text = session.Username;
            }
            else
            {
                user.Text = Login.offUser;
            }
        }

        private void LoadProfiles()
        {
            Minecraft.Initialize(MCPath.Text);
            MProfileInfo[] versions = MProfileInfo.GetProfiles();
            foreach (var item in versions)
            {
                if (item.Type == "release" || MProfileTypeConverter.FromString(item.Type) == MProfileType.Custom)
                {
                    var toAdd = new ListViewItem(item.Name);
                    VersionListView.Items.Add(toAdd);
                }
            }
        }

        private void Start()
        {
            Minecraft.Initialize(MCPath.Text);
            var th = new Thread(new ThreadStart(delegate
            {
                if (Vers.Text != "Vers")
                {
                    MProfileInfo[] versions = MProfileInfo.GetProfiles();
                    MProfile profile = MProfile.FindProfile(versions, Vers.Text);

                    DownloadGame(profile);

                    MLaunchOption option = new MLaunchOption()
                    {
                        StartProfile = profile,
                        LauncherName = "FinGuMCLauncher",
                        JavaPath = JavaPath.Text,
                        MaximumRamMb = Convert.ToInt32(RAMAmmount.Text),
                        Session = Login.session
                    };

                    MLaunch launch = new MLaunch(option);
                    launch.GetProcess().Start();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Select a version first!", "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
            th.Start();
        }

        private void DownloadGame(MProfile profile)
        {
            MDownloader downloader = new MDownloader(profile);
            downloader.ChangeProgress += downloadworker_ProgressChanged;
            downloader.ChangeFile += downloadworker_ChangeFile;
            downloader.DownloadAll();
        }

        private void VersionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchVersions_TextChanged_1(object sender, EventArgs e)
        {
            if (SearchVersions.Text != "")
            {
                for (int i = VersionListView.Items.Count - 1; i >= 0; i--)
                {
                    var item = VersionListView.Items[i];
                    if (item.Text.ToLower().Contains(SearchVersions.Text.ToLower()))
                    {

                    }
                    else
                    {
                        VersionListView.Items.Remove(item);
                    }
                }
                if (VersionListView.SelectedItems.Count == 1)
                {
                    VersionListView.Focus();
                }
            }
            else
                LoadProfiles();
        }

        private void VersionListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int i = VersionListView.FocusedItem.Index;
                Vers.Text = VersionListView.Items[i].SubItems[0].Text;
                materialLabel6.Text = VersionListView.Items[i].SubItems[0].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InstalleLaunch_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void downloadworker_ChangeFile(DownloadFileChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                Data.Text = e.FileKind.ToString() + " : " + e.FileName;
            });
        }

        private void downloadworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                DownloadProgressBar.Value = e.ProgressPercentage;
            });
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ConfigSystem load = ConfigSystem.Load();
            Vers.Text = load.Version;
            MCPath.Text = load.MCPath;
            JavaPath.Text = load.JavaPath;
            RAMAmmount.Text = load.MaxRam;
        }

        private void SaveCFG_Click(object sender, EventArgs e)
        {
            ConfigSystem load = ConfigSystem.Load();
            load.Version = Vers.Text;
            load.MCPath = MCPath.Text;
            load.JavaPath = JavaPath.Text;
            load.MaxRam = RAMAmmount.Text;
            load.Save();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login.login.DeleteTokenFile();
            new Login().Show();
            this.Hide();
        }
        private void VersionListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }
    }
    class ListViewAutoSorter : System.Collections.IComparer
    {
        private int Column = 0;
        private System.Windows.Forms.SortOrder Order = SortOrder.Ascending;

        public ListViewAutoSorter(int Column, SortOrder Order)
        {
            this.Column = Column;
            this.Order = Order;
        }

        public int Compare(object x, object y) // IComparer Member
        {
            if (!(x is ListViewItem))
                return (0);
            if (!(y is ListViewItem))
                return (0);

            var l1 = (ListViewItem)x;
            var l2 = (ListViewItem)y;

            var value1 = 0.0;
            var value2 = 0.0;

            if (Double.TryParse(l1.SubItems[Column].Text, out value1) &&
                Double.TryParse(l2.SubItems[Column].Text, out value2))
            {
                if (Order == SortOrder.Ascending)
                {
                    return value1.CompareTo(value2);
                }
                else
                {
                    return value2.CompareTo(value1);
                }
            }
            else
            {
                var str1 = l1.SubItems[Column].Text;
                var str2 = l2.SubItems[Column].Text;

                if (Order == SortOrder.Ascending)
                {
                    return str1.CompareTo(str2);
                }
                else
                {
                    return str2.CompareTo(str1);
                }
            }
        }
    }

}

