using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRouterOutlet
{
}

public static partial class IonRouterOutletControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterOutlet(this HtmlBuilder b, Action<AttributesBuilder<IonRouterOutlet>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-router-outlet", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterOutlet(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-router-outlet", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterOutlet(this HtmlBuilder b, Action<AttributesBuilder<IonRouterOutlet>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-router-outlet", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterOutlet(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-router-outlet", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the router-outlet should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the router-outlet should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonRouterOutlet> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRouterOutlet> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRouterOutlet> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
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
    /// <para> If `true`, the router-outlet should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the router-outlet should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the router-outlet should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> This property allows to create custom transition using AnimationBuilder functions. </para>
    /// </summary>
    public static void SetAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> animation) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("animation"), animation);
    }

    /// <summary>
    /// <para> This property allows to create custom transition using AnimationBuilder functions. </para>
    /// </summary>
    public static void SetAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> animation) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("animation"), b.Const(animation));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }


}

