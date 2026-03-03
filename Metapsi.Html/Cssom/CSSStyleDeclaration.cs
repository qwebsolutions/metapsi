namespace Metapsi.Html;

/// <summary>
/// The CSSStyleDeclaration interface is the base class for objects that represent CSS declaration blocks
/// </summary>
public interface CSSStyleDeclaration
{
    /// <summary>
    /// The cssText property of the CSSStyleDeclaration interface returns or sets the text of the element's inline style declaration only.
    /// </summary>
    string cssText { get; set; }

    /// <summary>
    /// The read-only property returns an integer that represents the number of style declarations in this CSS declaration block.
    /// </summary>
    int length { get; set; }

    /// <summary>
    /// The CSSStyleDeclaration.parentRule read-only property returns a CSSRule that is the parent of this style block
    /// </summary>
    CSSRule parentRule { get; }
}
