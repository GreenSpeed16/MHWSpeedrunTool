using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSpeedrunTool.SaveManagement
{
    public class SaveDataService
    {
        /**
         * @param string oldFilePath - Path of the old save manager
         * Take in the path to the old save manager, and attempt to copy over all backups
         */
        public static void TransferSaveListFromOldManager(string oldFilePath)
        {
            if(Directory.Exists(oldFilePath + @"\Saves"))
            {
                FileService.CopyDirectory(oldFilePath + @"\Saves", $@"{Constants.APP_DATA_PATH}\World\Saves", true, true);

                try
                {
                    File.Copy(oldFilePath + @"\MainSave\MainData", $@"{Constants.APP_DATA_PATH}\World\MainSave", true);
                }
                catch(FileNotFoundException)
                {
                    throw new FailedToLoadMainSaveException();
                }
            }
            else
            {
                throw new FailedToLoadExistingSavesException();
            }
        }

        public class FailedToLoadMainSaveException : Exception
        {
            public FailedToLoadMainSaveException() {}
        }

        public class FailedToLoadExistingSavesException : Exception
        {
            public FailedToLoadExistingSavesException() {}
        }
    }
}
