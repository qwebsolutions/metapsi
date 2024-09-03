using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlDfn
{
}

public static partial class HtmlDfnControl
{
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static IHtmlNode HtmlDfn(this HtmlBuilder b, Action<AttributesBuilder<HtmlDfn>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dfn", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static IHtmlNode HtmlDfn(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dfn", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static IHtmlNode HtmlDfn(this HtmlBuilder b, Action<AttributesBuilder<HtmlDfn>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("dfn", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static IHtmlNode HtmlDfn(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("dfn", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Action<PropsBuilder<HtmlDfn>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dfn", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Action<PropsBuilder<HtmlDfn>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dfn", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dfn", children);
    }
    /// <summary>
    /// <para> The HTML dfn tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dfn", children);
    }
}

