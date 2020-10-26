using FacebookWrapper.ObjectModel;
using System;

namespace FacebookApplicationLogic
{
    public class ApplicationUser : IUserAccess
    {
        public eUserType eUserType { get; set; }

        public User User { get; set; }

        public event Action<eUserType> NotifyFeatures;

        public ApplicationUser(User i_User)
        {
            User = i_User;
            eUserType = eUserType.eTrialUser;
        }

        public void ChangeUserType(eUserType i_UserType)
        {
            eUserType = i_UserType;
            NotifyFeatures.Invoke(eUserType);
        }
    }
}