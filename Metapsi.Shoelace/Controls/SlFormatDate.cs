using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlFormatDate
{
}

public static partial class SlFormatDateControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatDate(this HtmlBuilder b, Action<AttributesBuilder<SlFormatDate>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-format-date", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatDate(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-format-date", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatDate(this HtmlBuilder b, Action<AttributesBuilder<SlFormatDate>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-format-date", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatDate(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-format-date", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate(this AttributesBuilder<SlFormatDate> b, string date)
    {
        b.SetAttribute("date", date);
    }

    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekday(this AttributesBuilder<SlFormatDate> b, string weekday)
    {
        b.SetAttribute("weekday", weekday);
    }

    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekdayNarrow(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("weekday", "narrow");
    }

    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekdayShort(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("weekday", "short");
    }

    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekdayLong(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("weekday", "long");
    }

    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEra(this AttributesBuilder<SlFormatDate> b, string era)
    {
        b.SetAttribute("era", era);
    }

    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEraNarrow(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("era", "narrow");
    }

    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEraShort(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("era", "short");
    }

    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEraLong(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("era", "long");
    }

    /// <summary>
    /// <para> The format for displaying the year. </para>
    /// </summary>
    public static void SetYear(this AttributesBuilder<SlFormatDate> b, string year)
    {
        b.SetAttribute("year", year);
    }

    /// <summary>
    /// <para> The format for displaying the year. </para>
    /// </summary>
    public static void SetYearNumeric(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("year", "numeric");
    }

    /// <summary>
    /// <para> The format for displaying the year. </para>
    /// </summary>
    public static void SetYear2Digit(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("year", "2-digit");
    }

    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonth(this AttributesBuilder<SlFormatDate> b, string month)
    {
        b.SetAttribute("month", month);
    }

    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthNumeric(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("month", "numeric");
    }

    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonth2Digit(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("month", "2-digit");
    }

    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthNarrow(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("month", "narrow");
    }

    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthShort(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("month", "short");
    }

    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthLong(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("month", "long");
    }

    /// <summary>
    /// <para> The format for displaying the day. </para>
    /// </summary>
    public static void SetDay(this AttributesBuilder<SlFormatDate> b, string day)
    {
        b.SetAttribute("day", day);
    }

    /// <summary>
    /// <para> The format for displaying the day. </para>
    /// </summary>
    public static void SetDayNumeric(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("day", "numeric");
    }

    /// <summary>
    /// <para> The format for displaying the day. </para>
    /// </summary>
    public static void SetDay2Digit(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("day", "2-digit");
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHour(this AttributesBuilder<SlFormatDate> b, string hour)
    {
        b.SetAttribute("hour", hour);
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourNumeric(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("hour", "numeric");
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHour2Digit(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("hour", "2-digit");
    }

    /// <summary>
    /// <para> The format for displaying the minute. </para>
    /// </summary>
    public static void SetMinute(this AttributesBuilder<SlFormatDate> b, string minute)
    {
        b.SetAttribute("minute", minute);
    }

    /// <summary>
    /// <para> The format for displaying the minute. </para>
    /// </summary>
    public static void SetMinuteNumeric(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("minute", "numeric");
    }

    /// <summary>
    /// <para> The format for displaying the minute. </para>
    /// </summary>
    public static void SetMinute2Digit(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("minute", "2-digit");
    }

    /// <summary>
    /// <para> The format for displaying the second. </para>
    /// </summary>
    public static void SetSecond(this AttributesBuilder<SlFormatDate> b, string second)
    {
        b.SetAttribute("second", second);
    }

    /// <summary>
    /// <para> The format for displaying the second. </para>
    /// </summary>
    public static void SetSecondNumeric(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("second", "numeric");
    }

    /// <summary>
    /// <para> The format for displaying the second. </para>
    /// </summary>
    public static void SetSecond2Digit(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("second", "2-digit");
    }

    /// <summary>
    /// <para> The format for displaying the time. </para>
    /// </summary>
    public static void SetTimeZoneName(this AttributesBuilder<SlFormatDate> b, string timeZoneName)
    {
        b.SetAttribute("time-zone-name", timeZoneName);
    }

    /// <summary>
    /// <para> The format for displaying the time. </para>
    /// </summary>
    public static void SetTimeZoneNameShort(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("time-zone-name", "short");
    }

    /// <summary>
    /// <para> The format for displaying the time. </para>
    /// </summary>
    public static void SetTimeZoneNameLong(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("time-zone-name", "long");
    }

    /// <summary>
    /// <para> The time zone to express the time in. </para>
    /// </summary>
    public static void SetTimeZone(this AttributesBuilder<SlFormatDate> b, string timeZone)
    {
        b.SetAttribute("time-zone", timeZone);
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormat(this AttributesBuilder<SlFormatDate> b, string hourFormat)
    {
        b.SetAttribute("hour-format", hourFormat);
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormatAuto(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("hour-format", "auto");
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormat12(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("hour-format", "12");
    }

    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormat24(this AttributesBuilder<SlFormatDate> b)
    {
        b.SetAttribute("hour-format", "24");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, Action<PropsBuilder<SlFormatDate>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-format-date", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, Action<PropsBuilder<SlFormatDate>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-format-date", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-format-date", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatDate(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-format-date", children);
    }
    /// <summary>
    /// <para> The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, Var<DateTime> date) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), date);
    }

    /// <summary>
    /// <para> The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, DateTime date) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), b.Const(date));
    }


    /// <summary>
    /// <para> The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, Var<string> date) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), date);
    }

    /// <summary>
    /// <para> The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, string date) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), b.Const(date));
    }


    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekdayNarrow<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("weekday"), b.Const("narrow"));
    }


    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekdayShort<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("weekday"), b.Const("short"));
    }


    /// <summary>
    /// <para> The format for displaying the weekday. </para>
    /// </summary>
    public static void SetWeekdayLong<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("weekday"), b.Const("long"));
    }


    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEraNarrow<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("era"), b.Const("narrow"));
    }


    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEraShort<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("era"), b.Const("short"));
    }


    /// <summary>
    /// <para> The format for displaying the era. </para>
    /// </summary>
    public static void SetEraLong<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("era"), b.Const("long"));
    }


    /// <summary>
    /// <para> The format for displaying the year. </para>
    /// </summary>
    public static void SetYearNumeric<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("year"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> The format for displaying the year. </para>
    /// </summary>
    public static void SetYear2Digit<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("year"), b.Const("2-digit"));
    }


    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthNumeric<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("month"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonth2Digit<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("month"), b.Const("2-digit"));
    }


    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthNarrow<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("month"), b.Const("narrow"));
    }


    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthShort<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("month"), b.Const("short"));
    }


    /// <summary>
    /// <para> The format for displaying the month. </para>
    /// </summary>
    public static void SetMonthLong<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("month"), b.Const("long"));
    }


    /// <summary>
    /// <para> The format for displaying the day. </para>
    /// </summary>
    public static void SetDayNumeric<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("day"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> The format for displaying the day. </para>
    /// </summary>
    public static void SetDay2Digit<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("day"), b.Const("2-digit"));
    }


    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourNumeric<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hour"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHour2Digit<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hour"), b.Const("2-digit"));
    }


    /// <summary>
    /// <para> The format for displaying the minute. </para>
    /// </summary>
    public static void SetMinuteNumeric<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("minute"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> The format for displaying the minute. </para>
    /// </summary>
    public static void SetMinute2Digit<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("minute"), b.Const("2-digit"));
    }


    /// <summary>
    /// <para> The format for displaying the second. </para>
    /// </summary>
    public static void SetSecondNumeric<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("second"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> The format for displaying the second. </para>
    /// </summary>
    public static void SetSecond2Digit<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("second"), b.Const("2-digit"));
    }


    /// <summary>
    /// <para> The format for displaying the time. </para>
    /// </summary>
    public static void SetTimeZoneNameShort<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("timeZoneName"), b.Const("short"));
    }


    /// <summary>
    /// <para> The format for displaying the time. </para>
    /// </summary>
    public static void SetTimeZoneNameLong<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("timeZoneName"), b.Const("long"));
    }


    /// <summary>
    /// <para> The time zone to express the time in. </para>
    /// </summary>
    public static void SetTimeZone<T>(this PropsBuilder<T> b, Var<string> timeZone) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("timeZone"), timeZone);
    }

    /// <summary>
    /// <para> The time zone to express the time in. </para>
    /// </summary>
    public static void SetTimeZone<T>(this PropsBuilder<T> b, string timeZone) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("timeZone"), b.Const(timeZone));
    }


    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormatAuto<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourFormat"), b.Const("auto"));
    }


    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormat12<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourFormat"), b.Const("12"));
    }


    /// <summary>
    /// <para> The format for displaying the hour. </para>
    /// </summary>
    public static void SetHourFormat24<T>(this PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourFormat"), b.Const("24"));
    }


}

