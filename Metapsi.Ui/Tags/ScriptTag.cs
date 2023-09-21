namespace Metapsi.Ui;

public record ExternalScriptTag(string src, string type) : DistinctTag
{
    public override HtmlTag GetTag()
    {
        var tag = new HtmlTag("script").SetAttribute("src", src);
        if (!string.IsNullOrEmpty(type))
            tag.SetAttribute("type", type);

        return tag;
    }
}