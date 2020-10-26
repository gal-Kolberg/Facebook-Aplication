using System;
using System.Windows.Forms;
using System.Drawing;
using FacebookApplicationLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationUI
{
    public partial class CheckInToRouteForm : Form, IDanceable
    {
        public CheckInRoute CheckInRoute { get; set; }

        public CheckInAdapter CheckInDataBind { get; set; }

        private WayPointSelectionForm WayPointSelectionForm { get; set; }

        private Dancer Dancer { get; set; }

        private int MaxNumberOfStops { get; set; }

        public CheckInToRouteForm()
        {
            WayPointSelectionForm = new WayPointSelectionForm();
            InitializeComponent();
            MaxNumberOfStops = 9;
            Dancer = new Dancer();
        }

        public void InitForm(FacebookObjectCollection<Checkin> i_Checkins)
        {
            CheckInDataBind = new CheckInAdapter(i_Checkins);
            CheckInRoute = new CheckInRoute(i_Checkins);
            WayPointSelectionForm.InitForm(CheckInRoute.FetchAllLocations());

            OriginComboBox.DataSource = CheckInDataBind;
            DestinationComboBox.DataSource = CheckInDataBind;

            OriginComboBox.DisplayMember = "UserCheckInsFormated";
            DestinationComboBox.DisplayMember = "UserCheckInsFormated";

            bindLocationComboBox();
        }

        public void FeatureAccess(eUserType i_UserType)
        {
            switch (i_UserType)
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
            const int k_NumberOfBusinessUserWayPoints = 9;
            MaxNumberOfStops = k_NumberOfBusinessUserWayPoints;
            NumberOfStopsComboBox.Enabled = true;
            SelectWayPointButton.Enabled = true;
            bindLocationComboBox();
        }

        private void limitToBusinessUser()
        {
            NumberOfStopsComboBox.Enabled = true;
            SelectWayPointButton.Enabled = true;
            const int k_NumberOfBusinessUserWayPoints = 4;
            MaxNumberOfStops = k_NumberOfBusinessUserWayPoints;
            bindLocationComboBox();
        }

        private void limitToTrailUser()
        {
            NumberOfStopsComboBox.Enabled = false;
            SelectWayPointButton.Enabled = false;
            SelectWayPointButton.BackColor = Color.LightGray;
        }

        private void bindLocationComboBox()
        {
            NumberOfStopsComboBox.Items.Clear();
            NumberOfStopsComboBox.ResetText();

            for (int i = 0; i <= MaxNumberOfStops; i++)
            {
                NumberOfStopsComboBox.Items.Add(i);
            }
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
                    "set to the default value of:{0}Origin - first item, destenation - last item",
                    Environment.NewLine);

                if (waypointSelected == 0 || waypointSelected == -1)
                {
                    msg += ", with no stops.";
                }

                MessageBox.Show(msg);
                originIndex = 0;
                destinationIndex = DestinationComboBox.Items.Count - 1;
            }

            try
            {
                origin = string.Format(
                    "{0},{1}",
                    CheckInRoute.UserCheckIns[originIndex].Place.Location.Latitude,
                    CheckInRoute.UserCheckIns[originIndex].Place.Location.Longitude);

                destination = string.Format(
                    "{0},{1}",
                    CheckInRoute.UserCheckIns[destinationIndex].Place.Location.Latitude,
                    CheckInRoute.UserCheckIns[destinationIndex].Place.Location.Longitude);

                url = CheckInRoute.GetCheckInRoutes(origin, destination);

                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectWayPointButton_Click(object sender, EventArgs e)
        {
            int numberOfWayPoints = NumberOfStopsComboBox.SelectedIndex;
            int selectedWayPointIndex;
            const int k_NumberOfMininalWayPoints = 0;

            CheckInRoute.EmptySelectedWayPointList();
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
                    CheckInRoute.AddToUserSelectedWayPoints(selectedWayPointIndex);
                }
            }
            else
            {
                MessageBox.Show("You need to select at least 1 stop.");
            }
        }

        private void DanceButton_Click(object sender, EventArgs e)
        {
            Dancer.MakeDance(this);
        }
    }
}