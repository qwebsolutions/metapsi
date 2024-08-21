using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlObject
{
}

public static partial class HtmlObjectControl
{
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static IHtmlNode HtmlObject(this HtmlBuilder b, Action<AttributesBuilder<HtmlObject>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("object", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static IHtmlNode HtmlObject(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("object", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static IHtmlNode HtmlObject(this HtmlBuilder b, Action<AttributesBuilder<HtmlObject>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("object", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static IHtmlNode HtmlObject(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("object", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, Action<PropsBuilder<HtmlObject>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("object", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, Action<PropsBuilder<HtmlObject>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("object", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("object", children);
    }
    /// <summary>
    /// <para> The HTML object tag </para>
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("object", children);
    }
}

