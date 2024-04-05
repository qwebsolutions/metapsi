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
    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public bool activated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("activated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("activated", value.ToString());
        }
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public string closeIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("closeIcon");
        }
        set
        {
            this.GetTag().SetAttribute("closeIcon", value.ToString());
        }
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color
    {
        get
        {
            return this.GetTag().GetAttribute<string>("color");
        }
        set
        {
            this.GetTag().SetAttribute("color", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public string download
    {
        get
        {
            return this.GetTag().GetAttribute<string>("download");
        }
        set
        {
            this.GetTag().SetAttribute("download", value.ToString());
        }
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public string href
    {
        get
        {
            return this.GetTag().GetAttribute<string>("href");
        }
        set
        {
            this.GetTag().SetAttribute("href", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public string rel
    {
        get
        {
            return this.GetTag().GetAttribute<string>("rel");
        }
        set
        {
            this.GetTag().SetAttribute("rel", value.ToString());
        }
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public System.Func<object,object,Animation> routerAnimation
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object,object,Animation>>("routerAnimation");
        }
        set
        {
            this.GetTag().SetAttribute("routerAnimation", value.ToString());
        }
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public string routerDirection
    {
        get
        {
            return this.GetTag().GetAttribute<string>("routerDirection");
        }
        set
        {
            this.GetTag().SetAttribute("routerDirection", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public bool show
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("show");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("show", value.ToString());
        }
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public string size
    {
        get
        {
            return this.GetTag().GetAttribute<string>("size");
        }
        set
        {
            this.GetTag().SetAttribute("size", value.ToString());
        }
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public string target
    {
        get
        {
            return this.GetTag().GetAttribute<string>("target");
        }
        set
        {
            this.GetTag().SetAttribute("target", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("translucent");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("translucent", value.ToString());
        }
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public string type
    {
        get
        {
            return this.GetTag().GetAttribute<string>("type");
        }
        set
        {
            this.GetTag().SetAttribute("type", value.ToString());
        }
    }

}

public static partial class IonFabButtonControl
{
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
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(true));
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon(this PropsBuilder<IonFabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeIcon"), value);
    }
    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon(this PropsBuilder<IonFabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeIcon"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonFabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonFabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonFabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonFabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonFabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonFabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonFabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonFabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonFabButton> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonFabButton> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("show"), b.Const(true));
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonFabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonFabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this PropsBuilder<IonFabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonFabButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonFabButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonFabButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonFabButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

