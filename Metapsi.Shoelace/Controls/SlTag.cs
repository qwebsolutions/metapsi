using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTag : SlComponent
{
    public SlTag() : base("sl-tag") { }
    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public string variant
    {
        get
        {
            return this.GetTag().GetAttribute<string>("variant");
        }
        set
        {
            this.GetTag().SetAttribute("variant", value.ToString());
        }
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public string size
    {
        get
        {
            return this.GetTag().GetAttribute<string>("size");
        }
        set
        {
            this.GetTag().SetAttribute("size", value.ToString());
        }
    }

    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public bool pill
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("pill");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("pill", value.ToString());
        }
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public bool removable
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("removable");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("removable", value.ToString());
        }
    }

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
        b.SetDynamic(b.Props, DynamicProperty.String("pill"), b.Const(string.Empty));
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable(this PropsBuilder<SlTag> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("removable"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-remove", action);
    }
    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-remove", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-remove", action);
    }
    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<TModel>(this PropsBuilder<SlTag> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-remove", b.MakeAction(action));
    }

}

