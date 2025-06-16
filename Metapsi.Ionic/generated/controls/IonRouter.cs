using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonRouter
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
        /// <summary>
        /// Go back to previous page in the window.history.
        /// </summary>
        public const string Back = "back";
        /// <summary>
        /// Navigate to the specified path.
        /// </summary>
        public const string Push = "push";
    }
}
/// <summary>
/// Setter extensions of IonRouter
/// </summary>
public static partial class IonRouterControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouter(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouter>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-router", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouter(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-router", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouter(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouter>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-router", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouter(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-router", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The root path to use when matching URLs. By default, this is set to "/", but you can specify an alternate prefix for all URL paths.
    /// </summary>
    public static void SetRoot(this Metapsi.Html.AttributesBuilder<IonRouter> b, string root) 
    {
        b.SetAttribute("root", root);
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash(this Metapsi.Html.AttributesBuilder<IonRouter> b, bool useHash) 
    {
        if (useHash) b.SetAttribute("useHash", "");
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash(this Metapsi.Html.AttributesBuilder<IonRouter> b) 
    {
        b.SetAttribute("useHash", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouter(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouter>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-router", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouter(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-router", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouter(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouter>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-router", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouter(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-router", children);
    }

    /// <summary>
    /// The root path to use when matching URLs. By default, this is set to "/", but you can specify an alternate prefix for all URL paths.
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> root) where T: IonRouter
    {
        b.SetProperty(b.Props, b.Const("root"), root);
    }

    /// <summary>
    /// The root path to use when matching URLs. By default, this is set to "/", but you can specify an alternate prefix for all URL paths.
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, string root) where T: IonRouter
    {
        b.SetRoot(b.Const(root));
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouter
    {
        b.SetUseHash(b.Const(true));
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> useHash) where T: IonRouter
    {
        b.SetProperty(b.Props, b.Const("useHash"), useHash);
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool useHash) where T: IonRouter
    {
        b.SetUseHash(b.Const(useHash));
    }

    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRouter
    {
        b.SetProperty(b.Props, "onionRouteDidChange", action);
    }

    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRouter
    {
        b.OnIonRouteDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRouter
    {
        b.SetProperty(b.Props, "onionRouteDidChange", action);
    }

    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRouter
    {
        b.OnIonRouteDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RouterEventDetail>>> action) where T: IonRouter
    {
        b.SetProperty(b.Props, "onionRouteDidChange", action);
    }

    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRouter
    {
        b.SetProperty(b.Props, "onionRouteWillChange", action);
    }

    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRouter
    {
        b.OnIonRouteWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRouter
    {
        b.SetProperty(b.Props, "onionRouteWillChange", action);
    }

    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRouter
    {
        b.OnIonRouteWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RouterEventDetail>>> action) where T: IonRouter
    {
        b.SetProperty(b.Props, "onionRouteWillChange", action);
    }

}