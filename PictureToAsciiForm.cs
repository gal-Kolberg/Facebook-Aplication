using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using FacebookApplicationLogic;

namespace FacebookApplicationUI
{
    public partial class PictureToAsciiForm : Form, IDanceable
    {
        public eUserType eUserType { get; set; }

        private PictureToAsciiSettingsForm AsciiSettingsForm { get; set; }

        private Image ProfilePicture { get; set; }

        private PictureToAscii PictureToAsciiLogic { get; set; }

        private Dancer Dancer { get; set; }

        public PictureToAsciiForm()
        {
            AsciiSettingsForm = new PictureToAsciiSettingsForm();
            InitializeComponent();
            Dancer = new Dancer();
        }

        public void InitForm(int i_ImageHight, int i_ImageWidth, Image i_ProfilePictue)
        {
            ProfilePicture = i_ProfilePictue;
            AsciiSettingsForm.InitForm(i_ImageHight, i_ImageWidth);
            SaveFileDialog.FileName = "ProfileToAscii.txt";
        }

        public void FeatureAccess(eUserType UserType)
        {
            switch (UserType)
            {
                case eUserType.eTrialUser:
                    limitToTrailUser();
                    break;
                case eUserType.eBusinessUser:
                    limitToBusinessUser();
                    break;
                case eUserType.ePremiumUser:
                    premiumUser();
                    break;
                default:
                    break;
            }
        }

        private void premiumUser()
        {
            PictureToAsciiSettingsButton.Enabled = true;
            AsciiSettingsForm.PremiumUser();
        }

        private void limitToBusinessUser()
        {
            PictureToAsciiSettingsButton.Enabled = true;
            AsciiSettingsForm.LimitToBusinessUser();
        }

        private void limitToTrailUser()
        {
            PictureToAsciiSettingsButton.Enabled = false;
        }

        private void PictureToAsciiButton_Click(object sender, EventArgs e)
        {
            PictureToAsciiLogic = new PictureToAscii(ProfilePicture);

            PictureToAsciiLogic.SetSettings(AsciiSettingsForm.ImageHight, AsciiSettingsForm.ImageWidth, AsciiSettingsForm.IndexCharsChoosen, AsciiSettingsForm.BlackToWhite);
            new Thread(makeToAscii).Start();
            SaveToFileButton.Enabled = true;
        }

        private void makeToAscii()
        {
            AsciiStringTextBox.Invoke(new Action(() => AsciiStringTextBox.Text = PictureToAsciiLogic.MakeToAscii()));
        }

        private void PictureToAsciiSettingsButton_Click(object sender, EventArgs e)
        {
            AsciiSettingsForm.ShowDialog();
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(SaveFileDialog.FileName))
                {
                    outputFile.Write(AsciiStringTextBox.Text);
                }
            }
        }

        private void DanceButton_Click(object sender, EventArgs e)
        {
            Dancer.MakeDance(this);
        }
    }
}