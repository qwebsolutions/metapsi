using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonItemOption : IonComponent
{
    public IonItemOption() : base("ion-item-option") { }
    /// <summary> 
    /// Content is placed between the named slots if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Content is placed below the option text.
        /// </summary>
        public const string Bottom = "bottom";
        /// <summary> 
        /// Content is placed to the right of the option text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// Should be used on an icon in an option that has no text.
        /// </summary>
        public const string IconOnly = "icon-only";
        /// <summary> 
        /// Content is placed to the left of the option text in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
        /// <summary> 
        /// Content is placed above the option text.
        /// </summary>
        public const string Top = "top";
    }
}

public static partial class IonItemOptionControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonItemOption(this HtmlBuilder b, Action<AttributesBuilder<IonItemOption>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-item-option", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonItemOption(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-item-option", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItemOption> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("download", value);
    }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("expandable", "");
    }
    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable(this AttributesBuilder<IonItemOption> b, bool value)
    {
        if (value) b.SetAttribute("expandable", "");
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("href", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("rel", value);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("target", value);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonItemOption> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonItemOption> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemOption(this LayoutBuilder b, Action<PropsBuilder<IonItemOption>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-option", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemOption(this LayoutBuilder b, Action<PropsBuilder<IonItemOption>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-option", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemOption(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-option", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemOption(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-option", children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the item option.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("expandable"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("expandable"), value);
    }
    /// <summary>
    /// If `true`, the option will expand to take up the available width and cover any other options.
    /// </summary>
    public static void SetExpandable<T>(this PropsBuilder<T> b, bool value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("expandable"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string value) where T: IonItemOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonItemOption
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

}

