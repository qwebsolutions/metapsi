using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;


namespace Metapsi.Html;


public class HtmlAttributes : Dictionary<string, string>, IHtmlProps
{

}

public class JsScriptDependency : IDependency, IDependencyDefaultImport
{
    public string JsPath { get; set; }
    public bool IsModule { get; set; }

    public string DependencyId => JsPath;

    public void Import(HtmlBuilder b)
    {
        b.HeadAppend(
            b.HtmlScript(
                b =>
                {
                    b.SetSrc(JsPath);
                    if (IsModule)
                    {
                        b.SetTypeModule();
                    }
                }));
    }
}

public class StylesheetDependency : IDependency, IDependencyDefaultImport
{
    public string StylesheetPath { get; set; }

    public string DependencyId => StylesheetPath;

    public void Import(HtmlBuilder b)
    {
        b.HeadAppend(
            b.HtmlLink(
                b =>
                {
                    b.SetRel("stylesheet");
                    b.SetHref(StylesheetPath);
                }));
    }
}


public class ResolverOverride
{
    public string resolvedPath { get; private set; }

    public void ResolveTo(string redirectPath)
    {
        resolvedPath = redirectPath;
    }
}

/// <summary>
/// When resolving inside HTML, required tags are actually added to the document
/// </summary>
public class InPageResolver : IDependencyResolver
{
    private readonly HtmlBuilder htmlBuilder;

    public InPageResolver(HtmlBuilder b)
    {
        this.htmlBuilder = b;
    }

    public Action<ResolverOverride, IResource> OverridePath = (b, resource) =>
    {

    };

    HashSet<string> ResolvedDependencyIds = new HashSet<string>();
    Dictionary<string, string> ResolvedPaths = new Dictionary<string, string>();

    // Resolves a path. Could be for js or css or img src or anything
    public string ResolvePath(IResource resource)
    {
        var resourceId = resource.ResourceId;
        ResolvedPaths.TryGetValue(resourceId, out var path);
        if (!string.IsNullOrEmpty(path))
            return path;

        // Enable overrides here

        if (this.OverridePath != null)
        {
            var resolverOverride = new ResolverOverride();
            this.OverridePath(resolverOverride, resource);
            if (!string.IsNullOrEmpty(resolverOverride.resolvedPath))
            {
                ResolvedPaths[resourceId] = resolverOverride.resolvedPath;
                return resolverOverride.resolvedPath;
            }
        }

        var withDefaultResolver = resource as IResourceDefaultPath;
        if (withDefaultResolver != null)
        {
            path = withDefaultResolver.GetDefaultPath();
            ResolvedPaths[resourceId] = path;
            return path;
        }
        else
        {
            return string.Empty;
        }
    }

    // Ensures that some resource exists, for example CSS stylesheet, JavaScript module, CSS class
    public void Import(IDependency dependency)
    {
        var dependencyId = dependency.DependencyId;
        if (ResolvedDependencyIds.Contains(dependencyId))
            return;

        // Enabled overrides here

        var withDefaultResolver = dependency as IDependencyDefaultImport;
        if (withDefaultResolver != null)
        {
            withDefaultResolver.Import(this.htmlBuilder);
            ResolvedDependencyIds.Add(dependencyId);
        }
    }
}

public interface IDependencyDefaultImport : IDependency
{
    void Import(HtmlBuilder b);
}

/// <summary>
/// Builder for an HTML document
/// </summary>
public class HtmlBuilder : ICanResolveResourcePath, ICanRequireDependency
{
    /// <summary>
    /// The HTML document
    /// </summary>
    public HtmlDocument Document { get; private set; }

    private HtmlBuilder()
    {
        this.Document = new HtmlDocument();
        this.Resolver = new InPageResolver(this);
    }

    public InPageResolver Resolver { get; private set; }

    public string ResolvePath(IResource resource)
    {
        return Resolver.ResolvePath(resource);
    }

    /// <summary>
    /// Ensures that some resource exists, for example CSS stylesheet, JavaScript module, CSS class.
    /// This allows different resolutions per dependency, for example some stylesheet might be inlined while other imported
    /// </summary>
    /// <param name="dependency"></param>
    public void Require(IDependency dependency)
    {
        Resolver.Import(dependency);
    }

    /// <summary>
    /// Start from a completely empty document
    /// </summary>
    /// <param name="build"></param>
    /// <returns></returns>
    public static HtmlDocument FromEmpty(Action<HtmlBuilder> build)
    {
        var builder = new HtmlBuilder();
        build(builder);
        return builder.Document;
    }

    /// <summary>
    /// Sets:
    /// <para>&lt;html lang="en-US" dir="ltr"/&gt; </para>
    /// <para>&lt;meta name="charset" content="UTF-8" /&gt;</para>
    /// <para>&lt;meta name="viewport" content="width=device-width, initial-scale=1" /&gt;</para>
    /// </summary>
    /// <param name="build"></param>
    /// <returns></returns>
    public static HtmlDocument FromDefault(Action<HtmlBuilder> build)
    {
        var b = new HtmlBuilder();
        b.HeadAppend(
            b.HtmlMeta(
                b =>
                {
                    b.SetAttribute("name", "viewport");
                    b.SetAttribute("content", "width=device-width, initial-scale=1");
                }),
            b.HtmlMeta(
                b =>
                {
                    b.SetAttribute("charset", "UTF-8");
                }));
        build(b);
        return b.Document;
    }

