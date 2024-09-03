using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metapsi.Html;

public static class WebComponentExtensions
{
    public static void AddWebComponentsTracker(this HtmlBuilder b)
    {
        if (b.Document.Head.Children.Any(x => x is WebComponentsTracker))
        {
            return;
        }

        b.Document.Head.Children.Add(new WebComponentsTracker());
    }

    public static WebComponentsTracker GetWebComponentsTracker(this HtmlBuilder b)
    {
        var wcfi = b.Document.Head.Children.SingleOrDefault(x => x is WebComponentsTracker);
        if (wcfi != null)
            return wcfi as WebComponentsTracker;
        return null;
    }

    public static void TrackWebComponent(this HtmlBuilder b, string webComponentTag)
    {
        var tracker = b.GetWebComponentsTracker();
        if(tracker != null)
        {
            tracker.WebComponentTags.Add(webComponentTag);
        }
    }
}

public class WebComponentsTracker : IHtmlNode
{
    public HashSet<string> WebComponentTags { get; set; } = new();

    public string ToHtml()
    {
        return string.Empty;
    }
}

public class WebComponentsFadeInScript : IHtmlNode
{
    public WebComponentsTracker WebComponentsTracker { get; set; }

    public string ToHtml()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("<style>\r\n  body {\r\n    opacity: 0;\r\n  }\r\n\r\n  body.ready {\r\n    opacity: 1;\r\n    transition: .25s opacity;\r\n  }\r\n</style>");
        var allWhenDefined = string.Join(",", WebComponentsTracker.WebComponentTags.Select(x => $"customElements.whenDefined('{x}')"));
        builder.AppendLine($"<script type=\"module\">\r\n  await Promise.allSettled([{allWhenDefined}]); document.body.classList.add('ready');\r\n</script>");

        return builder.ToString();
    }
}

public static class WebComponentsFadeInExtensions
{
    public static void UseWebComponentsFadeIn(this HtmlBuilder b)
    {
        b.AddWebComponentsTracker();
        var tracker = b.GetWebComponentsTracker();
        b.HeadAppend(new WebComponentsFadeInScript() { WebComponentsTracker = tracker });
    }
}
