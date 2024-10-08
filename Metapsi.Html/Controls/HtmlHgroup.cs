using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlHgroup
{
}

public static partial class HtmlHgroupControl
{
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static IHtmlNode HtmlHgroup(this HtmlBuilder b, Action<AttributesBuilder<HtmlHgroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("hgroup", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static IHtmlNode HtmlHgroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("hgroup", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static IHtmlNode HtmlHgroup(this HtmlBuilder b, Action<AttributesBuilder<HtmlHgroup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("hgroup", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static IHtmlNode HtmlHgroup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("hgroup", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlHgroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("hgroup", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlHgroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("hgroup", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("hgroup", children);
    }
    /// <summary>
    /// <para> The HTML hgroup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("hgroup", children);
    }
}

