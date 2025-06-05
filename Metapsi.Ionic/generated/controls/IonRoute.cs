using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonRoute
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonRoute
/// </summary>
public static partial class IonRouteControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRoute(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRoute>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-route", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRoute(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-route", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRoute(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRoute>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-route", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRoute(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-route", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent(this Metapsi.Html.AttributesBuilder<IonRoute> b, string component) 
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl(this Metapsi.Html.AttributesBuilder<IonRoute> b, string url) 
    {
        b.SetAttribute("url", url);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRoute(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRoute>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-route", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRoute(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-route", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRoute(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRoute>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-route", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRoute(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-route", children);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<bool>> beforeEnter) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeEnter"), beforeEnter);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<Metapsi.Ionic.NavigationHookOptions>> beforeEnter) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeEnter"), beforeEnter);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<Metapsi.Html.Promise<bool>>> beforeEnter) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeEnter"), beforeEnter);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<Metapsi.Html.Promise<Metapsi.Ionic.NavigationHookOptions>>> beforeEnter) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeEnter"), beforeEnter);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<bool>> beforeLeave) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeLeave"), beforeLeave);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<Metapsi.Ionic.NavigationHookOptions>> beforeLeave) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeLeave"), beforeLeave);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<Metapsi.Html.Promise<bool>>> beforeLeave) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeLeave"), beforeLeave);
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<Metapsi.Html.Promise<Metapsi.Ionic.NavigationHookOptions>>> beforeLeave) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("beforeLeave"), beforeLeave);
    }

    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("component"), component);
    }

    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, string component) where T: IonRoute
    {
        b.SetComponent(b.Const(component));
    }

    /// <summary>
    /// A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<object>> componentProps) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> url) where T: IonRoute
    {
        b.SetProperty(b.Props, b.Const("url"), url);
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b, string url) where T: IonRoute
    {
        b.SetUrl(b.Const(url));
    }

    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRoute
    {
        b.SetProperty(b.Props, "onionRouteDataChanged", action);
    }

    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRoute
    {
        b.OnIonRouteDataChanged(b.MakeAction(action));
    }

    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRoute
    {
        b.SetProperty(b.Props, "onionRouteDataChanged", action);
    }

    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRoute
    {
        b.OnIonRouteDataChanged(b.MakeAction(action));
    }

}