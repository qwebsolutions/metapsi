using System;
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

public interface IHasValidationPanel
{
    string ValidationMessage { get; set; }
}

public interface IHasLoadingPanel
{
    bool IsLoading { get; set; }
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
        if (user == null)
            return false;

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

//public class ViewRenderer<TVarClientModel, TVarVNode>
//{
//    public string Name { get; set; }
//    public Func<TVarClientModel, TVarVNode> RenderFunc { get; set; }
//}

//public class ViewEntry
//{
//    /// <summary>
//    /// The name of the area where this view is applied. 
//    /// There might be multiple view-based controls (multiple tabs, for example) in the same page,
//    /// so this is used to differentiate between them
//    /// </summary>
//    public string AreaName { get; set; } = string.Empty;
//    public string ViewRendererName { get; set; } = string.Empty;
//}

//public interface IHasViews
//{
//    List<ViewEntry> Views { get; set; }
//}