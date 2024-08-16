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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBackButton> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The url to navigate back to by default when there is no history. </para>
    /// </summary>
    public static void SetDefaultHref(this AttributesBuilder<IonBackButton> b,string defaultHref)
    {
        b.SetAttribute("default-href", defaultHref);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonBackButton> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button. </para>
    /// </summary>
    public static void SetIcon(this AttributesBuilder<IonBackButton> b,string icon)
    {
        b.SetAttribute("icon", icon);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBackButton> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The text to display in the back button. </para>
    /// </summary>
    public static void SetText(this AttributesBuilder<IonBackButton> b,string text)
    {
        b.SetAttribute("text", text);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonBackButton> b,string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonBackButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The type of the button. </para>
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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The url to navigate back to by default when there is no history. </para>
    /// </summary>
    public static void SetDefaultHref<T>(this PropsBuilder<T> b, Var<string> defaultHref) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultHref"), defaultHref);
    }

    /// <summary>
    /// <para> The url to navigate back to by default when there is no history. </para>
    /// </summary>
    public static void SetDefaultHref<T>(this PropsBuilder<T> b, string defaultHref) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultHref"), b.Const(defaultHref));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button. </para>
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, Var<string> icon) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), icon);
    }

    /// <summary>
    /// <para> The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button. </para>
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, string icon) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), b.Const(icon));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> routerAnimation) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> routerAnimation) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> The text to display in the back button. </para>
    /// </summary>
    public static void SetText<T>(this PropsBuilder<T> b, Var<string> text) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("text"), text);
    }

    /// <summary>
    /// <para> The text to display in the back button. </para>
    /// </summary>
    public static void SetText<T>(this PropsBuilder<T> b, string text) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("text"), b.Const(text));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("button"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("reset"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("submit"));
    }


}

