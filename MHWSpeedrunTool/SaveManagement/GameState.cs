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

        /**
         * @param string saveFileName - Name of the current save file
         * Loads the selected save, will validate if it exists
         */
        public static void LoadSave(string saveFileName)
        {

        }

        /**
         * @param string backupSaveFileName - Name of the current save file
         * Creates backup of the currently loaded save data
         */
        public static void BackupSave(string backupSaveFileName)
        {

        }

        /**
         * @param string oldName - Name of the current save file
         * @param string newName - New name for the save file
         * Renames the save
         */
        public static void RenameSave(string oldName, string newName)
        {

        }
    }
}
