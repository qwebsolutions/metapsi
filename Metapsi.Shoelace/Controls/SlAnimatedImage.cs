using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlAnimatedImage
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Optional play icon to use instead of the default. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string PlayIcon = "play-icon";
        /// <summary>
        /// <para> Optional pause icon to use instead of the default. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string PauseIcon = "pause-icon";
    }
}

public static partial class SlAnimatedImageControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimatedImage(this HtmlBuilder b, Action<AttributesBuilder<SlAnimatedImage>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-animated-image", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimatedImage(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-animated-image", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimatedImage(this HtmlBuilder b, Action<AttributesBuilder<SlAnimatedImage>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-animated-image", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAnimatedImage(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-animated-image", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The path to the image to load. </para>
    /// </summary>
    public static void SetSrc(this AttributesBuilder<SlAnimatedImage> b, string src)
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// <para> A description of the image used by assistive devices. </para>
    /// </summary>
    public static void SetAlt(this AttributesBuilder<SlAnimatedImage> b, string alt)
    {
        b.SetAttribute("alt", alt);
    }

    /// <summary>
    /// <para> Plays the animation. When this attribute is remove, the animation will pause. </para>
    /// </summary>
    public static void SetPlay(this AttributesBuilder<SlAnimatedImage> b)
    {
        b.SetAttribute("play", "");
    }

    /// <summary>
    /// <para> Plays the animation. When this attribute is remove, the animation will pause. </para>
    /// </summary>
    public static void SetPlay(this AttributesBuilder<SlAnimatedImage> b, bool play)
    {
        if (play) b.SetAttribute("play", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimatedImage(this LayoutBuilder b, Action<PropsBuilder<SlAnimatedImage>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-animated-image", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimatedImage(this LayoutBuilder b, Action<PropsBuilder<SlAnimatedImage>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-animated-image", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimatedImage(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-animated-image", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAnimatedImage(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-animated-image", children);
    }
    /// <summary>
    /// <para> The path to the image to load. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, Var<string> src) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), src);
    }

    /// <summary>
    /// <para> The path to the image to load. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, string src) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(src));
    }


    /// <summary>
    /// <para> A description of the image used by assistive devices. </para>
    /// </summary>
    public static void SetAlt<T>(this PropsBuilder<T> b, Var<string> alt) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), alt);
    }

    /// <summary>
    /// <para> A description of the image used by assistive devices. </para>
    /// </summary>
    public static void SetAlt<T>(this PropsBuilder<T> b, string alt) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), b.Const(alt));
    }


    /// <summary>
    /// <para> Plays the animation. When this attribute is remove, the animation will pause. </para>
    /// </summary>
    public static void SetPlay<T>(this PropsBuilder<T> b) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("play"), b.Const(true));
    }


    /// <summary>
    /// <para> Plays the animation. When this attribute is remove, the animation will pause. </para>
    /// </summary>
    public static void SetPlay<T>(this PropsBuilder<T> b, Var<bool> play) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("play"), play);
    }

    /// <summary>
    /// <para> Plays the animation. When this attribute is remove, the animation will pause. </para>
    /// </summary>
    public static void SetPlay<T>(this PropsBuilder<T> b, bool play) where T: SlAnimatedImage
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("play"), b.Const(play));
    }


    /// <summary>
    /// <para> Emitted when the image loads successfully. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// <para> Emitted when the image loads successfully. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the image loads successfully. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// <para> Emitted when the image loads successfully. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the image fails to load. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the image fails to load. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the image fails to load. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the image fails to load. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAnimatedImage
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

}

