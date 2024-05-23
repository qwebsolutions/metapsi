using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonDatetime : IonComponent
{
    public IonDatetime() : base("ion-datetime") { }
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
    public static class Method
    {
        /// <summary> 
        /// Emits the ionCancel event and optionally closes the popover or modal that the datetime was presented in.
        /// <para>(closeOverlay?: boolean) =&gt; Promise&lt;void&gt;</para>
        /// <para>closeOverlay </para>
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary> 
        /// Confirms the selected datetime value, updates the `value` property, and optionally closes the popover or modal that the datetime was presented in.
        /// <para>(closeOverlay?: boolean) =&gt; Promise&lt;void&gt;</para>
        /// <para>closeOverlay </para>
        /// </summary>
        public const string Confirm = "confirm";
        /// <summary> 
        /// Resets the internal state of the datetime but does not update the value. Passing a valid ISO-8601 string will reset the state of the component to the provided date. If no value is provided, the internal state will be reset to the clamped value of the min, max and today.
        /// <para>(startDate?: string) =&gt; Promise&lt;void&gt;</para>
        /// <para>startDate </para>
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
        return b.Tag("ion-datetime", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonDatetime(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-datetime", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The text to display on the picker's cancel button.
    /// </summary>
    public static void SetCancelText(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("cancel-text", value);
    }

    /// <summary>
    /// The text to display on the picker's "Clear" button.
    /// </summary>
    public static void SetClearText(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("clear-text", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("day-values", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The text to display on the picker's "Done" button.
    /// </summary>
    public static void SetDoneText(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("done-text", value);
    }

    /// <summary>
    /// The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday.
    /// </summary>
    public static void SetFirstDayOfWeek(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("first-day-of-week", value);
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycle(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("hour-cycle", value);
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH11(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h11");
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH12(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h12");
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH23(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h23");
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH24(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("hour-cycle", "h24");
    }

    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("hour-values", value);
    }

    /// <summary>
    /// The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device.
    /// </summary>
    public static void SetLocale(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("locale", value);
    }

    /// <summary>
    /// The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year.
    /// </summary>
    public static void SetMax(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("max", value);
    }

    /// <summary>
    /// The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today.
    /// </summary>
    public static void SetMin(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("min", value);
    }

    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("minute-values", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("month-values", value);
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("multiple", "");
    }
    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("prefer-wheel", "");
    }
    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("prefer-wheel", "");
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentation(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("presentation", value);
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDate(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "date");
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDateTime(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "date-time");
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonth(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "month");
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonthYear(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "month-year");
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTime(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "time");
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTimeDate(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "time-date");
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationYear(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("presentation", "year");
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("readonly", "");
    }
    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-clear-button", "");
    }
    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("show-clear-button", "");
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-default-buttons", "");
    }
    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("show-default-buttons", "");
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-default-time-label", "");
    }
    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("show-default-time-label", "");
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("show-default-title", "");
    }
    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle(this AttributesBuilder<IonDatetime> b, bool value)
    {
        if (value) b.SetAttribute("show-default-title", "");
    }

    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("size", value);
    }
    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeCover(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("size", "cover");
    }
    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeFixed(this AttributesBuilder<IonDatetime> b)
    {
        b.SetAttribute("size", "fixed");
    }

    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues(this AttributesBuilder<IonDatetime> b, string value)
    {
        b.SetAttribute("year-values", value);
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
    /// The text to display on the picker's cancel button.
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), value);
    }
    /// <summary>
    /// The text to display on the picker's cancel button.
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), b.Const(value));
    }

    /// <summary>
    /// The text to display on the picker's "Clear" button.
    /// </summary>
    public static void SetClearText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearText"), value);
    }
    /// <summary>
    /// The text to display on the picker's "Clear" button.
    /// </summary>
    public static void SetClearText<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearText"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, Var<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("dayValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, int value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("dayValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, Var<List<int>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("dayValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, List<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("dayValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("dayValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable days. By default every day is shown for the given month. However, to control exactly which days of the month to display, the `dayValues` input can take a number, an array of numbers, or a string of comma separated numbers. Note that even if the array days have an invalid number for the selected month, like `31` in February, it will correctly not show days which are not valid for the selected month.
    /// </summary>
    public static void SetDayValues<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("dayValues"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the datetime.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// The text to display on the picker's "Done" button.
    /// </summary>
    public static void SetDoneText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("doneText"), value);
    }
    /// <summary>
    /// The text to display on the picker's "Done" button.
    /// </summary>
    public static void SetDoneText<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("doneText"), b.Const(value));
    }

    /// <summary>
    /// The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday.
    /// </summary>
    public static void SetFirstDayOfWeek<T>(this PropsBuilder<T> b, Var<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("firstDayOfWeek"), value);
    }
    /// <summary>
    /// The first day of the week to use for `ion-datetime`. The default value is `0` and represents Sunday.
    /// </summary>
    public static void SetFirstDayOfWeek<T>(this PropsBuilder<T> b, int value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("firstDayOfWeek"), b.Const(value));
    }

    /// <summary>
    /// Formatting options for dates and times. Should include a 'date' and/or 'time' object, each of which is of type [Intl.DateTimeFormatOptions](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Intl/DateTimeFormat/DateTimeFormat#options).
    /// </summary>
    public static void SetFormatOptions<T>(this PropsBuilder<T> b, Var<DateTimeFormatOptions> date,Var<DateTimeFormatOptions> time) where T: IonDatetime
    {
        var _dynamicParameter = b.NewObj<DynamicObject>();
        b.SetDynamic(_dynamicParameter, new DynamicProperty<DateTimeFormatOptions>("date"), date);
        b.SetDynamic(_dynamicParameter, new DynamicProperty<DateTimeFormatOptions>("time"), time);
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("formatOptions"), _dynamicParameter);
    }

    /// <summary>
    /// Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`.
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, Var<Func<string,DatetimeHighlightStyle>> f) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<string,DatetimeHighlightStyle>>("highlightedDates"), f);
    }
    /// <summary>
    /// Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`.
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<string>,Var<DatetimeHighlightStyle>> f) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<string,DatetimeHighlightStyle>>("highlightedDates"), b.Def(f));
    }
    /// <summary>
    /// Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`.
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, Var<List<DatetimeHighlight>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<DatetimeHighlight>>("highlightedDates"), value);
    }
    /// <summary>
    /// Used to apply custom text and background colors to specific dates.  Can be either an array of objects containing ISO strings and colors, or a callback that receives an ISO string and returns the colors.  Only applies to the `date`, `date-time`, and `time-date` presentations, with `preferWheel="false"`.
    /// </summary>
    public static void SetHighlightedDates<T>(this PropsBuilder<T> b, List<DatetimeHighlight> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<DatetimeHighlight>>("highlightedDates"), b.Const(value));
    }

    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH11<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourCycle"), b.Const("h11"));
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH12<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourCycle"), b.Const("h12"));
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH23<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourCycle"), b.Const("h23"));
    }
    /// <summary>
    /// The hour cycle of the `ion-datetime`. If no value is set, this is specified by the current locale.
    /// </summary>
    public static void SetHourCycleH24<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hourCycle"), b.Const("h24"));
    }

    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, Var<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("hourValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, int value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("hourValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, Var<List<int>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("hourValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, List<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("hourValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable hours. By default the hour values range from `0` to `23` for 24-hour, or `1` to `12` for 12-hour. However, to control exactly which hours to display, the `hourValues` input can take a number, an array of numbers, or a string of comma separated numbers.
    /// </summary>
    public static void SetHourValues<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hourValues"), b.Const(value));
    }

    /// <summary>
    /// Returns if an individual date (calendar day) is enabled or disabled.  If `true`, the day will be enabled/interactive. If `false`, the day will be disabled/non-interactive.  The function accepts an ISO 8601 date string of a given day. By default, all days are enabled. Developers can use this function to write custom logic to disable certain days.  The function is called for each rendered calendar day, for the previous, current and next month. Custom implementations should be optimized for performance to avoid jank.
    /// </summary>
    public static void SetIsDateEnabled<T>(this PropsBuilder<T> b, Var<Func<string,bool>> f) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<string,bool>>("isDateEnabled"), f);
    }
    /// <summary>
    /// Returns if an individual date (calendar day) is enabled or disabled.  If `true`, the day will be enabled/interactive. If `false`, the day will be disabled/non-interactive.  The function accepts an ISO 8601 date string of a given day. By default, all days are enabled. Developers can use this function to write custom logic to disable certain days.  The function is called for each rendered calendar day, for the previous, current and next month. Custom implementations should be optimized for performance to avoid jank.
    /// </summary>
    public static void SetIsDateEnabled<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<string>,Var<bool>> f) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<string,bool>>("isDateEnabled"), b.Def(f));
    }

    /// <summary>
    /// The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device.
    /// </summary>
    public static void SetLocale<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("locale"), value);
    }
    /// <summary>
    /// The locale to use for `ion-datetime`. This impacts month and day name formatting. The `"default"` value refers to the default locale set by your device.
    /// </summary>
    public static void SetLocale<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("locale"), b.Const(value));
    }

    /// <summary>
    /// The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), value);
    }
    /// <summary>
    /// The maximum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the maximum could just be the year, such as `1994`. Defaults to the end of this year.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), b.Const(value));
    }

    /// <summary>
    /// The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), value);
    }
    /// <summary>
    /// The minimum datetime allowed. Value must be a date string following the [ISO 8601 datetime format standard](https://www.w3.org/TR/NOTE-datetime), such as `1996-12-19`. The format does not have to be specific to an exact datetime. For example, the minimum could just be the year, such as `1994`. Defaults to the beginning of the year, 100 years ago from today.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), b.Const(value));
    }

    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, Var<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minuteValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, int value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minuteValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, Var<List<int>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("minuteValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, List<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("minuteValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("minuteValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable minutes. By default the minutes range from `0` to `59`. However, to control exactly which minutes to display, the `minuteValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if the minute selections should only be every 15 minutes, then this input value would be `minuteValues="0,15,30,45"`.
    /// </summary>
    public static void SetMinuteValues<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("minuteValues"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, Var<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("monthValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, int value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("monthValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, Var<List<int>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("monthValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, List<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("monthValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("monthValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable months. By default the month values range from `1` to `12`. However, to control exactly which months to display, the `monthValues` input can take a number, an array of numbers, or a string of comma separated numbers. For example, if only summer months should be shown, then this input value would be `monthValues="6,7,8"`. Note that month numbers do *not* have a zero-based index, meaning January's value is `1`, and December's is `12`.
    /// </summary>
    public static void SetMonthValues<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("monthValues"), b.Const(value));
    }

    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }
    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), value);
    }
    /// <summary>
    /// If `true`, multiple dates can be selected at once. Only applies to `presentation="date"` and `preferWheel="false"`.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(value));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("preferWheel"), b.Const(true));
    }
    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("preferWheel"), value);
    }
    /// <summary>
    /// If `true`, a wheel picker will be rendered instead of a calendar grid where possible. If `false`, a calendar grid will be rendered instead of a wheel picker where possible.  A wheel picker can be rendered instead of a grid when `presentation` is one of the following values: `"date"`, `"date-time"`, or `"time-date"`.  A wheel picker will always be rendered regardless of the `preferWheel` value when `presentation` is one of the following values: `"time"`, `"month"`, `"month-year"`, or `"year"`.
    /// </summary>
    public static void SetPreferWheel<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("preferWheel"), b.Const(value));
    }

    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDate<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("date"));
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationDateTime<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("date-time"));
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonth<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("month"));
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationMonthYear<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("month-year"));
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTime<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("time"));
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationTimeDate<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("time-date"));
    }
    /// <summary>
    /// Which values you want to select. `"date"` will show a calendar picker to select the month, day, and year. `"time"` will show a time picker to select the hour, minute, and (optionally) AM/PM. `"date-time"` will show the date picker first and time picker second. `"time-date"` will show the time picker first and date picker second.
    /// </summary>
    public static void SetPresentationYear<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("presentation"), b.Const("year"));
    }

    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), value);
    }
    /// <summary>
    /// If `true`, the datetime appears normal but the selected date cannot be changed.
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showClearButton"), b.Const(true));
    }
    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showClearButton"), value);
    }
    /// <summary>
    /// If `true`, a "Clear" button will be rendered alongside the default "Cancel" and "OK" buttons at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowClearButton<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showClearButton"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultButtons"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultButtons"), value);
    }
    /// <summary>
    /// If `true`, the default "Cancel" and "OK" buttons will be rendered at the bottom of the `ion-datetime` component. Developers can also use the `button` slot if they want to customize these buttons. If custom buttons are set in the `button` slot then the default buttons will not be rendered.
    /// </summary>
    public static void SetShowDefaultButtons<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultButtons"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultTimeLabel"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultTimeLabel"), value);
    }
    /// <summary>
    /// If `true`, the default "Time" label will be rendered for the time selector of the `ion-datetime` component. Developers can also use the `time-label` slot if they want to customize this label. If a custom label is set in the `time-label` slot then the default label will not be rendered.
    /// </summary>
    public static void SetShowDefaultTimeLabel<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultTimeLabel"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultTitle"), b.Const(true));
    }
    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultTitle"), value);
    }
    /// <summary>
    /// If `true`, a header will be shown above the calendar picker. This will include both the slotted title, and the selected date.
    /// </summary>
    public static void SetShowDefaultTitle<T>(this PropsBuilder<T> b, bool value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showDefaultTitle"), b.Const(value));
    }

    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeCover<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("cover"));
    }
    /// <summary>
    /// If `cover`, the `ion-datetime` will expand to cover the full width of its container. If `fixed`, the `ion-datetime` will have a fixed width.
    /// </summary>
    public static void SetSizeFixed<T>(this PropsBuilder<T> b) where T: IonDatetime
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("fixed"));
    }

    /// <summary>
    /// A callback used to format the header text that shows how many dates are selected. Only used if there are 0 or more than 1 selected (i.e. unused for exactly 1). By default, the header text is set to "numberOfDates days".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetTitleSelectedDatesFormatter<T>(this PropsBuilder<T> b, Var<Func<List<string>,string>> f) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<List<string>,string>>("titleSelectedDatesFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the header text that shows how many dates are selected. Only used if there are 0 or more than 1 selected (i.e. unused for exactly 1). By default, the header text is set to "numberOfDates days".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetTitleSelectedDatesFormatter<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<List<string>>,Var<string>> f) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<List<string>,string>>("titleSelectedDatesFormatter"), b.Def(f));
    }

    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), value);
    }
    /// <summary>
    /// The value of the datetime as a valid ISO 8601 datetime string. This should be an array of strings only when `multiple="true"`.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, List<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), b.Const(value));
    }

    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, Var<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("yearValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, int value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("yearValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, Var<List<int>> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("yearValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, List<int> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("yearValues"), b.Const(value));
    }
    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, Var<string> value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("yearValues"), value);
    }
    /// <summary>
    /// Values used to create the list of selectable years. By default the year values range between the `min` and `max` datetime inputs. However, to control exactly which years to display, the `yearValues` input can take a number, an array of numbers, or string of comma separated numbers. For example, to show upcoming and recent leap years, then this input's value would be `yearValues="2008,2012,2016,2020,2024"`.
    /// </summary>
    public static void SetYearValues<T>(this PropsBuilder<T> b, string value) where T: IonDatetime
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("yearValues"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the datetime loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the datetime loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the datetime selection was cancelled.
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// Emitted when the datetime selection was cancelled.
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value (selected date) has changed.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DatetimeChangeEventDetail>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value (selected date) has changed.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DatetimeChangeEventDetail>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the datetime has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the datetime has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonDatetime
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

