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
    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public string closeDuration
    {
        get
        {
            return this.GetTag().GetAttribute<string>("closeDuration");
        }
        set
        {
            this.GetTag().SetAttribute("closeDuration", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public int pullFactor
    {
        get
        {
            return this.GetTag().GetAttribute<int>("pullFactor");
        }
        set
        {
            this.GetTag().SetAttribute("pullFactor", value.ToString());
        }
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public int pullMax
    {
        get
        {
            return this.GetTag().GetAttribute<int>("pullMax");
        }
        set
        {
            this.GetTag().SetAttribute("pullMax", value.ToString());
        }
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public int pullMin
    {
        get
        {
            return this.GetTag().GetAttribute<int>("pullMin");
        }
        set
        {
            this.GetTag().SetAttribute("pullMin", value.ToString());
        }
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public string snapbackDuration
    {
        get
        {
            return this.GetTag().GetAttribute<string>("snapbackDuration");
        }
        set
        {
            this.GetTag().SetAttribute("snapbackDuration", value.ToString());
        }
    }

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
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration(this PropsBuilder<IonRefresher> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeDuration"), value);
    }
    /// <summary>
    /// Time it takes to close the refresher. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetCloseDuration(this PropsBuilder<IonRefresher> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("closeDuration"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the refresher will be hidden.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonRefresher> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonRefresher> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonRefresher> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor(this PropsBuilder<IonRefresher> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullFactor"), value);
    }
    /// <summary>
    /// How much to multiply the pull speed by. To slow the pull animation down, pass a number less than `1`. To speed up the pull, pass a number greater than `1`. The default value is `1` which is equal to the speed of the cursor. If a negative value is passed in, the factor will be `1` instead.  For example: If the value passed is `1.2` and the content is dragged by `10` pixels, instead of `10` pixels the content will be pulled by `12` pixels (an increase of 20 percent). If the value passed is `0.8`, the dragged amount will be `8` pixels, less than the amount the cursor has moved.  Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullFactor(this PropsBuilder<IonRefresher> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullFactor"), b.Const(value));
    }

    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax(this PropsBuilder<IonRefresher> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMax"), value);
    }
    /// <summary>
    /// The maximum distance of the pull until the refresher will automatically go into the `refreshing` state. Defaults to the result of `pullMin + 60`. Does not apply when  the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMax(this PropsBuilder<IonRefresher> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMax"), b.Const(value));
    }

    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin(this PropsBuilder<IonRefresher> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMin"), value);
    }
    /// <summary>
    /// The minimum distance the user must pull down until the refresher will go into the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetPullMin(this PropsBuilder<IonRefresher> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("pullMin"), b.Const(value));
    }

    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration(this PropsBuilder<IonRefresher> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snapbackDuration"), value);
    }
    /// <summary>
    /// Time it takes the refresher to snap back to the `refreshing` state. Does not apply when the refresher content uses a spinner, enabling the native refresher.
    /// </summary>
    public static void SetSnapbackDuration(this PropsBuilder<IonRefresher> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snapbackDuration"), b.Const(value));
    }

    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<TModel>(this PropsBuilder<IonRefresher> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionPull", action);
    }
    /// <summary>
    /// Emitted while the user is pulling down the content and exposing the refresher.
    /// </summary>
    public static void OnIonPull<TModel>(this PropsBuilder<IonRefresher> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionPull", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<TModel>(this PropsBuilder<IonRefresher> b, Var<HyperType.Action<TModel, RefresherEventDetail>> action)
    {
        b.OnEventAction("onionRefresh", action, "detail");
    }
    /// <summary>
    /// Emitted when the user lets go of the content and has pulled down further than the `pullMin` or pulls the content down and exceeds the pullMax. Updates the refresher state to `refreshing`. The `complete()` method should be called when the async operation has completed.
    /// </summary>
    public static void OnIonRefresh<TModel>(this PropsBuilder<IonRefresher> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RefresherEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionRefresh", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<TModel>(this PropsBuilder<IonRefresher> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionStart", action);
    }
    /// <summary>
    /// Emitted when the user begins to start pulling down.
    /// </summary>
    public static void OnIonStart<TModel>(this PropsBuilder<IonRefresher> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionStart", b.MakeAction(action));
    }

}

