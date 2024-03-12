using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlCopyButton
{
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
        b.SetDynamic(b.Props, new DynamicProperty<string>("copyLabel"), value);
    }
    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public static void SetCopyLabel(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("copyLabel"), b.Const(value));
    }

    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("successLabel"), value);
    }
    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("successLabel"), b.Const(value));
    }

    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel(this PropsBuilder<SlCopyButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorLabel"), value);
    }
    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel(this PropsBuilder<SlCopyButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorLabel"), b.Const(value));
    }

    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public static void SetFeedbackDuration(this PropsBuilder<SlCopyButton> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("feedbackDuration"), value);
    }
    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public static void SetFeedbackDuration(this PropsBuilder<SlCopyButton> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("feedbackDuration"), b.Const(value));
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementTop(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltipPlacement"), b.Const("top"));
    }
    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementRight(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltipPlacement"), b.Const("right"));
    }
    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementBottom(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltipPlacement"), b.Const("bottom"));
    }
    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementLeft(this PropsBuilder<SlCopyButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltipPlacement"), b.Const("left"));
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
    public static void OnSlCopy<TModel>(this PropsBuilder<SlCopyButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-copy"), eventAction);
    }
    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<TModel>(this PropsBuilder<SlCopyButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-copy"), eventAction);
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlCopyButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-error"), eventAction);
    }
    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlCopyButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-error"), eventAction);
    }

}

