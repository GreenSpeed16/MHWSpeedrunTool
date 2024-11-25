using MHWSpeedrunTool.TrackManagement;

namespace MHWSpeedrunTool
{
    public partial class Form1 : Form
    {
        List<MonsterPattern> patterns;
        public Form1()
        {
            InitializeComponent();

            patterns = new List<MonsterPattern>{
                new MonsterPattern(Constants.PINK_RATHIAN_ID),
                new MonsterPattern(Constants.KIRIN_ID),
                new MonsterPattern(Constants.TEOSTRA_ID),
                new MonsterPattern(Constants.KUSHALA_DAORA_ID),
                new MonsterPattern(Constants.VAAL_HAZAK_ID),
                new MonsterPattern(Constants.NERGIGANTE_ID),
                new MonsterPattern(Constants.VELKHANA_ID),
                new MonsterPattern(Constants.BLACKVEIL_ID),
                new MonsterPattern(Constants.NAMIELLE_ID),
            };

            UiController.BindComboBox(cboRathianForest);
            UiController.BindComboBox(cboRathianWaste);
            UiController.BindComboBox(cboRathianCoral);
            UiController.BindComboBox(cboRathianVale);

            UiController.BindComboBox(cboKushala);
            UiController.BindComboBox(cboTeostra);
            UiController.BindComboBox(cboVaal);
            UiController.BindComboBox(cboKirin);
            UiController.BindComboBox(cboNergigante);

            UiController.BindComboBox(cboVelkhanaForest);
            UiController.BindComboBox(cboVelkhanaWaste);
            UiController.BindComboBox(cboVelkhanaCoral);
            UiController.BindComboBox(cboVelkhanaVale);
            UiController.BindComboBox(cboVelkhanaRecess);
            UiController.BindComboBox(cboVelkhanaHoarfrost);

            UiController.BindComboBox(cboBlackveilForest);
            UiController.BindComboBox(cboBlackveilWaste);
            UiController.BindComboBox(cboBlackveilCoral);
            UiController.BindComboBox(cboBlackveilVale);
            UiController.BindComboBox(cboBlackveilRecess);
            UiController.BindComboBox(cboBlackveilHoarfrost);

            UiController.BindComboBox(cboNamielleForest);
            UiController.BindComboBox(cboNamielleWaste);
            UiController.BindComboBox(cboNamielleCoral);
            UiController.BindComboBox(cboNamielleVale);
            UiController.BindComboBox(cboNamielleRecess);
            UiController.BindComboBox(cboNamielleHoarfrost);
        }

        private void btnLoadNativePc_Click(object sender, EventArgs e)
        {
            TrackService.BuildNativePc(patterns);
            UiController.DisableLoadNativePc(btnLoadNativePc);
        }

        // Pink Rathian
        private void cboRathianForest_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.PINK_RATHIAN_ID, Constants.FOREST_ID);
        }

        private void cboRathianWaste_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.PINK_RATHIAN_ID, Constants.WASTE_ID);
        }

        private void cboRathianCoral_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.PINK_RATHIAN_ID, Constants.CORAL_ID);
        }

        private void cboRathianVale_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.PINK_RATHIAN_ID, Constants.VALE_ID);
        }

        //HR Elders
        private void cboKushala_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.KUSHALA_DAORA_ID, Constants.FOREST_ID);
        }

        private void cboTeostra_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.TEOSTRA_ID, Constants.WASTE_ID);
        }

        private void cboVaal_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VAAL_HAZAK_ID, Constants.VALE_ID);
        }

        private void cboKirin_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.KIRIN_ID, Constants.CORAL_ID);
        }

        private void cboNergigante_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NERGIGANTE_ID, Constants.RECESS_ID);
        }

        // Velkhana
        private void cboVelkhanaForest_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VELKHANA_ID, Constants.FOREST_ID);
        }

        private void cboVelkhanaWaste_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VELKHANA_ID, Constants.WASTE_ID);
        }

        private void cboVelkhanaCoral_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VELKHANA_ID, Constants.CORAL_ID);
        }

        private void cboVelkhanaVale_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VELKHANA_ID, Constants.VALE_ID);
        }

        private void cboVelkhanaRecess_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VELKHANA_ID, Constants.RECESS_ID);
        }

        private void cboVelkhanaHoarfrost_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.VELKHANA_ID, Constants.HOARFROST_ID);
        }

        // Blackveil
        private void cboBlackveilForest_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.BLACKVEIL_ID, Constants.FOREST_ID);
        }

        private void cboBlackveilWaste_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.BLACKVEIL_ID, Constants.WASTE_ID);
        }

        private void cboBlackveilCoral_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.BLACKVEIL_ID, Constants.CORAL_ID);
        }

        private void cboBlackveilVale_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.BLACKVEIL_ID, Constants.VALE_ID);
        }

        private void cboBlackveilRecess_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.BLACKVEIL_ID, Constants.RECESS_ID);
        }

        private void cboBlackveilHoarfrost_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.BLACKVEIL_ID, Constants.HOARFROST_ID);
        }

        // Namielle
        private void cboNamielleForest_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NAMIELLE_ID, Constants.FOREST_ID);
        }

        private void cboNamielleWaste_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NAMIELLE_ID, Constants.WASTE_ID);
        }

        private void cboNamielleCoral_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NAMIELLE_ID, Constants.CORAL_ID);
        }

        private void cboNamielleVale_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NAMIELLE_ID, Constants.VALE_ID);
        }

        private void cboNamielleRecess_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NAMIELLE_ID, Constants.RECESS_ID);
        }

        private void cboNamielleHoarfrost_SelectedValueChanged(object sender, EventArgs e)
        {
            HandleComboboxChange(sender, Constants.NAMIELLE_ID, Constants.HOARFROST_ID);
        }

        private void HandleComboboxChange(object sender, string monsterId, string stageId)
        {
            UiController.HandleComboboxChange(sender as ComboBox, monsterId, stageId, patterns, btnLoadNativePc);
        }

        private void cbxShowKirin_CheckedChanged(object sender, EventArgs e)
        {
            var cbx = sender as CheckBox;
            lblKirin.Visible = cbx.Checked;
            cboKirin.Visible = cbx.Checked;

            gpbHrElders.Height = cbx.Checked ? 188 : 137;
        }

        private void cbxShowMr_CheckedChanged(object sender, EventArgs e)
        {
            var cbx = sender as CheckBox;
            gpbVelkhana.Visible = cbx.Checked;
            gpbBlackveil.Visible = cbx.Checked;
            gpbNamielle.Visible = cbx.Checked;

            Height = cbx.Checked ? 587 : 365;
        }
    }
}
