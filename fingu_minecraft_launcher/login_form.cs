using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Launcher;
using System.Threading;

namespace fingu_minecraft_launcher
{
    public partial class login_form : MaterialForm
    {
        #region globals
        public static MSession session = null;
        public static MLogin login = new MLogin();
        public static bool offline { get; set; }
        public static string offline_user { get; set; }
        #endregion

        public login_form() {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void show_main_form() {
            new main_form().Show();
            this.Hide();
        }

        private void login_button_click(object sender, EventArgs e) {
            if (offline_mode.Checked) {
                if (user_o_mail.Text != "") {
                    offline = true;
                    session = MSession.GetOfflineSession(user_o_mail.Text);

                    if (session.Result == MLoginResult.Success) {
                        offline_user = user_o_mail.Text;
                        
                        show_main_form();
                    }
                    else {
                        MessageBox.Show("Failed to login : " + session.Result.ToString(), "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Username/Email is null!!", "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                offline = false;
                session = login.TryAutoLogin();

                if (session.Result != MLoginResult.Success) {
                    session = login.Authenticate(user_o_mail.Text, password.Text);

                    if (session.Result == MLoginResult.Success) {
                        MessageBox.Show("Logged in Successfuly", "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        show_main_form();
                    }
                    else {
                        MessageBox.Show("Failed to login : " + session.Result.ToString(), "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Session already exists, redirecting..", "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    show_main_form();
                }
            }
        }

        private void login_load(object sender, EventArgs e) {
            try {
                api.version_check();
            }
            catch {
                MessageBox.Show("Setup the API!!", "fingu_minecraft_launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void offline_mode_cc(object sender, EventArgs e) {
            if (offline_mode.Checked) {
                offline = true;

                user_o_mail.Hint = "username";
                password.Enabled = false;
            }
            else {
                offline = false;

                user_o_mail.Hint = "email";
                password.Enabled = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();
    }
}
