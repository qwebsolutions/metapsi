using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlDivider
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

/// <summary>
/// Dividers are used to visually separate or group elements.
/// </summary>
public partial class SlDivider : HtmlTag
{
    public SlDivider()
    {
        this.Tag = "sl-divider";
    }

    public static SlDivider New()
    {
        return new SlDivider();
    }
}

public static partial class SlDividerControl
{
    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static SlDivider SetVertical(this SlDivider tag)
    {
        return tag.SetAttribute("vertical", "true");
    }
}

