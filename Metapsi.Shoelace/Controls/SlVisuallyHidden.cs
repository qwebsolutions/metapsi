using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlVisuallyHidden : SlComponent
{
    public SlVisuallyHidden() : base("sl-visually-hidden") { }
}

public static partial class SlVisuallyHiddenControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlVisuallyHidden(this HtmlBuilder b, Action<AttributesBuilder<SlVisuallyHidden>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-visually-hidden", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlVisuallyHidden(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-visually-hidden", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, Action<PropsBuilder<SlVisuallyHidden>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-visually-hidden", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, Action<PropsBuilder<SlVisuallyHidden>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-visually-hidden", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-visually-hidden", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-visually-hidden", children);
    }
}

