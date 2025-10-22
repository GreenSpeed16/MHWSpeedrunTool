using MHWSpeedrunTool.SteamManagement;
using Microsoft.VisualBasic;

namespace MHWSpeedrunTool.TrackManagement
{
    internal class TrackService
    {
        /**
         * @param Dictionary<string, int> trackPatterns
         * Take in a map of monster id to pattern number, and build nativePC based on provided values
         */
        public static void BuildNativePc(List<MonsterPattern> trackPatterns)
        {
            string mhwPath = SteamService.FindMhwInstall();

            if (String.IsNullOrEmpty(mhwPath))
            {
                while (true)
                {
                    mhwPath = Interaction.InputBox("Unable to locate Monster Hunter: World install location. Enter a path for the tracks folder to be output to: ", "No MHW Install");

                    // Cancel if no input
                    if (String.IsNullOrEmpty(mhwPath)) return;

                    if (Directory.Exists(mhwPath)) break;

                    // If directory does not exist, warn user before looping again
                    MessageBox.Show("The provided file path does not exist.", "Path Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (MonsterPattern pattern in trackPatterns) {
                foreach(string stageId in pattern.StageToPatternMap.Keys)
                {
                    LoadPattern(stageId, pattern.MonsterId, pattern.StageToPatternMap[stageId], mhwPath);
                }
            }
        }

        static void LoadPattern(string stageId, string monsterId, int patternNumber, string mhwPath)
        {

            if (!Directory.Exists(@$"{mhwPath}\nativePC\stage\{stageId}"))
            {
                Directory.CreateDirectory(@$"{mhwPath}\nativePC\stage\{stageId}\common\set");
            }

            for (int i = 1; i <= 3; i++)
            {
                string fileOutput = @$"{mhwPath}\nativePC\stage\{stageId}\common\set\{stageId}_traceSP_{monsterId}_0{i}.sobj";

                if (File.Exists(fileOutput))
                {
                    File.Delete(fileOutput);
                }

                if (i != patternNumber)
                {
                    // Pattern number of 0 means go back to random tracks, so don't replace the files after deletion
                    if(patternNumber > 0)
                    {
                        File.Copy(
                            @$"{Constants.APP_DATA_PATH}\Track Files\{stageId}_traceSP_{monsterId}_0{patternNumber}.sobj",
                            fileOutput
                        );
                    }

                }
            }
        }
    }
}
