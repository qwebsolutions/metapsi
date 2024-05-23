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
    public static IHtmlNode IonSelect(this HtmlBuilder b, Action<AttributesBuilder<IonSelect>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-select", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSelect(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-select", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("cancel-text", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("compare-with", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSelect> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("expanded-icon", value);
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("fill", value);
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("fill", "outline");
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterface(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("interface", value);
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfaceActionSheet(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("interface", "action-sheet");
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfaceAlert(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("interface", "alert");
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfacePopover(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("interface", "popover");
    }

    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public static void SetInterfaceOptions(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("interface-options", value);
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("justify", value);
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("justify", "end");
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("justify", "space-between");
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("label", value);
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("label-placement", value);
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "end");
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFloating(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "floating");
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("multiple", "");
    }
    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonSelect> b, bool value)
    {
        if (value) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("ok-text", value);
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("placeholder", value);
    }

    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("selected-text", value);
    }

    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("shape", value);
    }
    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("toggle-icon", value);
    }

    /// <summary>
    /// The value of the select.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSelect> b, string value)
    {
        b.SetAttribute("value", value);
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonSelect(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-select", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSelect(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-select", children);
    }
    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), value);
    }
    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<Func<object,object,bool>> f) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), f);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<bool>> f) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), b.Def(f));
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), value);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expandedIcon"), value);
    }
    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expandedIcon"), b.Const(value));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfaceActionSheet<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("interface"), b.Const("action-sheet"));
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfaceAlert<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("interface"), b.Const("alert"));
    }
    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover` or `alert`.
    /// </summary>
    public static void SetInterfacePopover<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("interface"), b.Const("popover"));
    }

    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public static void SetInterfaceOptions<T>(this PropsBuilder<T> b, Var<object> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("interfaceOptions"), value);
    }
    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public static void SetInterfaceOptions<T>(this PropsBuilder<T> b, object value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("interfaceOptions"), b.Const(value));
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("end"));
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("space-between"));
    }
    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("start"));
    }

    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("floating"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), value);
    }
    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool value) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(value));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("okText"), value);
    }
    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("okText"), b.Const(value));
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selectedText"), value);
    }
    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selectedText"), b.Const(value));
    }

    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("toggleIcon"), value);
    }
    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon<T>(this PropsBuilder<T> b, string value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("toggleIcon"), b.Const(value));
    }

    /// <summary>
    /// The value of the select.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<object> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// The value of the select.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, object value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SelectChangeEventDetail>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SelectChangeEventDetail>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionDismiss", action);
    }
    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionDismiss", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

