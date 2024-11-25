using MHWSpeedrunTool.TrackManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool
{
    internal class Constants
    {
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

        public static string? MHW_INSTALL_PATH { get; private set; }

        /**
         * Loads the constant strings from JSON file, and saves the JSON to _rawJson for quick access later
         */
        public static void LoadConstantsFromJson()
        {
            // TODO: Properly initialize install path
            MHW_INSTALL_PATH = @"D:\SteamLibrary\steamapps\common\Monster Hunter World";
            if (string.IsNullOrEmpty(APP_DATA_PATH))
            {
                APP_DATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MHWSpeedrunTool";

                if (!Directory.Exists($@"{APP_DATA_PATH}\Track Files"))
                {
                    Directory.CreateDirectory(APP_DATA_PATH);
                    TrackService.CopyDirectory(@".\Track Files", $@"{APP_DATA_PATH}\Track Files", true);
                }
            }
        }
    }
}
