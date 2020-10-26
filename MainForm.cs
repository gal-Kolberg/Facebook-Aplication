using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using FacebookApplicationLogic;
using FacebookWrapper;

namespace FacebookApplicationUI
{
    public partial class MainForm : Form, IDanceable
    {
        private AppLogic AppLogic { get; set; }

        private PictureToAsciiForm PictureToAsciiForm { get; set; }

        private CheckInToRouteForm CheckInToRouteForm { get; set; }

        public event Action InitilizeMainForm;

        private string AppName { get; set; }

        private Dancer Dancer { get; set; }

        private bool PackageClicked { get; set; }

        public MainForm()
        {
            InitializeComponent();
            AppLogic = new AppLogic();
            AppName = "aceBook D&G app";
            PackageClicked = false;
            FacebookService.s_CollectionLimit = 100;
            Dancer = new Dancer();
            PictureToAsciiForm = new PictureToAsciiForm();
            CheckInToRouteForm = new CheckInToRouteForm();

            InitilizeMainForm += AppLogic.Login;
            InitilizeMainForm += fetchProfilePicture;
            InitilizeMainForm += fetchLastPost;
            InitilizeMainForm += addUserNotifiers;
        }

        private void makeEnabledDisableClient(bool i_EnableOfDisableButton)
        {
            LastPostTextBox.Enabled = i_EnableOfDisableButton;
            FecthFriendsLinkLabel.Enabled = i_EnableOfDisableButton;
            FetchCoverPhotoLinkLabel.Enabled = i_EnableOfDisableButton;
            GroupsLinkLable.Enabled = i_EnableOfDisableButton;
            LikedPages.Enabled = i_EnableOfDisableButton;
            GroupsLinkLable.Enabled = i_EnableOfDisableButton;
            EventsLinkLabel.Enabled = i_EnableOfDisableButton;
            PictureToAsciiButton.Enabled = i_EnableOfDisableButton;
            CheckInToRouteButton.Enabled = i_EnableOfDisableButton;
            LogoutButton.Enabled = i_EnableOfDisableButton;
            SortByComboBox.Enabled = i_EnableOfDisableButton;
            DanceButton.Enabled = i_EnableOfDisableButton;
            SortFriednsByLabel.Enabled = i_EnableOfDisableButton;
        }

        private void addRemoveButtonsColor()
        {
            CheckInToRouteButton.BackColor = CheckInToRouteButton.BackColor == Color.LightGreen ? Color.LightGray : Color.LightGreen;
            PictureToAsciiButton.BackColor = PictureToAsciiButton.BackColor == Color.Violet ? Color.LightGray : Color.Violet;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Thread mainFormInitializer = new Thread(InitilizeMainForm.Invoke);
                PackageSelectButton.Enabled = true;
                mainFormInitializer.SetApartmentState(ApartmentState.STA);
                mainFormInitializer.Start();
                LoginButton.Click -= LoginButton_Click;
                PackageSelectButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addUserNotifiers()
        {
            AppLogic.LoggedInUser.NotifyFeatures += CheckInToRouteForm.FeatureAccess;
            AppLogic.LoggedInUser.NotifyFeatures += PictureToAsciiForm.FeatureAccess;
        }

        private void fetchProfilePicture()
        { 
            ProfilePictureBox.Invoke(new Action(() => ProfilePictureBox.Image = AppLogic.FetchProfilePicture()));
        }

        private void fetchLastPost()
        {
            LastPostTextBox.Invoke(new Action(() => LastPostTextBox.Text = AppLogic.FetchLastPost()));
        }

        private void fetchCoverPhoto()
        {
            LikedPagesTextBox.Invoke(new Action(() => CoverPhotoPictureBox.Image = AppLogic.FetchCoverPhoto()));
        }

        private void FetchCoverPhotoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchCoverPhoto).Start();
        }

        private void fetchLikedPages()
        {
            LikedPagesTextBox.Invoke(new Action(() => LikedPagesTextBox.Text = AppLogic.FetchLikedPages()));
        }

        private void LikedPages_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchLikedPages).Start();
        }

        private void fetchGroups()
        {
            GroupsTextBox.Invoke(new Action(() => GroupsTextBox.Text = AppLogic.FetchGrourps()));
        }

        private void GroupsLinkLable_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void fetchFriends()
        {
            FriendsTextBox.Invoke(new Action(() => FriendsTextBox.Text = AppLogic.FetchFriends()));
        }

        private void FecthFriendsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchFriends).Start();
        }

        private void fetchEvents()
        {
            EventTextBox.Invoke(new Action(() => EventTextBox.Text = AppLogic.FetchEvents()));
        }

        private void EventsLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void PictureToAsciiButton_Click(object sender, EventArgs e)
        {
            PictureToAsciiForm.InitForm(ProfilePictureBox.Image.Height, ProfilePictureBox.Image.Width, ProfilePictureBox.Image);

            PictureToAsciiForm.ShowDialog();
        }

        private void CheckInToRouteButton_Click(object sender, EventArgs e)
        {
            CheckInToRouteForm.InitForm(AppLogic.LoggedInUser.User.Checkins);

            CheckInToRouteForm.ShowDialog();
        }

        private void LogoutButton_Click_1(object sender, EventArgs e)
        {
            const bool v_DisableAllButton = false;

            AppLogic.Logout();
            cleanClient();
            makeEnabledDisableClient(v_DisableAllButton);
            LoginButton.Click += LoginButton_Click;
            addRemoveButtonsColor();
            PackageSelectButton.Enabled = false;
        }

        private void cleanClient()
        {
            PictureBox currentPictureBox;
            ProfilePictureBox.Image = null;
            CoverPhotoPictureBox.Image = null;

            foreach (Control control in Controls) 
            {
                currentPictureBox = control as PictureBox;

                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (currentPictureBox != null)
                {
                    currentPictureBox.Image = null;
                }
            }
        }

        private void nameAppAccordingToUserType()
        {
            switch (AppLogic.LoggedInUser.eUserType)
            {
                case eUserType.eTrialUser:
                    Text = string.Format("{0}{1}", AppName, " - Trial User");
                    break;
                case eUserType.eBusinessUser:
                    Text = string.Format("{0}{1}", AppName, " - Business User");
                    break;
                case eUserType.ePremiumUser:
                    Text = string.Format("{0}{1}", AppName, " - Premium User");
                    break;
                default:
                    break;
            }
        }

        private void PackageSelectButton_Click(object sender, EventArgs e)
        {
            const bool v_EnalbleAllButtons = true;
            PackageForm packageForm = new PackageForm();

            packageForm.ShowDialog();
            AppLogic.LoggedInUser.ChangeUserType(packageForm.UserChoosenType);
            makeEnabledDisableClient(v_EnalbleAllButtons);
            nameAppAccordingToUserType();

            if (PackageClicked == false)
            {
                addRemoveButtonsColor();
                PackageClicked = true;
            }
        }

        private void DanceButton_Click(object sender, EventArgs e)
        {
            Dancer.MakeDance(this);
        }

        private void SortByComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eSortBy sortBy = (eSortBy)SortByComboBox.SelectedIndex;
            FriendsTextBox.Text = AppLogic.SortBy(sortBy);
        }
    }
}