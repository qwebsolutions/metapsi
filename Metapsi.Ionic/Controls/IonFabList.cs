using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonFabList
{
}

public static partial class IonFabListControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFabList(this LayoutBuilder b, Action<PropsBuilder<IonFabList>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab-list", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFabList(this LayoutBuilder b, Action<PropsBuilder<IonFabList>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab-list", buildProps, children);
    }
    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated(this PropsBuilder<IonFabList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(true));
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideBottom(this PropsBuilder<IonFabList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("bottom"));
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideEnd(this PropsBuilder<IonFabList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideStart(this PropsBuilder<IonFabList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideTop(this PropsBuilder<IonFabList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("top"));
    }

}

