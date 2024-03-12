using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonInfiniteScroll
{
    public static class Method
    {
        /// <summary> 
        /// Call `complete()` within the `ionInfinite` output event handler when your async operation has completed. For example, the `loading` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request to add more items to a data list. Once the data has been received and UI updated, you then call this method to signify that the loading has completed. This method will change the infinite scroll's state from `loading` to `enabled`.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Complete = "complete";
    }
}

public static partial class IonInfiniteScrollControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScroll(this LayoutBuilder b, Action<PropsBuilder<IonInfiniteScroll>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScroll(this LayoutBuilder b, Action<PropsBuilder<IonInfiniteScroll>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll", buildProps, children);
    }
    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonInfiniteScroll> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom(this PropsBuilder<IonInfiniteScroll> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("bottom"));
    }
    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop(this PropsBuilder<IonInfiniteScroll> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("top"));
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold(this PropsBuilder<IonInfiniteScroll> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("threshold"), value);
    }
    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold(this PropsBuilder<IonInfiniteScroll> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("threshold"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<TModel>(this PropsBuilder<IonInfiniteScroll> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionInfinite"), action);
    }
    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<TModel>(this PropsBuilder<IonInfiniteScroll> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionInfinite"), b.MakeAction(action));
    }

}

