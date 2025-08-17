using MHWSpeedrunTool.SaveManagement;
using MHWSpeedrunTool.TrackManagement;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace MHWSpeedrunTool
{
    public partial class Form1 : Form
    {
        WorldTrackForm trackForm;
        SaveForm saveForm;

        public Form1()
        {
            InitializeComponent();

            if(Constants.Settings.LoadedTab == Constants.WORLD_SAVE_TAB)
            {
                setSaveForm(SaveDataService.LoadedGame.World);
            }
            else if (Constants.Settings.LoadedTab == Constants.WILDS_SAVE_TAB)
            {
                setSaveForm(SaveDataService.LoadedGame.Wilds);
            }
            else
            {
                setTrackForm();
            }
        }

        private void btnLoadTrackForm_Click(object sender, EventArgs e)
        {
            setTrackForm();
        }

        private void WorldTrackForm_FormClosed(object sender, EventArgs e)
        {
            trackForm = null;
        }

        private void btnLoadWorldSaveForm_Click(object sender, EventArgs e)
        {
            setSaveForm(SaveDataService.LoadedGame.World);
        }

        private void btnLoadWildsSaveForm_Click(object sender, EventArgs e)
        {
            setSaveForm(SaveDataService.LoadedGame.Wilds);
        }

        void setSaveForm(SaveDataService.LoadedGame loadedGame)
        {
            if (saveForm == null)
            {
                saveForm = new SaveForm();
                saveForm.FormClosed += SaveForm_FormClosed;
                saveForm.MdiParent = this;
                saveForm.Show();
            }
            else
            {
                saveForm.Activate();
            }

            string gameString = "";

            if (loadedGame == SaveDataService.LoadedGame.World)
            {
                gameString = "World";
                Constants.Settings.LoadedTab = Constants.WORLD_SAVE_TAB;
            }
            else
            {
                gameString = "Wilds";
                Constants.Settings.LoadedTab = Constants.WILDS_SAVE_TAB;
            }

            SaveDataService.SwapState(loadedGame);

            saveForm.Text =  $"{gameString} Save Management";
            saveForm.ChangeTitle(gameString);
        }

        void setTrackForm()
        {
            if (trackForm == null)
            {
                trackForm = new WorldTrackForm();
                trackForm.FormClosed += WorldTrackForm_FormClosed;
                trackForm.MdiParent = this;
                trackForm.Show();
            }
            else
            {
                trackForm.Activate();
            }
            Constants.Settings.LoadedTab = Constants.WORLD_TRACKS_TAB;
        }

        private void SaveForm_FormClosed(object sender, EventArgs e)
        {
            trackForm = null;
        }

        private void btnTransferFromOldManager_Click(object sender, EventArgs e)
        {
            UiController.TransferDataFromOldSaveManager();
            setSaveForm(SaveDataService.LoadedGame.World);
            saveForm.RefreshUi();
        }
    }
}
