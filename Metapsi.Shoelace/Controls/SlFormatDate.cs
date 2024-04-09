using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlFormatDate : SlComponent
{
    public SlFormatDate() : base("sl-format-date") { }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public string date
    {
        get
        {
            return this.GetTag().GetAttribute<string>("date");
        }
        set
        {
            this.GetTag().SetAttribute("date", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public string weekday
    {
        get
        {
            return this.GetTag().GetAttribute<string>("weekday");
        }
        set
        {
            this.GetTag().SetAttribute("weekday", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public string era
    {
        get
        {
            return this.GetTag().GetAttribute<string>("era");
        }
        set
        {
            this.GetTag().SetAttribute("era", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public string year
    {
        get
        {
            return this.GetTag().GetAttribute<string>("year");
        }
        set
        {
            this.GetTag().SetAttribute("year", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public string month
    {
        get
        {
            return this.GetTag().GetAttribute<string>("month");
        }
        set
        {
            this.GetTag().SetAttribute("month", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public string day
    {
        get
        {
            return this.GetTag().GetAttribute<string>("day");
        }
        set
        {
            this.GetTag().SetAttribute("day", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public string hour
    {
        get
        {
            return this.GetTag().GetAttribute<string>("hour");
        }
        set
        {
            this.GetTag().SetAttribute("hour", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public string minute
    {
        get
        {
            return this.GetTag().GetAttribute<string>("minute");
        }
        set
        {
            this.GetTag().SetAttribute("minute", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public string second
    {
        get
        {
            return this.GetTag().GetAttribute<string>("second");
        }
        set
        {
            this.GetTag().SetAttribute("second", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public string timeZoneName
    {
        get
        {
            return this.GetTag().GetAttribute<string>("time-zone-name");
        }
        set
        {
            this.GetTag().SetAttribute("time-zone-name", value.ToString());
        }
    }

    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public string timeZone
    {
        get
        {
            return this.GetTag().GetAttribute<string>("time-zone");
        }
        set
        {
            this.GetTag().SetAttribute("time-zone", value.ToString());
        }
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public string hourFormat
    {
        get
        {
            return this.GetTag().GetAttribute<string>("hour-format");
        }
        set
        {
            this.GetTag().SetAttribute("hour-format", value.ToString());
        }
    }

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
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-date", children);
    }
    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-date", children);
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlFormatDate> b, Var<DateTime> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), value);
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlFormatDate> b, DateTime value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), b.Const(value));
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlFormatDate> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), value);
    }
    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this PropsBuilder<SlFormatDate> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), b.Const(value));
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
    public static void SetYear2Digit(this PropsBuilder<SlFormatDate> b)
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
    public static void SetMonth2Digit(this PropsBuilder<SlFormatDate> b)
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
    public static void SetDay2Digit(this PropsBuilder<SlFormatDate> b)
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
    public static void SetHour2Digit(this PropsBuilder<SlFormatDate> b)
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
    public static void SetMinute2Digit(this PropsBuilder<SlFormatDate> b)
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
    public static void SetSecond2Digit(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("second"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameShort(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("time-zone-name"), b.Const("short"));
    }
    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameLong(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("time-zone-name"), b.Const("long"));
    }

    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone(this PropsBuilder<SlFormatDate> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("time-zone"), value);
    }
    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone(this PropsBuilder<SlFormatDate> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("time-zone"), b.Const(value));
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormatAuto(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hour-format"), b.Const("auto"));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat12(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hour-format"), b.Const("12"));
    }
    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat24(this PropsBuilder<SlFormatDate> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hour-format"), b.Const("24"));
    }

}

