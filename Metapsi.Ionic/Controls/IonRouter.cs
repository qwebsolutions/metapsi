using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRouter : IonComponent
{
    public IonRouter() : base("ion-router") { }
    public static class Method
    {
        /// <summary> 
        /// Go back to previous page in the window.history.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Back = "back";
        /// <summary> 
        /// Navigate to the specified path.
        /// <para>(path: string, direction?: RouterDirection, animation?: AnimationBuilder) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>path The path to navigate to.</para>
        /// <para>direction The direction of the animation. Defaults to `"forward"`.</para>
        /// <para>animation </para>
        /// </summary>
        public const string Push = "push";
    }
}

public static partial class IonRouterControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRouter(this HtmlBuilder b, Action<AttributesBuilder<IonRouter>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-router", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRouter(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-router", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The root path to use when matching URLs. By default, this is set to "/", but you can specify an alternate prefix for all URL paths.
    /// </summary>
    public static void SetRoot(this AttributesBuilder<IonRouter> b, string value)
    {
        b.SetAttribute("root", value);
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash(this AttributesBuilder<IonRouter> b)
    {
        b.SetAttribute("use-hash", "");
    }
    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash(this AttributesBuilder<IonRouter> b, bool value)
    {
        if (value) b.SetAttribute("use-hash", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouter(this LayoutBuilder b, Action<PropsBuilder<IonRouter>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-router", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouter(this LayoutBuilder b, Action<PropsBuilder<IonRouter>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-router", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouter(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-router", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRouter(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-router", children);
    }
    /// <summary>
    /// The root path to use when matching URLs. By default, this is set to "/", but you can specify an alternate prefix for all URL paths.
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRouter
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("root"), value);
    }
    /// <summary>
    /// The root path to use when matching URLs. By default, this is set to "/", but you can specify an alternate prefix for all URL paths.
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, string value) where T: IonRouter
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("root"), b.Const(value));
    }

    /// <summary>
    /// The router can work in two "modes": - With hash: `/index.html#/path/to/page` - Without hash: `/path/to/page`  Using one or another might depend in the requirements of your app and/or where it's deployed.  Usually "hash-less" navigation works better for SEO and it's more user friendly too, but it might requires additional server-side configuration in order to properly work.  On the other side hash-navigation is much easier to deploy, it even works over the file protocol.  By default, this property is `true`, change to `false` to allow hash-less URLs.
    /// </summary>
    public static void SetUseHash<T>(this PropsBuilder<T> b) where T: IonRouter
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("useHash"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RouterEventDetail>> action) where TComponent: IonRouter
    {
        b.OnEventAction("onionRouteDidChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the route had changed
    /// </summary>
    public static void OnIonRouteDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RouterEventDetail>, Var<TModel>> action) where TComponent: IonRouter
    {
        b.OnEventAction("onionRouteDidChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RouterEventDetail>> action) where TComponent: IonRouter
    {
        b.OnEventAction("onionRouteWillChange", action, "detail");
    }
    /// <summary>
    /// Event emitted when the route is about to change
    /// </summary>
    public static void OnIonRouteWillChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RouterEventDetail>, Var<TModel>> action) where TComponent: IonRouter
    {
        b.OnEventAction("onionRouteWillChange", b.MakeAction(action), "detail");
    }

}

