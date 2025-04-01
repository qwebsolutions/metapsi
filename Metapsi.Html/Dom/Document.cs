using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The Document interface represents any web page loaded in the browser and serves as an entry point into the web page's content, which is the DOM tree.
/// </summary>
public interface Document: Node
{
    /// <summary>
    /// The Document.body property represents the &lt;body&gt; or &lt;frameset&gt; node of the current document, or null if no such element exists.
    /// </summary>
    HTMLElement body { get; }

    /// <summary>
    /// The activeElement read-only property of the Document interface returns the Element within the DOM that is receiving keyboard events such as keydown and keyup. This is usually analogous to the focused element.
    /// </summary>
    Element activeElement { get; }
}

/// <summary>
/// 
/// </summary>
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