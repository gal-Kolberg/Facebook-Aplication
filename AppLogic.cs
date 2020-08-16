using System;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class AppLogic
    {
        private User LoggedInUser { get; set; }

        public PictureToAscii PicToAscii { get; set; }

        public CheckInRoute CheckInRoute { get; set; }

        public int ImageHight { get; private set; }

        public int ImageWidth { get; private set; }

        public AppLogic()
        {
            FacebookService.s_CollectionLimit = 100;
            LoginResult result = FacebookService.Login(
                "2576935335891542",
            "public_profile",
           "email",
           "publish_to_groups",
           "user_tagged_places",
           "user_videos",
           "groups_access_member_info",
           "user_friends",
           "user_events",
           "user_likes",
           "user_location",
           "user_photos",
           "user_posts",
           "user_hometown");

            if (string.IsNullOrEmpty(result.AccessToken) == false) 
            {
                LoggedInUser = result.LoggedInUser;
            }
            else
            {
                throw new Exception(result.ErrorMessage);
            }

            CheckInRoute = new CheckInRoute(LoggedInUser.Checkins);
        }

        public void Logout()
        {
            FacebookService.Logout(null);
        }

        public void SetPictureToAsciiSettings(int i_HightAscii, int i_WidthAscii, int i_AsciiChars, bool i_BlackToWhite)
        {
            PicToAscii.SetSettings(i_HightAscii, i_WidthAscii, i_AsciiChars, i_BlackToWhite);
        }

        public Image FetchProfilePicture()
        {
            Image profilePicture = LoggedInUser.ImageNormal;

            ImageHight = profilePicture.Height;
            ImageWidth = profilePicture.Width;

            return profilePicture;
        }

        public string FetchLastPost()
        {
            string lastPost = string.Empty;

            try
            {
                foreach (Post userPost in LoggedInUser.Posts)
                {
                    if (string.IsNullOrEmpty(userPost.Message) == false)
                    {
                        lastPost = userPost.Message;
                        break;
                    }
                }
            }
            catch
            {
                lastPost = addMsgIfEmpty(lastPost, "No postes found!");
            }

            return lastPost;
        }

        public string FetchEvents()
        {
            string EventList = string.Empty;

            try
            {
                foreach (Event facebookEvent in LoggedInUser.Events)
                {
                    EventList += string.Format("{0}{1}", facebookEvent.Name, Environment.NewLine);
                }
            }
            catch
            {
                EventList = "You have no social life";
            }

            EventList = addMsgIfEmpty(EventList, "You have no social life");

            return EventList;
        }

        private string addMsgIfEmpty(string i_StringToCheck, string i_Msg)
        {
            if (string.IsNullOrEmpty(i_StringToCheck) == true)
            {
                i_StringToCheck = i_Msg;
            }

            return i_StringToCheck;
        }

        public string FetchFriends()
        {
            string friendsList = string.Empty;

            try
            {
                foreach (User friend in LoggedInUser.Friends)
                {
                    friendsList += string.Format("{0}{1}", friend.Name, Environment.NewLine);
                }
            }
            catch
            {
                friendsList = "You have no friends";
            }

            friendsList = addMsgIfEmpty(friendsList, "You have no friends");

            return friendsList;
        }

        public string FetchGrourps()
        {
            string groupList = string.Empty;

            try
            {
                foreach (Group group in LoggedInUser.Groups)
                {
                    groupList += string.Format("{0}{1}", group.Name, Environment.NewLine);
                }
            }
            catch
            {
                groupList = "You are not a member of any group.";
            }

            groupList = addMsgIfEmpty(groupList, "You are not a member of any group.");

            return groupList;
        }

        public string FetchLikedPages()
        {
            string likedPagesList = string.Empty;

            try
            {
                foreach (Page page in LoggedInUser.LikedPages)
                {
                    likedPagesList += string.Format("{0}{1}", page.Name, Environment.NewLine);
                }
            }
            catch
            {
                likedPagesList = "You have not liked pages.";
            }

            likedPagesList = addMsgIfEmpty(likedPagesList, "You have not liked pages.");

            return likedPagesList;
        }

        public void InitPicToAscii(Image i_ProfilePicture)
        {
            PicToAscii = new PictureToAscii(i_ProfilePicture);
            ImageHight = i_ProfilePicture.Height;
            ImageWidth = i_ProfilePicture.Width;
        }

        public Image FetchCoverPhoto()
        {
            Album coverAlbum = null;
            Image coverImage;

            foreach (Album album in LoggedInUser.Albums)
            {
                if (album.Name == "Cover Photos")
                {
                    coverAlbum = album;
                }
            }

            try
            {
                coverImage = coverAlbum.ImageAlbum;
            }
            catch
            {
                coverImage = null;
            }

            return coverImage;
        }
    }
}