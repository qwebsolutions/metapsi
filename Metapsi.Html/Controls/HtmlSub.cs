using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSub
{
}

public static partial class HtmlSubControl
{
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static IHtmlNode HtmlSub(this HtmlBuilder b, Action<AttributesBuilder<HtmlSub>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sub", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static IHtmlNode HtmlSub(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sub", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static IHtmlNode HtmlSub(this HtmlBuilder b, Action<AttributesBuilder<HtmlSub>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("sub", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static IHtmlNode HtmlSub(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("sub", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, Action<PropsBuilder<HtmlSub>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sub", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, Action<PropsBuilder<HtmlSub>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sub", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sub", children);
    }
    /// <summary>
    /// <para> The HTML sub tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sub", children);
    }
}

