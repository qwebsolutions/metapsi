using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlAnimatedImage
{
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
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-load"), eventAction);
    }
    /// <summary>
    /// Emitted when the image loads successfully.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-load"), eventAction);
    }

    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-error"), eventAction);
    }
    /// <summary>
    /// Emitted when the image fails to load.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlAnimatedImage> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-error"), eventAction);
    }

}

