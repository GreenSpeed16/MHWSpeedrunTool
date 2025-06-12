using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    internal class WorldState : GameState
    {
        public override string LoadedSave
        {
            get
            {
                return Constants.Settings.WorldLoadedSave;
            }
            set
            {
                Constants.Settings.WorldLoadedSave = value;
            }
        }

        public WorldState() : base()
        {
            SaveList = Constants.Settings.WorldSaveList;
        }
    }
}
