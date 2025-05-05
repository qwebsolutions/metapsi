using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlFormatBytes
{
}

public static partial class SlFormatBytesControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatBytes(this HtmlBuilder b, Action<AttributesBuilder<SlFormatBytes>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-format-bytes", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatBytes(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-format-bytes", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatBytes(this HtmlBuilder b, Action<AttributesBuilder<SlFormatBytes>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-format-bytes", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatBytes(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-format-bytes", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The number to format in bytes. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlFormatBytes> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The type of unit to display. </para>
    /// </summary>
    public static void SetUnit(this AttributesBuilder<SlFormatBytes> b, string unit)
    {
        b.SetAttribute("unit", unit);
    }

    /// <summary>
    /// <para> The type of unit to display. </para>
    /// </summary>
    public static void SetUnitByte(this AttributesBuilder<SlFormatBytes> b)
    {
        b.SetAttribute("unit", "byte");
    }

    /// <summary>
    /// <para> The type of unit to display. </para>
    /// </summary>
    public static void SetUnitBit(this AttributesBuilder<SlFormatBytes> b)
    {
        b.SetAttribute("unit", "bit");
    }

    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplay(this AttributesBuilder<SlFormatBytes> b, string display)
    {
        b.SetAttribute("display", display);
    }

    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplayLong(this AttributesBuilder<SlFormatBytes> b)
    {
        b.SetAttribute("display", "long");
    }

    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplayShort(this AttributesBuilder<SlFormatBytes> b)
    {
        b.SetAttribute("display", "short");
    }

    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplayNarrow(this AttributesBuilder<SlFormatBytes> b)
    {
        b.SetAttribute("display", "narrow");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatBytes(this LayoutBuilder b, Action<PropsBuilder<SlFormatBytes>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-bytes", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatBytes(this LayoutBuilder b, Action<PropsBuilder<SlFormatBytes>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-bytes", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatBytes(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-bytes", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatBytes(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-bytes", children);
    }
    /// <summary>
    /// <para> The number to format in bytes. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The number to format in bytes. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The type of unit to display. </para>
    /// </summary>
    public static void SetUnitByte<T>(this PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("unit"), b.Const("byte"));
    }


    /// <summary>
    /// <para> The type of unit to display. </para>
    /// </summary>
    public static void SetUnitBit<T>(this PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("unit"), b.Const("bit"));
    }


    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplayLong<T>(this PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("display"), b.Const("long"));
    }


    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplayShort<T>(this PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("display"), b.Const("short"));
    }


    /// <summary>
    /// <para> Determines how to display the result, e.g. "100 bytes", "100 b", or "100b". </para>
    /// </summary>
    public static void SetDisplayNarrow<T>(this PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("display"), b.Const("narrow"));
    }


}

