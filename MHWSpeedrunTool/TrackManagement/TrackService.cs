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
        public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException(@$"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
    }
}
