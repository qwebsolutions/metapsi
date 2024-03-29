using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlButtonGroup
{
}

public static partial class SlButtonGroupControl
{
    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Action<PropsBuilder<SlButtonGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-button-group", buildProps, children);
    }
    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Var<IVNode> SlButtonGroup(this LayoutBuilder b, Action<PropsBuilder<SlButtonGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-button-group", buildProps, children);
    }
    /// <summary>
    /// A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlButtonGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlButtonGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

}

