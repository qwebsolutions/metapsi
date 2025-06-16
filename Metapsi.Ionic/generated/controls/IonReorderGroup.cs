using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonReorderGroup
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
        /// <summary>
        /// Completes the reorder operation. Must be called by the `ionItemReorder` event.  If a list of items is passed, the list will be reordered and returned in the proper order.  If no parameters are passed or if `true` is passed in, the reorder will complete and the item will remain in the position it was dragged to. If `false` is passed, the reorder will complete and the item will bounce back to its original position.
        /// </summary>
        public const string Complete = "complete";
    }
}
/// <summary>
/// Setter extensions of IonReorderGroup
/// </summary>
public static partial class IonReorderGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonReorderGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-reorder-group", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-reorder-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonReorderGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-reorder-group", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonReorderGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-reorder-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonReorderGroup> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonReorderGroup> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonReorderGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-reorder-group", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-reorder-group", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonReorderGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-reorder-group", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonReorderGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-reorder-group", children);
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonReorderGroup
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonReorderGroup
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonReorderGroup
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Props, "onionItemReorder", action);
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonItemReorder(b.MakeAction(action));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Props, "onionItemReorder", action);
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonReorderGroup
    {
        b.OnIonItemReorder(b.MakeAction(action));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<ItemReorderEventDetail>>> action) where T: IonReorderGroup
    {
        b.SetProperty(b.Props, "onionItemReorder", action);
    }

}