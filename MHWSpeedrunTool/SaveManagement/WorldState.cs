using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    internal class WorldState : GameState
    {
        public override string LoadedSave
        {
            get
            {
                return Constants.Settings.WorldLoadedSave;
            }
            set
            {
                Constants.Settings.WorldLoadedSave = value;
            }
        }

        public WorldState() : base()
        {
            SaveList = Constants.Settings.WorldSaveList;
            GameId = Constants.WORLD_ID;
        }

        public override void LoadSave(string saveFileName)
        {
            try
            {
                File.Copy($@"{Constants.APP_DATA_PATH}\World\{FormatSaveName(saveFileName)}", $@"{GameSaveFolder}\SAVEDATA1000", true);
                Constants.Settings.WorldLoadedSave = saveFileName;
            }
            catch(Exception e)
            {
                if(e is FileNotFoundException || e is DirectoryNotFoundException)
                {
                    throw new SaveDataService.FailedToLoadSaveException();
                }
                throw e;
            }
        }

        public override void BackupSave(string backupSaveFileName)
        {
            base.BackupSave(backupSaveFileName);

            try
            {
                File.Copy($@"{GameSaveFolder}\SAVEDATA1000", $@"{Constants.APP_DATA_PATH}\World\{FormatSaveName(backupSaveFileName)}", true);
                Constants.Settings.WorldLoadedSave = backupSaveFileName;
            }
            catch(Exception e) {
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
                File.Move($@"{Constants.APP_DATA_PATH}\World\{FormatSaveName(oldName)}", $@"{Constants.APP_DATA_PATH}\World\{FormatSaveName(newName)}");

                if(Constants.Settings.WorldLoadedSave == oldName)
                {
                    Constants.Settings.WorldLoadedSave = newName;
                }
            }
            catch(Exception e)
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
