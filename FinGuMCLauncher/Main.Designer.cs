namespace FinGuMCLauncher
{
    partial class Main
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
        private void InitializeComponent()
        {
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.version_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.user = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogS = new System.Windows.Forms.Label();
            this.Data = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.InstalleLaunch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DownloadProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Logout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LoadCFG = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SaveCFG = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MCPath = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Vers = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.JavaPath = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.RAMAmmount = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SearchVersions = new System.Windows.Forms.TextBox();
            this.VersionListView = new MaterialSkin.Controls.MaterialListView();
            this.Versions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.downloadworker = new System.ComponentModel.BackgroundWorker();
            this.ChooseSkin = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Data);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.InstalleLaunch);
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
            this.version_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(8, 282);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(80, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Welcome :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogS);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(156, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
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
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Depth = 0;
            this.Data.Font = new System.Drawing.Font("Roboto", 11F);
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Data.Location = new System.Drawing.Point(152, 206);
            this.Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(40, 19);
            this.Data.TabIndex = 5;
            this.Data.Text = "Data";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(398, 206);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Version";
            // 
            // InstalleLaunch
            // 
            this.InstalleLaunch.AutoSize = true;
            this.InstalleLaunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InstalleLaunch.Depth = 0;
            this.InstalleLaunch.Icon = null;
            this.InstalleLaunch.Location = new System.Drawing.Point(270, 239);
            this.InstalleLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstalleLaunch.Name = "InstalleLaunch";
            this.InstalleLaunch.Primary = true;
            this.InstalleLaunch.Size = new System.Drawing.Size(75, 36);
            this.InstalleLaunch.TabIndex = 1;
            this.InstalleLaunch.Text = "Launch";
            this.InstalleLaunch.UseVisualStyleBackColor = true;
            this.InstalleLaunch.Click += new System.EventHandler(this.InstalleLaunch_Click);
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
            this.tabPage3.Controls.Add(this.Logout);
            this.tabPage3.Controls.Add(this.LoadCFG);
            this.tabPage3.Controls.Add(this.SaveCFG);
            this.tabPage3.Controls.Add(this.MCPath);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.Vers);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.JavaPath);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.RAMAmmount);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.SearchVersions);
            this.tabPage3.Controls.Add(this.VersionListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(629, 300);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout.Depth = 0;
            this.Logout.Icon = null;
            this.Logout.Location = new System.Drawing.Point(403, 264);
            this.Logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout.Name = "Logout";
            this.Logout.Primary = true;
            this.Logout.Size = new System.Drawing.Size(74, 36);
            this.Logout.TabIndex = 13;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // LoadCFG
            // 
            this.LoadCFG.AutoSize = true;
            this.LoadCFG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadCFG.Depth = 0;
            this.LoadCFG.Icon = null;
            this.LoadCFG.Location = new System.Drawing.Point(357, 219);
            this.LoadCFG.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadCFG.Name = "LoadCFG";
            this.LoadCFG.Primary = true;
            this.LoadCFG.Size = new System.Drawing.Size(82, 36);
            this.LoadCFG.TabIndex = 12;
            this.LoadCFG.Text = "LoadCFG";
            this.LoadCFG.UseVisualStyleBackColor = true;
            this.LoadCFG.Click += new System.EventHandler(this.LoadCFG_Click);
            // 
            // SaveCFG
            // 
            this.SaveCFG.AutoSize = true;
            this.SaveCFG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveCFG.Depth = 0;
            this.SaveCFG.Icon = null;
            this.SaveCFG.Location = new System.Drawing.Point(461, 219);
            this.SaveCFG.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveCFG.Name = "SaveCFG";
            this.SaveCFG.Primary = true;
            this.SaveCFG.Size = new System.Drawing.Size(81, 36);
            this.SaveCFG.TabIndex = 11;
            this.SaveCFG.Text = "SaveCFG";
            this.SaveCFG.UseVisualStyleBackColor = true;
            this.SaveCFG.Click += new System.EventHandler(this.SaveCFG_Click);
            // 
            // MCPath
            // 
            this.MCPath.Location = new System.Drawing.Point(374, 160);
            this.MCPath.Name = "MCPath";
            this.MCPath.Size = new System.Drawing.Size(192, 20);
            this.MCPath.TabIndex = 10;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(346, 138);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(115, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Minecraft Path :";
            // 
            // Vers
            // 
            this.Vers.AutoSize = true;
            this.Vers.Depth = 0;
            this.Vers.Font = new System.Drawing.Font("Roboto", 11F);
            this.Vers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Vers.Location = new System.Drawing.Point(483, 183);
            this.Vers.MouseState = MaterialSkin.MouseState.HOVER;
            this.Vers.Name = "Vers";
            this.Vers.Size = new System.Drawing.Size(40, 19);
            this.Vers.TabIndex = 8;
            this.Vers.Text = "Vers";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(346, 183);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(131, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Selected Version :";
            // 
            // JavaPath
            // 
            this.JavaPath.Location = new System.Drawing.Point(374, 115);
            this.JavaPath.Name = "JavaPath";
            this.JavaPath.Size = new System.Drawing.Size(192, 20);
            this.JavaPath.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(346, 93);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Java Path :";
            // 
            // RAMAmmount
            // 
            this.RAMAmmount.Location = new System.Drawing.Point(374, 70);
            this.RAMAmmount.Name = "RAMAmmount";
            this.RAMAmmount.Size = new System.Drawing.Size(192, 20);
            this.RAMAmmount.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(346, 48);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(151, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Max RAM Ammount :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(346, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Search Versions :";
            // 
            // SearchVersions
            // 
            this.SearchVersions.Location = new System.Drawing.Point(374, 25);
            this.SearchVersions.Name = "SearchVersions";
            this.SearchVersions.Size = new System.Drawing.Size(192, 20);
            this.SearchVersions.TabIndex = 1;
            this.SearchVersions.TextChanged += new System.EventHandler(this.SearchVersions_TextChanged_1);
            // 
            // VersionListView
            // 
            this.VersionListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VersionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Versions});
            this.VersionListView.Depth = 0;
            this.VersionListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.VersionListView.FullRowSelect = true;
            this.VersionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.VersionListView.HideSelection = false;
            this.VersionListView.Location = new System.Drawing.Point(8, 6);
            this.VersionListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.VersionListView.MouseState = MaterialSkin.MouseState.OUT;
            this.VersionListView.Name = "VersionListView";
            this.VersionListView.OwnerDraw = true;
            this.VersionListView.Size = new System.Drawing.Size(332, 314);
            this.VersionListView.TabIndex = 0;
            this.VersionListView.UseCompatibleStateImageBehavior = false;
            this.VersionListView.View = System.Windows.Forms.View.Details;
            this.VersionListView.SelectedIndexChanged += new System.EventHandler(this.VersionListView_SelectedIndexChanged_1);
            // 
            // Versions
            // 
            this.Versions.Text = "Versions";
            this.Versions.Width = 319;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.MainTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(637, 41);
            this.materialTabSelector1.TabIndex = 18;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // downloadworker
            // 
            this.downloadworker.WorkerReportsProgress = true;
            this.downloadworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.downloadworker_ProgressChanged);
            // 
            // ChooseSkin
            // 
            this.ChooseSkin.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 433);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialProgressBar DownloadProgressBar;
        private MaterialSkin.Controls.MaterialRaisedButton InstalleLaunch;
        private MaterialSkin.Controls.MaterialListView VersionListView;
        private System.Windows.Forms.ColumnHeader Versions;
        private System.Windows.Forms.TextBox SearchVersions;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox RAMAmmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox JavaPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel Vers;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.ComponentModel.BackgroundWorker downloadworker;
        private System.Windows.Forms.TextBox MCPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel Data;
        private MaterialSkin.Controls.MaterialRaisedButton LoadCFG;
        private MaterialSkin.Controls.MaterialRaisedButton SaveCFG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LogS;
        private MaterialSkin.Controls.MaterialRaisedButton Logout;
        private MaterialSkin.Controls.MaterialLabel user;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel version_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.OpenFileDialog ChooseSkin;
    }
}