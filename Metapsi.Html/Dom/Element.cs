using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// Element is the most general base class from which all element objects (i.e. objects that represent elements) in a Document inherit. It only has methods and properties common to all kinds of elements. More specific classes inherit from Element.
/// </summary>
public interface Element : Node
{

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