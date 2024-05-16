using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonAccordionGroup : IonComponent
{
    public IonAccordionGroup() : base("ion-accordion-group") { }
}

public static partial class IonAccordionGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonAccordionGroup(this HtmlBuilder b, Action<AttributesBuilder<IonAccordionGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-accordion-group", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonAccordionGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-accordion-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonAccordionGroup> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonAccordionGroup> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpand(this AttributesBuilder<IonAccordionGroup> b, string value)
    {
        b.SetAttribute("expand", value);
    }
    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandCompact(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("expand", "compact");
    }
    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandInset(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("expand", "inset");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonAccordionGroup> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("multiple", "");
    }
    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonAccordionGroup> b, bool value)
    {
        if (value) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("readonly", "");
    }
    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonAccordionGroup> b, bool value)
    {
        if (value) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonAccordionGroup> b, string value)
    {
        b.SetAttribute("value", value);
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonAccordionGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-accordion-group", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAccordionGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-accordion-group", children);
    }
    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandCompact<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("compact"));
    }
    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandInset<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.String("expand"), b.Const("inset"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }

    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), value);
    }
    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, List<string> value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the value property.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, AccordionGroupChangeEventDetail>> action) where TComponent: IonAccordionGroup
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the value property.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<AccordionGroupChangeEventDetail>, Var<TModel>> action) where TComponent: IonAccordionGroup
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

