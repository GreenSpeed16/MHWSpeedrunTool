using MHWSpeedrunTool.SaveManagement;

namespace MHWSpeedrunTool
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        void RefreshUi()
        {
            UiController.SetSaveList(lstSaveNames, lblSaveName);

            // Disable buttons if there is no relevant save folder or if steam is closed and cannot find the user's id
            bool enableBtns = Path.Exists(SaveDataService.CurrentGameSaveFolder);

            string disabledReason = "";
            if (!enableBtns)
            {
                disabledReason = Constants.STEAM_ID == "0" ? "Steam is Not Open" : "Game is Not Installed";
            }

            ToggleButton(cmdLoadMainSave, enableBtns, "Load Main Save", disabledReason);
            ToggleButton(cmdLoadSelectedSave, enableBtns, "Load Selected Save", disabledReason);
            ToggleButton(cmdBackupCurrentSave, enableBtns, "Backup Current Save", disabledReason);
            ToggleButton(cmdOverwriteMain, enableBtns, "Overwrite Main", disabledReason);
        }

        void ToggleButton(Button btn, bool btnEnabled, string enabledText, string disabledText)
        {
            btn.Text = btnEnabled ? enabledText : disabledText;
            btn.Enabled = btnEnabled;
        }

        public void ChangeTitle(string title)
        {
            lblSaveName.Text = SaveDataService.LoadedSave;
            lblGameTitle.Text = title;
            RefreshUi();
        }

        private void cmdLoadSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.LoadSave(lstSaveNames.SelectedItem.ToString());
            RefreshUi();
        }

        private void cmdRenameSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.RenameSave(lstSaveNames.SelectedItem.ToString());
            UiController.SetSaveList(lstSaveNames,lblSaveName);
        }

        private void cmdDeleteSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.DeleteSave(lstSaveNames.SelectedItem.ToString(), lstSaveNames);
            RefreshUi();
        }

        private void cmdLoadMainSave_Click(object sender, EventArgs e)
        {
            UiController.LoadSave("Main");
            RefreshUi();
        }

        private void cmdBackupCurrentSave_Click(object sender, EventArgs e)
        {
            UiController.BackupSave();
            RefreshUi();
        }

        private void cmdOverwriteMain_Click(object sender, EventArgs e)
        {
            UiController.OverwriteMainSave();
            RefreshUi();
        }
    }
}
