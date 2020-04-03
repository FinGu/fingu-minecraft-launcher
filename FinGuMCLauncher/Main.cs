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
using System.Net;

namespace FinGuMCLauncher
{
    public partial class Main : MaterialForm
    {
        #region Imports
        [DllImport("user32.dll")]
        static public extern bool ShowScrollBar(System.IntPtr hWnd, int wBar, bool bShow);

        private const uint SB_HORZ = 0;

        private const uint SB_VERT = 1;

        private const uint ESB_DISABLE_BOTH = 0x3;

        private const uint ESB_ENABLE_BOTH = 0x0;
        #endregion
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            VersionListView.Scrollable = false;
            ShowScrollBar(VersionListView.Handle, (int)SB_VERT, true);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config.json")) {
                ConfigSystem.Create();
                ConfigSystem load = ConfigSystem.Load();

                MCPath.Text = load.MCPath;
                JavaPath.Text = load.JavaPath;
                RAMAmmount.Text = load.MaxRam;
            }

            LoadProfiles();

            if (!File.Exists(MCPath.Text + "\\launcher_profiles.json"))
                File.WriteAllText(MCPath.Text + "\\launcher_profiles.json", new WebClient().DownloadString("https://launchermeta.mojang.com/mc/game/version_manifest.json"));

            version_label.Text = API.version;
            LogS.Text = API.Logs();

            if (!Login.offline) {
                var session = Login.login.GetLocalToken();
                user.Text = session.Username;
            }
            else {
                user.Text = Login.offline_user;
            }
        }

        private void LoadProfiles() {
            Minecraft.Initialize(MCPath.Text);
            MProfileInfo[] versions = MProfileInfo.GetProfiles();

            VersionListView.Items.Clear();

            foreach (var item in versions) {
                if (MProfileTypeConverter.FromString(item.Type) == MProfileType.Release || MProfileTypeConverter.FromString(item.Type) == MProfileType.Custom) {
                    var toAdd = new ListViewItem(item.Name);
                    VersionListView.Items.Add(toAdd);
                }
            }
        }

        private void Start() {
            Minecraft.Initialize(MCPath.Text);
            var th = new Thread(new ThreadStart(delegate {
                if (Vers.Text != "Vers") {
                    MProfileInfo[] versions = MProfileInfo.GetProfiles();
                    MProfile profile = MProfile.FindProfile(versions, Vers.Text);

                    DownloadGame(profile);

                    MLaunchOption option = new MLaunchOption() {
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
                else {
                    MessageBox.Show("Select a version first!", "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
            th.Start();
        }

        private void DownloadGame(MProfile profile) {
            MDownloader downloader = new MDownloader(profile);
            downloader.ChangeProgress += downloadworker_ProgressChanged;
            downloader.ChangeFile += downloadworker_ChangeFile;
            downloader.DownloadAll();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void SearchVersions_TextChanged_1(object sender, EventArgs e) {
            try {
                if (SearchVersions.Text != "") {
                    for (int i = VersionListView.Items.Count - 1;i >= 0;i--) {
                        var item = VersionListView.Items[i];
                        if (!item.Text.ToLower().Contains(SearchVersions.Text.ToLower())) {
                            VersionListView.Items.Remove(item);
                        }
                    }
                    if (VersionListView.SelectedItems.Count == 1) {
                        VersionListView.Focus();
                    }
                }
                else {
                    LoadProfiles();
                }
            }
            catch { }
        }

        private void VersionListView_SelectedIndexChanged_1(object sender, EventArgs e) {
            try {
                int i = VersionListView.FocusedItem.Index;
                Vers.Text = VersionListView.Items[i].SubItems[0].Text;
                materialLabel6.Text = VersionListView.Items[i].SubItems[0].Text;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InstalleLaunch_Click(object sender, EventArgs e) =>
            Start();

        private void downloadworker_ChangeFile(DownloadFileChangedEventArgs e) {
            Invoke((MethodInvoker)delegate {
                Data.Text = e.FileKind.ToString() + " : " + e.FileName;
            });
        }

        private void downloadworker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            Invoke((MethodInvoker)delegate {
                DownloadProgressBar.Value = e.ProgressPercentage;
            });
        }

        private void LoadCFG_Click(object sender, EventArgs e) {
            ConfigSystem load = ConfigSystem.Load();

            Vers.Text = load.Version;
            MCPath.Text = load.MCPath;
            JavaPath.Text = load.JavaPath;
            RAMAmmount.Text = load.MaxRam;

            LoadProfiles();
        }

        private void SaveCFG_Click(object sender, EventArgs e) {
            ConfigSystem load = ConfigSystem.Load();

            load.Version = Vers.Text;
            load.MCPath = MCPath.Text;
            load.JavaPath = JavaPath.Text;
            load.MaxRam = RAMAmmount.Text;

            load.Save();
            LoadProfiles();
        }

        private void Logout_Click(object sender, EventArgs e) {
            Login.login.DeleteTokenFile();
            new Login().Show();
            this.Hide();
        }
    }
}

