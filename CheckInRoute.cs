using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class CheckInRoute
    {
        public FacebookObjectCollection<Checkin> UserCheckIns { get; set; }

        public string LastGivenRoute { get; private set; }

        private List<Checkin> UserSelectedWayPoints { get; set; }

        private const string k_BaseUrl = @"https://www.google.com/maps/dir/?api=1&origin={0}&destination={1}&travelmode=driving";

        private const string k_WayPointsUrl = @"&waypoints=";

        public CheckInRoute(FacebookObjectCollection<Checkin> i_Checkins)
        {
            UserCheckIns = i_Checkins;
            UserSelectedWayPoints = new List<Checkin>();
        }

        public List<string> FetchAllLocations()
        {
            List<string> allLocations = new List<string>();

            foreach (Checkin checkin in UserCheckIns) 
            {
                if (checkin.Place.Location != null) 
                {
                    allLocations.Add(string.Format("{0},{1},{2}", checkin.Place.Location.Country, checkin.Place.Location.City, checkin.Place.Name));
                }
            }

            return allLocations;
        }

        public void EmptySelectedWayPointList()
        {
            UserSelectedWayPoints.Clear();
        }

        public void AddToUserSelectedWayPoints(int i_WayPointIndex)
        {
            UserSelectedWayPoints.Add(UserCheckIns[i_WayPointIndex]);
        }

        public string GetCheckInRoutes(string i_Origin, string i_Destination)
        {
            string checkinRoutesURL = string.Format(k_BaseUrl, i_Origin, i_Destination);

            if (UserSelectedWayPoints.Count != 0) 
            {
                checkinRoutesURL += k_WayPointsUrl;
            }

            foreach (Checkin selectedWayPoint in UserSelectedWayPoints) 
            {
                checkinRoutesURL = string.Format(checkinRoutesURL + "{0},{1}|", selectedWayPoint.Place.Location.Latitude, selectedWayPoint.Place.Location.Longitude);
            }

            checkinRoutesURL = checkinRoutesURL.Substring(0, checkinRoutesURL.Length - 1);
            LastGivenRoute = checkinRoutesURL;

            return checkinRoutesURL;
        }
    }
}