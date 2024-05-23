using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonInfiniteScroll : IonComponent
{
    public IonInfiniteScroll() : base("ion-infinite-scroll") { }
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
    public static IHtmlNode IonInfiniteScroll(this HtmlBuilder b, Action<AttributesBuilder<IonInfiniteScroll>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-infinite-scroll", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInfiniteScroll(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-infinite-scroll", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInfiniteScroll> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPosition(this AttributesBuilder<IonInfiniteScroll> b, string value)
    {
        b.SetAttribute("position", value);
    }
    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom(this AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("position", "bottom");
    }
    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop(this AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold(this AttributesBuilder<IonInfiniteScroll> b, string value)
    {
        b.SetAttribute("threshold", value);
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScroll(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScroll(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll", children);
    }
    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom<T>(this PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("bottom"));
    }
    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop<T>(this PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("top"));
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("threshold"), value);
    }
    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold<T>(this PropsBuilder<T> b, string value) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("threshold"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonInfiniteScroll
    {
        b.OnEventAction("onionInfinite", action);
    }
    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonInfiniteScroll
    {
        b.OnEventAction("onionInfinite", b.MakeAction(action));
    }

}

