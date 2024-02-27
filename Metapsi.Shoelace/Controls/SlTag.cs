using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTag
{
}
public partial class SlTagRemoveArgs
{
    public IClientSideSlTag target { get; set; }
}
public static partial class SlTagControl
{
    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Var<IVNode> SlTag(this LayoutBuilder b, Action<PropsBuilder<SlTag>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tag", buildProps, children);
    }
    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Var<IVNode> SlTag(this LayoutBuilder b, Action<PropsBuilder<SlTag>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tag", buildProps, children);
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("primary"));
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("success"));
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("neutral"));
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantWarning(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("warning"));
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantDanger(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("danger"));
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantText(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("text"));
    }
    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pill"), b.Const(true));
    }
    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("removable"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, Var<HyperType.Action<TModel, SlTagRemoveArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTagRemoveArgs>>("onsl-remove"), action);
    }
    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTagRemoveArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTagRemoveArgs>>("onsl-remove"), b.MakeAction(action));
    }
}

/// <summary>
/// Tags are used as labels to organize things or to indicate a selection.
/// </summary>
public partial class SlTag : HtmlTag
{
    public SlTag()
    {
        this.Tag = "sl-tag";
    }

    public static SlTag New()
    {
        return new SlTag();
    }
}

public static partial class SlTagControl
{
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static SlTag SetVariantPrimary(this SlTag tag)
    {
        return tag.SetAttribute("variant", "primary");
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static SlTag SetVariantSuccess(this SlTag tag)
    {
        return tag.SetAttribute("variant", "success");
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static SlTag SetVariantNeutral(this SlTag tag)
    {
        return tag.SetAttribute("variant", "neutral");
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static SlTag SetVariantWarning(this SlTag tag)
    {
        return tag.SetAttribute("variant", "warning");
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static SlTag SetVariantDanger(this SlTag tag)
    {
        return tag.SetAttribute("variant", "danger");
    }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static SlTag SetVariantText(this SlTag tag)
    {
        return tag.SetAttribute("variant", "text");
    }
    /// <summary>
    /// The tag's size.
    /// </summary>
    public static SlTag SetSizeSmall(this SlTag tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The tag's size.
    /// </summary>
    public static SlTag SetSizeMedium(this SlTag tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The tag's size.
    /// </summary>
    public static SlTag SetSizeLarge(this SlTag tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static SlTag SetPill(this SlTag tag)
    {
        return tag.SetAttribute("pill", "true");
    }
    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static SlTag SetRemovable(this SlTag tag)
    {
        return tag.SetAttribute("removable", "true");
    }
}

