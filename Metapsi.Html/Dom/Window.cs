namespace Metapsi.Html;

/// <summary>
/// The Window interface represents a window containing a DOM document; the document property points to the DOM document loaded in that window.
/// </summary>
public interface Window : EventTarget
{
    /// <summary>
    /// window.document returns a reference to the document contained in the window.
    /// </summary>
    public Document document { get; }

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
