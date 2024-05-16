using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDl
{
}

public static partial class HtmlDlControl
{
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static IHtmlNode HtmlDl(this HtmlBuilder b, Action<AttributesBuilder<HtmlDl>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dl", buildAttributes, children);
    }
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static IHtmlNode HtmlDl(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dl", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Action<PropsBuilder<HtmlDl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dl", buildProps, children);
    }
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Action<PropsBuilder<HtmlDl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dl", buildProps, children);
    }
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dl", children);
    }
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dl", children);
    }
}

