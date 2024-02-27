using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlProgressBar
{
    public int value { get; set; }
}
public static partial class SlProgressBarControl
{
    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, Action<PropsBuilder<SlProgressBar>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-progress-bar", buildProps, children);
    }
    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, Action<PropsBuilder<SlProgressBar>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-progress-bar", buildProps, children);
    }
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlProgressBar> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlProgressBar> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static void SetIndeterminate(this PropsBuilder<SlProgressBar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("indeterminate"), b.Const(true));
    }
    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlProgressBar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlProgressBar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }
}

/// <summary>
/// Progress bars are used to show the status of an ongoing operation.
/// </summary>
public partial class SlProgressBar : HtmlTag
{
    public SlProgressBar()
    {
        this.Tag = "sl-progress-bar";
    }

    public static SlProgressBar New()
    {
        return new SlProgressBar();
    }
}

public static partial class SlProgressBarControl
{
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static SlProgressBar SetValue(this SlProgressBar tag, int value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static SlProgressBar SetIndeterminate(this SlProgressBar tag)
    {
        return tag.SetAttribute("indeterminate", "true");
    }
    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static SlProgressBar SetLabel(this SlProgressBar tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
}

