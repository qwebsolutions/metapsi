using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlSpinner
{
}

public static partial class SlSpinnerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSpinner(this HtmlBuilder b, Action<AttributesBuilder<SlSpinner>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-spinner", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSpinner(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-spinner", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSpinner(this HtmlBuilder b, Action<AttributesBuilder<SlSpinner>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-spinner", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSpinner(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-spinner", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSpinner(this LayoutBuilder b, Action<PropsBuilder<SlSpinner>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-spinner", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSpinner(this LayoutBuilder b, Action<PropsBuilder<SlSpinner>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-spinner", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSpinner(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-spinner", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSpinner(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-spinner", children);
    }
}

