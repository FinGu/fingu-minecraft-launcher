namespace fingu_minecraft_launcher
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.version_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.user = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.log_box = new System.Windows.Forms.GroupBox();
            this.LogS = new System.Windows.Forms.Label();
            this.data_label = new MaterialSkin.Controls.MaterialLabel();
            this.ver_label = new MaterialSkin.Controls.MaterialLabel();
            this.install_and_launch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DownloadProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.logout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.load_cfg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.save_cfg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mc_path = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.vers = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.java_path = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ram_amount = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.search_versions = new System.Windows.Forms.TextBox();
            this.version_list_view = new MaterialSkin.Controls.MaterialListView();
            this.Versions = new System.Windows.Forms.ColumnHeader();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.download_display = new System.ComponentModel.BackgroundWorker();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.log_box.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Location = new System.Drawing.Point(0, 109);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(637, 326);
            this.MainTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.version_label);
            this.tabPage1.Controls.Add(this.materialLabel8);
            this.tabPage1.Controls.Add(this.user);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.log_box);
            this.tabPage1.Controls.Add(this.data_label);
            this.tabPage1.Controls.Add(this.ver_label);
            this.tabPage1.Controls.Add(this.install_and_launch);
            this.tabPage1.Controls.Add(this.DownloadProgressBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Depth = 0;
            this.version_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.version_label.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.version_label.Location = new System.Drawing.Point(583, 282);
            this.version_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(17, 19);
            this.version_label.TabIndex = 10;
            this.version_label.Text = "n";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel8.Location = new System.Drawing.Point(453, 281);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(134, 19);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "Launcher Version :";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Depth = 0;
            this.user.Font = new System.Drawing.Font("Roboto", 11F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.user.Location = new System.Drawing.Point(85, 282);
            this.user.MouseState = MaterialSkin.MouseState.HOVER;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(38, 19);
            this.user.TabIndex = 8;
            this.user.Text = "user";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel7.Location = new System.Drawing.Point(8, 282);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(80, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Welcome :";
            // 
            // log_box
            // 
            this.log_box.Controls.Add(this.LogS);
            this.log_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.log_box.Location = new System.Drawing.Point(156, 23);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(303, 154);
            this.log_box.TabIndex = 6;
            this.log_box.TabStop = false;
            this.log_box.Text = "Logs";
            // 
            // LogS
            // 
            this.LogS.AutoSize = true;
            this.LogS.BackColor = System.Drawing.Color.Transparent;
            this.LogS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogS.Location = new System.Drawing.Point(7, 20);
            this.LogS.Name = "LogS";
            this.LogS.Size = new System.Drawing.Size(30, 13);
            this.LogS.TabIndex = 0;
            this.LogS.Text = "Logs";
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Depth = 0;
            this.data_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.data_label.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.data_label.Location = new System.Drawing.Point(152, 206);
            this.data_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(40, 19);
            this.data_label.TabIndex = 5;
            this.data_label.Text = "Data";
            // 
            // ver_label
            // 
            this.ver_label.AutoSize = true;
            this.ver_label.Depth = 0;
            this.ver_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.ver_label.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.ver_label.Location = new System.Drawing.Point(398, 206);
            this.ver_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.ver_label.Name = "ver_label";
            this.ver_label.Size = new System.Drawing.Size(61, 19);
            this.ver_label.TabIndex = 3;
            this.ver_label.Text = "Version";
            // 
            // install_and_launch
            // 
            this.install_and_launch.AutoSize = true;
            this.install_and_launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.install_and_launch.Depth = 0;
            this.install_and_launch.Icon = null;
            this.install_and_launch.Location = new System.Drawing.Point(270, 239);
            this.install_and_launch.MouseState = MaterialSkin.MouseState.HOVER;
            this.install_and_launch.Name = "install_and_launch";
            this.install_and_launch.Primary = true;
            this.install_and_launch.Size = new System.Drawing.Size(75, 36);
            this.install_and_launch.TabIndex = 1;
            this.install_and_launch.Text = "Launch";
            this.install_and_launch.UseVisualStyleBackColor = true;
            this.install_and_launch.Click += new System.EventHandler(this.install_and_launch_click);
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Depth = 0;
            this.DownloadProgressBar.Location = new System.Drawing.Point(156, 228);
            this.DownloadProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(303, 5);
            this.DownloadProgressBar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.logout);
            this.tabPage3.Controls.Add(this.load_cfg);
            this.tabPage3.Controls.Add(this.save_cfg);
            this.tabPage3.Controls.Add(this.mc_path);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.vers);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.java_path);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.ram_amount);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.search_versions);
            this.tabPage3.Controls.Add(this.version_list_view);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(629, 300);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logout.Depth = 0;
            this.logout.Icon = null;
            this.logout.Location = new System.Drawing.Point(403, 264);
            this.logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.logout.Name = "logout";
            this.logout.Primary = true;
            this.logout.Size = new System.Drawing.Size(74, 36);
            this.logout.TabIndex = 13;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_click);
            // 
            // load_cfg
            // 
            this.load_cfg.AutoSize = true;
            this.load_cfg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.load_cfg.Depth = 0;
            this.load_cfg.Icon = null;
            this.load_cfg.Location = new System.Drawing.Point(357, 219);
            this.load_cfg.MouseState = MaterialSkin.MouseState.HOVER;
            this.load_cfg.Name = "load_cfg";
            this.load_cfg.Primary = true;
            this.load_cfg.Size = new System.Drawing.Size(88, 36);
            this.load_cfg.TabIndex = 12;
            this.load_cfg.Text = "load_cfg";
            this.load_cfg.UseVisualStyleBackColor = true;
            this.load_cfg.Click += new System.EventHandler(this.load_cfg_click);
            // 
            // save_cfg
            // 
            this.save_cfg.AutoSize = true;
            this.save_cfg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_cfg.Depth = 0;
            this.save_cfg.Icon = null;
            this.save_cfg.Location = new System.Drawing.Point(461, 219);
            this.save_cfg.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_cfg.Name = "save_cfg";
            this.save_cfg.Primary = true;
            this.save_cfg.Size = new System.Drawing.Size(87, 36);
            this.save_cfg.TabIndex = 11;
            this.save_cfg.Text = "save_cfg";
            this.save_cfg.UseVisualStyleBackColor = true;
            this.save_cfg.Click += new System.EventHandler(this.save_cfg_click);
            // 
            // mc_path
            // 
            this.mc_path.Location = new System.Drawing.Point(374, 160);
            this.mc_path.Name = "mc_path";
            this.mc_path.Size = new System.Drawing.Size(192, 20);
            this.mc_path.TabIndex = 10;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel5.Location = new System.Drawing.Point(346, 138);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(115, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Minecraft Path :";
            // 
            // vers
            // 
            this.vers.AutoSize = true;
            this.vers.Depth = 0;
            this.vers.Font = new System.Drawing.Font("Roboto", 11F);
            this.vers.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.vers.Location = new System.Drawing.Point(483, 183);
            this.vers.MouseState = MaterialSkin.MouseState.HOVER;
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(40, 19);
            this.vers.TabIndex = 8;
            this.vers.Text = "Vers";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel4.Location = new System.Drawing.Point(346, 183);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(131, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Selected Version :";
            // 
            // java_path
            // 
            this.java_path.Location = new System.Drawing.Point(374, 115);
            this.java_path.Name = "java_path";
            this.java_path.Size = new System.Drawing.Size(192, 20);
            this.java_path.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel3.Location = new System.Drawing.Point(346, 93);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Java Path :";
            // 
            // ram_amount
            // 
            this.ram_amount.Location = new System.Drawing.Point(374, 70);
            this.ram_amount.Name = "ram_amount";
            this.ram_amount.Size = new System.Drawing.Size(192, 20);
            this.ram_amount.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel2.Location = new System.Drawing.Point(346, 48);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Max RAM Amount : ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel1.Location = new System.Drawing.Point(346, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Search Versions :";
            // 
            // search_versions
            // 
            this.search_versions.Location = new System.Drawing.Point(374, 25);
            this.search_versions.Name = "search_versions";
            this.search_versions.Size = new System.Drawing.Size(192, 20);
            this.search_versions.TabIndex = 1;
            this.search_versions.TextChanged += new System.EventHandler(this.search_versions_text_changed);
            // 
            // version_list_view
            // 
            this.version_list_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.version_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.Versions});
            this.version_list_view.Depth = 0;
            this.version_list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.version_list_view.FullRowSelect = true;
            this.version_list_view.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.version_list_view.HideSelection = false;
            this.version_list_view.Location = new System.Drawing.Point(8, 6);
            this.version_list_view.MouseLocation = new System.Drawing.Point(-1, -1);
            this.version_list_view.MouseState = MaterialSkin.MouseState.OUT;
            this.version_list_view.Name = "version_list_view";
            this.version_list_view.OwnerDraw = true;
            this.version_list_view.Size = new System.Drawing.Size(332, 314);
            this.version_list_view.TabIndex = 0;
            this.version_list_view.UseCompatibleStateImageBehavior = false;
            this.version_list_view.View = System.Windows.Forms.View.Details;
            this.version_list_view.SelectedIndexChanged += new System.EventHandler(this.version_list_view_sic);
            // 
            // Versions
            // 
            this.Versions.Text = "Versions";
            this.Versions.Width = 319;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.MainTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(637, 41);
            this.materialTabSelector1.TabIndex = 18;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // download_display
            // 
            this.download_display.WorkerReportsProgress = true;
            this.download_display.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.download_display_progress_changed);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 433);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.MainTabControl);
            this.Name = "main_form";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_form_closed);
            this.Load += new System.EventHandler(this.main_load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.log_box.ResumeLayout(false);
            this.log_box.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialLabel data_label;
        private System.ComponentModel.BackgroundWorker download_display;
        private MaterialSkin.Controls.MaterialProgressBar DownloadProgressBar;
        private MaterialSkin.Controls.MaterialRaisedButton install_and_launch;
        private System.Windows.Forms.TextBox java_path;
        private MaterialSkin.Controls.MaterialRaisedButton load_cfg;
        private System.Windows.Forms.GroupBox log_box;
        private MaterialSkin.Controls.MaterialRaisedButton logout;
        private System.Windows.Forms.Label LogS;
        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TextBox mc_path;
        private System.Windows.Forms.TextBox ram_amount;
        private MaterialSkin.Controls.MaterialRaisedButton save_cfg;
        private System.Windows.Forms.TextBox search_versions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel user;
        private MaterialSkin.Controls.MaterialLabel ver_label;
        private MaterialSkin.Controls.MaterialLabel vers;
        private MaterialSkin.Controls.MaterialLabel version_label;
        private MaterialSkin.Controls.MaterialListView version_list_view;
        private System.Windows.Forms.ColumnHeader Versions;

        #endregion
    }
}