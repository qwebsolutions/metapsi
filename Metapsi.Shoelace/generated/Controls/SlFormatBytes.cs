using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Formats a number as a human readable bytes value.
/// </summary>
public partial class SlFormatBytes
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
/// Setter extensions of SlFormatBytes
/// </summary>
public static partial class SlFormatBytesControl
{
    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatBytes(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlFormatBytes>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-format-bytes", buildAttributes, children);
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatBytes(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-format-bytes", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatBytes(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlFormatBytes>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-format-bytes", buildAttributes, children);
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatBytes(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-format-bytes", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static void SetUnitByte(this Metapsi.Html.AttributesBuilder<SlFormatBytes> b) 
    {
        b.SetAttribute("unit", "byte");
    }

    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static void SetUnitBit(this Metapsi.Html.AttributesBuilder<SlFormatBytes> b) 
    {
        b.SetAttribute("unit", "bit");
    }

    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayLong(this Metapsi.Html.AttributesBuilder<SlFormatBytes> b) 
    {
        b.SetAttribute("display", "long");
    }

    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayShort(this Metapsi.Html.AttributesBuilder<SlFormatBytes> b) 
    {
        b.SetAttribute("display", "short");
    }

    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayNarrow(this Metapsi.Html.AttributesBuilder<SlFormatBytes> b) 
    {
        b.SetAttribute("display", "narrow");
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatBytes(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlFormatBytes>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-format-bytes", buildProps, children);
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatBytes(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-format-bytes", children);
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatBytes(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlFormatBytes>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-format-bytes", buildProps, children);
    }

    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatBytes(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-format-bytes", children);
    }

    /// <summary>
    /// The number to format in bytes.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static void SetUnitByte<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("unit"), b.Const("byte"));
    }

    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static void SetUnitBit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("unit"), b.Const("bit"));
    }

    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayLong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("display"), b.Const("long"));
    }

    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayShort<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("display"), b.Const("short"));
    }

    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayNarrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatBytes
    {
        b.SetProperty(b.Props, b.Const("display"), b.Const("narrow"));
    }

}