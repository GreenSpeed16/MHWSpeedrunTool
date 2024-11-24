using MHWSpeedrunTool.TrackManagement;

namespace MHWSpeedrunTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var boxData = new List<ComboBoxMapping>{
                new ComboBoxMapping() { Label = "Random", Value = 0 },
                new ComboBoxMapping() { Label = "1", Value = 1 },
                new ComboBoxMapping() { Label = "2", Value = 2 },
                new ComboBoxMapping() { Label = "3", Value = 3 },
            };

            BindComboBox(cboRathian, boxData);
        }

        private void BindComboBox(ComboBox box, List<ComboBoxMapping> source)
        {
            box.DataSource = source;
            box.DisplayMember = "Label";
            box.ValueMember = "Value";
        }

        private void btnLoadNativePc_Click(object sender, EventArgs e)
        {
            TrackService.BuildNativePc(GetTrackMap());
        }

        private Dictionary<string, int> GetTrackMap()
        {
            Dictionary<string, int> trackMap = new Dictionary<string, int> {
                { Constants.PINK_RATHIAN_ID, int.Parse(cboRathian.SelectedValue.ToString()) }
            };

            return trackMap;
        }

        public class ComboBoxMapping
        {
            public string Label { get; set; }
            public int Value { get; set; }
        }
    }
}
