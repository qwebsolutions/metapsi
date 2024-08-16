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
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content to display at the trailing edge of the select. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> The label text to associate with the select. Use the `labelPlacement` property to control where the label is placed relative to the select. Use this if you need to render a label with custom HTML. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Content to display at the leading edge of the select. </para>
        /// </summary>
        public const string Start = "start";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Open the select overlay. The overlay is either an alert, action sheet, or popover, depending on the `interface` property on the `ion-select`. </para>
        /// <para> (event?: UIEvent) =&gt; Promise&lt;any&gt; </para>
        /// <para> event The user interface event that called the open. </para>
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
    /// <para> The text to display on the cancel button. </para>
    /// </summary>
    public static void SetCancelText(this AttributesBuilder<IonSelect> b,string cancelText)
    {
        b.SetAttribute("cancel-text", cancelText);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax. </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSelect> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith(this AttributesBuilder<IonSelect> b,string compareWith)
    {
        b.SetAttribute("compare-with", compareWith);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the select. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the select. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSelect> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed. </para>
    /// </summary>
    public static void SetExpandedIcon(this AttributesBuilder<IonSelect> b,string expandedIcon)
    {
        b.SetAttribute("expanded-icon", expandedIcon);
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonSelect> b,string fill)
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// <para> The interface the select should use: `action-sheet`, `popover` or `alert`. </para>
    /// </summary>
    public static void SetInterface(this AttributesBuilder<IonSelect> b,string @interface)
    {
        b.SetAttribute("interface", @interface);
    }

    /// <summary>
    /// <para> The interface the select should use: `action-sheet`, `popover` or `alert`. </para>
    /// </summary>
    public static void SetInterfaceActionSheet(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("interface", "action-sheet");
    }

    /// <summary>
    /// <para> The interface the select should use: `action-sheet`, `popover` or `alert`. </para>
    /// </summary>
    public static void SetInterfaceAlert(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("interface", "alert");
    }

    /// <summary>
    /// <para> The interface the select should use: `action-sheet`, `popover` or `alert`. </para>
    /// </summary>
    public static void SetInterfacePopover(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("interface", "popover");
    }

    /// <summary>
    /// <para> Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface. </para>
    /// </summary>
    public static void SetInterfaceOptions(this AttributesBuilder<IonSelect> b,string interfaceOptions)
    {
        b.SetAttribute("interface-options", interfaceOptions);
    }

    /// <summary>
    /// <para> How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonSelect> b,string justify)
    {
        b.SetAttribute("justify", justify);
    }

    /// <summary>
    /// <para> How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("justify", "end");
    }

    /// <summary>
    /// <para> How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("justify", "space-between");
    }

    /// <summary>
    /// <para> How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// <para> The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonSelect> b,string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonSelect> b,string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacementFloating(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "floating");
    }

    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSelect> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, the select can accept multiple values. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> If `true`, the select can accept multiple values. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonSelect> b,bool multiple)
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonSelect> b,string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The text to display on the ok button. </para>
    /// </summary>
    public static void SetOkText(this AttributesBuilder<IonSelect> b,string okText)
    {
        b.SetAttribute("ok-text", okText);
    }

    /// <summary>
    /// <para> The text to display when the select is empty. </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonSelect> b,string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> The text to display instead of the selected option's value. </para>
    /// </summary>
    public static void SetSelectedText(this AttributesBuilder<IonSelect> b,string selectedText)
    {
        b.SetAttribute("selected-text", selectedText);
    }

    /// <summary>
    /// <para> The shape of the select. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonSelect> b,string shape)
    {
        b.SetAttribute("shape", shape);
    }

    /// <summary>
    /// <para> The shape of the select. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonSelect> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// <para> The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode. </para>
    /// </summary>
    public static void SetToggleIcon(this AttributesBuilder<IonSelect> b,string toggleIcon)
    {
        b.SetAttribute("toggle-icon", toggleIcon);
    }

    /// <summary>
    /// <para> The value of the select. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSelect> b,string value)
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
    /// <para> The text to display on the cancel button. </para>
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, Var<string> cancelText) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), cancelText);
    }

    /// <summary>
    /// <para> The text to display on the cancel button. </para>
    /// </summary>
    public static void SetCancelText<T>(this PropsBuilder<T> b, string cancelText) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelText"), b.Const(cancelText));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax. </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<System.Func<object,object,bool>> compareWith) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,bool>>("compareWith"), compareWith);
    }

    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, System.Func<object,object,bool> compareWith) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,bool>>("compareWith"), b.Const(compareWith));
    }


    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<string> compareWith) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), compareWith);
    }

    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, string compareWith) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), b.Const(compareWith));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the select. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the select. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the select. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed. </para>
    /// </summary>
    public static void SetExpandedIcon<T>(this PropsBuilder<T> b, Var<string> expandedIcon) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expandedIcon"), expandedIcon);
    }

    /// <summary>
    /// <para> The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed. </para>
    /// </summary>
    public static void SetExpandedIcon<T>(this PropsBuilder<T> b, string expandedIcon) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expandedIcon"), b.Const(expandedIcon));
    }


    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("outline"));
    }


    /// <summary>
    /// <para> The interface the select should use: `action-sheet`, `popover` or `alert`. </para>
    /// </summary>
    public static void SetInterfaceActionSheet<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("interface"), b.Const("action-sheet"));
    }


    /// <summary>
    /// <para> Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface. </para>
    /// </summary>
    public static void SetInterfaceOptions<T>(this PropsBuilder<T> b, Var<object> interfaceOptions) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("interfaceOptions"), interfaceOptions);
    }

    /// <summary>
    /// <para> Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet) and the [ion-popover docs](./popover) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface. </para>
    /// </summary>
    public static void SetInterfaceOptions<T>(this PropsBuilder<T> b, object interfaceOptions) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("interfaceOptions"), b.Const(interfaceOptions));
    }


    /// <summary>
    /// <para> How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("end"));
    }


    /// <summary>
    /// <para> The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`. </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> If `true`, the select can accept multiple values. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the select can accept multiple values. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> multiple) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), multiple);
    }

    /// <summary>
    /// <para> If `true`, the select can accept multiple values. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool multiple) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(multiple));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The text to display on the ok button. </para>
    /// </summary>
    public static void SetOkText<T>(this PropsBuilder<T> b, Var<string> okText) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("okText"), okText);
    }

    /// <summary>
    /// <para> The text to display on the ok button. </para>
    /// </summary>
    public static void SetOkText<T>(this PropsBuilder<T> b, string okText) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("okText"), b.Const(okText));
    }


    /// <summary>
    /// <para> The text to display when the select is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> The text to display when the select is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> The text to display instead of the selected option's value. </para>
    /// </summary>
    public static void SetSelectedText<T>(this PropsBuilder<T> b, Var<string> selectedText) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selectedText"), selectedText);
    }

    /// <summary>
    /// <para> The text to display instead of the selected option's value. </para>
    /// </summary>
    public static void SetSelectedText<T>(this PropsBuilder<T> b, string selectedText) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selectedText"), b.Const(selectedText));
    }


    /// <summary>
    /// <para> The shape of the select. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("round"));
    }


    /// <summary>
    /// <para> The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode. </para>
    /// </summary>
    public static void SetToggleIcon<T>(this PropsBuilder<T> b, Var<string> toggleIcon) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("toggleIcon"), toggleIcon);
    }

    /// <summary>
    /// <para> The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode. </para>
    /// </summary>
    public static void SetToggleIcon<T>(this PropsBuilder<T> b, string toggleIcon) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("toggleIcon"), b.Const(toggleIcon));
    }


    /// <summary>
    /// <para> The value of the select. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<object> value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }

    /// <summary>
    /// <para> The value of the select. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, object value) where T: IonSelect
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the select loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the select loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the selection is cancelled. </para>
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// <para> Emitted when the selection is cancelled. </para>
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the value has changed. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SelectChangeEventDetail>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the value has changed. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SelectChangeEventDetail>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the overlay is dismissed. </para>
    /// </summary>
    public static void OnIonDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionDismiss", action);
    }
    /// <summary>
    /// <para> Emitted when the overlay is dismissed. </para>
    /// </summary>
    public static void OnIonDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionDismiss", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the select has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the select has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSelect
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

