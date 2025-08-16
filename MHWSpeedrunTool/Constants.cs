using Gameloop.Vdf.Linq;
using Gameloop.Vdf;
using MHWSpeedrunTool.TrackManagement;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Gameloop.Vdf.JsonConverter;
using MHWSpeedrunTool.SteamManagement;
using MHWSpeedrunTool.SaveManagement;

namespace MHWSpeedrunTool
{
    internal class Constants
    {
        // ENSURE THIS IS FALSE WHEN COMMITTING
        static bool IS_TEST = false;

        // Save management constants
        public static string STEAM_INSTALL_PATH
        {
            get
            {
                return Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", null).ToString();
            }
        }
        public static string STEAM_ID
        {
            get
            {
                return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam\ActiveProcess", "ActiveUser", null).ToString();
            }
        }
        public static string WORLD_ID = "582010";
        public static string WILDS_ID = "2246340";

        // Track management constants
        public static string PINK_RATHIAN_ID = "em001_01";
        public static string KIRIN_ID = "em011_00";
        public static string KUSHALA_DAORA_ID = "em024_00";
        public static string TEOSTRA_ID = "em027_00";
        public static string NERGIGANTE_ID = "em103_00";
        public static string VAAL_HAZAK_ID = "em115_00";
        public static string VELKHANA_ID = "em124_00";
        public static string BLACKVEIL_ID = "em115_05";
        public static string NAMIELLE_ID = "em125_00";

        public static Dictionary<string, string> MONSTER_NAME_TO_ID = new Dictionary<string, string>
        {
            { "Rathian", PINK_RATHIAN_ID },
            { "Kirin", KIRIN_ID },
            { "Kushala", KUSHALA_DAORA_ID },
            { "Teostra", TEOSTRA_ID },
            { "Nergigante", NERGIGANTE_ID },
            { "VaalHazak", VAAL_HAZAK_ID },
            { "Velkhana", VELKHANA_ID },
            { "Blackveil", BLACKVEIL_ID },
            { "Namielle", NAMIELLE_ID }
        };

        public static string FOREST_ID = "st101";
        public static string WASTE_ID = "st102";
        public static string CORAL_ID = "st103";
        public static string VALE_ID = "st104";
        public static string RECESS_ID = "st105";
        public static string HOARFROST_ID = "st108";

        public static string APP_DATA_PATH = "";

        // Tab settings
        public static string WORLD_TRACKS_TAB = "WorldTracks";
        public static string WORLD_SAVE_TAB = "WorldSaves";
        public static string WILDS_SAVE_TAB = "WildsSaves";        

        public static AppSettings Settings = new AppSettings();

        /**
         * Checks current saves in the saves folder against the list from appSettings.json and removes or adds based on missing items
         */
        public static void SynchronizeSaveList(List<string> saveFiles, List<string> saveList, string gameName)
        {
            List<string> missingSavesFromSaveList = saveFiles.Except(saveList).ToList();
            List<string> extraSavesFromSaveList = saveList.Except(saveFiles).ToList();

            List<string> savesRemoved = new List<string>();
            List<string> savesAdded = new List<string>();

            foreach (var difference in missingSavesFromSaveList)
            {
                Settings.AddToSaveList(difference, saveList);
                savesAdded.Add(difference);
            }

            foreach (var difference in extraSavesFromSaveList)
            {
                Settings.RemoveFromSaveList(difference, saveList);
                savesRemoved.Add(difference);
            }

            if (savesRemoved.Count > 0)
            {
                string savesRemovedList = string.Join(Environment.NewLine, savesRemoved.Take(5)) + (savesRemoved.Count > 5 ? $"\nAnd {savesRemoved.Count - 5} more" : "");
                MessageBox.Show($"Could not find corresponding backups for these {gameName} saves, so they have been removed:\n{savesRemovedList}","Saves Removed", MessageBoxButtons.OK);
            }
            if (savesAdded.Count > 0)
            {
                string savesAddedList = string.Join(Environment.NewLine, savesAdded.Take(5)) + (savesAdded.Count > 5 ? $"\nAnd {savesAdded.Count - 5} more" : "");
                MessageBox.Show($"The following {gameName} saves have backup files, but were not stored in the save list and have now been added:\n{savesAddedList}","Saves Added", MessageBoxButtons.OK);
            }

        }

