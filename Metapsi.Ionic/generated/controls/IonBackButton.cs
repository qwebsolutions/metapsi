using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonBackButton
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
/// Setter extensions of IonBackButton
/// </summary>
public static partial class IonBackButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonBackButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-back-button", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-back-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonBackButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-back-button", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonBackButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-back-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonBackButton> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// The url to navigate back to by default when there is no history.
    /// </summary>
    public static void SetDefaultHref(this Metapsi.Html.AttributesBuilder<IonBackButton> b, string defaultHref) 
    {
        b.SetAttribute("defaultHref", defaultHref);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonBackButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button.
    /// </summary>
    public static void SetIcon(this Metapsi.Html.AttributesBuilder<IonBackButton> b, string icon) 
    {
        b.SetAttribute("icon", icon);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The text to display in the back button.
    /// </summary>
    public static void SetText(this Metapsi.Html.AttributesBuilder<IonBackButton> b, string text) 
    {
        b.SetAttribute("text", text);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<IonBackButton> b) 
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonBackButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-back-button", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-back-button", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonBackButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-back-button", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonBackButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-back-button", children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// The url to navigate back to by default when there is no history.
    /// </summary>
    public static void SetDefaultHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> defaultHref) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("defaultHref"), defaultHref);
    }

    /// <summary>
    /// The url to navigate back to by default when there is no history.
    /// </summary>
    public static void SetDefaultHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, string defaultHref) where T: IonBackButton
    {
        b.SetDefaultHref(b.Const(defaultHref));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonBackButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The built-in named SVG icon name or the exact `src` of an SVG file to use for the back button.
    /// </summary>
    public static void SetIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> icon) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("icon"), icon);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The text to display in the back button.
    /// </summary>
    public static void SetText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> text) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("text"), text);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("button"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonBackButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("submit"));
    }

}