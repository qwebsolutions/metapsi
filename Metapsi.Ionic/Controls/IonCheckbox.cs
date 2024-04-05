using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonCheckbox : IonComponent
{
    public IonCheckbox() : base("ion-checkbox") { }
    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public string alignment
    {
        get
        {
            return this.GetTag().GetAttribute<string>("alignment");
        }
        set
        {
            this.GetTag().SetAttribute("alignment", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
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
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color
    {
        get
        {
            return this.GetTag().GetAttribute<string>("color");
        }
        set
        {
            this.GetTag().SetAttribute("color", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
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
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public bool indeterminate
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("indeterminate");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("indeterminate", value.ToString());
        }
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public string justify
    {
        get
        {
            return this.GetTag().GetAttribute<string>("justify");
        }
        set
        {
            this.GetTag().SetAttribute("justify", value.ToString());
        }
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public string labelPlacement
    {
        get
        {
            return this.GetTag().GetAttribute<string>("labelPlacement");
        }
        set
        {
            this.GetTag().SetAttribute("labelPlacement", value.ToString());
        }
    }

    /// <summary>
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt checkboxes in to the modern form markup when they are using either the `aria-label` attribute or have text in the default slot. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior.  Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
    /// </summary>
    public bool legacy
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("legacy");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("legacy", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public string name
    {
        get
        {
            return this.GetTag().GetAttribute<string>("name");
        }
        set
        {
            this.GetTag().SetAttribute("name", value.ToString());
        }
    }

    /// <summary>
    /// The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `<input type="checkbox">`, it's only used when the checkbox participates in a native `<form>`.
    /// </summary>
    public object value
    {
        get
        {
            return this.GetTag().GetAttribute<object>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary> 
    /// The label text to associate with the checkbox. Use the "labelPlacement" property to control where the label is placed relative to the checkbox.
    /// </summary>
    public static class Slot
    {
    }
}

public static partial class IonCheckboxControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonCheckbox(this LayoutBuilder b, Action<PropsBuilder<IonCheckbox>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-checkbox", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonCheckbox(this LayoutBuilder b, Action<PropsBuilder<IonCheckbox>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-checkbox", buildProps, children);
    }
    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentCenter(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("center"));
    }
    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentStart(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
    /// </summary>
    public static void SetChecked(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(true));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public static void SetIndeterminate(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("indeterminate"), b.Const(true));
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("end"));
    }
    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("space-between"));
    }
    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("start"));
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt checkboxes in to the modern form markup when they are using either the `aria-label` attribute or have text in the default slot. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior.  Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
    /// </summary>
    public static void SetLegacy(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("legacy"), b.Const(true));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `<input type="checkbox">`, it's only used when the checkbox participates in a native `<form>`.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonCheckbox> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `<input type="checkbox">`, it's only used when the checkbox participates in a native `<form>`.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonCheckbox> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the checked property.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonCheckbox> b, Var<HyperType.Action<TModel, CheckboxChangeEventDetail>> action)
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the checked property.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<CheckboxChangeEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the checkbox has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the checkbox has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

