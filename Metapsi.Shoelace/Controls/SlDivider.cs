using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlDivider : SlComponent
{
    public SlDivider() : base("sl-divider") { }
    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public bool vertical
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("vertical");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("vertical", value.ToString());
        }
    }

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
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-divider", children);
    }
    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-divider", children);
    }
    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical(this PropsBuilder<SlDivider> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("vertical"), b.Const(true));
    }

}

