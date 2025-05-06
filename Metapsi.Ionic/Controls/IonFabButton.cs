using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonFabButton
{
}

public static partial class IonFabButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabButton(this HtmlBuilder b, Action<AttributesBuilder<IonFabButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabButton(this HtmlBuilder b, Action<AttributesBuilder<IonFabButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-fab-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-fab-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the fab button will be show a close icon. </para>
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// <para> If `true`, the fab button will be show a close icon. </para>
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabButton> b, bool activated)
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// <para> The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list. </para>
    /// </summary>
    public static void SetCloseIcon(this AttributesBuilder<IonFabButton> b, string closeIcon)
    {
        b.SetAttribute("close-icon", closeIcon);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonFabButton> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the fab button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the fab button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonFabButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonFabButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonFabButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonFabButton> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonFabButton> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonFabButton> b, string routerDirection)
    {
        b.SetAttribute("router-direction", routerDirection);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// <para> If `true`, the fab button will show when in a fab-list. </para>
    /// </summary>
    public static void SetShow(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("show", "");
    }

    /// <summary>
    /// <para> If `true`, the fab button will show when in a fab-list. </para>
    /// </summary>
    public static void SetShow(this AttributesBuilder<IonFabButton> b, bool show)
    {
        if (show) b.SetAttribute("show", "");
    }

    /// <summary>
    /// <para> The size of the button. Set this to `small` in order to have a mini fab button. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonFabButton> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The size of the button. Set this to `small` in order to have a mini fab button. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonFabButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonFabButton> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonFabButton> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonFabButton(this LayoutBuilder b, Action<PropsBuilder<IonFabButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonFabButton(this LayoutBuilder b, Action<PropsBuilder<IonFabButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonFabButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonFabButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab-button", children);
    }
    /// <summary>
    /// <para> If `true`, the fab button will be show a close icon. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("activated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the fab button will be show a close icon. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, Var<bool> activated) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("activated"), activated);
    }

    /// <summary>
    /// <para> If `true`, the fab button will be show a close icon. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, bool activated) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("activated"), b.Const(activated));
    }


    /// <summary>
    /// <para> The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list. </para>
    /// </summary>
    public static void SetCloseIcon<T>(this PropsBuilder<T> b, Var<string> closeIcon) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("closeIcon"), closeIcon);
    }

    /// <summary>
    /// <para> The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list. </para>
    /// </summary>
    public static void SetCloseIcon<T>(this PropsBuilder<T> b, string closeIcon) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("closeIcon"), b.Const(closeIcon));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the fab button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the fab button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the fab button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("download"), b.Const(download));
    }


    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("href"), b.Const(href));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> routerAnimation) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> routerAnimation) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("back"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("forward"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("root"));
    }


    /// <summary>
    /// <para> If `true`, the fab button will show when in a fab-list. </para>
    /// </summary>
    public static void SetShow<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("show"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the fab button will show when in a fab-list. </para>
    /// </summary>
    public static void SetShow<T>(this PropsBuilder<T> b, Var<bool> show) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("show"), show);
    }

    /// <summary>
    /// <para> If `true`, the fab button will show when in a fab-list. </para>
    /// </summary>
    public static void SetShow<T>(this PropsBuilder<T> b, bool show) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("show"), b.Const(show));
    }


    /// <summary>
    /// <para> The size of the button. Set this to `small` in order to have a mini fab button. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> target) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("target"), target);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string target) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const(target));
    }


    /// <summary>
    /// <para> If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("translucent"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> translucent) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("translucent"), translucent);
    }

    /// <summary>
    /// <para> If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool translucent) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("translucent"), b.Const(translucent));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("button"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reset"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("submit"));
    }


    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the button has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

