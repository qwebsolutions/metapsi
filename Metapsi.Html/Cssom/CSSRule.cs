namespace Metapsi.Html;

/// <summary>
/// The CSSRule interface represents a single CSS rule. There are several types of rules which inherit properties from CSSRule.
/// </summary>
public interface CSSRule
{
    /// <summary>
    /// The cssText property of the CSSRule interface returns the actual text of a CSSStyleSheet style-rule.
    /// </summary>
    string cssText { get; }

    /// <summary>
    /// The parentRule property of the CSSRule interface returns the containing rule of the current rule if this exists, or otherwise returns null.
    /// </summary>
    CSSRule parentRule { get; }

    /// <summary>
    /// The parentStyleSheet property of the CSSRule interface returns the StyleSheet object in which the current rule is defined.
    /// </summary>
    StyleSheet parentStyleSheet { get; }
}
