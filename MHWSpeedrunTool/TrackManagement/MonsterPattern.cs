using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.TrackManagement
{
    public class MonsterPattern
    {
        public string MonsterId;
        public Dictionary<string, int> StageToPatternMap;

        public MonsterPattern(string monsterId) {
            MonsterId = monsterId;
            StageToPatternMap = new Dictionary<string, int>();

            foreach(string stageId in MONSTER_ID_TO_STAGELIST[monsterId])
            {
                StageToPatternMap.Add(stageId, 0);
            }
        }

        static Dictionary<string, List<string>> MONSTER_ID_TO_STAGELIST = new Dictionary<string, List<string>>{
            {
                Constants.PINK_RATHIAN_ID,
                new List<string>{
                    Constants.FOREST_ID,
                    Constants.WASTE_ID,
                    Constants.CORAL_ID,
                    Constants.VALE_ID
                }
            },
            {
                Constants.KIRIN_ID,
                new List<string>
                {
                    Constants.CORAL_ID
                }
            },
            {
                Constants.KUSHALA_DAORA_ID,
                new List<string>
                {
                    Constants.FOREST_ID
                }
            },
            {
                Constants.TEOSTRA_ID,
                new List<string>
                {
                    Constants.WASTE_ID
                }
            },
            {
                Constants.VAAL_HAZAK_ID,
                new List<string>
                {
                    Constants.VALE_ID
                }
            },
            {
                Constants.NERGIGANTE_ID,
                new List<string>
                {
                    Constants.RECESS_ID
                }
            },
            {
                Constants.VELKHANA_ID,
                new List<string>{
                    Constants.FOREST_ID,
                    Constants.WASTE_ID,
                    Constants.CORAL_ID,
                    Constants.VALE_ID,
                    Constants.RECESS_ID,
                    Constants.HOARFROST_ID
                }
            },
            {
                Constants.BLACKVEIL_ID,
                new List<string>{
                    Constants.FOREST_ID,
                    Constants.WASTE_ID,
                    Constants.CORAL_ID,
                    Constants.VALE_ID,
                    Constants.RECESS_ID,
                    Constants.HOARFROST_ID
                }
            },
            {
                Constants.NAMIELLE_ID,
                new List<string>{
                    Constants.FOREST_ID,
                    Constants.WASTE_ID,
                    Constants.CORAL_ID,
                    Constants.VALE_ID,
                    Constants.RECESS_ID,
                    Constants.HOARFROST_ID
                }
            },
        };
    }
}
