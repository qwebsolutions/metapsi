using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonDatetime
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The buttons in the datetime. </para>
        /// </summary>
        public const string Buttons = "buttons";
        /// <summary>
        /// <para> The label for the time selector in the datetime. </para>
        /// </summary>
        public const string TimeLabel = "time-label";
        /// <summary>
        /// <para> The title of the datetime. </para>
        /// </summary>
        public const string Title = "title";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Emits the ionCancel event and optionally closes the popover or modal that the datetime was presented in. </para>
        /// <para> (closeOverlay?: boolean) =&gt; Promise&lt;void&gt; </para>
        /// <para> closeOverlay  </para>
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary>
        /// <para> Confirms the selected datetime value, updates the `value` property, and optionally closes the popover or modal that the datetime was presented in. </para>
        /// <para> (closeOverlay?: boolean) =&gt; Promise&lt;void&gt; </para>
        /// <para> closeOverlay  </para>
        /// </summary>
        public const string Confirm = "confirm";
        /// <summary>
        /// <para> Resets the internal state of the datetime but does not update the value. Passing a valid ISO-8601 string will reset the state of the component to the provided date. If no value is provided, the internal state will be reset to the clamped value of the min, max and today. </para>
        /// <para> (startDate?: string) =&gt; Promise&lt;void&gt; </para>
        /// <para> startDate  </para>
        /// </summary>
        public const string Reset = "reset";
    }
}

