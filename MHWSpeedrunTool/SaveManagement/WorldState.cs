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
            GameId = Constants.WORLD_ID;
        }

        public override string LoadSave(string saveFileName)
        {
            string savePath = base.LoadSave(saveFileName);
            File.Copy($@"{Constants.APP_DATA_PATH}\World\{savePath}", $@"{GameSaveFolder}\SAVEDATA1000", true);

            return saveFileName.Split(@"\").Last();
        }
    }
}
