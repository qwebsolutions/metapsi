using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlFieldset
{
}

public static partial class HtmlFieldsetControl
{
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static IHtmlNode HtmlFieldset(this HtmlBuilder b, Action<AttributesBuilder<HtmlFieldset>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("fieldset", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static IHtmlNode HtmlFieldset(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("fieldset", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static IHtmlNode HtmlFieldset(this HtmlBuilder b, Action<AttributesBuilder<HtmlFieldset>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("fieldset", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static IHtmlNode HtmlFieldset(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("fieldset", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFieldset(this LayoutBuilder b, Action<PropsBuilder<HtmlFieldset>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("fieldset", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFieldset(this LayoutBuilder b, Action<PropsBuilder<HtmlFieldset>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("fieldset", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFieldset(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("fieldset", children);
    }
    /// <summary>
    /// <para> The HTML fieldset tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFieldset(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("fieldset", children);
    }
}

