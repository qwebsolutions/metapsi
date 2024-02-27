using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlFormatBytes
{
    public int value { get; set; }
}
public static partial class SlFormatBytesControl
{
    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Var<IVNode> SlFormatBytes(this LayoutBuilder b, Action<PropsBuilder<SlFormatBytes>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-bytes", buildProps, children);
    }
    /// <summary>
    /// Formats a number as a human readable bytes value.
    /// </summary>
    public static Var<IVNode> SlFormatBytes(this LayoutBuilder b, Action<PropsBuilder<SlFormatBytes>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-bytes", buildProps, children);
    }
    /// <summary>
    /// The number to format in bytes.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlFormatBytes> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The number to format in bytes.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlFormatBytes> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static void SetUnitByte(this PropsBuilder<SlFormatBytes> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("unit"), b.Const("byte"));
    }
    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static void SetUnitBit(this PropsBuilder<SlFormatBytes> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("unit"), b.Const("bit"));
    }
    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayLong(this PropsBuilder<SlFormatBytes> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("display"), b.Const("long"));
    }
    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayShort(this PropsBuilder<SlFormatBytes> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("display"), b.Const("short"));
    }
    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static void SetDisplayNarrow(this PropsBuilder<SlFormatBytes> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("display"), b.Const("narrow"));
    }
}

/// <summary>
/// Formats a number as a human readable bytes value.
/// </summary>
public partial class SlFormatBytes : HtmlTag
{
    public SlFormatBytes()
    {
        this.Tag = "sl-format-bytes";
    }

    public static SlFormatBytes New()
    {
        return new SlFormatBytes();
    }
}

public static partial class SlFormatBytesControl
{
    /// <summary>
    /// The number to format in bytes.
    /// </summary>
    public static SlFormatBytes SetValue(this SlFormatBytes tag, int value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static SlFormatBytes SetUnitByte(this SlFormatBytes tag)
    {
        return tag.SetAttribute("unit", "byte");
    }
    /// <summary>
    /// The type of unit to display.
    /// </summary>
    public static SlFormatBytes SetUnitBit(this SlFormatBytes tag)
    {
        return tag.SetAttribute("unit", "bit");
    }
    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static SlFormatBytes SetDisplayLong(this SlFormatBytes tag)
    {
        return tag.SetAttribute("display", "long");
    }
    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static SlFormatBytes SetDisplayShort(this SlFormatBytes tag)
    {
        return tag.SetAttribute("display", "short");
    }
    /// <summary>
    /// Determines how to display the result, e.g. "100 bytes", "100 b", or "100b".
    /// </summary>
    public static SlFormatBytes SetDisplayNarrow(this SlFormatBytes tag)
    {
        return tag.SetAttribute("display", "narrow");
    }
}

