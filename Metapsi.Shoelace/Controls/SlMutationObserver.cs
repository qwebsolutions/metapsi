using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlMutationObserver
{
}

public static partial class SlMutationObserverControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMutationObserver(this HtmlBuilder b, Action<AttributesBuilder<SlMutationObserver>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-mutation-observer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMutationObserver(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-mutation-observer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMutationObserver(this HtmlBuilder b, Action<AttributesBuilder<SlMutationObserver>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-mutation-observer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMutationObserver(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-mutation-observer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`. </para>
    /// </summary>
    public static void SetAttr(this AttributesBuilder<SlMutationObserver> b, string attr)
    {
        b.SetAttribute("attr", attr);
    }

    /// <summary>
    /// <para> Indicates whether or not the attribute's previous value should be recorded when monitoring changes. </para>
    /// </summary>
    public static void SetAttrOldValue(this AttributesBuilder<SlMutationObserver> b)
    {
        b.SetAttribute("attr-old-value", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the attribute's previous value should be recorded when monitoring changes. </para>
    /// </summary>
    public static void SetAttrOldValue(this AttributesBuilder<SlMutationObserver> b, bool attrOldValue)
    {
        if (attrOldValue) b.SetAttribute("attr-old-value", "");
    }

    /// <summary>
    /// <para> Watches for changes to the character data contained within the node. </para>
    /// </summary>
    public static void SetCharData(this AttributesBuilder<SlMutationObserver> b)
    {
        b.SetAttribute("char-data", "");
    }

    /// <summary>
    /// <para> Watches for changes to the character data contained within the node. </para>
    /// </summary>
    public static void SetCharData(this AttributesBuilder<SlMutationObserver> b, bool charData)
    {
        if (charData) b.SetAttribute("char-data", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the previous value of the node's text should be recorded. </para>
    /// </summary>
    public static void SetCharDataOldValue(this AttributesBuilder<SlMutationObserver> b)
    {
        b.SetAttribute("char-data-old-value", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the previous value of the node's text should be recorded. </para>
    /// </summary>
    public static void SetCharDataOldValue(this AttributesBuilder<SlMutationObserver> b, bool charDataOldValue)
    {
        if (charDataOldValue) b.SetAttribute("char-data-old-value", "");
    }

    /// <summary>
    /// <para> Watches for the addition or removal of new child nodes. </para>
    /// </summary>
    public static void SetChildList(this AttributesBuilder<SlMutationObserver> b)
    {
        b.SetAttribute("child-list", "");
    }

    /// <summary>
    /// <para> Watches for the addition or removal of new child nodes. </para>
    /// </summary>
    public static void SetChildList(this AttributesBuilder<SlMutationObserver> b, bool childList)
    {
        if (childList) b.SetAttribute("child-list", "");
    }

    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlMutationObserver> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlMutationObserver> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMutationObserver(this LayoutBuilder b, Action<PropsBuilder<SlMutationObserver>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-mutation-observer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMutationObserver(this LayoutBuilder b, Action<PropsBuilder<SlMutationObserver>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-mutation-observer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMutationObserver(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-mutation-observer", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMutationObserver(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-mutation-observer", children);
    }
    /// <summary>
    /// <para> Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`. </para>
    /// </summary>
    public static void SetAttr<T>(this PropsBuilder<T> b, Var<string> attr) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("attr"), attr);
    }

    /// <summary>
    /// <para> Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`. </para>
    /// </summary>
    public static void SetAttr<T>(this PropsBuilder<T> b, string attr) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("attr"), b.Const(attr));
    }


    /// <summary>
    /// <para> Indicates whether or not the attribute's previous value should be recorded when monitoring changes. </para>
    /// </summary>
    public static void SetAttrOldValue<T>(this PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("attrOldValue"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the attribute's previous value should be recorded when monitoring changes. </para>
    /// </summary>
    public static void SetAttrOldValue<T>(this PropsBuilder<T> b, Var<bool> attrOldValue) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("attrOldValue"), attrOldValue);
    }

    /// <summary>
    /// <para> Indicates whether or not the attribute's previous value should be recorded when monitoring changes. </para>
    /// </summary>
    public static void SetAttrOldValue<T>(this PropsBuilder<T> b, bool attrOldValue) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("attrOldValue"), b.Const(attrOldValue));
    }


    /// <summary>
    /// <para> Watches for changes to the character data contained within the node. </para>
    /// </summary>
    public static void SetCharData<T>(this PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("charData"), b.Const(true));
    }


    /// <summary>
    /// <para> Watches for changes to the character data contained within the node. </para>
    /// </summary>
    public static void SetCharData<T>(this PropsBuilder<T> b, Var<bool> charData) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("charData"), charData);
    }

    /// <summary>
    /// <para> Watches for changes to the character data contained within the node. </para>
    /// </summary>
    public static void SetCharData<T>(this PropsBuilder<T> b, bool charData) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("charData"), b.Const(charData));
    }


    /// <summary>
    /// <para> Indicates whether or not the previous value of the node's text should be recorded. </para>
    /// </summary>
    public static void SetCharDataOldValue<T>(this PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("charDataOldValue"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the previous value of the node's text should be recorded. </para>
    /// </summary>
    public static void SetCharDataOldValue<T>(this PropsBuilder<T> b, Var<bool> charDataOldValue) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("charDataOldValue"), charDataOldValue);
    }

    /// <summary>
    /// <para> Indicates whether or not the previous value of the node's text should be recorded. </para>
    /// </summary>
    public static void SetCharDataOldValue<T>(this PropsBuilder<T> b, bool charDataOldValue) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("charDataOldValue"), b.Const(charDataOldValue));
    }


    /// <summary>
    /// <para> Watches for the addition or removal of new child nodes. </para>
    /// </summary>
    public static void SetChildList<T>(this PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("childList"), b.Const(true));
    }


    /// <summary>
    /// <para> Watches for the addition or removal of new child nodes. </para>
    /// </summary>
    public static void SetChildList<T>(this PropsBuilder<T> b, Var<bool> childList) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("childList"), childList);
    }

    /// <summary>
    /// <para> Watches for the addition or removal of new child nodes. </para>
    /// </summary>
    public static void SetChildList<T>(this PropsBuilder<T> b, bool childList) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("childList"), b.Const(childList));
    }


    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlMutationObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when a mutation occurs. </para>
    /// </summary>
    public static void OnSlMutation<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlMutationObserver
    {
        b.OnEventAction("onsl-mutation", action);
    }
    /// <summary>
    /// <para> Emitted when a mutation occurs. </para>
    /// </summary>
    public static void OnSlMutation<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlMutationObserver
    {
        b.OnEventAction("onsl-mutation", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a mutation occurs. </para>
    /// </summary>
    public static void OnSlMutation<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlMutationObserver
    {
        b.OnEventAction("onsl-mutation", action);
    }
    /// <summary>
    /// <para> Emitted when a mutation occurs. </para>
    /// </summary>
    public static void OnSlMutation<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlMutationObserver
    {
        b.OnEventAction("onsl-mutation", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a mutation occurs. </para>
    /// </summary>
    public static void OnSlMutation<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlMutationEventArgs>> action) where TComponent: SlMutationObserver
    {
        b.OnEventAction("onsl-mutation", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when a mutation occurs. </para>
    /// </summary>
    public static void OnSlMutation<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlMutationEventArgs>, Var<TModel>> action) where TComponent: SlMutationObserver
    {
        b.OnEventAction("onsl-mutation", b.MakeAction(action), "detail");
    }

}

