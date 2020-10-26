using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class CheckInAdapter : IListSource
    {
        public List<string> UserCheckInsFormated { get; set; }

        public bool ContainsListCollection => (UserCheckInsFormated != null);

        public CheckInAdapter(FacebookObjectCollection<Checkin> i_UserCheckIns)
        {
            UserCheckIns = i_UserCheckIns;
            UserCheckInsFormated = new List<string>();
            FetchAllLocations();
        }

        private FacebookObjectCollection<Checkin> UserCheckIns { get; set; }

        public void FetchAllLocations()
        {
            foreach (Checkin checkin in UserCheckIns)
            {
                if (checkin.Place.Location != null)
                {
                    UserCheckInsFormated.Add(string.Format("{0},{1},{2}", checkin.Place.Location.Country, checkin.Place.Location.City, checkin.Place.Name));
                }
            }
        }

        public IList GetList()
        {
            return UserCheckInsFormated;
        }
    }
}
