using Metapsi.Html;
using Metapsi.Syntax;
using System;

namespace Metapsi.Luxon;

/// <summary>
///  "year" | "quarter" | "month" | "week" | "day" | "hour" | "minute" | "second" | "millisecond";
/// </summary>
public enum DateTimeUnit
{
    /// <summary>
    /// 
    /// </summary>
    Year,
    /// <summary>
    /// 
    /// </summary>
    Quarter,
    /// <summary>
    /// 
    /// </summary>
    Month,
    /// <summary>
    /// 
    /// </summary>
    Week,
    /// <summary>
    /// 
    /// </summary>
    Day,
    /// <summary>
    /// 
    /// </summary>
    Hour,
    /// <summary>
    /// 
    /// </summary>
    Minute,
    /// <summary>
    /// 
    /// </summary>
    Second,
    /// <summary>
    /// 
    /// </summary>
    Millisecond
}

/// <summary>
/// A DateTime is an immutable data structure representing a specific date and time and accompanying methods. It contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
/// </summary>
public abstract class DateTime
{
    /// <summary>
    /// Returns whether the DateTime is valid. Invalid DateTimes occur when:
    /// <para> The DateTime was created from invalid calendar information, such as the 13th month or February 30</para>
    /// <para> The DateTime was created by an operation on another invalid date</para>
    /// </summary>
    public bool isValid { get; }

    /// <summary>
    /// Returns an error code if this DateTime is invalid, or null if the DateTime is valid
    /// </summary>
    public string invalidReason { get; }

    /// <summary>
    /// Returns an explanation of why this DateTime became invalid, or null if the DateTime is valid
    /// </summary>
    public string invalidExplanation { get; }

    /// <summary>
    /// Get the locale of a DateTime, such as 'en-GB'. The locale is used when formatting the DateTime
    /// </summary>
    public string locale { get; }

    /// <summary>
    /// Get the numbering system of a DateTime, such as 'beng'. The numbering system is used when formatting the DateTime
    /// </summary>
    public string numberingSystem { get; }

    /// <summary>
    /// Get the output calendar of a DateTime, such as 'islamic'. The output calendar is used when formatting the DateTime
    /// </summary>
    public string outputCalendar { get; }

    /// <summary>
    /// Get the time zone associated with this DateTime.
    /// </summary>
    public Zone zone { get; }

    /// <summary>
    /// Get the name of the time zone.
    /// </summary>
    public string zoneName { get; }

    /// <summary>
    /// Get the year
    /// </summary>
    public int year { get; }

    /// <summary>
    /// Get the quarter
    /// </summary>
    public int quarter { get; }

    /// <summary>
    ///  Get the month (1-12).
    /// </summary>
    public int month { get; }

    /// <summary>
    /// Get the day of the month (1-30ish).
    /// </summary>
    public int day { get; }

    /// <summary>
    /// Get the hour of the day (0-23).
    /// </summary>
    public int hour { get; }

    /// <summary>
    /// Get the minute of the hour (0-59).
    /// </summary>
    public int minute { get; }

    /// <summary>
    /// Get the second of the minute (0-59).
    /// </summary>
    public int second { get; }

    /// <summary>
    /// Get the millisecond of the second (0-999).
    /// </summary>
    public int millisecond { get; }

    /// <summary>
    /// Get the week year <see href="https://en.wikipedia.org/wiki/ISO_week_date"></see>
    /// </summary>
    public int weekYear { get; }

    /// <summary>
    /// Get the week number of the week year (1-52ish). <see href="https://en.wikipedia.org/wiki/ISO_week_date"></see>
    /// </summary>
    public int weekNumber { get; }

    /// <summary>
    /// Get the day of the week. 1 is Monday and 7 is Sunday. <see href="https://en.wikipedia.org/wiki/ISO_week_date"></see>
    /// </summary>
    public int weekday { get; }

    /// <summary>
    /// Returns true if this date is on a weekend, according to the locale, false otherwise
    /// </summary>
    public bool isWeekend { get; }

    /// <summary>
    /// Get the day of the week, according to the locale. 1 is the first day of the week, and 7 is the last day of the week. If the locale assigns Sunday as the first day of the week, then a date which is a Sunday will return 1.
    /// </summary>
    public int localWeekday { get; }

    /// <summary>
    ///  Get the week number of the week year, according to the locale. Different locales assign week numbers differently. The week can start on different days of the week (<see cref="localWeekday"/>), and because a different number of days is required for a week to count as the first week of a year.
    /// </summary>
    public int localWeekNumber { get; }

