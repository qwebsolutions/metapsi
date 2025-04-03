namespace Metapsi.Html;

/// <summary>
/// A MediaQueryList object stores information on a media query applied to a document, with support for both immediate and event-driven matching against the state of the document.
/// </summary>
public interface MediaQueryList : EventTarget
{
    /// <summary>
    /// The matches read-only property of the MediaQueryList interface is a boolean value that returns true if the document currently matches the media query list, or false if not.
    /// </summary>
    bool matches { get; }

    /// <summary>
    /// The media read-only property of the MediaQueryList interface is a string representing a serialized media query.
    /// </summary>
    string media { get; }
}