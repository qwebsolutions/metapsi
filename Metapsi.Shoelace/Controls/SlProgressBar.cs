using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlProgressBar : SlComponent
{
    public SlProgressBar() : base("sl-progress-bar") { }
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public int value
    {
        get
        {
            return this.GetTag().GetAttribute<int>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public bool indeterminate
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("indeterminate");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("indeterminate", value.ToString());
        }
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

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
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-progress-bar", children);
    }
    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Var<IVNode> SlProgressBar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-progress-bar", children);
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

