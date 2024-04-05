using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlAnimatedImage : SlComponent
{
    public SlAnimatedImage() : base("sl-animated-image") { }
    /// <summary>
    /// The path to the image to load.
    /// </summary>
    public string src
    {
        get
        {
            return this.GetTag().GetAttribute<string>("src");
        }
        set
        {
            this.GetTag().SetAttribute("src", value.ToString());
        }
    }

    /// <summary>
    /// A description of the image used by assistive devices.
    /// </summary>
    public string alt
    {
        get
        {
            return this.GetTag().GetAttribute<string>("alt");
        }
        set
        {
            this.GetTag().SetAttribute("alt", value.ToString());
        }
    }

    /// <summary>
    /// Plays the animation. When this attribute is remove, the animation will pause.
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
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

}

