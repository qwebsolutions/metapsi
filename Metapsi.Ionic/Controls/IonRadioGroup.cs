using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRadioGroup : IonComponent
{
    public IonRadioGroup() : base("ion-radio-group") { }
}

public static partial class IonRadioGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRadioGroup(this HtmlBuilder b, Action<AttributesBuilder<IonRadioGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-radio-group", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRadioGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-radio-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this AttributesBuilder<IonRadioGroup> b)
    {
        b.SetAttribute("allow-empty-selection", "");
    }
    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this AttributesBuilder<IonRadioGroup> b, bool value)
    {
        if (value) b.SetAttribute("allow-empty-selection", "");
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this AttributesBuilder<IonRadioGroup> b, string value)
    {
        b.SetAttribute("compare-with", value);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonRadioGroup> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// the value of the radio group.
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
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection<T>(this PropsBuilder<T> b) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("allowEmptySelection"), b.Const(true));
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<Func<object,object,bool>> f) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), f);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<bool>> f) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), b.Def(f));
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), value);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this PropsBuilder<T> b, string value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), b.Const(value));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<object> value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, object value) where T: IonRadioGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RadioGroupChangeEventDetail>> action) where TComponent: IonRadioGroup
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RadioGroupChangeEventDetail>, Var<TModel>> action) where TComponent: IonRadioGroup
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

