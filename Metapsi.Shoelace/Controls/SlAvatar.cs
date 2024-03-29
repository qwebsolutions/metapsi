using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlAvatar
{
    public static class Slot
    {
        /// <summary> 
        /// The default icon to use when no image or initials are present. Works best with `<sl-icon>`.
        /// </summary>
        public const string Icon = "icon";
    }
}

public static partial class SlAvatarControl
{
    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Var<IVNode> SlAvatar(this LayoutBuilder b, Action<PropsBuilder<SlAvatar>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-avatar", buildProps, children);
    }
    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Var<IVNode> SlAvatar(this LayoutBuilder b, Action<PropsBuilder<SlAvatar>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-avatar", buildProps, children);
    }
    /// <summary>
    /// The image source to use for the avatar.
    /// </summary>
    public static void SetImage(this PropsBuilder<SlAvatar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("image"), value);
    }
    /// <summary>
    /// The image source to use for the avatar.
    /// </summary>
    public static void SetImage(this PropsBuilder<SlAvatar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("image"), b.Const(value));
    }

    /// <summary>
    /// A label to use to describe the avatar to assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlAvatar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A label to use to describe the avatar to assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlAvatar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Initials to use as a fallback when no image is available (1-2 characters max recommended).
    /// </summary>
    public static void SetInitials(this PropsBuilder<SlAvatar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("initials"), value);
    }
    /// <summary>
    /// Initials to use as a fallback when no image is available (1-2 characters max recommended).
    /// </summary>
    public static void SetInitials(this PropsBuilder<SlAvatar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("initials"), b.Const(value));
    }

    /// <summary>
    /// Indicates how the browser should load the image.
    /// </summary>
    public static void SetLoadingEager(this PropsBuilder<SlAvatar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loading"), b.Const("eager"));
    }
    /// <summary>
    /// Indicates how the browser should load the image.
    /// </summary>
    public static void SetLoadingLazy(this PropsBuilder<SlAvatar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loading"), b.Const("lazy"));
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeCircle(this PropsBuilder<SlAvatar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("circle"));
    }
    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeSquare(this PropsBuilder<SlAvatar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("square"));
    }
    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeRounded(this PropsBuilder<SlAvatar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("rounded"));
    }

}

