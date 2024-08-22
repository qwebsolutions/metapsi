using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlMenuItem
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Used to prepend an icon or similar element to the menu item. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> Used to append an icon or similar element to the menu item. </para>
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// <para> Used to denote a nested menu. </para>
        /// </summary>
        public const string Submenu = "submenu";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Returns a text label based on the contents of the menu item's default slot. </para>
        /// </summary>
        public const string GetTextLabel = "getTextLabel";
    }
}

public static partial class SlMenuItemControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuItem(this HtmlBuilder b, Action<AttributesBuilder<SlMenuItem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-menu-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-menu-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuItem(this HtmlBuilder b, Action<AttributesBuilder<SlMenuItem>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-menu-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuItem(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-menu-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The type of menu item to render. To use `checked`, this value must be set to `checkbox`. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<SlMenuItem> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of menu item to render. To use `checked`, this value must be set to `checkbox`. </para>
    /// </summary>
    public static void SetTypeNormal(this AttributesBuilder<SlMenuItem> b)
    {
        b.SetAttribute("type", "normal");
    }

    /// <summary>
    /// <para> The type of menu item to render. To use `checked`, this value must be set to `checkbox`. </para>
    /// </summary>
    public static void SetTypeCheckbox(this AttributesBuilder<SlMenuItem> b)
    {
        b.SetAttribute("type", "checkbox");
    }

    /// <summary>
    /// <para> Draws the item in a checked state. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<SlMenuItem> b)
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> Draws the item in a checked state. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<SlMenuItem> b, bool @checked)
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> A unique value to store in the menu item. This can be used as a way to identify menu items when selected. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlMenuItem> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> Draws the menu item in a loading state. </para>
    /// </summary>
    public static void SetLoading(this AttributesBuilder<SlMenuItem> b)
    {
        b.SetAttribute("loading", "");
    }

    /// <summary>
    /// <para> Draws the menu item in a loading state. </para>
    /// </summary>
    public static void SetLoading(this AttributesBuilder<SlMenuItem> b, bool loading)
    {
        if (loading) b.SetAttribute("loading", "");
    }

    /// <summary>
    /// <para> Draws the menu item in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlMenuItem> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Draws the menu item in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlMenuItem> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuItem(this LayoutBuilder b, Action<PropsBuilder<SlMenuItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuItem(this LayoutBuilder b, Action<PropsBuilder<SlMenuItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuItem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu-item", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuItem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu-item", children);
    }
    /// <summary>
    /// <para> The type of menu item to render. To use `checked`, this value must be set to `checkbox`. </para>
    /// </summary>
    public static void SetTypeNormal<T>(this PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("normal"));
    }


    /// <summary>
    /// <para> The type of menu item to render. To use `checked`, this value must be set to `checkbox`. </para>
    /// </summary>
    public static void SetTypeCheckbox<T>(this PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("checkbox"));
    }


    /// <summary>
    /// <para> Draws the item in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the item in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, Var<bool> @checked) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), @checked);
    }

    /// <summary>
    /// <para> Draws the item in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, bool @checked) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(@checked));
    }


    /// <summary>
    /// <para> A unique value to store in the menu item. This can be used as a way to identify menu items when selected. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> A unique value to store in the menu item. This can be used as a way to identify menu items when selected. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Draws the menu item in a loading state. </para>
    /// </summary>
    public static void SetLoading<T>(this PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("loading"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the menu item in a loading state. </para>
    /// </summary>
    public static void SetLoading<T>(this PropsBuilder<T> b, Var<bool> loading) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("loading"), loading);
    }

    /// <summary>
    /// <para> Draws the menu item in a loading state. </para>
    /// </summary>
    public static void SetLoading<T>(this PropsBuilder<T> b, bool loading) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("loading"), b.Const(loading));
    }


    /// <summary>
    /// <para> Draws the menu item in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the menu item in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Draws the menu item in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlMenuItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


}

