using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
/// </summary>
public partial class SlAnimation
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlAnimation
/// </summary>
public static partial class SlAnimationControl
{
    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimation(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAnimation>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-animation", buildAttributes, children);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimation(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-animation", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimation(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAnimation>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-animation", buildAttributes, children);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimation(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-animation", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlAnimation> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static void SetPlay(this Metapsi.Html.AttributesBuilder<SlAnimation> b, bool play) 
    {
        if (play) b.SetAttribute("play", "");
    }

    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static void SetPlay(this Metapsi.Html.AttributesBuilder<SlAnimation> b) 
    {
        b.SetAttribute("play", "");
    }

    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public static void SetEasing(this Metapsi.Html.AttributesBuilder<SlAnimation> b, string easing) 
    {
        b.SetAttribute("easing", easing);
    }

    /// <summary>
    /// The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops.
    /// </summary>
    public static void SetIterations(this Metapsi.Html.AttributesBuilder<SlAnimation> b, string iterations) 
    {
        b.SetAttribute("iterations", iterations);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimation(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAnimation>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-animation", buildProps, children);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimation(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-animation", children);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimation(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAnimation>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-animation", buildProps, children);
    }

    /// <summary>
    /// Animate elements declaratively with nearly 100 baked-in presets, or roll your own with custom keyframes. Powered by the [Web Animations API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Animations_API).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimation(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-animation", children);
    }

    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the built-in animation to use. For custom animations, use the `keyframes` prop.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlAnimation
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static void SetPlay<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetPlay(b.Const(true));
    }

    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static void SetPlay<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> play) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("play"), play);
    }

    /// <summary>
    /// Plays the animation. When omitted, the animation will be paused. This attribute will be automatically removed when the animation finishes or gets canceled.
    /// </summary>
    public static void SetPlay<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool play) where T: SlAnimation
    {
        b.SetPlay(b.Const(play));
    }

    /// <summary>
    /// The number of milliseconds to delay the start of the animation.
    /// </summary>
    public static void SetDelay<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> delay) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("delay"), delay);
    }

    /// <summary>
    /// The number of milliseconds to delay the start of the animation.
    /// </summary>
    public static void SetDelay<T>(this Metapsi.Syntax.PropsBuilder<T> b, int delay) where T: SlAnimation
    {
        b.SetDelay(b.Const(delay));
    }

    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionAlternate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("direction"), b.Const("alternate"));
    }

    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionAlternateReverse<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("direction"), b.Const("alternate-reverse"));
    }

    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionNormal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("direction"), b.Const("normal"));
    }

    /// <summary>
    /// Determines the direction of playback as well as the behavior when reaching the end of an iteration. [Learn more](https://developer.mozilla.org/en-US/docs/Web/CSS/animation-direction)
    /// </summary>
    public static void SetDirectionReverse<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("direction"), b.Const("reverse"));
    }

    /// <summary>
    /// The number of milliseconds each iteration of the animation takes to complete.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> duration) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("duration"), duration);
    }

    /// <summary>
    /// The number of milliseconds each iteration of the animation takes to complete.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, int duration) where T: SlAnimation
    {
        b.SetDuration(b.Const(duration));
    }

    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public static void SetEasing<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> easing) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("easing"), easing);
    }

    /// <summary>
    /// The easing function to use for the animation. This can be a Shoelace easing function or a custom easing function such as `cubic-bezier(0, 1, .76, 1.14)`.
    /// </summary>
    public static void SetEasing<T>(this Metapsi.Syntax.PropsBuilder<T> b, string easing) where T: SlAnimation
    {
        b.SetEasing(b.Const(easing));
    }

    /// <summary>
    /// The number of milliseconds to delay after the active period of an animation sequence.
    /// </summary>
    public static void SetEndDelay<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> endDelay) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("endDelay"), endDelay);
    }

    /// <summary>
    /// The number of milliseconds to delay after the active period of an animation sequence.
    /// </summary>
    public static void SetEndDelay<T>(this Metapsi.Syntax.PropsBuilder<T> b, int endDelay) where T: SlAnimation
    {
        b.SetEndDelay(b.Const(endDelay));
    }

    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("auto"));
    }

    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillBackwards<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("backwards"));
    }

    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillBoth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("both"));
    }

    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillForwards<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("forwards"));
    }

    /// <summary>
    /// Sets how the animation applies styles to its target before and after its execution.
    /// </summary>
    public static void SetFillNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("none"));
    }

    /// <summary>
    /// The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops.
    /// </summary>
    public static void SetIterations<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> iterations) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("iterations"), iterations);
    }

    /// <summary>
    /// The number of iterations to run before the animation completes. Defaults to `Infinity`, which loops.
    /// </summary>
    public static void SetIterations<T>(this Metapsi.Syntax.PropsBuilder<T> b, string iterations) where T: SlAnimation
    {
        b.SetIterations(b.Const(iterations));
    }

    /// <summary>
    /// The offset at which to start the animation, usually between 0 (start) and 1 (end).
    /// </summary>
    public static void SetIterationStart<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> iterationStart) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("iterationStart"), iterationStart);
    }

    /// <summary>
    /// The offset at which to start the animation, usually between 0 (start) and 1 (end).
    /// </summary>
    public static void SetIterationStart<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal iterationStart) where T: SlAnimation
    {
        b.SetIterationStart(b.Const(iterationStart));
    }

    /// <summary>
    /// The keyframes to use for the animation. If this is set, `name` will be ignored.
    /// </summary>
    public static void SetKeyframes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Html.Keyframe>>> keyframes) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("keyframes"), keyframes);
    }

    /// <summary>
    /// Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart.
    /// </summary>
    public static void SetPlaybackRate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> playbackRate) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("playbackRate"), playbackRate);
    }

    /// <summary>
    /// Sets the animation's playback rate. The default is `1`, which plays the animation at a normal speed. Setting this to `2`, for example, will double the animation's speed. A negative value can be used to reverse the animation. This value can be changed without causing the animation to restart.
    /// </summary>
    public static void SetPlaybackRate<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal playbackRate) where T: SlAnimation
    {
        b.SetPlaybackRate(b.Const(playbackRate));
    }

    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static void SetCurrentTime<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> currentTime) where T: SlAnimation
    {
        b.SetProperty(b.Props, b.Const("currentTime"), currentTime);
    }

    /// <summary>
    /// Gets and sets the current animation time.
    /// </summary>
    public static void SetCurrentTime<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal currentTime) where T: SlAnimation
    {
        b.SetCurrentTime(b.Const(currentTime));
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAnimation
    {
        b.OnSlEvent("onsl-cancel", action);
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimation
    {
        b.OnSlCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAnimation
    {
        b.OnSlEvent("onsl-cancel", action);
    }

    /// <summary>
    /// Emitted when the animation is canceled.
    /// </summary>
    public static void OnSlCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimation
    {
        b.OnSlCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAnimation
    {
        b.OnSlEvent("onsl-finish", action);
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimation
    {
        b.OnSlFinish(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAnimation
    {
        b.OnSlEvent("onsl-finish", action);
    }

    /// <summary>
    /// Emitted when the animation finishes.
    /// </summary>
    public static void OnSlFinish<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimation
    {
        b.OnSlFinish(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAnimation
    {
        b.OnSlEvent("onsl-start", action);
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimation
    {
        b.OnSlStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAnimation
    {
        b.OnSlEvent("onsl-start", action);
    }

    /// <summary>
    /// Emitted when the animation starts or restarts.
    /// </summary>
    public static void OnSlStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimation
    {
        b.OnSlStart(b.MakeAction(action));
    }

}