using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRange
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The range's label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Text that describes how to use the input. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus on the range. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the range. </para>
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// <para> Increments the value of the range by the value of the step attribute. </para>
        /// </summary>
        public const string StepUp = "stepUp";
        /// <summary>
        /// <para> Decrements the value of the range by the value of the step attribute. </para>
        /// </summary>
        public const string StepDown = "stepDown";
        /// <summary>
        /// <para> Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid. </para>
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary>
        /// <para> Gets the associated form, if one exists. </para>
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary>
        /// <para> Checks for validity and shows the browser's validation message if the control is invalid. </para>
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary>
        /// <para> Sets a custom validation message. Pass an empty string to restore validity. </para>
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlRangeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRange(this HtmlBuilder b, Action<AttributesBuilder<SlRange>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-range", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRange(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-range", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRange(this HtmlBuilder b, Action<AttributesBuilder<SlRange>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-range", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRange(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-range", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the range, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlRange> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The current value of the range, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlRange> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The range's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlRange> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The range's help text. If you need to display HTML, use the help-text slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlRange> b, string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// <para> Disables the range. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRange> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the range. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRange> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The minimum acceptable value of the range. </para>
    /// </summary>
    public static void SetMin(this AttributesBuilder<SlRange> b, string min)
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// <para> The maximum acceptable value of the range. </para>
    /// </summary>
    public static void SetMax(this AttributesBuilder<SlRange> b, string max)
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// <para> The interval at which the range will increase and decrease. </para>
    /// </summary>
    public static void SetStep(this AttributesBuilder<SlRange> b, string step)
    {
        b.SetAttribute("step", step);
    }

    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltip(this AttributesBuilder<SlRange> b, string tooltip)
    {
        b.SetAttribute("tooltip", tooltip);
    }

    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltipTop(this AttributesBuilder<SlRange> b)
    {
        b.SetAttribute("tooltip", "top");
    }

    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltipBottom(this AttributesBuilder<SlRange> b)
    {
        b.SetAttribute("tooltip", "bottom");
    }

    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltipNone(this AttributesBuilder<SlRange> b)
    {
        b.SetAttribute("tooltip", "none");
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlRange> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRange(this LayoutBuilder b, Action<PropsBuilder<SlRange>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-range", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRange(this LayoutBuilder b, Action<PropsBuilder<SlRange>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-range", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRange(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-range", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRange(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-range", children);
    }
    /// <summary>
    /// <para> The name of the range, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the range, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the range, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The current value of the range, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The range's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The range's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The range's help text. If you need to display HTML, use the help-text slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), helpText);
    }

    /// <summary>
    /// <para> The range's help text. If you need to display HTML, use the help-text slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> Disables the range. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the range. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the range. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The minimum acceptable value of the range. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<int> min) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), min);
    }

    /// <summary>
    /// <para> The minimum acceptable value of the range. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, int min) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(min));
    }


    /// <summary>
    /// <para> The maximum acceptable value of the range. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> max) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), max);
    }

    /// <summary>
    /// <para> The maximum acceptable value of the range. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int max) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(max));
    }


    /// <summary>
    /// <para> The interval at which the range will increase and decrease. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, Var<int> step) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), step);
    }

    /// <summary>
    /// <para> The interval at which the range will increase and decrease. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, int step) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), b.Const(step));
    }


    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltipTop<T>(this PropsBuilder<T> b) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltip"), b.Const("top"));
    }


    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltipBottom<T>(this PropsBuilder<T> b) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltip"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The preferred placement of the range's tooltip. </para>
    /// </summary>
    public static void SetTooltipNone<T>(this PropsBuilder<T> b) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tooltip"), b.Const("none"));
    }


    /// <summary>
    /// <para> A function used to format the tooltip's value. The range's value is passed as the first and only argument. The function should return a string to display in the tooltip. </para>
    /// </summary>
    public static void SetTooltipFormatter<T>(this PropsBuilder<T> b, Var<System.Func<int,string>> tooltipFormatter) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,string>>("tooltipFormatter"), tooltipFormatter);
    }

    /// <summary>
    /// <para> A function used to format the tooltip's value. The range's value is passed as the first and only argument. The function should return a string to display in the tooltip. </para>
    /// </summary>
    public static void SetTooltipFormatter<T>(this PropsBuilder<T> b, System.Func<int,string> tooltipFormatter) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,string>>("tooltipFormatter"), b.Const(tooltipFormatter));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, Var<int> defaultValue) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("defaultValue"), defaultValue);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, int defaultValue) where T: SlRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("defaultValue"), b.Const(defaultValue));
    }


    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRange
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

