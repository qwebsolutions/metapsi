using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlMenuItem : SlComponent
{
    public SlMenuItem() : base("sl-menu-item") { }
    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public string type
    {
        get
        {
            return this.GetTag().GetAttribute<string>("type");
        }
        set
        {
            this.GetTag().SetAttribute("type", value.ToString());
        }
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public bool @checked
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("checked");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("checked", value.ToString());
        }
    }

    /// <summary>
    /// A unique value to store in the menu item. This can be used as a way to identify menu items when selected.
    /// </summary>
    public string value
    {
        get
        {
            return this.GetTag().GetAttribute<string>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public bool loading
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("loading");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("loading", value.ToString());
        }
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

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
    public static class Method
    {
        /// <summary> 
        /// Returns a text label based on the contents of the menu item's default slot.
        /// </summary>
        public const string GetTextLabel = "getTextLabel";
    }
}

public static partial class SlMenuItemControl
{
    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Var<IVNode> SlMenuItem(this LayoutBuilder b, Action<PropsBuilder<SlMenuItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu-item", buildProps, children);
    }
    /// <summary>
    /// Menu items provide options for the user to pick from in a menu.
    /// </summary>
    public static Var<IVNode> SlMenuItem(this LayoutBuilder b, Action<PropsBuilder<SlMenuItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu-item", buildProps, children);
    }
    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public static void SetTypeNormal(this PropsBuilder<SlMenuItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("normal"));
    }
    /// <summary>
    /// The type of menu item to render. To use `checked`, this value must be set to `checkbox`.
    /// </summary>
    public static void SetTypeCheckbox(this PropsBuilder<SlMenuItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("checkbox"));
    }

    /// <summary>
    /// Draws the item in a checked state.
    /// </summary>
    public static void SetChecked(this PropsBuilder<SlMenuItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(true));
    }

    /// <summary>
    /// A unique value to store in the menu item. This can be used as a way to identify menu items when selected.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlMenuItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// A unique value to store in the menu item. This can be used as a way to identify menu items when selected.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlMenuItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Draws the menu item in a loading state.
    /// </summary>
    public static void SetLoading(this PropsBuilder<SlMenuItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("loading"), b.Const(true));
    }

    /// <summary>
    /// Draws the menu item in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlMenuItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

}

