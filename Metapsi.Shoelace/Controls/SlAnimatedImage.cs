using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlAnimatedImage
{
}
public partial class SlAnimatedImageLoadArgs
{
    public IClientSideSlAnimatedImage target { get; set; }
}
public partial class SlAnimatedImageErrorArgs
{
    public IClientSideSlAnimatedImage target { get; set; }
}
public static partial class SlAnimatedImageControl
{
    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Var<IVNode> SlAnimatedImage(this LayoutBuilder b, Action<PropsBuilder<SlAnimatedImage>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-animated-image", buildProps, children);
    }
    /// <summary>
    /// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
    /// </summary>
    public static Var<IVNode> SlAnimatedImage(this LayoutBuilder b, Action<PropsBuilder<SlAnimatedImage>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-animated-image", buildProps, children);
    }
    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlAnimatedImage> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), value);
    }
    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlAnimatedImage> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(value));
    }
    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public static void SetAlt(this PropsBuilder<SlAnimatedImage> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), value);
    }
    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public static void SetAlt(this PropsBuilder<SlAnimatedImage> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), b.Const(value));
    }
    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static void SetPlay(this PropsBuilder<SlAnimatedImage> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("play"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel, SlAnimatedImageLoadArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimatedImageLoadArgs>>("onsl-load"), action);
    }
    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAnimatedImageLoadArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimatedImageLoadArgs>>("onsl-load"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel, SlAnimatedImageErrorArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimatedImageErrorArgs>>("onsl-error"), action);
    }
    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAnimatedImageErrorArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAnimatedImageErrorArgs>>("onsl-error"), b.MakeAction(action));
    }
}

/// <summary>
/// A component for displaying animated GIFs and WEBPs that play and pause on interaction.
/// </summary>
public partial class SlAnimatedImage : HtmlTag
{
    public SlAnimatedImage()
    {
        this.Tag = "sl-animated-image";
    }

    public static SlAnimatedImage New()
    {
        return new SlAnimatedImage();
    }
    public static class Slot
    {
        /// <summary> 
        /// Optional play icon to use instead of the default. Works best with `<sl-icon>`.
        /// </summary>
        public const string PlayIcon = "play-icon";
        /// <summary> 
        /// Optional pause icon to use instead of the default. Works best with `<sl-icon>`.
        /// </summary>
        public const string PauseIcon = "pause-icon";
    }
}

public static partial class SlAnimatedImageControl
{
    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public static SlAnimatedImage SetSrc(this SlAnimatedImage tag, string value)
    {
        return tag.SetAttribute("src", value.ToString());
    }
    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public static SlAnimatedImage SetAlt(this SlAnimatedImage tag, string value)
    {
        return tag.SetAttribute("alt", value.ToString());
    }
    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
    /// </summary>
    public static SlAnimatedImage SetPlay(this SlAnimatedImage tag)
    {
        return tag.SetAttribute("play", "true");
    }
}

