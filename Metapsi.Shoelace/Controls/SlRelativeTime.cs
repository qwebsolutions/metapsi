using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRelativeTime
{
}

public static partial class SlRelativeTimeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRelativeTime(this HtmlBuilder b, Action<AttributesBuilder<SlRelativeTime>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-relative-time", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRelativeTime(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-relative-time", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRelativeTime(this HtmlBuilder b, Action<AttributesBuilder<SlRelativeTime>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-relative-time", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRelativeTime(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-relative-time", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate(this AttributesBuilder<SlRelativeTime> b, string date)
    {
        b.SetAttribute("date", date);
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormat(this AttributesBuilder<SlRelativeTime> b, string format)
    {
        b.SetAttribute("format", format);
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormatLong(this AttributesBuilder<SlRelativeTime> b)
    {
        b.SetAttribute("format", "long");
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormatShort(this AttributesBuilder<SlRelativeTime> b)
    {
        b.SetAttribute("format", "short");
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormatNarrow(this AttributesBuilder<SlRelativeTime> b)
    {
        b.SetAttribute("format", "narrow");
    }

    /// <summary>
    /// <para> When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown. </para>
    /// </summary>
    public static void SetNumeric(this AttributesBuilder<SlRelativeTime> b, string numeric)
    {
        b.SetAttribute("numeric", numeric);
    }

    /// <summary>
    /// <para> When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown. </para>
    /// </summary>
    public static void SetNumericAlways(this AttributesBuilder<SlRelativeTime> b)
    {
        b.SetAttribute("numeric", "always");
    }

    /// <summary>
    /// <para> When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown. </para>
    /// </summary>
    public static void SetNumericAuto(this AttributesBuilder<SlRelativeTime> b)
    {
        b.SetAttribute("numeric", "auto");
    }

    /// <summary>
    /// <para> Keep the displayed value up to date as time passes. </para>
    /// </summary>
    public static void SetSync(this AttributesBuilder<SlRelativeTime> b)
    {
        b.SetAttribute("sync", "");
    }

    /// <summary>
    /// <para> Keep the displayed value up to date as time passes. </para>
    /// </summary>
    public static void SetSync(this AttributesBuilder<SlRelativeTime> b, bool sync)
    {
        if (sync) b.SetAttribute("sync", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRelativeTime(this LayoutBuilder b, Action<PropsBuilder<SlRelativeTime>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-relative-time", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRelativeTime(this LayoutBuilder b, Action<PropsBuilder<SlRelativeTime>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-relative-time", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRelativeTime(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-relative-time", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRelativeTime(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-relative-time", children);
    }
    /// <summary>
    /// <para> The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, Var<DateTime> date) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), date);
    }

    /// <summary>
    /// <para> The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, DateTime date) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTime>("date"), b.Const(date));
    }


    /// <summary>
    /// <para> The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, Var<string> date) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), date);
    }

    /// <summary>
    /// <para> The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString). </para>
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, string date) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("date"), b.Const(date));
    }


    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormatLong<T>(this PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("long"));
    }


    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormatShort<T>(this PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("short"));
    }


    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetFormatNarrow<T>(this PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("narrow"));
    }


    /// <summary>
    /// <para> When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown. </para>
    /// </summary>
    public static void SetNumericAlways<T>(this PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("numeric"), b.Const("always"));
    }


    /// <summary>
    /// <para> When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown. </para>
    /// </summary>
    public static void SetNumericAuto<T>(this PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("numeric"), b.Const("auto"));
    }


    /// <summary>
    /// <para> Keep the displayed value up to date as time passes. </para>
    /// </summary>
    public static void SetSync<T>(this PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("sync"), b.Const(true));
    }


    /// <summary>
    /// <para> Keep the displayed value up to date as time passes. </para>
    /// </summary>
    public static void SetSync<T>(this PropsBuilder<T> b, Var<bool> sync) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("sync"), sync);
    }

    /// <summary>
    /// <para> Keep the displayed value up to date as time passes. </para>
    /// </summary>
    public static void SetSync<T>(this PropsBuilder<T> b, bool sync) where T: SlRelativeTime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("sync"), b.Const(sync));
    }


}

