using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    public abstract class GameState
    {
        public List<string> SaveList { get; set; }

        public virtual string LoadedSave { get; set; }

        protected string GameId { get; set; }

        protected string GameSaveFolder
        {
            get
            {
                return $@"{Constants.STEAM_INSTALL_PATH}\userdata\{Constants.STEAM_ID}\{GameId}\remote";
            }
        }

        /**
         * @param string saveFileName - Name of the current save file
         * Loads the selected save, will validate if it exists
         */
        public virtual void LoadSave(string saveFileName)
        {
            
        }

        /**
         * @param string backupSaveFileName - Name of the current save file
         * Creates backup of the currently loaded save data
         */
        public virtual void BackupSave(string backupSaveFileName)
        {
            Constants.Settings.AddToSaveList(backupSaveFileName, SaveList);
        }

        /**
         * @param string oldName - Name of the current save file
         * @param string newName - New name for the save file
         * Renames the save
         */
        public virtual void RenameSave(string oldName, string newName)
        {
            Constants.Settings.RenameSave(newName, SaveList.IndexOf(oldName), SaveList);
        }

        protected string FormatSaveName(string saveFileName)
        {
            if (saveFileName == "Main")
            {
                return "Main";
            }
            else
            {
                return $@"Saves\{saveFileName}";
            }
        }


    }
}
