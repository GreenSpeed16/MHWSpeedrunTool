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
            foreach(MonsterPattern pattern in trackPatterns) {
                foreach(string stageId in pattern.StageToPatternMap.Keys)
                {
                    LoadPattern(stageId, pattern.MonsterId, pattern.StageToPatternMap[stageId]);
                }
            }
        }

        static void LoadPattern(string stageId, string monsterId, int patternNumber)
        {
            if (!Directory.Exists(@$"{Constants.Settings.MhwInstallPath}\nativePC\stage\{stageId}"))
            {
                Directory.CreateDirectory(@$"{Constants.Settings.MhwInstallPath}\nativePC\stage\{stageId}\common\set");
            }

            for (int i = 1; i <= 3; i++)
            {
                string fileOutput = @$"{Constants.Settings.MhwInstallPath}\nativePC\stage\{stageId}\common\set\{stageId}_traceSP_{monsterId}_0{i}.sobj";

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
