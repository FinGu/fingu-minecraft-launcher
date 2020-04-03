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

namespace FinGuMCLauncher
{
    public partial class Login : MaterialForm
    {
        #region Globals
        public static MSession session = null;
        public static MLogin login = new MLogin();
        public static bool offline { get; set; }
        public static string offline_user { get; set; }
        #endregion

        public Login() {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            if (OfflineMode.Checked) {
                if (UserOMail.Text != "") {
                    offline = true;
                    session = MSession.GetOfflineSession(UserOMail.Text);

                    if (session.Result == MLoginResult.Success) {
                        offline_user = UserOMail.Text;

                        new Main().Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Failed to login : " + session.Result.ToString(), "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Username/Email is null!!", "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                offline = false;
                session = login.TryAutoLogin();

                if (session.Result != MLoginResult.Success) {
                    session = login.Authenticate(UserOMail.Text, Password.Text);

                    if (session.Result == MLoginResult.Success) {
                        MessageBox.Show("Logged in Successfuly", "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        new Main().Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Failed to login : " + session.Result.ToString(), "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    new Main().Show();
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e) {
            try {
                API.VersionCheck();
            }
            catch {
                MessageBox.Show("Setup the API!!", "FinGuLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void OfflineMode_CheckedChanged(object sender, EventArgs e) {
            if (OfflineMode.Checked) {
                offline = true;

                UserOMail.Hint = "Username";
                Password.Enabled = false;
            }
            else {
                offline = false;

                UserOMail.Hint = "Email";
                Password.Enabled = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();
    }
}
