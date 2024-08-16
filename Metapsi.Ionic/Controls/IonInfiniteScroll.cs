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
        /// <para> Call `complete()` within the `ionInfinite` output event handler when your async operation has completed. For example, the `loading` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request to add more items to a data list. Once the data has been received and UI updated, you then call this method to signify that the loading has completed. This method will change the infinite scroll's state from `loading` to `enabled`. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
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
    /// <para> If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInfiniteScroll> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The position of the infinite scroll element. The value can be either `top` or `bottom`. </para>
    /// </summary>
    public static void SetPosition(this AttributesBuilder<IonInfiniteScroll> b,string position)
    {
        b.SetAttribute("position", position);
    }

    /// <summary>
    /// <para> The position of the infinite scroll element. The value can be either `top` or `bottom`. </para>
    /// </summary>
    public static void SetPositionBottom(this AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("position", "bottom");
    }

    /// <summary>
    /// <para> The position of the infinite scroll element. The value can be either `top` or `bottom`. </para>
    /// </summary>
    public static void SetPositionTop(this AttributesBuilder<IonInfiniteScroll> b)
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// <para> The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page. </para>
    /// </summary>
    public static void SetThreshold(this AttributesBuilder<IonInfiniteScroll> b,string threshold)
    {
        b.SetAttribute("threshold", threshold);
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
    /// <para> If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The position of the infinite scroll element. The value can be either `top` or `bottom`. </para>
    /// </summary>
    public static void SetPositionBottom<T>(this PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("position"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page. </para>
    /// </summary>
    public static void SetThreshold<T>(this PropsBuilder<T> b, Var<string> threshold) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("threshold"), threshold);
    }

    /// <summary>
    /// <para> The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page. </para>
    /// </summary>
    public static void SetThreshold<T>(this PropsBuilder<T> b, string threshold) where T: IonInfiniteScroll
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("threshold"), b.Const(threshold));
    }


    /// <summary>
    /// <para> Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed. </para>
    /// </summary>
    public static void OnIonInfinite<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonInfiniteScroll
    {
        b.OnEventAction("onionInfinite", action);
    }
    /// <summary>
    /// <para> Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed. </para>
    /// </summary>
    public static void OnIonInfinite<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonInfiniteScroll
    {
        b.OnEventAction("onionInfinite", b.MakeAction(action));
    }

}

