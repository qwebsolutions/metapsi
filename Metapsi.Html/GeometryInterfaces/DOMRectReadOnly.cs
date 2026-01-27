namespace Metapsi.Html;

/// <summary>
/// The DOMRectReadOnly interface specifies the standard properties (also used by DOMRect) to define a rectangle whose properties are immutable.
/// </summary>
public interface DOMRectReadOnly
{
    /// <summary>
    /// The bottom read-only property of the DOMRectReadOnly interface returns the bottom coordinate value of the DOMRect. (Has the same value as y + height, or y if height is negative.)
    /// </summary>
    decimal bottom { get; }

    /// <summary>
    /// The height read-only property of the DOMRectReadOnly interface represents the height of the DOMRect.
    /// </summary>
    decimal height { get;  }

    /// <summary>
    /// The left read-only property of the DOMRectReadOnly interface returns the left coordinate value of the DOMRect. (Has the same value as x, or x + width if width is negative.)
    /// </summary>
    decimal left { get; }

    /// <summary>
    /// The right read-only property of the DOMRectReadOnly interface returns the right coordinate value of the DOMRect. (Has the same value as x + width, or x if width is negative.)
    /// </summary>
    decimal right { get; }

    /// <summary>
    /// The top read-only property of the DOMRectReadOnly interface returns the top coordinate value of the DOMRect. (Has the same value as y, or y + height if height is negative.)
    /// </summary>
    decimal top { get; }

    /// <summary>
    /// The width read-only property of the DOMRectReadOnly interface represents the width of the DOMRect.
    /// </summary>
    decimal width { get; }

    /// <summary>
    /// The x read-only property of the DOMRectReadOnly interface represents the x coordinate of the DOMRect's origin.
    /// </summary>
    decimal x { get; }

    /// <summary>
    /// The y read-only property of the DOMRectReadOnly interface represents the y coordinate of the DOMRect's origin.
    /// </summary>
    decimal y { get; }
}
