using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlDl
{
}

public static partial class HtmlDlControl
{
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static IHtmlNode HtmlDl(this HtmlBuilder b, Action<AttributesBuilder<HtmlDl>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dl", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static IHtmlNode HtmlDl(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dl", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static IHtmlNode HtmlDl(this HtmlBuilder b, Action<AttributesBuilder<HtmlDl>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("dl", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static IHtmlNode HtmlDl(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("dl", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Action<PropsBuilder<HtmlDl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dl", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Action<PropsBuilder<HtmlDl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dl", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dl", children);
    }
    /// <summary>
    /// <para> The HTML dl tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dl", children);
    }
}

