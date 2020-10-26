using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class SortAge : IComparer<User>
    {
        public int Compare(User i_User1, User i_User2)
        {
            DateTime user1BDai_User = DateTime.Parse(i_User1.Birthday);
            DateTime user2BDai_User = DateTime.Parse(i_User1.Birthday);

            return user1BDai_User > user2BDai_User ? 1 : -1;
        }
    }
}