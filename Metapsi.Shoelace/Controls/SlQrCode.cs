using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlQrCode
{
}

public static partial class SlQrCodeControl
{
    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, Action<PropsBuilder<SlQrCode>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-qr-code", buildProps, children);
    }
    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, Action<PropsBuilder<SlQrCode>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-qr-code", buildProps, children);
    }
    /// <summary>
    /// The QR code's value.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlQrCode> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The QR code's value.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlQrCode> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// The label for assistive devices to announce. If unspecified, the value will be used instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlQrCode> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The label for assistive devices to announce. If unspecified, the value will be used instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlQrCode> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The size of the QR code, in pixels.
    /// </summary>
    public static void SetSize(this PropsBuilder<SlQrCode> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("size"), value);
    }
    /// <summary>
    /// The size of the QR code, in pixels.
    /// </summary>
    public static void SetSize(this PropsBuilder<SlQrCode> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("size"), b.Const(value));
    }

    /// <summary>
    /// The fill color. This can be any valid CSS color, but not a CSS custom property.
    /// </summary>
    public static void SetFill(this PropsBuilder<SlQrCode> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), value);
    }
    /// <summary>
    /// The fill color. This can be any valid CSS color, but not a CSS custom property.
    /// </summary>
    public static void SetFill(this PropsBuilder<SlQrCode> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const(value));
    }

    /// <summary>
    /// The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property.
    /// </summary>
    public static void SetBackground(this PropsBuilder<SlQrCode> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("background"), value);
    }
    /// <summary>
    /// The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property.
    /// </summary>
    public static void SetBackground(this PropsBuilder<SlQrCode> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("background"), b.Const(value));
    }

    /// <summary>
    /// The edge radius of each module. Must be between 0 and 0.5.
    /// </summary>
    public static void SetRadius(this PropsBuilder<SlQrCode> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("radius"), value);
    }
    /// <summary>
    /// The edge radius of each module. Must be between 0 and 0.5.
    /// </summary>
    public static void SetRadius(this PropsBuilder<SlQrCode> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("radius"), b.Const(value));
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionL(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("errorCorrection"), b.Const("L"));
    }
    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionM(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("errorCorrection"), b.Const("M"));
    }
    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionQ(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("errorCorrection"), b.Const("Q"));
    }
    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionH(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("errorCorrection"), b.Const("H"));
    }

}

