using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Luxon;

public static partial class DateTimeExtensions
{
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATE_SHORT(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATE_SHORT");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATE_MED(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATE_MED");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATE_MED_WITH_WEEKDAY(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATE_MED_WITH_WEEKDAY");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATE_FULL(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATE_FULL");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATE_HUGE(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATE_HUGE");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_SIMPLE(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_SIMPLE");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_WITH_SECONDS(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_WITH_SECONDS");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_WITH_SHORT_OFFSET(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_WITH_SHORT_OFFSET");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_WITH_LONG_OFFSET(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_WITH_LONG_OFFSET");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_24_SIMPLE(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_24_SIMPLE");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_24_WITH_SECONDS(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_24_WITH_SECONDS");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_24_WITH_SHORT_OFFSET(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_24_WITH_SHORT_OFFSET");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> TIME_24_WITH_LONG_OFFSET(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("TIME_24_WITH_LONG_OFFSET");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_SHORT(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_SHORT");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_SHORT_WITH_SECONDS(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_SHORT_WITH_SECONDS");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_MED(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_MED");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_MED_WITH_SECONDS(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_MED_WITH_SECONDS");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_MED_WITH_WEEKDAY(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_MED_WITH_WEEKDAY");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_FULL(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_FULL");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_FULL_WITH_SECONDS(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_FULL_WITH_SECONDS");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_HUGE(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_HUGE");
    }
    public static ObjBuilder<Metapsi.Html.Intl.DateTimeFormatOptions> DATETIME_HUGE_WITH_SECONDS(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Get<Intl.DateTimeFormatOptions>("DATETIME_HUGE_WITH_SECONDS");
    }
    public static ObjBuilder<bool> isValid(this ObjBuilder<DateTime> b) 
    {
        return b.Get<bool>("isValid");
    }
    public static ObjBuilder<string> invalidReason(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("invalidReason");
    }
    public static ObjBuilder<string> invalidExplanation(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("invalidExplanation");
    }
    public static ObjBuilder<string> locale(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("locale");
    }
    public static ObjBuilder<string> numberingSystem(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("numberingSystem");
    }
    public static ObjBuilder<string> outputCalendar(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("outputCalendar");
    }
    public static ObjBuilder<Zone> zone(this ObjBuilder<DateTime> b) 
    {
        return b.Get<Zone>("zone");
    }
    public static ObjBuilder<string> zoneName(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("zoneName");
    }
    public static ObjBuilder<int> year(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("year");
    }
    public static ObjBuilder<int> quarter(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("quarter");
    }
    public static ObjBuilder<int> month(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("month");
    }
    public static ObjBuilder<int> day(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("day");
    }
    public static ObjBuilder<int> hour(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("hour");
    }
    public static ObjBuilder<int> minute(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("minute");
    }
    public static ObjBuilder<int> second(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("second");
    }
    public static ObjBuilder<int> millisecond(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("millisecond");
    }
    public static ObjBuilder<int> weekYear(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("weekYear");
    }
    public static ObjBuilder<int> weekNumber(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("weekNumber");
    }
    public static ObjBuilder<int> weekday(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("weekday");
    }
    public static ObjBuilder<bool> isWeekend(this ObjBuilder<DateTime> b) 
    {
        return b.Get<bool>("isWeekend");
    }
    public static ObjBuilder<int> localWeekday(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("localWeekday");
    }
    public static ObjBuilder<int> localWeekNumber(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("localWeekNumber");
    }
    public static ObjBuilder<int> localWeekYear(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("localWeekYear");
    }
    public static ObjBuilder<int> ordinal(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("ordinal");
    }
    public static ObjBuilder<string> monthShort(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("monthShort");
    }
    public static ObjBuilder<string> monthLong(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("monthLong");
    }
    public static ObjBuilder<string> weekdayShort(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("weekdayShort");
    }
    public static ObjBuilder<string> weekdayLong(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("weekdayLong");
    }
    public static ObjBuilder<int> offset(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("offset");
    }
    public static ObjBuilder<string> offsetNameShort(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("offsetNameShort");
    }
    public static ObjBuilder<string> offsetNameLong(this ObjBuilder<DateTime> b) 
    {
        return b.Get<string>("offsetNameLong");
    }
    public static ObjBuilder<bool> isOffsetFixed(this ObjBuilder<DateTime> b) 
    {
        return b.Get<bool>("isOffsetFixed");
    }
    public static ObjBuilder<bool> isInDST(this ObjBuilder<DateTime> b) 
    {
        return b.Get<bool>("isInDST");
    }
    public static ObjBuilder<bool> isInLeapYear(this ObjBuilder<DateTime> b) 
    {
        return b.Get<bool>("isInLeapYear");
    }
    public static ObjBuilder<int> daysInMonth(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("daysInMonth");
    }
    public static ObjBuilder<int> daysInYear(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("daysInYear");
    }
    public static ObjBuilder<int> weeksInWeekYear(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("weeksInWeekYear");
    }
    public static ObjBuilder<int> weeksInLocalWeekYear(this ObjBuilder<DateTime> b) 
    {
        return b.Get<int>("weeksInLocalWeekYear");
    }
    public static ObjBuilder<DateTime> now(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Call<DateTime>("now");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second, Metapsi.Syntax.Var<int> millisecond) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second, Metapsi.Syntax.Var<int> millisecond, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> local(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("local");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second, Metapsi.Syntax.Var<int> millisecond) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second, Metapsi.Syntax.Var<int> millisecond, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<int> second, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<int> minute, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<int> hour, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<int> day, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<int> month, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> year, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> utc(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<DateTime>("utc");
    }
    public static ObjBuilder<DateTime> fromJSDate(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<object> date) 
    {
        return b.Call<DateTime>("fromJSDate");
    }
    public static ObjBuilder<DateTime> fromJSDate(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<object> date, Metapsi.Syntax.Var<Zone> options) 
    {
        return b.Call<DateTime>("fromJSDate");
    }
    public static ObjBuilder<DateTime> fromMillis(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> milliseconds) 
    {
        return b.Call<DateTime>("fromMillis");
    }
    public static ObjBuilder<DateTime> fromMillis(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> milliseconds, Metapsi.Syntax.Var<DateTimeJSOptions> options) 
    {
        return b.Call<DateTime>("fromMillis");
    }
    public static ObjBuilder<DateTime> fromSeconds(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> seconds) 
    {
        return b.Call<DateTime>("fromSeconds");
    }
    public static ObjBuilder<DateTime> fromSeconds(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<int> seconds, Metapsi.Syntax.Var<DateTimeJSOptions> options) 
    {
        return b.Call<DateTime>("fromSeconds");
    }
    public static ObjBuilder<DateTime> fromObject(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<DateObjectUnits> obj) 
    {
        return b.Call<DateTime>("fromObject");
    }
    public static ObjBuilder<DateTime> fromObject(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<DateObjectUnits> obj, Metapsi.Syntax.Var<DateTimeJSOptions> opts) 
    {
        return b.Call<DateTime>("fromObject");
    }
    public static ObjBuilder<DateTime> fromISO(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<DateTime>("fromISO");
    }
    public static ObjBuilder<DateTime> fromISO(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DateTimeOptions> opts) 
    {
        return b.Call<DateTime>("fromISO");
    }
    public static ObjBuilder<DateTime> fromRFC2822(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<DateTime>("fromRFC2822");
    }
    public static ObjBuilder<DateTime> fromRFC2822(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DateTimeOptions> opts) 
    {
        return b.Call<DateTime>("fromRFC2822");
    }
    public static ObjBuilder<DateTime> fromHTTP(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<DateTime>("fromHTTP");
    }
    public static ObjBuilder<DateTime> fromHTTP(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DateTimeOptions> opts) 
    {
        return b.Call<DateTime>("fromHTTP");
    }
    public static ObjBuilder<DateTime> fromFormat(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<DateTime>("fromFormat");
    }
    public static ObjBuilder<DateTime> fromFormat(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<DateTimeOptions> opts) 
    {
        return b.Call<DateTime>("fromFormat");
    }
    public static ObjBuilder<DateTime> fromString(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<DateTime>("fromString");
    }
    public static ObjBuilder<DateTime> fromString(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<DateTimeOptions> options) 
    {
        return b.Call<DateTime>("fromString");
    }
    public static ObjBuilder<DateTime> fromSQL(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text) 
    {
        return b.Call<DateTime>("fromSQL");
    }
    public static ObjBuilder<DateTime> fromSQL(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<DateTimeOptions> opts) 
    {
        return b.Call<DateTime>("fromSQL");
    }
    public static ObjBuilder<DateTime> invalid(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> reason) 
    {
        return b.Call<DateTime>("invalid");
    }
    public static ObjBuilder<DateTime> invalid(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> reason, Metapsi.Syntax.Var<string> explanation) 
    {
        return b.Call<DateTime>("invalid");
    }
    public static ObjBuilder<bool> isDateTime(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<object> o) 
    {
        return b.Call<bool>("isDateTime");
    }
    public static ObjBuilder<string> parseFormatForOpts(this ObjBuilder<ClassDef<DateTime>> b) 
    {
        return b.Call<string>("parseFormatForOpts");
    }
    public static ObjBuilder<string> parseFormatForOpts(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> formatOpts) 
    {
        return b.Call<string>("parseFormatForOpts");
    }
    public static ObjBuilder<string> parseFormatForOpts(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> formatOpts, Metapsi.Syntax.Var<LocaleOptions> localeOpts) 
    {
        return b.Call<string>("parseFormatForOpts");
    }
    public static ObjBuilder<string> expandFormat(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<string>("expandFormat");
    }
    public static ObjBuilder<string> expandFormat(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<LocaleOptions> localeOptions) 
    {
        return b.Call<string>("expandFormat");
    }
    public static ObjBuilder<DateTime> min(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<System.Collections.Generic.List<DateTime>> dateTimes) 
    {
        return b.Call<DateTime>("min");
    }
    public static ObjBuilder<DateTime> max(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<System.Collections.Generic.List<DateTime>> dateTimes) 
    {
        return b.Call<DateTime>("max");
    }
    public static ObjBuilder<ExplainedFormat> fromFormatExplain(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<ExplainedFormat>("fromFormatExplain");
    }
    public static ObjBuilder<ExplainedFormat> fromFormatExplain(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<DateTimeOptions> options) 
    {
        return b.Call<ExplainedFormat>("fromFormatExplain");
    }
    public static ObjBuilder<ExplainedFormat> fromStringExplain(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<ExplainedFormat>("fromStringExplain");
    }
    public static ObjBuilder<ExplainedFormat> fromStringExplain(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<DateTimeOptions> options) 
    {
        return b.Call<ExplainedFormat>("fromStringExplain");
    }
    public static ObjBuilder<TokenParser> buildFormatParser(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<TokenParser>("buildFormatParser");
    }
    public static ObjBuilder<TokenParser> buildFormatParser(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<TokenParser>("buildFormatParser");
    }
    public static ObjBuilder<DateTime> fromFormatParser(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<TokenParser> parser) 
    {
        return b.Call<DateTime>("fromFormatParser");
    }
    public static ObjBuilder<DateTime> fromFormatParser(this ObjBuilder<ClassDef<DateTime>> b, Metapsi.Syntax.Var<string> text, Metapsi.Syntax.Var<TokenParser> parser, Metapsi.Syntax.Var<DateTimeOptions> options) 
    {
        return b.Call<DateTime>("fromFormatParser");
    }
    public static ObjBuilder<DateTime> get(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<DateTime>("get", unit);
    }
    public static ObjBuilder<System.Collections.Generic.List<DateTime>> getPossibleOffsets(this ObjBuilder<DateTime> b) 
    {
        return b.Call<System.Collections.Generic.List<DateTime>>("getPossibleOffsets");
    }
    public static ObjBuilder<DateTime> resolvedLocaleOptions(this ObjBuilder<DateTime> b) 
    {
        return b.Call<DateTime>("resolvedLocaleOptions");
    }
    public static ObjBuilder<DateTime> resolvedLocaleOptions(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<object> opts) 
    {
        return b.Call<DateTime>("resolvedLocaleOptions", opts);
    }
    public static ObjBuilder<DateTime> toUTC(this ObjBuilder<DateTime> b) 
    {
        return b.Call<DateTime>("toUTC");
    }
    public static ObjBuilder<DateTime> toUTC(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<int> offset) 
    {
        return b.Call<DateTime>("toUTC", offset);
    }
    public static ObjBuilder<DateTime> toUTC(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<int> offset, Metapsi.Syntax.Var<ZoneOptions> opts) 
    {
        return b.Call<DateTime>("toUTC", offset, opts);
    }
    public static ObjBuilder<DateTime> toLocal(this ObjBuilder<DateTime> b) 
    {
        return b.Call<DateTime>("toLocal");
    }
    public static ObjBuilder<DateTime> setZone(this ObjBuilder<DateTime> b) 
    {
        return b.Call<DateTime>("setZone");
    }
    public static ObjBuilder<DateTime> setZone(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Zone> zone) 
    {
        return b.Call<DateTime>("setZone", zone);
    }
    public static ObjBuilder<DateTime> setZone(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Zone> zone, Metapsi.Syntax.Var<ZoneOptions> opts) 
    {
        return b.Call<DateTime>("setZone", zone, opts);
    }
    public static ObjBuilder<DateTime> reconfigure(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<LocaleOptions> properties) 
    {
        return b.Call<DateTime>("reconfigure", properties);
    }
    public static ObjBuilder<DateTime> setLocale(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> locale) 
    {
        return b.Call<DateTime>("setLocale", locale);
    }
    public static ObjBuilder<DateTime> set(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateObjectUnits> values) 
    {
        return b.Call<DateTime>("set", values);
    }
    public static ObjBuilder<DateTime> plus(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<DateTime>("plus", duration);
    }
    public static ObjBuilder<DateTime> minus(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Duration> duration) 
    {
        return b.Call<DateTime>("minus", duration);
    }
    public static ObjBuilder<DateTime> startOf(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<DateTime>("startOf", unit);
    }
    public static ObjBuilder<DateTime> startOf(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> unit, Metapsi.Syntax.Var<object> opts) 
    {
        return b.Call<DateTime>("startOf", unit, opts);
    }
    public static ObjBuilder<DateTime> endOf(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<DateTime>("endOf", unit);
    }
    public static ObjBuilder<DateTime> endOf(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> unit, Metapsi.Syntax.Var<object> opts) 
    {
        return b.Call<DateTime>("endOf", unit, opts);
    }
    public static ObjBuilder<string> toFormat(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> format) 
    {
        return b.Call<string>("toFormat", format);
    }
    public static ObjBuilder<string> toFormat(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<string> format, Metapsi.Syntax.Var<LocaleOptions> options) 
    {
        return b.Call<string>("toFormat", format, options);
    }
    public static ObjBuilder<string> toLocaleString(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toLocaleString");
    }
    public static ObjBuilder<string> toLocaleString(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> formatOpts) 
    {
        return b.Call<string>("toLocaleString", formatOpts);
    }
    public static ObjBuilder<string> toLocaleString(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> formatOpts, Metapsi.Syntax.Var<LocaleOptions> opts) 
    {
        return b.Call<string>("toLocaleString", formatOpts, opts);
    }
    public static ObjBuilder<System.Collections.Generic.List<Intl.DateTimeFormatPart>> toLocaleParts(this ObjBuilder<DateTime> b) 
    {
        return b.Call<System.Collections.Generic.List<Intl.DateTimeFormatPart>>("toLocaleParts");
    }
    public static ObjBuilder<System.Collections.Generic.List<Intl.DateTimeFormatPart>> toLocaleParts(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<Intl.DateTimeFormatOptions> opts) 
    {
        return b.Call<System.Collections.Generic.List<Intl.DateTimeFormatPart>>("toLocaleParts", opts);
    }
    public static ObjBuilder<string> toISO(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toISO");
    }
    public static ObjBuilder<string> toISO(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToISOTimeOptions> opts) 
    {
        return b.Call<string>("toISO", opts);
    }
    public static ObjBuilder<string> toISODate(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toISODate");
    }
    public static ObjBuilder<string> toISODate(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToISODateOptions> opts) 
    {
        return b.Call<string>("toISODate", opts);
    }
    public static ObjBuilder<string> toISOWeekDate(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toISOWeekDate");
    }
    public static ObjBuilder<string> toISOTime(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toISOTime");
    }
    public static ObjBuilder<string> toISOTime(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToISOTimeOptions> opts) 
    {
        return b.Call<string>("toISOTime", opts);
    }
    public static ObjBuilder<string> toRFC2822(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toRFC2822");
    }
    public static ObjBuilder<string> toHTTP(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toHTTP");
    }
    public static ObjBuilder<string> toSQLDate(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toSQLDate");
    }
    public static ObjBuilder<string> toSQLTime(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toSQLTime");
    }
    public static ObjBuilder<string> toSQLTime(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToSQLOptions > opts) 
    {
        return b.Call<string>("toSQLTime", opts);
    }
    public static ObjBuilder<string> toSQL(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toSQL");
    }
    public static ObjBuilder<string> toSQL(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToSQLOptions > opts) 
    {
        return b.Call<string>("toSQL", opts);
    }
    public static ObjBuilder<string> toString(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toString");
    }
    public static ObjBuilder<int> valueOf(this ObjBuilder<DateTime> b) 
    {
        return b.Call<int>("valueOf");
    }
    public static ObjBuilder<int> toMillis(this ObjBuilder<DateTime> b) 
    {
        return b.Call<int>("toMillis");
    }
    public static ObjBuilder<int> toSeconds(this ObjBuilder<DateTime> b) 
    {
        return b.Call<int>("toSeconds");
    }
    public static ObjBuilder<int> toUnixInteger(this ObjBuilder<DateTime> b) 
    {
        return b.Call<int>("toUnixInteger");
    }
    public static ObjBuilder<string> toJSON(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toJSON");
    }
    public static ObjBuilder<object> toBSON(this ObjBuilder<DateTime> b) 
    {
        return b.Call<object>("toBSON");
    }
    public static ObjBuilder<object> toObject(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<object> opts) 
    {
        return b.Call<object>("toObject", opts);
    }
    public static ObjBuilder<object> toJSDate(this ObjBuilder<DateTime> b) 
    {
        return b.Call<object>("toJSDate");
    }
    public static ObjBuilder<Duration> diff(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> otherDateTime) 
    {
        return b.Call<Duration>("diff", otherDateTime);
    }
    public static ObjBuilder<Duration> diff(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> otherDateTime, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> unit) 
    {
        return b.Call<Duration>("diff", otherDateTime, unit);
    }
    public static ObjBuilder<Duration> diff(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> otherDateTime, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> unit, Metapsi.Syntax.Var<DiffOptions> opts) 
    {
        return b.Call<Duration>("diff", otherDateTime, unit, opts);
    }
    public static ObjBuilder<Duration> diffNow(this ObjBuilder<DateTime> b) 
    {
        return b.Call<Duration>("diffNow");
    }
    public static ObjBuilder<Duration> diffNow(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> unit) 
    {
        return b.Call<Duration>("diffNow", unit);
    }
    public static ObjBuilder<Duration> diffNow(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> unit, Metapsi.Syntax.Var<DiffOptions> opts) 
    {
        return b.Call<Duration>("diffNow", unit, opts);
    }
    public static ObjBuilder<Interval> until(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> otherDateTime) 
    {
        return b.Call<Interval>("until", otherDateTime);
    }
    public static ObjBuilder<bool> hasSame(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> otherDateTime, Metapsi.Syntax.Var<string> unit) 
    {
        return b.Call<bool>("hasSame", otherDateTime, unit);
    }
    public static ObjBuilder<bool> hasSame(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> otherDateTime, Metapsi.Syntax.Var<string> unit, Metapsi.Syntax.Var<object> opts) 
    {
        return b.Call<bool>("hasSame", otherDateTime, unit, opts);
    }
    public static ObjBuilder<bool> equals(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<DateTime> other) 
    {
        return b.Call<bool>("equals", other);
    }
    public static ObjBuilder<string> toRelative(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toRelative");
    }
    public static ObjBuilder<string> toRelative(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToRelativeOptions> options) 
    {
        return b.Call<string>("toRelative", options);
    }
    public static ObjBuilder<string> toRelativeCalendar(this ObjBuilder<DateTime> b) 
    {
        return b.Call<string>("toRelativeCalendar");
    }
    public static ObjBuilder<string> toRelativeCalendar(this ObjBuilder<DateTime> b, Metapsi.Syntax.Var<ToRelativeCalendarOptions> options) 
    {
        return b.Call<string>("toRelativeCalendar", options);
    }
}