    /// <summary>
    /// Get the week year, according to the locale. Different locales assign week numbers(and therefore week years) differently <see cref="localWeekNumber"/>
    /// </summary>
    public int localWeekYear { get; }

    /// <summary>
    /// Get the ordinal (meaning the day of the year)
    /// </summary>
    public int ordinal { get; }

    /// <summary>
    /// Get the human readable short month name, such as 'Oct'. Defaults to the system's locale if no locale has been specified
    /// </summary>
    public string monthShort { get; }

    /// <summary>
    /// Get the human readable long month name, such as 'October'. Defaults to the system's locale if no locale has been specified
    /// </summary>
    public string monthLong { get; }

    /// <summary>
    /// Get the human readable short weekday, such as 'Mon'. Defaults to the system's locale if no locale has been specified
    /// </summary>
    public string weekdayShort { get; }

    /// <summary>
    /// Get the human readable long weekday, such as 'Monday'.  Defaults to the system's locale if no locale has been specified
    /// </summary>
    public string weekdayLong { get; }

    /// <summary>
    /// Get the UTC offset of this DateTime in minutes
    /// </summary>
    public int offset { get; }

    /// <summary>
    /// Get the short human name for the zone's current offset, for example "EST" or "EDT". Defaults to the system's locale if no locale has been specified
    /// </summary>
    public string offsetNameShort { get; }

    /// <summary>
    /// Get the long human name for the zone's current offset, for example "Eastern Standard Time" or "Eastern Daylight Time". Defaults to the system's locale if no locale has been specified
    /// </summary>
    public string offsetNameLong { get; }

    /// <summary>
    /// Get whether this zone's offset ever changes, as in a DST.
    /// </summary>
    public bool isOffsetFixed { get; }

    /// <summary>
    /// Get whether the DateTime is in a DST.
    /// </summary>
    public bool isInDST { get; }

    /// <summary>
    /// Returns true if this DateTime is in a leap year, false otherwise
    /// </summary>
    public bool isInLeapYear { get; }

    /// <summary>
    /// Returns the number of days in this DateTime's month
    /// </summary>
    public int daysInMonth { get; }

    /// <summary>
    /// Returns the number of days in this DateTime's year
    /// </summary>
    public int daysInYear { get; }

    /// <summary>
    /// Returns the number of weeks in this DateTime's year
    /// </summary>
    public int weeksInWeekYear { get; }

    /// <summary>
    /// Returns the number of weeks in this DateTime's local week year
    /// </summary>
    public int weeksInLocalWeekYear { get; }

    public static bool operator <(DateTime left, DateTime right)
    {
        throw new System.Exception("Client-side only");
    }

    public static bool operator >(DateTime left, DateTime right)
    {
        throw new System.Exception("Client-side only");
    }

    public static bool operator <=(DateTime left, DateTime right)
    {
        throw new System.Exception("Client-side only");
    }

    public static bool operator >=(DateTime left, DateTime right)
    {
        throw new System.Exception("Client-side only");
    }
}

/// <summary>
/// The reference to the Luxon DateTime class itself, for static calls
/// </summary>
public interface DateTimeClass
{
    // FORMAT PRESETS

    /// <summary>
    /// format like 10/14/1983
    /// </summary>
    Intl.DateTimeFormatOptions DATE_SHORT { get; }

    /// <summary>
    /// format like 'Oct 14, 1983'
    /// </summary>
    Intl.DateTimeFormatOptions DATE_MED { get; }

    /// <summary>
    /// format like 'Fri, Oct 14, 1983'
    /// </summary>
    Intl.DateTimeFormatOptions DATE_MED_WITH_WEEKDAY { get; }

    /// <summary>
    /// format like 'October 14, 1983'
    /// </summary>
    Intl.DateTimeFormatOptions DATE_FULL { get; }

    /// <summary>
    /// format like 'Tuesday, October 14, 1983'
    /// </summary>
    Intl.DateTimeFormatOptions DATE_HUGE { get; }

    /// <summary>
    /// format like '09:30 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_SIMPLE { get; }


    /// <summary>
    /// format like '09:30:23 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_WITH_SECONDS { get; }
    
    /// <summary>
    /// format like '09:30:23 AM EDT'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_WITH_SHORT_OFFSET { get; }
    
    /// <summary>
    /// format like '09:30:23 AM Eastern Daylight Time'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_WITH_LONG_OFFSET { get; }

    /// <summary>
    /// format like '09:30', always 24-hour.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_24_SIMPLE { get; }
    
    /// <summary>
    /// format like '09:30:23', always 24-hour.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_24_WITH_SECONDS { get; }
    
    /// <summary>
    /// format like '09:30:23 EDT', always 24-hour.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_24_WITH_SHORT_OFFSET { get; }

