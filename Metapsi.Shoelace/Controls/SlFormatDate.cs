using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlFormatDate
{
}
public static partial class SlFormatDateControl
{
    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, Action<PropsBuilder<SlFormatDate>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-date", buildProps, children);
    }
    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, Action<PropsBuilder<SlFormatDate>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-date", buildProps, children);
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDateDate(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("date"), b.Const("Date"));
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDateString(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("date"), b.Const("string"));
    }
    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayNarrow(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("weekday"), b.Const("narrow"));
    }
    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayShort(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("weekday"), b.Const("short"));
    }
    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayLong(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("weekday"), b.Const("long"));
    }
    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraNarrow(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("era"), b.Const("narrow"));
    }
    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraShort(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("era"), b.Const("short"));
    }
    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraLong(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("era"), b.Const("long"));
    }
    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static void SetYearNumeric(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("year"), b.Const("numeric"));
    }
    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static void SetYear2digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("year"), b.Const("2-digit"));
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthNumeric(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("month"), b.Const("numeric"));
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonth2digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("month"), b.Const("2-digit"));
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthNarrow(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("month"), b.Const("narrow"));
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthShort(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("month"), b.Const("short"));
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthLong(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("month"), b.Const("long"));
    }
    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static void SetDayNumeric(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("day"), b.Const("numeric"));
    }
    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static void SetDay2digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("day"), b.Const("2-digit"));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourNumeric(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hour"), b.Const("numeric"));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHour2digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hour"), b.Const("2-digit"));
    }
    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static void SetMinuteNumeric(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("minute"), b.Const("numeric"));
    }
    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static void SetMinute2digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("minute"), b.Const("2-digit"));
    }
    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static void SetSecondNumeric(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("second"), b.Const("numeric"));
    }
    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static void SetSecond2digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("second"), b.Const("2-digit"));
    }
    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameShort(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("timeZoneName"), b.Const("short"));
    }
    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameLong(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("timeZoneName"), b.Const("long"));
    }
    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone(this PropsBuilder<SlFormatDate> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("timeZone"), value);
    }
    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone(this PropsBuilder<SlFormatDate> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("timeZone"), b.Const(value));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormatAuto(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourFormat"), b.Const("auto"));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat12(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourFormat"), b.Const("12"));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat24(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourFormat"), b.Const("24"));
    }
}

/// <summary>
/// Formats a date/time using the specified locale and options.
/// </summary>
public partial class SlFormatDate : HtmlTag
{
    public SlFormatDate()
    {
        this.Tag = "sl-format-date";
    }

    public static SlFormatDate New()
    {
        return new SlFormatDate();
    }
}

public static partial class SlFormatDateControl
{
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static SlFormatDate SetDateDate(this SlFormatDate tag)
    {
        return tag.SetAttribute("date", "Date");
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static SlFormatDate SetDateString(this SlFormatDate tag)
    {
        return tag.SetAttribute("date", "string");
    }
    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static SlFormatDate SetWeekdayNarrow(this SlFormatDate tag)
    {
        return tag.SetAttribute("weekday", "narrow");
    }
    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static SlFormatDate SetWeekdayShort(this SlFormatDate tag)
    {
        return tag.SetAttribute("weekday", "short");
    }
    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static SlFormatDate SetWeekdayLong(this SlFormatDate tag)
    {
        return tag.SetAttribute("weekday", "long");
    }
    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static SlFormatDate SetEraNarrow(this SlFormatDate tag)
    {
        return tag.SetAttribute("era", "narrow");
    }
    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static SlFormatDate SetEraShort(this SlFormatDate tag)
    {
        return tag.SetAttribute("era", "short");
    }
    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static SlFormatDate SetEraLong(this SlFormatDate tag)
    {
        return tag.SetAttribute("era", "long");
    }
    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static SlFormatDate SetYearNumeric(this SlFormatDate tag)
    {
        return tag.SetAttribute("year", "numeric");
    }
    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static SlFormatDate SetYear2digit(this SlFormatDate tag)
    {
        return tag.SetAttribute("year", "2-digit");
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static SlFormatDate SetMonthNumeric(this SlFormatDate tag)
    {
        return tag.SetAttribute("month", "numeric");
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static SlFormatDate SetMonth2digit(this SlFormatDate tag)
    {
        return tag.SetAttribute("month", "2-digit");
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static SlFormatDate SetMonthNarrow(this SlFormatDate tag)
    {
        return tag.SetAttribute("month", "narrow");
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static SlFormatDate SetMonthShort(this SlFormatDate tag)
    {
        return tag.SetAttribute("month", "short");
    }
    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static SlFormatDate SetMonthLong(this SlFormatDate tag)
    {
        return tag.SetAttribute("month", "long");
    }
    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static SlFormatDate SetDayNumeric(this SlFormatDate tag)
    {
        return tag.SetAttribute("day", "numeric");
    }
    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static SlFormatDate SetDay2digit(this SlFormatDate tag)
    {
        return tag.SetAttribute("day", "2-digit");
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static SlFormatDate SetHourNumeric(this SlFormatDate tag)
    {
        return tag.SetAttribute("hour", "numeric");
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static SlFormatDate SetHour2digit(this SlFormatDate tag)
    {
        return tag.SetAttribute("hour", "2-digit");
    }
    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static SlFormatDate SetMinuteNumeric(this SlFormatDate tag)
    {
        return tag.SetAttribute("minute", "numeric");
    }
    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static SlFormatDate SetMinute2digit(this SlFormatDate tag)
    {
        return tag.SetAttribute("minute", "2-digit");
    }
    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static SlFormatDate SetSecondNumeric(this SlFormatDate tag)
    {
        return tag.SetAttribute("second", "numeric");
    }
    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static SlFormatDate SetSecond2digit(this SlFormatDate tag)
    {
        return tag.SetAttribute("second", "2-digit");
    }
    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static SlFormatDate SetTimeZoneNameShort(this SlFormatDate tag)
    {
        return tag.SetAttribute("timeZoneName", "short");
    }
    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static SlFormatDate SetTimeZoneNameLong(this SlFormatDate tag)
    {
        return tag.SetAttribute("timeZoneName", "long");
    }
    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static SlFormatDate SetTimeZone(this SlFormatDate tag, string value)
    {
        return tag.SetAttribute("timeZone", value.ToString());
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static SlFormatDate SetHourFormatAuto(this SlFormatDate tag)
    {
        return tag.SetAttribute("hourFormat", "auto");
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static SlFormatDate SetHourFormat12(this SlFormatDate tag)
    {
        return tag.SetAttribute("hourFormat", "12");
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static SlFormatDate SetHourFormat24(this SlFormatDate tag)
    {
        return tag.SetAttribute("hourFormat", "24");
    }
}

