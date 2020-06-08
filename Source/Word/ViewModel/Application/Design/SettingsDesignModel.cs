using System.Collections.Generic;

namespace Word
{
    /// <summary>
    /// The design-time data for a <see cref="SettingsViewModel"/>
    /// </summary>
    public class SettingsDesignModel : SettingsViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SettingsDesignModel Instance => new SettingsDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsDesignModel()
        {
            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Dawid Urban" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "inspire95" };
            Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "password" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "dawidurban95@gmail.com" };
        }

        #endregion
    }
}