    /// <summary>
    /// Adds the returned node to the body
    /// Sets:
    /// <para>&lt;html lang="en-US" dir="ltr"/&gt; </para>
    /// <para>&lt;meta name="charset" content="UTF-8" /&gt;</para>
    /// <para>&lt;meta name="viewport" content="width=device-width, initial-scale=1" /&gt;</para>
    /// </summary>
    /// <param name="build"></param>
    /// <returns></returns>
    public static HtmlDocument FromDefault(Func<HtmlBuilder, IHtmlNode> build)
    {
        return FromDefault(b =>
        {
            b.BodyAppend(build(b));
        });
    }

    /// <summary>
    /// Builds a fragment of a document, discarding the head and body
    /// </summary>
    /// <param name="build"></param>
    /// <returns></returns>
    public static IHtmlNode Node(Func<HtmlBuilder, IHtmlNode> build)
    {
        var builder = new HtmlBuilder();
        return build(builder);
    }

    public IHtmlNode Tag(string tagName, IHtmlProps attrs, params IHtmlNode[] children)
    {
        Dictionary<string, string> serverSideAttributes = attrs as Dictionary<string, string>;

        return HtmlBuilderExtensions.Tag(this, tagName, serverSideAttributes, children);
    }

    public IHtmlNode Text(string text)
    {
        return HtmlBuilderExtensions.Text(this, text);
    }

    public IHtmlPropsBuilder<TElement> GetPropsBuilder<TElement>()
    {
        return new AttributesBuilder<TElement>();
    }
}

public static class HtmlBuilderExtensions
{
    /// <summary>
    /// Adds children to head tag if they don't already exist
    /// </summary>
    /// <param name="b"></param>
    /// <param name="nodes"></param>
    public static void HeadAppend(this HtmlBuilder b, params IHtmlNode[] nodes)
    {
        foreach (var node in nodes)
        {
            if (!b.Document.Head.Children.Any(x => x.IsEquivalentTo(node)))
            {
                b.Document.Head.Children.Add(node);
            }
        }
    }

    /// <summary>
    /// Adds children to the body tag
    /// </summary>
    /// <param name="b"></param>
    /// <param name="nodes"></param>
    public static void BodyAppend(this HtmlBuilder b, params IHtmlNode[] nodes)
    {
        b.Document.Body.Children.AddRange(nodes);
    }

    /// <summary>
    /// Creates a tag
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="attributes"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, Dictionary<string, string> attributes, List<IHtmlNode> children)
    {
        return new HtmlTag()
        {
            Tag = tagName,
            Attributes = attributes,
            Children = children
        };
    }

    /// <summary>
    /// Creates a tag
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="attributes"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, Dictionary<string, string> attributes, params IHtmlNode[] children)
    {
        return b.Tag(tagName, attributes, children.ToList());
    }

    /// <summary>
    /// Creates a tag
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, params IHtmlNode[] children)
    {
        return b.Tag(tagName, children.ToList());
    }

    /// <summary>
    /// Creates a tag
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, List<IHtmlNode> children)
    {
        return b.Tag(tagName, new Dictionary<string, string>(), children);
    }

    public static IHtmlNode Tag<TTag>(this HtmlBuilder b, string tagName, Action<AttributesBuilder<TTag>> buildAttributes, List<IHtmlNode> children)
    {
        AttributesBuilder<TTag> builder = new();
        if (buildAttributes != null)
        {
            buildAttributes(builder);
        }
        return b.Tag(tagName, builder._attributes, children);
    }

    public static IHtmlNode Tag<TTag>(this HtmlBuilder b, string tagName, Action<AttributesBuilder<TTag>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag(tagName, buildAttributes, children.ToList());
    }

    public static IHtmlNode Text(this HtmlBuilder b, string text)
    {
        return new HtmlText() { Text = text };
    }

    /// <summary>
    /// Adds <paramref name="src"/> script to document head if it doesn't already exist
    /// </summary>
    /// <param name="b"></param>
    /// <param name="src"></param>
    /// <param name="type"></param>
    public static void AddScript(this HtmlBuilder b, string src, string type = null)
    {
        b.HeadAppend(
            b.HtmlScript(
                b =>
                {
                    b.SetSrc(src);
                    if (!string.IsNullOrEmpty(type))
                    {
                        b.SetType(type);
                    }
                }));
    }

    public static void AddScript(this HtmlBuilder b, Assembly assembly, string jsFile, string type = null)
    {
        b.AddScript(jsFile, type);
    }

    public static void AddScriptModule(this HtmlBuilder b, string src)
    {
        b.AddScript(src, "module");
    }


    public static IHtmlNode Optional(this HtmlBuilder b, bool variable, Func<HtmlBuilder, IHtmlNode> ifTrue)
    {
        if (variable)
        {
            return ifTrue(b);
        }
        else return b.Text("");
    }
}