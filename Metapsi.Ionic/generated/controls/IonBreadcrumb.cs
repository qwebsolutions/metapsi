using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonBreadcrumb
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
/// Setter extensions of IonBreadcrumb
/// </summary>
public static partial class IonBreadcrumbControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBreadcrumb(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonBreadcrumb>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-breadcrumb", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBreadcrumb(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-breadcrumb", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBreadcrumb(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonBreadcrumb>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-breadcrumb", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBreadcrumb(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-breadcrumb", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, bool active) 
    {
        if (active) b.SetAttribute("active", "");
    }

    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("active", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, string download) 
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, string href) 
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, string rel) 
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("routerDirection", "back");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("routerDirection", "forward");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("routerDirection", "root");
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, bool separator) 
    {
        if (separator) b.SetAttribute("separator", "");
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b) 
    {
        b.SetAttribute("separator", "");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this Metapsi.Html.AttributesBuilder<IonBreadcrumb> b, string target) 
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonBreadcrumb>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-breadcrumb", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-breadcrumb", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonBreadcrumb>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-breadcrumb", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-breadcrumb", children);
    }

    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetActive(b.Const(true));
    }

    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> active) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("active"), active);
    }

    /// <summary>
    /// If `true`, the breadcrumb will take on a different look to show that it is the currently active breadcrumb. Defaults to `true` for the last breadcrumb if it is not set on any.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool active) where T: IonBreadcrumb
    {
        b.SetActive(b.Const(active));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the breadcrumb.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonBreadcrumb
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, string download) where T: IonBreadcrumb
    {
        b.SetDownload(b.Const(download));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, string href) where T: IonBreadcrumb
    {
        b.SetHref(b.Const(href));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string rel) where T: IonBreadcrumb
    {
        b.SetRel(b.Const(rel));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBreadcrumb
    {
        b.SetSeparator(b.Const(true));
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> separator) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("separator"), separator);
    }

    /// <summary>
    /// If true, show a separator between this breadcrumb and the next. Defaults to `true` for all breadcrumbs except the last.
    /// </summary>
    public static void SetSeparator<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool separator) where T: IonBreadcrumb
    {
        b.SetSeparator(b.Const(separator));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("target"), target);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, string target) where T: IonBreadcrumb
    {
        b.SetTarget(b.Const(target));
    }

    /// <summary>
    /// Emitted when the breadcrumb loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the breadcrumb loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonBreadcrumb
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the breadcrumb loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the breadcrumb loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonBreadcrumb
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the breadcrumb has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the breadcrumb has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonBreadcrumb
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the breadcrumb has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonBreadcrumb
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the breadcrumb has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonBreadcrumb
    {
        b.OnIonFocus(b.MakeAction(action));
    }

}