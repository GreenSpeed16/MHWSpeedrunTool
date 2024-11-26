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
            cboRathianWaste = new ComboBox();
            btnLoadNativePc = new Button();
            cboRathianForest = new ComboBox();
            cboRathianCoral = new ComboBox();
            cboRathianVale = new ComboBox();
            gpbRathian = new GroupBox();
            lblRathianVale = new Label();
            lblRathianCoral = new Label();
            lblRathianWaste = new Label();
            lblRathianForest = new Label();
            gpbHrElders = new GroupBox();
            lblNergigante = new Label();
            cboNergigante = new ComboBox();
            lblKirin = new Label();
            lblVaal = new Label();
            lblTeostra = new Label();
            lblKushala = new Label();
            cboKirin = new ComboBox();
            cboVaal = new ComboBox();
            cboTeostra = new ComboBox();
            cboKushala = new ComboBox();
            gpbBlackveil = new GroupBox();
            lblBlackveilHoarfrost = new Label();
            cboBlackveilHoarfrost = new ComboBox();
            lblBlackveilRecess = new Label();
            cboBlackveilRecess = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblBlackveilForest = new Label();
            cboBlackveilForest = new ComboBox();
            cboBlackveilCoral = new ComboBox();
            cboBlackveilVale = new ComboBox();
            cboBlackveilWaste = new ComboBox();
            gpbVelkhana = new GroupBox();
            lblVelkhanaHoarfrost = new Label();
            cboVelkhanaHoarfrost = new ComboBox();
            lblVelkhanaRecess = new Label();
            cboVelkhanaRecess = new ComboBox();
            lblVelkhanaVale = new Label();
            lblVelkhanaCoral = new Label();
            lblVelkhanaWaste = new Label();
            lblVelkhanaForest = new Label();
            cboVelkhanaForest = new ComboBox();
            cboVelkhanaCoral = new ComboBox();
            cboVelkhanaVale = new ComboBox();
            cboVelkhanaWaste = new ComboBox();
            gpbNamielle = new GroupBox();
            lblNamielleHoarfrost = new Label();
            cboNamielleHoarfrost = new ComboBox();
            lblNamielleRecess = new Label();
            cboNamielleRecess = new ComboBox();
            lblNamielleVale = new Label();
            lblNamielleCoral = new Label();
            lblNamielleWaste = new Label();
            lblNamielleForest = new Label();
            cboNamielleForest = new ComboBox();
            cboNamielleCoral = new ComboBox();
            cboNamielleVale = new ComboBox();
            cboNamielleWaste = new ComboBox();
            btnLocateWorldFolder = new Button();
            lblWorldPath = new Label();
            btnSetWorldFolder = new Button();
            gpbRathian.SuspendLayout();
            gpbHrElders.SuspendLayout();
            gpbBlackveil.SuspendLayout();
            gpbVelkhana.SuspendLayout();
            gpbNamielle.SuspendLayout();
            SuspendLayout();
            // 
            // cboRathianWaste
            // 
            cboRathianWaste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianWaste.FormattingEnabled = true;
            cboRathianWaste.Location = new Point(195, 44);
            cboRathianWaste.Name = "cboRathianWaste";
            cboRathianWaste.Size = new Size(121, 23);
            cboRathianWaste.TabIndex = 0;
            cboRathianWaste.SelectedValueChanged += cboRathianWaste_SelectedValueChanged;
            // 
            // btnLoadNativePc
            // 
            btnLoadNativePc.Anchor = AnchorStyles.None;
            btnLoadNativePc.Location = new Point(416, 514);
            btnLoadNativePc.Name = "btnLoadNativePc";
            btnLoadNativePc.Size = new Size(150, 23);
            btnLoadNativePc.TabIndex = 2;
            btnLoadNativePc.Text = "Load to NativePC";
            btnLoadNativePc.UseVisualStyleBackColor = true;
            btnLoadNativePc.Click += btnLoadNativePc_Click;
            // 
            // cboRathianForest
            // 
            cboRathianForest.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianForest.FormattingEnabled = true;
            cboRathianForest.Location = new Point(6, 44);
            cboRathianForest.Name = "cboRathianForest";
            cboRathianForest.Size = new Size(121, 23);
            cboRathianForest.TabIndex = 3;
            cboRathianForest.SelectedValueChanged += cboRathianForest_SelectedValueChanged;
            // 
            // cboRathianCoral
            // 
            cboRathianCoral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianCoral.FormattingEnabled = true;
            cboRathianCoral.Location = new Point(6, 103);
            cboRathianCoral.Name = "cboRathianCoral";
            cboRathianCoral.Size = new Size(121, 23);
            cboRathianCoral.TabIndex = 4;
            cboRathianCoral.SelectedValueChanged += cboRathianCoral_SelectedValueChanged;
            // 
            // cboRathianVale
            // 
            cboRathianVale.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRathianVale.FormattingEnabled = true;
            cboRathianVale.Location = new Point(195, 103);
            cboRathianVale.Name = "cboRathianVale";
            cboRathianVale.Size = new Size(121, 23);
            cboRathianVale.TabIndex = 5;
            cboRathianVale.SelectedValueChanged += cboRathianVale_SelectedValueChanged;
            // 
            // gpbRathian
            // 
            gpbRathian.Controls.Add(lblRathianVale);
            gpbRathian.Controls.Add(lblRathianCoral);
            gpbRathian.Controls.Add(lblRathianWaste);
            gpbRathian.Controls.Add(lblRathianForest);
            gpbRathian.Controls.Add(cboRathianForest);
            gpbRathian.Controls.Add(cboRathianCoral);
            gpbRathian.Controls.Add(cboRathianVale);
            gpbRathian.Controls.Add(cboRathianWaste);
            gpbRathian.Location = new Point(9, 38);
            gpbRathian.Name = "gpbRathian";
            gpbRathian.Size = new Size(322, 137);
            gpbRathian.TabIndex = 6;
            gpbRathian.TabStop = false;
            gpbRathian.Text = "Pink Rathian";
            // 
            // lblRathianVale
            // 
            lblRathianVale.AutoSize = true;
            lblRathianVale.Location = new Point(195, 85);
            lblRathianVale.Name = "lblRathianVale";
            lblRathianVale.Size = new Size(66, 15);
            lblRathianVale.TabIndex = 7;
            lblRathianVale.Text = "Rotten Vale";
            // 
            // lblRathianCoral
            // 
            lblRathianCoral.AutoSize = true;
            lblRathianCoral.Location = new Point(6, 85);
            lblRathianCoral.Name = "lblRathianCoral";
            lblRathianCoral.Size = new Size(92, 15);
            lblRathianCoral.TabIndex = 7;
            lblRathianCoral.Text = "Coral Highlands";
            // 
            // lblRathianWaste
            // 
            lblRathianWaste.AutoSize = true;
            lblRathianWaste.Location = new Point(195, 26);
            lblRathianWaste.Name = "lblRathianWaste";
            lblRathianWaste.Size = new Size(91, 15);
            lblRathianWaste.TabIndex = 7;
            lblRathianWaste.Text = "Wildspire Waste";
            // 
            // lblRathianForest
            // 
            lblRathianForest.AutoSize = true;
            lblRathianForest.Location = new Point(6, 26);
            lblRathianForest.Name = "lblRathianForest";
            lblRathianForest.Size = new Size(83, 15);
            lblRathianForest.TabIndex = 6;
            lblRathianForest.Text = "Ancient Forest";
            // 
            // gpbHrElders
            // 
            gpbHrElders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gpbHrElders.Controls.Add(lblNergigante);
            gpbHrElders.Controls.Add(cboNergigante);
            gpbHrElders.Controls.Add(lblKirin);
            gpbHrElders.Controls.Add(lblVaal);
            gpbHrElders.Controls.Add(lblTeostra);
            gpbHrElders.Controls.Add(lblKushala);
            gpbHrElders.Controls.Add(cboKirin);
            gpbHrElders.Controls.Add(cboVaal);
            gpbHrElders.Controls.Add(cboTeostra);
            gpbHrElders.Controls.Add(cboKushala);
            gpbHrElders.Location = new Point(669, 38);
            gpbHrElders.Name = "gpbHrElders";
            gpbHrElders.Size = new Size(322, 187);
            gpbHrElders.TabIndex = 7;
            gpbHrElders.TabStop = false;
            gpbHrElders.Text = "HR Elders";
            // 
            // lblNergigante
            // 
            lblNergigante.AutoSize = true;
            lblNergigante.Location = new Point(195, 85);
            lblNergigante.Name = "lblNergigante";
            lblNergigante.Size = new Size(66, 15);
            lblNergigante.TabIndex = 16;
            lblNergigante.Text = "Nergigante";
            // 
            // cboNergigante
            // 
            cboNergigante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNergigante.FormattingEnabled = true;
            cboNergigante.Location = new Point(195, 103);
            cboNergigante.Name = "cboNergigante";
            cboNergigante.Size = new Size(121, 23);
            cboNergigante.TabIndex = 15;
            cboNergigante.SelectedValueChanged += cboNergigante_SelectedValueChanged;
            // 
            // lblKirin
            // 
            lblKirin.AutoSize = true;
            lblKirin.Location = new Point(6, 139);
            lblKirin.Name = "lblKirin";
            lblKirin.Size = new Size(31, 15);
            lblKirin.TabIndex = 14;
            lblKirin.Text = "Kirin";
            // 
            // lblVaal
            // 
            lblVaal.AutoSize = true;
            lblVaal.Location = new Point(6, 85);
            lblVaal.Name = "lblVaal";
            lblVaal.Size = new Size(63, 15);
            lblVaal.TabIndex = 13;
            lblVaal.Text = "Vaal Hazak";
            // 
            // lblTeostra
            // 
            lblTeostra.AutoSize = true;
            lblTeostra.Location = new Point(195, 26);
            lblTeostra.Name = "lblTeostra";
            lblTeostra.Size = new Size(44, 15);
            lblTeostra.TabIndex = 12;
            lblTeostra.Text = "Teostra";
            // 
            // lblKushala
            // 
            lblKushala.AutoSize = true;
            lblKushala.Location = new Point(6, 26);
            lblKushala.Name = "lblKushala";
            lblKushala.Size = new Size(82, 15);
            lblKushala.TabIndex = 8;
            lblKushala.Text = "Kushala Daora";
            // 
            // cboKirin
            // 
            cboKirin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKirin.FormattingEnabled = true;
            cboKirin.Location = new Point(6, 157);
            cboKirin.Name = "cboKirin";
            cboKirin.Size = new Size(121, 23);
            cboKirin.TabIndex = 11;
            cboKirin.SelectedValueChanged += cboKirin_SelectedValueChanged;
            // 
            // cboVaal
            // 
            cboVaal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaal.FormattingEnabled = true;
            cboVaal.Location = new Point(6, 103);
            cboVaal.Name = "cboVaal";
            cboVaal.Size = new Size(121, 23);
            cboVaal.TabIndex = 10;
            cboVaal.SelectedValueChanged += cboVaal_SelectedValueChanged;
            // 
            // cboTeostra
            // 
            cboTeostra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTeostra.FormattingEnabled = true;
            cboTeostra.Location = new Point(195, 44);
            cboTeostra.Name = "cboTeostra";
            cboTeostra.Size = new Size(121, 23);
            cboTeostra.TabIndex = 9;
            cboTeostra.SelectedValueChanged += cboTeostra_SelectedValueChanged;
            // 
            // cboKushala
            // 
            cboKushala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKushala.FormattingEnabled = true;
            cboKushala.Location = new Point(6, 44);
            cboKushala.Name = "cboKushala";
            cboKushala.Size = new Size(121, 23);
            cboKushala.TabIndex = 8;
            cboKushala.SelectedValueChanged += cboKushala_SelectedValueChanged;
            // 
            // gpbBlackveil
            // 
            gpbBlackveil.Anchor = AnchorStyles.None;
            gpbBlackveil.Controls.Add(lblBlackveilHoarfrost);
            gpbBlackveil.Controls.Add(cboBlackveilHoarfrost);
            gpbBlackveil.Controls.Add(lblBlackveilRecess);
            gpbBlackveil.Controls.Add(cboBlackveilRecess);
            gpbBlackveil.Controls.Add(label1);
            gpbBlackveil.Controls.Add(label2);
            gpbBlackveil.Controls.Add(label3);
            gpbBlackveil.Controls.Add(lblBlackveilForest);
            gpbBlackveil.Controls.Add(cboBlackveilForest);
            gpbBlackveil.Controls.Add(cboBlackveilCoral);
            gpbBlackveil.Controls.Add(cboBlackveilVale);
            gpbBlackveil.Controls.Add(cboBlackveilWaste);
            gpbBlackveil.Location = new Point(339, 261);
            gpbBlackveil.Name = "gpbBlackveil";
            gpbBlackveil.Size = new Size(322, 195);
            gpbBlackveil.TabIndex = 8;
            gpbBlackveil.TabStop = false;
            gpbBlackveil.Text = "Blackveil Vaal Hazak";
            // 
            // lblBlackveilHoarfrost
            // 
            lblBlackveilHoarfrost.AutoSize = true;
            lblBlackveilHoarfrost.Location = new Point(195, 148);
            lblBlackveilHoarfrost.Name = "lblBlackveilHoarfrost";
            lblBlackveilHoarfrost.Size = new Size(92, 15);
            lblBlackveilHoarfrost.TabIndex = 11;
            lblBlackveilHoarfrost.Text = "Hoarfrost Reach";
            // 
            // cboBlackveilHoarfrost
            // 
            cboBlackveilHoarfrost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBlackveilHoarfrost.FormattingEnabled = true;
            cboBlackveilHoarfrost.Location = new Point(195, 166);
            cboBlackveilHoarfrost.Name = "cboBlackveilHoarfrost";
            cboBlackveilHoarfrost.Size = new Size(121, 23);
            cboBlackveilHoarfrost.TabIndex = 10;
            cboBlackveilHoarfrost.SelectedValueChanged += cboBlackveilHoarfrost_SelectedValueChanged;
            // 
            // lblBlackveilRecess
            // 
            lblBlackveilRecess.AutoSize = true;
            lblBlackveilRecess.Location = new Point(6, 148);
            lblBlackveilRecess.Name = "lblBlackveilRecess";
            lblBlackveilRecess.Size = new Size(79, 15);
            lblBlackveilRecess.TabIndex = 9;
            lblBlackveilRecess.Text = "Elder's Recess";
            // 
            // cboBlackveilRecess
            // 
            cboBlackveilRecess.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBlackveilRecess.FormattingEnabled = true;
            cboBlackveilRecess.Location = new Point(6, 166);
            cboBlackveilRecess.Name = "cboBlackveilRecess";
            cboBlackveilRecess.Size = new Size(121, 23);
            cboBlackveilRecess.TabIndex = 8;
            cboBlackveilRecess.SelectedValueChanged += cboBlackveilRecess_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 85);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Rotten Vale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 7;
            label2.Text = "Coral Highlands";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 26);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "Wildspire Waste";
            // 
            // lblBlackveilForest
            // 
            lblBlackveilForest.AutoSize = true;
            lblBlackveilForest.Location = new Point(6, 26);
            lblBlackveilForest.Name = "lblBlackveilForest";
            lblBlackveilForest.Size = new Size(83, 15);
            lblBlackveilForest.TabIndex = 6;
            lblBlackveilForest.Text = "Ancient Forest";
            // 
            // cboBlackveilForest
            // 
            cboBlackveilForest.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBlackveilForest.FormattingEnabled = true;
            cboBlackveilForest.Location = new Point(6, 44);
            cboBlackveilForest.Name = "cboBlackveilForest";
            cboBlackveilForest.Size = new Size(121, 23);
            cboBlackveilForest.TabIndex = 3;
            cboBlackveilForest.SelectedValueChanged += cboBlackveilForest_SelectedValueChanged;
            // 
            // cboBlackveilCoral
            // 
            cboBlackveilCoral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBlackveilCoral.FormattingEnabled = true;
            cboBlackveilCoral.Location = new Point(6, 103);
            cboBlackveilCoral.Name = "cboBlackveilCoral";
            cboBlackveilCoral.Size = new Size(121, 23);
            cboBlackveilCoral.TabIndex = 4;
            cboBlackveilCoral.SelectedValueChanged += cboBlackveilCoral_SelectedValueChanged;
            // 
            // cboBlackveilVale
            // 
            cboBlackveilVale.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBlackveilVale.FormattingEnabled = true;
            cboBlackveilVale.Location = new Point(195, 103);
            cboBlackveilVale.Name = "cboBlackveilVale";
            cboBlackveilVale.Size = new Size(121, 23);
            cboBlackveilVale.TabIndex = 5;
            cboBlackveilVale.SelectedValueChanged += cboBlackveilVale_SelectedValueChanged;
            // 
            // cboBlackveilWaste
            // 
            cboBlackveilWaste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBlackveilWaste.FormattingEnabled = true;
            cboBlackveilWaste.Location = new Point(195, 44);
            cboBlackveilWaste.Name = "cboBlackveilWaste";
            cboBlackveilWaste.Size = new Size(121, 23);
            cboBlackveilWaste.TabIndex = 0;
            cboBlackveilWaste.SelectedValueChanged += cboBlackveilWaste_SelectedValueChanged;
            // 
            // gpbVelkhana
            // 
            gpbVelkhana.Anchor = AnchorStyles.Left;
            gpbVelkhana.Controls.Add(lblVelkhanaHoarfrost);
            gpbVelkhana.Controls.Add(cboVelkhanaHoarfrost);
            gpbVelkhana.Controls.Add(lblVelkhanaRecess);
            gpbVelkhana.Controls.Add(cboVelkhanaRecess);
            gpbVelkhana.Controls.Add(lblVelkhanaVale);
            gpbVelkhana.Controls.Add(lblVelkhanaCoral);
            gpbVelkhana.Controls.Add(lblVelkhanaWaste);
            gpbVelkhana.Controls.Add(lblVelkhanaForest);
            gpbVelkhana.Controls.Add(cboVelkhanaForest);
            gpbVelkhana.Controls.Add(cboVelkhanaCoral);
            gpbVelkhana.Controls.Add(cboVelkhanaVale);
            gpbVelkhana.Controls.Add(cboVelkhanaWaste);
            gpbVelkhana.Location = new Point(9, 261);
            gpbVelkhana.Name = "gpbVelkhana";
            gpbVelkhana.Size = new Size(322, 195);
            gpbVelkhana.TabIndex = 12;
            gpbVelkhana.TabStop = false;
            gpbVelkhana.Text = "Velkhana";
            // 
            // lblVelkhanaHoarfrost
            // 
            lblVelkhanaHoarfrost.AutoSize = true;
            lblVelkhanaHoarfrost.Location = new Point(195, 148);
            lblVelkhanaHoarfrost.Name = "lblVelkhanaHoarfrost";
            lblVelkhanaHoarfrost.Size = new Size(92, 15);
            lblVelkhanaHoarfrost.TabIndex = 11;
            lblVelkhanaHoarfrost.Text = "Hoarfrost Reach";
            // 
            // cboVelkhanaHoarfrost
            // 
            cboVelkhanaHoarfrost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVelkhanaHoarfrost.FormattingEnabled = true;
            cboVelkhanaHoarfrost.Location = new Point(195, 166);
            cboVelkhanaHoarfrost.Name = "cboVelkhanaHoarfrost";
            cboVelkhanaHoarfrost.Size = new Size(121, 23);
            cboVelkhanaHoarfrost.TabIndex = 10;
            cboVelkhanaHoarfrost.SelectedValueChanged += cboVelkhanaHoarfrost_SelectedValueChanged;
            // 
            // lblVelkhanaRecess
            // 
            lblVelkhanaRecess.AutoSize = true;
            lblVelkhanaRecess.Location = new Point(6, 148);
            lblVelkhanaRecess.Name = "lblVelkhanaRecess";
            lblVelkhanaRecess.Size = new Size(79, 15);
            lblVelkhanaRecess.TabIndex = 9;
            lblVelkhanaRecess.Text = "Elder's Recess";
            // 
            // cboVelkhanaRecess
            // 
            cboVelkhanaRecess.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVelkhanaRecess.FormattingEnabled = true;
            cboVelkhanaRecess.Location = new Point(6, 166);
            cboVelkhanaRecess.Name = "cboVelkhanaRecess";
            cboVelkhanaRecess.Size = new Size(121, 23);
            cboVelkhanaRecess.TabIndex = 8;
            cboVelkhanaRecess.SelectedValueChanged += cboVelkhanaRecess_SelectedValueChanged;
            // 
            // lblVelkhanaVale
            // 
            lblVelkhanaVale.AutoSize = true;
            lblVelkhanaVale.Location = new Point(195, 85);
            lblVelkhanaVale.Name = "lblVelkhanaVale";
            lblVelkhanaVale.Size = new Size(66, 15);
            lblVelkhanaVale.TabIndex = 7;
            lblVelkhanaVale.Text = "Rotten Vale";
            // 
            // lblVelkhanaCoral
            // 
            lblVelkhanaCoral.AutoSize = true;
            lblVelkhanaCoral.Location = new Point(6, 85);
            lblVelkhanaCoral.Name = "lblVelkhanaCoral";
            lblVelkhanaCoral.Size = new Size(92, 15);
            lblVelkhanaCoral.TabIndex = 7;
            lblVelkhanaCoral.Text = "Coral Highlands";
            // 
            // lblVelkhanaWaste
            // 
            lblVelkhanaWaste.AutoSize = true;
            lblVelkhanaWaste.Location = new Point(195, 26);
            lblVelkhanaWaste.Name = "lblVelkhanaWaste";
            lblVelkhanaWaste.Size = new Size(91, 15);
            lblVelkhanaWaste.TabIndex = 7;
            lblVelkhanaWaste.Text = "Wildspire Waste";
            // 
            // lblVelkhanaForest
            // 
            lblVelkhanaForest.AutoSize = true;
            lblVelkhanaForest.Location = new Point(6, 26);
            lblVelkhanaForest.Name = "lblVelkhanaForest";
            lblVelkhanaForest.Size = new Size(83, 15);
            lblVelkhanaForest.TabIndex = 6;
            lblVelkhanaForest.Text = "Ancient Forest";
            // 
            // cboVelkhanaForest
            // 
            cboVelkhanaForest.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVelkhanaForest.FormattingEnabled = true;
            cboVelkhanaForest.Location = new Point(6, 44);
            cboVelkhanaForest.Name = "cboVelkhanaForest";
            cboVelkhanaForest.Size = new Size(121, 23);
            cboVelkhanaForest.TabIndex = 3;
            cboVelkhanaForest.SelectedValueChanged += cboVelkhanaForest_SelectedValueChanged;
            // 
            // cboVelkhanaCoral
            // 
            cboVelkhanaCoral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVelkhanaCoral.FormattingEnabled = true;
            cboVelkhanaCoral.Location = new Point(6, 103);
            cboVelkhanaCoral.Name = "cboVelkhanaCoral";
            cboVelkhanaCoral.Size = new Size(121, 23);
            cboVelkhanaCoral.TabIndex = 4;
            cboVelkhanaCoral.SelectedValueChanged += cboVelkhanaCoral_SelectedValueChanged;
            // 
            // cboVelkhanaVale
            // 
            cboVelkhanaVale.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVelkhanaVale.FormattingEnabled = true;
            cboVelkhanaVale.Location = new Point(195, 103);
            cboVelkhanaVale.Name = "cboVelkhanaVale";
            cboVelkhanaVale.Size = new Size(121, 23);
            cboVelkhanaVale.TabIndex = 5;
            cboVelkhanaVale.SelectedValueChanged += cboVelkhanaVale_SelectedValueChanged;
            // 
            // cboVelkhanaWaste
            // 
            cboVelkhanaWaste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVelkhanaWaste.FormattingEnabled = true;
            cboVelkhanaWaste.Location = new Point(195, 44);
            cboVelkhanaWaste.Name = "cboVelkhanaWaste";
            cboVelkhanaWaste.Size = new Size(121, 23);
            cboVelkhanaWaste.TabIndex = 0;
            cboVelkhanaWaste.SelectedValueChanged += cboVelkhanaWaste_SelectedValueChanged;
            // 
            // gpbNamielle
            // 
            gpbNamielle.Anchor = AnchorStyles.Right;
            gpbNamielle.Controls.Add(lblNamielleHoarfrost);
            gpbNamielle.Controls.Add(cboNamielleHoarfrost);
            gpbNamielle.Controls.Add(lblNamielleRecess);
            gpbNamielle.Controls.Add(cboNamielleRecess);
            gpbNamielle.Controls.Add(lblNamielleVale);
            gpbNamielle.Controls.Add(lblNamielleCoral);
            gpbNamielle.Controls.Add(lblNamielleWaste);
            gpbNamielle.Controls.Add(lblNamielleForest);
            gpbNamielle.Controls.Add(cboNamielleForest);
            gpbNamielle.Controls.Add(cboNamielleCoral);
            gpbNamielle.Controls.Add(cboNamielleVale);
            gpbNamielle.Controls.Add(cboNamielleWaste);
            gpbNamielle.Location = new Point(669, 261);
            gpbNamielle.Name = "gpbNamielle";
            gpbNamielle.Size = new Size(322, 195);
            gpbNamielle.TabIndex = 12;
            gpbNamielle.TabStop = false;
            gpbNamielle.Text = "Namielle";
            // 
            // lblNamielleHoarfrost
            // 
            lblNamielleHoarfrost.AutoSize = true;
            lblNamielleHoarfrost.Location = new Point(195, 148);
            lblNamielleHoarfrost.Name = "lblNamielleHoarfrost";
            lblNamielleHoarfrost.Size = new Size(92, 15);
            lblNamielleHoarfrost.TabIndex = 11;
            lblNamielleHoarfrost.Text = "Hoarfrost Reach";
            // 
            // cboNamielleHoarfrost
            // 
            cboNamielleHoarfrost.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamielleHoarfrost.FormattingEnabled = true;
            cboNamielleHoarfrost.Location = new Point(195, 166);
            cboNamielleHoarfrost.Name = "cboNamielleHoarfrost";
            cboNamielleHoarfrost.Size = new Size(121, 23);
            cboNamielleHoarfrost.TabIndex = 10;
            cboNamielleHoarfrost.SelectedValueChanged += cboNamielleHoarfrost_SelectedValueChanged;
            // 
            // lblNamielleRecess
            // 
            lblNamielleRecess.AutoSize = true;
            lblNamielleRecess.Location = new Point(6, 148);
            lblNamielleRecess.Name = "lblNamielleRecess";
            lblNamielleRecess.Size = new Size(79, 15);
            lblNamielleRecess.TabIndex = 9;
            lblNamielleRecess.Text = "Elder's Recess";
            // 
            // cboNamielleRecess
            // 
            cboNamielleRecess.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamielleRecess.FormattingEnabled = true;
            cboNamielleRecess.Location = new Point(6, 166);
            cboNamielleRecess.Name = "cboNamielleRecess";
            cboNamielleRecess.Size = new Size(121, 23);
            cboNamielleRecess.TabIndex = 8;
            cboNamielleRecess.SelectedValueChanged += cboNamielleRecess_SelectedValueChanged;
            // 
            // lblNamielleVale
            // 
            lblNamielleVale.AutoSize = true;
            lblNamielleVale.Location = new Point(195, 85);
            lblNamielleVale.Name = "lblNamielleVale";
            lblNamielleVale.Size = new Size(66, 15);
            lblNamielleVale.TabIndex = 7;
            lblNamielleVale.Text = "Rotten Vale";
            // 
            // lblNamielleCoral
            // 
            lblNamielleCoral.AutoSize = true;
            lblNamielleCoral.Location = new Point(6, 85);
            lblNamielleCoral.Name = "lblNamielleCoral";
            lblNamielleCoral.Size = new Size(92, 15);
            lblNamielleCoral.TabIndex = 7;
            lblNamielleCoral.Text = "Coral Highlands";
            // 
            // lblNamielleWaste
            // 
            lblNamielleWaste.AutoSize = true;
            lblNamielleWaste.Location = new Point(195, 26);
            lblNamielleWaste.Name = "lblNamielleWaste";
            lblNamielleWaste.Size = new Size(91, 15);
            lblNamielleWaste.TabIndex = 7;
            lblNamielleWaste.Text = "Wildspire Waste";
            // 
            // lblNamielleForest
            // 
            lblNamielleForest.AutoSize = true;
            lblNamielleForest.Location = new Point(6, 26);
            lblNamielleForest.Name = "lblNamielleForest";
            lblNamielleForest.Size = new Size(83, 15);
            lblNamielleForest.TabIndex = 6;
            lblNamielleForest.Text = "Ancient Forest";
            // 
            // cboNamielleForest
            // 
            cboNamielleForest.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamielleForest.FormattingEnabled = true;
            cboNamielleForest.Location = new Point(6, 44);
            cboNamielleForest.Name = "cboNamielleForest";
            cboNamielleForest.Size = new Size(121, 23);
            cboNamielleForest.TabIndex = 3;
            cboNamielleForest.SelectedValueChanged += cboNamielleForest_SelectedValueChanged;
            // 
            // cboNamielleCoral
            // 
            cboNamielleCoral.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamielleCoral.FormattingEnabled = true;
            cboNamielleCoral.Location = new Point(6, 103);
            cboNamielleCoral.Name = "cboNamielleCoral";
            cboNamielleCoral.Size = new Size(121, 23);
            cboNamielleCoral.TabIndex = 4;
            cboNamielleCoral.SelectedValueChanged += cboNamielleCoral_SelectedValueChanged;
            // 
            // cboNamielleVale
            // 
            cboNamielleVale.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamielleVale.FormattingEnabled = true;
            cboNamielleVale.Location = new Point(195, 103);
            cboNamielleVale.Name = "cboNamielleVale";
            cboNamielleVale.Size = new Size(121, 23);
            cboNamielleVale.TabIndex = 5;
            cboNamielleVale.SelectedValueChanged += cboNamielleVale_SelectedValueChanged;
            // 
            // cboNamielleWaste
            // 
            cboNamielleWaste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNamielleWaste.FormattingEnabled = true;
            cboNamielleWaste.Location = new Point(195, 44);
            cboNamielleWaste.Name = "cboNamielleWaste";
            cboNamielleWaste.Size = new Size(121, 23);
            cboNamielleWaste.TabIndex = 0;
            cboNamielleWaste.SelectedValueChanged += cboNamielleWaste_SelectedValueChanged;
            // 
            // btnLocateWorldFolder
            // 
            btnLocateWorldFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLocateWorldFolder.Location = new Point(828, 514);
            btnLocateWorldFolder.Name = "btnLocateWorldFolder";
            btnLocateWorldFolder.Size = new Size(150, 23);
            btnLocateWorldFolder.TabIndex = 13;
            btnLocateWorldFolder.Text = "Locate MHW Folder";
            btnLocateWorldFolder.UseVisualStyleBackColor = true;
            btnLocateWorldFolder.Click += btnLocateWorldFolder_Click;
            // 
            // lblWorldPath
            // 
            lblWorldPath.AutoSize = true;
            lblWorldPath.Location = new Point(656, 459);
            lblWorldPath.MaximumSize = new Size(322, 0);
            lblWorldPath.Name = "lblWorldPath";
            lblWorldPath.RightToLeft = RightToLeft.No;
            lblWorldPath.Size = new Size(102, 15);
            lblWorldPath.TabIndex = 14;
            lblWorldPath.Text = "MHW Install Path:";
            lblWorldPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSetWorldFolder
            // 
            btnSetWorldFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSetWorldFolder.Location = new Point(656, 514);
            btnSetWorldFolder.Name = "btnSetWorldFolder";
            btnSetWorldFolder.Size = new Size(150, 23);
            btnSetWorldFolder.TabIndex = 15;
            btnSetWorldFolder.Text = "Input MHW Folder";
            btnSetWorldFolder.UseVisualStyleBackColor = true;
            btnSetWorldFolder.Click += btnSetWorldFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1001, 589);
            Controls.Add(btnSetWorldFolder);
            Controls.Add(lblWorldPath);
            Controls.Add(btnLocateWorldFolder);
            Controls.Add(gpbNamielle);
            Controls.Add(gpbVelkhana);
            Controls.Add(gpbBlackveil);
            Controls.Add(gpbHrElders);
            Controls.Add(gpbRathian);
            Controls.Add(btnLoadNativePc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(5, 0, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MHW Speedrun Tool";
            gpbRathian.ResumeLayout(false);
            gpbRathian.PerformLayout();
            gpbHrElders.ResumeLayout(false);
            gpbHrElders.PerformLayout();
            gpbBlackveil.ResumeLayout(false);
            gpbBlackveil.PerformLayout();
            gpbVelkhana.ResumeLayout(false);
            gpbVelkhana.PerformLayout();
            gpbNamielle.ResumeLayout(false);
            gpbNamielle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboRathianWaste;
        private Button btnLoadNativePc;
        private ComboBox cboRathianForest;
        private ComboBox cboRathianCoral;
        private ComboBox cboRathianVale;
        private GroupBox gpbRathian;
        private Label lblRathianWaste;
        private Label lblRathianForest;
        private Label lblRathianVale;
        private Label lblRathianCoral;
        private GroupBox gpbHrElders;
        private Label lblKirin;
        private Label lblVaal;
        private Label lblTeostra;
        private Label lblKushala;
        private ComboBox cboKirin;
        private ComboBox cboVaal;
        private ComboBox cboTeostra;
        private ComboBox cboKushala;
        private Label lblNergigante;
        private ComboBox cboNergigante;
        private GroupBox gpbBlackveil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblBlackveilForest;
        private ComboBox cboBlackveilForest;
        private ComboBox cboBlackveilCoral;
        private ComboBox cboBlackveilVale;
        private ComboBox cboBlackveilWaste;
        private Label lblBlackveilHoarfrost;
        private ComboBox cboBlackveilHoarfrost;
        private Label lblBlackveilRecess;
        private ComboBox cboBlackveilRecess;
        private GroupBox gpbVelkhana;
        private Label lblVelkhanaHoarfrost;
        private ComboBox cboVelkhanaHoarfrost;
        private Label lblVelkhanaRecess;
        private ComboBox cboVelkhanaRecess;
        private Label lblVelkhanaVale;
        private Label lblVelkhanaCoral;
        private Label lblVelkhanaWaste;
        private Label lblVelkhanaForest;
        private ComboBox cboVelkhanaForest;
        private ComboBox cboVelkhanaCoral;
        private ComboBox cboVelkhanaVale;
        private ComboBox cboVelkhanaWaste;
        private GroupBox gpbNamielle;
        private Label lblNamielleHoarfrost;
        private ComboBox cboNamielleHoarfrost;
        private Label lblNamielleRecess;
        private ComboBox cboNamielleRecess;
        private Label lblNamielleVale;
        private Label lblNamielleCoral;
        private Label lblNamielleWaste;
        private Label lblNamielleForest;
        private ComboBox cboNamielleForest;
        private ComboBox cboNamielleCoral;
        private ComboBox cboNamielleVale;
        private ComboBox cboNamielleWaste;
        private Button btnLocateWorldFolder;
        private Label lblWorldPath;
        private Button btnSetWorldFolder;
    }
}
