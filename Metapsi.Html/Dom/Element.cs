using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// Element is the most general base class from which all element objects (i.e. objects that represent elements) in a Document inherit. It only has methods and properties common to all kinds of elements. More specific classes inherit from Element.
/// </summary>
public interface Element : Node
{
    /// <summary>
    /// The id property of the Element interface represents the element's identifier, reflecting the id global attribute.
    /// </summary>
    public string id { get; set; }

    /// <summary>
    /// The Element property innerHTML gets or sets the HTML or XML markup contained within the element.
    /// </summary>
    public string innerHTML { get; set; }

    /// <summary>
    /// The outerHTML attribute of the Element DOM interface gets the serialized HTML fragment describing the element including its descendants. It can also be set to replace the element with nodes parsed from the given string.
    /// </summary>
    public string outerHTML { get; set; }

    /// <summary>
    /// The slot property of the Element interface returns the name of the shadow DOM slot the element is inserted in.
    /// </summary>
    public string slot { get; set; }

    /// <summary>
    /// The tagName read-only property of the Element interface returns the tag name of the element on which it's called.
    /// </summary>
    public string tagName { get; }
}

public static class ElementExtensions
{
    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<Element> parent, Var<string> selectors)
    {
        return b.CallOnObject<Element>(parent, "querySelector", selectors);
    }

    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<Element> parent, string selectors)
    {
        return b.QuerySelector(parent, b.Const(selectors));
    }
}