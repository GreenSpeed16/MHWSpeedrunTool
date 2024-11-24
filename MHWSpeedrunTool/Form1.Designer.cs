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
            cboRathian = new ComboBox();
            btnLoadNativePc = new Button();
            SuspendLayout();
            // 
            // cboRathian
            // 
            cboRathian.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathian.FormattingEnabled = true;
            cboRathian.Location = new Point(12, 40);
            cboRathian.Name = "cboRathian";
            cboRathian.Size = new Size(121, 23);
            cboRathian.TabIndex = 0;
            // 
            // btnLoadNativePc
            // 
            btnLoadNativePc.Location = new Point(349, 369);
            btnLoadNativePc.Name = "btnLoadNativePc";
            btnLoadNativePc.Size = new Size(143, 23);
            btnLoadNativePc.TabIndex = 2;
            btnLoadNativePc.Text = "Load to nativePC";
            btnLoadNativePc.UseVisualStyleBackColor = true;
            btnLoadNativePc.Click += btnLoadNativePc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 582);
            Controls.Add(btnLoadNativePc);
            Controls.Add(cboRathian);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboRathian;
        private Button btnLoadNativePc;
    }
}
