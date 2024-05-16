using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSlot
{
}

public static partial class HtmlSlotControl
{
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static IHtmlNode HtmlSlot(this HtmlBuilder b, Action<AttributesBuilder<HtmlSlot>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("slot", buildAttributes, children);
    }
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static IHtmlNode HtmlSlot(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("slot", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Action<PropsBuilder<HtmlSlot>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("slot", buildProps, children);
    }
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Action<PropsBuilder<HtmlSlot>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("slot", buildProps, children);
    }
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("slot", children);
    }
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("slot", children);
    }
}

