using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRoute
{
}

public static partial class IonRouteControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRoute(this HtmlBuilder b, Action<AttributesBuilder<IonRoute>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-route", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRoute(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-route", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRoute(this HtmlBuilder b, Action<AttributesBuilder<IonRoute>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-route", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRoute(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-route", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select. </para>
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonRoute> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// <para> Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props. </para>
    /// </summary>
    public static void SetUrl(this AttributesBuilder<IonRoute> b, string url)
    {
        b.SetAttribute("url", url);
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
    /// <para> A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified. </para>
    /// </summary>
    public static void SetBeforeEnter<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject>> beforeEnter) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeEnter"), beforeEnter);
    }

    /// <summary>
    /// <para> A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified. </para>
    /// </summary>
    public static void SetBeforeEnter<T>(this PropsBuilder<T> b, System.Func<DynamicObject> beforeEnter) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeEnter"), b.Const(beforeEnter));
    }


    /// <summary>
    /// <para> A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified. </para>
    /// </summary>
    public static void SetBeforeLeave<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject>> beforeLeave) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeLeave"), beforeLeave);
    }

    /// <summary>
    /// <para> A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified. </para>
    /// </summary>
    public static void SetBeforeLeave<T>(this PropsBuilder<T> b, System.Func<DynamicObject> beforeLeave) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeLeave"), b.Const(beforeLeave));
    }


    /// <summary>
    /// <para> Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> component) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("component"), component);
    }

    /// <summary>
    /// <para> Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string component) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("component"), b.Const(component));
    }


    /// <summary>
    /// <para> A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered. </para>
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, Var<DynamicObject> componentProps) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// <para> A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered. </para>
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, DynamicObject componentProps) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("componentProps"), b.Const(componentProps));
    }


    /// <summary>
    /// <para> Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props. </para>
    /// </summary>
    public static void SetUrl<T>(this PropsBuilder<T> b, Var<string> url) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("url"), url);
    }

    /// <summary>
    /// <para> Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props. </para>
    /// </summary>
    public static void SetUrl<T>(this PropsBuilder<T> b, string url) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("url"), b.Const(url));
    }


    /// <summary>
    /// <para> Used internally by `ion-router` to know when this route did change. </para>
    /// </summary>
    public static void OnIonRouteDataChanged<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DynamicObject>> action) where TComponent: IonRoute
    {
        b.OnEventAction("onionRouteDataChanged", action, "detail");
    }
    /// <summary>
    /// <para> Used internally by `ion-router` to know when this route did change. </para>
    /// </summary>
    public static void OnIonRouteDataChanged<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DynamicObject>, Var<TModel>> action) where TComponent: IonRoute
    {
        b.OnEventAction("onionRouteDataChanged", b.MakeAction(action), "detail");
    }

}

