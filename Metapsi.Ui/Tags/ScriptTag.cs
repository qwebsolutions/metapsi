namespace Metapsi.Ui;

public record ScriptTag(string src, string type) : IHtmlTag
{
    public HtmlTag ToTag()
    {
        var tag = new HtmlTag("script").AddAttribute("src", src);
        if (!string.IsNullOrEmpty(type))
            tag.AddAttribute("type", type);

        return tag;
    }
}
