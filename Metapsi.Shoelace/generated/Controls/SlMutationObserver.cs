using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
/// </summary>
public partial class SlMutationObserver
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
/// Setter extensions of SlMutationObserver
/// </summary>
public static partial class SlMutationObserverControl
{
    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMutationObserver(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMutationObserver>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-mutation-observer", buildAttributes, children);
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMutationObserver(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-mutation-observer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMutationObserver(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMutationObserver>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-mutation-observer", buildAttributes, children);
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMutationObserver(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-mutation-observer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`.
    /// </summary>
    public static void SetAttr(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b, string attr) 
    {
        b.SetAttribute("attr", attr);
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public static void SetAttrOldValue(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b, bool attrOldValue) 
    {
        if (attrOldValue) b.SetAttribute("attr-old-value", "");
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public static void SetAttrOldValue(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b) 
    {
        b.SetAttribute("attr-old-value", "");
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public static void SetCharData(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b, bool charData) 
    {
        if (charData) b.SetAttribute("char-data", "");
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public static void SetCharData(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b) 
    {
        b.SetAttribute("char-data", "");
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public static void SetCharDataOldValue(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b, bool charDataOldValue) 
    {
        if (charDataOldValue) b.SetAttribute("char-data-old-value", "");
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public static void SetCharDataOldValue(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b) 
    {
        b.SetAttribute("char-data-old-value", "");
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public static void SetChildList(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b, bool childList) 
    {
        if (childList) b.SetAttribute("child-list", "");
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public static void SetChildList(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b) 
    {
        b.SetAttribute("child-list", "");
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlMutationObserver> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMutationObserver(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMutationObserver>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-mutation-observer", buildProps, children);
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMutationObserver(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-mutation-observer", children);
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMutationObserver(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMutationObserver>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-mutation-observer", buildProps, children);
    }

    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMutationObserver(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-mutation-observer", children);
    }

    /// <summary>
    /// Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`.
    /// </summary>
    public static void SetAttr<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> attr) where T: SlMutationObserver
    {
        b.SetProperty(b.Props, b.Const("attr"), attr);
    }

    /// <summary>
    /// Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`.
    /// </summary>
    public static void SetAttr<T>(this Metapsi.Syntax.PropsBuilder<T> b, string attr) where T: SlMutationObserver
    {
        b.SetAttr(b.Const(attr));
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public static void SetAttrOldValue<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetAttrOldValue(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public static void SetAttrOldValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> attrOldValue) where T: SlMutationObserver
    {
        b.SetProperty(b.Props, b.Const("attrOldValue"), attrOldValue);
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public static void SetAttrOldValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool attrOldValue) where T: SlMutationObserver
    {
        b.SetAttrOldValue(b.Const(attrOldValue));
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public static void SetCharData<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetCharData(b.Const(true));
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public static void SetCharData<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> charData) where T: SlMutationObserver
    {
        b.SetProperty(b.Props, b.Const("charData"), charData);
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public static void SetCharData<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool charData) where T: SlMutationObserver
    {
        b.SetCharData(b.Const(charData));
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public static void SetCharDataOldValue<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetCharDataOldValue(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public static void SetCharDataOldValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> charDataOldValue) where T: SlMutationObserver
    {
        b.SetProperty(b.Props, b.Const("charDataOldValue"), charDataOldValue);
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public static void SetCharDataOldValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool charDataOldValue) where T: SlMutationObserver
    {
        b.SetCharDataOldValue(b.Const(charDataOldValue));
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public static void SetChildList<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetChildList(b.Const(true));
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public static void SetChildList<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> childList) where T: SlMutationObserver
    {
        b.SetProperty(b.Props, b.Const("childList"), childList);
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public static void SetChildList<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool childList) where T: SlMutationObserver
    {
        b.SetChildList(b.Const(childList));
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlMutationObserver
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlMutationObserver
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlMutationObserver
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlMutationObserver
    {
        b.OnSlEvent("onsl-mutation", action);
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlMutationObserver
    {
        b.OnSlMutation(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlMutationObserver
    {
        b.OnSlEvent("onsl-mutation", action);
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlMutationObserver
    {
        b.OnSlMutation(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlMutationDetail>>> action) where T: SlMutationObserver
    {
        b.OnSlEvent("onsl-mutation", action);
    }

}