    /// <summary>
    /// format like '09:30:23 Eastern Daylight Time', always 24-hour.
    /// </summary>
    Intl.DateTimeFormatOptions TIME_24_WITH_LONG_OFFSET { get; }
    
    /// <summary>
    /// format like '10/14/1983, 9:30 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_SHORT { get; }
    
    /// <summary>
    /// format like '10/14/1983, 9:30:33 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_SHORT_WITH_SECONDS { get; }
    
    /// <summary>
    /// format like 'Oct 14, 1983, 9:30 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_MED { get; }

    /// <summary>
    /// format like 'Oct 14, 1983, 9:30:33 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_MED_WITH_SECONDS { get; }
    
    /// <summary>
    /// format like 'Fri, 14 Oct 1983, 9:30 AM'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_MED_WITH_WEEKDAY { get; }

    /// <summary>
    /// format like 'October 14, 1983, 9:30 AM EDT'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_FULL { get; }

    /// <summary>
    /// format like 'October 14, 1983, 9:30:33 AM EDT'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_FULL_WITH_SECONDS { get; }

    /// <summary>
    /// format like 'Friday, October 14, 1983, 9:30 AM Eastern Daylight Time'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_HUGE { get; }

    /// <summary>
    ///    format like 'Friday, October 14, 1983, 9:30:33 AM Eastern Daylight Time'. Only 12-hour if the locale is.
    /// </summary>
    Intl.DateTimeFormatOptions DATETIME_HUGE_WITH_SECONDS { get; }
}

public static partial class DateTimeExtensions
{
    // STATIC

    /// <summary>
    /// Returns the reference to the Luxon DateTime class itself. Use it for static calls
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<Luxon.DateTimeClass> LuxonDateTime(this SyntaxBuilder b)
    {
        b.AddLuxon();
        var dateTimeClass = b.ImportName<DateTimeClass>("luxon.min.js", "DateTime");
        return dateTimeClass;
    }

    /// <summary>
    /// Create a DateTime for the current instant, in the system's time zone.
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeNow(this SyntaxBuilder b)
    {
        return b.CallOnObject<DateTime>(b.LuxonDateTime(), "now");
    }

    /// <summary>
    /// Create a local DateTime
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeLocal(this SyntaxBuilder b)
    {
        return b.CallOnObject<DateTime>(b.LuxonDateTime(), "local");
    }

    /// <summary>
    /// Create a DateTime in UTC
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeUtc(this SyntaxBuilder b)
    {
        return b.CallOnObject<DateTime>(b.LuxonDateTime(), "utc");
    }

    /// <summary>
    /// Create a DateTime from an ISO 8601 string
    /// </summary>
    /// <param name="b"></param>
    /// <param name="isoDateTime"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeFromIso(this SyntaxBuilder b, Var<string> isoDateTime)
    {
        return b.CallOnObject<DateTime>(b.LuxonDateTime(), "fromISO", isoDateTime);
    }

    /// <summary>
    /// Return the min of several date times
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTimes"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeMin(this SyntaxBuilder b, params Var<DateTime>[] dateTimes)
    {
        return b.CallOnObject<DateTime>(b.LuxonDateTime(), "min", dateTimes);
    }

    /// <summary>
    /// Return the max of several date times
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTimes"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeMax(this SyntaxBuilder b, params Var<DateTime>[] dateTimes)
    {
        return b.CallOnObject<DateTime>(b.LuxonDateTime(), "max", dateTimes);
    }

    // INSTANCE

    /// <summary>
    /// Get the value of unit.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="unit">unit (string) a unit such as 'minute' or 'day' </param>
    /// <returns></returns>
    public static Var<int> LuxonDateTimeGet(this SyntaxBuilder b, Var<DateTime> dateTime, Var<string> unit)
    {
        return b.CallOnObject<int>(dateTime, "get", unit);
    }

    /// <summary>
    /// "Set" the DateTime's zone to UTC. Returns a newly-constructed DateTime. Equivalent to <see cref="LuxonDateTimeSetZone"/>("utc")
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeToUtc(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<DateTime>(dateTime, "toUTC");
    }

    /// <summary>
    /// "Set" the DateTime's zone to the host's local zone. Returns a newly-constructed DateTime. Equivalent to `setZone('local')`
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeToLocal(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<DateTime>(dateTime, "toLocal");
    }

