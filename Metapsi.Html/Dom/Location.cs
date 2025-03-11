﻿namespace Metapsi.Html;

/// <summary>
/// The Location interface represents the location (URL) of the object it is linked to. Changes done on it are reflected on the object it relates to. Both the Document and Window interface have such a linked Location, accessible via Document.location and Window.location respectively.
/// </summary>
public interface Location
{
    /// <summary>
    /// The hash property of the Location interface is a string containing a "#" followed by the fragment identifier of the location URL. If the URL does not have a fragment identifier, this property contains an empty string, "".
    /// </summary>
    public string hash { get; set; }

    /// <summary>
    /// The host property of the Location interface is a string containing the host, which is the hostname, and then, if the port of the URL is nonempty, a ":", followed by the port of the URL. If the URL does not have a hostname, this property contains an empty string, "".
    /// </summary>
    public string host { get; set; }

    /// <summary>
    /// The hostname property of the Location interface is a string containing either the domain name or IP address of the location URL. If the URL does not have a hostname, this property contains an empty string, "". IPv4 and IPv6 addresses are normalized, such as stripping leading zeros, and domain names are converted to IDN.
    /// </summary>
    public string hostname { get; set; }

    /// <summary>
    /// The href property of the Location interface is a stringifier that returns a string containing the whole URL, and allows the href to be updated.
    /// </summary>
    public string href { get; set; }

    /// <summary>
    /// The origin read-only property of the Location interface returns a string containing the Unicode serialization of the origin of the location's URL.
    /// </summary>
    public string origin { get; set; }

    /// <summary>
    /// The pathname property of the Location interface is a string containing the path of the URL for the location. If there is no path, pathname will be empty: otherwise, pathname contains an initial '/' followed by the path of the URL, not including the query string or fragment.
    /// </summary>
    public string pathname { get; set; }

    /// <summary>
    /// The port property of the Location interface is a string containing the port number of the location's URL. If the port is the default for the protocol (80 for ws: and http:, 443 for wss: and https:, and 21 for ftp:), this property contains an empty string, "".
    /// </summary>
    public string port { get; set; }

    /// <summary>
    /// The protocol property of the Location interface is a string containing the protocol or scheme of the location's URL, including the final ":". If the port is the default for the protocol (80 for ws: and http:, 443 for wss: and https:, and 21 for ftp:), this property contains an empty string, "".
    /// </summary>
    public string protocol { get; set; }

    /// <summary>
    /// The search property of the Location interface is a search string, also called a query string, that is a string containing a "?" followed by the parameters of the location's URL. If the URL does not have a search query, this property contains an empty string, "".
    /// </summary>
    public string search { get; set; }
}