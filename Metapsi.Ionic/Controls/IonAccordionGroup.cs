using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonAccordionGroup
{
}

public static partial class IonAccordionGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAccordionGroup(this LayoutBuilder b, Action<PropsBuilder<IonAccordionGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-accordion-group", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAccordionGroup(this LayoutBuilder b, Action<PropsBuilder<IonAccordionGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-accordion-group", buildProps, children);
    }
    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandCompact(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("compact"));
    }
    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandInset(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("inset"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly(this PropsBuilder<IonAccordionGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }

    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue(this PropsBuilder<IonAccordionGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue(this PropsBuilder<IonAccordionGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue(this PropsBuilder<IonAccordionGroup> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), value);
    }
    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue(this PropsBuilder<IonAccordionGroup> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the value property.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonAccordionGroup> b, Var<HyperType.Action<TModel, AccordionGroupChangeEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<AccordionGroupChangeEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, AccordionGroupChangeEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionChange"), eventAction);
    }
    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the value property.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonAccordionGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<AccordionGroupChangeEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<AccordionGroupChangeEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, AccordionGroupChangeEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionChange"), eventAction);
    }

}