    /// <summary>
    /// "Set" the values of specified units. Returns a newly-constructed DateTime.
    /// <para> You can only set units with this method; for "setting" metadata, see <see cref="LuxonDateTimeReconfigure"/> and <see cref="LuxonDateTimeSetZone"/></para>
    /// <para> This method also supports setting locale-based week units, i.e. `localWeekday`, `localWeekNumber` and `localWeekYear`.</para>
    /// <para> They cannot be mixed with ISO-week units like `weekday`.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeSet(this SyntaxBuilder b, Var<DateTime> dateTime, Var<DateObjectUnits> values)
    {
        return b.CallOnObject<DateTime>(dateTime, "set", values);
    }

    /// <summary>
    /// "Set" the values of specified units. Returns a newly-constructed DateTime.
    /// <para> You can only set units with this method; for "setting" metadata, see <see cref="LuxonDateTimeReconfigure"/> and <see cref="LuxonDateTimeSetZone"/></para>
    /// <para> This method also supports setting locale-based week units, i.e. `localWeekday`, `localWeekNumber` and `localWeekYear`.</para>
    /// <para> They cannot be mixed with ISO-week units like `weekday`.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeSet(this SyntaxBuilder b, Var<DateTime> dateTime, Action<PropsBuilder<DateObjectUnits>> values)
    {
        return b.CallOnObject<DateTime>(dateTime, "set", b.SetProps(b.NewObj(), values));
    }

    /// <summary>
    ///  "Set" the locale, numberingSystem, or outputCalendar. Returns a newly-constructed DateTime.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="properties"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeReconfigure(this SyntaxBuilder b, Var<DateTime> dateTime, Var<LocaleOptions> properties)
    {
        return b.CallOnObject<DateTime>(dateTime, "reconfigure", properties);
    }


    /// <summary>
    ///  "Set" the DateTime's zone to specified zone. Returns a newly-constructed DateTime.
    ///  <para> By default, the setter keeps the underlying time the same (as in, the same timestamp), but the new instance will report different local times and consider DSTs when making computations, as with {@link DateTime.plus}. You may wish to use <see cref="LuxonDateTimeToLocal(SyntaxBuilder, Var{DateTime})"/> and <see cref="LuxonDateTimeToUtc(SyntaxBuilder, Var{DateTime})"/> which provide simple convenience wrappers for commonly used zones.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="zone"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeSetZone(this SyntaxBuilder b, Var<DateTime> dateTime, Var<string> zone)
    {
        return b.CallOnObject<DateTime>(dateTime, "setZone", zone);
    }

    /// <summary>
    /// "Set" the locale. Returns a newly-constructed DateTime.  Just a convenient alias for reconfigure({ locale })
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="locale"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeSetLocale(this SyntaxBuilder b, Var<DateTime> dateTime, Var<string> locale)
    {
        return b.CallOnObject<DateTime>(dateTime, "setLocale", locale);
    }

    /// <summary>
    /// Adding hours, minutes, seconds, or milliseconds increases the timestamp by the right number of milliseconds. Adding days, months, or years shifts the calendar, accounting for DSTs and leap years along the way.Thus, `dt.plus({ hours: 24 })` may result in a different time than `dt.plus({ days: 1 })` if there's a DST shift in between.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="duration"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimePlus(this SyntaxBuilder b, Var<DateTime> dateTime, Var<Duration> duration)
    {
        return b.CallOnObject<DateTime>(dateTime, "plus", duration);
    }

    /// <summary>
    /// <see cref="LuxonDateTimePlus(SyntaxBuilder, Var{DateTime}, Var{Duration})"/>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="duration"></param>
    /// <returns></returns>
    public static Var<DateTime> LuxonDateTimeMinus(this SyntaxBuilder b, Var<DateTime> dateTime, Var<Duration> duration)
    {
        return b.CallOnObject<DateTime>(dateTime, "minus", duration);
    }

    /// <summary>
    /// "Set" this DateTime to the beginning of the given unit.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="unit">The unit to go to the beginning of. Can be 'year', 'quarter', 'month', 'week', 'day', 'hour', 'minute', 'second', or 'millisecond'.</param>
    /// <returns></returns>
    /// <remarks>    
    /// <code> DateTime.local(2014, 3, 3).startOf('month').toISODate(); //=> '2014-03-01'</code>
    /// <code> DateTime.local(2014, 3, 3).startOf('year').toISODate(); //=> '2014-01-01' </code>
    /// <code> DateTime.local(2014, 3, 3).startOf('week').toISODate(); //=> '2014-03-03', weeks always start on Mondays</code>
    /// <code> DateTime.local(2014, 3, 3, 5, 30).startOf('day').toISOTime(); //=> '00:00.000-05:00'</code>
    /// <code> DateTime.local(2014, 3, 3, 5, 30).startOf('hour').toISOTime(); //=> '05:00:00.000-05:00'</code></remarks>
    public static Var<DateTime> LuxonDateTimeStartOf(this SyntaxBuilder b, Var<DateTime> dateTime, Var<DateTimeUnit> unit)
    {
        return b.CallOnObject<DateTime>(dateTime, "startOf", b.EnumToLowercase(unit));
    }

