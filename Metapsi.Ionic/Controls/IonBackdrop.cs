using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonBackdrop
{
}

public static partial class IonBackdropControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackdrop(this LayoutBuilder b, Action<PropsBuilder<IonBackdrop>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-backdrop", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackdrop(this LayoutBuilder b, Action<PropsBuilder<IonBackdrop>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-backdrop", buildProps, children);
    }
    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation(this PropsBuilder<IonBackdrop> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("stopPropagation"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable(this PropsBuilder<IonBackdrop> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("tappable"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible(this PropsBuilder<IonBackdrop> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("visible"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    public static void OnIonBackdropTap<TModel>(this PropsBuilder<IonBackdrop> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionBackdropTap"), action);
    }
    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    public static void OnIonBackdropTap<TModel>(this PropsBuilder<IonBackdrop> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionBackdropTap"), b.MakeAction(action));
    }

}

