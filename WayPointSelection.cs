using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookApplicationUI
{
    public partial class WayPointSelection : Form
    {
        private const string k_LabelBaseText = "Pick way point number {0}";

        public int LastSelected { get; private set; }

        public WayPointSelection(List<string> i_WayPoints)
        {
            InitializeComponent();

            foreach (string wayPoint in i_WayPoints)
            {
                WayPointsComboBox.Items.AddRange(new object[] { wayPoint });
            }
        }

        public void UpdateLabelText(int i_NumberOfWayPoint)
        {
            WayPointLabel.Text = string.Format(k_LabelBaseText, i_NumberOfWayPoint);
        }

        public void UpdateButtonText(string i_Msg)
        {
            NextWayPointButton.Text = i_Msg;
        }

        private void NextWayPointButton_Click(object sender, EventArgs e)
        {
            LastSelected = WayPointsComboBox.SelectedIndex;
            NextWayPointButton.Enabled = false;
            Close();
        }

        private void WayPointsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NextWayPointButton.Enabled = true;
        }
    }
}