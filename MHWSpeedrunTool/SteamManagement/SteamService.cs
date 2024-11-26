using Gameloop.Vdf.Linq;
using Gameloop.Vdf;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameloop.Vdf.JsonConverter;

namespace MHWSpeedrunTool.SteamManagement
{
    internal class SteamService
    {
        public static string FindMhwInstall()
        {
            string steamInstallPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", null).ToString();

            VProperty vdfContent = VdfConvert.Deserialize(File.ReadAllText($"{steamInstallPath}\\steamapps\\libraryfolders.vdf")); // load the vdf file | pass your file path here.

            JObject folderJson = new JObject(vdfContent.ToJson());
            SteamLibraryFolders folders = folderJson.ToObject<SteamLibraryFolders>();

            foreach (SteamLibraryFolder folder in folders.libraryfolders.Values)
            {
                if (folder.apps.ContainsKey("582010"))
                {
                    return $"{folder.path}\\steamapps\\common\\Monster Hunter World";
                }
            }

            return "";
        }
    }
}
