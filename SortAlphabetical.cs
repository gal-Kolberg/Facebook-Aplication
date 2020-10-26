using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class SortAlphabetical : IComparer<User>
    {
        public int Compare(User i_User1, User i_User2)
        {
            return string.Compare(i_User1.Name, i_User2.Name);
        }
    }
}