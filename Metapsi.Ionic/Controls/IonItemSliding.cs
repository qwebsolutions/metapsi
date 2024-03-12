using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonItemSliding
{
    public static class Method
    {
        /// <summary> 
        /// Close the sliding item. Items can also be closed from the [List](./list).
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Close = "close";
        /// <summary> 
        /// Close all of the sliding items in the list. Items can also be closed from the [List](./list).
        /// <para>() =&gt; Promise&lt;boolean&gt;</para>
        /// </summary>
        public const string CloseOpened = "closeOpened";
        /// <summary> 
        /// Get the amount the item is open in pixels.
        /// <para>() =&gt; Promise&lt;number&gt;</para>
        /// </summary>
        public const string GetOpenAmount = "getOpenAmount";
        /// <summary> 
        /// Get the ratio of the open amount of the item compared to the width of the options. If the number returned is positive, then the options on the right side are open. If the number returned is negative, then the options on the left side are open. If the absolute value of the number is greater than 1, the item is open more than the width of the options.
        /// <para>() =&gt; Promise&lt;number&gt;</para>
        /// </summary>
        public const string GetSlidingRatio = "getSlidingRatio";
        /// <summary> 
        /// Open the sliding item.
        /// <para>(side: Side | undefined) =&gt; Promise&lt;void&gt;</para>
        /// <para>side The side of the options to open. If a side is not provided, it will open the first set of options it finds within the item.</para>
        /// </summary>
        public const string Open = "open";
    }
}

public static partial class IonItemSlidingControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemSliding(this LayoutBuilder b, Action<PropsBuilder<IonItemSliding>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-sliding", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemSliding(this LayoutBuilder b, Action<PropsBuilder<IonItemSliding>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-sliding", buildProps, children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the sliding item.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonItemSliding> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the sliding position changes.
    /// </summary>
    public static void OnIonDrag<TModel>(this PropsBuilder<IonItemSliding> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionDrag"), eventAction);
    }
    /// <summary>
    /// Emitted when the sliding position changes.
    /// </summary>
    public static void OnIonDrag<TModel>(this PropsBuilder<IonItemSliding> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionDrag"), eventAction);
    }

}

