namespace MHWSpeedrunTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlNavigation = new Panel();
            btnLoadWildsSaveForm = new Button();
            btnLoadWorldSaveForm = new Button();
            btnLoadTrackForm = new Button();
            menuStrip1 = new MenuStrip();
            btnTransferFromOldManager = new Button();
            pnlNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = SystemColors.ControlDark;
            pnlNavigation.Controls.Add(btnTransferFromOldManager);
            pnlNavigation.Controls.Add(btnLoadWildsSaveForm);
            pnlNavigation.Controls.Add(btnLoadWorldSaveForm);
            pnlNavigation.Controls.Add(btnLoadTrackForm);
            pnlNavigation.Controls.Add(menuStrip1);
            pnlNavigation.Dock = DockStyle.Top;
            pnlNavigation.Location = new Point(0, 0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(1184, 28);
            pnlNavigation.TabIndex = 4;
            // 
            // btnLoadWildsSaveForm
            // 
            btnLoadWildsSaveForm.BackColor = SystemColors.ControlDark;
            btnLoadWildsSaveForm.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnLoadWildsSaveForm.FlatAppearance.BorderSize = 0;
            btnLoadWildsSaveForm.FlatStyle = FlatStyle.Flat;
            btnLoadWildsSaveForm.Location = new Point(342, 3);
            btnLoadWildsSaveForm.Name = "btnLoadWildsSaveForm";
            btnLoadWildsSaveForm.Size = new Size(168, 23);
            btnLoadWildsSaveForm.TabIndex = 7;
            btnLoadWildsSaveForm.Text = "Wilds Save Management";
            btnLoadWildsSaveForm.UseVisualStyleBackColor = false;
            btnLoadWildsSaveForm.Click += btnLoadWildsSaveForm_Click;
            // 
            // btnLoadWorldSaveForm
            // 
            btnLoadWorldSaveForm.BackColor = SystemColors.ControlDark;
            btnLoadWorldSaveForm.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnLoadWorldSaveForm.FlatAppearance.BorderSize = 0;
            btnLoadWorldSaveForm.FlatStyle = FlatStyle.Flat;
            btnLoadWorldSaveForm.Location = new Point(168, 3);
            btnLoadWorldSaveForm.Name = "btnLoadWorldSaveForm";
            btnLoadWorldSaveForm.Size = new Size(168, 23);
            btnLoadWorldSaveForm.TabIndex = 6;
            btnLoadWorldSaveForm.Text = "World Save Management";
            btnLoadWorldSaveForm.UseVisualStyleBackColor = false;
            btnLoadWorldSaveForm.Click += btnLoadWorldSaveForm_Click;
            // 
            // btnLoadTrackForm
            // 
            btnLoadTrackForm.BackColor = SystemColors.ControlDark;
            btnLoadTrackForm.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnLoadTrackForm.FlatAppearance.BorderSize = 0;
            btnLoadTrackForm.FlatStyle = FlatStyle.Flat;
            btnLoadTrackForm.Location = new Point(3, 2);
            btnLoadTrackForm.Name = "btnLoadTrackForm";
            btnLoadTrackForm.Size = new Size(168, 23);
            btnLoadTrackForm.TabIndex = 5;
            btnLoadTrackForm.Text = "World Track Management";
            btnLoadTrackForm.UseVisualStyleBackColor = false;
            btnLoadTrackForm.Click += btnLoadTrackForm_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // btnTransferFromOldManager
            // 
            btnTransferFromOldManager.BackColor = SystemColors.ControlDark;
            btnTransferFromOldManager.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnTransferFromOldManager.FlatAppearance.BorderSize = 0;
            btnTransferFromOldManager.FlatStyle = FlatStyle.Flat;
            btnTransferFromOldManager.Location = new Point(1008, 3);
            btnTransferFromOldManager.Name = "btnTransferFromOldManager";
            btnTransferFromOldManager.Size = new Size(164, 23);
            btnTransferFromOldManager.TabIndex = 9;
            btnTransferFromOldManager.Text = "Transfer From Old Manager";
            btnTransferFromOldManager.UseVisualStyleBackColor = false;
            btnTransferFromOldManager.Click += btnTransferFromOldManager_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1184, 550);
            Controls.Add(pnlNavigation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MHW Speedrun Tool";
            pnlNavigation.ResumeLayout(false);
            pnlNavigation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNavigation;
        private Button btnLoadTrackForm;
        private Button btnLoadWildsSaveForm;
        private Button btnLoadWorldSaveForm;
        private MenuStrip menuStrip1;
        private Button btnTransferFromOldManager;
    }
}
