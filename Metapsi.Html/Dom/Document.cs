using Metapsi.Syntax;

namespace Metapsi.Html;

public interface Document: Node
{

}

public static class DocumentExtensions
{
    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<Document> document, Var<string> selectors)
    {
        return b.CallOnObject<Element>(document, "querySelector", selectors);
    }

    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<string> selector)
    {
        return b.QuerySelector(b.Document(), selector);
    }

    public static Var<Element> QuerySelector(this SyntaxBuilder b, string selector)
    {
        return b.QuerySelector(b.Const(selector));
    }
}