using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SteamManagement
{
    public class SteamLibraryFolder
    {
        public string path { get; set; }

        public string label { get; set; }

        public string contentid { get; set; }

        public string totalsize { get; set; }

        public string update_clean_bytes_tally { get; set; }

        public string time_last_update_verified { get; set; }

        public Dictionary<string, string> apps { get; set; }
    }

    public class SteamLibraryFolders
    {
        public Dictionary<string, SteamLibraryFolder> libraryfolders { get; set; }
    }
}
