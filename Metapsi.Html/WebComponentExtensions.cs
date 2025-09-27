using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metapsi.Html;

public static class WebComponentExtensions
{
    public static void TrackWebComponent(this HashSet<Metadata> b, string webComponentTag)
    {
        b.Add(new Metadata()
        {
            Type = "web-component",
            Value = webComponentTag,
        });
    }

    public static Var<Promise> WhenDefined(this SyntaxBuilder b, Var<string> tag)
    {
        var customElements = b.GetProperty<object>(b.Self(), "customElements");
        var whenDefinedPromise = b.CallOnObject<Promise>(customElements, "whenDefined", tag);
        return whenDefinedPromise;
    }

    public static Var<Promise> WhenDefined(this SyntaxBuilder b, Var<List<string>> tags)
    {
        var whenAllDefined = b.PromiseAllSettled(b.Map(tags, (b, tag) => b.WhenDefined(tag)));
        return whenAllDefined;
    }

    public static Var<Promise> WhenDefined(this SyntaxBuilder b, params string[] tags)
    {
        return b.WhenDefined(b.Const(tags.ToList()));
    }

    public static IHtmlNode WebComponentsFadeInScript(this HtmlBuilder b)
    {
        var webComponentTags = b.Document.Metadata.Where(x => x.Type == "web-component");
        //b.Document.Metadata.AddRequiredTagMetadata(
        //    new HtmlTag("style")
        //    {
        //        Children = new List<HtmlNode>()
        //        {
        //            new HtmlNode()
        //            {
        //                Text = new ()
        //                {
        //                    new HtmlText()
        //                    {
        //                        Text = "body {\r\n    opacity: 0;\r\n  }\r\n\r\n  body.ready {\r\n    opacity: 1;\r\n    transition: .25s opacity;\r\n  }\r\n"
        //                    }
        //                }
        //            }
        //        }
        //    });

        b.HeadAppend(
            b.HtmlStyle(
                b.Text("body {\r\n    opacity: 0;\r\n  }\r\n\r\n  body.ready {\r\n    opacity: 1;\r\n    transition: .25s opacity;\r\n  }\r\n")));

        return b.HtmlScriptModule(
            b =>
            {
                b.PromiseThen(
                    b.WhenDefined(webComponentTags.Select(x => x.Value).ToArray()),
                    (SyntaxBuilder b, Var<object> _) =>
                    {
                        b.CallOnObject(
                            b.Get(b.Document(), x => x.body.classList),
                            "add",
                            b.Const("ready"));
                    });
            });
    }
}

//public class WebComponentsTracker : IHtmlNode
//{
//    public HashSet<string> WebComponentTags { get; set; } = new();

//    public string ToHtml(System.Func<ResourceMetadata, string> resourceResolver)
//    {
//        return string.Empty;
//    }
//}

//public class WebComponentsFadeInScript : IHtmlNode
//{
//    public WebComponentsTracker WebComponentsTracker { get; set; }

//    public string ToHtml(System.Func<ResourceMetadata, string> resourceResolver)
//    {
//        StringBuilder builder = new StringBuilder();
//        builder.AppendLine("<style>\r\n  body {\r\n    opacity: 0;\r\n  }\r\n\r\n  body.ready {\r\n    opacity: 1;\r\n    transition: .25s opacity;\r\n  }\r\n</style>");
//        var allWhenDefined = string.Join(",", WebComponentsTracker.WebComponentTags.Select(x => $"customElements.whenDefined('{x}')"));
//        builder.AppendLine($"<script type=\"module\">\r\n  await Promise.allSettled([{allWhenDefined}]); document.body.classList.add('ready');\r\n</script>");

//        return builder.ToString();
//    }
//}

//public static class WebComponentsFadeInExtensions
//{
//    public static void UseWebComponentsFadeIn(this HtmlBuilder b)
//    {
//        //b.AddWebComponentsTracker();
//        //var tracker = b.GetWebComponentsTracker();
//        //b.HeadAppend(new WebComponentsFadeInScript() { WebComponentsTracker = tracker });
//    }
//}
