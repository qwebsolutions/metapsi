using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonDatetime
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The buttons in the datetime.
        /// </summary>
        public const string Buttons = "buttons";
        /// <summary>
        /// The label for the time selector in the datetime.
        /// </summary>
        public const string TimeLabel = "time-label";
        /// <summary>
        /// The title of the datetime.
        /// </summary>
        public const string Title = "title";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Emits the ionCancel event and optionally closes the popover or modal that the datetime was presented in.
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary>
        /// Confirms the selected datetime value, updates the `value` property, and optionally closes the popover or modal that the datetime was presented in.
        /// </summary>
        public const string Confirm = "confirm";
        /// <summary>
        /// Resets the internal state of the datetime but does not update the value. Passing a valid ISO-8601 string will reset the state of the component to the provided date. If no value is provided, the internal state will be reset to the clamped value of the min, max and today.
        /// </summary>
        public const string Reset = "reset";
    }
}
/// <summary>
/// Setter extensions of IonDatetime
/// </summary>
public static partial class IonDatetimeControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonDatetime(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonDatetime>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-datetime", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonDatetime(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-datetime", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonDatetime(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonDatetime>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-datetime", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonDatetime(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-datetime", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The text to display on the picker's cancel button.
    /// </summary>
    public static void SetCancelText(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string cancelText) 
    {
        b.SetAttribute("cancelText", cancelText);
    }

    /// <summary>
    /// The text to display on the picker's "Clear" button.
    /// </summary>
    public static void SetClearText(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string clearText) 
    {
        b.SetAttribute("clearText", clearText);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string dayValues) 
    {
        b.SetAttribute("dayValues", dayValues);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The text to display on the picker's "Done" button.
    /// </summary>
    public static void SetDoneText(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string doneText) 
    {
        b.SetAttribute("doneText", doneText);
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH11(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("hourCycle", "h11");
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH12(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("hourCycle", "h12");
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH23(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("hourCycle", "h23");
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH24(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("hourCycle", "h24");
    }

    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string hourValues) 
    {
        b.SetAttribute("hourValues", hourValues);
    }

    /// <summary>
    /// The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device.
    /// </summary>
    public static void SetLocale(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string locale) 
    {
        b.SetAttribute("locale", locale);
    }

    /// <summary>
    /// The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year.
    /// </summary>
    public static void SetMax(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string max) 
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today.
    /// </summary>
    public static void SetMin(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string min) 
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string minuteValues) 
    {
        b.SetAttribute("minuteValues", minuteValues);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string monthValues) 
    {
        b.SetAttribute("monthValues", monthValues);
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool multiple) 
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool preferWheel) 
    {
        if (preferWheel) b.SetAttribute("preferWheel", "");
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("preferWheel", "");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDate(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "date");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDateTime(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "date-time");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonth(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "month");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonthYear(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "month-year");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTime(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "time");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTimeDate(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "time-date");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationYear(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("presentation", "year");
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool showClearButton) 
    {
        if (showClearButton) b.SetAttribute("showClearButton", "");
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("showClearButton", "");
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool showDefaultButtons) 
    {
        if (showDefaultButtons) b.SetAttribute("showDefaultButtons", "");
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("showDefaultButtons", "");
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool showDefaultTimeLabel) 
    {
        if (showDefaultTimeLabel) b.SetAttribute("showDefaultTimeLabel", "");
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("showDefaultTimeLabel", "");
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle(this Metapsi.Html.AttributesBuilder<IonDatetime> b, bool showDefaultTitle) 
    {
        if (showDefaultTitle) b.SetAttribute("showDefaultTitle", "");
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("showDefaultTitle", "");
    }

    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeCover(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("size", "cover");
    }

    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeFixed(this Metapsi.Html.AttributesBuilder<IonDatetime> b) 
    {
        b.SetAttribute("size", "fixed");
    }

    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues(this Metapsi.Html.AttributesBuilder<IonDatetime> b, string yearValues) 
    {
        b.SetAttribute("yearValues", yearValues);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonDatetime(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonDatetime>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-datetime", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonDatetime(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-datetime", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonDatetime(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonDatetime>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-datetime", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonDatetime(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-datetime", children);
    }

    /// <summary>
    /// The text to display on the picker's cancel button.
    /// </summary>
    public static void SetCancelText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cancelText) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("cancelText"), cancelText);
    }

    /// <summary>
    /// The text to display on the picker's cancel button.
    /// </summary>
    public static void SetCancelText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string cancelText) where T: IonDatetime
    {
        b.SetCancelText(b.Const(cancelText));
    }

    /// <summary>
    /// The text to display on the picker's "Clear" button.
    /// </summary>
    public static void SetClearText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> clearText) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("clearText"), clearText);
    }

    /// <summary>
    /// The text to display on the picker's "Clear" button.
    /// </summary>
    public static void SetClearText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string clearText) where T: IonDatetime
    {
        b.SetClearText(b.Const(clearText));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> dayValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("dayValues"), dayValues);
    }

    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> dayValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("dayValues"), dayValues);
    }

    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> dayValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("dayValues"), dayValues);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonDatetime
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The text to display on the picker's "Done" button.
    /// </summary>
    public static void SetDoneText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> doneText) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("doneText"), doneText);
    }

    /// <summary>
    /// The text to display on the picker's "Done" button.
    /// </summary>
    public static void SetDoneText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string doneText) where T: IonDatetime
    {
        b.SetDoneText(b.Const(doneText));
    }

    /// <summary>
    /// The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday.
    /// </summary>
    public static void SetFirstDayOfWeek<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> firstDayOfWeek) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("firstDayOfWeek"), firstDayOfWeek);
    }

    /// <summary>
    /// The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday.
    /// </summary>
    public static void SetFirstDayOfWeek<T>(this Metapsi.Syntax.PropsBuilder<T> b, int firstDayOfWeek) where T: IonDatetime
    {
        b.SetFirstDayOfWeek(b.Const(firstDayOfWeek));
    }

    /// <summary>
    /// Formatting options for dates and times. Should include a 'date' and/or 'time' object, each of which is of type [Intl.DateTimeFormatOptions](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat#options).
    /// </summary>
    public static void SetFormatOptions<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> formatOptions) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("formatOptions"), formatOptions);
    }

    /// <summary>
    /// Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`.
    /// </summary>
    public static void SetHighlightedDates<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Ionic.DatetimeHighlight>> highlightedDates) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("highlightedDates"), highlightedDates);
    }

    /// <summary>
    /// Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`.
    /// </summary>
    public static void SetHighlightedDates<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<string, Metapsi.Ionic.DatetimeHighlightStyle>> highlightedDates) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("highlightedDates"), highlightedDates);
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH11<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourCycle"), b.Const("h11"));
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH12<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourCycle"), b.Const("h12"));
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH23<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourCycle"), b.Const("h23"));
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH24<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourCycle"), b.Const("h24"));
    }

    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> hourValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourValues"), hourValues);
    }

    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> hourValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourValues"), hourValues);
    }

    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> hourValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("hourValues"), hourValues);
    }

    /// <summary>
    /// Returns if an individual date (calendar day) is enabled or disabled.  If `true`, the day will be enabled/interactive. If `false`, the day will be disabled/non-interactive.  The function accepts an ISO 8601 date string of a given day. By default, all days are enabled. Developers can use this function to write custom logic to disable certain days.  The function is called for each rendered calendar day, for the previous, current and next month. Custom implementations should be optimized for performance to avoid jank.
    /// </summary>
    public static void SetIsDateEnabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Ionic.DatetimeHighlight>> isDateEnabled) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("isDateEnabled"), isDateEnabled);
    }

    /// <summary>
    /// Returns if an individual date (calendar day) is enabled or disabled.  If `true`, the day will be enabled/interactive. If `false`, the day will be disabled/non-interactive.  The function accepts an ISO 8601 date string of a given day. By default, all days are enabled. Developers can use this function to write custom logic to disable certain days.  The function is called for each rendered calendar day, for the previous, current and next month. Custom implementations should be optimized for performance to avoid jank.
    /// </summary>
    public static void SetIsDateEnabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<string, bool>> isDateEnabled) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("isDateEnabled"), isDateEnabled);
    }

    /// <summary>
    /// The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device.
    /// </summary>
    public static void SetLocale<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> locale) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("locale"), locale);
    }

    /// <summary>
    /// The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device.
    /// </summary>
    public static void SetLocale<T>(this Metapsi.Syntax.PropsBuilder<T> b, string locale) where T: IonDatetime
    {
        b.SetLocale(b.Const(locale));
    }

    /// <summary>
    /// The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> max) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, string max) where T: IonDatetime
    {
        b.SetMax(b.Const(max));
    }

    /// <summary>
    /// The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> min) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, string min) where T: IonDatetime
    {
        b.SetMin(b.Const(min));
    }

    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> minuteValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("minuteValues"), minuteValues);
    }

    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minuteValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("minuteValues"), minuteValues);
    }

    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> minuteValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("minuteValues"), minuteValues);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> monthValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("monthValues"), monthValues);
    }

    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> monthValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("monthValues"), monthValues);
    }

    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> monthValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("monthValues"), monthValues);
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetMultiple(b.Const(true));
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> multiple) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool multiple) where T: IonDatetime
    {
        b.SetMultiple(b.Const(multiple));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonDatetime
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetPreferWheel(b.Const(true));
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> preferWheel) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("preferWheel"), preferWheel);
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool preferWheel) where T: IonDatetime
    {
        b.SetPreferWheel(b.Const(preferWheel));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("date"));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDateTime<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("date-time"));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("month"));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonthYear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("month-year"));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTime<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("time"));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTimeDate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("time-date"));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationYear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("presentation"), b.Const("year"));
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: IonDatetime
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetShowClearButton(b.Const(true));
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showClearButton) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("showClearButton"), showClearButton);
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool showClearButton) where T: IonDatetime
    {
        b.SetShowClearButton(b.Const(showClearButton));
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetShowDefaultButtons(b.Const(true));
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showDefaultButtons) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("showDefaultButtons"), showDefaultButtons);
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool showDefaultButtons) where T: IonDatetime
    {
        b.SetShowDefaultButtons(b.Const(showDefaultButtons));
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetShowDefaultTimeLabel(b.Const(true));
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showDefaultTimeLabel) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("showDefaultTimeLabel"), showDefaultTimeLabel);
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool showDefaultTimeLabel) where T: IonDatetime
    {
        b.SetShowDefaultTimeLabel(b.Const(showDefaultTimeLabel));
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetShowDefaultTitle(b.Const(true));
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showDefaultTitle) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("showDefaultTitle"), showDefaultTitle);
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool showDefaultTitle) where T: IonDatetime
    {
        b.SetShowDefaultTitle(b.Const(showDefaultTitle));
    }

    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeCover<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("cover"));
    }

    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("fixed"));
    }

    /// <summary>
    /// A callback used to format the header text that shows how many dates are selected. Only used if there are 0 or more than 1 selected (i.e. unused for exactly 1). By default, the header text is set to "numberOfDates days".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetTitleSelectedDatesFormatter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<System.Collections.Generic.List<string>, string>> titleSelectedDatesFormatter) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("titleSelectedDatesFormatter"), titleSelectedDatesFormatter);
    }

    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> value) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> yearValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("yearValues"), yearValues);
    }

    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> yearValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("yearValues"), yearValues);
    }

    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> yearValues) where T: IonDatetime
    {
        b.SetProperty(b.Props, b.Const("yearValues"), yearValues);
    }

    /// <summary>
    /// Emitted when the datetime loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the datetime loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the datetime loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the datetime loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the datetime selection was cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionCancel", action);
    }

    /// <summary>
    /// Emitted when the datetime selection was cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the datetime selection was cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionCancel", action);
    }

    /// <summary>
    /// Emitted when the datetime selection was cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value (selected date) has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value (selected date) has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value (selected date) has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value (selected date) has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value (selected date) has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<DatetimeChangeEventDetail>>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the datetime has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the datetime has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the datetime has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonDatetime
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the datetime has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonDatetime
    {
        b.OnIonFocus(b.MakeAction(action));
    }

}