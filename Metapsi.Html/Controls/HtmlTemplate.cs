using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTemplate
{
}

public static partial class HtmlTemplateControl
{
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static IHtmlNode HtmlTemplate(this HtmlBuilder b, Action<AttributesBuilder<HtmlTemplate>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("template", buildAttributes, children);
    }
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static IHtmlNode HtmlTemplate(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("template", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static Var<IVNode> HtmlTemplate(this LayoutBuilder b, Action<PropsBuilder<HtmlTemplate>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("template", buildProps, children);
    }
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static Var<IVNode> HtmlTemplate(this LayoutBuilder b, Action<PropsBuilder<HtmlTemplate>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("template", buildProps, children);
    }
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static Var<IVNode> HtmlTemplate(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("template", children);
    }
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static Var<IVNode> HtmlTemplate(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("template", children);
    }
}

