using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSpinner : IonComponent
{
    public IonSpinner() : base("ion-spinner") { }
}

public static partial class IonSpinnerControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSpinner(this HtmlBuilder b, Action<AttributesBuilder<IonSpinner>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-spinner", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSpinner(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-spinner", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSpinner> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonSpinner> b, string value)
    {
        b.SetAttribute("duration", value);
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonSpinner> b, string value)
    {
        b.SetAttribute("name", value);
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameBubbles(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "bubbles");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircles(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "circles");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircular(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "circular");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCrescent(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "crescent");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameDots(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "dots");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLines(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharp(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines-sharp");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharpSmall(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines-sharp-small");
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSmall(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines-small");
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("paused", "");
    }
    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused(this AttributesBuilder<IonSpinner> b, bool value)
    {
        if (value) b.SetAttribute("paused", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSpinner(this LayoutBuilder b, Action<PropsBuilder<IonSpinner>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-spinner", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSpinner(this LayoutBuilder b, Action<PropsBuilder<IonSpinner>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-spinner", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSpinner(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-spinner", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSpinner(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-spinner", children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int value) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameBubbles<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("bubbles"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircles<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("circles"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircular<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("circular"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCrescent<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("crescent"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameDots<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("dots"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLines<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharp<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSmall<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines-small"));
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("paused"), b.Const(true));
    }

}

