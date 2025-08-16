using MHWSpeedrunTool.SaveManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWSpeedrunTool
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        public void ChangeTitle(string title)
        {
            lblSaveName.Text = SaveDataService.LoadedSave;
            lblGameTitle.Text = title;
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdLoadSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.LoadSave(lstSaveNames.SelectedItem.ToString());
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdRenameSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.RenameSave(lstSaveNames.SelectedItem.ToString());
            UiController.SetSaveList(lstSaveNames,lblSaveName);
        }

        private void cmdDeleteSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.DeleteSave(lstSaveNames.SelectedItem.ToString(), lstSaveNames);
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdLoadMainSave_Click(object sender, EventArgs e)
        {
            UiController.LoadSave("Main");
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdBackupCurrentSave_Click(object sender, EventArgs e)
        {
            UiController.BackupSave();
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdOverwriteMain_Click(object sender, EventArgs e)
        {
            UiController.OverwriteMainSave();
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }
    }
}
