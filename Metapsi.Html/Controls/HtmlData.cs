using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlData
{
}

public static partial class HtmlDataControl
{
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static IHtmlNode HtmlData(this HtmlBuilder b, Action<AttributesBuilder<HtmlData>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("data", buildAttributes, children);
    }
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static IHtmlNode HtmlData(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("data", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Action<PropsBuilder<HtmlData>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("data", buildProps, children);
    }
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Action<PropsBuilder<HtmlData>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("data", buildProps, children);
    }
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("data", children);
    }
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("data", children);
    }
}

