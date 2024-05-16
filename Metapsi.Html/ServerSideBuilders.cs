using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;

public abstract class DocumentTemplate
{
    public IHtmlNode Render() {  return null; }

    public abstract void SetHtmlAttributes(AttributesBuilder<HtmlHtml> b);
    public abstract IHtmlNode BuildBody(AttributesBuilder<HtmlBody> b, params IHtmlNode[] children);
}


public class AttributesBuilder<TTag>
{
    public Dictionary<string, string> Attributes { get; set; } = new();
}

public static class AttributesBuilderExtensions
{
    public static void SetAttribute<TTag>(this AttributesBuilder<TTag> b, string attributeName, string attributeValue)
    {
        b.Attributes[attributeName] = attributeValue;
    }

    /// <summary>
    /// Boolean attribute, has no value (is set if it exists)
    /// </summary>
    /// <typeparam name="TTag"></typeparam>
    /// <param name="b"></param>
    /// <param name="attributeName"></param>
    public static void SetAttribute<TTag>(this AttributesBuilder<TTag> b, string attributeName)
    {
        b.Attributes[attributeName] = "";
    }

    public static void SetClass<TTag>(this AttributesBuilder<TTag> b, string className)
    {
        b.SetAttribute("class", className);
    }

    public static void AddClass<TTag>(this AttributesBuilder<TTag> b, string className)
    {
        string previousClass = "";
        if (b.Attributes.ContainsKey("class"))
        {
            previousClass = b.Attributes["class"];
        }

        b.SetAttribute("class", previousClass + " " + className);
    }
}

public static class DocumentBuilderExtensions
{

    //public static IHtmlNode FromEmptyDocument(
    //    this HtmlBuilder b,
    //    Action<AttributesBuilder<HtmlHtml>> setHtmlAttributes = null,
    //    Action<AttributesBuilder<HtmlBody>> setBodyAttributes = null,
    //    Func<HtmlBuilder, List<IHtmlNode>> createHeadChildren = null,
    //    Func<HtmlBuilder, List<IHtmlNode>> createBodyChildren = null)
    //{
    //    if (setHtmlAttributes == null) setHtmlAttributes = b => { };
    //    if (setBodyAttributes == null) setBodyAttributes = b => { };
    //    if (createHeadChildren == null) createHeadChildren = b => new();
    //    if (createBodyChildren == null) createBodyChildren = b => new();

    //    return b.HtmlHtml(
    //            b =>
    //            {
    //                setHtmlAttributes(b);
    //            },
    //            b.HtmlHead(createHeadChildren(b).ToArray()),
    //            b.HtmlBody(
    //                b =>
    //                {
    //                    setBodyAttributes(b);
    //                },
    //                createBodyChildren(b).ToArray()));
    //}

    //public static IHtmlNode FromBasicDocument(
    //    this HtmlBuilder b,
    //    string title = null,
    //    Action<AttributesBuilder<HtmlHtml>> addHtmlAttributes = null,
    //    Action<AttributesBuilder<HtmlBody>> addBodyAttributes = null,
    //    Func<HtmlBuilder, List<IHtmlNode>> addHeadChildren = null,
    //    Func<HtmlBuilder, List<IHtmlNode>> addBodyChildren = null)
    //{
    //    Action<AttributesBuilder<HtmlHtml>> setHtmlAttributes= b =>
    //    {
    //        b.SetAttribute("lang", "en");
    //        b.SetAttribute("dir", "ltr");
    //        if(addHtmlAttributes!=null)
    //        {
    //            addHtmlAttributes(b);
    //        }
    //    };

    //    Action<AttributesBuilder<HtmlBody>> setBodyAttributes = b =>
    //    {
    //        if (addBodyAttributes != null)
    //        {
    //            addBodyAttributes(b);
    //        }
    //    };

    //    Func<HtmlBuilder, List<IHtmlNode>> createHeadChildren = b =>
    //    {
    //        List<IHtmlNode> headNodes = new List<IHtmlNode>();
    //        headNodes.Add(b.HtmlMeta(b =>
    //        {
    //            b.SetAttribute("name", "viewport");
    //            b.SetAttribute("content", "width=device-width,initial-scale=1");
    //        }));

    //        if (!string.IsNullOrEmpty(title))
    //        {
    //            headNodes.Add(b.HtmlTitle(b.Text(title)));
    //        }
    //        if(addHeadChildren!=null)
    //            headNodes.AddRange(addHeadChildren(b));
    //        return headNodes;
    //    };

    //    Func<HtmlBuilder, List<IHtmlNode>> createBodyChildren = b =>
    //    {
    //        List<IHtmlNode> bodyNodes = new List<IHtmlNode>();

    //        if (addBodyChildren != null)
    //        {
    //            bodyNodes.AddRange(addBodyChildren(b));
    //        }

    //        return bodyNodes;
    //    };

    //    return b.FromEmptyDocument(setHtmlAttributes, setBodyAttributes, createHeadChildren, createBodyChildren);
    //}
}
