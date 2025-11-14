namespace Metapsi.Html;

/// <summary>
/// The CSSStyleSheet interface represents a single CSS stylesheet, and lets you inspect and modify the list of rules contained in the stylesheet. It inherits properties and methods from its parent, StyleSheet.
/// </summary>
public interface CSSStyleSheet : StyleSheet
{
    /// <summary>
    /// The read-only CSSStyleSheet property cssRules returns a live CSSRuleList which provides a real-time, up-to-date list of every CSS rule which comprises the stylesheet. Each item in the list is a CSSRule defining a single rule.
    /// </summary>
    CSSRuleList cssRules { get; }

    /// <summary>
    /// The read-only CSSStyleSheet property ownerRule returns the CSSImportRule corresponding to the @import at-rule which imported the stylesheet into the document. If the stylesheet wasn't imported into the document using @import, the returned value is null.
    /// </summary>
    CSSImportRule ownerRule { get; }
}
