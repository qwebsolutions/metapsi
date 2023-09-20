namespace Metapsi.Ui;

public class SpanTag : HtmlTag
{
    public SpanTag()
    {
        this.Tag = "span";
    }

    public static SpanTag Create(params IHtmlNode[] children)
    {
        var span = new SpanTag();
        span.AddChildren(children);
        return span;
    }
}