namespace MHWSpeedrunTool
{
    partial class SaveForm
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
            cboBackups = new GroupBox();
            cmdDeleteSelectedSave = new Button();
            lstSaveNames = new ListBox();
            cmdRenameSelectedSave = new Button();
            cmdLoadSelectedSave = new Button();
            lblCurrentlyLoadedSave = new Label();
            lblSaveName = new Label();
            cmdLoadMainSave = new Button();
            cboNewSave = new GroupBox();
            cmdBackupCurrentSave = new Button();
            cmdOverwriteMain = new Button();
            lblGameTitle = new Label();
            cboBackups.SuspendLayout();
            cboNewSave.SuspendLayout();
            SuspendLayout();
            // 
            // cboBackups
            // 
            cboBackups.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboBackups.Controls.Add(cmdDeleteSelectedSave);
            cboBackups.Controls.Add(lstSaveNames);
            cboBackups.Controls.Add(cmdRenameSelectedSave);
            cboBackups.Controls.Add(cmdLoadSelectedSave);
            cboBackups.Location = new Point(628, 99);
            cboBackups.Name = "cboBackups";
            cboBackups.Size = new Size(294, 237);
            cboBackups.TabIndex = 0;
            cboBackups.TabStop = false;
            cboBackups.Text = "Backups";
            // 
            // cmdDeleteSelectedSave
            // 
            cmdDeleteSelectedSave.Location = new Point(127, 181);
            cmdDeleteSelectedSave.Name = "cmdDeleteSelectedSave";
            cmdDeleteSelectedSave.Size = new Size(165, 40);
            cmdDeleteSelectedSave.TabIndex = 3;
            cmdDeleteSelectedSave.Text = "Delete Selected Save";
            cmdDeleteSelectedSave.UseVisualStyleBackColor = true;
            cmdDeleteSelectedSave.Click += cmdDeleteSelectedSave_Click;
            // 
            // lstSaveNames
            // 
            lstSaveNames.AllowDrop = true;
            lstSaveNames.FormattingEnabled = true;
            lstSaveNames.HorizontalScrollbar = true;
            lstSaveNames.ItemHeight = 15;
            lstSaveNames.Location = new Point(6, 22);
            lstSaveNames.Name = "lstSaveNames";
            lstSaveNames.Size = new Size(100, 199);
            lstSaveNames.TabIndex = 0;
            lstSaveNames.DragDrop += lstSaveNames_DragDrop;
            lstSaveNames.DragEnter += lstSaveNames_DragEnter;
            lstSaveNames.DragOver += lstSaveNames_DragOver;
            lstSaveNames.MouseDown += lstSaveNames_MouseDown;
            // 
            // cmdRenameSelectedSave
            // 
            cmdRenameSelectedSave.Location = new Point(127, 103);
            cmdRenameSelectedSave.Name = "cmdRenameSelectedSave";
            cmdRenameSelectedSave.Size = new Size(165, 40);
            cmdRenameSelectedSave.TabIndex = 2;
            cmdRenameSelectedSave.Text = "Rename Selected Save";
            cmdRenameSelectedSave.UseVisualStyleBackColor = true;
            cmdRenameSelectedSave.Click += cmdRenameSelectedSave_Click;
            // 
            // cmdLoadSelectedSave
            // 
            cmdLoadSelectedSave.Location = new Point(127, 22);
            cmdLoadSelectedSave.Name = "cmdLoadSelectedSave";
            cmdLoadSelectedSave.Size = new Size(165, 40);
            cmdLoadSelectedSave.TabIndex = 1;
            cmdLoadSelectedSave.Text = "Load Selected Save";
            cmdLoadSelectedSave.UseVisualStyleBackColor = true;
            cmdLoadSelectedSave.Click += cmdLoadSelectedSave_Click;
            // 
            // lblCurrentlyLoadedSave
            // 
            lblCurrentlyLoadedSave.Anchor = AnchorStyles.Top;
            lblCurrentlyLoadedSave.AutoSize = true;
            lblCurrentlyLoadedSave.Location = new Point(408, 164);
            lblCurrentlyLoadedSave.Name = "lblCurrentlyLoadedSave";
            lblCurrentlyLoadedSave.Size = new Size(128, 15);
            lblCurrentlyLoadedSave.TabIndex = 1;
            lblCurrentlyLoadedSave.Text = "Currently Loaded Save:";
            // 
            // lblSaveName
            // 
            lblSaveName.Anchor = AnchorStyles.Top;
            lblSaveName.Location = new Point(408, 179);
            lblSaveName.Name = "lblSaveName";
            lblSaveName.Size = new Size(128, 15);
            lblSaveName.TabIndex = 2;
            lblSaveName.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmdLoadMainSave
            // 
            cmdLoadMainSave.Anchor = AnchorStyles.Bottom;
            cmdLoadMainSave.Location = new Point(408, 449);
            cmdLoadMainSave.Name = "cmdLoadMainSave";
            cmdLoadMainSave.Size = new Size(128, 48);
            cmdLoadMainSave.TabIndex = 3;
            cmdLoadMainSave.Text = "Load Main Save";
            cmdLoadMainSave.UseVisualStyleBackColor = true;
            cmdLoadMainSave.Click += cmdLoadMainSave_Click;
            // 
            // cboNewSave
            // 
            cboNewSave.Controls.Add(cmdBackupCurrentSave);
            cboNewSave.Controls.Add(cmdOverwriteMain);
            cboNewSave.Location = new Point(12, 143);
            cboNewSave.Name = "cboNewSave";
            cboNewSave.Size = new Size(200, 126);
            cboNewSave.TabIndex = 4;
            cboNewSave.TabStop = false;
            cboNewSave.Text = "New Save";
            // 
            // cmdBackupCurrentSave
            // 
            cmdBackupCurrentSave.Location = new Point(34, 87);
            cmdBackupCurrentSave.Name = "cmdBackupCurrentSave";
            cmdBackupCurrentSave.Size = new Size(130, 33);
            cmdBackupCurrentSave.TabIndex = 5;
            cmdBackupCurrentSave.Text = "Backup Current Save";
            cmdBackupCurrentSave.UseVisualStyleBackColor = true;
            cmdBackupCurrentSave.Click += cmdBackupCurrentSave_Click;
            // 
            // cmdOverwriteMain
            // 
            cmdOverwriteMain.Location = new Point(34, 21);
            cmdOverwriteMain.Name = "cmdOverwriteMain";
            cmdOverwriteMain.Size = new Size(130, 33);
            cmdOverwriteMain.TabIndex = 0;
            cmdOverwriteMain.Text = "Overwrite Main";
            cmdOverwriteMain.UseVisualStyleBackColor = true;
            cmdOverwriteMain.Click += cmdOverwriteMain_Click;
            // 
            // lblGameTitle
            // 
            lblGameTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblGameTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblGameTitle.Location = new Point(376, 9);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(192, 52);
            lblGameTitle.TabIndex = 5;
            lblGameTitle.Text = "World";
            lblGameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 509);
            ControlBox = false;
            Controls.Add(lblGameTitle);
            Controls.Add(cboNewSave);
            Controls.Add(cmdLoadMainSave);
            Controls.Add(lblSaveName);
            Controls.Add(lblCurrentlyLoadedSave);
            Controls.Add(cboBackups);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaveForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SaveForm";
            WindowState = FormWindowState.Maximized;
            cboBackups.ResumeLayout(false);
            cboNewSave.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox cboBackups;
        private ListBox lstSaveNames;
        private Button cmdDeleteSelectedSave;
        private Button cmdRenameSelectedSave;
        private Button cmdLoadSelectedSave;
        private Label lblCurrentlyLoadedSave;
        private Label lblSaveName;
        private Button cmdLoadMainSave;
        private GroupBox cboNewSave;
        private Button cmdOverwriteMain;
        private Button cmdBackupCurrentSave;
        private Label lblGameTitle;
    }
}