using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonRefresher
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
        /// Changes the refresher's state from `refreshing` to `cancelling`.
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary>
        /// Call `complete()` when your async operation has completed. For example, the `refreshing` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request. Once the data has been received, you then call this method to signify that the refreshing has completed and to close the refresher. This method also changes the refresher's state from `refreshing` to `completing`.
        /// </summary>
        public const string Complete = "complete";
        /// <summary>
        /// A number representing how far down the user has pulled. The number `0` represents the user hasn't pulled down at all. The number `1`, and anything greater than `1`, represents that the user has pulled far enough down that when they let go then the refresh will happen. If they let go and the number is less than `1`, then the refresh will not happen, and the content will return to it's original position.
        /// </summary>
        public const string GetProgress = "getProgress";
    }
}
/// <summary>
/// Setter extensions of IonRefresher
/// </summary>
public static partial class IonRefresherControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRefresher>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-refresher", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-refresher", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRefresher>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-refresher", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresher(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-refresher", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string closeDuration) 
    {
        b.SetAttribute("closeDuration", closeDuration);
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonRefresher> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonRefresher> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonRefresher> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonRefresher> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration(this Metapsi.Html.AttributesBuilder<IonRefresher> b, string snapbackDuration) 
    {
        b.SetAttribute("snapbackDuration", snapbackDuration);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRefresher>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-refresher", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-refresher", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRefresher>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-refresher", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresher(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-refresher", children);
    }

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> closeDuration) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("closeDuration"), closeDuration);
    }

    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, string closeDuration) where T: IonRefresher
    {
        b.SetCloseDuration(b.Const(closeDuration));
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonRefresher
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> pullFactor) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullFactor"), pullFactor);
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> pullMax) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullMax"), pullMax);
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> pullMin) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullMin"), pullMin);
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> snapbackDuration) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("snapbackDuration"), snapbackDuration);
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, string snapbackDuration) where T: IonRefresher
    {
        b.SetSnapbackDuration(b.Const(snapbackDuration));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionPull", action);
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPull(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionPull", action);
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonPull(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionRefresh", action);
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonRefresh(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionRefresh", action);
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonRefresh(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RefresherEventDetail>>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionRefresh", action);
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionStart", action);
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRefresher
    {
        b.SetProperty(b.Props, "onionStart", action);
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRefresher
    {
        b.OnIonStart(b.MakeAction(action));
    }

}