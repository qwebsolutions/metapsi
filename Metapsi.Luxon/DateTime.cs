using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Luxon;

/// <summary>
/// A DateTime is an immutable data structure representing a specific date and time and accompanying methods. It contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
/// </summary>
public class DateTime
{

}


public static partial class DateTimeExtensions
{
    public static Var<DateTime> LuxonDateTimeUtc(this SyntaxBuilder b)
    {
        return b.CallOnObject<DateTime>(b.DateTimeStatic(), "utc");
    }

    public static Var<string> LuxonDateTimeToRelative(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toRelative");
    }

    public static Var<string> LuxonDateTimeToIso(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toISO");
    }

    public static Var<string> LuxonDateTimeToLocaleString(this SyntaxBuilder b, Var<DateTime> dateTime)
    {
        return b.CallOnObject<string>(dateTime, "toLocaleString");
    }

    public static Var<string> LuxonDateTimeToLocaleString(this SyntaxBuilder b, Var<DateTime> dateTime, Var<Intl.DateTimeFormatOptions> options)
    {
        return b.CallOnObject<string>(dateTime, "toLocaleString", options);
    }
}