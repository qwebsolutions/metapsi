namespace Metapsi.Ui;

public interface IMetapsiRoute
{
}

public static class Route
{
    public static string Path<TRoute>() where TRoute : IMetapsiRoute
    {
        return typeof(TRoute).Name;
    }
}

public interface IHasSidePanel
{
    bool ShowSidePanel { get; set; }
}

public static class Menu
{
    public class Entry
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Href { get; set; }
        public string SvgIcon { get; set; } = string.Empty;
    }
}

public enum AuthType
{
    Oidc,
    Windows
}

public class User
{
    public string Name { get; set; }
    public AuthType AuthType { get; set; }
}

public interface IHasUser
{
    User User { get; set; }
}