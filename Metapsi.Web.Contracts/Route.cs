namespace Metapsi;

public static class Route
{
    public interface IGet { }
    public interface IGet<T1> { }
    public interface IGet<T1, T2> { }
    public interface IGet<T1, T2, T3> { }

    public interface IPost<T1> { }

    public static string Path<TRoute>()
        where TRoute: IGet
    {
        var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        string path = string.Join("/", nestedTypeNames);
        return $"/{path}";
    }

    public static string Path<TRoute, T1>(T1 p1)
        where TRoute : IGet<T1>
    {
        var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        string path = string.Join("/", nestedTypeNames);
        return $"/{path}/{p1.ToString()}";
    }
}
