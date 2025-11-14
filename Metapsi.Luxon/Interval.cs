using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Luxon;

public class IntervalClass
{

}

public class Interval
{

}

/// <summary>
/// 
/// </summary>
public static partial class IntervalExtensions
{
    ///// <summary>
    ///// Returns the reference to the Luxon Interval class itself. Use it for static calls
    ///// </summary>
    ///// <param name="b"></param>
    ///// <returns></returns>
    //public static Var<Luxon.IntervalClass> LuxonInterval(this SyntaxBuilder b)
    //{
    //    b.AddLuxon();
    //    var dateTimeClass = b.ImportName<IntervalClass>("luxon.min.js", "Interval");
    //    return dateTimeClass;
    //}

    public static Var<Interval> LuxonIntervalFromDateTimes(this SyntaxBuilder b, Var<DateTime> start, Var<DateTime> end)
    {
        return b.CallOnObject<Interval>(b.LuxonInterval(), "fromDateTimes", start, end);
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
}