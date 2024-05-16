using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlOptgroup
{
}

public static partial class HtmlOptgroupControl
{
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static IHtmlNode HtmlOptgroup(this HtmlBuilder b, Action<AttributesBuilder<HtmlOptgroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("optgroup", buildAttributes, children);
    }
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static IHtmlNode HtmlOptgroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("optgroup", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static Var<IVNode> HtmlOptgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlOptgroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("optgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static Var<IVNode> HtmlOptgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlOptgroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("optgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static Var<IVNode> HtmlOptgroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("optgroup", children);
    }
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static Var<IVNode> HtmlOptgroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("optgroup", children);
    }
}

