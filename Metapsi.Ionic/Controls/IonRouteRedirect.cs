using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonRouteRedirect
{
}

public static partial class IonRouteRedirectControl
{
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
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom(this PropsBuilder<IonRouteRedirect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), value);
    }
    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "from" URL. It needs to be an exact match of the navigated URL in order to apply.  The path specified in this value is always an absolute path, even if the initial `/` slash is not specified.
    /// </summary>
    public static void SetFrom(this PropsBuilder<IonRouteRedirect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), b.Const(value));
    }

    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo(this PropsBuilder<IonRouteRedirect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("to"), value);
    }
    /// <summary>
    /// A redirect route, redirects "from" a URL "to" another URL. This property is that "to" URL. When the defined `ion-route-redirect` rule matches, the router will redirect to the path specified in this property.  The value of this property is always an absolute path inside the scope of routes defined in `ion-router` it can't be used with another router or to perform a redirection to a different domain.  Note that this is a virtual redirect, it will not cause a real browser refresh, again, it's a redirect inside the context of ion-router.  When this property is not specified or his value is `undefined` the whole redirect route is noop, even if the "from" value matches.
    /// </summary>
    public static void SetTo(this PropsBuilder<IonRouteRedirect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("to"), b.Const(value));
    }

    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    public static void OnIonRouteRedirectChanged<TModel>(this PropsBuilder<IonRouteRedirect> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionRouteRedirectChanged"), eventAction);
    }
    /// <summary>
    /// Internal event that fires when any value of this rule is added/removed from the DOM, or any of his public properties changes.  `ion-router` captures this event in order to update his internal registry of router rules.
    /// </summary>
    public static void OnIonRouteRedirectChanged<TModel>(this PropsBuilder<IonRouteRedirect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionRouteRedirectChanged"), eventAction);
    }

}

