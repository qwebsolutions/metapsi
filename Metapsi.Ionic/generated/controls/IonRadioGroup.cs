using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonRadioGroup
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonRadioGroup
/// </summary>
public static partial class IonRadioGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRadioGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-radio-group", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-radio-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRadioGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-radio-group", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-radio-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, bool allowEmptySelection) 
    {
        if (allowEmptySelection) b.SetAttribute("allowEmptySelection", "");
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b) 
    {
        b.SetAttribute("allowEmptySelection", "");
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string compareWith) 
    {
        b.SetAttribute("compareWith", compareWith);
    }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public static void SetErrorText(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string errorText) 
    {
        b.SetAttribute("errorText", errorText);
    }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public static void SetHelperText(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string helperText) 
    {
        b.SetAttribute("helperText", helperText);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonRadioGroup> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRadioGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-radio-group", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-radio-group", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRadioGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-radio-group", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-radio-group", children);
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRadioGroup
    {
        b.SetAllowEmptySelection(b.Const(true));
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> allowEmptySelection) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("allowEmptySelection"), allowEmptySelection);
    }

    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool allowEmptySelection) where T: IonRadioGroup
    {
        b.SetAllowEmptySelection(b.Const(allowEmptySelection));
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> compareWith) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, bool>> compareWith) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("errorText"), errorText);
    }

    /// <summary>
    /// The error text to display at the top of the radio group.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string errorText) where T: IonRadioGroup
    {
        b.SetErrorText(b.Const(errorText));
    }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("helperText"), helperText);
    }

    /// <summary>
    /// The helper text to display at the top of the radio group.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helperText) where T: IonRadioGroup
    {
        b.SetHelperText(b.Const(helperText));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonRadioGroup
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRadioGroup
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRadioGroup
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RadioGroupChangeEventDetail>>> action) where T: IonRadioGroup
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

}