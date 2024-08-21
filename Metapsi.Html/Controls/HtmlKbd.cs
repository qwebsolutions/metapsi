using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlKbd
{
}

public static partial class HtmlKbdControl
{
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static IHtmlNode HtmlKbd(this HtmlBuilder b, Action<AttributesBuilder<HtmlKbd>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("kbd", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static IHtmlNode HtmlKbd(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("kbd", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static IHtmlNode HtmlKbd(this HtmlBuilder b, Action<AttributesBuilder<HtmlKbd>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("kbd", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static IHtmlNode HtmlKbd(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("kbd", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static Var<IVNode> HtmlKbd(this LayoutBuilder b, Action<PropsBuilder<HtmlKbd>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("kbd", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static Var<IVNode> HtmlKbd(this LayoutBuilder b, Action<PropsBuilder<HtmlKbd>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("kbd", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static Var<IVNode> HtmlKbd(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("kbd", children);
    }
    /// <summary>
    /// <para> The HTML kbd tag </para>
    /// </summary>
    public static Var<IVNode> HtmlKbd(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("kbd", children);
    }
}

