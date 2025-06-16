using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Formats a date/time using the specified locale and options.
/// </summary>
public partial class SlFormatDate
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
/// Setter extensions of SlFormatDate
/// </summary>
public static partial class SlFormatDateControl
{
    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatDate(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlFormatDate>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-format-date", buildAttributes, children);
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatDate(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-format-date", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatDate(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlFormatDate>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-format-date", buildAttributes, children);
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatDate(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-format-date", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this Metapsi.Html.AttributesBuilder<SlFormatDate> b, string date) 
    {
        b.SetAttribute("date", date);
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayNarrow(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("weekday", "narrow");
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayShort(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("weekday", "short");
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayLong(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("weekday", "long");
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraNarrow(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("era", "narrow");
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraShort(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("era", "short");
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraLong(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("era", "long");
    }

    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static void SetYearNumeric(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("year", "numeric");
    }

    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static void SetYear2Digit(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("year", "2-digit");
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthNumeric(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("month", "numeric");
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonth2Digit(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("month", "2-digit");
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthNarrow(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("month", "narrow");
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthShort(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("month", "short");
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthLong(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("month", "long");
    }

    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static void SetDayNumeric(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("day", "numeric");
    }

    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static void SetDay2Digit(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("day", "2-digit");
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourNumeric(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("hour", "numeric");
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHour2Digit(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("hour", "2-digit");
    }

    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static void SetMinuteNumeric(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("minute", "numeric");
    }

    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static void SetMinute2Digit(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("minute", "2-digit");
    }

    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static void SetSecondNumeric(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("second", "numeric");
    }

    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static void SetSecond2Digit(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("second", "2-digit");
    }

    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameShort(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("time-zone-name", "short");
    }

    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameLong(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("time-zone-name", "long");
    }

    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone(this Metapsi.Html.AttributesBuilder<SlFormatDate> b, string timeZone) 
    {
        b.SetAttribute("time-zone", timeZone);
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormatAuto(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("hour-format", "auto");
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat12(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("hour-format", "12");
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat24(this Metapsi.Html.AttributesBuilder<SlFormatDate> b) 
    {
        b.SetAttribute("hour-format", "24");
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatDate(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlFormatDate>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-format-date", buildProps, children);
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatDate(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-format-date", children);
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatDate(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlFormatDate>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-format-date", buildProps, children);
    }

    /// <summary>
    /// Formats a date/time using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatDate(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-format-date", children);
    }

    /// <summary>
    /// The date/time to format. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> date) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("date"), date);
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayNarrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("weekday"), b.Const("narrow"));
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayShort<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("weekday"), b.Const("short"));
    }

    /// <summary>
    /// The format for displaying the weekday.
    /// </summary>
    public static void SetWeekdayLong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("weekday"), b.Const("long"));
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraNarrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("era"), b.Const("narrow"));
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraShort<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("era"), b.Const("short"));
    }

    /// <summary>
    /// The format for displaying the era.
    /// </summary>
    public static void SetEraLong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("era"), b.Const("long"));
    }

    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static void SetYearNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("year"), b.Const("numeric"));
    }

    /// <summary>
    /// The format for displaying the year.
    /// </summary>
    public static void SetYear2Digit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("year"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("month"), b.Const("numeric"));
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonth2Digit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("month"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthNarrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("month"), b.Const("narrow"));
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthShort<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("month"), b.Const("short"));
    }

    /// <summary>
    /// The format for displaying the month.
    /// </summary>
    public static void SetMonthLong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("month"), b.Const("long"));
    }

    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static void SetDayNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("day"), b.Const("numeric"));
    }

    /// <summary>
    /// The format for displaying the day.
    /// </summary>
    public static void SetDay2Digit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("day"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("hour"), b.Const("numeric"));
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHour2Digit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("hour"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static void SetMinuteNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("minute"), b.Const("numeric"));
    }

    /// <summary>
    /// The format for displaying the minute.
    /// </summary>
    public static void SetMinute2Digit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("minute"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static void SetSecondNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("second"), b.Const("numeric"));
    }

    /// <summary>
    /// The format for displaying the second.
    /// </summary>
    public static void SetSecond2Digit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("second"), b.Const("2-digit"));
    }

    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameShort<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("timeZoneName"), b.Const("short"));
    }

    /// <summary>
    /// The format for displaying the time.
    /// </summary>
    public static void SetTimeZoneNameLong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("timeZoneName"), b.Const("long"));
    }

    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> timeZone) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("timeZone"), timeZone);
    }

    /// <summary>
    /// The time zone to express the time in.
    /// </summary>
    public static void SetTimeZone<T>(this Metapsi.Syntax.PropsBuilder<T> b, string timeZone) where T: SlFormatDate
    {
        b.SetTimeZone(b.Const(timeZone));
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormatAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("hourFormat"), b.Const("auto"));
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat12<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("hourFormat"), b.Const("12"));
    }

    /// <summary>
    /// The format for displaying the hour.
    /// </summary>
    public static void SetHourFormat24<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatDate
    {
        b.SetProperty(b.Props, b.Const("hourFormat"), b.Const("24"));
    }

}