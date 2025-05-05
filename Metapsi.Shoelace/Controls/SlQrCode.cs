using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlQrCode
{
}

public static partial class SlQrCodeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlQrCode(this HtmlBuilder b, Action<AttributesBuilder<SlQrCode>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-qr-code", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlQrCode(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-qr-code", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlQrCode(this HtmlBuilder b, Action<AttributesBuilder<SlQrCode>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-qr-code", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlQrCode(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-qr-code", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The QR code's value. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlQrCode> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The label for assistive devices to announce. If unspecified, the value will be used instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlQrCode> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The size of the QR code, in pixels. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlQrCode> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The fill color. This can be any valid CSS color, but not a CSS custom property. </para>
    /// </summary>
    public static void SetFill(this AttributesBuilder<SlQrCode> b, string fill)
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// <para> The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property. </para>
    /// </summary>
    public static void SetBackground(this AttributesBuilder<SlQrCode> b, string background)
    {
        b.SetAttribute("background", background);
    }

    /// <summary>
    /// <para> The edge radius of each module. Must be between 0 and 0.5. </para>
    /// </summary>
    public static void SetRadius(this AttributesBuilder<SlQrCode> b, string radius)
    {
        b.SetAttribute("radius", radius);
    }

    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrection(this AttributesBuilder<SlQrCode> b, string errorCorrection)
    {
        b.SetAttribute("error-correction", errorCorrection);
    }

    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionL(this AttributesBuilder<SlQrCode> b)
    {
        b.SetAttribute("error-correction", "L");
    }

    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionM(this AttributesBuilder<SlQrCode> b)
    {
        b.SetAttribute("error-correction", "M");
    }

    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionQ(this AttributesBuilder<SlQrCode> b)
    {
        b.SetAttribute("error-correction", "Q");
    }

    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionH(this AttributesBuilder<SlQrCode> b)
    {
        b.SetAttribute("error-correction", "H");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, Action<PropsBuilder<SlQrCode>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-qr-code", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, Action<PropsBuilder<SlQrCode>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-qr-code", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-qr-code", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-qr-code", children);
    }
    /// <summary>
    /// <para> The QR code's value. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The QR code's value. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The label for assistive devices to announce. If unspecified, the value will be used instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// <para> The label for assistive devices to announce. If unspecified, the value will be used instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The size of the QR code, in pixels. </para>
    /// </summary>
    public static void SetSize<T>(this PropsBuilder<T> b, Var<int> size) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("size"), size);
    }

    /// <summary>
    /// <para> The size of the QR code, in pixels. </para>
    /// </summary>
    public static void SetSize<T>(this PropsBuilder<T> b, int size) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(size));
    }


    /// <summary>
    /// <para> The fill color. This can be any valid CSS color, but not a CSS custom property. </para>
    /// </summary>
    public static void SetFill<T>(this PropsBuilder<T> b, Var<string> fill) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("fill"), fill);
    }

    /// <summary>
    /// <para> The fill color. This can be any valid CSS color, but not a CSS custom property. </para>
    /// </summary>
    public static void SetFill<T>(this PropsBuilder<T> b, string fill) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const(fill));
    }


    /// <summary>
    /// <para> The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property. </para>
    /// </summary>
    public static void SetBackground<T>(this PropsBuilder<T> b, Var<string> background) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("background"), background);
    }

    /// <summary>
    /// <para> The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property. </para>
    /// </summary>
    public static void SetBackground<T>(this PropsBuilder<T> b, string background) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("background"), b.Const(background));
    }


    /// <summary>
    /// <para> The edge radius of each module. Must be between 0 and 0.5. </para>
    /// </summary>
    public static void SetRadius<T>(this PropsBuilder<T> b, Var<int> radius) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("radius"), radius);
    }

    /// <summary>
    /// <para> The edge radius of each module. Must be between 0 and 0.5. </para>
    /// </summary>
    public static void SetRadius<T>(this PropsBuilder<T> b, int radius) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("radius"), b.Const(radius));
    }


    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionL<T>(this PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("L"));
    }


    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionM<T>(this PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("M"));
    }


    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionQ<T>(this PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("Q"));
    }


    /// <summary>
    /// <para> The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html) </para>
    /// </summary>
    public static void SetErrorCorrectionH<T>(this PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("H"));
    }


}

