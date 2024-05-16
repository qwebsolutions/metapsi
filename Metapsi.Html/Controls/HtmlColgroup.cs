using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlColgroup
{
}

public static partial class HtmlColgroupControl
{
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static IHtmlNode HtmlColgroup(this HtmlBuilder b, Action<AttributesBuilder<HtmlColgroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("colgroup", buildAttributes, children);
    }
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static IHtmlNode HtmlColgroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("colgroup", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static Var<IVNode> HtmlColgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlColgroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("colgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static Var<IVNode> HtmlColgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlColgroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("colgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static Var<IVNode> HtmlColgroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("colgroup", children);
    }
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static Var<IVNode> HtmlColgroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("colgroup", children);
    }
}

