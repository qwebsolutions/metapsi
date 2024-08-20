using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Metapsi.Ui;

//public abstract class HtmlComponent : IHtmlComponent, IHtmlElement
//{
//    public HtmlComponent(string tagName)
//    {
//        this.HtmlTag = new HtmlTag(tagName);
//    }

//    public HtmlTag HtmlTag { get; set; }

//    protected bool Attached { get; set; }

//    void IHtmlComponent.Attach(DocumentTag document, IHtmlElement parentNode)
//    {
//        if (!this.Attached)
//        {
//            OnAttach(document, parentNode);
//            Attached = true;
//        }
//    }

//    protected abstract void OnAttach(DocumentTag documentTag, IHtmlElement parentNode);

//    public HtmlTag GetTag()
//    {
//        return this.HtmlTag;
//    }

//    string IHtmlNode.ToHtml()
//    {
//        return this.GetTag().ToHtml();
//    }
//}

//public abstract class WebComponent : HtmlComponent
//{
//    public WebComponent(string tagName) : base(tagName)
//    {

//    }

//    protected override void OnAttach(DocumentTag documentTag, IHtmlElement parentNode)
//    {
//        var fadeInScript = documentTag.Head.Children.SingleOrDefault(x => x is WebComponentsFadeIn);
//        if (fadeInScript != null)
//        {
//            (fadeInScript as WebComponentsFadeIn).WebComponentTags.Add(this.GetTag().Tag);
//        }
//    }
//}

public static class WebComponentsExtensions
{
    public static void UseWebComponentsFadeIn(this HtmlDocument htmlDocument)
    {
        if (htmlDocument.Head.Children.Any(x => x is WebComponentsFadeIn))
            return;
        htmlDocument.Head.AddChild(new WebComponentsFadeIn());
    }

    public static WebComponentsFadeIn GetWebComponentFadeIn(this HtmlDocument documentTag)
    {
        var wcfi = documentTag.Head.Children.SingleOrDefault(x => x is WebComponentsFadeIn);
        if (wcfi != null)
            return wcfi as WebComponentsFadeIn;
        return null;
    }

    public static void AddToFadeInList(this HtmlDocument documentTag, string webComponentTag)
    {
        var fadeIn = GetWebComponentFadeIn(documentTag);
        if (fadeIn != null)
            fadeIn.WebComponentTags.Add(webComponentTag);
    }
}

public record WebComponentTag(string tag);

public class WebComponentsFadeIn : IHtmlNode
{
    public HashSet<string> WebComponentTags { get; set; } = new();

    public string ToHtml()
    {
        if (!WebComponentTags.Any())
            return string.Empty;

        StringBuilder builder = new StringBuilder();
        builder.AppendLine("<style>\r\n  body {\r\n    opacity: 0;\r\n  }\r\n\r\n  body.ready {\r\n    opacity: 1;\r\n    transition: .25s opacity;\r\n  }\r\n</style>");
        var allWhenDefined = string.Join(",", WebComponentTags.Select(x => $"customElements.whenDefined('{x}')"));
        builder.AppendLine($"<script type=\"module\">\r\n  await Promise.allSettled([{allWhenDefined}]); document.body.classList.add('ready');\r\n</script>");

        return builder.ToString();
    }
}


public class PageBuilder<TModel>
{
}

public interface IControlProps
{

}

public static class PageBuilderExtensions
{
    public static T Server<T>(this PageBuilder<T> builder, Action<T> buildProps) where T : IControlProps, new()
    {
        var props = new T();
        buildProps(props);
        return props;
    }
}