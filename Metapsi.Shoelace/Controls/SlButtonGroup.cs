using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlButtonGroup
{
}

public static partial class SlButtonGroupControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButtonGroup(this HtmlBuilder b, Action<AttributesBuilder<SlButtonGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-button-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButtonGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-button-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButtonGroup(this HtmlBuilder b, Action<AttributesBuilder<SlButtonGroup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-button-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButtonGroup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-button-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlButtonGroup> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Action<PropsBuilder<SlButtonGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-button-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Action<PropsBuilder<SlButtonGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-button-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-button-group", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-button-group", children);
    }
    /// <summary>
    /// <para> A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlButtonGroup
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// <para> A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlButtonGroup
    {
        b.SetProperty(b.Props, b.Const("label"), b.Const(label));
    }


}

