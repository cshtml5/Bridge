namespace System
{
    /// <summary>
    /// Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.
    /// </summary>
    [Bridge.Convention(Member = Bridge.ConventionMember.Method | Bridge.ConventionMember.Field, Notation = Bridge.Notation.CamelCase)]
    [Bridge.Reflectable]
    [Bridge.External]
    public class Uri
    {
        /// <summary>
        /// Initializes a new instance of the Uri class with the specified URI.
        /// </summary>
        /// <param name="uriString"></param>
        public extern Uri(string uriString);

        /// <summary>
        /// Initializes a new instance of the System.Uri class with the specified URI. This constructor allows you to specify if the URI string is a relative URI, absolute URI, or is indeterminate.
        /// </summary>
        /// <param name="uriString">
        /// A string that identifies the resource to be represented by the System.Uri instance.
        /// </param>
        /// <param name="uriKind">Specifies whether the URI string is a relative URI, absolute URI, or is indeterminate.</param>
        public extern Uri(string uriString, UriKind uriKind);

        /// <summary>
        /// Gets the original URI string that was passed to the System.Uri constructor.
        /// </summary>
        public extern string OriginalString
        {
            [Bridge.Template("getOriginalString()")]
            get;
        }

        /// <summary>
        /// Gets whether the Uri instance is absolute.
        /// </summary>
        public extern bool IsAbsoluteUri
        {
            [Bridge.Template("getIsAbsolute()")]
            get;
        }

        /// <summary>
        /// Gets the absolute URI.
        /// </summary>
        public extern string AbsoluteUri
        {
            [Bridge.Template("getAbsoluteUri()")]
            get;
        }

        /// <summary>
        /// Gets the scheme name for this URI.
        /// </summary>
        public extern string Scheme
        {
            [Bridge.Template("getProtocol()")]
            get;
        }

        /// <summary>
        /// Gets the host component of this instance.
        /// </summary>
        public extern string Host
        {
            [Bridge.Template("getHostName()")]
            get;
        }

        /// <summary>
        /// Gets any query information included in the specified URI.
        /// </summary>
        public extern string Query
        {
            [Bridge.Template("getSearch()")]
            get;
        }

        /// <summary>
        /// Gets the port number of this URI.
        /// </summary>
        public extern int Port
        {
            [Bridge.Template("getPort()")]
            get;
        }

        /// <summary>
        /// Gets the escaped URI fragment.
        /// </summary>
        public extern string Fragment
        {
            [Bridge.Template("getHash()")]
            get;
        }

        /// <summary>
        /// Converts a string to its escaped representation.
        /// </summary>
        /// <param name="data">The string to escape.</param>
        /// <returns>A System.String that contains the escaped representation of stringToEscape.</returns>
        [Bridge.Template("encodeURIComponent({data})")]
        public static extern string EscapeDataString(string data);

        [Bridge.Template("System.Uri.equals({uri1}, {uri2})")]
        public static extern bool operator ==(Uri uri1, Uri uri2);

        [Bridge.Template("System.Uri.notEquals({uri1}, {uri2})")]
        public static extern bool operator !=(Uri uri1, Uri uri2);
    }
}