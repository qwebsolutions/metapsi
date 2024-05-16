using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlCite
{
}

public static partial class HtmlCiteControl
{
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static IHtmlNode HtmlCite(this HtmlBuilder b, Action<AttributesBuilder<HtmlCite>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("cite", buildAttributes, children);
    }
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static IHtmlNode HtmlCite(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("cite", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static Var<IVNode> HtmlCite(this LayoutBuilder b, Action<PropsBuilder<HtmlCite>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("cite", buildProps, children);
    }
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static Var<IVNode> HtmlCite(this LayoutBuilder b, Action<PropsBuilder<HtmlCite>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("cite", buildProps, children);
    }
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static Var<IVNode> HtmlCite(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("cite", children);
    }
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static Var<IVNode> HtmlCite(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("cite", children);
    }
}

