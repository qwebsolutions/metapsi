using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlTag
{
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
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-remove"), eventAction);
    }
    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-remove"), eventAction);
    }

}

