using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Menus provide a list of options for the user to choose from.
/// </summary>
public partial class SlMenu
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlMenu
/// </summary>
public static partial class SlMenuControl
{
    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenu(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMenu>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-menu", buildAttributes, children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenu(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-menu", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenu(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMenu>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-menu", buildAttributes, children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenu(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-menu", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenu(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMenu>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-menu", buildProps, children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenu(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-menu", children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenu(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMenu>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-menu", buildProps, children);
    }

    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenu(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-menu", children);
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlMenu
    {
        b.OnSlEvent("onsl-select", action);
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlMenu
    {
        b.OnSlSelect(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlMenu
    {
        b.OnSlEvent("onsl-select", action);
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlMenu
    {
        b.OnSlSelect(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlSelectDetail>>> action) where T: SlMenu
    {
        b.OnSlEvent("onsl-select", action);
    }

}