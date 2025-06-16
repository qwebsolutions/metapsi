using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
/// </summary>
public partial class SlAnimatedImage
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Optional play icon to use instead of the default. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string PlayIcon = "play-icon";
        /// <summary>
        /// Optional pause icon to use instead of the default. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string PauseIcon = "pause-icon";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlAnimatedImage
/// </summary>
public static partial class SlAnimatedImageControl
{
    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimatedImage(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAnimatedImage>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-animated-image", buildAttributes, children);
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimatedImage(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-animated-image", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimatedImage(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAnimatedImage>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-animated-image", buildAttributes, children);
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAnimatedImage(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-animated-image", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public static void SetSrc(this Metapsi.Html.AttributesBuilder<SlAnimatedImage> b, string src) 
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public static void SetAlt(this Metapsi.Html.AttributesBuilder<SlAnimatedImage> b, string alt) 
    {
        b.SetAttribute("alt", alt);
    }

    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static void SetPlay(this Metapsi.Html.AttributesBuilder<SlAnimatedImage> b, bool play) 
    {
        if (play) b.SetAttribute("play", "");
    }

    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static void SetPlay(this Metapsi.Html.AttributesBuilder<SlAnimatedImage> b) 
    {
        b.SetAttribute("play", "");
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimatedImage(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAnimatedImage>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-animated-image", buildProps, children);
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimatedImage(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-animated-image", children);
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimatedImage(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAnimatedImage>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-animated-image", buildProps, children);
    }

    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAnimatedImage(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-animated-image", children);
    }

    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> src) where T: SlAnimatedImage
    {
        b.SetProperty(b.Props, b.Const("src"), src);
    }

    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, string src) where T: SlAnimatedImage
    {
        b.SetSrc(b.Const(src));
    }

    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public static void SetAlt<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> alt) where T: SlAnimatedImage
    {
        b.SetProperty(b.Props, b.Const("alt"), alt);
    }

    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public static void SetAlt<T>(this Metapsi.Syntax.PropsBuilder<T> b, string alt) where T: SlAnimatedImage
    {
        b.SetAlt(b.Const(alt));
    }

    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static void SetPlay<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAnimatedImage
    {
        b.SetPlay(b.Const(true));
    }

    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static void SetPlay<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> play) where T: SlAnimatedImage
    {
        b.SetProperty(b.Props, b.Const("play"), play);
    }

    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static void SetPlay<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool play) where T: SlAnimatedImage
    {
        b.SetPlay(b.Const(play));
    }

    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAnimatedImage
    {
        b.OnSlEvent("onsl-load", action);
    }

    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimatedImage
    {
        b.OnSlLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAnimatedImage
    {
        b.OnSlEvent("onsl-load", action);
    }

    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimatedImage
    {
        b.OnSlLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAnimatedImage
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimatedImage
    {
        b.OnSlError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAnimatedImage
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAnimatedImage
    {
        b.OnSlError(b.MakeAction(action));
    }

}