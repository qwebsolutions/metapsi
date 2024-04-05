using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSelect : IonComponent
{
    public IonSelect() : base("ion-select") { }
    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public string cancelText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("cancelText");
        }
        set
        {
            this.GetTag().SetAttribute("cancelText", value.ToString());
        }
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
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
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public string compareWith
    {
        get
        {
            return this.GetTag().GetAttribute<string>("compareWith");
        }
        set
        {
            this.GetTag().SetAttribute("compareWith", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
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
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public string expandedIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("expandedIcon");
        }
        set
        {
            this.GetTag().SetAttribute("expandedIcon", value.ToString());
        }
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public string fill
    {
        get
        {
            return this.GetTag().GetAttribute<string>("fill");
        }
        set
        {
            this.GetTag().SetAttribute("fill", value.ToString());
        }
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public string @interface
    {
        get
        {
            return this.GetTag().GetAttribute<string>("interface");
        }
        set
        {
            this.GetTag().SetAttribute("interface", value.ToString());
        }
    }

    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public object interfaceOptions
    {
        get
        {
            return this.GetTag().GetAttribute<object>("interfaceOptions");
        }
        set
        {
            this.GetTag().SetAttribute("interfaceOptions", value.ToString());
        }
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
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
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
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
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt components in to the modern form markup when they are using either the `aria-label` attribute or the `label` property. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior. Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
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
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public bool multiple
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("multiple");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("multiple", value.ToString());
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
    /// The text to display on the ok button.
    /// </summary>
    public string okText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("okText");
        }
        set
        {
            this.GetTag().SetAttribute("okText", value.ToString());
        }
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public string placeholder
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placeholder");
        }
        set
        {
            this.GetTag().SetAttribute("placeholder", value.ToString());
        }
    }

    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public string selectedText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("selectedText");
        }
        set
        {
            this.GetTag().SetAttribute("selectedText", value.ToString());
        }
    }

    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public string shape
    {
        get
        {
            return this.GetTag().GetAttribute<string>("shape");
        }
        set
        {
            this.GetTag().SetAttribute("shape", value.ToString());
        }
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public string toggleIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("toggleIcon");
        }
        set
        {
            this.GetTag().SetAttribute("toggleIcon", value.ToString());
        }
    }

    /// <summary>
    /// The value of the select.
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

    public static class Slot
    {
        /// <summary> 
        /// Content to display at the trailing edge of the select.
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// The label text to associate with the select. Use the `labelPlacement` property to control where the label is placed relative to the select. Use this if you need to render a label with custom HTML.
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Content to display at the leading edge of the select.
        /// </summary>
        public const string Start = "start";
    }
    public static class Method
    {
        /// <summary> 
        /// Open the select overlay. The overlay is either an alert, action sheet, or popover, depending on the `interface` property on the `ion-select`.
        /// <para>(event?: UIEvent) =&gt; Promise&lt;any&gt;</para>
        /// <para>event The user interface event that called the open.</para>
        /// </summary>
        public const string Open = "open";
    }
}

public static partial class IonSelectControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSelect(this LayoutBuilder b, Action<PropsBuilder<IonSelect>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-select", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSelect(this LayoutBuilder b, Action<PropsBuilder<IonSelect>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-select", buildProps, children);
    }
    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), value);
    }
    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonSelect> b, Var<Func<object,object,bool>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), f);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonSelect> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<bool>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), b.Def(f));
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), value);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expandedIcon"), value);
    }
    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expandedIcon"), b.Const(value));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfaceActionSheet(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("interface"), b.Const("action-sheet"));
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfaceAlert(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("interface"), b.Const("alert"));
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfacePopover(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("interface"), b.Const("popover"));
    }

    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public static void SetInterfaceOptions(this PropsBuilder<IonSelect> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("interfaceOptions"), value);
    }
    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public static void SetInterfaceOptions(this PropsBuilder<IonSelect> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("interfaceOptions"), b.Const(value));
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("end"));
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("space-between"));
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("start"));
    }

    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementEnd(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFixed(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFloating(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("floating"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStacked(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStart(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt components in to the modern form markup when they are using either the `aria-label` attribute or the `label` property. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior. Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
    /// </summary>
    public static void SetLegacy(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("legacy"), b.Const(true));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("okText"), value);
    }
    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("okText"), b.Const(value));
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selectedText"), value);
    }
    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selectedText"), b.Const(value));
    }

    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this PropsBuilder<IonSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon(this PropsBuilder<IonSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("toggleIcon"), value);
    }
    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon(this PropsBuilder<IonSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("toggleIcon"), b.Const(value));
    }

    /// <summary>
    /// The value of the select.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSelect> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// The value of the select.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSelect> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<TModel>(this PropsBuilder<IonSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<TModel>(this PropsBuilder<IonSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonSelect> b, Var<HyperType.Action<TModel, SelectChangeEventDetail>> action)
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SelectChangeEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<TModel>(this PropsBuilder<IonSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionDismiss", action);
    }
    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<TModel>(this PropsBuilder<IonSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionDismiss", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

