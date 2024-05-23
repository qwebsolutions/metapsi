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
}

public static partial class IonRouterOutletControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRouterOutlet(this HtmlBuilder b, Action<AttributesBuilder<IonRouterOutlet>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-router-outlet", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRouterOutlet(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-router-outlet", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonRouterOutlet> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRouterOutlet> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("mode", "md");
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonRouterOutlet(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-router-outlet", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouterOutlet(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-router-outlet", children);
    }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), value);
    }
    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool value) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(value));
    }

    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public static void SetAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("animation"), f);
    }
    /// <summary>
    /// This property allows to create custom transition using AnimationBuilder functions.
    /// </summary>
    public static void SetAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("animation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

}

