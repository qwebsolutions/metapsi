using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlProgressRing
{
}

public static partial class SlProgressRingControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressRing(this HtmlBuilder b, Action<AttributesBuilder<SlProgressRing>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-progress-ring", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressRing(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-progress-ring", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressRing(this HtmlBuilder b, Action<AttributesBuilder<SlProgressRing>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-progress-ring", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressRing(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-progress-ring", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The current progress as a percentage, 0 to 100. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlProgressRing> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> A custom label for assistive devices. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlProgressRing> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressRing(this LayoutBuilder b, Action<PropsBuilder<SlProgressRing>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-progress-ring", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressRing(this LayoutBuilder b, Action<PropsBuilder<SlProgressRing>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-progress-ring", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressRing(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-progress-ring", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressRing(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-progress-ring", children);
    }
    /// <summary>
    /// <para> The current progress as a percentage, 0 to 100. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: SlProgressRing
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The current progress as a percentage, 0 to 100. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: SlProgressRing
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> A custom label for assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlProgressRing
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> A custom label for assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlProgressRing
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


}

