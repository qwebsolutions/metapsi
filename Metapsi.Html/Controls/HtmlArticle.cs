using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlArticle
{
}

public static partial class HtmlArticleControl
{
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static IHtmlNode HtmlArticle(this HtmlBuilder b, Action<AttributesBuilder<HtmlArticle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("article", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static IHtmlNode HtmlArticle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("article", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static IHtmlNode HtmlArticle(this HtmlBuilder b, Action<AttributesBuilder<HtmlArticle>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("article", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static IHtmlNode HtmlArticle(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("article", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArticle(this LayoutBuilder b, Action<PropsBuilder<HtmlArticle>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("article", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArticle(this LayoutBuilder b, Action<PropsBuilder<HtmlArticle>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("article", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArticle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("article", children);
    }
    /// <summary>
    /// <para> The HTML article tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArticle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("article", children);
    }
}

