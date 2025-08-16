using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    public class SaveDataService
    {
        static GameState _currentState;

        public static List<string> CurrentSaveList
        {
            get
            {
                return _currentState.SaveList;
            }
        }

        public static string LoadedSave
        {
            get
            {
                return _currentState.LoadedSave;
            }
        }

        public enum LoadedGame
        {
            World,
            Wilds
        }

        /**
         * @param Game loadedGame - The game that is currently loaded
         * Changes the game state to the currently loaded game
         */
        public static void SwapState(LoadedGame loadedGame)
        {
            _currentState = loadedGame == LoadedGame.World ? new WorldState() : new WildsState();
        }

        /**
         * @param string saveFileName - Name of the current save file
         * Loads the selected save, will validate if it exists
         */
        public static void LoadSave(string saveFileName)
        {
            _currentState.LoadSave(saveFileName);
        }
        
        /**
         * @param string backupSaveFileName - Name of the current save file
         * Creates backup of the currently loaded save data
         */
        public static void BackupSave(string backupSaveFileName)
        {
            _currentState.BackupSave(backupSaveFileName);
        }

        public static void RenameSave(string oldName, string newName)
        {
            _currentState.RenameSave(oldName, newName);
        }

        /**
         * @param string oldFilePath - Path of the old save manager
         * Take in the path to the old save manager, and attempt to copy over all backups
         */
        public static void TransferSaveListFromOldManager(string oldFilePath)
        {
            if(Directory.Exists(oldFilePath + @"\Saves"))
            {
                FileService.CopyDirectory(oldFilePath + @"\Saves", $@"{Constants.APP_DATA_PATH}\World\Saves", true, true);

                foreach(string saveName in Directory.GetFiles($@"{Constants.APP_DATA_PATH}\World\Saves").ToList())
                {
                    Constants.Settings.AddToSaveList(Path.GetFileName(saveName), Constants.Settings.WorldSaveList);
                }

                try
                {
                    File.Copy(oldFilePath + @"\MainSave\MainData", $@"{Constants.APP_DATA_PATH}\World\Main", true);
                }
                catch(FileNotFoundException)
                {
                    throw new FailedToLoadMainSaveException();
                }
            }
            else
            {
                throw new FailedToLoadExistingSavesException();
            }
        }

        public class FailedToLoadMainSaveException : Exception
        {
            public FailedToLoadMainSaveException() {}
        }

        public class FailedToLoadExistingSavesException : Exception
        {
            public FailedToLoadExistingSavesException() {}
        }

        public class FailedToLoadSaveException : Exception
        {
            public FailedToLoadSaveException() { }
        }

        public class FailedToBackupSaveException : Exception
        {
            public FailedToBackupSaveException() { }
        }

        public class FailedToRenameSaveException : Exception
        {
            public FailedToRenameSaveException() { }
        }
    }
}
