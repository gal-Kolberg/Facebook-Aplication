using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookApplicationLogic;

namespace FacebookApplicationUI
{
    public partial class MainForm : Form
    {
        private AppLogic AppLogic { get; set; }

        private PictureToAsciiSettings AsciiSettingsForm { get; set; }

        private WayPointSelection WayPointSelectionForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                const bool v_EnalbleAllButtons = true;

                AppLogic = new AppLogic();

                WayPointSelectionForm = new WayPointSelection(AppLogic.CheckInRoute.FetchAllLocations());
                ProfilePictureBox.Image = AppLogic.FetchProfilePicture();
                makeEnabledDisableClient(v_EnalbleAllButtons);
                LastPostTextBox.Text = AppLogic.FetchLastPost();
                fetchCheckInListBoxes();

                AsciiSettingsForm = new PictureToAsciiSettings(AppLogic.ImageHight, AppLogic.ImageWidth);
                SaveFileDialog.FileName = "ProfileToAscii.txt";

                LoginButton.Click -= loginButton_Clicked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchCheckInListBoxes()
        {
            const int k_MaxNumberOfStops = 9;
            List<string> userLocations = AppLogic.CheckInRoute.FetchAllLocations();

            OriginComboBox.Items.Clear();
            DestinationComboBox.Items.Clear();
            NumberOfStopsComboBox.Items.Clear();

            foreach (string locationString in userLocations)
            {
                OriginComboBox.Items.AddRange(new object[] { locationString });
                DestinationComboBox.Items.AddRange(new object[] { locationString });
            }

            for (int i = 0; i <= k_MaxNumberOfStops; i++)
            {
                NumberOfStopsComboBox.Items.AddRange(new object[] { i });
            }
        }

        private void makeEnabledDisableClient(bool i_EnableOfDisableButton)
        {
            LastPostTextBox.Enabled = i_EnableOfDisableButton;
            FecthFriendsLinkLabel.Enabled = i_EnableOfDisableButton;
            FetchCoverPhotoLinkLabel.Enabled = i_EnableOfDisableButton;
            GroupsLinkLable.Enabled = i_EnableOfDisableButton;
            LikedPages.Enabled = i_EnableOfDisableButton;
            GroupsLinkLable.Enabled = i_EnableOfDisableButton;
            PictureToAsciiButton.Enabled = i_EnableOfDisableButton;
            PictureToAsciiSettingsButton.Enabled = i_EnableOfDisableButton;
            EventsLinkLabel.Enabled = i_EnableOfDisableButton;
            OriginComboBox.Enabled = i_EnableOfDisableButton;
            DestinationComboBox.Enabled = i_EnableOfDisableButton;
            NumberOfStopsComboBox.Enabled = i_EnableOfDisableButton;
            CheckInToRouteButton.Enabled = i_EnableOfDisableButton;
            SelectWayPointButton.Enabled = i_EnableOfDisableButton;
        }

        private void FriendsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FriendsTextBox.Text = AppLogic.FetchFriends();
        }

