using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlScript
{
}

public static partial class HtmlScriptControl
{
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static IHtmlNode HtmlScript(this HtmlBuilder b, Action<AttributesBuilder<HtmlScript>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("script", buildAttributes, children);
    }
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static IHtmlNode HtmlScript(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("script", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Action<PropsBuilder<HtmlScript>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("script", buildProps, children);
    }
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Action<PropsBuilder<HtmlScript>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("script", buildProps, children);
    }
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("script", children);
    }
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("script", children);
    }
}

