namespace Metapsi.Html;

public static class HtmlTitleExtensions
{
    public static IHtmlNode HtmlTitle(this HtmlBuilder b, string title)
    {
        return b.HtmlTitle(b.Text(title));
    }
}
