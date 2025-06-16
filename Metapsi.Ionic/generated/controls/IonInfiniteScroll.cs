using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonInfiniteScroll
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
        /// Call `complete()` within the `ionInfinite` output event handler when your async operation has completed. For example, the `loading` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request to add more items to a data list. Once the data has been received and UI updated, you then call this method to signify that the loading has completed. This method will change the infinite scroll's state from `loading` to `enabled`.
        /// </summary>
        public const string Complete = "complete";
    }
}
/// <summary>
/// Setter extensions of IonInfiniteScroll
/// </summary>
public static partial class IonInfiniteScrollControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInfiniteScroll>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-infinite-scroll", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-infinite-scroll", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInfiniteScroll>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-infinite-scroll", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScroll(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-infinite-scroll", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b) 
    {
        b.SetAttribute("position", "bottom");
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b) 
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold(this Metapsi.Html.AttributesBuilder<IonInfiniteScroll> b, string threshold) 
    {
        b.SetAttribute("threshold", threshold);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInfiniteScroll>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-infinite-scroll", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-infinite-scroll", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInfiniteScroll>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-infinite-scroll", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScroll(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-infinite-scroll", children);
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the infinite scroll will be hidden and scroll event listeners will be removed.  Set this to true to disable the infinite scroll from actively trying to receive new data while scrolling. This is useful when it is known that there is no more data that can be added, and the infinite scroll is no longer needed.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonInfiniteScroll
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("bottom"));
    }

    /// <summary>
    /// The position of the infinite scroll element. The value can be either `top` or `bottom`.
    /// </summary>
    public static void SetPositionTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("top"));
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> threshold) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Props, b.Const("threshold"), threshold);
    }

    /// <summary>
    /// The threshold distance from the bottom of the content to call the `infinite` output event when scrolled. The threshold value can be either a percent, or in pixels. For example, use the value of `10%` for the `infinite` output event to get called when the user has scrolled 10% from the bottom of the page. Use the value `100px` when the scroll is within 100 pixels from the bottom of the page.
    /// </summary>
    public static void SetThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, string threshold) where T: IonInfiniteScroll
    {
        b.SetThreshold(b.Const(threshold));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Props, "onionInfinite", action);
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInfiniteScroll
    {
        b.OnIonInfinite(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInfiniteScroll
    {
        b.SetProperty(b.Props, "onionInfinite", action);
    }

    /// <summary>
    /// Emitted when the scroll reaches the threshold distance. From within your infinite handler, you must call the infinite scroll's `complete()` method when your async operation has completed.
    /// </summary>
    public static void OnIonInfinite<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInfiniteScroll
    {
        b.OnIonInfinite(b.MakeAction(action));
    }

}