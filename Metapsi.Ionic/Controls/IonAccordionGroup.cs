using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonAccordionGroup
{
}

public static partial class IonAccordionGroupControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAccordionGroup(this HtmlBuilder b, Action<AttributesBuilder<IonAccordionGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-accordion-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAccordionGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-accordion-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAccordionGroup(this HtmlBuilder b, Action<AttributesBuilder<IonAccordionGroup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-accordion-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAccordionGroup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-accordion-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, all accordions inside of the accordion group will animate when expanding or collapsing. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, all accordions inside of the accordion group will animate when expanding or collapsing. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonAccordionGroup> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonAccordionGroup> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`. </para>
    /// </summary>
    public static void SetExpand(this AttributesBuilder<IonAccordionGroup> b, string expand)
    {
        b.SetAttribute("expand", expand);
    }

    /// <summary>
    /// <para> Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`. </para>
    /// </summary>
    public static void SetExpandCompact(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("expand", "compact");
    }

    /// <summary>
    /// <para> Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`. </para>
    /// </summary>
    public static void SetExpandInset(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("expand", "inset");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonAccordionGroup> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, the accordion group can have multiple accordion components expanded at the same time. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> If `true`, the accordion group can have multiple accordion components expanded at the same time. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonAccordionGroup> b, bool multiple)
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with, but does not alter the opacity. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonAccordionGroup> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with, but does not alter the opacity. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonAccordionGroup> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"` </para>
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
    /// <para> If `true`, all accordions inside of the accordion group will animate when expanding or collapsing. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, all accordions inside of the accordion group will animate when expanding or collapsing. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, all accordions inside of the accordion group will animate when expanding or collapsing. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`. </para>
    /// </summary>
    public static void SetExpandCompact<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expand"), b.Const("compact"));
    }


    /// <summary>
    /// <para> Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`. </para>
    /// </summary>
    public static void SetExpandInset<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expand"), b.Const("inset"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If `true`, the accordion group can have multiple accordion components expanded at the same time. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the accordion group can have multiple accordion components expanded at the same time. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> multiple) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), multiple);
    }

    /// <summary>
    /// <para> If `true`, the accordion group can have multiple accordion components expanded at the same time. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool multiple) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(multiple));
    }


    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with, but does not alter the opacity. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with, but does not alter the opacity. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), @readonly);
    }

    /// <summary>
    /// <para> If `true`, the accordion group cannot be interacted with, but does not alter the opacity. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"` </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"` </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"` </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), value);
    }

    /// <summary>
    /// <para> The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"` </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, List<string> value) where T: IonAccordionGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the value property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the value property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, AccordionGroupChangeEventDetail>> action) where TComponent: IonAccordionGroup
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the value property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the value property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<AccordionGroupChangeEventDetail>, Var<TModel>> action) where TComponent: IonAccordionGroup
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

