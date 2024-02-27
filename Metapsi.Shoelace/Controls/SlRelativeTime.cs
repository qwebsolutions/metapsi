using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlRelativeTime
{
}
public static partial class SlRelativeTimeControl
{
    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Var<IVNode> SlRelativeTime(this LayoutBuilder b, Action<PropsBuilder<SlRelativeTime>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-relative-time", buildProps, children);
    }
    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Var<IVNode> SlRelativeTime(this LayoutBuilder b, Action<PropsBuilder<SlRelativeTime>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-relative-time", buildProps, children);
    }
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDateDate(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("date"), b.Const("Date"));
    }
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDateString(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("date"), b.Const("string"));
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatLong(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("long"));
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatShort(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("short"));
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatNarrow(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("narrow"));
    }
    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static void SetNumericAlways(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("numeric"), b.Const("always"));
    }
    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static void SetNumericAuto(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("numeric"), b.Const("auto"));
    }
    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static void SetSync(this PropsBuilder<SlRelativeTime> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("sync"), b.Const(true));
    }
}

/// <summary>
/// Outputs a localized time phrase relative to the current date and time.
/// </summary>
public partial class SlRelativeTime : HtmlTag
{
    public SlRelativeTime()
    {
        this.Tag = "sl-relative-time";
    }

    public static SlRelativeTime New()
    {
        return new SlRelativeTime();
    }
}

public static partial class SlRelativeTimeControl
{
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static SlRelativeTime SetDateDate(this SlRelativeTime tag)
    {
        return tag.SetAttribute("date", "Date");
    }
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static SlRelativeTime SetDateString(this SlRelativeTime tag)
    {
        return tag.SetAttribute("date", "string");
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static SlRelativeTime SetFormatLong(this SlRelativeTime tag)
    {
        return tag.SetAttribute("format", "long");
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static SlRelativeTime SetFormatShort(this SlRelativeTime tag)
    {
        return tag.SetAttribute("format", "short");
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static SlRelativeTime SetFormatNarrow(this SlRelativeTime tag)
    {
        return tag.SetAttribute("format", "narrow");
    }
    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static SlRelativeTime SetNumericAlways(this SlRelativeTime tag)
    {
        return tag.SetAttribute("numeric", "always");
    }
    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static SlRelativeTime SetNumericAuto(this SlRelativeTime tag)
    {
        return tag.SetAttribute("numeric", "auto");
    }
    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static SlRelativeTime SetSync(this SlRelativeTime tag)
    {
        return tag.SetAttribute("sync", "true");
    }
}

