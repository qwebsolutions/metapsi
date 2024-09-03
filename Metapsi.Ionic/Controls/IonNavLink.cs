using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonNavLink
{
}

public static partial class IonNavLinkControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNavLink(this HtmlBuilder b, Action<AttributesBuilder<IonNavLink>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav-link", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNavLink(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav-link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNavLink(this HtmlBuilder b, Action<AttributesBuilder<IonNavLink>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-nav-link", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNavLink(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-nav-link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonNavLink> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonNavLink> b, string routerDirection)
    {
        b.SetAttribute("router-direction", routerDirection);
    }

    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNavLink(this LayoutBuilder b, Action<PropsBuilder<IonNavLink>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNavLink(this LayoutBuilder b, Action<PropsBuilder<IonNavLink>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNavLink(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-nav-link", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNavLink(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-nav-link", children);
    }
    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), component);
    }

    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<HTMLElement> component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), component);
    }

    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, HTMLElement component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<ViewController> component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("component"), component);
    }

    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, ViewController component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), component);
    }

    /// <summary>
    /// <para> Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string component) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, Var<DynamicObject> componentProps) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), componentProps);
    }

    /// <summary>
    /// <para> Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`. </para>
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, DynamicObject componentProps) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), b.Const(componentProps));
    }


    /// <summary>
    /// <para> The transition animation when navigating to another page. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> routerAnimation) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> The transition animation when navigating to another page. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> routerAnimation) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("back"));
    }


    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("forward"));
    }


    /// <summary>
    /// <para> The transition direction when navigating to another page. </para>
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("root"));
    }


}

