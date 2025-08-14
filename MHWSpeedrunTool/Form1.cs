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
        }

        private void btnLoadTrackForm_Click(object sender, EventArgs e)
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

            string gameString = (loadedGame == SaveDataService.LoadedGame.World ? "World" : "Wilds");
            saveForm.Text = $"{gameString} Save Management";
            saveForm.ChangeTitle(gameString);
            SaveDataService.SwapState(loadedGame);
        }

        private void SaveForm_FormClosed(object sender, EventArgs e)
        {
            trackForm = null;
        }

        private void btnTransferFromOldManager_Click(object sender, EventArgs e)
        {
            UiController.TransferDataFromOldSaveManager();
        }
    }
}
