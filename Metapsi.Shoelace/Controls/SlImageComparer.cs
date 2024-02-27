using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlImageComparer
{
}
public partial class SlImageComparerChangeArgs
{
    public IClientSideSlImageComparer target { get; set; }
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
    public static void OnSlChange<TModel>(this PropsBuilder<SlImageComparer> b, Var<HyperType.Action<TModel, SlImageComparerChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlImageComparerChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlImageComparer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlImageComparerChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlImageComparerChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
}

/// <summary>
/// Compare visual differences between similar photos with a sliding panel.
/// </summary>
public partial class SlImageComparer : HtmlTag
{
    public SlImageComparer()
    {
        this.Tag = "sl-image-comparer";
    }

    public static SlImageComparer New()
    {
        return new SlImageComparer();
    }
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
    /// The position of the divider as a percentage.
    /// </summary>
    public static SlImageComparer SetPosition(this SlImageComparer tag, int value)
    {
        return tag.SetAttribute("position", value.ToString());
    }
}

