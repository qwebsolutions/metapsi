using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlDivider
{
}

public static partial class SlDividerControl
{
    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, Action<PropsBuilder<SlDivider>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-divider", buildProps, children);
    }
    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, Action<PropsBuilder<SlDivider>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-divider", buildProps, children);
    }
    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical(this PropsBuilder<SlDivider> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("vertical"), b.Const(true));
    }

}

