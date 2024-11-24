﻿namespace MHWSpeedrunTool.TrackManagement
{
    internal class TrackService
    {
        /**
         * @param Dictionary<string, int> trackPatterns
         * Take in a map of monster id to pattern number, and build nativePC based on provided values
         */
        public static void BuildNativePc(Dictionary<string, int> trackPatterns)
        {
            foreach(string monsterId in trackPatterns.Keys) {
                foreach(string stageId in Constants.MONSTER_ID_TO_STAGELIST[monsterId])
                {
                    LoadPattern(stageId, monsterId, trackPatterns[monsterId]);
                }
            }
        }

        static void LoadPattern(string stageId, string monsterId, int patternNumber)
        {
            if (!Directory.Exists(@$"{Constants.MHW_INSTALL_PATH}\nativePC\stage\{stageId}"))
            {
                Directory.CreateDirectory(@$"{Constants.MHW_INSTALL_PATH}\nativePC\stage\{stageId}\common\set");
            }

            for (int i = 1; i <= 3; i++)
            {
                if (i != patternNumber)
                {
                    string fileOutput = @$"{Constants.MHW_INSTALL_PATH}\nativePC\stage\{stageId}\common\set\{stageId}_traceSP_{monsterId}_0{i}.sobj";
                    
                    if (File.Exists(fileOutput))
                    {
                        File.Delete(fileOutput);
                    }

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
