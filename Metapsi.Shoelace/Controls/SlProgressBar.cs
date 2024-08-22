using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlProgressBar
{
}

public static partial class SlProgressBarControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressBar(this HtmlBuilder b, Action<AttributesBuilder<SlProgressBar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-progress-bar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressBar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-progress-bar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressBar(this HtmlBuilder b, Action<AttributesBuilder<SlProgressBar>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-progress-bar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlProgressBar(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-progress-bar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The current progress as a percentage, 0 to 100. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlProgressBar> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state. </para>
    /// </summary>
    public static void SetIndeterminate(this AttributesBuilder<SlProgressBar> b)
    {
        b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// <para> When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state. </para>
    /// </summary>
    public static void SetIndeterminate(this AttributesBuilder<SlProgressBar> b, bool indeterminate)
    {
        if (indeterminate) b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// <para> A custom label for assistive devices. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlProgressBar> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, Action<PropsBuilder<SlProgressBar>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-progress-bar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, Action<PropsBuilder<SlProgressBar>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-progress-bar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-progress-bar", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-progress-bar", children);
    }
    /// <summary>
    /// <para> The current progress as a percentage, 0 to 100. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The current progress as a percentage, 0 to 100. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), b.Const(true));
    }


    /// <summary>
    /// <para> When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b, Var<bool> indeterminate) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), indeterminate);
    }

    /// <summary>
    /// <para> When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b, bool indeterminate) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), b.Const(indeterminate));
    }


    /// <summary>
    /// <para> A custom label for assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> A custom label for assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


}

