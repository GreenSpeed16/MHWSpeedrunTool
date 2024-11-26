using MHWSpeedrunTool.TrackManagement;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static MHWSpeedrunTool.Form1;
using MHWSpeedrunTool.SteamManagement;

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
