using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonSpinner
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
/// Setter extensions of IonSpinner
/// </summary>
public static partial class IonSpinnerControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSpinner(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSpinner>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-spinner", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSpinner(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-spinner", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSpinner(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSpinner>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-spinner", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSpinner(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-spinner", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonSpinner> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration(this Metapsi.Html.AttributesBuilder<IonSpinner> b, string duration) 
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameBubbles(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "bubbles");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircles(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "circles");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircular(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "circular");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCrescent(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "crescent");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameDots(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "dots");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLines(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "lines");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharp(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "lines-sharp");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharpSmall(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "lines-sharp-small");
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSmall(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("name", "lines-small");
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused(this Metapsi.Html.AttributesBuilder<IonSpinner> b, bool paused) 
    {
        if (paused) b.SetAttribute("paused", "");
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused(this Metapsi.Html.AttributesBuilder<IonSpinner> b) 
    {
        b.SetAttribute("paused", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSpinner(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSpinner>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-spinner", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSpinner(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-spinner", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSpinner(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSpinner>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-spinner", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSpinner(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-spinner", children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> duration) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("duration"), duration);
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameBubbles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("bubbles"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("circles"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircular<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("circular"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCrescent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("crescent"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameDots<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("dots"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLines<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("lines"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharpSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const("lines-small"));
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetPaused(b.Const(true));
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> paused) where T: IonSpinner
    {
        b.SetProperty(b.Props, b.Const("paused"), paused);
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool paused) where T: IonSpinner
    {
        b.SetPaused(b.Const(paused));
    }

}