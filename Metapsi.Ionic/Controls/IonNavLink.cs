using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonNavLink : IonComponent
{
    public IonNavLink() : base("ion-nav-link") { }
}

public static partial class IonNavLinkControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonNavLink(this HtmlBuilder b, Action<AttributesBuilder<IonNavLink>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-nav-link", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonNavLink(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-nav-link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonNavLink> b, string value)
    {
        b.SetAttribute("component", value);
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonNavLink> b, string value)
    {
        b.SetAttribute("router-direction", value);
    }
    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "back");
    }
    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonNavLink> b)
    {
        b.SetAttribute("router-direction", "forward");
    }
    /// <summary>
    /// The transition direction when navigating to another page.
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
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(value));
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<HTMLElement> value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, HTMLElement value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(value));
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<ViewController> value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, ViewController value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("component"), b.Const(value));
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), value);
    }
    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), b.Const(value));
    }

    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonNavLink
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

}

