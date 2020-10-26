using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class SortDate : IComparer<User>
    {
        public int Compare(User i_User1, User i_User2)
        {
            DateTime userUser1BDay = DateTime.Parse(i_User1.Birthday);
            DateTime userUser2BDay = DateTime.Parse(i_User2.Birthday);

            return userUser1BDay.Day > userUser2BDay.Day ? -1 : 1;
        }
    }
}
