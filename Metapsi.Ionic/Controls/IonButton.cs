using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonButton
{
    /// <summary> 
    /// Content is placed between the named slots if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Content is placed to the right of the button text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// Should be used on an icon in a button that has no text.
        /// </summary>
        public const string IconOnly = "icon-only";
        /// <summary> 
        /// Content is placed to the left of the button text in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, Action<PropsBuilder<IonButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, Action<PropsBuilder<IonButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-button", buildProps, children);
    }
    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("buttonType"), value);
    }
    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("buttonType"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandBlock(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("block"));
    }
    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandFull(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("full"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillClear(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("clear"));
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillDefault(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("default"));
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillOutline(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillSolid(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this PropsBuilder<IonButton> b, Var<HTMLFormElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLFormElement>("form"), value);
    }
    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this PropsBuilder<IonButton> b, HTMLFormElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLFormElement>("form"), b.Const(value));
    }
    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonButton> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonButton> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShapeRound(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeDefault(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("default"));
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("strong"), b.Const(true));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this PropsBuilder<IonButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionBlur"), action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionBlur"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionFocus"), action);
    }
    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionFocus"), b.MakeAction(action));
    }

}

