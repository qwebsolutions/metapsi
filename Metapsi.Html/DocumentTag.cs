using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Metapsi.Html;

//public class HtmlDocument : IHtmlNode, IHtmlElement
//{
//    public HtmlDocument()
//    {
//        this.tag = new HtmlTag("html")
//        {
//            Attributes = this.Attributes,
//            Children = new List<IHtmlNode>() { Head, Body }
//        };
//    }

//    public Dictionary<string, string> Attributes { get; set; } = new();

//    private HtmlTag tag = null;

//    public HtmlTag Head { get; set; } = new HtmlTag("head");
//    public HtmlTag Body { get; set; } = new HtmlTag("body");

//    public string ToHtml()
//    {
//        StringBuilder stringBuilder = new StringBuilder();
//        stringBuilder.AppendLine("<!DOCTYPE html>");
//        stringBuilder.AppendLine(tag.ToHtml());
//        return stringBuilder.ToString();
//    }

//    public HtmlTag GetTag()
//    {
//        return tag;
//    }
//}

public class ToHtmlOptions
{
    public ToJavaScriptOptions ToJavaScriptOptions { get; set; } = new ToJavaScriptOptions();
    public int Indent { get; set; } = 2;
    public Func<HtmlDocument, Metapsi.Syntax.ResourceMetadata, string> ResolveResource { get; set; } = (htmlDocument, resource) =>
    {
        //if (string.IsNullOrWhiteSpace(resource.FileHash))
        //{
        //    resource.FileHash = GetEmbeddedFileHashMetadata(htmlDocument, resource.RelativePath);
        //}
        return resource.GetDefaultHttpPath();
    };

    //private static string GetEmbeddedFileHashMetadata(HtmlDocument htmlDocument, string fileName)
    //{
    //    var isKnownResource = htmlDocument.Metadata.Contains(new Metadata()
    //    {
    //        Type = "embedded-resource-name",
    //        Value = fileName.ToLowerInvariant()
    //    });
    //    if (!isKnownResource)
    //        return string.Empty;

    //    var allEmbeddedResources = htmlDocument.Metadata.Where(x => x.Type == "embedded-resource");
    //    foreach (var resource in allEmbeddedResources)
    //    {
    //        var r = Metapsi.Serialize.FromJson<ResourceMetadata>(resource.Value);
    //        if (r.LogicalName == fileName)
    //            return r.FileHash;
    //    }

    //    return string.Empty;
    //}
}

public class HtmlDocument : HtmlTag
{
    public HashSet<Metapsi.Syntax.Metadata> Metadata { get; set; } = new HashSet<Syntax.Metadata>();

    public HtmlDocument() : base("html")
    {
        this.Children.Add(new HtmlNode() { Tags = new List<HtmlTag>() { this.Head } });
        this.Children.Add(new HtmlNode() { Tags = new List<HtmlTag>() { this.Body } });
    }

    public HtmlTag Head { get; } = new HtmlTag("head");
    public HtmlTag Body { get; } = new HtmlTag("body");

    public override string ToHtml(ToHtmlOptions options = null)
    {
        if (options == null) options = new ToHtmlOptions();
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("<!DOCTYPE html>");
        stringBuilder.AppendLine(base.ToHtml(options));
        return stringBuilder.ToString();
    }
}



//public class DocumentTag : HtmlTag
//{
//    public HeadTag Head { get; set; } = new();
//    public BodyTag Body { get; set; } = new();

//    public DocumentTag()
//    {
//        this.Tag = "html";
//        var head = this.AddChild(Head);
//        var body = this.AddChild(this.Body);
//    }

//    public static DocumentTag Create(string title = "", string lang = "en", string charset = "utf-8")
//    {
//        var documentTag = new DocumentTag();
//        documentTag.SetAttribute("lang", "en");

//        if(!string.IsNullOrEmpty(title))
//        {
//            var titleTag = documentTag.Head.AddChild(new HtmlTag() { Tag = "title" });
//            titleTag.AddText(title);
//        }

//        var metaCharset = documentTag.Head.AddChild(new HtmlTag("meta"));
//        metaCharset.SetAttribute("charset", "utf-8");

//        var metaViewport = documentTag.Head.AddChild(new HtmlTag("meta"));
//        metaViewport.SetAttribute("name", "viewport");
//        metaViewport.SetAttribute("content", "width=device-width,initial-scale=1");

//        return documentTag;
//    }
//}

