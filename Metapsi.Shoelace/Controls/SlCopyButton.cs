using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlCopyButton
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The icon to show in the default copy state. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string CopyIcon = "copy-icon";
        /// <summary>
        /// <para> The icon to show when the content is copied. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string SuccessIcon = "success-icon";
        /// <summary>
        /// <para> The icon to show when a copy error occurs. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string ErrorIcon = "error-icon";
    }
}

public static partial class SlCopyButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCopyButton(this HtmlBuilder b, Action<AttributesBuilder<SlCopyButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-copy-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCopyButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-copy-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCopyButton(this HtmlBuilder b, Action<AttributesBuilder<SlCopyButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-copy-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCopyButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-copy-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The text value to copy. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlCopyButton> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`. </para>
    /// </summary>
    public static void SetFrom(this AttributesBuilder<SlCopyButton> b, string from)
    {
        b.SetAttribute("from", from);
    }

    /// <summary>
    /// <para> Disables the copy button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlCopyButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the copy button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlCopyButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> A custom label to show in the tooltip. </para>
    /// </summary>
    public static void SetCopyLabel(this AttributesBuilder<SlCopyButton> b, string copyLabel)
    {
        b.SetAttribute("copy-label", copyLabel);
    }

    /// <summary>
    /// <para> A custom label to show in the tooltip after copying. </para>
    /// </summary>
    public static void SetSuccessLabel(this AttributesBuilder<SlCopyButton> b, string successLabel)
    {
        b.SetAttribute("success-label", successLabel);
    }

    /// <summary>
    /// <para> A custom label to show in the tooltip when a copy error occurs. </para>
    /// </summary>
    public static void SetErrorLabel(this AttributesBuilder<SlCopyButton> b, string errorLabel)
    {
        b.SetAttribute("error-label", errorLabel);
    }

    /// <summary>
    /// <para> The length of time to show feedback before restoring the default trigger. </para>
    /// </summary>
    public static void SetFeedbackDuration(this AttributesBuilder<SlCopyButton> b, string feedbackDuration)
    {
        b.SetAttribute("feedback-duration", feedbackDuration);
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacement(this AttributesBuilder<SlCopyButton> b, string tooltipPlacement)
    {
        b.SetAttribute("tooltip-placement", tooltipPlacement);
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementTop(this AttributesBuilder<SlCopyButton> b)
    {
        b.SetAttribute("tooltip-placement", "top");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementRight(this AttributesBuilder<SlCopyButton> b)
    {
        b.SetAttribute("tooltip-placement", "right");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementBottom(this AttributesBuilder<SlCopyButton> b)
    {
        b.SetAttribute("tooltip-placement", "bottom");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementLeft(this AttributesBuilder<SlCopyButton> b)
    {
        b.SetAttribute("tooltip-placement", "left");
    }

    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlCopyButton> b)
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlCopyButton> b, bool hoist)
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, Action<PropsBuilder<SlCopyButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-copy-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, Action<PropsBuilder<SlCopyButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-copy-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-copy-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCopyButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-copy-button", children);
    }
    /// <summary>
    /// <para> The text value to copy. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The text value to copy. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`. </para>
    /// </summary>
    public static void SetFrom<T>(this PropsBuilder<T> b, Var<string> from) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), from);
    }

    /// <summary>
    /// <para> An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`. </para>
    /// </summary>
    public static void SetFrom<T>(this PropsBuilder<T> b, string from) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("from"), b.Const(from));
    }


    /// <summary>
    /// <para> Disables the copy button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the copy button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the copy button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> A custom label to show in the tooltip. </para>
    /// </summary>
    public static void SetCopyLabel<T>(this PropsBuilder<T> b, Var<string> copyLabel) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("copyLabel"), copyLabel);
    }

    /// <summary>
    /// <para> A custom label to show in the tooltip. </para>
    /// </summary>
    public static void SetCopyLabel<T>(this PropsBuilder<T> b, string copyLabel) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("copyLabel"), b.Const(copyLabel));
    }


    /// <summary>
    /// <para> A custom label to show in the tooltip after copying. </para>
    /// </summary>
    public static void SetSuccessLabel<T>(this PropsBuilder<T> b, Var<string> successLabel) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("successLabel"), successLabel);
    }

    /// <summary>
    /// <para> A custom label to show in the tooltip after copying. </para>
    /// </summary>
    public static void SetSuccessLabel<T>(this PropsBuilder<T> b, string successLabel) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("successLabel"), b.Const(successLabel));
    }


    /// <summary>
    /// <para> A custom label to show in the tooltip when a copy error occurs. </para>
    /// </summary>
    public static void SetErrorLabel<T>(this PropsBuilder<T> b, Var<string> errorLabel) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorLabel"), errorLabel);
    }

    /// <summary>
    /// <para> A custom label to show in the tooltip when a copy error occurs. </para>
    /// </summary>
    public static void SetErrorLabel<T>(this PropsBuilder<T> b, string errorLabel) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorLabel"), b.Const(errorLabel));
    }


    /// <summary>
    /// <para> The length of time to show feedback before restoring the default trigger. </para>
    /// </summary>
    public static void SetFeedbackDuration<T>(this PropsBuilder<T> b, Var<int> feedbackDuration) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("feedbackDuration"), feedbackDuration);
    }

    /// <summary>
    /// <para> The length of time to show feedback before restoring the default trigger. </para>
    /// </summary>
    public static void SetFeedbackDuration<T>(this PropsBuilder<T> b, int feedbackDuration) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("feedbackDuration"), b.Const(feedbackDuration));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementTop<T>(this PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltipPlacement"), b.Const("top"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementRight<T>(this PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltipPlacement"), b.Const("right"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementBottom<T>(this PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltipPlacement"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. </para>
    /// </summary>
    public static void SetTooltipPlacementLeft<T>(this PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltipPlacement"), b.Const("left"));
    }


    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), b.Const(true));
    }


    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, Var<bool> hoist) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), hoist);
    }

    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, bool hoist) where T: SlCopyButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), b.Const(hoist));
    }


    /// <summary>
    /// <para> Emitted when the data has been copied. </para>
    /// </summary>
    public static void OnSlCopy<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-copy", action);
    }
    /// <summary>
    /// <para> Emitted when the data has been copied. </para>
    /// </summary>
    public static void OnSlCopy<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-copy", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the data has been copied. </para>
    /// </summary>
    public static void OnSlCopy<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-copy", action);
    }
    /// <summary>
    /// <para> Emitted when the data has been copied. </para>
    /// </summary>
    public static void OnSlCopy<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-copy", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the data could not be copied. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the data could not be copied. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the data could not be copied. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the data could not be copied. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCopyButton
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

}

