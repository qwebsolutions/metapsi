using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlB
{
}

public static partial class HtmlBControl
{
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static IHtmlNode HtmlB(this HtmlBuilder b, Action<AttributesBuilder<HtmlB>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("b", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static IHtmlNode HtmlB(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("b", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static IHtmlNode HtmlB(this HtmlBuilder b, Action<AttributesBuilder<HtmlB>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("b", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static IHtmlNode HtmlB(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("b", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, Action<PropsBuilder<HtmlB>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("b", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, Action<PropsBuilder<HtmlB>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("b", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("b", children);
    }
    /// <summary>
    /// <para> The HTML b tag </para>
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("b", children);
    }
}

