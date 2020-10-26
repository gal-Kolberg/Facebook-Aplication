using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class Sorter
    {
        public IComparer<User> Comparer { get; set; }

        public Sorter(IComparer<User> i_Comparer)
        {
            Comparer = i_Comparer;
        }

        public string Sort(FacebookObjectCollection<User> i_UserList)
        {
            string friendsNames = string.Empty;
            User[] userFriendArray = i_UserList.ToArray();
            Array.Sort(userFriendArray, Comparer);

            foreach (User friend in userFriendArray)
            {
                friendsNames += string.Format("{0}{1}", friend.Name, Environment.NewLine);
            }

            return friendsNames;
        }
    }
}
