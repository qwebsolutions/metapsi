using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonButton : IonComponent
{
    public IonButton() : base("ion-button") { }
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
    public static IHtmlNode IonButton(this HtmlBuilder b, Action<AttributesBuilder<IonButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-button", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("button-type", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonButton> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("download", value);
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpand(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("expand", value);
    }
    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandBlock(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("expand", "block");
    }
    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandFull(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("expand", "full");
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("fill", value);
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillClear(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "clear");
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillDefault(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "default");
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "outline");
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("form", value);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("href", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("rel", value);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("router-direction", value);
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "back");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "forward");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("shape", value);
    }
    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("size", value);
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeDefault(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "default");
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "large");
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("strong", "");
    }
    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong(this AttributesBuilder<IonButton> b, bool value)
    {
        if (value) b.SetAttribute("strong", "");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("target", value);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonButton> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "submit");
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-button", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-button", children);
    }
    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("buttonType"), value);
    }
    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("buttonType"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandBlock<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("block"));
    }
    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandFull<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("full"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillClear<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("clear"));
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillDefault<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("default"));
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillSolid<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<HTMLFormElement> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLFormElement>("form"), value);
    }
    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, HTMLFormElement value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLFormElement>("form"), b.Const(value));
    }
    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeDefault<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("default"));
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("strong"), b.Const(true));
    }
    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("strong"), value);
    }
    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong<T>(this PropsBuilder<T> b, bool value) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("strong"), b.Const(value));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string value) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

