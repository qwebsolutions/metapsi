using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlOption : SlComponent
{
    public SlOption() : base("sl-option") { }
    /// <summary>
    /// The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values.
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
    /// Draws the option in a disabled state, preventing selection.
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
    }
    public static class Method
    {
        /// <summary> 
        /// Returns a plain text label based on the option's content.
        /// </summary>
        public const string GetTextLabel = "getTextLabel";
    }
}

public static partial class SlOptionControl
{
    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Var<IVNode> SlOption(this LayoutBuilder b, Action<PropsBuilder<SlOption>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-option", buildProps, children);
    }
    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Var<IVNode> SlOption(this LayoutBuilder b, Action<PropsBuilder<SlOption>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-option", buildProps, children);
    }
    /// <summary>
    /// The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlOption> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlOption> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Draws the option in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlOption> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

}

