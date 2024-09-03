using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlScript
{
}

public static partial class HtmlScriptControl
{
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static IHtmlNode HtmlScript(this HtmlBuilder b, Action<AttributesBuilder<HtmlScript>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("script", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static IHtmlNode HtmlScript(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("script", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static IHtmlNode HtmlScript(this HtmlBuilder b, Action<AttributesBuilder<HtmlScript>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("script", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static IHtmlNode HtmlScript(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("script", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static void SetSrc(this AttributesBuilder<HtmlScript> b, string src)
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetType(this AttributesBuilder<HtmlScript> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Action<PropsBuilder<HtmlScript>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("script", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Action<PropsBuilder<HtmlScript>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("script", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("script", children);
    }
    /// <summary>
    /// <para> The HTML script tag </para>
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("script", children);
    }
}