        /**
         * This edits the list of file names or direectories to only have the name instead of the full UNC path
         */
        public static void SetFileNames(List<string> fileList)
        {
            int fileCount = fileList.Count;

            for(int i = 0; i < fileCount; i++)
            {
                fileList[i] = Path.GetFileName(fileList[i]);
            }
        }

        /**
         * Loads the constant strings from JSON file, and saves the JSON to _rawJson for quick access later
         */
        public static void LoadConstantsFromJson()
        {
            if (string.IsNullOrEmpty(APP_DATA_PATH))
            {
                APP_DATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + (IS_TEST ? @"\MHWSpeedrunToolTest" : @"\MHWSpeedrunTool");

                if (!Directory.Exists($@"{APP_DATA_PATH}\Track Files"))
                {
                    Directory.CreateDirectory(APP_DATA_PATH);
                    FileService.CopyDirectory(@".\Track Files", $@"{APP_DATA_PATH}\Track Files", true);
                }
                if (!Directory.Exists($@"{APP_DATA_PATH}\World\Saves"))
                {
                    Directory.CreateDirectory($@"{APP_DATA_PATH}\World\Saves");
                }
                if (!Directory.Exists($@"{APP_DATA_PATH}\Wilds\Saves"))
                {
                    Directory.CreateDirectory($@"{APP_DATA_PATH}\Wilds\Saves");
                }
            }

            if (File.Exists(@$"{APP_DATA_PATH}\appSettings.json"))
            {
                Settings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText($@"{APP_DATA_PATH}\appSettings.json"));
            }

            // Back up current save as main if none exists, for both World and Wilds
            if(!File.Exists($@"{APP_DATA_PATH}\World\Main")) setUpMainBackup("World");

            if (!Directory.Exists($@"{APP_DATA_PATH}\Wilds\Main")) setUpMainBackup("Wilds");

            // Get list of saves in the app folder for World and Wilds
            List<string> currentWorldSaves = Directory.GetFiles($@"{APP_DATA_PATH}\World\Saves").ToList();
            List<string> currentWildsSaves = Directory.GetDirectories($@"{APP_DATA_PATH}\Wilds\Saves").ToList();

            SetFileNames(currentWorldSaves);
            SetFileNames(currentWildsSaves);

            SynchronizeSaveList(currentWorldSaves, Settings.WorldSaveList, "World");
            SynchronizeSaveList(currentWildsSaves, Settings.WildsSaveList, "Wilds");
        }

        static void setUpMainBackup(string gameName)
        {
            // Swap SaveDataService to the relevant game
            SaveDataService.SwapState((SaveDataService.LoadedGame)Enum.Parse(typeof(SaveDataService.LoadedGame), gameName));
            if (STEAM_ID == "0" && gameName == "World")
            {
                MessageBox.Show("Unable to complete initial save management setup if Steam is not running. Please open Steam and try again.", "Steam Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(SaveDataService.CurrentGameSaveFolder))
            {
                // Perform this check on every startup, but mark LoadedSave as N/A to avoid notifying the user their game isn't installed every time
                if (Settings.GetType().GetProperty($"{gameName}LoadedSave").GetValue(Settings).ToString() == "N/A")
                    return;

                Settings.GetType().GetProperty($"{gameName}LoadedSave").SetValue(Settings, "N/A");
                MessageBox.Show($"No save data folder for {gameName} found. A main backup will not be created.");
                return;
            }

            SaveDataService.BackupSave("Main");
            Settings.GetType().GetProperty($"{gameName}LoadedSave").SetValue(Settings, "Main");
        }
    }
}
