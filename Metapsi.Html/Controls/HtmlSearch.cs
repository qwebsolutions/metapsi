using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSearch
{
}

public static partial class HtmlSearchControl
{
    /// <summary>
    /// The HTML search tag
    /// </summary>
    public static IHtmlNode HtmlSearch(this HtmlBuilder b, Action<AttributesBuilder<HtmlSearch>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("search", buildAttributes, children);
    }
    /// <summary>
    /// The HTML search tag
    /// </summary>
    public static IHtmlNode HtmlSearch(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("search", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML search tag
    /// </summary>
    public static Var<IVNode> HtmlSearch(this LayoutBuilder b, Action<PropsBuilder<HtmlSearch>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("search", buildProps, children);
    }
    /// <summary>
    /// The HTML search tag
    /// </summary>
    public static Var<IVNode> HtmlSearch(this LayoutBuilder b, Action<PropsBuilder<HtmlSearch>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("search", buildProps, children);
    }
    /// <summary>
    /// The HTML search tag
    /// </summary>
    public static Var<IVNode> HtmlSearch(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("search", children);
    }
    /// <summary>
    /// The HTML search tag
    /// </summary>
    public static Var<IVNode> HtmlSearch(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("search", children);
    }
}

