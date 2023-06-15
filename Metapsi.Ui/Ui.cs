using System.Collections.Generic;

namespace Metapsi.Ui;

//public interface IMetapsiRoute
//{
//}

//public static class Route
//{
//    public static string Path<TRoute>() where TRoute : IMetapsiRoute
//    {
//        return typeof(TRoute).Name;
//    }
//}

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

public static class UserExtensions
{
    public static bool IsSignedIn(this Metapsi.Ui.User user)
    {
        return !string.IsNullOrEmpty(user.Name);
    }
}

public interface IHtmlNode { }

public class HtmlTag : IHtmlNode
{
    public string Tag { get; set; } = string.Empty;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<IHtmlNode> Children { get; set; } = new();

    public HtmlTag() { }

    public HtmlTag(string tag)
    {
        this.Tag = tag;
    }

    public TChild AddChild<TChild>(TChild child)
        where TChild : IHtmlNode
    {
        this.Children.Add(child);
        return child;
    }

    public HtmlTag AddAttribute(string name, string value)
    {
        this.Attributes.Add(name, value);
        return this;
    }
}

public class HtmlText : IHtmlNode
{
    public string Text { get; set; } = string.Empty;

    public HtmlText() { }

    public HtmlText(string text)
    {
        this.Text = text;
    }
}