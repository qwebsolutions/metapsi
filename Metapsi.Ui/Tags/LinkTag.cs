namespace Metapsi.Ui;

public record LinkTag(string rel, string href) : IHtmlTag
{
    public HtmlTag ToTag()
    {
        return new HtmlTag("link")
            .AddAttribute("rel", rel)
            .AddAttribute("href", href);
    }
}
