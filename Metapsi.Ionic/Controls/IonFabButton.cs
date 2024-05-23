using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonFabButton : IonComponent
{
    public IonFabButton() : base("ion-fab-button") { }
}

public static partial class IonFabButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonFabButton(this HtmlBuilder b, Action<AttributesBuilder<IonFabButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-fab-button", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonFabButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-fab-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("activated", "");
    }
    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabButton> b, bool value)
    {
        if (value) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("close-icon", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonFabButton> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("download", value);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("href", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("rel", value);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("router-direction", value);
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "back");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "forward");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("show", "");
    }
    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow(this AttributesBuilder<IonFabButton> b, bool value)
    {
        if (value) b.SetAttribute("show", "");
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("size", value);
    }
    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("target", value);
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonFabButton> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonFabButton> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The type of the button.
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
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), value);
    }
    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, bool value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(value));
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeIcon"), value);
    }
    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon<T>(this PropsBuilder<T> b, string value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeIcon"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("show"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("show"), value);
    }
    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow<T>(this PropsBuilder<T> b, bool value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("show"), b.Const(value));
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), value);
    }
    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool value) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(value));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonFabButton
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

