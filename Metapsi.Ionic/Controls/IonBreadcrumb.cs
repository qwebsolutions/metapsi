using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonBreadcrumb : IonComponent
{
    public IonBreadcrumb() : base("ion-breadcrumb") { }
}

public static partial class IonBreadcrumbControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBreadcrumb(this HtmlBuilder b, Action<AttributesBuilder<IonBreadcrumb>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-breadcrumb", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBreadcrumb(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-breadcrumb", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any. </para>
    /// </summary>
    public static void SetActive(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("active", "");
    }

    /// <summary>
    /// <para> If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any. </para>
    /// </summary>
    public static void SetActive(this AttributesBuilder<IonBreadcrumb> b,bool active)
    {
        if (active) b.SetAttribute("active", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBreadcrumb> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the breadcrumb. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the breadcrumb. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBreadcrumb> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonBreadcrumb> b,string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonBreadcrumb> b,string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBreadcrumb> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonBreadcrumb> b,string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonBreadcrumb> b,string routerDirection)
    {
        b.SetAttribute("router-direction", routerDirection);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// <para> If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last. </para>
    /// </summary>
    public static void SetSeparator(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("separator", "");
    }

    /// <summary>
    /// <para> If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last. </para>
    /// </summary>
    public static void SetSeparator(this AttributesBuilder<IonBreadcrumb> b,bool separator)
    {
        if (separator) b.SetAttribute("separator", "");
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonBreadcrumb> b,string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumb(this LayoutBuilder b, Action<PropsBuilder<IonBreadcrumb>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-breadcrumb", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumb(this LayoutBuilder b, Action<PropsBuilder<IonBreadcrumb>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-breadcrumb", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumb(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-breadcrumb", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumb(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-breadcrumb", children);
    }
    /// <summary>
    /// <para> If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, Var<bool> active) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), active);
    }

    /// <summary>
    /// <para> If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, bool active) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), b.Const(active));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the breadcrumb. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the breadcrumb. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the breadcrumb. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), download);
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(download));
    }


    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), href);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(href));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), rel);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> routerAnimation) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> routerAnimation) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("back"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("forward"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("root"));
    }


    /// <summary>
    /// <para> If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last. </para>
    /// </summary>
    public static void SetSeparator<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("separator"), b.Const(true));
    }


    /// <summary>
    /// <para> If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last. </para>
    /// </summary>
    public static void SetSeparator<T>(this PropsBuilder<T> b, Var<bool> separator) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("separator"), separator);
    }

    /// <summary>
    /// <para> If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last. </para>
    /// </summary>
    public static void SetSeparator<T>(this PropsBuilder<T> b, bool separator) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("separator"), b.Const(separator));
    }


    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> target) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), target);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string target) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(target));
    }


    /// <summary>
    /// <para> Emitted when the breadcrumb loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the breadcrumb loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the breadcrumb has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the breadcrumb has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

