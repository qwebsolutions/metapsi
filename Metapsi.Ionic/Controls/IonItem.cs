using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonItem : IonComponent
{
    public IonItem() : base("ion-item") { }
    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public bool button
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("button");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("button", value.ToString());
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
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Only applies when the `maxlength` property is set on the inner `ion-input` or `ion-textarea`.
    /// </summary>
    public bool counter
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("counter");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("counter", value.ToString());
        }
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".
    /// </summary>
    public System.Func<int,int,string> counterFormatter
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<int,int,string>>("counterFormatter");
        }
        set
        {
            this.GetTag().SetAttribute("counterFormatter", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public bool detail
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("detail");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("detail", value.ToString());
        }
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public string detailIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("detailIcon");
        }
        set
        {
            this.GetTag().SetAttribute("detailIcon", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
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
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public string fill
    {
        get
        {
            return this.GetTag().GetAttribute<string>("fill");
        }
        set
        {
            this.GetTag().SetAttribute("fill", value.ToString());
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
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public string lines
    {
        get
        {
            return this.GetTag().GetAttribute<string>("lines");
        }
        set
        {
            this.GetTag().SetAttribute("lines", value.ToString());
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
    /// The shape of the item. If "round" it will have increased border radius.
    /// </summary>
    public string shape
    {
        get
        {
            return this.GetTag().GetAttribute<string>("shape");
        }
        set
        {
            this.GetTag().SetAttribute("shape", value.ToString());
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
    /// The type of the button. Only used when an `onclick` or `button` property is present.
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

    /// <summary> 
    /// Content is placed between the named slots if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Content is placed to the right of the item text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// Content is placed under the item and displayed when an error is detected. **DEPRECATED** Use the "errorText" property on ion-input or ion-textarea instead.
        /// </summary>
        public const string Error = "error";
        /// <summary> 
        /// Content is placed under the item and displayed when no error is detected. **DEPRECATED** Use the "helperText" property on ion-input or ion-textarea instead.
        /// </summary>
        public const string Helper = "helper";
        /// <summary> 
        /// Content is placed to the left of the item text in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonItemControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItem(this LayoutBuilder b, Action<PropsBuilder<IonItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItem(this LayoutBuilder b, Action<PropsBuilder<IonItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item", buildProps, children);
    }
    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("button"), b.Const(true));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Only applies when the `maxlength` property is set on the inner `ion-input` or `ion-textarea`.
    /// </summary>
    public static void SetCounter(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("counter"), b.Const(true));
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".
    /// </summary>
    public static void SetCounterFormatter(this PropsBuilder<IonItem> b, Var<Func<int,int,string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".
    /// </summary>
    public static void SetCounterFormatter(this PropsBuilder<IonItem> b, Func<SyntaxBuilder,Var<int>,Var<int>,Var<string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), b.Def(f));
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("detail"), b.Const(true));
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon(this PropsBuilder<IonItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("detailIcon"), value);
    }
    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon(this PropsBuilder<IonItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("detailIcon"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesFull(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("full"));
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesInset(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("inset"));
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesNone(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonItem> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonItem> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// The shape of the item. If "round" it will have increased border radius.
    /// </summary>
    public static void SetShapeRound(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeButton(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeReset(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeSubmit(this PropsBuilder<IonItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

}

