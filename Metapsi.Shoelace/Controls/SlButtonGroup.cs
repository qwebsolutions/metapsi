using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlButtonGroup : SlComponent
{
    public SlButtonGroup() : base("sl-button-group") { }
}

public static partial class SlButtonGroupControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButtonGroup(this HtmlBuilder b, Action<AttributesBuilder<SlButtonGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-button-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButtonGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-button-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlButtonGroup> b,string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Action<PropsBuilder<SlButtonGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-button-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Action<PropsBuilder<SlButtonGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-button-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-button-group", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-button-group", children);
    }
    /// <summary>
    /// <para> A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlButtonGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlButtonGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


}