    /// <summary>
    /// Set" this DateTime to the end (meaning the last millisecond) of a unit of time
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="unit"> The unit to go to the end of. Can be 'year', 'quarter', 'month', 'week', 'day', 'hour', 'minute', 'second', or 'millisecond'.</param>
    /// <returns></returns>
    /// <remarks>
    /// <code>DateTime.local(2014, 3, 3).endOf('month').toISO(); //=> '2014-03-31T23:59:59.999-05:00'</code>
    /// <code>DateTime.local(2014, 3, 3).endOf('year').toISO(); //=> '2014-12-31T23:59:59.999-05:00'</code>
    /// <code>DateTime.local(2014, 3, 3).endOf('week').toISO(); // => '2014-03-09T23:59:59.999-05:00', weeks start on Mondays</code>
    /// <code>DateTime.local(2014, 3, 3, 5, 30).endOf('day').toISO(); //=> '2014-03-03T23:59:59.999-05:00'</code>
    /// <code>DateTime.local(2014, 3, 3, 5, 30).endOf('hour').toISO(); //=> '2014-03-03T05:59:59.999-05:00'</code>
    /// </remarks>
    public static Var<DateTime> LuxonDateTimeEndOf(this SyntaxBuilder b, Var<DateTime> dateTime, Var<DateTimeUnit> unit)
    {
        return b.CallOnObject<DateTime>(dateTime, "endOf", b.EnumToLowercase(unit));
    }

    public static Var<string> LuxonDateTimeToRelative(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toRelative");
    }

    /// <summary>
    ///  Returns an ISO 8601-compliant string representation of this DateTime
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    /// <remarks><code>DateTime.utc(1982, 5, 25).toISO() //=> '1982-05-25T00:00:00.000Z'</code></remarks>
    public static Var<string> LuxonDateTimeToIso(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toISO");
    }

    /// <summary>
    /// Returns an ISO 8601-compliant string representation of this DateTime's date component
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    /// <remarks><code>DateTime.utc(1982, 5, 25).toISODate() //=> '1982-05-25'</code></remarks>
    public static Var<string> LuxonDateTimeToIsoDate(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toISODate");
    }

    /// <summary>
    /// Returns a localized string representing this date. Accepts the same options as the <see cref="Intl.DateTimeFormat"/> constructor and any presets defined by Luxon, such as `DateTime.DATE_FULL` or `DateTime.TIME_SIMPLE` of the DateTime in the assigned locale. Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static Var<string> LuxonDateTimeToLocaleString(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toLocaleString");
    }

    /// <summary>
    /// Returns a localized string representing this date. Accepts the same options as the <see cref="Intl.DateTimeFormat"/> constructor and any presets defined by Luxon, such as `DateTime.DATE_FULL` or `DateTime.TIME_SIMPLE` of the DateTime in the assigned locale. Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <param name="b"></param>
    /// <param name="dateTime"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<string> LuxonDateTimeToLocaleString(this SyntaxBuilder b, Var<DateTime> dateTime, Var<Intl.DateTimeFormatOptions> options)
    {
        return b.CallOnObject<string>(dateTime, "toLocaleString", options);
    }

    /// <summary>
    /// Converts a Luxon weekday into a System.DayOfWeek. 
    /// <para>In Luxon, Monday = 1, Sunday = 7</para>
    /// <para>In C#, Sunday=0, Saturday = 6</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="luxonDayOfWeek"></param>
    /// <returns></returns>
    public static Var<System.DayOfWeek> LuxonWeekdayToSystemDayOfWeek(this SyntaxBuilder b, Var<int> luxonDayOfWeek)
    {
        return b.Get(luxonDayOfWeek, x => x % 7).As<System.DayOfWeek>();
    }

    /// <summary>
    /// Converts a System.DayOfWeek to a Luxon weekday
    /// <para>In Luxon, Monday = 1, Sunday = 7</para>
    /// <para>In C#, Sunday=0, Saturday = 6</para>
    /// </summary>
    public static Var<int> SystemDayOfWeekToLuxonWeekday(this SyntaxBuilder b, Var<System.DayOfWeek> systemDayOfWeek)
    {
        return b.If(b.AreEqual(systemDayOfWeek, b.Const(System.DayOfWeek.Sunday)), b => b.Const(7), b => systemDayOfWeek.As<int>());
    }

}