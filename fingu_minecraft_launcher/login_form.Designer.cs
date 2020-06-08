namespace fingu_minecraft_launcher
{
    partial class login_form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.login_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.offline_mode = new MaterialSkin.Controls.MaterialCheckBox();
            this.user_o_mail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.AutoSize = true;
            this.login_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_button.Depth = 0;
            this.login_button.Icon = null;
            this.login_button.Location = new System.Drawing.Point(224, 180);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.Primary = true;
            this.login_button.Size = new System.Drawing.Size(61, 36);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login     ";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_click);
            // 
            // offline_mode
            // 
            this.offline_mode.AutoSize = true;
            this.offline_mode.Depth = 0;
            this.offline_mode.Font = new System.Drawing.Font("Roboto", 10F);
            this.offline_mode.Location = new System.Drawing.Point(31, 184);
            this.offline_mode.Margin = new System.Windows.Forms.Padding(0);
            this.offline_mode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.offline_mode.MouseState = MaterialSkin.MouseState.HOVER;
            this.offline_mode.Name = "offline_mode";
            this.offline_mode.Ripple = true;
            this.offline_mode.Size = new System.Drawing.Size(110, 30);
            this.offline_mode.TabIndex = 1;
            this.offline_mode.Text = "Offline Mode";
            this.offline_mode.UseVisualStyleBackColor = true;
            this.offline_mode.CheckedChanged += new System.EventHandler(this.offline_mode_cc);
            // 
            // user_o_mail
            // 
            this.user_o_mail.Depth = 0;
            this.user_o_mail.Hint = "email";
            this.user_o_mail.Location = new System.Drawing.Point(31, 89);
            this.user_o_mail.MaxLength = 32767;
            this.user_o_mail.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_o_mail.Name = "user_o_mail";
            this.user_o_mail.PasswordChar = '\0';
            this.user_o_mail.SelectedText = "";
            this.user_o_mail.SelectionLength = 0;
            this.user_o_mail.SelectionStart = 0;
            this.user_o_mail.Size = new System.Drawing.Size(278, 23);
            this.user_o_mail.TabIndex = 2;
            this.user_o_mail.TabStop = false;
            this.user_o_mail.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "password";
            this.password.Location = new System.Drawing.Point(31, 139);
            this.password.MaxLength = 32767;
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(278, 23);
            this.password.TabIndex = 3;
            this.password.TabStop = false;
            this.password.UseSystemPasswordChar = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 256);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_o_mail);
            this.Controls.Add(this.offline_mode);
            this.Controls.Add(this.login_button);
            this.Name = "login_form";
            this.Text = "login form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.login_load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MaterialSkin.Controls.MaterialRaisedButton login_button;
        private MaterialSkin.Controls.MaterialCheckBox offline_mode;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialSingleLineTextField user_o_mail;

        #endregion
    }
}

