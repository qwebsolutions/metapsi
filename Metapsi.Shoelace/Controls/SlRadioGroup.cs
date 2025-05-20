using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlRadioGroup
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The radio group's label. Required for proper accessibility. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Text that describes how to use the radio group. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
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
        /// <summary>
        /// <para> Sets focus on the radio-group. </para>
        /// </summary>
        public const string Focus = "focus";
    }
}

public static partial class SlRadioGroupControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadioGroup(this HtmlBuilder b, Action<AttributesBuilder<SlRadioGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-radio-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadioGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-radio-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadioGroup(this HtmlBuilder b, Action<AttributesBuilder<SlRadioGroup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-radio-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadioGroup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-radio-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlRadioGroup> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The radio groups's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlRadioGroup> b, string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// <para> The name of the radio group, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlRadioGroup> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The current value of the radio group, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlRadioGroup> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlRadioGroup> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlRadioGroup> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlRadioGroup> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlRadioGroup> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlRadioGroup> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Ensures a child radio is checked before allowing the containing form to submit. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlRadioGroup> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> Ensures a child radio is checked before allowing the containing form to submit. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlRadioGroup> b, bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioGroup(this LayoutBuilder b, Action<PropsBuilder<SlRadioGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-radio-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioGroup(this LayoutBuilder b, Action<PropsBuilder<SlRadioGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-radio-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-radio-group", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-radio-group", children);
    }
    /// <summary>
    /// <para> The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// <para> The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The radio groups's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// <para> The radio groups's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> The name of the radio group, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// <para> The name of the radio group, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the radio group, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The current value of the radio group, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The radio group's size. This size will be applied to all child radios and radio buttons. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Ensures a child radio is checked before allowing the containing form to submit. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("required"), b.Const(true));
    }


    /// <summary>
    /// <para> Ensures a child radio is checked before allowing the containing form to submit. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// <para> Ensures a child radio is checked before allowing the containing form to submit. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("required"), b.Const(required));
    }


    /// <summary>
    /// <para> Emitted when the radio group's selected value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the radio group's selected value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the radio group's selected value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the radio group's selected value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the radio group receives user input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the radio group receives user input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the radio group receives user input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the radio group receives user input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadioGroup
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

