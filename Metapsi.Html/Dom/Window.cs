using Metapsi.Syntax;
using System.Runtime.CompilerServices;

namespace Metapsi.Html;

/// <summary>
/// The Window interface represents a window containing a DOM document; the document property points to the DOM document loaded in that window.
/// </summary>
public interface Window : EventTarget
{
    /// <summary>
    /// The caches read-only property of the Window interface returns the CacheStorage object associated with the current context. This object enables functionality such as storing assets for offline use, and generating custom responses to requests.
    /// </summary>
    public CacheStorage caches { get; }

    /// <summary>
    /// window.document returns a reference to the document contained in the window.
    /// </summary>
    public Document document { get; }

    /// <summary>
    /// The isSecureContext read-only property of the Window interface returns a boolean indicating whether the current context is secure (true) or not (false).
    /// </summary>
    bool isSecureContext { get; }

    /// <summary>
    /// The localStorage read-only property of the window interface allows you to access a Storage object for the Document's origin; the stored data is saved across browser sessions.
    /// </summary>
    public Storage localStorage { get; }

    /// <summary>
    /// The Window.location read-only property returns a Location object with information about the current location of the document.
    /// </summary>
    public Location location { get; }

    /// <summary>
    /// The Window.navigator read-only property returns a reference to the Navigator object, which has methods and properties about the application running the script.
    /// </summary>
    public Navigator navigator { get; }
}

/// <summary>
/// 
/// </summary>
public static class WindowExtensions
{
    /// <summary>
    /// The Window interface's matchMedia() method returns a new MediaQueryList object that can then be used to determine if the document matches the media query string, as well as to monitor the document to detect when it matches (or stops matching) that media query.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="window"></param>
    /// <param name="mediaQueryString">A string specifying the media query to parse into a MediaQueryList.</param>
    /// <returns></returns>
    public static Var<MediaQueryList> WindowMatchMedia(this SyntaxBuilder b, Var<Window> window, Var<string> mediaQueryString)
    {
        return b.CallOnObject<MediaQueryList>(window, "matchMedia", mediaQueryString);
    }

    /// <summary>
    /// The Window interface's matchMedia() method returns a new MediaQueryList object that can then be used to determine if the document matches the media query string, as well as to monitor the document to detect when it matches (or stops matching) that media query.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="mediaQueryString">A string specifying the media query to parse into a MediaQueryList.</param>
    /// <returns></returns>
    public static Var<MediaQueryList> WindowMatchMedia(this SyntaxBuilder b, Var<string> mediaQueryString)
    {
        return b.WindowMatchMedia(b.Window(), mediaQueryString);
    }
}
