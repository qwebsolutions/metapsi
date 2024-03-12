using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonGrid
{
}

public static partial class IonGridControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonGrid(this LayoutBuilder b, Action<PropsBuilder<IonGrid>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonGrid(this LayoutBuilder b, Action<PropsBuilder<IonGrid>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }
    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this PropsBuilder<IonGrid> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("fixed"), b.Const(true));
    }

}

