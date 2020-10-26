using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class SortRandom : IComparer<User>
    {

        // $G$ CSS-999 (-3) should be in the form of r_PascalCase
        private readonly Random Random = new Random();


        // $G$ CSS-999 (-3) should be in the form of i_PascalCase
        public int Compare(User x, User y)
        {
            int randomNum = Random.Next(0, 100);

            return randomNum % 2 == 0 ? 1 : -1;
        }
    }
}