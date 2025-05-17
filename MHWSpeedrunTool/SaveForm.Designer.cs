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
            lstSaveNames = new ListBox();
            cmdLoadSelectedSave = new Button();
            cmdRenameSelectedSave = new Button();
            cmdDeleteSelectedSave = new Button();
            lblCurrentlyLoadedSave = new Label();
            lblSaveName = new Label();
            cmdLoadMainSave = new Button();
            cboNewSave = new GroupBox();
            cmdOverwriteMain = new Button();
            cmdBackupCurrentSave = new Button();
            cboBackups.SuspendLayout();
            cboNewSave.SuspendLayout();
            SuspendLayout();
            // 
            // cboBackups
            // 
            cboBackups.Controls.Add(cmdDeleteSelectedSave);
            cboBackups.Controls.Add(lstSaveNames);
            cboBackups.Controls.Add(cmdRenameSelectedSave);
            cboBackups.Controls.Add(cmdLoadSelectedSave);
            cboBackups.Location = new Point(619, 12);
            cboBackups.Name = "cboBackups";
            cboBackups.Size = new Size(370, 409);
            cboBackups.TabIndex = 0;
            cboBackups.TabStop = false;
            cboBackups.Text = "Backups";
            // 
            // lstSaveNames
            // 
            lstSaveNames.FormattingEnabled = true;
            lstSaveNames.ItemHeight = 15;
            lstSaveNames.Location = new Point(22, 22);
            lstSaveNames.Name = "lstSaveNames";
            lstSaveNames.Size = new Size(156, 379);
            lstSaveNames.TabIndex = 0;
            // 
            // cmdLoadSelectedSave
            // 
            cmdLoadSelectedSave.Location = new Point(199, 42);
            cmdLoadSelectedSave.Name = "cmdLoadSelectedSave";
            cmdLoadSelectedSave.Size = new Size(165, 105);
            cmdLoadSelectedSave.TabIndex = 1;
            cmdLoadSelectedSave.Text = "Load Selected Save";
            cmdLoadSelectedSave.UseVisualStyleBackColor = true;
            // 
            // cmdRenameSelectedSave
            // 
            cmdRenameSelectedSave.Location = new Point(199, 153);
            cmdRenameSelectedSave.Name = "cmdRenameSelectedSave";
            cmdRenameSelectedSave.Size = new Size(165, 105);
            cmdRenameSelectedSave.TabIndex = 2;
            cmdRenameSelectedSave.Text = "Rename Selected Save";
            cmdRenameSelectedSave.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteSelectedSave
            // 
            cmdDeleteSelectedSave.Location = new Point(199, 264);
            cmdDeleteSelectedSave.Name = "cmdDeleteSelectedSave";
            cmdDeleteSelectedSave.Size = new Size(165, 105);
            cmdDeleteSelectedSave.TabIndex = 3;
            cmdDeleteSelectedSave.Text = "Delete Selected Save";
            cmdDeleteSelectedSave.UseVisualStyleBackColor = true;
            // 
            // lblCurrentlyLoadedSave
            // 
            lblCurrentlyLoadedSave.AutoSize = true;
            lblCurrentlyLoadedSave.Location = new Point(331, 99);
            lblCurrentlyLoadedSave.Name = "lblCurrentlyLoadedSave";
            lblCurrentlyLoadedSave.Size = new Size(128, 15);
            lblCurrentlyLoadedSave.TabIndex = 1;
            lblCurrentlyLoadedSave.Text = "Currently Loaded Save:";
            // 
            // lblSaveName
            // 
            lblSaveName.Location = new Point(331, 144);
            lblSaveName.Name = "lblSaveName";
            lblSaveName.Size = new Size(128, 15);
            lblSaveName.TabIndex = 2;
            // 
            // cmdLoadMainSave
            // 
            cmdLoadMainSave.Location = new Point(331, 492);
            cmdLoadMainSave.Name = "cmdLoadMainSave";
            cmdLoadMainSave.Size = new Size(128, 48);
            cmdLoadMainSave.TabIndex = 3;
            cmdLoadMainSave.Text = "Load Main Save";
            cmdLoadMainSave.UseVisualStyleBackColor = true;
            // 
            // cboNewSave
            // 
            cboNewSave.Controls.Add(cmdBackupCurrentSave);
            cboNewSave.Controls.Add(cmdOverwriteMain);
            cboNewSave.Location = new Point(12, 144);
            cboNewSave.Name = "cboNewSave";
            cboNewSave.Size = new Size(200, 126);
            cboNewSave.TabIndex = 4;
            cboNewSave.TabStop = false;
            cboNewSave.Text = "New Save";
            // 
            // cmdOverwriteMain
            // 
            cmdOverwriteMain.Location = new Point(34, 21);
            cmdOverwriteMain.Name = "cmdOverwriteMain";
            cmdOverwriteMain.Size = new Size(130, 33);
            cmdOverwriteMain.TabIndex = 0;
            cmdOverwriteMain.Text = "Overwrite Main";
            cmdOverwriteMain.UseVisualStyleBackColor = true;
            // 
            // cmdBackupCurrentSave
            // 
            cmdBackupCurrentSave.Location = new Point(34, 87);
            cmdBackupCurrentSave.Name = "cmdBackupCurrentSave";
            cmdBackupCurrentSave.Size = new Size(130, 33);
            cmdBackupCurrentSave.TabIndex = 5;
            cmdBackupCurrentSave.Text = "Backup Current Save";
            cmdBackupCurrentSave.UseVisualStyleBackColor = true;
            // 
            // SaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 589);
            Controls.Add(cboNewSave);
            Controls.Add(cmdLoadMainSave);
            Controls.Add(lblSaveName);
            Controls.Add(lblCurrentlyLoadedSave);
            Controls.Add(cboBackups);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaveForm";
            Text = "SaveForm";
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
    }
}