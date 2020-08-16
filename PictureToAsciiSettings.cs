using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookApplicationUI
{
    public partial class PictureToAsciiSettings : Form
    {
        public int ImageHight { get; set; }

        public int ImageWidth { get; set; }

        public int IndexCharsChoosen { get; set; }

        public bool BlackToWhite { get; set; }

        private bool DefaultChoosen { get; set; }

        private int GivenImageHight { get; }

        private int GivenImageWidth { get; }

        private Point[] m_RangeOptions = { new Point(50, 30), new Point(100, 30), new Point(100, 50) };
        private string[] m_NumberOfCharsOption = { "10 (recommended)", "20", "50", "70" };
        private string[] m_StringSizeOption = { "Small", "Medium", "Large (recommended)" };
        private const bool k_NegativeDefault = true;

        public PictureToAsciiSettings(int i_ImageHight, int i_ImageWidth)
        {
            InitializeComponent();
            GivenImageHight = i_ImageHight;
            GivenImageWidth = i_ImageWidth;
            BlackToWhite = true;
            int i = 0;

            foreach (Point option in m_RangeOptions)
            {
                if (option.X <= i_ImageHight && option.Y <= i_ImageWidth) 
                {
                    SizeComboBox.Items.AddRange(new object[] { m_StringSizeOption[i++] });
                }
            }

            foreach (string option in m_NumberOfCharsOption)
            {
                NumOfCharsComboBox.Items.AddRange(new object[] { option });
            }
        }

        private void SizeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ImageHight = m_RangeOptions[SizeComboBox.SelectedIndex].X;
            ImageWidth = m_RangeOptions[SizeComboBox.SelectedIndex].Y;
        }

        private void NumOfCharsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IndexCharsChoosen = NumOfCharsComboBox.SelectedIndex;
        }

        private void BlackToWhiteRadioButton_Click(object sender, EventArgs e)
        {
            setNegative(k_NegativeDefault);
        }

        private void WhiteToBlackRadioButton_Click(object sender, EventArgs e)
        {
            setNegative(!k_NegativeDefault);
        }

        private void setNegative(bool i_SetBlackToWhite)
        {
            BlackToWhiteRadioButton.Checked = i_SetBlackToWhite;
            WhiteToBlackRadioButton.Checked = !i_SetBlackToWhite;
        }

        private void setDefault()
        {
            const int k_DefaulValueIndex = 2;
            Point defaultValueIfInSize = new Point(80, 40);
            Point defaultValueIfSmallSize = new Point(20, 10);

            BlackToWhite = k_NegativeDefault;
            IndexCharsChoosen = 0;

            if (m_RangeOptions[k_DefaulValueIndex].X <= GivenImageHight && m_RangeOptions[k_DefaulValueIndex].Y <= GivenImageWidth)
            {
                ImageHight = defaultValueIfInSize.X;
                ImageWidth = defaultValueIfInSize.Y;
                DefaultChoosen = true;
            }
            else
            {
                ImageHight = defaultValueIfSmallSize.X;
                ImageWidth = defaultValueIfSmallSize.Y;
                DefaultChoosen = false;
            }
        }

        private void DefultButton_Click(object sender, EventArgs e)
        {
            const int k_DefaultChoosen20x10 = 0;
            const int k_DefaultChoosen80x40 = 2;

            setDefault();
            setNegative(k_NegativeDefault);
            SizeComboBox.SelectedIndex = DefaultChoosen ? k_DefaultChoosen80x40 : k_DefaultChoosen20x10;
            NumOfCharsComboBox.SelectedIndex = 0;
        }

        private void PictureToAsciiSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            BlackToWhite = BlackToWhiteRadioButton.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}