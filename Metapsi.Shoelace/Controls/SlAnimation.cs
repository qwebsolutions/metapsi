using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlAnimation
{
}
public partial class SlAnimationCancelArgs
{
    public IClientSideSlAnimation target { get; set; }
}
public partial class SlAnimationFinishArgs
{
    public IClientSideSlAnimation target { get; set; }
}
public partial class SlAnimationStartArgs
{
    public IClientSideSlAnimation target { get; set; }
}
public static partial class SlAnimationControl
{
    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Var<IVNode> SlAnimation(this LayoutBuilder b, Action<PropsBuilder<SlAnimation>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-animation", buildProps, children);
    }
    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Var<IVNode> SlAnimation(this LayoutBuilder b, Action<PropsBuilder<SlAnimation>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-animation", buildProps, children);
    }
    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public static void SetName(this PropsBuilder<SlAnimation> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public static void SetName(this PropsBuilder<SlAnimation> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }
    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static void SetPlay(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("play"), b.Const(true));
    }
    /// <summary>
    /// The number of milliseconds to delay the start of the animation.
    /// </summary>
    public static void SetDelay(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("delay"), value);
    }
    /// <summary>
    /// The number of milliseconds to delay the start of the animation.
    /// </summary>
    public static void SetDelay(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("delay"), b.Const(value));
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionNormal(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("direction"), b.Const("normal"));
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionReverse(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("direction"), b.Const("reverse"));
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionAlternate(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("direction"), b.Const("alternate"));
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionAlternateReverse(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("direction"), b.Const("alternate-reverse"));
    }
    /// <summary>
    /// The number of milliseconds each iteration of the animation takes to complete.
    /// </summary>
    public static void SetDuration(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// The number of milliseconds each iteration of the animation takes to complete.
    /// </summary>
    public static void SetDuration(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }
    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public static void SetEasing(this PropsBuilder<SlAnimation> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("easing"), value);
    }
    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public static void SetEasing(this PropsBuilder<SlAnimation> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("easing"), b.Const(value));
    }
    /// <summary>
    /// The number of milliseconds to delay after the active period of an animation sequence.
    /// </summary>
    public static void SetEndDelay(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("endDelay"), value);
    }
    /// <summary>
    /// The number of milliseconds to delay after the active period of an animation sequence.
    /// </summary>
    public static void SetEndDelay(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("endDelay"), b.Const(value));
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillNone(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("none"));
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillForwards(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("forwards"));
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillBackwards(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("backwards"));
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillBoth(this PropsBuilder<SlAnimation> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("both"));
    }
    /// <summary>
    /// The offset at which to start the animation, usually between 0 (start) and 1 (end).
    /// </summary>
    public static void SetIterationStart(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterationStart"), value);
    }
    /// <summary>
    /// The offset at which to start the animation, usually between 0 (start) and 1 (end).
    /// </summary>
    public static void SetIterationStart(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterationStart"), b.Const(value));
    }
    /// <summary>
    /// The keyframes to use for the animation. If this is set, `name` will be ignored.
    /// </summary>
    public static void SetKeyframes(this PropsBuilder<SlAnimation> b, Var<List<Keyframe>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<Keyframe>>("keyframes"), value);
    }
    /// <summary>
    /// The keyframes to use for the animation. If this is set, `name` will be ignored.
    /// </summary>
    public static void SetKeyframes(this PropsBuilder<SlAnimation> b, List<Keyframe> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<Keyframe>>("keyframes"), b.Const(value));
    }
    /// <summary>
    /// Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart.
    /// </summary>
    public static void SetPlaybackRate(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("playbackRate"), value);
    }
    /// <summary>
    /// Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart.
    /// </summary>
    public static void SetPlaybackRate(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("playbackRate"), b.Const(value));
    }
    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static void SetCurrentTime(this PropsBuilder<SlAnimation> b, Var<decimal> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<decimal>("currentTime"), value);
    }
    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static void SetCurrentTime(this PropsBuilder<SlAnimation> b, decimal value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<decimal>("currentTime"), b.Const(value));
    }
    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, SlAnimationCancelArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimationCancelArgs>>("onsl-cancel"), action);
    }
    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAnimationCancelArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimationCancelArgs>>("onsl-cancel"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, SlAnimationFinishArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimationFinishArgs>>("onsl-finish"), action);
    }
    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAnimationFinishArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimationFinishArgs>>("onsl-finish"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, SlAnimationStartArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimationStartArgs>>("onsl-start"), action);
    }
    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAnimationStartArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimationStartArgs>>("onsl-start"), b.MakeAction(action));
    }
}

