using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Metapsi.Luxon;

public static partial class DateTimeExtensions
{
    internal static ResourceMetadata AddLuxon(this SyntaxBuilder b)
    {
        return b.AddEmbeddedResourceMetadata(typeof(DateTimeExtensions).Assembly, "luxon.min.js");
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
}
