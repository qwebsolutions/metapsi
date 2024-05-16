using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRoute : IonComponent
{
    public IonRoute() : base("ion-route") { }
}

public static partial class IonRouteControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRoute(this HtmlBuilder b, Action<AttributesBuilder<IonRoute>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-route", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRoute(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-route", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonRoute> b, string value)
    {
        b.SetAttribute("component", value);
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl(this AttributesBuilder<IonRoute> b, string value)
    {
        b.SetAttribute("url", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRoute(this LayoutBuilder b, Action<PropsBuilder<IonRoute>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-route", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRoute(this LayoutBuilder b, Action<PropsBuilder<IonRoute>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-route", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRoute(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-route", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRoute(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-route", children);
    }
    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter<T>(this PropsBuilder<T> b, Var<Func<object>> f) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeEnter"), f);
    }
    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>> f) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeEnter"), b.Def(f));
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave<T>(this PropsBuilder<T> b, Var<Func<object>> f) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeLeave"), f);
    }
    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>> f) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeLeave"), b.Def(f));
    }

    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string value) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered.
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), value);
    }
    /// <summary>
    /// A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered.
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), b.Const(value));
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("url"), value);
    }
    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl<T>(this PropsBuilder<T> b, string value) where T: IonRoute
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("url"), b.Const(value));
    }

    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, object>> action) where TComponent: IonRoute
    {
        b.OnEventAction("onionRouteDataChanged", action, "detail");
    }
    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action) where TComponent: IonRoute
    {
        b.OnEventAction("onionRouteDataChanged", b.MakeAction(action), "detail");
    }

}

