using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRefresher : IonComponent
{
    public IonRefresher() : base("ion-refresher") { }
    public static class Method
    {
        /// <summary> 
        /// Changes the refresher's state from `refreshing` to `cancelling`.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary> 
        /// Call `complete()` when your async operation has completed. For example, the `refreshing` state is while the app is performing an asynchronous operation, such as receiving more data from an AJAX request. Once the data has been received, you then call this method to signify that the refreshing has completed and to close the refresher. This method also changes the refresher's state from `refreshing` to `completing`.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Complete = "complete";
        /// <summary> 
        /// A number representing how far down the user has pulled. The number `0` represents the user hasn't pulled down at all. The number `1`, and anything greater than `1`, represents that the user has pulled far enough down that when they let go then the refresh will happen. If they let go and the number is less than `1`, then the refresh will not happen, and the content will return to it's original position.
        /// <para>() =&gt; Promise&lt;number&gt;</para>
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
        return b.Tag("ion-refresher", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRefresher(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-refresher", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration(this AttributesBuilder<IonRefresher> b, string value)
    {
        b.SetAttribute("close-duration", value);
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRefresher> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRefresher> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRefresher> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor(this AttributesBuilder<IonRefresher> b, string value)
    {
        b.SetAttribute("pull-factor", value);
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax(this AttributesBuilder<IonRefresher> b, string value)
    {
        b.SetAttribute("pull-max", value);
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin(this AttributesBuilder<IonRefresher> b, string value)
    {
        b.SetAttribute("pull-min", value);
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration(this AttributesBuilder<IonRefresher> b, string value)
    {
        b.SetAttribute("snapback-duration", value);
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
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeDuration"), value);
    }
    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration<T>(this PropsBuilder<T> b, string value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeDuration"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRefresher
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullFactor"), value);
    }
    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor<T>(this PropsBuilder<T> b, int value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullFactor"), b.Const(value));
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMax"), value);
    }
    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax<T>(this PropsBuilder<T> b, int value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMax"), b.Const(value));
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMin"), value);
    }
    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin<T>(this PropsBuilder<T> b, int value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMin"), b.Const(value));
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snapbackDuration"), value);
    }
    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration<T>(this PropsBuilder<T> b, string value) where T: IonRefresher
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snapbackDuration"), b.Const(value));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionPull", action);
    }
    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionPull", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RefresherEventDetail>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionRefresh", action, "detail");
    }
    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RefresherEventDetail>, Var<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionRefresh", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionStart", action);
    }
    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRefresher
    {
        b.OnEventAction("onionStart", b.MakeAction(action));
    }

}

