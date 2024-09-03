using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlDialog
{
}

public static partial class HtmlDialogControl
{
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static IHtmlNode HtmlDialog(this HtmlBuilder b, Action<AttributesBuilder<HtmlDialog>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dialog", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static IHtmlNode HtmlDialog(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dialog", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static IHtmlNode HtmlDialog(this HtmlBuilder b, Action<AttributesBuilder<HtmlDialog>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("dialog", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static IHtmlNode HtmlDialog(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("dialog", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Action<PropsBuilder<HtmlDialog>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dialog", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Action<PropsBuilder<HtmlDialog>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dialog", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dialog", children);
    }
    /// <summary>
    /// <para> The HTML dialog tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dialog", children);
    }
}

