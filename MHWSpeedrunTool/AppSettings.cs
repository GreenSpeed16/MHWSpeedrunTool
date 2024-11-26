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

        // Extremely simplistic for now, but will be useful when save management is added

        void SaveSettings()
        {
            File.WriteAllText(@$"{Constants.APP_DATA_PATH}\appSettings.json", JsonSerializer.Serialize(this));
        }
    }
}
