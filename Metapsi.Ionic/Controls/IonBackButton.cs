using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonBackButton : IonComponent
{
    public IonBackButton() : base("ion-back-button") { }
}

public static partial class IonBackButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonBackButton(this HtmlBuilder b, Action<AttributesBuilder<IonBackButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-back-button", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonBackButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-back-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBackButton> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// The url to navigate back to by default when there is no history.
    /// </summary>
    public static void SetDefaultHref(this AttributesBuilder<IonBackButton> b, string value)
    {
        b.SetAttribute("default-href", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBackButton> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button.
    /// </summary>
    public static void SetIcon(this AttributesBuilder<IonBackButton> b, string value)
    {
        b.SetAttribute("icon", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBackButton> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The text to display in the back button.
    /// </summary>
    public static void SetText(this AttributesBuilder<IonBackButton> b, string value)
    {
        b.SetAttribute("text", value);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonBackButton> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackButton(this LayoutBuilder b, Action<PropsBuilder<IonBackButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-back-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackButton(this LayoutBuilder b, Action<PropsBuilder<IonBackButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-back-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-back-button", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-back-button", children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The url to navigate back to by default when there is no history.
    /// </summary>
    public static void SetDefaultHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultHref"), value);
    }
    /// <summary>
    /// The url to navigate back to by default when there is no history.
    /// </summary>
    public static void SetDefaultHref<T>(this PropsBuilder<T> b, string value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultHref"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button.
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), value);
    }
    /// <summary>
    /// The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button.
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, string value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// The text to display in the back button.
    /// </summary>
    public static void SetText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("text"), value);
    }
    /// <summary>
    /// The text to display in the back button.
    /// </summary>
    public static void SetText<T>(this PropsBuilder<T> b, string value) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("text"), b.Const(value));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

}

