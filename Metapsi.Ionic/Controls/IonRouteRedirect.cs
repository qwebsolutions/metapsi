using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRouteRedirect : IonComponent
{
    public IonRouteRedirect() : base("ion-route-redirect") { }
}

public static partial class IonRouteRedirectControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRouteRedirect(this HtmlBuilder b, Action<AttributesBuilder<IonRouteRedirect>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-route-redirect", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRouteRedirect(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-route-redirect", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom(this AttributesBuilder<IonRouteRedirect> b, string value)
    {
        b.SetAttribute("from", value);
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo(this AttributesBuilder<IonRouteRedirect> b, string value)
    {
        b.SetAttribute("to", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouteRedirect(this LayoutBuilder b, Action<PropsBuilder<IonRouteRedirect>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-route-redirect", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouteRedirect(this LayoutBuilder b, Action<PropsBuilder<IonRouteRedirect>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-route-redirect", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouteRedirect(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-route-redirect", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouteRedirect(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-route-redirect", children);
    }
    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRouteRedirect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), value);
    }
    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom<T>(this PropsBuilder<T> b, string value) where T: IonRouteRedirect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), b.Const(value));
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRouteRedirect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("to"), value);
    }
    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo<T>(this PropsBuilder<T> b, string value) where T: IonRouteRedirect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("to"), b.Const(value));
    }

    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    public static void OnIonRouteRedirectChanged<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, object>> action) where TComponent: IonRouteRedirect
    {
        b.OnEventAction("onionRouteRedirectChanged", action, "detail");
    }
    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    public static void OnIonRouteRedirectChanged<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action) where TComponent: IonRouteRedirect
    {
        b.OnEventAction("onionRouteRedirectChanged", b.MakeAction(action), "detail");
    }

}

