using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlRelativeTime
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
    public static void SetDate(this PropsBuilder<SlRelativeTime> b, Var<DateTime> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), value);
    }
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlRelativeTime> b, DateTime value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), b.Const(value));
    }
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlRelativeTime> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), value);
    }
    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlRelativeTime> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), b.Const(value));
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

