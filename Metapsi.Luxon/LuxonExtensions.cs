using Metapsi.Syntax;

namespace Metapsi.Luxon;

public static partial class LuxonExtensions
{

    /// <summary>
    /// Returns the reference to the Luxon DateTime class. Use it for static calls
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<Luxon.DateTime>> LuxonDateTime(this SyntaxBuilder b)
    {
        var luxonJsResource = b.AddLuxon();
        var dateTimeClass = b.ImportName<ClassDef<Luxon.DateTime>>(luxonJsResource, "DateTime");
        return dateTimeClass;
    }

    /// <summary>
    /// Returns the reference to the Luxon Interval class. Use it for static calls
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<Luxon.Interval>> LuxonInterval(this SyntaxBuilder b)
    {
        var luxonJsResource = b.AddLuxon();
        var intervalClass = b.ImportName<ClassDef<Luxon.Interval>>(luxonJsResource, "Interval");
        return intervalClass;
    }

    /// <summary>
    /// Returns the reference to the Luxon Duration class. Use it for static calls
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<Luxon.Duration>> LuxonDuration(this SyntaxBuilder b)
    {
        var luxonJsResource = b.AddLuxon();
        var durationClass = b.ImportName<ClassDef<Luxon.Duration>>(luxonJsResource, "Duration");
        return durationClass;
    }
}
