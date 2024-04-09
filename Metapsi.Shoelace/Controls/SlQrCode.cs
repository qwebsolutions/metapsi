using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlQrCode : SlComponent
{
    public SlQrCode() : base("sl-qr-code") { }
    /// <summary>
    /// The QR code's value.
    /// </summary>
    public string value
    {
        get
        {
            return this.GetTag().GetAttribute<string>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// The label for assistive devices to announce. If unspecified, the value will be used instead.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

    /// <summary>
    /// The size of the QR code, in pixels.
    /// </summary>
    public int size
    {
        get
        {
            return this.GetTag().GetAttribute<int>("size");
        }
        set
        {
            this.GetTag().SetAttribute("size", value.ToString());
        }
    }

    /// <summary>
    /// The fill color. This can be any valid CSS color, but not a CSS custom property.
    /// </summary>
    public string fill
    {
        get
        {
            return this.GetTag().GetAttribute<string>("fill");
        }
        set
        {
            this.GetTag().SetAttribute("fill", value.ToString());
        }
    }

    /// <summary>
    /// The background color. This can be any valid CSS color or `transparent`. It cannot be a CSS custom property.
    /// </summary>
    public string background
    {
        get
        {
            return this.GetTag().GetAttribute<string>("background");
        }
        set
        {
            this.GetTag().SetAttribute("background", value.ToString());
        }
    }

    /// <summary>
    /// The edge radius of each module. Must be between 0 and 0.5.
    /// </summary>
    public int radius
    {
        get
        {
            return this.GetTag().GetAttribute<int>("radius");
        }
        set
        {
            this.GetTag().SetAttribute("radius", value.ToString());
        }
    }

    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public string errorCorrection
    {
        get
        {
            return this.GetTag().GetAttribute<string>("error-correction");
        }
        set
        {
            this.GetTag().SetAttribute("error-correction", value.ToString());
        }
    }

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
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-qr-code", children);
    }
    /// <summary>
    /// Generates a [QR code](https://www.qrcode.com/) and renders it using the [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API).
    /// </summary>
    public static Var<IVNode> SlQrCode(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-qr-code", children);
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
        b.SetDynamic(b.Props, DynamicProperty.String("error-correction"), b.Const("L"));
    }
    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionM(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("error-correction"), b.Const("M"));
    }
    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionQ(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("error-correction"), b.Const("Q"));
    }
    /// <summary>
    /// The level of error correction to use. [Learn more](https://www.qrcode.com/en/about/error_correction.html)
    /// </summary>
    public static void SetErrorCorrectionH(this PropsBuilder<SlQrCode> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("error-correction"), b.Const("H"));
    }

}

