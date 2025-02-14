using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonSelectOption
{
}

public static partial class IonSelectOptionControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectOption(this HtmlBuilder b, Action<AttributesBuilder<IonSelectOption>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-select-option", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectOption(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-select-option", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectOption(this HtmlBuilder b, Action<AttributesBuilder<IonSelectOption>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-select-option", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectOption(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-select-option", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSelectOption> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSelectOption> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The text value of the option. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSelectOption> b, string value)
    {
        b.SetAttribute("value", value);
    }

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
    ///
    /// </summary>
    public static Var<IVNode> IonSelectOption(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-select-option", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSelectOption(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-select-option", children);
    }
    /// <summary>
    /// <para> If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSelectOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSelectOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the select option. This property does not apply when `interface="action-sheet"` as `ion-action-sheet` does not allow for disabled buttons. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSelectOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The text value of the option. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonSelectOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("value"), value);
    }

    /// <summary>
    /// <para> The text value of the option. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonSelectOption
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("value"), b.Const(value));
    }


}

