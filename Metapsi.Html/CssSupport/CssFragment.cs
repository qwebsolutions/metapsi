using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Metapsi.Html;

public class CssFragment : IDependency, IDependencyDefaultImport
{
    internal sealed class IdentityResolver : IResourceResolver
    {
        public static readonly IdentityResolver Instance = new();
        public string ResolvePath(IResource r) => $"{r.Package}/{r.FileName}";       // stable, distinct per resource, never served
        public bool TryResolveDependencyResource(string id, out IResource r) { r = null; return false; }
    }

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
        this.DependencyId = builder(new CssBuilder(IdentityResolver.Instance));
        this.Builder = (CssBuilder b) => builder(b);
    }

    public CssFragment(Action<CssBuilder> builder)
    {
        if (builder == null)
            throw new ArgumentNullException(nameof(builder));
        this.Builder = builder;

        CssBuilder cssBuilder = new CssBuilder(IdentityResolver.Instance);
        builder(cssBuilder);
        var outRule = cssBuilder.Rule.ToCss(new ToCssOptions());
        this.DependencyId = WebResourceBuilder.Hash(outRule);
    }

    public void Import(HtmlBuilder b)
    {
        var tracker = CssTrackerNode.Get(b);

        // Already provided by a file linked earlier (or by an explicit CssFileReference): nothing to do.
        if (tracker.ExternalFragmentIds.Contains(this.DependencyId))
            return;

        if (b.ResourceResolver.TryResolveDependencyResource(this.DependencyId, out var resource))
        {
            tracker.ExternalFragmentIds.AddRange(resource.ResolvesDependencyIds);
            var path = b.ResolvePath(resource);
            b.HeadAppend(b.HtmlLink(l => { l.SetRel("stylesheet"); l.SetHref(path); }));
            return;
        }

        tracker.RequiredFragments.Add(this);
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