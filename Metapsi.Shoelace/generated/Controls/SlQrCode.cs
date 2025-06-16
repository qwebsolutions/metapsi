using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
/// </summary>
public partial class SlQrCode
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
/// Setter extensions of SlQrCode
/// </summary>
public static partial class SlQrCodeControl
{
    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlQrCode(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlQrCode>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-qr-code", buildAttributes, children);
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlQrCode(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-qr-code", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlQrCode(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlQrCode>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-qr-code", buildAttributes, children);
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlQrCode(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-qr-code", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The QR code's value.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlQrCode> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The label for assistive devices to announce. If unspecified, the value will be used instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlQrCode> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The fill color. This can be any valid CSS color, but not a CSS custom property.
    /// </summary>
    public static void SetFill(this Metapsi.Html.AttributesBuilder<SlQrCode> b, string fill) 
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property.
    /// </summary>
    public static void SetBackground(this Metapsi.Html.AttributesBuilder<SlQrCode> b, string background) 
    {
        b.SetAttribute("background", background);
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionL(this Metapsi.Html.AttributesBuilder<SlQrCode> b) 
    {
        b.SetAttribute("error-correction", "L");
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionM(this Metapsi.Html.AttributesBuilder<SlQrCode> b) 
    {
        b.SetAttribute("error-correction", "M");
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionQ(this Metapsi.Html.AttributesBuilder<SlQrCode> b) 
    {
        b.SetAttribute("error-correction", "Q");
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionH(this Metapsi.Html.AttributesBuilder<SlQrCode> b) 
    {
        b.SetAttribute("error-correction", "H");
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlQrCode(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlQrCode>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-qr-code", buildProps, children);
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlQrCode(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-qr-code", children);
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlQrCode(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlQrCode>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-qr-code", buildProps, children);
    }

    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlQrCode(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-qr-code", children);
    }

    /// <summary>
    /// The QR code's value.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The QR code's value.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlQrCode
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The label for assistive devices to announce. If unspecified, the value will be used instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The label for assistive devices to announce. If unspecified, the value will be used instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlQrCode
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The size of the QR code, in pixels.
    /// </summary>
    public static void SetSize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> size) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("size"), size);
    }

    /// <summary>
    /// The size of the QR code, in pixels.
    /// </summary>
    public static void SetSize<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal size) where T: SlQrCode
    {
        b.SetSize(b.Const(size));
    }

    /// <summary>
    /// The fill color. This can be any valid CSS color, but not a CSS custom property.
    /// </summary>
    public static void SetFill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> fill) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("fill"), fill);
    }

    /// <summary>
    /// The fill color. This can be any valid CSS color, but not a CSS custom property.
    /// </summary>
    public static void SetFill<T>(this Metapsi.Syntax.PropsBuilder<T> b, string fill) where T: SlQrCode
    {
        b.SetFill(b.Const(fill));
    }

    /// <summary>
    /// The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property.
    /// </summary>
    public static void SetBackground<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> background) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("background"), background);
    }

    /// <summary>
    /// The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property.
    /// </summary>
    public static void SetBackground<T>(this Metapsi.Syntax.PropsBuilder<T> b, string background) where T: SlQrCode
    {
        b.SetBackground(b.Const(background));
    }

    /// <summary>
    /// The edge radius of each module. Must be between 0 and 0.5.
    /// </summary>
    public static void SetRadius<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> radius) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("radius"), radius);
    }

    /// <summary>
    /// The edge radius of each module. Must be between 0 and 0.5.
    /// </summary>
    public static void SetRadius<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal radius) where T: SlQrCode
    {
        b.SetRadius(b.Const(radius));
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionL<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("L"));
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionM<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("M"));
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionQ<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("Q"));
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionH<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlQrCode
    {
        b.SetProperty(b.Props, b.Const("errorCorrection"), b.Const("H"));
    }

}