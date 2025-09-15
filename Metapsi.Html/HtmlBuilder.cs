using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Metapsi.Html;

/// <summary>
/// Builder for an HTML document
/// </summary>
public class HtmlBuilder
{
    /// <summary>
    /// The HTML document
    /// </summary>
    public HtmlDocument Document { get; private set; }

    private HtmlBuilder()
    {
        this.Document = new HtmlDocument();
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
}

public static class HtmlBuilderExtensions
{
    //public static HtmlDocument Document(this HtmlBuilder b)
    //{
    //    return b.Document;
    //}

    /// <summary>
    /// Adds children to head tag if they don't already exist
    /// </summary>
    /// <param name="b"></param>
    /// <param name="nodes"></param>
    public static void HeadAppend(this HtmlBuilder b, params IHtmlNode[] nodes)
    {
        foreach (var node in nodes)
        {
            if (!b.Document.Head.Children.Contains(node, new HtmlNodeComparer()))
            {
                b.Document.Head.Children.Add(node as HtmlNode);
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
        b.Document.Body.Children.AddRange(nodes.Cast<HtmlNode>());
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
        var attributesDictionary = new Dictionary<string, HtmlAttribute>();
        foreach (var attribute in attributes)
        {
            attributesDictionary[attribute.Key] = new HtmlAttribute() { Value = attribute.Value };
        }
        return new HtmlNode()
        {
            Tags = new List<HtmlTag>() {
                new HtmlTag(tagName)
                {
                    Attributes = attributesDictionary,
                    Children = children.Cast<HtmlNode>().ToList()
                }
            }
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
        buildAttributes(builder);
        return b.Tag(tagName, builder.Attributes, children);
    }

    public static IHtmlNode Tag<TTag>(this HtmlBuilder b, string tagName, Action<AttributesBuilder<TTag>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag(tagName, buildAttributes, children.ToList());
    }

    public static IHtmlNode Text(this HtmlBuilder b, string text)
    {
        return new HtmlNode() { Text = new List<HtmlText>() { new HtmlText(text) } };
    }

    /// <summary>
    /// Adds the <paramref name="href"/> stylesheet do document head if it doesn't already exist
    /// </summary>
    /// <param name="b"></param>
    /// <param name="href"></param>
    public static void AddStylesheet(this HtmlBuilder b, string href)
    {
        if (!href.StartsWith("http"))
        {
            // If it is not absolute path, make it absolute
            href = $"/{href}".Replace("//", "/");
        }
        b.HeadAppend(
            b.HtmlLink(
                b =>
                {
                    b.SetHref(href);
                    b.SetRel("stylesheet");
                }));
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

    public static void AddModuleStylesheet(this HtmlBuilder b)
    {
        var assembly = System.Reflection.Assembly.GetCallingAssembly();
        var cssName = $"{assembly.GetName().Name}.css";
        b.AddStylesheet(assembly, cssName);
    }

    public static void AddStylesheet(this HtmlBuilder b, Assembly assembly, string cssFile)
    {
        //var embeddedFile = EmbeddedFiles.Add(assembly, cssFile);
        //if (embeddedFile != null)
        //{
        //    if (!string.IsNullOrWhiteSpace(embeddedFile.Hash))
        //    {
        //        cssFile = cssFile + "?h=" + embeddedFile.Hash;
        //    }
        //}
        b.HeadAppend(b.HtmlLink(b =>
        {
            b.SetAttribute("rel", "stylesheet");
            b.SetAttribute("href", "/" + cssFile);
        }));
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