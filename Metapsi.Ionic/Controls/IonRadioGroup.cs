using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRadioGroup
{
}

public static partial class IonRadioGroupControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadioGroup(this HtmlBuilder b, Action<AttributesBuilder<IonRadioGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-radio-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadioGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-radio-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadioGroup(this HtmlBuilder b, Action<AttributesBuilder<IonRadioGroup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-radio-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRadioGroup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-radio-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the radios can be deselected. </para>
    /// </summary>
    public static void SetAllowEmptySelection(this AttributesBuilder<IonRadioGroup> b)
    {
        b.SetAttribute("allow-empty-selection", "");
    }

    /// <summary>
    /// <para> If `true`, the radios can be deselected. </para>
    /// </summary>
    public static void SetAllowEmptySelection(this AttributesBuilder<IonRadioGroup> b, bool allowEmptySelection)
    {
        if (allowEmptySelection) b.SetAttribute("allow-empty-selection", "");
    }

    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith(this AttributesBuilder<IonRadioGroup> b, string compareWith)
    {
        b.SetAttribute("compare-with", compareWith);
    }

    /// <summary>
    /// <para> The error text to display at the top of the radio group. </para>
    /// </summary>
    public static void SetErrorText(this AttributesBuilder<IonRadioGroup> b, string errorText)
    {
        b.SetAttribute("error-text", errorText);
    }

    /// <summary>
    /// <para> The helper text to display at the top of the radio group. </para>
    /// </summary>
    public static void SetHelperText(this AttributesBuilder<IonRadioGroup> b, string helperText)
    {
        b.SetAttribute("helper-text", helperText);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonRadioGroup> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> the value of the radio group. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonRadioGroup> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadioGroup(this LayoutBuilder b, Action<PropsBuilder<IonRadioGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-radio-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadioGroup(this LayoutBuilder b, Action<PropsBuilder<IonRadioGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-radio-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadioGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-radio-group", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRadioGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-radio-group", children);
    }
    /// <summary>
    /// <para> If `true`, the radios can be deselected. </para>
    /// </summary>
    public static void SetAllowEmptySelection<T>(this PropsBuilder<T> b) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("allowEmptySelection"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the radios can be deselected. </para>
    /// </summary>
    public static void SetAllowEmptySelection<T>(this PropsBuilder<T> b, Var<bool> allowEmptySelection) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("allowEmptySelection"), allowEmptySelection);
    }

    /// <summary>
    /// <para> If `true`, the radios can be deselected. </para>
    /// </summary>
    public static void SetAllowEmptySelection<T>(this PropsBuilder<T> b, bool allowEmptySelection) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("allowEmptySelection"), b.Const(allowEmptySelection));
    }


    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject,DynamicObject,bool>> compareWith) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,DynamicObject,bool>>("compareWith"), compareWith);
    }

    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, System.Func<DynamicObject,DynamicObject,bool> compareWith) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,DynamicObject,bool>>("compareWith"), b.Const(compareWith));
    }


    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<string> compareWith) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), compareWith);
    }

    /// <summary>
    /// <para> This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison. </para>
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, string compareWith) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), b.Const(compareWith));
    }


    /// <summary>
    /// <para> The error text to display at the top of the radio group. </para>
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, Var<string> errorText) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), errorText);
    }

    /// <summary>
    /// <para> The error text to display at the top of the radio group. </para>
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, string errorText) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), b.Const(errorText));
    }


    /// <summary>
    /// <para> The helper text to display at the top of the radio group. </para>
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, Var<string> helperText) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), helperText);
    }

    /// <summary>
    /// <para> The helper text to display at the top of the radio group. </para>
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, string helperText) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), b.Const(helperText));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> the value of the radio group. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("value"), value);
    }

    /// <summary>
    /// <para> the value of the radio group. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RadioGroupChangeEventDetail>> action) where TComponent: IonRadioGroup
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RadioGroupChangeEventDetail>, Var<TModel>> action) where TComponent: IonRadioGroup
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

