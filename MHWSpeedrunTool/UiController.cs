using MHWSpeedrunTool.SaveManagement;
using MHWSpeedrunTool.SteamManagement;
using MHWSpeedrunTool.TrackManagement;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static MHWSpeedrunTool.Form1;

namespace MHWSpeedrunTool
{
    internal class UiController
    {
        public static string GetWorldPathLabelText()
        {
            return $"MHW Install Path: {Constants.Settings.MhwInstallPath}";
        }

        public static void HandleComboboxChange(ComboBox sender, string monsterId, string stageId, List<MonsterPattern> patterns, Button? btnToDisable)
        {
            if(int.TryParse(sender.SelectedValue.ToString(), out int patternId))
            {
                UpdatePattern(monsterId, stageId, patternId, patterns);
                if (btnToDisable != null)
                {
                    EnableLoadNativePc(btnToDisable);
                }
            }
        }

        public static void SetMhwPath(Label? lblToChange, bool manual)
        {
            string mhwPath = SteamService.FindMhwInstall();

            if (manual || string.IsNullOrEmpty(mhwPath))
            {
                string interactionPrompt =
                    manual ?
                    "Enter your MHW install path here: " :
                    "MHW install folder not found. Please type the path here: ";

                Constants.Settings.MhwInstallPath = Interaction.InputBox(interactionPrompt);
            }
            else
            {
                Constants.Settings.MhwInstallPath = mhwPath;
            }
        }

        public static void SetWorldFolder(Label? pathLabel, bool? manual)
        {
            string newPath = Interaction.InputBox("Enter your MHW install path here: ");
            Constants.Settings.MhwInstallPath = newPath;
            if(pathLabel != null)
            {
                pathLabel.Text = GetWorldPathLabelText();
            }
        }

        /**
         * Handles all dialog and calls for transferring save data between the old manager and this tool.
         * Not currently referenced anywhere, will be triggered from the settings menu once it's created.
         */
        public static void TransferDataFromOldSaveManager()
        {
            // If any saves exist for world, warn the user that they may overwrite them
            if(Directory.Exists($@"{Constants.APP_DATA_PATH}\World") && Directory.EnumerateFiles($@"{Constants.APP_DATA_PATH}\World").Any())
            {
                DialogResult overwriteResult = MessageBox.Show(
                    "You have existing save backups for Monster Hunter: World. This operation will overwrite any existing backups that share a name with backups being transferred. Continue?",
                    "Existing Saves",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (overwriteResult == DialogResult.No)
                {
                    return;
                }
            }

            // Get save manager path by checking running processes
            Process[] processes = Process.GetProcessesByName("MHWSaveManager");
            string oldManagerPath = "";

            if (processes.Length > 0) {
                List<string> messageParts = processes[0].MainModule.FileName.Split("\\").ToList();
                messageParts.RemoveAt(messageParts.Count - 1);
                oldManagerPath = string.Join("\\", messageParts);
            }
            else
            {
                Interaction.InputBox("Unable to automatically locate old save manager. Enter the path to the old save manager here. \n (can be found by right clicking it in Task Manager and selecting \"Open file location\").");
            }

            if (oldManagerPath != "")
            {
                string outputMessage = "Successfully transferred saves from the old manager!";
                string outputHeading = "Success!";
                MessageBoxIcon outputIcon = MessageBoxIcon.None;

                // The TransferSaveListFromOldManager method handles more detailed exceptions and throws a custom exception so the UI can handle user notification
                try
                {
                    SaveDataService.TransferSaveListFromOldManager(oldManagerPath);
                }
                catch (SaveDataService.FailedToLoadExistingSavesException)
                {
                    outputMessage = "Unable to locate any existing saves in the old save manager.";
                    outputIcon = MessageBoxIcon.Error;
                }
                catch (SaveDataService.FailedToLoadMainSaveException)
                {
                    outputMessage = "Unable to locate a main save backup in the old save manager. All non-main backups were successfully transferred.";
                    outputIcon = MessageBoxIcon.Error;
                }

                MessageBox.Show(outputMessage, outputHeading, MessageBoxButtons.OK, outputIcon);
            }
        }

        public static void UpdatePattern(string monsterId, string stageId, int patternNumber, List<MonsterPattern> patterns)
        {
            patterns.Find(pattern => pattern.MonsterId == monsterId).StageToPatternMap[stageId] = patternNumber;
        }

        public static void EnableLoadNativePc(Button btn)
        {
            btn.Enabled = true;
            btn.Text = "Load to NativePC";
        }

        public static void DisableLoadNativePc(Button btn)
        {
            btn.Enabled = false;
            btn.Text = "Patterns Loaded";
        }

        public static void BindComboBox(ComboBox box)
        {
            var boxData = new List<ComboBoxMapping>{
                new ComboBoxMapping() { Label = "Random", Value = 0 },
                new ComboBoxMapping() { Label = "1", Value = 1 },
                new ComboBoxMapping() { Label = "2", Value = 2 },
                new ComboBoxMapping() { Label = "3", Value = 3 },
            };

            box.DataSource = boxData;
            box.DisplayMember = "Label";
            box.ValueMember = "Value";
        }

        public class ComboBoxMapping
        {
            public string Label { get; set; }
            public int Value { get; set; }
        }
    }
}
