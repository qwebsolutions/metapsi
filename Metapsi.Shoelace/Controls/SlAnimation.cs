using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlAnimation
{
    public static class Method
    {
        /// <summary> 
        /// Clears all keyframe effects caused by this animation and aborts its playback.
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary> 
        /// Sets the playback time to the end of the animation corresponding to the current playback direction.
        /// </summary>
        public const string Finish = "finish";
    }
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
    public static void SetDirection(this PropsBuilder<SlAnimation> b, Var<PlaybackDirection> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<PlaybackDirection>("direction"), value);
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirection(this PropsBuilder<SlAnimation> b, PlaybackDirection value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<PlaybackDirection>("direction"), b.Const(value));
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
    public static void SetFill(this PropsBuilder<SlAnimation> b, Var<FillMode> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<FillMode>("fill"), value);
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFill(this PropsBuilder<SlAnimation> b, FillMode value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<FillMode>("fill"), b.Const(value));
    }

    /// <summary>
    /// The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops.
    /// </summary>
    public static void SetIterations(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterations"), value);
    }
    /// <summary>
    /// The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops.
    /// </summary>
    public static void SetIterations(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterations"), b.Const(value));
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
    public static void SetCurrentTime(this PropsBuilder<SlAnimation> b, Var<CSSNumberish> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<CSSNumberish>("currentTime"), value);
    }
    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static void SetCurrentTime(this PropsBuilder<SlAnimation> b, CSSNumberish value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<CSSNumberish>("currentTime"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-cancel"), eventAction);
    }
    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-cancel"), eventAction);
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-finish"), eventAction);
    }
    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-finish"), eventAction);
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-start"), eventAction);
    }
    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-start"), eventAction);
    }

}

