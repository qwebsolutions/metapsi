using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlSkeleton
{
}

public static partial class SlSkeletonControl
{
    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Var<IVNode> SlSkeleton(this LayoutBuilder b, Action<PropsBuilder<SlSkeleton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-skeleton", buildProps, children);
    }
    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Var<IVNode> SlSkeleton(this LayoutBuilder b, Action<PropsBuilder<SlSkeleton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-skeleton", buildProps, children);
    }
    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectPulse(this PropsBuilder<SlSkeleton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("effect"), b.Const("pulse"));
    }
    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectSheen(this PropsBuilder<SlSkeleton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("effect"), b.Const("sheen"));
    }
    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectNone(this PropsBuilder<SlSkeleton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("effect"), b.Const("none"));
    }

}

