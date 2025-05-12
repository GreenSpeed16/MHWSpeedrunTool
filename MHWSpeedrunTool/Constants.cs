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

namespace MHWSpeedrunTool
{
    internal class Constants
    {
        // ENSURE THIS IS FALSE WHEN PUSHING TO MAIN
        static bool IS_TEST = true;

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

        // 
        public static string APP_DATA_PATH = "";

        public static AppSettings Settings = new AppSettings();

        /**
         * Loads the constant strings from JSON file, and saves the JSON to _rawJson for quick access later
         */
        public static void LoadConstantsFromJson()
        {
            if (string.IsNullOrEmpty(APP_DATA_PATH))
            {
                string dataFolderName = IS_TEST ? @"\MHWSpeedrunToolTest" : @"\MHWSpeedrunTool";
                APP_DATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + dataFolderName;

                if (!Directory.Exists($@"{APP_DATA_PATH}\Track Files"))
                {
                    Directory.CreateDirectory(APP_DATA_PATH);
                    FileService.CopyDirectory(@".\Track Files", $@"{APP_DATA_PATH}\Track Files", true);
                }
            }

            if (File.Exists(@$"{APP_DATA_PATH}\appSettings.json"))
            {
                Settings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText($@"{APP_DATA_PATH}\appSettings.json"));
            }
            if(String.IsNullOrEmpty(Settings.MhwInstallPath))
            {
                UiController.SetMhwPath(null, false);
            }
        }
    }
}
