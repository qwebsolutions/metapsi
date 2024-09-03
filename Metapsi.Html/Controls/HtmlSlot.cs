using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlSlot
{
}

public static partial class HtmlSlotControl
{
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static IHtmlNode HtmlSlot(this HtmlBuilder b, Action<AttributesBuilder<HtmlSlot>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("slot", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static IHtmlNode HtmlSlot(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("slot", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static IHtmlNode HtmlSlot(this HtmlBuilder b, Action<AttributesBuilder<HtmlSlot>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("slot", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static IHtmlNode HtmlSlot(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("slot", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Action<PropsBuilder<HtmlSlot>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("slot", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Action<PropsBuilder<HtmlSlot>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("slot", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("slot", children);
    }
    /// <summary>
    /// <para> The HTML slot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("slot", children);
    }
}

