using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool
{
    public class AppSettings
    {
        string _mhwInstallPath;
        public string MhwInstallPath { 
            get
            {
                return this._mhwInstallPath;
            }
            set
            {
                this._mhwInstallPath = value;
                SaveSettings();
            }
        }

        public List<string> WorldSaveList { get; set; }

        string _worldLoadedSave;
        public string WorldLoadedSave
        {
            get
            {
                return this._worldLoadedSave;
            }
            set
            {
                this._worldLoadedSave = value;
                SaveSettings();
            }
        }

        public List<string> WildsSaveList { get; set; }

        string _wildsLoadedSave;
        public string WildsLoadedSave
        {
            get
            {
                return this._wildsLoadedSave;
            }
            set
            {
                this._wildsLoadedSave = value;
                SaveSettings();
            }
        }

        string _loadedTab;
        public string LoadedTab
        {
            get
            {
                return this._loadedTab;
            }
            set
            {
                this._loadedTab = value;
                SaveSettings();
            }
        }

        public AppSettings() {
            WorldSaveList = new List<string>();
            WildsSaveList = new List<string>();
            LoadedTab = Constants.WORLD_TRACKS_TAB;
        }

        // Extremely simplistic for now, but will be useful when save management is added

        void SaveSettings()
        {
            File.WriteAllText(@$"{Constants.APP_DATA_PATH}\appSettings.json", JsonSerializer.Serialize(this));
        }

        /**
         * @param string saveName - Name of the save
         * @param List<string> saveList - List of saves
         * Adds the save name to the save list
         */
        public void AddToSaveList(string saveName, List<string> saveList)
        {
            if (saveList.Contains(saveName) || saveName == "Main") return;

            saveList.Add(saveName);
            SaveSettings();
        }

        /**
         * @param string saveName - Name of the save
         * @param List<string> saveList - List of saves
         * Removes the save name from the save list
         */
        public void RemoveFromSaveList(string saveName, List<string> saveList)
        {
            if (!saveList.Contains(saveName)) return;

            saveList.Remove(saveName);
            SaveSettings();
        }

        /**
         * @param string saveName - Name of the save
         * @param int index - Index of the save name to be changed
         * @param List<string> saveList - List of saves
         * Renames the save in the save list
         */
        public void RenameSave(string saveName, int index, List<string> saveList)
        {
            saveList[index] = saveName;
            SaveSettings();
        }
    }
}
