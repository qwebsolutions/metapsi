using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRefresher
{
    public static class Method
    {
        /// <summary>
        /// <para> Changes the refresher's state from `refreshing` to `cancelling`. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary>
        /// <para> Call `complete()` when your async operation has completed. For example, the `refreshing` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request. Once the data has been received, you then call this method to signify that the refreshing has completed and to close the refresher. This method also changes the refresher's state from `refreshing` to `completing`. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Complete = "complete";
        /// <summary>
        /// <para> A number representing how far down the user has pulled. The number `0` represents the user hasn't pulled down at all. The number `1`, and anything greater than `1`, represents that the user has pulled far enough down that when they let go then the refresh will happen. If they let go and the number is less than `1`, then the refresh will not happen, and the content will return to it's original position. </para>
        /// <para> () =&gt; Promise&lt;number&gt; </para>
        /// </summary>
        public const string GetProgress = "getProgress";
    }
}

public static partial class IonRefresherControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresher(this HtmlBuilder b, Action<AttributesBuilder<IonRefresher>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresher(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresher(this HtmlBuilder b, Action<AttributesBuilder<IonRefresher>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresher(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetCloseDuration(this AttributesBuilder<IonRefresher> b, string closeDuration)
    {
        b.SetAttribute("close-duration", closeDuration);
    }

    /// <summary>
    /// <para> If `true`, the refresher will be hidden. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the refresher will be hidden. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRefresher> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRefresher> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullFactor(this AttributesBuilder<IonRefresher> b, string pullFactor)
    {
        b.SetAttribute("pull-factor", pullFactor);
    }

    /// <summary>
    /// <para> The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullMax(this AttributesBuilder<IonRefresher> b, string pullMax)
    {
        b.SetAttribute("pull-max", pullMax);
    }

    /// <summary>
    /// <para> The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullMin(this AttributesBuilder<IonRefresher> b, string pullMin)
    {
        b.SetAttribute("pull-min", pullMin);
    }

    /// <summary>
    /// <para> Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetSnapbackDuration(this AttributesBuilder<IonRefresher> b, string snapbackDuration)
    {
        b.SetAttribute("snapback-duration", snapbackDuration);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresher(this LayoutBuilder b, Action<PropsBuilder<IonRefresher>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-refresher", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresher(this LayoutBuilder b, Action<PropsBuilder<IonRefresher>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-refresher", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresher(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-refresher", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresher(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-refresher", children);
    }
    /// <summary>
    /// <para> Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetCloseDuration<T>(this PropsBuilder<T> b, Var<string> closeDuration) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("closeDuration"), closeDuration);
    }

    /// <summary>
    /// <para> Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetCloseDuration<T>(this PropsBuilder<T> b, string closeDuration) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("closeDuration"), b.Const(closeDuration));
    }


    /// <summary>
    /// <para> If `true`, the refresher will be hidden. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the refresher will be hidden. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the refresher will be hidden. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullFactor<T>(this PropsBuilder<T> b, Var<int> pullFactor) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullFactor"), pullFactor);
    }

    /// <summary>
    /// <para> How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullFactor<T>(this PropsBuilder<T> b, int pullFactor) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullFactor"), b.Const(pullFactor));
    }


    /// <summary>
    /// <para> The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullMax<T>(this PropsBuilder<T> b, Var<int> pullMax) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullMax"), pullMax);
    }

    /// <summary>
    /// <para> The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullMax<T>(this PropsBuilder<T> b, int pullMax) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullMax"), b.Const(pullMax));
    }


    /// <summary>
    /// <para> The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullMin<T>(this PropsBuilder<T> b, Var<int> pullMin) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullMin"), pullMin);
    }

    /// <summary>
    /// <para> The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetPullMin<T>(this PropsBuilder<T> b, int pullMin) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("pullMin"), b.Const(pullMin));
    }


    /// <summary>
    /// <para> Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetSnapbackDuration<T>(this PropsBuilder<T> b, Var<string> snapbackDuration) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("snapbackDuration"), snapbackDuration);
    }

    /// <summary>
    /// <para> Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher. </para>
    /// </summary>
    public static void SetSnapbackDuration<T>(this PropsBuilder<T> b, string snapbackDuration) where T: IonRefresher
    {
        b.SetProperty(b.Props, b.Const("snapbackDuration"), b.Const(snapbackDuration));
    }


    /// <summary>
    /// <para> Emitted while the user is pulling down the content and exposing the refresher. </para>
    /// </summary>
    public static void OnIonPull<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionPull", action);
    }
    /// <summary>
    /// <para> Emitted while the user is pulling down the content and exposing the refresher. </para>
    /// </summary>
    public static void OnIonPull<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionPull", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed. </para>
    /// </summary>
    public static void OnIonRefresh<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RefresherEventDetail>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionRefresh", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed. </para>
    /// </summary>
    public static void OnIonRefresh<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RefresherEventDetail>, Var<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionRefresh", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the user begins to start pulling down. </para>
    /// </summary>
    public static void OnIonStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionStart", action);
    }
    /// <summary>
    /// <para> Emitted when the user begins to start pulling down. </para>
    /// </summary>
    public static void OnIonStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionStart", b.MakeAction(action));
    }

}

