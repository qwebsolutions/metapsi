using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonReorderGroup : IonComponent
{
    public IonReorderGroup() : base("ion-reorder-group") { }
    public static class Method
    {
        /// <summary> 
        /// Completes the reorder operation. Must be called by the `ionItemReorder` event.  If a list of items is passed, the list will be reordered and returned in the proper order.  If no parameters are passed or if `true` is passed in, the reorder will complete and the item will remain in the position it was dragged to. If `false` is passed, the reorder will complete and the item will bounce back to its original position.
        /// <para>(listOrReorder?: boolean | any[]) =&gt; Promise&lt;any&gt;</para>
        /// <para>listOrReorder A list of items to be sorted and returned in the new order or a boolean of whether or not the reorder should reposition the item.</para>
        /// </summary>
        public const string Complete = "complete";
    }
}

public static partial class IonReorderGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonReorderGroup(this HtmlBuilder b, Action<AttributesBuilder<IonReorderGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-reorder-group", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonReorderGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-reorder-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonReorderGroup> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonReorderGroup> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonReorderGroup(this LayoutBuilder b, Action<PropsBuilder<IonReorderGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-reorder-group", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonReorderGroup(this LayoutBuilder b, Action<PropsBuilder<IonReorderGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-reorder-group", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonReorderGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-reorder-group", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonReorderGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-reorder-group", children);
    }
    /// <summary>
    /// If `true`, the reorder will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonReorderGroup
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ItemReorderEventDetail>> action) where TComponent: IonReorderGroup
    {
        b.OnEventAction("onionItemReorder", action, "detail");
    }
    /// <summary>
    /// Event that needs to be listened to in order to complete the reorder action. Once the event has been emitted, the `complete()` method then needs to be called in order to finalize the reorder action.
    /// </summary>
    public static void OnIonItemReorder<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ItemReorderEventDetail>, Var<TModel>> action) where TComponent: IonReorderGroup
    {
        b.OnEventAction("onionItemReorder", b.MakeAction(action), "detail");
    }

}

