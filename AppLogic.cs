using System;
using System.Drawing;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApplicationLogic
{
    public class AppLogic
    {
        public ApplicationUser LoggedInUser { get; set; }

        private FacebookObjectCollection<User> UserFriends { get; set; }

        private Sorter Sorter { get; set; }

        public void Login()
        {
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
                LoggedInUser = new ApplicationUser(result.LoggedInUser);
                UserFriends = LoggedInUser.User.Friends;
            }
            else
            {
                throw new Exception(result.ErrorMessage);
            }
        }

        public void Logout()
        {
            FacebookService.Logout(null);
        }

        public string SortBy(eSortBy i_SortBy)
        {
            switch (i_SortBy)
            {
                case eSortBy.Alpabetical:
                    Sorter = new Sorter(new SortAlphabetical());
                    break;
                case eSortBy.Age:
                    Sorter = new Sorter(new SortAge());
                    break;
                case eSortBy.Date:
                    Sorter = new Sorter(new SortDate());
                    break;
                case eSortBy.Random:
                    Sorter = new Sorter(new SortRandom());
                    break;
                default:
                    break;
            }

            return Sorter.Sort(UserFriends);
        }

        public Image FetchCoverPhoto()
        {
            Album coverAlbum = null;
            Image coverImage;

            foreach (Album album in LoggedInUser.User.Albums)
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

        public Image FetchProfilePicture()
        {
            return LoggedInUser.User.ImageNormal;
        }

        public string FetchLastPost()
        {
            string lastPost = string.Empty;

            try
            {
                foreach (Post userPost in LoggedInUser.User.Posts)
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

        public string FetchLikedPages()
        {
            string likedPagesList = string.Empty;

            try
            {
                foreach (Page page in LoggedInUser.User.LikedPages)
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

        public string FetchGrourps()
        {
            string groupList = string.Empty;

            try
            {
                foreach (Group group in LoggedInUser.User.Groups)
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

        public string FetchFriends()
        {
            string friendsList = string.Empty;

            try
            {
                foreach (User friend in LoggedInUser.User.Friends)
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

        public string FetchEvents()
        {
            string eventList = string.Empty;

            try
            {
                foreach (Event facebookEvent in LoggedInUser.User.Events)
                {
                    eventList += string.Format("{0}{1}", facebookEvent.Name, Environment.NewLine);
                }
            }
            catch
            {
                eventList = "You have no social life";
            }

            eventList = addMsgIfEmpty(eventList, "You have no social life");

            return eventList;
        }

        private string addMsgIfEmpty(string i_StringToCheck, string i_Msg)
        {
            if (string.IsNullOrEmpty(i_StringToCheck) == true)
            {
                i_StringToCheck = i_Msg;
            }

            return i_StringToCheck;
        }
    }
}