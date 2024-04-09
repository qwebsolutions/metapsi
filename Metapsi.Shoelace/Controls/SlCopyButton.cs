using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlCopyButton : SlComponent
{
    public SlCopyButton() : base("sl-copy-button") { }
    /// <summary>
    /// The text value to copy.
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
    /// An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`.
    /// </summary>
    public string from
    {
        get
        {
            return this.GetTag().GetAttribute<string>("from");
        }
        set
        {
            this.GetTag().SetAttribute("from", value.ToString());
        }
    }

    /// <summary>
    /// Disables the copy button.
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

    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public string copyLabel
    {
        get
        {
            return this.GetTag().GetAttribute<string>("copy-label");
        }
        set
        {
            this.GetTag().SetAttribute("copy-label", value.ToString());
        }
    }

    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public string successLabel
    {
        get
        {
            return this.GetTag().GetAttribute<string>("success-label");
        }
        set
        {
            this.GetTag().SetAttribute("success-label", value.ToString());
        }
    }

    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public string errorLabel
    {
        get
        {
            return this.GetTag().GetAttribute<string>("error-label");
        }
        set
        {
            this.GetTag().SetAttribute("error-label", value.ToString());
        }
    }

    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public int feedbackDuration
    {
        get
        {
            return this.GetTag().GetAttribute<int>("feedback-duration");
        }
        set
        {
            this.GetTag().SetAttribute("feedback-duration", value.ToString());
        }
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public string tooltipPlacement
    {
        get
        {
            return this.GetTag().GetAttribute<string>("tooltip-placement");
        }
        set
        {
            this.GetTag().SetAttribute("tooltip-placement", value.ToString());
        }
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public bool hoist
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("hoist");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("hoist", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// The icon to show in the default copy state. Works best with `<sl-icon>`.
        /// </summary>
        public const string CopyIcon = "copy-icon";
        /// <summary> 
        /// The icon to show when the content is copied. Works best with `<sl-icon>`.
        /// </summary>
        public const string SuccessIcon = "success-icon";
        /// <summary> 
        /// The icon to show when a copy error occurs. Works best with `<sl-icon>`.
        /// </summary>
        public const string ErrorIcon = "error-icon";
    }
}

public static partial class SlCopyButtonControl
{
    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, Action<PropsBuilder<SlCopyButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-copy-button", buildProps, children);
    }
    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, Action<PropsBuilder<SlCopyButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-copy-button", buildProps, children);
    }
    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-copy-button", children);
    }
    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-copy-button", children);
    }
    /// <summary>
    /// The text value to copy.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The text value to copy.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`.
    /// </summary>
    public static void SetFrom(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), value);
    }
    /// <summary>
    /// An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`.
    /// </summary>
    public static void SetFrom(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), b.Const(value));
    }

    /// <summary>
    /// Disables the copy button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public static void SetCopyLabel(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("copy-label"), value);
    }
    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public static void SetCopyLabel(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("copy-label"), b.Const(value));
    }

    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("success-label"), value);
    }
    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("success-label"), b.Const(value));
    }

    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("error-label"), value);
    }
    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("error-label"), b.Const(value));
    }

    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public static void SetFeedbackDuration(this PropsBuilder<SlCopyButton> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("feedback-duration"), value);
    }
    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public static void SetFeedbackDuration(this PropsBuilder<SlCopyButton> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("feedback-duration"), b.Const(value));
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementTop(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip-placement"), b.Const("top"));
    }
    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementRight(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip-placement"), b.Const("right"));
    }
    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementBottom(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip-placement"), b.Const("bottom"));
    }
    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementLeft(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip-placement"), b.Const("left"));
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("hoist"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<TModel>(this PropsBuilder<SlCopyButton> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-copy", action);
    }
    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<TModel>(this PropsBuilder<SlCopyButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-copy", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<TModel>(this PropsBuilder<SlCopyButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-copy", action);
    }
    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<TModel>(this PropsBuilder<SlCopyButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-copy", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlCopyButton> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlCopyButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlCopyButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlCopyButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

}

