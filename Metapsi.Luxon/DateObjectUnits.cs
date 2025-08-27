using Metapsi.Syntax;

namespace Metapsi.Luxon;

/// <summary>
/// 
/// </summary>
public interface DateObjectUnits
{
    /// <summary>
    /// a year, such as 1987
    /// </summary>
    int year { get; set; }
    /// <summary>
    /// a month, 1-12
    /// </summary>
    int month { get; set; }
    /// <summary>
    /// a day of the month, 1-31, depending on the month
    /// </summary>
    int day { get; set; }
    /// <summary>
    /// day of the year, 1-365 or 366
    /// </summary>
    int ordinal { get; set; }
    /// <summary>
    /// an ISO week year
    /// </summary>
    int weekYear { get; set; }
    /// <summary>
    /// a week year, according to the locale
    /// </summary>
    int localWeekYear { get; set; }
    /// <summary>
    /// an ISO week number, between 1 and 52 or 53, depending on the year
    /// </summary>
    int weekNumber { get; set; }
    /// <summary>
    /// a week number, between 1 and 52 or 53, depending on the year, according to the locale
    /// </summary>
    int localWeekNumber { get; set; }
    /// <summary>
    /// an ISO weekday, 1-7, where 1 is Monday and 7 is Sunday
    /// </summary>
    int weekday { get; set; }
    /// <summary>
    /// a weekday, 1-7, where 1 is the first day of the week, and 7 is the last, according to the locale
    /// </summary>
    int localWeekday { get; set; }
    /// <summary>
    /// hour of the day, 0-23
    /// </summary>
    int hour { get; set; }
    /// <summary>
    /// minute of the hour, 0-59
    /// </summary>
    int minute { get; set; }
    /// <summary>
    /// second of the minute, 0-59
    /// </summary>
    int second { get; set; }
    /// <summary>
    /// millisecond of the second, 0-999
    /// </summary>
    int millisecond { get; set; }
}

public class DateTimeOptions
{

}

public class ToRelativeOptions
{

}

public class ToRelativeCalendarOptions
{

}

public class DateTimeJSOptions
{

}

public class TokenParser
{

}

public class ExplainedFormat
{

}

public class ToISOTimeOptions
{

}

public class ToISODateOptions
{

}

public class ToSQLOptions
{

}

public class DiffOptions
{

}

public class DurationOptions
{

}

public class ToHumanDurationOptions
{

}

public class ToISOTimeDurationOptions
{

}

public class DurationFormatOptions
{

}

public class CountOptions
{

}

//public static class RandomSyntaxTests
//{
//    public static Var<string> T1(this SyntaxBuilder b)
//    {
//        var startDate = b.On(b.LuxonDateTime(), b => b.fromISO(b.Const("")));
//        var endDate = b.On(b.LuxonDateTime(), b => b.fromISO(b.Const("")));
//        var intervalIso =
//            b.On(
//            b.LuxonInterval(),
//            b => b.fromDateTimes(startDate, endDate).toISO());
//        return intervalIso;
//    }
//}