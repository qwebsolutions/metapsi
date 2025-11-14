namespace Metapsi.Html;

/// <summary>
/// The MediaList interface represents the media queries of a stylesheet, e.g., those set using a &lt;link&gt; element's media attribute.
/// </summary>
public interface MediaList
{
    /// <summary>
    /// The read-only length property of the MediaList interface returns the number of media queries in the list.
    /// </summary>
    int length { get; }

    /// <summary>
    /// The mediaText property of the MediaList interface is a stringifier that returns a string representing the MediaList as text, and also allows you to set a new MediaList.
    /// </summary>
    string mediaText { get; set; }
}