/// <summary>
/// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
/// </summary>
public partial class SlAnimation : HtmlTag
{
    public SlAnimation()
    {
        this.Tag = "sl-animation";
    }

    public static SlAnimation New()
    {
        return new SlAnimation();
    }
}

public static partial class SlAnimationControl
{
    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public static SlAnimation SetName(this SlAnimation tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static SlAnimation SetPlay(this SlAnimation tag)
    {
        return tag.SetAttribute("play", "true");
    }
    /// <summary>
    /// The number of milliseconds to delay the start of the animation.
    /// </summary>
    public static SlAnimation SetDelay(this SlAnimation tag, int value)
    {
        return tag.SetAttribute("delay", value.ToString());
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static SlAnimation SetDirectionNormal(this SlAnimation tag)
    {
        return tag.SetAttribute("direction", "normal");
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static SlAnimation SetDirectionReverse(this SlAnimation tag)
    {
        return tag.SetAttribute("direction", "reverse");
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static SlAnimation SetDirectionAlternate(this SlAnimation tag)
    {
        return tag.SetAttribute("direction", "alternate");
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static SlAnimation SetDirectionAlternateReverse(this SlAnimation tag)
    {
        return tag.SetAttribute("direction", "alternate-reverse");
    }
    /// <summary>
    /// The number of milliseconds each iteration of the animation takes to complete.
    /// </summary>
    public static SlAnimation SetDuration(this SlAnimation tag, int value)
    {
        return tag.SetAttribute("duration", value.ToString());
    }
    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public static SlAnimation SetEasing(this SlAnimation tag, string value)
    {
        return tag.SetAttribute("easing", value.ToString());
    }
    /// <summary>
    /// The number of milliseconds to delay after the active period of an animation sequence.
    /// </summary>
    public static SlAnimation SetEndDelay(this SlAnimation tag, int value)
    {
        return tag.SetAttribute("endDelay", value.ToString());
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static SlAnimation SetFillNone(this SlAnimation tag)
    {
        return tag.SetAttribute("fill", "none");
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static SlAnimation SetFillForwards(this SlAnimation tag)
    {
        return tag.SetAttribute("fill", "forwards");
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static SlAnimation SetFillBackwards(this SlAnimation tag)
    {
        return tag.SetAttribute("fill", "backwards");
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static SlAnimation SetFillBoth(this SlAnimation tag)
    {
        return tag.SetAttribute("fill", "both");
    }
    /// <summary>
    /// The offset at which to start the animation, usually between 0 (start) and 1 (end).
    /// </summary>
    public static SlAnimation SetIterationStart(this SlAnimation tag, int value)
    {
        return tag.SetAttribute("iterationStart", value.ToString());
    }
    /// <summary>
    /// The keyframes to use for the animation. If this is set, `name` will be ignored.
    /// </summary>
    public static SlAnimation SetKeyframes(this SlAnimation tag, List<Keyframe> value)
    {
        return tag.SetAttribute("keyframes", value.ToString());
    }
    /// <summary>
    /// Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart.
    /// </summary>
    public static SlAnimation SetPlaybackRate(this SlAnimation tag, int value)
    {
        return tag.SetAttribute("playbackRate", value.ToString());
    }
    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static SlAnimation SetCurrentTime(this SlAnimation tag, decimal value)
    {
        return tag.SetAttribute("currentTime", value.ToString());
    }
}

