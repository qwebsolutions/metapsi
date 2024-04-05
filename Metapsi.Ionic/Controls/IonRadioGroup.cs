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
    /// <summary>
    /// If `true`, the radios can be deselected.
    /// </summary>
    public bool allowEmptySelection
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("allowEmptySelection");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("allowEmptySelection", value.ToString());
        }
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
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
    /// the value of the radio group.
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

}

public static partial class IonRadioGroupControl
{
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
    /// If `true`, the radios can be deselected.
    /// </summary>
    public static void SetAllowEmptySelection(this PropsBuilder<IonRadioGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("allowEmptySelection"), b.Const(true));
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonRadioGroup> b, Var<Func<object,object,bool>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), f);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonRadioGroup> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<bool>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,bool>>("compareWith"), b.Def(f));
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), value);
    }
    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-radio-group. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this PropsBuilder<IonRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("compareWith"), b.Const(value));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonRadioGroup> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// the value of the radio group.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonRadioGroup> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonRadioGroup> b, Var<HyperType.Action<TModel, RadioGroupChangeEventDetail>> action)
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value has changed.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RadioGroupChangeEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

