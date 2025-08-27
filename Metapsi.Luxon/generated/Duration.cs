using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Luxon;

public static partial class DurationExtensions
{
    public static ObjBuilder<string> locale(this ObjBuilder<Duration> b) 
    {
        return b.Get<string>("locale");
    }
    public static ObjBuilder<string> numberingSystem(this ObjBuilder<Duration> b) 
    {
        return b.Get<string>("numberingSystem");
    }
    public static ObjBuilder<int> years(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("years");
    }
    public static ObjBuilder<int> quarters(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("quarters");
    }
    public static ObjBuilder<int> months(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("months");
    }
    public static ObjBuilder<int> weeks(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("weeks");
    }
    public static ObjBuilder<int> days(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("days");
    }
    public static ObjBuilder<int> hours(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("hours");
    }
    public static ObjBuilder<int> minutes(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("minutes");
    }
    public static ObjBuilder<int> seconds(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("seconds");
    }
    public static ObjBuilder<int> milliseconds(this ObjBuilder<Duration> b) 
    {
        return b.Get<int>("milliseconds");
    }
    public static ObjBuilder<bool> isValid(this ObjBuilder<Duration> b) 
    {
        return b.Get<bool>("isValid");
    }
    public static ObjBuilder<string> invalidReason(this ObjBuilder<Duration> b) 
    {
        return b.Get<string>("invalidReason");
    }
    public static ObjBuilder<string> invalidExplanation(this ObjBuilder<Duration> b) 
    {
        return b.Get<string>("invalidExplanation");
    }
    public static ObjBuilder<Duration> fromMillis(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<int> count) 
    {
        return b.Call<Duration>("fromMillis");
    }
    public static ObjBuilder<Duration> fromMillis(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<int> count, Metapsi.Syntax.Var<DurationOptions> opts) 
    {
        return b.Call<Duration>("fromMillis");
    }
    public static ObjBuilder<Duration> fromObject(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<Duration> obj) 
    {
        return b.Call<Duration>("fromObject");
    }
    public static ObjBuilder<Duration> fromObject(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<Duration> obj, Metapsi.Syntax.Var<DurationOptions> opts) 
    {
        return b.Call<Duration>("fromObject");
    }
    public static ObjBuilder<Duration> fromDurationLike(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<Duration> durationLike) 
    {
        return b.Call<Duration>("fromDurationLike");
    }
    public static ObjBuilder<Duration> fromISO(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<Duration>("fromISO");
    }
    public static ObjBuilder<Duration> fromISO(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DurationOptions> opts) 
    {
        return b.Call<Duration>("fromISO");
    }
    public static ObjBuilder<Duration> fromISOTime(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<Duration>("fromISOTime");
    }
    public static ObjBuilder<Duration> fromISOTime(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DurationOptions> opts) 
    {
        return b.Call<Duration>("fromISOTime");
    }
    public static ObjBuilder<Duration> invalid(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<string> reason) 
    {
        return b.Call<Duration>("invalid");
    }
    public static ObjBuilder<Duration> invalid(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<string> reason, Metapsi.Syntax.Var<string> explanation) 
    {
        return b.Call<Duration>("invalid");
    }
    public static ObjBuilder<bool> isDuration(this ObjBuilder<ClassDef<Duration>> b, Metapsi.Syntax.Var<object> o) 
    {
        return b.Call<bool>("isDuration");
    }
    public static ObjBuilder<string> toFormat(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<string> fmt) 
    {
        return b.Call<string>("toFormat", fmt);
    }
    public static ObjBuilder<string> toFormat(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<string> fmt, Metapsi.Syntax.Var<DurationFormatOptions> opts) 
    {
        return b.Call<string>("toFormat", fmt, opts);
    }
    public static ObjBuilder<string> toHuman(this ObjBuilder<Duration> b) 
    {
        return b.Call<string>("toHuman");
    }
    public static ObjBuilder<string> toHuman(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<ToHumanDurationOptions> opts) 
    {
        return b.Call<string>("toHuman", opts);
    }
    public static ObjBuilder<object> toObject(this ObjBuilder<Duration> b) 
    {
        return b.Call<object>("toObject");
    }
    public static ObjBuilder<string> toISO(this ObjBuilder<Duration> b) 
    {
        return b.Call<string>("toISO");
    }
    public static ObjBuilder<string> toISOTime(this ObjBuilder<Duration> b) 
    {
        return b.Call<string>("toISOTime");
    }
    public static ObjBuilder<string> toISOTime(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<ToISOTimeDurationOptions> opts) 
    {
        return b.Call<string>("toISOTime", opts);
    }
    public static ObjBuilder<string> toJSON(this ObjBuilder<Duration> b) 
    {
        return b.Call<string>("toJSON");
    }
    public static ObjBuilder<string> toString(this ObjBuilder<Duration> b) 
    {
        return b.Call<string>("toString");
    }
    public static ObjBuilder<int> toMillis(this ObjBuilder<Duration> b) 
    {
        return b.Call<int>("toMillis");
    }
    public static ObjBuilder<int> valueOf(this ObjBuilder<Duration> b) 
    {
        return b.Call<int>("valueOf");
    }
    public static ObjBuilder<Duration> plus(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<Duration>("plus", duration);
    }
    public static ObjBuilder<Duration> minus(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<Duration>("minus", duration);
    }
    public static ObjBuilder<Duration> mapUnits(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<System.Func<int, int>> fn) 
    {
        return b.Call<Duration>("mapUnits", fn);
    }
    public static ObjBuilder<Duration> mapUnits(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<System.Func<int, string, int>> fn) 
    {
        return b.Call<Duration>("mapUnits", fn);
    }
    public static ObjBuilder<int> get(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<int>("get", unit);
    }
    public static ObjBuilder<Duration> set(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<Duration> values) 
    {
        return b.Call<Duration>("set", values);
    }
    public static ObjBuilder<Duration> reconfigure(this ObjBuilder<Duration> b) 
    {
        return b.Call<Duration>("reconfigure");
    }
    public static ObjBuilder<Duration> reconfigure(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<DurationOptions> opts) 
    {
        return b.Call<Duration>("reconfigure", opts);
    }
    public static ObjBuilder<int> @as(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<int>("as", unit);
    }
    public static ObjBuilder<Duration> normalize(this ObjBuilder<Duration> b) 
    {
        return b.Call<Duration>("normalize");
    }
    public static ObjBuilder<Duration> rescale(this ObjBuilder<Duration> b) 
    {
        return b.Call<Duration>("rescale");
    }
    public static ObjBuilder<Duration> shiftTo(this ObjBuilder<Duration> b, params Metapsi.Syntax.Var<string>[] units) 
    {
        return b.Call<Duration>("shiftTo", units);
    }
    public static ObjBuilder<Duration> shiftToAll(this ObjBuilder<Duration> b) 
    {
        return b.Call<Duration>("shiftToAll");
    }
    public static ObjBuilder<Duration> negate(this ObjBuilder<Duration> b) 
    {
        return b.Call<Duration>("negate");
    }
    public static ObjBuilder<Duration> removeZeros(this ObjBuilder<Duration> b) 
    {
        return b.Call<Duration>("removeZeros");
    }
    public static ObjBuilder<bool> equals(this ObjBuilder<Duration> b, Metapsi.Syntax.Var<Duration> other) 
    {
        return b.Call<bool>("equals", other);
    }
}