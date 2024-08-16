using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonPickerColumn : IonComponent
{
    public IonPickerColumn() : base("ion-picker-column") { }
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content to show on the left side of the picker options. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> Content to show on the right side of the picker options. </para>
        /// </summary>
        public const string Suffix = "suffix";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus on the scrollable container within the picker column. Use this method instead of the global `pickerColumn.focus()`. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}

public static partial class IonPickerColumnControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPickerColumn(this HtmlBuilder b, Action<AttributesBuilder<IonPickerColumn>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-picker-column", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPickerColumn(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-picker-column", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonPickerColumn> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the picker. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonPickerColumn> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the picker. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonPickerColumn> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonPickerColumn> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonPickerColumn> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonPickerColumn> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The selected option in the picker. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonPickerColumn> b,string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerColumn(this LayoutBuilder b, Action<PropsBuilder<IonPickerColumn>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker-column", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerColumn(this LayoutBuilder b, Action<PropsBuilder<IonPickerColumn>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker-column", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerColumn(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker-column", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerColumn(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker-column", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the picker. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the picker. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the picker. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The selected option in the picker. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The selected option in the picker. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The selected option in the picker. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The selected option in the picker. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonPickerColumn
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the value has changed. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, PickerColumnChangeEventDetail>> action) where TComponent: IonPickerColumn
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the value has changed. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<PickerColumnChangeEventDetail>, Var<TModel>> action) where TComponent: IonPickerColumn
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

