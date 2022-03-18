namespace Files2Folders2Files
{
    partial class FrmFiles2Folders2Files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiles2Folders2Files));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFiles2Folders2Files = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFiles2Folders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFolders2Files = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbFiles2Folders = new System.Windows.Forms.ToolStripButton();
            this.tsbFolders2Files = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsbCancel = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspbOverallProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSnap = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwFiles2Folders = new System.ComponentModel.BackgroundWorker();
            this.bgwFolders2Files = new System.ComponentModel.BackgroundWorker();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.gbGeneralPreferences = new System.Windows.Forms.GroupBox();
            this.chkDeleteEmptyFolders = new System.Windows.Forms.CheckBox();
            this.gbDirectoryPath = new System.Windows.Forms.GroupBox();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.bgwStartupTasks = new System.ComponentModel.BackgroundWorker();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbViewHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbViewLicense = new System.Windows.Forms.ToolStripButton();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.tsmiToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbViewToolbar = new System.Windows.Forms.ToolStripButton();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            this.gbGeneralPreferences.SuspendLayout();
            this.gbDirectoryPath.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.tabLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFiles2Folders2Files,
            this.tsmiView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // tsmiFiles2Folders2Files
            // 
            this.tsmiFiles2Folders2Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFiles2Folders,
            this.tsmiFolders2Files,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFiles2Folders2Files.Name = "tsmiFiles2Folders2Files";
            this.tsmiFiles2Folders2Files.Size = new System.Drawing.Size(127, 20);
            this.tsmiFiles2Folders2Files.Text = "Files 2 Folders 2 Files";
            // 
            // tsmiFiles2Folders
            // 
            this.tsmiFiles2Folders.Name = "tsmiFiles2Folders";
            this.tsmiFiles2Folders.Size = new System.Drawing.Size(180, 22);
            this.tsmiFiles2Folders.Text = "Files 2 Folders";
            this.tsmiFiles2Folders.Click += new System.EventHandler(this.Files2Folders_Click);
            // 
            // tsmiFolders2Files
            // 
            this.tsmiFolders2Files.Name = "tsmiFolders2Files";
            this.tsmiFolders2Files.Size = new System.Drawing.Size(180, 22);
            this.tsmiFolders2Files.Text = "Folders 2 Files";
            this.tsmiFolders2Files.Click += new System.EventHandler(this.Folders2Files_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFiles2Folders,
            this.tsbFolders2Files,
            this.toolStripSeparator2,
            this.tsbViewHelp,
            this.tsbViewLicense,
            this.tsbViewToolbar});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 39);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbFiles2Folders
            // 
            this.tsbFiles2Folders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFiles2Folders.Image = ((System.Drawing.Image)(resources.GetObject("tsbFiles2Folders.Image")));
            this.tsbFiles2Folders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiles2Folders.Name = "tsbFiles2Folders";
            this.tsbFiles2Folders.Size = new System.Drawing.Size(36, 36);
            this.tsbFiles2Folders.Text = "Files 2 Folders";
            this.tsbFiles2Folders.Click += new System.EventHandler(this.Files2Folders_Click);
            // 
            // tsbFolders2Files
            // 
            this.tsbFolders2Files.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFolders2Files.Image = ((System.Drawing.Image)(resources.GetObject("tsbFolders2Files.Image")));
            this.tsbFolders2Files.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFolders2Files.Name = "tsbFolders2Files";
            this.tsbFolders2Files.Size = new System.Drawing.Size(36, 36);
            this.tsbFolders2Files.Text = "Folders 2 Files";
            this.tsbFolders2Files.Click += new System.EventHandler(this.Folders2Files_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCancel,
            this.tspbOverallProgress,
            this.tsslStatus,
            this.tsslSnap});
            this.ssMain.Location = new System.Drawing.Point(0, 359);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "ssMain";
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.ShowDropDownArrow = false;
            this.tsbCancel.Size = new System.Drawing.Size(20, 20);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tspbOverallProgress
            // 
            this.tspbOverallProgress.MarqueeAnimationSpeed = 10;
            this.tspbOverallProgress.Name = "tspbOverallProgress";
            this.tspbOverallProgress.Size = new System.Drawing.Size(200, 16);
            this.tspbOverallProgress.Step = 1;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslStatus.Text = "Ready";
            // 
            // tsslSnap
            // 
            this.tsslSnap.Name = "tsslSnap";
            this.tsslSnap.Size = new System.Drawing.Size(508, 17);
            this.tsslSnap.Spring = true;
            // 
            // bgwFiles2Folders
            // 
            this.bgwFiles2Folders.WorkerReportsProgress = true;
            this.bgwFiles2Folders.WorkerSupportsCancellation = true;
            this.bgwFiles2Folders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Files2Folders_DoWork);
            this.bgwFiles2Folders.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Files2Folders_ProgressChanged);
            this.bgwFiles2Folders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Files2Folders_RunWorkerCompleted);
            // 
            // bgwFolders2Files
            // 
            this.bgwFolders2Files.WorkerReportsProgress = true;
            this.bgwFolders2Files.WorkerSupportsCancellation = true;
            this.bgwFolders2Files.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Folders2Files_DoWork);
            this.bgwFolders2Files.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Folders2Files_ProgressChanged);
            this.bgwFolders2Files.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Folders2Files_RunWorkerCompleted);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabOptions);
            this.tcMain.Controls.Add(this.tabHelp);
            this.tcMain.Controls.Add(this.tabLicense);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(784, 296);
            this.tcMain.TabIndex = 3;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtbLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(776, 270);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = " Log ";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(6, 6);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(764, 258);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tlpOptions);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(776, 270);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = " Options ";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // tlpOptions
            // 
            this.tlpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpOptions.ColumnCount = 1;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Controls.Add(this.gbGeneralPreferences, 0, 1);
            this.tlpOptions.Controls.Add(this.gbDirectoryPath, 0, 0);
            this.tlpOptions.Location = new System.Drawing.Point(6, 6);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 2;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpOptions.Size = new System.Drawing.Size(764, 99);
            this.tlpOptions.TabIndex = 0;
            // 
            // gbGeneralPreferences
            // 
            this.gbGeneralPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGeneralPreferences.Controls.Add(this.chkDeleteEmptyFolders);
            this.gbGeneralPreferences.Location = new System.Drawing.Point(3, 54);
            this.gbGeneralPreferences.Name = "gbGeneralPreferences";
            this.gbGeneralPreferences.Size = new System.Drawing.Size(758, 42);
            this.gbGeneralPreferences.TabIndex = 1;
            this.gbGeneralPreferences.TabStop = false;
            this.gbGeneralPreferences.Text = "General Preferences";
            // 
            // chkDeleteEmptyFolders
            // 
            this.chkDeleteEmptyFolders.AutoSize = true;
            this.chkDeleteEmptyFolders.Location = new System.Drawing.Point(6, 19);
            this.chkDeleteEmptyFolders.Name = "chkDeleteEmptyFolders";
            this.chkDeleteEmptyFolders.Size = new System.Drawing.Size(126, 17);
            this.chkDeleteEmptyFolders.TabIndex = 0;
            this.chkDeleteEmptyFolders.Text = "Delete Empty Folders";
            this.chkDeleteEmptyFolders.UseVisualStyleBackColor = true;
            // 
            // gbDirectoryPath
            // 
            this.gbDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDirectoryPath.Controls.Add(this.txtDirectoryPath);
            this.gbDirectoryPath.Location = new System.Drawing.Point(3, 3);
            this.gbDirectoryPath.Name = "gbDirectoryPath";
            this.gbDirectoryPath.Size = new System.Drawing.Size(758, 45);
            this.gbDirectoryPath.TabIndex = 0;
            this.gbDirectoryPath.TabStop = false;
            this.gbDirectoryPath.Text = "Directory Path";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(6, 19);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.ReadOnly = true;
            this.txtDirectoryPath.Size = new System.Drawing.Size(746, 20);
            this.txtDirectoryPath.TabIndex = 0;
            this.txtDirectoryPath.Click += new System.EventHandler(this.DirectoryPath_Click);
            // 
            // bgwStartupTasks
            // 
            this.bgwStartupTasks.WorkerReportsProgress = true;
            this.bgwStartupTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartupTasks_DoWork);
            this.bgwStartupTasks.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.StartupTasks_ProgressChanged);
            this.bgwStartupTasks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StartupTasks_RunWorkerCompleted);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbViewHelp
            // 
            this.tsbViewHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewHelp.Image")));
            this.tsbViewHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewHelp.Name = "tsbViewHelp";
            this.tsbViewHelp.Size = new System.Drawing.Size(36, 36);
            this.tsbViewHelp.Text = "View Help";
            this.tsbViewHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsbViewLicense
            // 
            this.tsbViewLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewLicense.Image")));
            this.tsbViewLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewLicense.Name = "tsbViewLicense";
            this.tsbViewLicense.Size = new System.Drawing.Size(36, 36);
            this.tsbViewLicense.Text = "View License";
            this.tsbViewLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLog,
            this.tsmiOptions,
            this.tsmiHelp,
            this.tsmiLicense,
            this.tsmiToolbar});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiLog
            // 
            this.tsmiLog.Checked = true;
            this.tsmiLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLog.Name = "tsmiLog";
            this.tsmiLog.Size = new System.Drawing.Size(180, 22);
            this.tsmiLog.Text = "Log";
            this.tsmiLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Checked = true;
            this.tsmiOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(180, 22);
            this.tsmiOptions.Text = "Options";
            this.tsmiOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(180, 22);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsmiLicense
            // 
            this.tsmiLicense.Name = "tsmiLicense";
            this.tsmiLicense.Size = new System.Drawing.Size(180, 22);
            this.tsmiLicense.Text = "License";
            this.tsmiLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.rtbHelp);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(776, 270);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = " Help ";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.rtbLicense);
            this.tabLicense.Location = new System.Drawing.Point(4, 22);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(776, 270);
            this.tabLicense.TabIndex = 3;
            this.tabLicense.Text = " License ";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // rtbHelp
            // 
            this.rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelp.Location = new System.Drawing.Point(6, 6);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(764, 258);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // rtbLicense
            // 
            this.rtbLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLicense.Location = new System.Drawing.Point(6, 6);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(764, 258);
            this.rtbLicense.TabIndex = 0;
            this.rtbLicense.Text = "";
            // 
            // tsmiToolbar
            // 
            this.tsmiToolbar.Name = "tsmiToolbar";
            this.tsmiToolbar.Size = new System.Drawing.Size(180, 22);
            this.tsmiToolbar.Text = "Toolbar";
            this.tsmiToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // tsbViewToolbar
            // 
            this.tsbViewToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewToolbar.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewToolbar.Image")));
            this.tsbViewToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewToolbar.Name = "tsbViewToolbar";
            this.tsbViewToolbar.Size = new System.Drawing.Size(36, 36);
            this.tsbViewToolbar.Text = "View Toolbar";
            this.tsbViewToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // FrmFiles2Folders2Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmFiles2Folders2Files";
            this.Text = "Files 2 Folders 2 Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Files2Folders2Files_FormClosing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tlpOptions.ResumeLayout(false);
            this.gbGeneralPreferences.ResumeLayout(false);
            this.gbGeneralPreferences.PerformLayout();
            this.gbDirectoryPath.ResumeLayout(false);
            this.gbDirectoryPath.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFiles2Folders2Files;
        private System.Windows.Forms.ToolStripMenuItem tsmiFiles2Folders;
        private System.Windows.Forms.ToolStripMenuItem tsmiFolders2Files;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbFiles2Folders;
        private System.Windows.Forms.ToolStripButton tsbFolders2Files;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslSnap;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripDropDownButton tsbCancel;
        private System.ComponentModel.BackgroundWorker bgwFiles2Folders;
        private System.ComponentModel.BackgroundWorker bgwFolders2Files;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.GroupBox gbDirectoryPath;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox gbGeneralPreferences;
        private System.Windows.Forms.CheckBox chkDeleteEmptyFolders;
        private System.Windows.Forms.ToolStripProgressBar tspbOverallProgress;
        private System.ComponentModel.BackgroundWorker bgwStartupTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbViewHelp;
        private System.Windows.Forms.ToolStripButton tsbViewLicense;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.RichTextBox rtbLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolbar;
        private System.Windows.Forms.ToolStripButton tsbViewToolbar;
    }
}

