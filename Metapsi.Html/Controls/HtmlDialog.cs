using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDialog
{
}

public static partial class HtmlDialogControl
{
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static IHtmlNode HtmlDialog(this HtmlBuilder b, Action<AttributesBuilder<HtmlDialog>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dialog", buildAttributes, children);
    }
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static IHtmlNode HtmlDialog(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dialog", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Action<PropsBuilder<HtmlDialog>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dialog", buildProps, children);
    }
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Action<PropsBuilder<HtmlDialog>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dialog", buildProps, children);
    }
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dialog", children);
    }
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dialog", children);
    }
}

