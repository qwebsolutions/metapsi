using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlImageComparer
{
    public static class Slot
    {
        /// <summary> 
        /// The before image, an `<img>` or `<svg>` element.
        /// </summary>
        public const string Before = "before";
        /// <summary> 
        /// The after image, an `<img>` or `<svg>` element.
        /// </summary>
        public const string After = "after";
        /// <summary> 
        /// The icon used inside the handle.
        /// </summary>
        public const string Handle = "handle";
    }
}

public static partial class SlImageComparerControl
{
    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Var<IVNode> SlImageComparer(this LayoutBuilder b, Action<PropsBuilder<SlImageComparer>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-image-comparer", buildProps, children);
    }
    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Var<IVNode> SlImageComparer(this LayoutBuilder b, Action<PropsBuilder<SlImageComparer>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-image-comparer", buildProps, children);
    }
    /// <summary>
    /// The position of the divider as a percentage.
    /// </summary>
    public static void SetPosition(this PropsBuilder<SlImageComparer> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), value);
    }
    /// <summary>
    /// The position of the divider as a percentage.
    /// </summary>
    public static void SetPosition(this PropsBuilder<SlImageComparer> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlImageComparer> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), eventAction);
    }
    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlImageComparer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), eventAction);
    }

}

