using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
//other includes ⬇️
using CmlLib.Launcher;
using MaterialSkin;
using MaterialSkin.Controls;

namespace fingu_minecraft_launcher
{
    public partial class main_form : MaterialForm
    {
        #region imports
        [DllImport("user32.dll")]
        static public extern bool ShowScrollBar(System.IntPtr hWnd, int wBar, bool bShow);

        private const uint SB_VERT = 1;
        #endregion
        
        public main_form()
        {
            InitializeComponent();
            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;

            version_list_view.Scrollable = false;
            ShowScrollBar(version_list_view.Handle, (int)SB_VERT, true);
        }

        private void main_load(object sender, EventArgs e)
        {
            if (!File.Exists("config.json")) { //default config check and creating
                config_system.create();
                config_system load = config_system.load();

                mc_path.Text = load.mc_path;
                java_path.Text = load.mc_path;
                ram_amount.Text = load.max_ram;
            }

            load_profiles(); //profile loading

            config_system cfg = config_system.load();

            if (!File.Exists(cfg.mc_path + "\\launcher_profiles.json")) { //check to make people be able to install forge
                File.WriteAllText(cfg.mc_path + "\\launcher_profiles.json", new WebClient().DownloadString("https://launchermeta.mojang.com/mc/game/version_manifest.json"));
            }

            version_label.Text = api.version;
            LogS.Text = api.logs();

            if (!login_form.offline) {
                var session = login_form.login.GetLocalToken();
                user.Text = session.Username;
            }
            else {
                user.Text = login_form.offline_user;
            }
        }

        private void load_profiles() {
            Minecraft.Initialize(mc_path.Text);
            MProfileInfo[] versions = MProfileInfo.GetProfiles();

            version_list_view.Items.Clear();

            foreach (var item in versions) {
                if (MProfileTypeConverter.FromString(item.Type) == MProfileType.Release || MProfileTypeConverter.FromString(item.Type) == MProfileType.Custom) { //if you want more versions, edit this part here
                    var toAdd = new ListViewItem(item.Name);
                    version_list_view.Items.Add(toAdd);
                }
            }
        }

        private void start_mc() {
            Minecraft.Initialize(mc_path.Text);
            var th = new Thread(new ThreadStart(delegate {
                if (vers.Text != "Vers") {
                    MProfileInfo[] versions = MProfileInfo.GetProfiles();
                    MProfile profile = MProfile.FindProfile(versions, vers.Text);

                    download_game(profile);

                    MLaunchOption option = new MLaunchOption() {
                        StartProfile = profile,
                        LauncherName = "fingu_minecraft_launcher",
                        JavaPath = java_path.Text,
                        MaximumRamMb = Convert.ToInt32(ram_amount.Text),
                        Session = login_form.session
                    };

                    MLaunch launch = new MLaunch(option);
                    launch.GetProcess().Start();
                    Application.Exit();
                }
                else {
                    MessageBox.Show("Select a version first!", "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
            th.Start();
        }

        private void download_game(MProfile profile) {
            MDownloader downloader = new MDownloader(profile);
            downloader.ChangeProgress += download_display_progress_changed;
            downloader.ChangeFile += download_display_change_file;
            downloader.DownloadAll();
        }

        private void main_form_closed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void search_versions_text_changed(object sender, EventArgs e) {
            try {
                if (search_versions.Text != "") {
                    for (int i = version_list_view.Items.Count - 1;i >= 0;i--) {
                        var item = version_list_view.Items[i];
                        if (!item.Text.ToLower().Contains(search_versions.Text.ToLower())) {
                            version_list_view.Items.Remove(item);
                        }
                    }
                    if (version_list_view.SelectedItems.Count == 1) {
                        version_list_view.Focus();
                    }
                }
                else {
                    load_profiles();
                }
            }
            catch { }
        }

        private void version_list_view_sic(object sender, EventArgs e) {
            try {
                int i = version_list_view.FocusedItem.Index;
                vers.Text = version_list_view.Items[i].SubItems[0].Text;
                ver_label.Text = version_list_view.Items[i].SubItems[0].Text;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void install_and_launch_click(object sender, EventArgs e) =>
            start_mc();

        private void download_display_change_file(DownloadFileChangedEventArgs e) {
            Invoke((MethodInvoker)delegate {
                data_label.Text = e.FileKind.ToString() + " : " + e.FileName;
            });
        }

        private void download_display_progress_changed(object sender, ProgressChangedEventArgs e) {
            Invoke((MethodInvoker)delegate {
                DownloadProgressBar.Value = e.ProgressPercentage;
            });
        }

        private void load_cfg_click(object sender, EventArgs e) {
            config_system load = config_system.load();

            vers.Text = load.version;
            mc_path.Text = load.mc_path;
            java_path.Text = load.java_path;
            ram_amount.Text = load.max_ram;

            load_profiles();
        }

        private void save_cfg_click(object sender, EventArgs e) {
            config_system load = config_system.load();

            load.version = vers.Text;
            load.mc_path = mc_path.Text;
            load.java_path = java_path.Text;
            load.max_ram = ram_amount.Text;

            load.save();
            
            load_profiles();
        }

        private void logout_click(object sender, EventArgs e) {
            login_form.login.DeleteTokenFile();
            
            new login_form().Show();
            this.Hide();
        }
    }
}
