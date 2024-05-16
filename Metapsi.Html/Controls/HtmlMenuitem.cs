using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMenuitem
{
}

public static partial class HtmlMenuitemControl
{
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static IHtmlNode HtmlMenuitem(this HtmlBuilder b, Action<AttributesBuilder<HtmlMenuitem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("menuitem", buildAttributes, children);
    }
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static IHtmlNode HtmlMenuitem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("menuitem", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static Var<IVNode> HtmlMenuitem(this LayoutBuilder b, Action<PropsBuilder<HtmlMenuitem>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("menuitem", buildProps, children);
    }
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static Var<IVNode> HtmlMenuitem(this LayoutBuilder b, Action<PropsBuilder<HtmlMenuitem>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("menuitem", buildProps, children);
    }
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static Var<IVNode> HtmlMenuitem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("menuitem", children);
    }
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static Var<IVNode> HtmlMenuitem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("menuitem", children);
    }
}

