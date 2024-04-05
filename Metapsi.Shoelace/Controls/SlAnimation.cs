using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlAnimation : SlComponent
{
    public SlAnimation() : base("sl-animation") { }
    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public string name
    {
        get
        {
            return this.GetTag().GetAttribute<string>("name");
        }
        set
        {
            this.GetTag().SetAttribute("name", value.ToString());
        }
    }

    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public bool play
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("play");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("play", value.ToString());
        }
    }

    /// <summary>
    /// The number of milliseconds to delay the start of the animation.
    /// </summary>
    public int delay
    {
        get
        {
            return this.GetTag().GetAttribute<int>("delay");
        }
        set
        {
            this.GetTag().SetAttribute("delay", value.ToString());
        }
    }

    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public string direction
    {
        get
        {
            return this.GetTag().GetAttribute<string>("direction");
        }
        set
        {
            this.GetTag().SetAttribute("direction", value.ToString());
        }
    }

    /// <summary>
    /// The number of milliseconds each iteration of the animation takes to complete.
    /// </summary>
    public int duration
    {
        get
        {
            return this.GetTag().GetAttribute<int>("duration");
        }
        set
        {
            this.GetTag().SetAttribute("duration", value.ToString());
        }
    }

    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public string easing
    {
        get
        {
            return this.GetTag().GetAttribute<string>("easing");
        }
        set
        {
            this.GetTag().SetAttribute("easing", value.ToString());
        }
    }

    /// <summary>
    /// The number of milliseconds to delay after the active period of an animation sequence.
    /// </summary>
    public int endDelay
    {
        get
        {
            return this.GetTag().GetAttribute<int>("endDelay");
        }
        set
        {
            this.GetTag().SetAttribute("endDelay", value.ToString());
        }
    }

    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public string fill
    {
        get
        {
            return this.GetTag().GetAttribute<string>("fill");
        }
        set
        {
            this.GetTag().SetAttribute("fill", value.ToString());
        }
    }

    /// <summary>
    /// The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops.
    /// </summary>
    public int iterations
    {
        get
        {
            return this.GetTag().GetAttribute<int>("iterations");
        }
        set
        {
            this.GetTag().SetAttribute("iterations", value.ToString());
        }
    }

    /// <summary>
    /// The offset at which to start the animation, usually between 0 (start) and 1 (end).
    /// </summary>
    public int iterationStart
    {
        get
        {
            return this.GetTag().GetAttribute<int>("iterationStart");
        }
        set
        {
            this.GetTag().SetAttribute("iterationStart", value.ToString());
        }
    }

    /// <summary>
    /// Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart.
    /// </summary>
    public int playbackRate
    {
        get
        {
            return this.GetTag().GetAttribute<int>("playbackRate");
        }
        set
        {
            this.GetTag().SetAttribute("playbackRate", value.ToString());
        }
    }

    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public int currentTime
    {
        get
        {
            return this.GetTag().GetAttribute<int>("currentTime");
        }
        set
        {
            this.GetTag().SetAttribute("currentTime", value.ToString());
        }
    }

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
    public static void SetDirection(this PropsBuilder<SlAnimation> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("direction"), value);
    }
    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirection(this PropsBuilder<SlAnimation> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("direction"), b.Const(value));
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
    public static void SetFill(this PropsBuilder<SlAnimation> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), value);
    }
    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFill(this PropsBuilder<SlAnimation> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const(value));
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
    public static void SetCurrentTime(this PropsBuilder<SlAnimation> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("currentTime"), value);
    }
    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static void SetCurrentTime(this PropsBuilder<SlAnimation> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("currentTime"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-cancel", action);
    }
    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-cancel", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-cancel", action);
    }
    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-cancel", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-finish", action);
    }
    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-finish", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-finish", action);
    }
    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-finish", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-start", action);
    }
    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-start", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-start", action);
    }
    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<TModel>(this PropsBuilder<SlAnimation> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-start", b.MakeAction(action));
    }

}