public static partial class IonDatetimeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetime(this HtmlBuilder b, Action<AttributesBuilder<IonDatetime>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-datetime", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetime(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-datetime", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetime(this HtmlBuilder b, Action<AttributesBuilder<IonDatetime>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-datetime", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetime(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-datetime", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The text to display on the picker's cancel button. </para>
    /// </summary>
    public static void SetCancelText(this AttributesBuilder<IonDatetime> b, string cancelText)
    {
        b.SetAttribute("cancel-text", cancelText);
    }

    /// <summary>
    /// <para> The text to display on the picker's "Clear" button. </para>
    /// </summary>
    public static void SetClearText(this AttributesBuilder<IonDatetime> b, string clearText)
    {
        b.SetAttribute("clear-text", clearText);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonDatetime> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues(this AttributesBuilder<IonDatetime> b, string dayValues)
    {
        b.SetAttribute("day-values", dayValues);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the datetime. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the datetime. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonDatetime> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The text to display on the picker's "Done" button. </para>
    /// </summary>
    public static void SetDoneText(this AttributesBuilder<IonDatetime> b, string doneText)
    {
        b.SetAttribute("done-text", doneText);
    }

    /// <summary>
    /// <para> The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday. </para>
    /// </summary>
    public static void SetFirstDayOfWeek(this AttributesBuilder<IonDatetime> b, string firstDayOfWeek)
    {
        b.SetAttribute("first-day-of-week", firstDayOfWeek);
    }

    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycle(this AttributesBuilder<IonDatetime> b, string hourCycle)
    {
        b.SetAttribute("hour-cycle", hourCycle);
    }

    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH11(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h11");
    }

    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH12(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h12");
    }

    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH23(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h23");
    }

    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH24(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h24");
    }

    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues(this AttributesBuilder<IonDatetime> b, string hourValues)
    {
        b.SetAttribute("hour-values", hourValues);
    }

    /// <summary>
    /// <para> The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device. </para>
    /// </summary>
    public static void SetLocale(this AttributesBuilder<IonDatetime> b, string locale)
    {
        b.SetAttribute("locale", locale);
    }

    /// <summary>
    /// <para> The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year. </para>
    /// </summary>
    public static void SetMax(this AttributesBuilder<IonDatetime> b, string max)
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// <para> The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today. </para>
    /// </summary>
    public static void SetMin(this AttributesBuilder<IonDatetime> b, string min)
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues(this AttributesBuilder<IonDatetime> b, string minuteValues)
    {
        b.SetAttribute("minute-values", minuteValues);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonDatetime> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues(this AttributesBuilder<IonDatetime> b, string monthValues)
    {
        b.SetAttribute("month-values", monthValues);
    }

    /// <summary>
    /// <para> If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonDatetime> b, bool multiple)
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonDatetime> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`. </para>
    /// </summary>
    public static void SetPreferWheel(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("prefer-wheel", "");
    }

    /// <summary>
    /// <para> If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`. </para>
    /// </summary>
    public static void SetPreferWheel(this AttributesBuilder<IonDatetime> b, bool preferWheel)
    {
        if (preferWheel) b.SetAttribute("prefer-wheel", "");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentation(this AttributesBuilder<IonDatetime> b, string presentation)
    {
        b.SetAttribute("presentation", presentation);
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationDate(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "date");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationDateTime(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "date-time");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationMonth(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "month");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationMonthYear(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "month-year");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationTime(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "time");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationTimeDate(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "time-date");
    }

    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationYear(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "year");
    }

    /// <summary>
    /// <para> If `true`, the datetime appears normal but the selected date cannot be changed. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, the datetime appears normal but the selected date cannot be changed. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonDatetime> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowClearButton(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-clear-button", "");
    }

    /// <summary>
    /// <para> If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowClearButton(this AttributesBuilder<IonDatetime> b, bool showClearButton)
    {
        if (showClearButton) b.SetAttribute("show-clear-button", "");
    }

    /// <summary>
    /// <para> If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultButtons(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-default-buttons", "");
    }

    /// <summary>
    /// <para> If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultButtons(this AttributesBuilder<IonDatetime> b, bool showDefaultButtons)
    {
        if (showDefaultButtons) b.SetAttribute("show-default-buttons", "");
    }

    /// <summary>
    /// <para> If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultTimeLabel(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-default-time-label", "");
    }

    /// <summary>
    /// <para> If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultTimeLabel(this AttributesBuilder<IonDatetime> b, bool showDefaultTimeLabel)
    {
        if (showDefaultTimeLabel) b.SetAttribute("show-default-time-label", "");
    }

    /// <summary>
    /// <para> If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date. </para>
    /// </summary>
    public static void SetShowDefaultTitle(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-default-title", "");
    }

    /// <summary>
    /// <para> If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date. </para>
    /// </summary>
    public static void SetShowDefaultTitle(this AttributesBuilder<IonDatetime> b, bool showDefaultTitle)
    {
        if (showDefaultTitle) b.SetAttribute("show-default-title", "");
    }

    /// <summary>
    /// <para> If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonDatetime> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width. </para>
    /// </summary>
    public static void SetSizeCover(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("size", "cover");
    }

    /// <summary>
    /// <para> If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width. </para>
    /// </summary>
    public static void SetSizeFixed(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("size", "fixed");
    }

    /// <summary>
    /// <para> The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues(this AttributesBuilder<IonDatetime> b, string yearValues)
    {
        b.SetAttribute("year-values", yearValues);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetime(this LayoutBuilder b, Action<PropsBuilder<IonDatetime>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-datetime", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetime(this LayoutBuilder b, Action<PropsBuilder<IonDatetime>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-datetime", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetime(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-datetime", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetime(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-datetime", children);
    }
    /// <summary>
    /// <para> The text to display on the picker's cancel button. </para>
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, Var<string> cancelText) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), cancelText);
    }

    /// <summary>
    /// <para> The text to display on the picker's cancel button. </para>
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, string cancelText) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), b.Const(cancelText));
    }


    /// <summary>
    /// <para> The text to display on the picker's "Clear" button. </para>
    /// </summary>
    public static void SetClearText<T>(this PropsBuilder<T> b, Var<string> clearText) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearText"), clearText);
    }

    /// <summary>
    /// <para> The text to display on the picker's "Clear" button. </para>
    /// </summary>
    public static void SetClearText<T>(this PropsBuilder<T> b, string clearText) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearText"), b.Const(clearText));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, Var<int> dayValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("dayValues"), dayValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, int dayValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("dayValues"), b.Const(dayValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, Var<List<int>> dayValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("dayValues"), dayValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, List<int> dayValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("dayValues"), b.Const(dayValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, Var<string> dayValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("dayValues"), dayValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month. </para>
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, string dayValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("dayValues"), b.Const(dayValues));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the datetime. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the datetime. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the datetime. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The text to display on the picker's "Done" button. </para>
    /// </summary>
    public static void SetDoneText<T>(this PropsBuilder<T> b, Var<string> doneText) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("doneText"), doneText);
    }

    /// <summary>
    /// <para> The text to display on the picker's "Done" button. </para>
    /// </summary>
    public static void SetDoneText<T>(this PropsBuilder<T> b, string doneText) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("doneText"), b.Const(doneText));
    }


    /// <summary>
    /// <para> The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday. </para>
    /// </summary>
    public static void SetFirstDayOfWeek<T>(this PropsBuilder<T> b, Var<int> firstDayOfWeek) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("firstDayOfWeek"), firstDayOfWeek);
    }

    /// <summary>
    /// <para> The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday. </para>
    /// </summary>
    public static void SetFirstDayOfWeek<T>(this PropsBuilder<T> b, int firstDayOfWeek) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("firstDayOfWeek"), b.Const(firstDayOfWeek));
    }


    /// <summary>
    /// <para> Formatting options for dates and times. Should include a 'date' and/or 'time' object, each of which is of type [Intl.DateTimeFormatOptions](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat#options). </para>
    /// </summary>
    public static void SetFormatOptions<T>(this PropsBuilder<T> b, Var<IonDatetimeFormatOptions> formatOptions) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonDatetimeFormatOptions>("formatOptions"), formatOptions);
    }

    /// <summary>
    /// <para> Formatting options for dates and times. Should include a 'date' and/or 'time' object, each of which is of type [Intl.DateTimeFormatOptions](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat#options). </para>
    /// </summary>
    public static void SetFormatOptions<T>(this PropsBuilder<T> b, IonDatetimeFormatOptions formatOptions) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonDatetimeFormatOptions>("formatOptions"), b.Const(formatOptions));
    }


    /// <summary>
    /// <para> Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`. </para>
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, Var<System.Func<string,DatetimeHighlightStyle>> highlightedDates) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<string,DatetimeHighlightStyle>>("highlightedDates"), highlightedDates);
    }

    /// <summary>
    /// <para> Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`. </para>
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, System.Func<string,DatetimeHighlightStyle> highlightedDates) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<string,DatetimeHighlightStyle>>("highlightedDates"), b.Const(highlightedDates));
    }


    /// <summary>
    /// <para> Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`. </para>
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, Var<List<DatetimeHighlight>> highlightedDates) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<DatetimeHighlight>>("highlightedDates"), highlightedDates);
    }

    /// <summary>
    /// <para> Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`. </para>
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, List<DatetimeHighlight> highlightedDates) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<DatetimeHighlight>>("highlightedDates"), b.Const(highlightedDates));
    }


    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH11<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourCycle"), b.Const("h11"));
    }


    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH12<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourCycle"), b.Const("h12"));
    }


    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH23<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourCycle"), b.Const("h23"));
    }


    /// <summary>
    /// <para> The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale. </para>
    /// </summary>
    public static void SetHourCycleH24<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourCycle"), b.Const("h24"));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, Var<int> hourValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("hourValues"), hourValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, int hourValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("hourValues"), b.Const(hourValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, Var<List<int>> hourValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("hourValues"), hourValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, List<int> hourValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("hourValues"), b.Const(hourValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, Var<string> hourValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourValues"), hourValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers. </para>
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, string hourValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourValues"), b.Const(hourValues));
    }


    /// <summary>
    /// <para> Returns if an individual date (calendar day) is enabled or disabled.  If `true`, the day will be enabled/interactive. If `false`, the day will be disabled/non-interactive.  The function accepts an ISO 8601 date string of a given day. By default, all days are enabled. Developers can use this function to write custom logic to disable certain days.  The function is called for each rendered calendar day, for the previous, current and next month. Custom implementations should be optimized for performance to avoid jank. </para>
    /// </summary>
    public static void SetIsDateEnabled<T>(this PropsBuilder<T> b, Var<System.Func<string,bool>> isDateEnabled) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<string,bool>>("isDateEnabled"), isDateEnabled);
    }

    /// <summary>
    /// <para> Returns if an individual date (calendar day) is enabled or disabled.  If `true`, the day will be enabled/interactive. If `false`, the day will be disabled/non-interactive.  The function accepts an ISO 8601 date string of a given day. By default, all days are enabled. Developers can use this function to write custom logic to disable certain days.  The function is called for each rendered calendar day, for the previous, current and next month. Custom implementations should be optimized for performance to avoid jank. </para>
    /// </summary>
    public static void SetIsDateEnabled<T>(this PropsBuilder<T> b, System.Func<string,bool> isDateEnabled) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<string,bool>>("isDateEnabled"), b.Const(isDateEnabled));
    }


    /// <summary>
    /// <para> The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device. </para>
    /// </summary>
    public static void SetLocale<T>(this PropsBuilder<T> b, Var<string> locale) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("locale"), locale);
    }

    /// <summary>
    /// <para> The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device. </para>
    /// </summary>
    public static void SetLocale<T>(this PropsBuilder<T> b, string locale) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("locale"), b.Const(locale));
    }


    /// <summary>
    /// <para> The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<string> max) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), max);
    }

    /// <summary>
    /// <para> The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, string max) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), b.Const(max));
    }


    /// <summary>
    /// <para> The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<string> min) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), min);
    }

    /// <summary>
    /// <para> The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, string min) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), b.Const(min));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, Var<int> minuteValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minuteValues"), minuteValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, int minuteValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minuteValues"), b.Const(minuteValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, Var<List<int>> minuteValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("minuteValues"), minuteValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, List<int> minuteValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("minuteValues"), b.Const(minuteValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, Var<string> minuteValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("minuteValues"), minuteValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`. </para>
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, string minuteValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("minuteValues"), b.Const(minuteValues));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, Var<int> monthValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("monthValues"), monthValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, int monthValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("monthValues"), b.Const(monthValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, Var<List<int>> monthValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("monthValues"), monthValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, List<int> monthValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("monthValues"), b.Const(monthValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, Var<string> monthValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("monthValues"), monthValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`. </para>
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, string monthValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("monthValues"), b.Const(monthValues));
    }


    /// <summary>
    /// <para> If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> multiple) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), multiple);
    }

    /// <summary>
    /// <para> If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool multiple) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(multiple));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`. </para>
    /// </summary>
    public static void SetPreferWheel<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("preferWheel"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`. </para>
    /// </summary>
    public static void SetPreferWheel<T>(this PropsBuilder<T> b, Var<bool> preferWheel) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("preferWheel"), preferWheel);
    }

    /// <summary>
    /// <para> If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`. </para>
    /// </summary>
    public static void SetPreferWheel<T>(this PropsBuilder<T> b, bool preferWheel) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("preferWheel"), b.Const(preferWheel));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationDate<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("date"));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationDateTime<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("date-time"));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationMonth<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("month"));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationMonthYear<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("month-year"));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationTime<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("time"));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationTimeDate<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("time-date"));
    }


    /// <summary>
    /// <para> Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second. </para>
    /// </summary>
    public static void SetPresentationYear<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("presentation"), b.Const("year"));
    }


    /// <summary>
    /// <para> If `true`, the datetime appears normal but the selected date cannot be changed. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the datetime appears normal but the selected date cannot be changed. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), @readonly);
    }

    /// <summary>
    /// <para> If `true`, the datetime appears normal but the selected date cannot be changed. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowClearButton<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showClearButton"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowClearButton<T>(this PropsBuilder<T> b, Var<bool> showClearButton) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showClearButton"), showClearButton);
    }

    /// <summary>
    /// <para> If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowClearButton<T>(this PropsBuilder<T> b, bool showClearButton) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showClearButton"), b.Const(showClearButton));
    }


    /// <summary>
    /// <para> If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultButtons<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultButtons"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultButtons<T>(this PropsBuilder<T> b, Var<bool> showDefaultButtons) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultButtons"), showDefaultButtons);
    }

    /// <summary>
    /// <para> If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultButtons<T>(this PropsBuilder<T> b, bool showDefaultButtons) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultButtons"), b.Const(showDefaultButtons));
    }


    /// <summary>
    /// <para> If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultTimeLabel"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this PropsBuilder<T> b, Var<bool> showDefaultTimeLabel) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultTimeLabel"), showDefaultTimeLabel);
    }

    /// <summary>
    /// <para> If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered. </para>
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this PropsBuilder<T> b, bool showDefaultTimeLabel) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultTimeLabel"), b.Const(showDefaultTimeLabel));
    }


    /// <summary>
    /// <para> If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date. </para>
    /// </summary>
    public static void SetShowDefaultTitle<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultTitle"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date. </para>
    /// </summary>
    public static void SetShowDefaultTitle<T>(this PropsBuilder<T> b, Var<bool> showDefaultTitle) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultTitle"), showDefaultTitle);
    }

    /// <summary>
    /// <para> If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date. </para>
    /// </summary>
    public static void SetShowDefaultTitle<T>(this PropsBuilder<T> b, bool showDefaultTitle) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showDefaultTitle"), b.Const(showDefaultTitle));
    }


    /// <summary>
    /// <para> If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width. </para>
    /// </summary>
    public static void SetSizeCover<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("cover"));
    }


    /// <summary>
    /// <para> If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width. </para>
    /// </summary>
    public static void SetSizeFixed<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> A callback used to format the header text that shows how many dates are selected. Only used if there are 0 or more than 1 selected (i.e. unused for exactly 1). By default, the header text is set to "numberOfDates days".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetTitleSelectedDatesFormatter<T>(this PropsBuilder<T> b, Var<System.Func<List<string>,string>> titleSelectedDatesFormatter) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<List<string>,string>>("titleSelectedDatesFormatter"), titleSelectedDatesFormatter);
    }

    /// <summary>
    /// <para> A callback used to format the header text that shows how many dates are selected. Only used if there are 0 or more than 1 selected (i.e. unused for exactly 1). By default, the header text is set to "numberOfDates days".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetTitleSelectedDatesFormatter<T>(this PropsBuilder<T> b, System.Func<List<string>,string> titleSelectedDatesFormatter) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<List<string>,string>>("titleSelectedDatesFormatter"), b.Const(titleSelectedDatesFormatter));
    }


    /// <summary>
    /// <para> The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), value);
    }

    /// <summary>
    /// <para> The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, List<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, Var<int> yearValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("yearValues"), yearValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, int yearValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("yearValues"), b.Const(yearValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, Var<List<int>> yearValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("yearValues"), yearValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, List<int> yearValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("yearValues"), b.Const(yearValues));
    }


    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, Var<string> yearValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("yearValues"), yearValues);
    }

    /// <summary>
    /// <para> Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`. </para>
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, string yearValues) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("yearValues"), b.Const(yearValues));
    }


    /// <summary>
    /// <para> Emitted when the datetime loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the datetime loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the datetime selection was cancelled. </para>
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// <para> Emitted when the datetime selection was cancelled. </para>
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the value (selected date) has changed. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DatetimeChangeEventDetail>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the value (selected date) has changed. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DatetimeChangeEventDetail>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the datetime has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the datetime has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

public class IonDatetimeFormatOptions { }
    /// <summary>
    ///
    /// </summary>
    public static void SetDate<T>(this PropsBuilder<T> b, Var<DateTimeFormatOptions> date) where T: IonDatetimeFormatOptions
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTimeFormatOptions>("date"), date);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetTime<T>(this PropsBuilder<T> b, Var<DateTimeFormatOptions> time) where T: IonDatetimeFormatOptions
    {
        b.SetDynamic(b.Props, new DynamicProperty<DateTimeFormatOptions>("time"), time);
    }

}

