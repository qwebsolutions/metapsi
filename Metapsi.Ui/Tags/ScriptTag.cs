namespace Metapsi.Ui;

public record ExternalScriptTag(string src, string type) : DistinctTag
{
    public override HtmlTag ToTag()
    {
        var tag = new HtmlTag("script").AddAttribute("src", src);
        if (!string.IsNullOrEmpty(type))
            tag.AddAttribute("type", type);

        return tag;
    }
}
