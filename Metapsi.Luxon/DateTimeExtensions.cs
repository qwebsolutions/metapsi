using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Metapsi.Luxon;

public class DateTime
{

}

public class Interval
{

}

public class Duration
{
    public decimal years { get; }
    public decimal quarters { get; }
    public decimal months { get; }
    public decimal weeks { get; }
    public decimal days { get; }
    public decimal hours { get; }
    public decimal minutes { get; }
    public decimal seconds { get; }
    public decimal milliseconds { get; }
}

public static class DateTimeExtensions
{
    private static void AddLuxon(this SyntaxBuilder b)
    {
        b.AddEmbeddedResourceMetadata(typeof(DateTimeExtensions).Assembly, "luxon.min.js");
        b.AddEmbeddedResourceMetadata(typeof(DateTimeExtensions).Assembly, "metapsi.luxon.js");
    }

    private static Var<object> DateTimeStatic(this SyntaxBuilder b)
    {
        b.AddLuxon();
        var get = b.ImportName<Func<object>>("metapsi.luxon.js", "getDateTimeStatic");
        return b.Call(get);
    }

    private static Var<object> IntervalStatic(this SyntaxBuilder b)
    {
        b.AddLuxon();
        var get = b.ImportName<Func<object>>("metapsi.luxon.js", "getIntervalStatic");
        return b.Call(get);
    }

    public static Var<DateTime> LuxonUtc(this SyntaxBuilder b)
    {
        return b.CallOnObject<DateTime>(b.DateTimeStatic(), "utc");
    }

    public static Var<DateTime> LuxonFromIso(this SyntaxBuilder b, Var<string> isoDateTime)
    {
        return b.CallOnObject<DateTime>(b.DateTimeStatic(), "fromISO", isoDateTime);
    }

    public static Var<Interval> LuxonIntervalFromDateTimes(this SyntaxBuilder b, Var<DateTime> start, Var<DateTime> end)
    {
        return b.CallOnObject<Interval>(b.IntervalStatic(), "fromDateTimes", start, end);
    }

    public static Var<Duration> LuxonIntervalToDuration(this SyntaxBuilder b, Var<Interval> interval)
    {
        return b.CallOnObject<Duration>(interval, "toDuration");
    }
    public static Var<Duration> LuxonIntervalToDuration(this SyntaxBuilder b, Var<Interval> interval, Var<string> unit)
    {
        return b.CallOnObject<Duration>(interval, "toDuration", unit);
    }

    public static Var<Duration> LuxonIntervalToDuration(this SyntaxBuilder b, Var<Interval> interval, Var<List<string>> units)
    {
        return b.CallOnObject<Duration>(interval, "toDuration", units);
    }

    public static Var<Duration> LuxonIntervalToDuration(this SyntaxBuilder b, Var<Interval> interval, List<string> units)
    {
        return b.LuxonIntervalToDuration(interval, b.Const(units));
    }

    public static Var<Duration> LuxonDurationNormalize(this SyntaxBuilder b, Var<Duration> duration)
    {
        return b.CallOnObject<Duration>(duration, "normalize");
    }

    public static Var<Duration> LuxonDurationRescale(this SyntaxBuilder b, Var<Duration> duration)
    {
        return b.CallOnObject<Duration>(duration, "rescale");
    }


    public static Var<string> LuxonDurationToHuman(this SyntaxBuilder b, Var<Duration> duration)
    {
        return b.CallOnObject<string>(duration, "toHuman");
    }

    public static Var<string> LuxonDurationToHuman(this SyntaxBuilder b, Var<Duration> duration, Var<object> options)
    {
        return b.CallOnObject<string>(duration, "toHuman", options);
    }

    public static Var<Duration> LuxonDurationShiftTo(this SyntaxBuilder b, Var<Duration> duration, params Var<string>[] units)
    {
        return b.CallOnObject<Duration>(duration, "shiftTo", units);
    }

    public static Var<Duration> LuxonDurationShiftTo(this SyntaxBuilder b, Var<Duration> duration, params string[] units)
    {
        return b.LuxonDurationShiftTo(duration, units.Select(x => b.Const(x)).ToArray());
    }

    public static Var<string> LuxonDateTimeToRelative(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toRelative");
    }

    public static Var<string> LuxonDateTimeToIso(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toISO");
    }
}
