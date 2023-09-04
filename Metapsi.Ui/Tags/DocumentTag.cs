namespace Metapsi.Ui;

public class DocumentTag : HtmlTag
{
    public HeadTag Head { get; set; } = new();
    public BodyTag Body { get; set; } = new();

    public DocumentTag()
    {
        this.Tag = "html";
        var head = this.AddChild(Head);
        var body = this.AddChild(this.Body);
    }

    public static DocumentTag Create(string title = "", string lang = "en", string charset = "utf-8")
    {
        var documentTag = new DocumentTag();
        documentTag.AddAttribute("lang", "en");

        if(!string.IsNullOrEmpty(title))
        {
            var titleTag = documentTag.AddChild(new HtmlTag() { Tag = "title" });
            titleTag.AddText(title);
        }

        var metaCharset = documentTag.Head.AddChild(new HtmlTag("meta"));
        metaCharset.AddAttribute("charset", "utf-8");

        var metaViewport = documentTag.Head.AddChild(new HtmlTag("meta"));
        metaViewport.AddAttribute("name", "viewport");
        metaViewport.AddAttribute("content", "width=device-width,initial-scale=1");

        return documentTag;
    }
}

