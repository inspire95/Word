namespace Word
{
    /// <summary>
    /// The design-time data for a <see cref="TextEntryViewModel"/>
    /// </summary>
    public class TextEntryDesignModel : TextEntryViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static TextEntryDesignModel Instance => new TextEntryDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TextEntryDesignModel()
        {
            Label = "Name";
            OriginalText = "Dawid Urban";
            EditedText = "Editing :)";
        }

        #endregion
    }
}