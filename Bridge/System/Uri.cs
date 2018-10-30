namespace System
{
    /// <summary>
    /// Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.
    /// </summary>
    [Bridge.Convention(Member = Bridge.ConventionMember.Field | Bridge.ConventionMember.Method, Notation = Bridge.Notation.CamelCase)]
    [Bridge.External]
    [Bridge.Reflectable]
    public class Uri
    {
        public extern Uri(string uriString);

        /// <summary>
        /// Initializes a new instance of the System.Uri class with the specified URI. This constructor allows you to specify if the URI string is a relative URI, absolute URI, or is indeterminate.
        /// </summary>
        /// <param name="uriString">
        /// A string that identifies the resource to be represented by the System.Uri instance.
        /// </param>
        /// <param name="uriKind">Specifies whether the URI string is a relative URI, absolute URI, or is indeterminate.</param>
        public extern Uri(string uriString, UriKind uriKind);

        public extern string AbsoluteUri
        {
            [Bridge.Template("getAbsoluteUri()")]
            get;
        }

        /// <summary>
        /// Gets the original URI string that was passed to the System.Uri constructor.
        /// </summary>
        public extern string OriginalString
        {
            [Bridge.Template("getOriginalString()")]
            get;
        }

        [Bridge.Template("System.Uri.equals({uri1}, {uri2})")]
        public static extern bool operator ==(Uri uri1, Uri uri2);

        [Bridge.Template("System.Uri.notEquals({uri1}, {uri2})")]
        public static extern bool operator !=(Uri uri1, Uri uri2);
    }
}