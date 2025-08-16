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
            UiController.SetSaveList(lstSaveNames);
        }

        private void cmdLoadSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.LoadSave(lstSaveNames.SelectedItem.ToString(), lblSaveName);
        }

        private void cmdRenameSelectedSave_Click(object sender, EventArgs e)
        {
            UiController.RenameSave(lstSaveNames.SelectedItem.ToString(),lblSaveName);
            UiController.SetSaveList(lstSaveNames);
        }

        private void cmdDeleteSelectedSave_Click(object sender, EventArgs e)
        {

        }

        private void cmdLoadMainSave_Click(object sender, EventArgs e)
        {
            UiController.LoadSave("Main", lblSaveName);
        }

        private void cmdBackupCurrentSave_Click(object sender, EventArgs e)
        {

        }

        private void cmdOverwriteMain_Click(object sender, EventArgs e)
        {

        }
    }
}
