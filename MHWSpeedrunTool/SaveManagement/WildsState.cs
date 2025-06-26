using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    public class WildsState : GameState
    {
        public override string LoadedSave
        {
            get
            {
                return Constants.Settings.WildsLoadedSave;
            }
            set
            {
                Constants.Settings.WildsLoadedSave = value;
            }
        }

        public WildsState() : base()
        {
            SaveList = Constants.Settings.WildsSaveList;
            GameId = Constants.WILDS_ID;
        }

        public override string LoadSave(string saveFileName)
        {
            string savePath = base.LoadSave(saveFileName);
            FileService.CopyDirectory($@"{Constants.APP_DATA_PATH}\Wilds\{savePath}", $@"{GameSaveFolder}\win64", true, true);

            return saveFileName.Split(@"\").Last();
        }
    }
}
