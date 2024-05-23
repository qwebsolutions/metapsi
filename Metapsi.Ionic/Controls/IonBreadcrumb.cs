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
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("active", "");
    }
    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive(this AttributesBuilder<IonBreadcrumb> b, bool value)
    {
        if (value) b.SetAttribute("active", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBreadcrumb> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("download", value);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("href", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("rel", value);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("router-direction", value);
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("router-direction", "back");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("router-direction", "forward");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator(this AttributesBuilder<IonBreadcrumb> b)
    {
        b.SetAttribute("separator", "");
    }
    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator(this AttributesBuilder<IonBreadcrumb> b, bool value)
    {
        if (value) b.SetAttribute("separator", "");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonBreadcrumb> b, string value)
    {
        b.SetAttribute("target", value);
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
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("active"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("active"), value);
    }
    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, bool value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("active"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator<T>(this PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("separator"), b.Const(true));
    }
    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("separator"), value);
    }
    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator<T>(this PropsBuilder<T> b, bool value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("separator"), b.Const(value));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string value) where T: IonBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the breadcrumb loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the breadcrumb loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the breadcrumb has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the breadcrumb has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonBreadcrumb
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

