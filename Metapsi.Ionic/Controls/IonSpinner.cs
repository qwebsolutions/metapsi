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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSpinner> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> Duration of the spinner animation in milliseconds. The default varies based on the spinner. </para>
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonSpinner> b,string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonSpinner> b,string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameBubbles(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "bubbles");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameCircles(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "circles");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameCircular(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "circular");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameCrescent(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "crescent");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameDots(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "dots");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameLines(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameLinesSharp(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines-sharp");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameLinesSharpSmall(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines-sharp-small");
    }

    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameLinesSmall(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("name", "lines-small");
    }

    /// <summary>
    /// <para> If `true`, the spinner's animation will be paused. </para>
    /// </summary>
    public static void SetPaused(this AttributesBuilder<IonSpinner> b)
    {
        b.SetAttribute("paused", "");
    }

    /// <summary>
    /// <para> If `true`, the spinner's animation will be paused. </para>
    /// </summary>
    public static void SetPaused(this AttributesBuilder<IonSpinner> b,bool paused)
    {
        if (paused) b.SetAttribute("paused", "");
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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> Duration of the spinner animation in milliseconds. The default varies based on the spinner. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> duration) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), duration);
    }

    /// <summary>
    /// <para> Duration of the spinner animation in milliseconds. The default varies based on the spinner. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int duration) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(duration));
    }


    /// <summary>
    /// <para> The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used. </para>
    /// </summary>
    public static void SetNameBubbles<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const("bubbles"));
    }


    /// <summary>
    /// <para> If `true`, the spinner's animation will be paused. </para>
    /// </summary>
    public static void SetPaused<T>(this PropsBuilder<T> b) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("paused"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the spinner's animation will be paused. </para>
    /// </summary>
    public static void SetPaused<T>(this PropsBuilder<T> b, Var<bool> paused) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("paused"), paused);
    }

    /// <summary>
    /// <para> If `true`, the spinner's animation will be paused. </para>
    /// </summary>
    public static void SetPaused<T>(this PropsBuilder<T> b, bool paused) where T: IonSpinner
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("paused"), b.Const(paused));
    }


}

