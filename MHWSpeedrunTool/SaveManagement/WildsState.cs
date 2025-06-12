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
        }
    }
}
