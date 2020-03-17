using System.Collections.Generic;

namespace Word
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name = "Dawid",
                    Initials = "LM",
                    Message = "Ten czat jest super!",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true
                },
                new ChatListItemViewModel
                {
                    Name = "Kamil",
                    Initials = "JA",
                    Message = "Hej, co u Ciebie?",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Name = "Arek",
                    Initials = "PL",
                    Message = "Super sprawa",
                    ProfilePictureRGB = "00d405",
                    IsSelected = true
                },
                new ChatListItemViewModel
                {
                    Name = "Dawid",
                    Initials = "LM",
                    Message = "Kiedy to zadanie zostanie ukończone?",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Name = "Kamil",
                    Initials = "JA",
                    Message = "Czekam na odpowiedz",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Name = "Arek",
                    Initials = "PL",
                    Message = "Sprawdz nowy serwer",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Name = "Dawid",
                    Initials = "LM",
                    Message = "???",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Name = "Kamil",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Name = "Arek",
                    Initials = "PL",
                    Message = "192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
            };
        }

        #endregion
    }
}