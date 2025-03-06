using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// The URL() constructor returns a newly created URL object representing the URL defined by the parameters.
    /// </summary>
    public interface URL
    {
        /// <summary>
        /// The hash property of the URL interface is a string containing a "#" followed by the fragment identifier of the URL. If the URL does not have a fragment identifier, this property contains an empty string, "".
        /// </summary>
        public string hash { get; set; }

        /// <summary>
        /// The host property of the URL interface is a string containing the host, which is the hostname, and then, if the port of the URL is nonempty, a ":", followed by the port of the URL. If the URL does not have a hostname, this property contains an empty string, "".
        /// </summary>
        public string host { get; set; }

        /// <summary>
        /// The hostname property of the URL interface is a string containing either the domain name or IP address of the URL. If the URL does not have a hostname, this property contains an empty string, "". IPv4 and IPv6 addresses are normalized, such as stripping leading zeros, and domain names are converted to IDN.
        /// </summary>
        public string hostname { get; set; }

        /// <summary>
        /// The href property of the URL interface is a string containing the whole URL.
        /// </summary>
        public string href { get; set; }

        /// <summary>
        /// The origin read-only property of the URL interface returns a string containing the Unicode serialization of the origin of the represented URL.
        /// </summary>
        public string origin { get; }

        /// <summary>
        /// The password property of the URL interface is a string containing the password component of the URL. If the URL does not have a password, this property contains an empty string, "".
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// The pathname property of the URL interface represents a location in a hierarchical structure. It is a string constructed from a list of path segments, each of which is prefixed by a / character.
        /// </summary>
        public string pathname { get; set; }

        /// <summary>
        /// The port property of the URL interface is a string containing the port number of the URL. If the port is the default for the protocol (80 for ws: and http:, 443 for wss: and https:, and 21 for ftp:), this property contains an empty string, "".
        /// </summary>
        public string port { get; set; }

        /// <summary>
        /// The protocol property of the URL interface is a string containing the protocol or scheme of the URL, including the final ":". If the port is the default for the protocol (80 for ws: and http:, 443 for wss: and https:, and 21 for ftp:), this property contains an empty string, "".
        /// </summary>
        public string protocol { get; set; }

        /// <summary>
        /// The search property of the URL interface is a search string, also called a query string, that is a string containing a "?" followed by the parameters of the URL. If the URL does not have a search query, this property contains an empty string, "".
        /// </summary>
        public string search { get; set; }

        /// <summary>
        /// The searchParams read-only property of the URL interface returns a URLSearchParams object allowing access to the GET decoded query arguments contained in the URL.
        /// </summary>
        public URLSearchParams searchParams { get; }

        /// <summary>
        /// The username property of the URL interface is a string containing the username component of the URL. If the URL does not have a username, this property contains an empty string, "".
        /// </summary>
        public string username { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class URLExtensions
    {
        public static Var<string> URLCreateObjectURL<TBlob>(this SyntaxBuilder b, Var<TBlob> blob)
            where TBlob: Blob
        {
            return b.CallOnObject<string>(
                b.GetProperty<object>(b.Self(), "URL"), 
                "createObjectURL",
                blob);
        }

        public static Var<string> URLCreateObjectURL(this SyntaxBuilder b, Var<MediaSource> mediaSource)
        {
            return b.CallOnObject<string>(
                b.GetProperty<object>(b.Self(), "URL"),
                "createObjectURL",
                mediaSource);
        }
    }
}
