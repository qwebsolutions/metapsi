using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Outputs a localized time phrase relative to the current date and time.
/// </summary>
public partial class SlRelativeTime
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
/// Setter extensions of SlRelativeTime
/// </summary>
public static partial class SlRelativeTimeControl
{
    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRelativeTime(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRelativeTime>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-relative-time", buildAttributes, children);
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRelativeTime(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-relative-time", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRelativeTime(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRelativeTime>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-relative-time", buildAttributes, children);
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRelativeTime(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-relative-time", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b, string date) 
    {
        b.SetAttribute("date", date);
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatLong(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b) 
    {
        b.SetAttribute("format", "long");
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatShort(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b) 
    {
        b.SetAttribute("format", "short");
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatNarrow(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b) 
    {
        b.SetAttribute("format", "narrow");
    }

    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static void SetNumericAlways(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b) 
    {
        b.SetAttribute("numeric", "always");
    }

    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static void SetNumericAuto(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b) 
    {
        b.SetAttribute("numeric", "auto");
    }

    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static void SetSync(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b, bool sync) 
    {
        if (sync) b.SetAttribute("sync", "");
    }

    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static void SetSync(this Metapsi.Html.AttributesBuilder<SlRelativeTime> b) 
    {
        b.SetAttribute("sync", "");
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRelativeTime(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRelativeTime>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-relative-time", buildProps, children);
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRelativeTime(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-relative-time", children);
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRelativeTime(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRelativeTime>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-relative-time", buildProps, children);
    }

    /// <summary>
    /// Outputs a localized time phrase relative to the current date and time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRelativeTime(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-relative-time", children);
    }

    /// <summary>
    /// The date from which to calculate time from. If not set, the current date and time will be used. When passing a string, it's strongly recommended to use the ISO 8601 format to ensure timezones are handled correctly. To convert a date to this format in JavaScript, use [`date.toISOString()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString).
    /// </summary>
    public static void SetDate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> date) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("date"), date);
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatLong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("long"));
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatShort<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("short"));
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetFormatNarrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("narrow"));
    }

    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static void SetNumericAlways<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("numeric"), b.Const("always"));
    }

    /// <summary>
    /// When `auto`, values such as "yesterday" and "tomorrow" will be shown when possible. When `always`, values such as "1 day ago" and "in 1 day" will be shown.
    /// </summary>
    public static void SetNumericAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("numeric"), b.Const("auto"));
    }

    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static void SetSync<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRelativeTime
    {
        b.SetSync(b.Const(true));
    }

    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static void SetSync<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> sync) where T: SlRelativeTime
    {
        b.SetProperty(b.Props, b.Const("sync"), sync);
    }

    /// <summary>
    /// Keep the displayed value up to date as time passes.
    /// </summary>
    public static void SetSync<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool sync) where T: SlRelativeTime
    {
        b.SetSync(b.Const(sync));
    }

}