using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRouterOutlet : IonComponent
{
    public IonRouterOutlet() : base("ion-router-outlet") { }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public bool animated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("animated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("animated", value.ToString());
        }
    }

    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public System.Func<object,object,Animation> animation
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object,object,Animation>>("animation");
        }
        set
        {
            this.GetTag().SetAttribute("animation", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

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

