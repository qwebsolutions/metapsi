using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDfn
{
}

public static partial class HtmlDfnControl
{
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static IHtmlNode HtmlDfn(this HtmlBuilder b, Action<AttributesBuilder<HtmlDfn>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dfn", buildAttributes, children);
    }
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static IHtmlNode HtmlDfn(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dfn", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Action<PropsBuilder<HtmlDfn>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dfn", buildProps, children);
    }
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Action<PropsBuilder<HtmlDfn>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dfn", buildProps, children);
    }
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dfn", children);
    }
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dfn", children);
    }
}

