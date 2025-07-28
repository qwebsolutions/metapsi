namespace Metapsi.Html;

/// <summary>
/// An object implementing the StyleSheet interface represents a single style sheet. CSS style sheets will further implement the more specialized CSSStyleSheet interface.
/// </summary>
public interface StyleSheet
{
    /// <summary>
    /// The disabled property of the StyleSheet interface determines whether the style sheet is prevented from applying to the document.
    /// A style sheet may be disabled by manually setting this property to true or if it's an inactive alternative style sheet. Note that disabled === false does not guarantee the style sheet is applied (it could be removed from the document, for instance).
    /// </summary>
    bool disabled { get; set; }

    /// <summary>
    /// The href property of the StyleSheet interface returns the location of the style sheet. This property is read-only.
    /// </summary>
    string href { get; }

    /// <summary>
    /// The media property of the StyleSheet interface specifies the intended destination media for style information. It is a read-only, array-like MediaList object and can be removed with deleteMedium() and added with appendMedium().
    /// </summary>
    MediaList media { get; }

    /// <summary>
    /// The ownerNode property of the StyleSheet interface returns the node that associates this style sheet with the document.
    /// </summary>
    Node ownerNode { get; }

    /// <summary>
    /// The parentStyleSheet property of the StyleSheet interface returns the style sheet, if any, that is including the given style sheet.
    /// </summary>
    StyleSheet parentStyleSheet { get; }

    /// <summary>
    /// The title property of the StyleSheet interface returns the advisory title of the current style sheet.
    /// The title is often specified in the ownerNode.
    /// </summary>
    string title { get; }

    /// <summary>
    /// The type property of the StyleSheet interface specifies the style sheet language for the given style sheet.
    /// </summary>
    string type { get; set; }
}
