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
            cboRathianWaste = new ComboBox();
            btnLoadNativePc = new Button();
            cboRathianForest = new ComboBox();
            cboRathianCoral = new ComboBox();
            cboRathianVale = new ComboBox();
            SuspendLayout();
            // 
            // cboRathianWaste
            // 
            cboRathianWaste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianWaste.FormattingEnabled = true;
            cboRathianWaste.Location = new Point(173, 33);
            cboRathianWaste.Name = "cboRathianWaste";
            cboRathianWaste.Size = new Size(121, 23);
            cboRathianWaste.TabIndex = 0;
            cboRathianWaste.SelectedIndexChanged += cboRathianWaste_SelectedIndexChanged;
            // 
            // btnLoadNativePc
            // 
            btnLoadNativePc.Location = new Point(349, 369);
            btnLoadNativePc.Name = "btnLoadNativePc";
            btnLoadNativePc.Size = new Size(143, 23);
            btnLoadNativePc.TabIndex = 2;
            btnLoadNativePc.Text = "Load to NativePC";
            btnLoadNativePc.UseVisualStyleBackColor = true;
            btnLoadNativePc.Click += btnLoadNativePc_Click;
            // 
            // cboRathianForest
            // 
            cboRathianForest.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianForest.FormattingEnabled = true;
            cboRathianForest.Location = new Point(25, 33);
            cboRathianForest.Name = "cboRathianForest";
            cboRathianForest.Size = new Size(121, 23);
            cboRathianForest.TabIndex = 3;
            cboRathianForest.SelectedIndexChanged += cboRathianForest_SelectedIndexChanged;
            // 
            // cboRathianCoral
            // 
            cboRathianCoral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianCoral.FormattingEnabled = true;
            cboRathianCoral.Location = new Point(25, 98);
            cboRathianCoral.Name = "cboRathianCoral";
            cboRathianCoral.Size = new Size(121, 23);
            cboRathianCoral.TabIndex = 4;
            cboRathianCoral.SelectedIndexChanged += cboRathianCoral_SelectedIndexChanged;
            // 
            // cboRathianVale
            // 
            cboRathianVale.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianVale.FormattingEnabled = true;
            cboRathianVale.Location = new Point(173, 98);
            cboRathianVale.Name = "cboRathianVale";
            cboRathianVale.Size = new Size(121, 23);
            cboRathianVale.TabIndex = 5;
            cboRathianVale.SelectedIndexChanged += cboRathianVale_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 582);
            Controls.Add(cboRathianVale);
            Controls.Add(cboRathianCoral);
            Controls.Add(cboRathianForest);
            Controls.Add(btnLoadNativePc);
            Controls.Add(cboRathianWaste);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboRathianWaste;
        private Button btnLoadNativePc;
        private ComboBox cboRathianForest;
        private ComboBox cboRathianCoral;
        private ComboBox cboRathianVale;
    }
}
