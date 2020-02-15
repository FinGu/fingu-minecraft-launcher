namespace FinGuMCLauncher
{
    partial class Login
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
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OfflineMode = new MaterialSkin.Controls.MaterialCheckBox();
            this.UserOMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(224, 180);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(61, 36);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login     ";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // OfflineMode
            // 
            this.OfflineMode.AutoSize = true;
            this.OfflineMode.Depth = 0;
            this.OfflineMode.Font = new System.Drawing.Font("Roboto", 10F);
            this.OfflineMode.Location = new System.Drawing.Point(31, 184);
            this.OfflineMode.Margin = new System.Windows.Forms.Padding(0);
            this.OfflineMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OfflineMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.OfflineMode.Name = "OfflineMode";
            this.OfflineMode.Ripple = true;
            this.OfflineMode.Size = new System.Drawing.Size(110, 30);
            this.OfflineMode.TabIndex = 1;
            this.OfflineMode.Text = "Offline Mode";
            this.OfflineMode.UseVisualStyleBackColor = true;
            this.OfflineMode.CheckedChanged += new System.EventHandler(this.OfflineMode_CheckedChanged);
            // 
            // UserOMail
            // 
            this.UserOMail.Depth = 0;
            this.UserOMail.Hint = "Email";
            this.UserOMail.Location = new System.Drawing.Point(31, 89);
            this.UserOMail.MaxLength = 32767;
            this.UserOMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserOMail.Name = "UserOMail";
            this.UserOMail.PasswordChar = '\0';
            this.UserOMail.SelectedText = "";
            this.UserOMail.SelectionLength = 0;
            this.UserOMail.SelectionStart = 0;
            this.UserOMail.Size = new System.Drawing.Size(278, 23);
            this.UserOMail.TabIndex = 2;
            this.UserOMail.TabStop = false;
            this.UserOMail.UseSystemPasswordChar = false;
            // 
            // Password
            // 
            this.Password.Depth = 0;
            this.Password.Hint = "Password";
            this.Password.Location = new System.Drawing.Point(31, 139);
            this.Password.MaxLength = 32767;
            this.Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(278, 23);
            this.Password.TabIndex = 3;
            this.Password.TabStop = false;
            this.Password.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 256);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserOMail);
            this.Controls.Add(this.OfflineMode);
            this.Controls.Add(this.LoginButton);
            this.Name = "Login";
            this.Text = "Login Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
        private MaterialSkin.Controls.MaterialCheckBox OfflineMode;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserOMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password;
    }
}

