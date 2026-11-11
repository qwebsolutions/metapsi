using System;
using System.Linq;

namespace Metapsi.Html;

public static class CssExtensions
{
    public static IHtmlNode CssFileReference(this HtmlBuilder b, CssFile cssFile)
    {
        var tracker = CssTrackerNode.Get(b);
        if (tracker != null)
        {
            tracker.ExternalFragmentIds.AddRange(cssFile.Fragments.Select(x => x.DependencyId));
        }

        var path = b.ResolvePath(cssFile);
        return b.HtmlLink(
            b =>
            {
                b.SetRel("stylesheet");
                b.SetHref(path);
            });
    }
}