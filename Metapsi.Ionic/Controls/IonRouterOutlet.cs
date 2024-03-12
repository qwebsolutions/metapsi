using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonRouterOutlet
{
}

public static partial class IonRouterOutletControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouterOutlet(this LayoutBuilder b, Action<PropsBuilder<IonRouterOutlet>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-router-outlet", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouterOutlet(this LayoutBuilder b, Action<PropsBuilder<IonRouterOutlet>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-router-outlet", buildProps, children);
    }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonRouterOutlet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public static void SetAnimation(this PropsBuilder<IonRouterOutlet> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("animation"), f);
    }
    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public static void SetAnimation(this PropsBuilder<IonRouterOutlet> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("animation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonRouterOutlet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonRouterOutlet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

}

