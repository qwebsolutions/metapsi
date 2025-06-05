using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonAccordionGroup
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
/// Setter extensions of IonAccordionGroup
/// </summary>
public static partial class IonAccordionGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAccordionGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonAccordionGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-accordion-group", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAccordionGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-accordion-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAccordionGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonAccordionGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-accordion-group", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonAccordionGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-accordion-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandCompact(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("expand", "compact");
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandInset(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("expand", "inset");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b, bool multiple) 
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonAccordionGroup> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAccordionGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonAccordionGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-accordion-group", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAccordionGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-accordion-group", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAccordionGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonAccordionGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-accordion-group", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonAccordionGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-accordion-group", children);
    }

    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, all accordions inside of the accordion group will animate when expanding or collapsing.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonAccordionGroup
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonAccordionGroup
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandCompact<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("expand"), b.Const("compact"));
    }

    /// <summary>
    /// Describes the expansion behavior for each accordion. Possible values are `"compact"` and `"inset"`. Defaults to `"compact"`.
    /// </summary>
    public static void SetExpandInset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("expand"), b.Const("inset"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetMultiple(b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> multiple) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    /// If `true`, the accordion group can have multiple accordion components expanded at the same time.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool multiple) where T: IonAccordionGroup
    {
        b.SetMultiple(b.Const(multiple));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonAccordionGroup
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// If `true`, the accordion group cannot be interacted with, but does not alter the opacity.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: IonAccordionGroup
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the accordion group. This controls which accordions are expanded. This should be an array of strings only when `multiple="true"`
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<string>>> value) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonAccordionGroup
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonAccordionGroup
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<AccordionGroupChangeEventDetail>>> action) where T: IonAccordionGroup
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

}