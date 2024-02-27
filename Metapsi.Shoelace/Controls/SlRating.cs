using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlRating
{
    public int value { get; set; }
}
public partial class SlRatingChangeArgs
{
    public IClientSideSlRating target { get; set; }
}
public partial class SlRatingHoverArgs
{
    public IClientSideSlRating target { get; set; }
    public partial class Details 
    {
        public string phase { get; set; }
        public int value { get; set; }
    }
    public Details detail { get; set; }
}
public static partial class SlRatingControl
{
    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Action<PropsBuilder<SlRating>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-rating", buildProps, children);
    }
    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Action<PropsBuilder<SlRating>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-rating", buildProps, children);
    }
    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRating> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRating> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }
    /// <summary>
    /// The current rating.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRating> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The current rating.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRating> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlRating> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlRating> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }
    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public static void SetPrecision(this PropsBuilder<SlRating> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("precision"), value);
    }
    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public static void SetPrecision(this PropsBuilder<SlRating> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("precision"), b.Const(value));
    }
    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly(this PropsBuilder<SlRating> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }
    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlRating> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `<sl-icon>` elements.
    /// </summary>
    public static void SetGetSymbol(this PropsBuilder<SlRating> b, Var<Func<int,string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,string>>("getSymbol"), f);
    }
    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel, SlRatingChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRatingChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRatingChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRatingChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// event detail: { phase: 'start' | 'move' | 'end', value: number }
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel, SlRatingHoverArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRatingHoverArgs>>("onsl-hover"), action);
    }
    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// event detail: { phase: 'start' | 'move' | 'end', value: number }
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRatingHoverArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRatingHoverArgs>>("onsl-hover"), b.MakeAction(action));
    }
}

/// <summary>
/// Ratings give users a way to quickly view and provide feedback.
/// </summary>
public partial class SlRating : HtmlTag
{
    public SlRating()
    {
        this.Tag = "sl-rating";
    }

    public static SlRating New()
    {
        return new SlRating();
    }
}

public static partial class SlRatingControl
{
    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static SlRating SetLabel(this SlRating tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The current rating.
    /// </summary>
    public static SlRating SetValue(this SlRating tag, int value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static SlRating SetMax(this SlRating tag, int value)
    {
        return tag.SetAttribute("max", value.ToString());
    }
    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public static SlRating SetPrecision(this SlRating tag, int value)
    {
        return tag.SetAttribute("precision", value.ToString());
    }
    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static SlRating SetReadonly(this SlRating tag)
    {
        return tag.SetAttribute("readonly", "true");
    }
    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static SlRating SetDisabled(this SlRating tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
}

