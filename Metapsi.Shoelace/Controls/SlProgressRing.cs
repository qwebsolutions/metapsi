using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlProgressRing
{
    public int value { get; set; }
}
public static partial class SlProgressRingControl
{
    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Var<IVNode> SlProgressRing(this LayoutBuilder b, Action<PropsBuilder<SlProgressRing>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-progress-ring", buildProps, children);
    }
    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Var<IVNode> SlProgressRing(this LayoutBuilder b, Action<PropsBuilder<SlProgressRing>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-progress-ring", buildProps, children);
    }
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlProgressRing> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlProgressRing> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlProgressRing> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlProgressRing> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }
}

/// <summary>
/// Progress rings are used to show the progress of a determinate operation in a circular fashion.
/// </summary>
public partial class SlProgressRing : HtmlTag
{
    public SlProgressRing()
    {
        this.Tag = "sl-progress-ring";
    }

    public static SlProgressRing New()
    {
        return new SlProgressRing();
    }
}

public static partial class SlProgressRingControl
{
    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static SlProgressRing SetValue(this SlProgressRing tag, int value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static SlProgressRing SetLabel(this SlProgressRing tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
}

