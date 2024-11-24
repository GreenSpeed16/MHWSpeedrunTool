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

        public static string FOREST_ID = "st101";
        public static string DESERT_ID = "st102";
        public static string CORAL_ID = "st103";
        public static string VALE_ID = "st104";
        public static string RECESS_ID = "st105";
        public static string HOARFROST_ID = "st108";

        static string _appDataPath = "";
        public static string APP_DATA_PATH
        {
            get
            {
                if (string.IsNullOrEmpty(_appDataPath))
                {
                    _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MHWSpeedrunTool";

                    if(!Directory.Exists(_appDataPath))
                    {
                        Directory.CreateDirectory(_appDataPath);
                    }
                }

                return _appDataPath;
            }
        }

        public static string? MHW_INSTALL_PATH { get; private set; }

        public static Dictionary<string, List<string>> monsterIdToStageListMap = new Dictionary<string, List<string>>{
            { 
                PINK_RATHIAN_ID, 
                new List<string>{
                    FOREST_ID,
                    DESERT_ID,
                    CORAL_ID,
                    VALE_ID
                }
            },
            {
                KIRIN_ID,
                new List<string>
                {
                    CORAL_ID
                }
            },
            {
                KUSHALA_DAORA_ID,
                new List<string>
                {
                    FOREST_ID
                }
            },
            {
                TEOSTRA_ID,
                new List<string>
                {
                    DESERT_ID
                }
            },
            {
                VAAL_HAZAK_ID,
                new List<string>
                {
                    VALE_ID
                }
            },
            {
                NERGIGANTE_ID,
                new List<string>
                {
                    RECESS_ID
                }
            },
            {
                VELKHANA_ID,
                new List<string>{
                    FOREST_ID,
                    DESERT_ID,
                    CORAL_ID,
                    VALE_ID,
                    RECESS_ID,
                    HOARFROST_ID
                }
            },
            {
                BLACKVEIL_ID,
                new List<string>{
                    FOREST_ID,
                    DESERT_ID,
                    CORAL_ID,
                    VALE_ID,
                    RECESS_ID,
                    HOARFROST_ID
                }
            },
            {
                NAMIELLE_ID,
                new List<string>{
                    FOREST_ID,
                    DESERT_ID,
                    CORAL_ID,
                    VALE_ID,
                    RECESS_ID,
                    HOARFROST_ID
                }
            },
        };

        /**
         * Loads the constant strings from JSON file, and saves the JSON to _rawJson for quick access later
         */
        public static void LoadConstantsFromJson()
        {
            // TODO: Properly initialize install path
            MHW_INSTALL_PATH = @"D:\SteamLibrary\steamapps\common\Monster Hunter World";
        }
    }
}
