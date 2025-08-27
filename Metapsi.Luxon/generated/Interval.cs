using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Luxon;

public static partial class IntervalExtensions
{
    public static ObjBuilder<DateTime> start(this ObjBuilder<Interval> b) 
    {
        return b.Get<DateTime>("start");
    }
    public static ObjBuilder<DateTime> end(this ObjBuilder<Interval> b) 
    {
        return b.Get<DateTime>("end");
    }
    public static ObjBuilder<DateTime> lastDateTime(this ObjBuilder<Interval> b) 
    {
        return b.Get<DateTime>("lastDateTime");
    }
    public static ObjBuilder<bool> isValid(this ObjBuilder<Interval> b) 
    {
        return b.Get<bool>("isValid");
    }
    public static ObjBuilder<string> invalidReason(this ObjBuilder<Interval> b) 
    {
        return b.Get<string>("invalidReason");
    }
    public static ObjBuilder<string> invalidExplanation(this ObjBuilder<Interval> b) 
    {
        return b.Get<string>("invalidExplanation");
    }
    public static ObjBuilder<Interval> invalid(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<string> reason) 
    {
        return b.Call<Interval>("invalid");
    }
    public static ObjBuilder<Interval> invalid(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<string> reason, Metapsi.Syntax.Var<string> explanation) 
    {
        return b.Call<Interval>("invalid");
    }
    public static ObjBuilder<Interval> fromDateTimes(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<DateTime> start, Metapsi.Syntax.Var<DateTime> end) 
    {
        return b.Call<Interval>("fromDateTimes");
    }
    public static ObjBuilder<Interval> after(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<DateTime> start, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<Interval>("after");
    }
    public static ObjBuilder<Interval> before(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<DateTime> end, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<Interval>("before");
    }
    public static ObjBuilder<Interval> fromISO(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<Interval>("fromISO");
    }
    public static ObjBuilder<Interval> fromISO(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DateTimeOptions> opts) 
    {
        return b.Call<Interval>("fromISO");
    }
    public static ObjBuilder<bool> isInterval(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<object> o) 
    {
        return b.Call<bool>("isInterval");
    }
    public static ObjBuilder<System.Collections.Generic.List<Interval>> merge(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Interval>> intervals) 
    {
        return b.Call<List>("merge");
    }
    public static ObjBuilder<System.Collections.Generic.List<Interval>> xor(this ObjBuilder<ClassDef<Interval>> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Interval>> intervals) 
    {
        return b.Call<List>("xor");
    }
    public static ObjBuilder<int> length(this ObjBuilder<Interval> b) 
    {
        return b.Call<int>("length");
    }
    public static ObjBuilder<int> length(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<int>("length");
    }
    public static ObjBuilder<Interval> count(this ObjBuilder<Interval> b) 
    {
        return b.Call<Interval>("count");
    }
    public static ObjBuilder<Interval> count(this ObjBuilder<Interval> b, string unit) 
    {
        return b.Call<Interval>("count", unit);
    }
    public static ObjBuilder<Interval> count(this ObjBuilder<Interval> b, string unit, CountOptions opts) 
    {
        return b.Call<Interval>("count", unit, opts);
    }
    public static ObjBuilder<bool> hasSame(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<bool>("hasSame");
    }
    public static ObjBuilder<bool> isEmpty(this ObjBuilder<Interval> b) 
    {
        return b.Call<bool>("isEmpty");
    }
    public static ObjBuilder<bool> isAfter(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<DateTime> dateTime) 
    {
        return b.Call<bool>("isAfter");
    }
    public static ObjBuilder<bool> isBefore(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<DateTime> dateTime) 
    {
        return b.Call<bool>("isBefore");
    }
    public static ObjBuilder<bool> contains(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<DateTime> dateTime) 
    {
        return b.Call<bool>("contains");
    }
    public static ObjBuilder<System.Collections.Generic.List<Interval>> splitAt(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<System.Collections.Generic.List<DateTime>> dateTimes) 
    {
        return b.Call<List>("splitAt");
    }
    public static ObjBuilder<System.Collections.Generic.List<Interval>> splitBy(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<List>("splitBy");
    }
    public static ObjBuilder<System.Collections.Generic.List<Interval>> divideEqually(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<int> numberOfParts) 
    {
        return b.Call<List>("divideEqually");
    }
    public static ObjBuilder<bool> overlaps(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<bool>("overlaps");
    }
    public static ObjBuilder<bool> abutsStart(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<bool>("abutsStart");
    }
    public static ObjBuilder<bool> abutsEnd(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<bool>("abutsEnd");
    }
    public static ObjBuilder<bool> engulfs(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<bool>("engulfs");
    }
    public static ObjBuilder<bool> equals(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<bool>("equals");
    }
    public static ObjBuilder<Interval> intersection(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<Interval>("intersection");
    }
    public static ObjBuilder<Interval> union(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Interval> other) 
    {
        return b.Call<Interval>("union");
    }
    public static ObjBuilder<System.Collections.Generic.List<Interval>> difference(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Interval>> intervals) 
    {
        return b.Call<List>("difference");
    }
    public static ObjBuilder<string> toString(this ObjBuilder<Interval> b) 
    {
        return b.Call<string>("toString");
    }
    public static ObjBuilder<string> toLocaleString(this ObjBuilder<Interval> b) 
    {
        return b.Call<string>("toLocaleString");
    }
    public static ObjBuilder<string> toLocaleString(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> formatOpts) 
    {
        return b.Call<string>("toLocaleString");
    }
    public static ObjBuilder<string> toLocaleString(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> formatOpts, Metapsi.Syntax.Var<LocaleOptions> opts) 
    {
        return b.Call<string>("toLocaleString");
    }
    public static ObjBuilder<string> toISO(this ObjBuilder<Interval> b) 
    {
        return b.Call<string>("toISO");
    }
    public static ObjBuilder<string> toISO(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<ToISOTimeOptions> opts) 
    {
        return b.Call<string>("toISO");
    }
    public static ObjBuilder<string> toISODate(this ObjBuilder<Interval> b) 
    {
        return b.Call<string>("toISODate");
    }
    public static ObjBuilder<string> toISOTime(this ObjBuilder<Interval> b) 
    {
        return b.Call<string>("toISOTime");
    }
    public static ObjBuilder<string> toISOTime(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<ToISOTimeOptions> opts) 
    {
        return b.Call<string>("toISOTime");
    }
    public static ObjBuilder<string> toFormat(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<string> dateFormat) 
    {
        return b.Call<string>("toFormat");
    }
    public static ObjBuilder<string> toFormat(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<string> dateFormat, Metapsi.Syntax.Var<object> opts) 
    {
        return b.Call<string>("toFormat");
    }
    public static ObjBuilder<Duration> toDuration(this ObjBuilder<Interval> b, string unit) 
    {
        return b.Call<Duration>("toDuration");
    }
    public static ObjBuilder<Duration> count(this ObjBuilder<Interval> b, System.Collections.Generic.Dictionary<string> unit) 
    {
        return b.Call<Duration>("toDuration", unit);
    }
    public static ObjBuilder<Interval> count(this ObjBuilder<Interval> b, string unit, DiffOptions opts) 
    {
        return b.Call<Interval>("toDuration", unit, opts);
    }
    public static ObjBuilder<Duration> mapEndpoints(this ObjBuilder<Interval> b, Metapsi.Syntax.Var<System.Func<DateTime, DateTime>> mapFn) 
    {
        return b.Call<Duration>("mapEndpoints", mapFn);
    }
}