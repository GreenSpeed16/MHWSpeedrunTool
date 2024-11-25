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
        }

        private void btnLoadNativePc_Click(object sender, EventArgs e)
        {
            TrackService.BuildNativePc(patterns);
            UiController.DisableLoadNativePc(btnLoadNativePc);
        }

        private void cboRathianForest_SelectedIndexChanged(object sender, EventArgs e)
        {
            UiController.HandleComboboxChange((ComboBox)sender, Constants.PINK_RATHIAN_ID, Constants.FOREST_ID, patterns, btnLoadNativePc);
        }

        private void cboRathianWaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            UiController.HandleComboboxChange((ComboBox)sender, Constants.PINK_RATHIAN_ID, Constants.WASTE_ID, patterns, btnLoadNativePc);
        }

        private void cboRathianCoral_SelectedIndexChanged(object sender, EventArgs e)
        {
            UiController.HandleComboboxChange((ComboBox)sender, Constants.PINK_RATHIAN_ID, Constants.CORAL_ID, patterns, btnLoadNativePc);
        }

        private void cboRathianVale_SelectedIndexChanged(object sender, EventArgs e)
        {
            UiController.HandleComboboxChange((ComboBox)sender, Constants.PINK_RATHIAN_ID, Constants.VALE_ID, patterns, btnLoadNativePc);
        }
    }
}