        private void LikedPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LikedPagesTextBox.Text = AppLogic.FetchLikedPages();
        }

        private void GroupsLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupsTextBox.Text = AppLogic.FetchGrourps();
        }

        private void CoverPhotoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FetchCoverPictureBox.Image = AppLogic.FetchCoverPhoto();
        }

        private void PictureToAsciiSettingsButton_Click(object sender, EventArgs e)
        {
            AsciiSettingsForm.ShowDialog();
        }

        private void PictureToAsciiButton_Click(object sender, EventArgs e)
        {
            AppLogic.InitPicToAscii(ProfilePictureBox.Image);
            AppLogic.SetPictureToAsciiSettings(AsciiSettingsForm.ImageHight, AsciiSettingsForm.ImageWidth, AsciiSettingsForm.IndexCharsChoosen, AsciiSettingsForm.BlackToWhite);
            AsciiStringTextBox.Text = AppLogic.PicToAscii.MakeToAscii();
            SaveToFileButton.Enabled = true;
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

        private void EventsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventTextBox.Text = AppLogic.FetchEvents();
        }

        private void CheckInToRouteButton_Click(object sender, EventArgs e)
        {
            const int k_IndexNotSelected = -1;
            int originIndex = OriginComboBox.SelectedIndex;
            int destinationIndex = DestinationComboBox.SelectedIndex;
            int waypointSelected = NumberOfStopsComboBox.SelectedIndex;
            string origin = string.Empty;
            string destination = string.Empty;
            string url = string.Empty;

            if (originIndex == k_IndexNotSelected || destinationIndex == k_IndexNotSelected)
            {
                string msg = string.Format(
                    "Because no origin or destination values where choosen your route will be " +
                    "set to the default value of:{0} Origin - first item, destenation - last item",
                    Environment.NewLine);

                if (waypointSelected == 0) 
                {
                    msg += ", with no stops.";
                }

                MessageBox.Show(msg);
                originIndex = 0;
                destinationIndex = DestinationComboBox.Items.Count - 1;
            }

            origin = string.Format(
                "{0},{1}",
                AppLogic.CheckInRoute.UserCheckIns[originIndex].Place.Location.Latitude,
                AppLogic.CheckInRoute.UserCheckIns[originIndex].Place.Location.Longitude);

            destination = string.Format(
                "{0},{1}",
                AppLogic.CheckInRoute.UserCheckIns[destinationIndex].Place.Location.Latitude,
                AppLogic.CheckInRoute.UserCheckIns[destinationIndex].Place.Location.Longitude);

            url = AppLogic.CheckInRoute.GetCheckInRoutes(origin, destination);

            System.Diagnostics.Process.Start(url);
        }

        private void SelectWayPointButton_Click(object sender, EventArgs e)
        {
            int numberOfWayPoints = NumberOfStopsComboBox.SelectedIndex;
            int selectedWayPointIndex;
            const int k_NumberOfMininalWayPoints = 0;

            AppLogic.CheckInRoute.EmptySelectedWayPointList();
            WayPointSelectionForm.UpdateButtonText("Next");

            if (numberOfWayPoints > k_NumberOfMininalWayPoints)
            {
                for (int i = 0; i < numberOfWayPoints; i++)
                {
                    if (i == numberOfWayPoints - 1) 
                    {
                        WayPointSelectionForm.UpdateButtonText("Finish");
                    }

                    WayPointSelectionForm.UpdateLabelText(i + 1);
                    WayPointSelectionForm.ShowDialog();
                    selectedWayPointIndex = WayPointSelectionForm.LastSelected;
                    AppLogic.CheckInRoute.AddToUserSelectedWayPoints(selectedWayPointIndex);
                }
            }
            else
            {
                MessageBox.Show("You need to select at least 1 stop.");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            const bool v_DisableAllButton = false;
            TextBox tempBox;
            TabPage tempTabPage;
            TabControl tempTabControl;
            PictureBox tempPictureBox;
            ComboBox tempComboBox;

            AppLogic.Logout();
            makeEnabledDisableClient(v_DisableAllButton);
            SaveToFileButton.Enabled = false;
            LoginButton.Click += loginButton_Clicked;

            foreach (Control mainFormControl in Controls)
            {
                tempTabControl = mainFormControl as TabControl;

                if (tempTabControl != null)
                {
                    foreach (Control tabControl in tempTabControl.Controls)
                    {
                        tempTabPage = tabControl as TabPage;

                        if (tempTabPage != null)
                        {
                            foreach (Control insideTabControl in tempTabPage.Controls)
                            {
                                tempBox = insideTabControl as TextBox;
                                tempPictureBox = insideTabControl as PictureBox;
                                tempComboBox = insideTabControl as ComboBox;

                                if (tempBox != null)
                                {
                                    tempBox.Text = string.Empty;
                                }
                                else if (tempPictureBox != null)
                                {
                                    tempPictureBox.Image = null;
                                }
                                else if (tempComboBox != null) 
                                {
                                    tempComboBox.Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}