using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Metapsi.Html;

public class HtmlBuilder
{
    public HtmlDocument Document { get; private set; }

    private HtmlBuilder()
    {
        this.Document = new HtmlDocument();
    }

    public HtmlBuilder(HtmlBuilder b)
    {
        this.Document = b.Document;
    }

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
        //b.Document.Attributes["lang"] = "en-US";
        //b.Document.Attributes["dir"] = "ltr";
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
}

public static class HtmlBuilderExtensions
{
    public static HtmlDocument Document(this HtmlBuilder b)
    {
        return b.Document;
    }

    /// <summary>
    /// Adds child to head tag if it doesn't already exists
    /// </summary>
    /// <param name="b"></param>
    /// <param name="htmlNode"></param>
    public static void HeadAppend(this HtmlBuilder b, params IHtmlNode[] nodes)
    {
        foreach (var node in nodes)
        {
            var html = node.ToString();
            if (!b.Document.Head.Children.Select(x => x.ToHtml()).Contains(html))
            {
                b.Document.Head.Children.Add(node);
            }
        }
    }

    public static void BodyAppend(this HtmlBuilder b, params IHtmlNode[] nodes)
    {
        b.Document.Body.Children.AddRange(nodes);
    }

    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, Dictionary<string, string> attributes, params IHtmlNode[] children)
    {
        return new HtmlTag(tagName)
        {
            Attributes = new Dictionary<string, string>(attributes),
            Children = children.ToList()
        };
    }

    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, params IHtmlNode[] children)
    {
        return new HtmlTag(tagName)
        {
            Attributes = new Dictionary<string, string>(),
            Children = children.ToList()
        };
    }

    public static IHtmlNode Tag(this HtmlBuilder b, string tagName, Action<AttributesBuilder<object>> buildAttributes, params IHtmlNode[] children)
    {
        AttributesBuilder<object> builder = new();
        buildAttributes(builder);
        return b.Tag(tagName, builder.Attributes, children);
    }

    public static IHtmlNode Tag<TTag>(this HtmlBuilder b, string tagName, Action<AttributesBuilder<TTag>> buildAttributes, params IHtmlNode[] children)
    {
        AttributesBuilder<TTag> builder = new();
        buildAttributes(builder);
        return b.Tag(tagName, builder.Attributes, children);
    }

    public static IHtmlNode Text(this HtmlBuilder b, string text)
    {
        return new HtmlText(text);
    }

    public static void AddModuleStylesheet(this HtmlBuilder b)
    {
        var assembly = System.Reflection.Assembly.GetCallingAssembly();
        var cssName = $"{assembly.GetName().Name}.css";
        StaticFiles.Add(assembly, cssName);
        b.HeadAppend(b.HtmlLink(b =>
        {
            b.SetAttribute("rel", "stylesheet");
            b.SetAttribute("href", cssName);
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