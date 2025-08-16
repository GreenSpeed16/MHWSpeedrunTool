using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    public class WildsState : GameState
    {
        public override string LoadedSave
        {
            get
            {
                return Constants.Settings.WildsLoadedSave;
            }
            set
            {
                Constants.Settings.WildsLoadedSave = value;
            }
        }

        public WildsState() : base()
        {
            SaveList = Constants.Settings.WildsSaveList;
            GameId = Constants.WILDS_ID;
        }

        public override void LoadSave(string saveFileName)
        {
            string savePath = FormatSaveName(saveFileName);
            FileService.CopyDirectory($@"{Constants.APP_DATA_PATH}\Wilds\{savePath}", $@"{GameSaveFolder}\win64_save", true, true);
        }

        public override void BackupSave(string backupSaveFileName)
        {
            base.BackupSave(backupSaveFileName);

            try
            {
                FileService.CopyDirectory($@"{GameSaveFolder}\win64_save", $@"{Constants.APP_DATA_PATH}\Wilds\{FormatSaveName(backupSaveFileName)}", true, true);
            }
            catch (Exception e)
            {
                // Remove backupSaveFileName from SaveList
                Constants.Settings.RemoveFromSaveList(backupSaveFileName, SaveList);

                if (e is FileNotFoundException || e is DirectoryNotFoundException)
                {
                    throw new SaveDataService.FailedToBackupSaveException();
                }
                throw e;
            }
        }

        public override void RenameSave(string oldName, string newName)
        {
            base.RenameSave(oldName, newName);

            try
            {
                Directory.Move($@"{Constants.APP_DATA_PATH}\Wilds\{FormatSaveName(oldName)}", $@"{Constants.APP_DATA_PATH}\Wilds\{FormatSaveName(newName)}");
            }
            catch (Exception e)
            {
                Constants.Settings.RenameSave(oldName, SaveList.IndexOf(newName), SaveList);

                if (e is FileNotFoundException || e is DirectoryNotFoundException || e is IOException)
                {
                    throw new SaveDataService.FailedToRenameSaveException();
                }
                throw e;
            }
        }
    }
}
