using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSelectOption : IonComponent
{
    public IonSelectOption() : base("ion-select-option") { }
    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
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
    /// The text value of the option.
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

public static partial class IonSelectOptionControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSelectOption(this LayoutBuilder b, Action<PropsBuilder<IonSelectOption>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-select-option", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSelectOption(this LayoutBuilder b, Action<PropsBuilder<IonSelectOption>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-select-option", buildProps, children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonSelectOption> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The text value of the option.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSelectOption> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// The text value of the option.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSelectOption> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

}

