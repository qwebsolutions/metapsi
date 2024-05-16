using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlForm
{
}

public static partial class HtmlFormControl
{
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static IHtmlNode HtmlForm(this HtmlBuilder b, Action<AttributesBuilder<HtmlForm>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("form", buildAttributes, children);
    }
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static IHtmlNode HtmlForm(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("form", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static Var<IVNode> HtmlForm(this LayoutBuilder b, Action<PropsBuilder<HtmlForm>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("form", buildProps, children);
    }
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static Var<IVNode> HtmlForm(this LayoutBuilder b, Action<PropsBuilder<HtmlForm>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("form", buildProps, children);
    }
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static Var<IVNode> HtmlForm(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("form", children);
    }
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static Var<IVNode> HtmlForm(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("form", children);
    }
}

