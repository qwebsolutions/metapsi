using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// A CSSRuleList represents an ordered collection of read-only CSSRule objects.
/// </summary>
public interface CSSRuleList
{
    /// <summary>
    /// The length property of the CSSRuleList interface returns the number of CSSRule objects in the list.
    /// </summary>
    int length { get; }
}

/// <summary>
/// 
/// </summary>
public static class CSSRuleListExtensions
{
    /// <summary>
    /// The item() method of the CSSRuleList interface returns the CSSRule object at the specified index or null if the specified index doesn't exist.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cssRuleList"></param>
    /// <param name="index">An integer.</param>
    /// <returns>A CSSRule.</returns>
    public static Var<CSSRule> CSSRuleListItem(this SyntaxBuilder b, Var<CSSRuleList> cssRuleList, Var<int> index)
    {
        return b.CallOnObject<CSSRule>(cssRuleList, "item", index);
    }
}