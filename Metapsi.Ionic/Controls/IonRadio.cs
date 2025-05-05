using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRadio
{
}

public static partial class IonRadioControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadio(this HtmlBuilder b, Action<AttributesBuilder<IonRadio>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-radio", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadio(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-radio", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadio(this HtmlBuilder b, Action<AttributesBuilder<IonRadio>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-radio", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadio(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-radio", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonRadio> b, string alignment)
    {
        b.SetAttribute("alignment", alignment);
    }

    /// <summary>
    /// <para> How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// <para> How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonRadio> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the radio. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the radio. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRadio> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonRadio> b, string justify)
    {
        b.SetAttribute("justify", justify);
    }

    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("justify", "end");
    }

    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("justify", "space-between");
    }

    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonRadio> b, string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRadio> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonRadio> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> the value of the radio. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, Action<PropsBuilder<IonRadio>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-radio", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, Action<PropsBuilder<IonRadio>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-radio", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-radio", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-radio", children);
    }
    /// <summary>
    /// <para> How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("center"));
    }


    /// <summary>
    /// <para> How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("start"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the radio. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the radio. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the radio. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("end"));
    }


    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("space-between"));
    }


    /// <summary>
    /// <para> How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements. Setting this property will change the radio `display` to `block`. </para>
    /// </summary>
    public static void SetJustifyStart<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("start"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("stacked"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("start"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const(name));
    }


    /// <summary>
    /// <para> the value of the radio. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> the value of the radio. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonRadio
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the radio button loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the radio button loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the radio button has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the radio button has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

