using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;

public class CssTrackerNode : IHtmlNode
{
    private readonly IResourceResolver resourceResolver;

    public CssTrackerNode(IResourceResolver resourceResolver)
    {
        this.resourceResolver = resourceResolver;
    }

    public List<string> ExternalFragmentIds { get; set; } = new();
    public HashSet<CssFragment> RequiredFragments { get; set; } = new();

    public bool IsEquivalentTo(IHtmlNode other)
    {
        if (other == null)
            return false;
        return other is CssTrackerNode;
    }

    public string ToHtml(ToHtmlOptions options)
    {
        var inlineStylesheet = HtmlBuilder.Node(
            this.resourceResolver,
            b =>
        {
            return b.HtmlStyleSheet(b =>
            {
                foreach (var inPageFragment in RequiredFragments)
                {
                    if (!ExternalFragmentIds.Contains(inPageFragment.DependencyId))
                    {
                        if (inPageFragment.Builder != null)
                        {
                            inPageFragment.Builder(b);
                        }
                    }
                }
            });
        });

        return inlineStylesheet.ToHtml(options);
    }

    public static CssTrackerNode Get(HtmlBuilder b)
    {
        CssTrackerNode cssTracker = null;
        var existingNode = b.Document.Head.Children.SingleOrDefault(x => x is CssTrackerNode);
        if (existingNode == null)
        {
            cssTracker = new CssTrackerNode(b.ResourceResolver);
            b.HeadAppend(cssTracker);
        }
        else
        {
            cssTracker = existingNode as CssTrackerNode;
        }

        return cssTracker;
    }
}
