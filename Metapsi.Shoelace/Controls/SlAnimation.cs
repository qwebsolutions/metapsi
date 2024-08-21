using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlAnimation
{
    public static class Method
    {
        /// <summary>
        /// <para> Clears all keyframe effects caused by this animation and aborts its playback. </para>
        /// </summary>
        public const string Cancel = "cancel";
        /// <summary>
        /// <para> Sets the playback time to the end of the animation corresponding to the current playback direction. </para>
        /// </summary>
        public const string Finish = "finish";
    }
}

public static partial class SlAnimationControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimation(this HtmlBuilder b, Action<AttributesBuilder<SlAnimation>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-animation", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimation(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-animation", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimation(this HtmlBuilder b, Action<AttributesBuilder<SlAnimation>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-animation", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimation(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-animation", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the built-in animation to use. For custom animations, use the `keyframes` prop. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlAnimation> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled. </para>
    /// </summary>
    public static void SetPlay(this AttributesBuilder<SlAnimation> b)
    {
        b.SetAttribute("play", "");
    }

    /// <summary>
    /// <para> Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled. </para>
    /// </summary>
    public static void SetPlay(this AttributesBuilder<SlAnimation> b, bool play)
    {
        if (play) b.SetAttribute("play", "");
    }

    /// <summary>
    /// <para> The number of milliseconds to delay the start of the animation. </para>
    /// </summary>
    public static void SetDelay(this AttributesBuilder<SlAnimation> b, string delay)
    {
        b.SetAttribute("delay", delay);
    }

    /// <summary>
    /// <para> Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction) </para>
    /// </summary>
    public static void SetDirection(this AttributesBuilder<SlAnimation> b, string direction)
    {
        b.SetAttribute("direction", direction);
    }

    /// <summary>
    /// <para> The number of milliseconds each iteration of the animation takes to complete. </para>
    /// </summary>
    public static void SetDuration(this AttributesBuilder<SlAnimation> b, string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// <para> The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`. </para>
    /// </summary>
    public static void SetEasing(this AttributesBuilder<SlAnimation> b, string easing)
    {
        b.SetAttribute("easing", easing);
    }

    /// <summary>
    /// <para> The number of milliseconds to delay after the active period of an animation sequence. </para>
    /// </summary>
    public static void SetEndDelay(this AttributesBuilder<SlAnimation> b, string endDelay)
    {
        b.SetAttribute("end-delay", endDelay);
    }

    /// <summary>
    /// <para> Sets how the animation applies styles to its target before and after its execution. </para>
    /// </summary>
    public static void SetFill(this AttributesBuilder<SlAnimation> b, string fill)
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// <para> The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops. </para>
    /// </summary>
    public static void SetIterations(this AttributesBuilder<SlAnimation> b, string iterations)
    {
        b.SetAttribute("iterations", iterations);
    }

    /// <summary>
    /// <para> The offset at which to start the animation, usually between 0 (start) and 1 (end). </para>
    /// </summary>
    public static void SetIterationStart(this AttributesBuilder<SlAnimation> b, string iterationStart)
    {
        b.SetAttribute("iteration-start", iterationStart);
    }

    /// <summary>
    /// <para> Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart. </para>
    /// </summary>
    public static void SetPlaybackRate(this AttributesBuilder<SlAnimation> b, string playbackRate)
    {
        b.SetAttribute("playback-rate", playbackRate);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimation(this LayoutBuilder b, Action<PropsBuilder<SlAnimation>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-animation", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimation(this LayoutBuilder b, Action<PropsBuilder<SlAnimation>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-animation", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimation(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-animation", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimation(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-animation", children);
    }
    /// <summary>
    /// <para> The name of the built-in animation to use. For custom animations, use the `keyframes` prop. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the built-in animation to use. For custom animations, use the `keyframes` prop. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled. </para>
    /// </summary>
    public static void SetPlay<T>(this PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("play"), b.Const(true));
    }


    /// <summary>
    /// <para> Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled. </para>
    /// </summary>
    public static void SetPlay<T>(this PropsBuilder<T> b, Var<bool> play) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("play"), play);
    }

    /// <summary>
    /// <para> Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled. </para>
    /// </summary>
    public static void SetPlay<T>(this PropsBuilder<T> b, bool play) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("play"), b.Const(play));
    }


    /// <summary>
    /// <para> The number of milliseconds to delay the start of the animation. </para>
    /// </summary>
    public static void SetDelay<T>(this PropsBuilder<T> b, Var<int> delay) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("delay"), delay);
    }

    /// <summary>
    /// <para> The number of milliseconds to delay the start of the animation. </para>
    /// </summary>
    public static void SetDelay<T>(this PropsBuilder<T> b, int delay) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("delay"), b.Const(delay));
    }


    /// <summary>
    /// <para> Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction) </para>
    /// </summary>
    public static void SetDirection<T>(this PropsBuilder<T> b, Var<string> direction) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("direction"), direction);
    }

    /// <summary>
    /// <para> Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction) </para>
    /// </summary>
    public static void SetDirection<T>(this PropsBuilder<T> b, string direction) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("direction"), b.Const(direction));
    }


    /// <summary>
    /// <para> The number of milliseconds each iteration of the animation takes to complete. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> duration) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), duration);
    }

    /// <summary>
    /// <para> The number of milliseconds each iteration of the animation takes to complete. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int duration) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(duration));
    }


    /// <summary>
    /// <para> The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`. </para>
    /// </summary>
    public static void SetEasing<T>(this PropsBuilder<T> b, Var<string> easing) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("easing"), easing);
    }

    /// <summary>
    /// <para> The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`. </para>
    /// </summary>
    public static void SetEasing<T>(this PropsBuilder<T> b, string easing) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("easing"), b.Const(easing));
    }


    /// <summary>
    /// <para> The number of milliseconds to delay after the active period of an animation sequence. </para>
    /// </summary>
    public static void SetEndDelay<T>(this PropsBuilder<T> b, Var<int> endDelay) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("endDelay"), endDelay);
    }

    /// <summary>
    /// <para> The number of milliseconds to delay after the active period of an animation sequence. </para>
    /// </summary>
    public static void SetEndDelay<T>(this PropsBuilder<T> b, int endDelay) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("endDelay"), b.Const(endDelay));
    }


    /// <summary>
    /// <para> Sets how the animation applies styles to its target before and after its execution. </para>
    /// </summary>
    public static void SetFill<T>(this PropsBuilder<T> b, Var<string> fill) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), fill);
    }

    /// <summary>
    /// <para> Sets how the animation applies styles to its target before and after its execution. </para>
    /// </summary>
    public static void SetFill<T>(this PropsBuilder<T> b, string fill) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const(fill));
    }


    /// <summary>
    /// <para> The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops. </para>
    /// </summary>
    public static void SetIterations<T>(this PropsBuilder<T> b, Var<int> iterations) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterations"), iterations);
    }

    /// <summary>
    /// <para> The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops. </para>
    /// </summary>
    public static void SetIterations<T>(this PropsBuilder<T> b, int iterations) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterations"), b.Const(iterations));
    }


    /// <summary>
    /// <para> The offset at which to start the animation, usually between 0 (start) and 1 (end). </para>
    /// </summary>
    public static void SetIterationStart<T>(this PropsBuilder<T> b, Var<int> iterationStart) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterationStart"), iterationStart);
    }

    /// <summary>
    /// <para> The offset at which to start the animation, usually between 0 (start) and 1 (end). </para>
    /// </summary>
    public static void SetIterationStart<T>(this PropsBuilder<T> b, int iterationStart) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("iterationStart"), b.Const(iterationStart));
    }


    /// <summary>
    /// <para> The keyframes to use for the animation. If this is set, `name` will be ignored. </para>
    /// </summary>
    public static void SetKeyframes<T>(this PropsBuilder<T> b, Var<List<Keyframe>> keyframes) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<Keyframe>>("keyframes"), keyframes);
    }

    /// <summary>
    /// <para> The keyframes to use for the animation. If this is set, `name` will be ignored. </para>
    /// </summary>
    public static void SetKeyframes<T>(this PropsBuilder<T> b, List<Keyframe> keyframes) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<Keyframe>>("keyframes"), b.Const(keyframes));
    }


    /// <summary>
    /// <para> Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart. </para>
    /// </summary>
    public static void SetPlaybackRate<T>(this PropsBuilder<T> b, Var<int> playbackRate) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("playbackRate"), playbackRate);
    }

    /// <summary>
    /// <para> Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart. </para>
    /// </summary>
    public static void SetPlaybackRate<T>(this PropsBuilder<T> b, int playbackRate) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("playbackRate"), b.Const(playbackRate));
    }


    /// <summary>
    /// <para> Gets and sets the current animation time. </para>
    /// </summary>
    public static void SetCurrentTime<T>(this PropsBuilder<T> b, Var<int> currentTime) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("currentTime"), currentTime);
    }

    /// <summary>
    /// <para> Gets and sets the current animation time. </para>
    /// </summary>
    public static void SetCurrentTime<T>(this PropsBuilder<T> b, int currentTime) where T: SlAnimation
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("currentTime"), b.Const(currentTime));
    }


    /// <summary>
    /// <para> Emitted when the animation is canceled. </para>
    /// </summary>
    public static void OnSlCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-cancel", action);
    }
    /// <summary>
    /// <para> Emitted when the animation is canceled. </para>
    /// </summary>
    public static void OnSlCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-cancel", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the animation is canceled. </para>
    /// </summary>
    public static void OnSlCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-cancel", action);
    }
    /// <summary>
    /// <para> Emitted when the animation is canceled. </para>
    /// </summary>
    public static void OnSlCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-cancel", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the animation finishes. </para>
    /// </summary>
    public static void OnSlFinish<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-finish", action);
    }
    /// <summary>
    /// <para> Emitted when the animation finishes. </para>
    /// </summary>
    public static void OnSlFinish<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-finish", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the animation finishes. </para>
    /// </summary>
    public static void OnSlFinish<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-finish", action);
    }
    /// <summary>
    /// <para> Emitted when the animation finishes. </para>
    /// </summary>
    public static void OnSlFinish<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-finish", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the animation starts or restarts. </para>
    /// </summary>
    public static void OnSlStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-start", action);
    }
    /// <summary>
    /// <para> Emitted when the animation starts or restarts. </para>
    /// </summary>
    public static void OnSlStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-start", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the animation starts or restarts. </para>
    /// </summary>
    public static void OnSlStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-start", action);
    }
    /// <summary>
    /// <para> Emitted when the animation starts or restarts. </para>
    /// </summary>
    public static void OnSlStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAnimation
    {
        b.OnEventAction("onsl-start", b.MakeAction(action));
    }

}

