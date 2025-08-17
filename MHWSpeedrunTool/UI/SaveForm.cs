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
            if (lstSaveNames.SelectedItem == null) return;

            UiController.LoadSave(lstSaveNames.SelectedItem.ToString());
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdRenameSelectedSave_Click(object sender, EventArgs e)
        {
            if (lstSaveNames.SelectedItem == null) return;

            UiController.RenameSave(lstSaveNames.SelectedItem.ToString());
            UiController.SetSaveList(lstSaveNames, lblSaveName);
        }

        private void cmdDeleteSelectedSave_Click(object sender, EventArgs e)
        {
            if (lstSaveNames.SelectedItem == null) return;

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

        private void lstSaveNames_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstSaveNames.SelectedItem == null) return;

            lstSaveNames.DoDragDrop(lstSaveNames.SelectedItem, DragDropEffects.Move);
        }

        private void lstSaveNames_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstSaveNames_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstSaveNames.PointToClient(new Point(e.X, e.Y));
            int index = lstSaveNames.IndexFromPoint(point);

            if (index < 0)
            {
                index = lstSaveNames.Items.Count - 1;
            }

            object data = e.Data.GetData(typeof(string));

            lstSaveNames.Items.Remove(data);
            lstSaveNames.Items.Insert(index, data);
            lstSaveNames.SelectedItem = data;

            ListBox updatedList = lstSaveNames;
            SaveDataService.CurrentSaveList.Clear();

            foreach (var item in updatedList.Items)
            {
                SaveDataService.CurrentSaveList.Add(item.ToString());
            }
        }

        private void lstSaveNames_DragOver(object sender, DragEventArgs e)
        {
            Point point = lstSaveNames.PointToClient(new Point(e.X, e.Y));
            int index = lstSaveNames.IndexFromPoint(point);

            if (point.Y < 20)
            {
                int firstVisible = lstSaveNames.TopIndex;
                if (firstVisible > 0)
                {
                    lstSaveNames.TopIndex = firstVisible - 1;
                }
            }

            else if (point.Y > lstSaveNames.Height - 20)
            {
                int visibleItems = lstSaveNames.ClientSize.Height / lstSaveNames.ItemHeight;
                int lastVisible = lstSaveNames.TopIndex + visibleItems;

                if (lastVisible < lstSaveNames.Items.Count)
                {
                    lstSaveNames.TopIndex = lstSaveNames.TopIndex + 1;
                }
            }

        }
    }
}
