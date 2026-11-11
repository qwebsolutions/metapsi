using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Metapsi.Html;

public class CssFragment : IDependency
{
    public string DependencyId { get; }
    public Action<CssBuilder> Builder { get; }

    public CssFragment(string fragmentId, Action<CssBuilder> builder)
    {
        if (string.IsNullOrEmpty(fragmentId))
            throw new ArgumentNullException(nameof(fragmentId));

        if (builder == null)
            throw new ArgumentNullException(nameof(builder));

        this.DependencyId = fragmentId;
        this.Builder = builder;
    }

    public CssFragment(Func<CssBuilder, string> builder)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));
        this.DependencyId = builder(new CssBuilder());
        this.Builder = (CssBuilder b) => builder(b);
    }

    public CssFragment(Action<CssBuilder> builder)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));
        this.Builder = builder;

        CssBuilder cssBuilder = new CssBuilder();
        builder(cssBuilder);
        var outRule = cssBuilder.Rule.ToCss(new ToCssOptions());
        this.DependencyId = WebResourceBuilder.Hash(outRule);
    }

    public void Import(HtmlBuilder b)
    {
        CssTrackerNode cssTracker = CssTrackerNode.Get(b);
        if (cssTracker.RequiredFragments.Any(x => x.DependencyId == this.DependencyId))
            return;
        cssTracker.RequiredFragments.Add(this);
    }
}

public static class CssFragmentExtensions
{
    public static string Require(this ICanRequireDependency b, System.Func<CssBuilder, string> build)
    {
        var fragment = new CssFragment(build);
        b.Require(fragment);
        return fragment.DependencyId;
    }

    public static void AddClass(this IHtmlPropsBuilder b, System.Func<CssBuilder, string> build)
    {
        b.AddClass(b.Require(build));
    }
}