namespace HR_Backup_Manager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BackupDirLabel = new System.Windows.Forms.Label();
            this.BakupDirSubmenuButton = new System.Windows.Forms.Button();
            this.SettingsSaveButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.StartedTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.AllCapsPanel = new System.Windows.Forms.Panel();
            this.AllCapsNo = new System.Windows.Forms.RadioButton();
            this.AllCapsYes = new System.Windows.Forms.RadioButton();
            this.AllCapsLabel = new System.Windows.Forms.Label();
            this.SettingsResultLabel = new System.Windows.Forms.Label();
            this.BackupDirTextBox = new System.Windows.Forms.TextBox();
            this.BrowseTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowseTreeView = new System.Windows.Forms.TreeView();
            this.BrowseTreeCurrentNodeLabel = new System.Windows.Forms.Label();
            this.BrowseTreeLabel = new System.Windows.Forms.Label();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.SearchRadioLabel = new System.Windows.Forms.Label();
            this.SearchRigsRadioPanel = new System.Windows.Forms.Panel();
            this.SearchRadioIRButton = new System.Windows.Forms.RadioButton();
            this.SearchRadioRigButton = new System.Windows.Forms.RadioButton();
            this.RigSearchResultsListView = new System.Windows.Forms.ListView();
            this.RigSearchLabel = new System.Windows.Forms.Label();
            this.RigSearchTextBox = new System.Windows.Forms.TextBox();
            this.RigDataNameLabel = new System.Windows.Forms.Label();
            this.ProgramMessageLabel = new System.Windows.Forms.Label();
            this.ProgramMessageBox = new System.Windows.Forms.TextBox();
            this.BackupDirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.AllCapsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OnlyIRLabel = new System.Windows.Forms.Label();
            this.OnlyIRButton = new System.Windows.Forms.Button();
            this.OnlyRigsButton = new System.Windows.Forms.Button();
            this.OnlyRigsLabel = new System.Windows.Forms.Label();
            this.RigDataNameLabel2 = new System.Windows.Forms.Label();
            this.RigDataListView = new System.Windows.Forms.ListView();
            this.SongHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetlistHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RigDataListViewLabel = new System.Windows.Forms.Label();
            this.RigDataIRLabel = new System.Windows.Forms.Label();
            this.RigDataIRLabel2 = new System.Windows.Forms.Label();
            this.BackupFolderErrorLabel = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.StartedTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.AllCapsPanel.SuspendLayout();
            this.BrowseTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchTab.SuspendLayout();
            this.SearchRigsRadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupDirLabel
            // 
            this.BackupDirLabel.AutoSize = true;
            this.BackupDirLabel.Location = new System.Drawing.Point(38, 29);
            this.BackupDirLabel.Name = "BackupDirLabel";
            this.BackupDirLabel.Size = new System.Drawing.Size(96, 16);
            this.BackupDirLabel.TabIndex = 0;
            this.BackupDirLabel.Text = "Backup Folder";
            // 
            // BakupDirSubmenuButton
            // 
            this.BakupDirSubmenuButton.Location = new System.Drawing.Point(530, 27);
            this.BakupDirSubmenuButton.Name = "BakupDirSubmenuButton";
            this.BakupDirSubmenuButton.Size = new System.Drawing.Size(113, 23);
            this.BakupDirSubmenuButton.TabIndex = 2;
            this.BakupDirSubmenuButton.Text = "Select a folder";
            this.BakupDirSubmenuButton.UseVisualStyleBackColor = true;
            this.BakupDirSubmenuButton.Click += new System.EventHandler(this.BakupDirSubmenuButton_Click);
            // 
            // SettingsSaveButton
            // 
            this.SettingsSaveButton.Enabled = false;
            this.SettingsSaveButton.Location = new System.Drawing.Point(158, 127);
            this.SettingsSaveButton.Name = "SettingsSaveButton";
            this.SettingsSaveButton.Size = new System.Drawing.Size(90, 26);
            this.SettingsSaveButton.TabIndex = 3;
            this.SettingsSaveButton.Text = "Save Settings";
            this.SettingsSaveButton.UseVisualStyleBackColor = true;
            this.SettingsSaveButton.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.StartedTab);
            this.MainTabControl.Controls.Add(this.SettingsTab);
            this.MainTabControl.Controls.Add(this.BrowseTab);
            this.MainTabControl.Controls.Add(this.SearchTab);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(11, 3);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(941, 468);
            this.MainTabControl.TabIndex = 4;
            // 
            // StartedTab
            // 
            this.StartedTab.Controls.Add(this.richTextBox1);
            this.StartedTab.Location = new System.Drawing.Point(4, 27);
            this.StartedTab.Name = "StartedTab";
            this.StartedTab.Size = new System.Drawing.Size(933, 437);
            this.StartedTab.TabIndex = 2;
            this.StartedTab.Text = "Getting Started";
            this.StartedTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(27, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(879, 413);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SettingsTab
            // 
            this.SettingsTab.AllowDrop = true;
            this.SettingsTab.Controls.Add(this.BackupFolderErrorLabel);
            this.SettingsTab.Controls.Add(this.AllCapsPanel);
            this.SettingsTab.Controls.Add(this.AllCapsLabel);
            this.SettingsTab.Controls.Add(this.SettingsResultLabel);
            this.SettingsTab.Controls.Add(this.BackupDirLabel);
            this.SettingsTab.Controls.Add(this.SettingsSaveButton);
            this.SettingsTab.Controls.Add(this.BakupDirSubmenuButton);
            this.SettingsTab.Controls.Add(this.BackupDirTextBox);
            this.SettingsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab.Location = new System.Drawing.Point(4, 27);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(933, 437);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // AllCapsPanel
            // 
            this.AllCapsPanel.Controls.Add(this.AllCapsNo);
            this.AllCapsPanel.Controls.Add(this.AllCapsYes);
            this.AllCapsPanel.Location = new System.Drawing.Point(154, 71);
            this.AllCapsPanel.Name = "AllCapsPanel";
            this.AllCapsPanel.Size = new System.Drawing.Size(90, 32);
            this.AllCapsPanel.TabIndex = 11;
            // 
            // AllCapsNo
            // 
            this.AllCapsNo.Appearance = System.Windows.Forms.Appearance.Button;
            this.AllCapsNo.AutoSize = true;
            this.AllCapsNo.Location = new System.Drawing.Point(51, 3);
            this.AllCapsNo.Name = "AllCapsNo";
            this.AllCapsNo.Size = new System.Drawing.Size(36, 26);
            this.AllCapsNo.TabIndex = 1;
            this.AllCapsNo.TabStop = true;
            this.AllCapsNo.Text = "No";
            this.AllCapsNo.UseVisualStyleBackColor = true;
            this.AllCapsNo.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // AllCapsYes
            // 
            this.AllCapsYes.Appearance = System.Windows.Forms.Appearance.Button;
            this.AllCapsYes.AutoSize = true;
            this.AllCapsYes.Location = new System.Drawing.Point(3, 3);
            this.AllCapsYes.Name = "AllCapsYes";
            this.AllCapsYes.Size = new System.Drawing.Size(42, 26);
            this.AllCapsYes.TabIndex = 0;
            this.AllCapsYes.TabStop = true;
            this.AllCapsYes.Text = "Yes";
            this.AllCapsYes.UseVisualStyleBackColor = true;
            this.AllCapsYes.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // AllCapsLabel
            // 
            this.AllCapsLabel.AutoSize = true;
            this.AllCapsLabel.Location = new System.Drawing.Point(77, 71);
            this.AllCapsLabel.MaximumSize = new System.Drawing.Size(130, 0);
            this.AllCapsLabel.Name = "AllCapsLabel";
            this.AllCapsLabel.Size = new System.Drawing.Size(58, 16);
            this.AllCapsLabel.TabIndex = 9;
            this.AllCapsLabel.Text = "All Caps";
            // 
            // SettingsResultLabel
            // 
            this.SettingsResultLabel.AutoSize = true;
            this.SettingsResultLabel.Location = new System.Drawing.Point(284, 132);
            this.SettingsResultLabel.Name = "SettingsResultLabel";
            this.SettingsResultLabel.Size = new System.Drawing.Size(124, 16);
            this.SettingsResultLabel.TabIndex = 4;
            this.SettingsResultLabel.Text = "Settings result label";
            // 
            // BackupDirTextBox
            // 
            this.BackupDirTextBox.Enabled = false;
            this.BackupDirTextBox.Location = new System.Drawing.Point(158, 28);
            this.BackupDirTextBox.Name = "BackupDirTextBox";
            this.BackupDirTextBox.Size = new System.Drawing.Size(366, 22);
            this.BackupDirTextBox.TabIndex = 1;
            // 
            // BrowseTab
            // 
            this.BrowseTab.Controls.Add(this.panel1);
            this.BrowseTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseTab.Location = new System.Drawing.Point(4, 27);
            this.BrowseTab.Name = "BrowseTab";
            this.BrowseTab.Padding = new System.Windows.Forms.Padding(3);
            this.BrowseTab.Size = new System.Drawing.Size(933, 437);
            this.BrowseTab.TabIndex = 1;
            this.BrowseTab.Text = "Browse";
            this.BrowseTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.BrowseTreeView);
            this.panel1.Controls.Add(this.BrowseTreeCurrentNodeLabel);
            this.panel1.Controls.Add(this.BrowseTreeLabel);
            this.panel1.Location = new System.Drawing.Point(236, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 435);
            this.panel1.TabIndex = 9;
            // 
            // BrowseTreeView
            // 
            this.BrowseTreeView.Location = new System.Drawing.Point(3, 42);
            this.BrowseTreeView.Name = "BrowseTreeView";
            this.BrowseTreeView.Size = new System.Drawing.Size(411, 380);
            this.BrowseTreeView.TabIndex = 6;
            this.BrowseTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.BrowseTreeView_BeforeCollapse);
            this.BrowseTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.BrowseTreeView_BeforeExpand);
            this.BrowseTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.BrowseTreeView_NodeMouseClick);
            this.BrowseTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.BrowseTreeView_NodeMouseDoubleClick);
            // 
            // BrowseTreeCurrentNodeLabel
            // 
            this.BrowseTreeCurrentNodeLabel.AutoSize = true;
            this.BrowseTreeCurrentNodeLabel.Location = new System.Drawing.Point(5, 23);
            this.BrowseTreeCurrentNodeLabel.Name = "BrowseTreeCurrentNodeLabel";
            this.BrowseTreeCurrentNodeLabel.Size = new System.Drawing.Size(194, 16);
            this.BrowseTreeCurrentNodeLabel.TabIndex = 8;
            this.BrowseTreeCurrentNodeLabel.Text = "currently selected treeview item";
            // 
            // BrowseTreeLabel
            // 
            this.BrowseTreeLabel.AutoSize = true;
            this.BrowseTreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseTreeLabel.Location = new System.Drawing.Point(5, 3);
            this.BrowseTreeLabel.Name = "BrowseTreeLabel";
            this.BrowseTreeLabel.Size = new System.Drawing.Size(181, 16);
            this.BrowseTreeLabel.TabIndex = 7;
            this.BrowseTreeLabel.Text = "Setlists, Songs, and Rigs";
            // 
            // SearchTab
            // 
            this.SearchTab.Controls.Add(this.OnlyRigsButton);
            this.SearchTab.Controls.Add(this.OnlyRigsLabel);
            this.SearchTab.Controls.Add(this.OnlyIRButton);
            this.SearchTab.Controls.Add(this.OnlyIRLabel);
            this.SearchTab.Controls.Add(this.SearchRadioLabel);
            this.SearchTab.Controls.Add(this.SearchRigsRadioPanel);
            this.SearchTab.Controls.Add(this.RigSearchResultsListView);
            this.SearchTab.Controls.Add(this.RigSearchLabel);
            this.SearchTab.Controls.Add(this.RigSearchTextBox);
            this.SearchTab.Location = new System.Drawing.Point(4, 27);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Size = new System.Drawing.Size(933, 437);
            this.SearchTab.TabIndex = 3;
            this.SearchTab.Text = "Search";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // SearchRadioLabel
            // 
            this.SearchRadioLabel.AutoSize = true;
            this.SearchRadioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRadioLabel.Location = new System.Drawing.Point(16, 31);
            this.SearchRadioLabel.Name = "SearchRadioLabel";
            this.SearchRadioLabel.Size = new System.Drawing.Size(132, 16);
            this.SearchRadioLabel.TabIndex = 4;
            this.SearchRadioLabel.Text = "Search for rigs using:";
            // 
            // SearchRigsRadioPanel
            // 
            this.SearchRigsRadioPanel.Controls.Add(this.SearchRadioIRButton);
            this.SearchRigsRadioPanel.Controls.Add(this.SearchRadioRigButton);
            this.SearchRigsRadioPanel.Location = new System.Drawing.Point(160, 15);
            this.SearchRigsRadioPanel.Name = "SearchRigsRadioPanel";
            this.SearchRigsRadioPanel.Size = new System.Drawing.Size(189, 47);
            this.SearchRigsRadioPanel.TabIndex = 3;
            // 
            // SearchRadioIRButton
            // 
            this.SearchRadioIRButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SearchRadioIRButton.AutoSize = true;
            this.SearchRadioIRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRadioIRButton.Location = new System.Drawing.Point(102, 13);
            this.SearchRadioIRButton.Name = "SearchRadioIRButton";
            this.SearchRadioIRButton.Size = new System.Drawing.Size(68, 26);
            this.SearchRadioIRButton.TabIndex = 1;
            this.SearchRadioIRButton.TabStop = true;
            this.SearchRadioIRButton.Text = "IR name";
            this.SearchRadioIRButton.UseVisualStyleBackColor = true;
            this.SearchRadioIRButton.Click += new System.EventHandler(this.SearchRadioIRButton_Click);
            // 
            // SearchRadioRigButton
            // 
            this.SearchRadioRigButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SearchRadioRigButton.AutoSize = true;
            this.SearchRadioRigButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRadioRigButton.Location = new System.Drawing.Point(13, 13);
            this.SearchRadioRigButton.Name = "SearchRadioRigButton";
            this.SearchRadioRigButton.Size = new System.Drawing.Size(76, 26);
            this.SearchRadioRigButton.TabIndex = 0;
            this.SearchRadioRigButton.TabStop = true;
            this.SearchRadioRigButton.Text = "Rig name";
            this.SearchRadioRigButton.UseVisualStyleBackColor = true;
            this.SearchRadioRigButton.Click += new System.EventHandler(this.SearchRadioRigButton_Click);
            // 
            // RigSearchResultsListView
            // 
            this.RigSearchResultsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigSearchResultsListView.HideSelection = false;
            this.RigSearchResultsListView.Location = new System.Drawing.Point(160, 129);
            this.RigSearchResultsListView.MultiSelect = false;
            this.RigSearchResultsListView.Name = "RigSearchResultsListView";
            this.RigSearchResultsListView.Size = new System.Drawing.Size(713, 286);
            this.RigSearchResultsListView.TabIndex = 2;
            this.RigSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.RigSearchResultsListView.View = System.Windows.Forms.View.List;
            this.RigSearchResultsListView.SelectedIndexChanged += new System.EventHandler(this.RigSearchResultsListView_SelectedIndexChanged);
            // 
            // RigSearchLabel
            // 
            this.RigSearchLabel.AutoSize = true;
            this.RigSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigSearchLabel.Location = new System.Drawing.Point(64, 86);
            this.RigSearchLabel.Name = "RigSearchLabel";
            this.RigSearchLabel.Size = new System.Drawing.Size(83, 16);
            this.RigSearchLabel.TabIndex = 1;
            this.RigSearchLabel.Text = "Search term:";
            // 
            // RigSearchTextBox
            // 
            this.RigSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigSearchTextBox.Location = new System.Drawing.Point(160, 82);
            this.RigSearchTextBox.Name = "RigSearchTextBox";
            this.RigSearchTextBox.Size = new System.Drawing.Size(443, 22);
            this.RigSearchTextBox.TabIndex = 0;
            this.RigSearchTextBox.TextChanged += new System.EventHandler(this.RigSearchTextBox_TextChanged);
            // 
            // RigDataNameLabel
            // 
            this.RigDataNameLabel.AutoSize = true;
            this.RigDataNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigDataNameLabel.Location = new System.Drawing.Point(22, 502);
            this.RigDataNameLabel.Name = "RigDataNameLabel";
            this.RigDataNameLabel.Size = new System.Drawing.Size(32, 16);
            this.RigDataNameLabel.TabIndex = 0;
            this.RigDataNameLabel.Text = "Rig:";
            // 
            // ProgramMessageLabel
            // 
            this.ProgramMessageLabel.AutoSize = true;
            this.ProgramMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramMessageLabel.Location = new System.Drawing.Point(715, 483);
            this.ProgramMessageLabel.Name = "ProgramMessageLabel";
            this.ProgramMessageLabel.Size = new System.Drawing.Size(165, 16);
            this.ProgramMessageLabel.TabIndex = 1;
            this.ProgramMessageLabel.Text = "Program Message Box";
            this.ProgramMessageLabel.Visible = false;
            // 
            // ProgramMessageBox
            // 
            this.ProgramMessageBox.Location = new System.Drawing.Point(718, 502);
            this.ProgramMessageBox.Multiline = true;
            this.ProgramMessageBox.Name = "ProgramMessageBox";
            this.ProgramMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProgramMessageBox.Size = new System.Drawing.Size(234, 100);
            this.ProgramMessageBox.TabIndex = 0;
            this.ProgramMessageBox.Visible = false;
            // 
            // BackupDirBrowserDialog
            // 
            this.BackupDirBrowserDialog.Description = "Select a backup folder. This folder must contain a valid HeadRush backup.";
            // 
            // AllCapsToolTip
            // 
            this.AllCapsToolTip.ToolTipTitle = "All Caps info";
            // 
            // OnlyIRLabel
            // 
            this.OnlyIRLabel.AutoSize = true;
            this.OnlyIRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyIRLabel.Location = new System.Drawing.Point(388, 31);
            this.OnlyIRLabel.Name = "OnlyIRLabel";
            this.OnlyIRLabel.Size = new System.Drawing.Size(142, 16);
            this.OnlyIRLabel.TabIndex = 5;
            this.OnlyIRLabel.Text = "Only show rigs with IRs";
            // 
            // OnlyIRButton
            // 
            this.OnlyIRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyIRButton.Location = new System.Drawing.Point(540, 27);
            this.OnlyIRButton.Name = "OnlyIRButton";
            this.OnlyIRButton.Size = new System.Drawing.Size(54, 26);
            this.OnlyIRButton.TabIndex = 6;
            this.OnlyIRButton.Text = "No";
            this.OnlyIRButton.UseVisualStyleBackColor = true;
            this.OnlyIRButton.Click += new System.EventHandler(this.OnlyIRButton_Click);
            // 
            // OnlyRigsButton
            // 
            this.OnlyRigsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyRigsButton.Location = new System.Drawing.Point(833, 28);
            this.OnlyRigsButton.Name = "OnlyRigsButton";
            this.OnlyRigsButton.Size = new System.Drawing.Size(54, 26);
            this.OnlyRigsButton.TabIndex = 8;
            this.OnlyRigsButton.Text = "No";
            this.OnlyRigsButton.UseVisualStyleBackColor = true;
            this.OnlyRigsButton.Click += new System.EventHandler(this.OnlyRigsButton_Click);
            // 
            // OnlyRigsLabel
            // 
            this.OnlyRigsLabel.AutoSize = true;
            this.OnlyRigsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyRigsLabel.Location = new System.Drawing.Point(650, 32);
            this.OnlyRigsLabel.Name = "OnlyRigsLabel";
            this.OnlyRigsLabel.Size = new System.Drawing.Size(172, 16);
            this.OnlyRigsLabel.TabIndex = 7;
            this.OnlyRigsLabel.Text = "Only show rigs not in setlists";
            // 
            // RigDataNameLabel2
            // 
            this.RigDataNameLabel2.AutoSize = true;
            this.RigDataNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigDataNameLabel2.Location = new System.Drawing.Point(60, 502);
            this.RigDataNameLabel2.Name = "RigDataNameLabel2";
            this.RigDataNameLabel2.Size = new System.Drawing.Size(60, 16);
            this.RigDataNameLabel2.TabIndex = 5;
            this.RigDataNameLabel2.Text = "rig name";
            // 
            // RigDataListView
            // 
            this.RigDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SongHeader,
            this.SetlistHeader});
            this.RigDataListView.HideSelection = false;
            this.RigDataListView.Location = new System.Drawing.Point(25, 559);
            this.RigDataListView.Name = "RigDataListView";
            this.RigDataListView.Size = new System.Drawing.Size(415, 135);
            this.RigDataListView.TabIndex = 6;
            this.RigDataListView.UseCompatibleStateImageBehavior = false;
            this.RigDataListView.View = System.Windows.Forms.View.Details;
            // 
            // SongHeader
            // 
            this.SongHeader.Text = "Song";
            this.SongHeader.Width = 192;
            // 
            // SetlistHeader
            // 
            this.SetlistHeader.Text = "Setlist";
            this.SetlistHeader.Width = 206;
            // 
            // RigDataListViewLabel
            // 
            this.RigDataListViewLabel.AutoSize = true;
            this.RigDataListViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigDataListViewLabel.Location = new System.Drawing.Point(25, 540);
            this.RigDataListViewLabel.Name = "RigDataListViewLabel";
            this.RigDataListViewLabel.Size = new System.Drawing.Size(231, 16);
            this.RigDataListViewLabel.TabIndex = 7;
            this.RigDataListViewLabel.Text = "Contained in these songs and setlists:";
            // 
            // RigDataIRLabel
            // 
            this.RigDataIRLabel.AutoSize = true;
            this.RigDataIRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigDataIRLabel.Location = new System.Drawing.Point(300, 502);
            this.RigDataIRLabel.Name = "RigDataIRLabel";
            this.RigDataIRLabel.Size = new System.Drawing.Size(24, 16);
            this.RigDataIRLabel.TabIndex = 8;
            this.RigDataIRLabel.Text = "IR:";
            // 
            // RigDataIRLabel2
            // 
            this.RigDataIRLabel2.AutoSize = true;
            this.RigDataIRLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RigDataIRLabel2.Location = new System.Drawing.Point(330, 502);
            this.RigDataIRLabel2.Name = "RigDataIRLabel2";
            this.RigDataIRLabel2.Size = new System.Drawing.Size(58, 16);
            this.RigDataIRLabel2.TabIndex = 8;
            this.RigDataIRLabel2.Text = "IR name";
            // 
            // BackupFolderErrorLabel
            // 
            this.BackupFolderErrorLabel.AutoSize = true;
            this.BackupFolderErrorLabel.Location = new System.Drawing.Point(649, 31);
            this.BackupFolderErrorLabel.Name = "BackupFolderErrorLabel";
            this.BackupFolderErrorLabel.Size = new System.Drawing.Size(121, 16);
            this.BackupFolderErrorLabel.TabIndex = 12;
            this.BackupFolderErrorLabel.Text = "backup folder error";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 706);
            this.Controls.Add(this.RigDataIRLabel2);
            this.Controls.Add(this.RigDataIRLabel);
            this.Controls.Add(this.RigDataListViewLabel);
            this.Controls.Add(this.RigDataListView);
            this.Controls.Add(this.RigDataNameLabel2);
            this.Controls.Add(this.RigDataNameLabel);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.ProgramMessageBox);
            this.Controls.Add(this.ProgramMessageLabel);
            this.Name = "MainForm";
            this.Text = "HeadRush Backup Manager";
            this.MainTabControl.ResumeLayout(false);
            this.StartedTab.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.AllCapsPanel.ResumeLayout(false);
            this.AllCapsPanel.PerformLayout();
            this.BrowseTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            this.SearchRigsRadioPanel.ResumeLayout(false);
            this.SearchRigsRadioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackupDirLabel;
        private System.Windows.Forms.Button BakupDirSubmenuButton;
        private System.Windows.Forms.Button SettingsSaveButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage BrowseTab;
        private System.Windows.Forms.FolderBrowserDialog BackupDirBrowserDialog;
        private System.Windows.Forms.Label SettingsResultLabel;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label ProgramMessageLabel;
        private System.Windows.Forms.TextBox ProgramMessageBox;
        private System.Windows.Forms.Label AllCapsLabel;
        private System.Windows.Forms.RadioButton AllCapsNo;
        private System.Windows.Forms.RadioButton AllCapsYes;
        private System.Windows.Forms.Panel AllCapsPanel;
        private System.Windows.Forms.TextBox BackupDirTextBox;
        private System.Windows.Forms.TabPage StartedTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip AllCapsToolTip;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.Label RigSearchLabel;
        private System.Windows.Forms.TextBox RigSearchTextBox;
        private System.Windows.Forms.ListView RigSearchResultsListView;
        private System.Windows.Forms.Panel SearchRigsRadioPanel;
        private System.Windows.Forms.RadioButton SearchRadioIRButton;
        private System.Windows.Forms.RadioButton SearchRadioRigButton;
        private System.Windows.Forms.Label SearchRadioLabel;
        private System.Windows.Forms.TreeView BrowseTreeView;
        private System.Windows.Forms.Label BrowseTreeCurrentNodeLabel;
        private System.Windows.Forms.Label BrowseTreeLabel;
        private System.Windows.Forms.Label RigDataNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OnlyIRButton;
        private System.Windows.Forms.Label OnlyIRLabel;
        private System.Windows.Forms.Button OnlyRigsButton;
        private System.Windows.Forms.Label OnlyRigsLabel;
        private System.Windows.Forms.Label RigDataNameLabel2;
        private System.Windows.Forms.ListView RigDataListView;
        private System.Windows.Forms.ColumnHeader SongHeader;
        private System.Windows.Forms.ColumnHeader SetlistHeader;
        private System.Windows.Forms.Label RigDataListViewLabel;
        private System.Windows.Forms.Label RigDataIRLabel;
        private System.Windows.Forms.Label RigDataIRLabel2;
        private System.Windows.Forms.Label BackupFolderErrorLabel;
    }
}

