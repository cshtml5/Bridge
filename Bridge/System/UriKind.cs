namespace System
{
    /// <summary>
    /// Defines the kinds of System.Uris
    /// </summary>
    public enum UriKind
    {
        /// <summary>
        /// The kind of the Uri is indeterminate.
        /// </summary>
        RelativeOrAbsolute = 0,

        /// <summary>
        /// The Uri is an absolute Uri.
        /// </summary>
        Absolute = 1,

        /// <summary>
        /// The Uri is a relative Uri.
        /// </summary>
        Relative = 2,
    }
}
