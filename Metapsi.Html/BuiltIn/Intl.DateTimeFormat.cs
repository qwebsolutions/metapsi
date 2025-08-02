using Metapsi.Syntax;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Metapsi.Html;

/// <summary>
/// The Intl namespace object contains several constructors as well as functionality common to the internationalization constructors and other language sensitive functions.
/// </summary>
public static partial class Intl
{
    /// <summary>
    /// The Intl.DateTimeFormat object enables language-sensitive date and time formatting.
    /// </summary>
    public interface DateTimeFormat
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public class DateTimeFormatOptions
    {
        /// <summary>
        /// The locale matching algorithm to use. Possible values are "lookup" and "best fit"; the default is "best fit"
        /// </summary>
        public string localeMatcher { get; set; }

        /// <summary>
        /// The calendar to use, such as "chinese", "gregory", "persian", and so on. 
        /// </summary>
        public string calendar { get; set; }

        /// <summary>
        /// The numbering system to use for number formatting, such as "arab", "hans", "mathsans", and so on.
        /// </summary>
        public string numberingSystem { get; set; }

        /// <summary>
        /// Whether to use 12-hour time (as opposed to 24-hour time). Possible values are true and false; the default is locale dependent. When true, this option sets hourCycle to either "h11" or "h12", depending on the locale. When false, it sets hourCycle to "h23". hour12 overrides both the hc locale extension tag and the hourCycle option, should either or both of those be present.
        /// </summary>
        public bool? hour12 { get; set; }

        /// <summary>
        /// The hour cycle to use. Possible values are "h11", "h12", "h23", and "h24". This option can also be set through the hc Unicode extension key; if both are provided, this options property takes precedence.
        /// </summary>
        public string hourCycle { get; set; }

        /// <summary>
        /// The time zone to use. Time zone names correspond to the Zone and Link names of the IANA Time Zone Database, such as "UTC", "Asia/Shanghai", "Asia/Kolkata", and "America/New_York". Additionally, time zones can be given as UTC offsets in the format "±hh:mm", "±hhmm", or "±hh", for example as "+01:00", "-2359", or "+23". The default is the runtime's default time zone.
        /// </summary>
        public string timeZone { get; set; }

        /// <summary>
        /// The representation of the weekday.Possible values are:
        /// <para>"long" E.g., Thursday</para>
        /// <para>"short" E.g., Thu </para>
        /// <para>"narrow" E.g., T.Two weekdays may have the same narrow style for some locales(e.g., Tuesday's narrow style is also T).</para>
        /// </summary>
        public string weekday { get; set; }

        /// <summary>
        /// The representation of the era.Possible values are:
        /// <para>"long" E.g., Anno Domini </para>
        /// <para>"short" E.g., AD</para>
        /// <para>"narrow" E.g., A </para>
        /// </summary>
        public string era { get; set; }

        /// <summary>
        /// The representation of the year. Possible values are "numeric" and "2-digit".
        /// </summary>
        public string year { get; set; }

        /// <summary>
        /// The representation of the month.Possible values are:
        /// <para>"numeric" E.g., 3</para>
        /// <para>"2-digit" E.g., 03</para>
        /// <para>"long" E.g., March</para>
        /// <para>"short" E.g., Mar </para>
        /// <para>"narrow" E.g., M. Two months may have the same narrow style for some locales(e.g., May's narrow style is also M).</para>
        /// </summary>
        public string month { get; set; }

        /// <summary>
        /// The representation of the day. Possible values are "numeric" and "2-digit".
        /// </summary>
        public string day { get; set; }

        /// <summary>
        /// The formatting style used for day periods like "in the morning", "am", "noon", "n" etc. Possible values are "narrow", "short", and "long".
        /// </summary>
        public string dayPeriod { get; set; }

        /// <summary>
        /// The representation of the hour. Possible values are "numeric" and "2-digit".
        /// </summary>
        public string hour { get; set; }

        /// <summary>
        /// The representation of the minute. Possible values are "numeric" and "2-digit".
        /// </summary>
        public string minute { get; set; }

        /// <summary>
        /// The representation of the second. Possible values are "numeric" and "2-digit".
        /// </summary>
        public string second { get; set; }

        /// <summary>
        /// The number of digits used to represent fractions of a second (any additional digits are truncated). Possible values are from 1 to 3.
        /// </summary>
        public int? fractionalSecondDigits { get;set; }

        /// <summary>
        /// The localized representation of the time zone name. Possible values are:
        /// <para>"long" Long localized form(e.g., Pacific Standard Time, Nordamerikanische Westküsten-Normalzeit)</para>
        /// <para>"short" Short localized form(e.g.: PST, GMT-8)</para>
        /// <para>"shortOffset" Short localized GMT format(e.g., GMT-8) </para>
        /// <para>"longOffset" Long localized GMT format(e.g., GMT-08:00)</para>
        /// <para>"shortGeneric" Short generic non-location format(e.g.: PT, Los Angeles Zeit).</para>
        /// <para>"longGeneric" Long generic non-location format(e.g.: Pacific Time, Nordamerikanische Westküstenzeit)</para>
        /// </summary>
        public string timeZoneName { get; set; }

        /// <summary>
        /// The format matching algorithm to use. Possible values are "basic" and "best fit"; the default is "best fit"
        /// </summary>
        public string formatMatcher { get; set; }

        /// <summary>
        /// The date formatting style to use. Possible values are "full", "long", "medium", and "short". It expands to styles for weekday, day, month, year, and era, with the exact combination of values depending on the locale.
        /// </summary>
        public string dateStyle { get; set; }

        /// <summary>
        /// The time formatting style to use. Possible values are "full", "long", "medium", and "short". It expands to styles for hour, minute, second, and timeZoneName, with the exact combination of values depending on the locale.
        /// </summary>
        public string timeStyle { get; set; }
    }

    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b)
    {
        return b.New<Intl.DateTimeFormat>();
    }


    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag or an Intl.Locale instance, or an array of such locale identifiers. </param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b, Var<string> locales)
    {
        return b.New<Intl.DateTimeFormat>(locales);
    }

    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag or an Intl.Locale instance, or an array of such locale identifiers. </param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b, Var<Locale> locales)
    {
        return b.New<Intl.DateTimeFormat>(locales);
    }

    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag or an Intl.Locale instance, or an array of such locale identifiers. </param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b, Var<List<Locale>> locales)
    {
        return b.New<Intl.DateTimeFormat>(locales);
    }

    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag or an Intl.Locale instance, or an array of such locale identifiers. </param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b, Var<string> locales, Var<DateTimeFormatOptions> options)
    {
        return b.New<Intl.DateTimeFormat>(locales);
    }

    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag or an Intl.Locale instance, or an array of such locale identifiers. </param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b, Var<Locale> locales, Var<DateTimeFormatOptions> options)
    {
        return b.New<Intl.DateTimeFormat>(locales);
    }

    /// <summary>
    /// The Intl.DateTimeFormat() constructor creates Intl.DateTimeFormat objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag or an Intl.Locale instance, or an array of such locale identifiers. </param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<DateTimeFormat> NewIntlDateTimeFormat(this SyntaxBuilder b, Var<List<Locale>> locales, Var<DateTimeFormatOptions> options)
    {
        return b.New<Intl.DateTimeFormat>(locales);
    }
}
