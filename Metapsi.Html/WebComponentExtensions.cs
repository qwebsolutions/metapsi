using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metapsi.Html;

public class WebComponentTrackerNode : IHtmlNode
{
    public HashSet<string> Tags { get; set; } = new HashSet<string>();

    public bool IsEquivalentTo(IHtmlNode other)
    {
        if (other == null) return false;
        WebComponentTracker webComponentTracker = other as WebComponentTracker;
        if (webComponentTracker == null) return false;

        // It should be just one tracker per document
        return true;
    }

    public string ToHtml(ToHtmlOptions options)
    {
        return string.Empty;
    }
}

public class WebComponentTracker: IDependency, IDependencyDefaultImport
{
    public WebComponentTracker(string tag)
    {
        this.Tag = tag;
        this.DependencyId = $"web-component-tracker-{tag}";
    }

    public string DependencyId { get; set; }
    public string Tag { get; set; }

    public void Import(HtmlBuilder b)
    {
        var trackerNode = GetWebComponentTrackerNode(b);
        trackerNode.Tags.Add(this.Tag);
    }

    public static WebComponentTrackerNode GetWebComponentTrackerNode(HtmlBuilder b)
    {
        var trackerNode = b.Document.Head.Children.SingleOrDefault(x => x is WebComponentTrackerNode);
        if (trackerNode == null)
        {
            trackerNode = new WebComponentTrackerNode();
            b.HeadAppend(trackerNode);
        }

        return trackerNode as WebComponentTrackerNode;
    }
}

public static class WebComponentExtensions
{
    public static void TrackWebComponent(
        this ICanRequireDependency b, string webComponentTag)
    {
        b.Require(new WebComponentTracker(webComponentTag));
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
        var tracker = WebComponentTracker.GetWebComponentTrackerNode(b);
        var webComponentTags = tracker.Tags;
        if (!webComponentTags.Any())
            return new HtmlText();

        b.HeadAppend(
            b.HtmlStyle(
                b.Text("body {\r\n    opacity: 0;\r\n  }\r\n\r\n  body.ready {\r\n    opacity: 1;\r\n    transition: .25s opacity;\r\n  }\r\n")));

        return b.HtmlScriptModule(
            b =>
            {
                b.PromiseThen(
                    b.WhenDefined(webComponentTags.ToArray()),
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