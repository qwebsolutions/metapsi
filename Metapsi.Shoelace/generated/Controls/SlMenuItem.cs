using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Menu items provide options for the user to pick from in a menu.
/// </summary>
public partial class SlMenuItem
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Used to prepend an icon or similar element to the menu item.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// Used to append an icon or similar element to the menu item.
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// Used to denote a nested menu.
        /// </summary>
        public const string Submenu = "submenu";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Returns a text label based on the contents of the menu item's default slot.
        /// </summary>
        public const string GetTextLabel = "getTextLabel";
    }
}
/// <summary>
/// Setter extensions of SlMenuItem
/// </summary>
public static partial class SlMenuItemControl
{
    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMenuItem>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-menu-item", buildAttributes, children);
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuItem(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-menu-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMenuItem>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-menu-item", buildAttributes, children);
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuItem(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-menu-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public static void SetTypeNormal(this Metapsi.Html.AttributesBuilder<SlMenuItem> b) 
    {
        b.SetAttribute("type", "normal");
    }

    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public static void SetTypeCheckbox(this Metapsi.Html.AttributesBuilder<SlMenuItem> b) 
    {
        b.SetAttribute("type", "checkbox");
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<SlMenuItem> b, bool @checked) 
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<SlMenuItem> b) 
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// A unique value to store in the menu item. This can be used as a way to identify menu items when selected.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlMenuItem> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public static void SetLoading(this Metapsi.Html.AttributesBuilder<SlMenuItem> b, bool loading) 
    {
        if (loading) b.SetAttribute("loading", "");
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public static void SetLoading(this Metapsi.Html.AttributesBuilder<SlMenuItem> b) 
    {
        b.SetAttribute("loading", "");
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlMenuItem> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlMenuItem> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMenuItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-menu-item", buildProps, children);
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-menu-item", children);
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMenuItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-menu-item", buildProps, children);
    }

    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-menu-item", children);
    }

    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public static void SetTypeNormal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("normal"));
    }

    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public static void SetTypeCheckbox<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("checkbox"));
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetChecked(b.Const(true));
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @checked) where T: SlMenuItem
    {
        b.SetProperty(b.Props, b.Const("checked"), @checked);
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @checked) where T: SlMenuItem
    {
        b.SetChecked(b.Const(@checked));
    }

    /// <summary>
    /// A unique value to store in the menu item. This can be used as a way to identify menu items when selected.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlMenuItem
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// A unique value to store in the menu item. This can be used as a way to identify menu items when selected.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlMenuItem
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public static void SetLoading<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetLoading(b.Const(true));
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public static void SetLoading<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> loading) where T: SlMenuItem
    {
        b.SetProperty(b.Props, b.Const("loading"), loading);
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public static void SetLoading<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool loading) where T: SlMenuItem
    {
        b.SetLoading(b.Const(loading));
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlMenuItem
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlMenuItem
    {
        b.SetDisabled(b.Const(disabled));
    }

}