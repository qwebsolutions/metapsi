using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonSkeletonText
{
}

public static partial class IonSkeletonTextControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Action<PropsBuilder<IonSkeletonText>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Action<PropsBuilder<IonSkeletonText>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }
    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonSkeletonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

}

