using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTag
{
}

public static partial class SlTagControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTag(this HtmlBuilder b, Action<AttributesBuilder<SlTag>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tag", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTag(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tag", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTag(this HtmlBuilder b, Action<AttributesBuilder<SlTag>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tag", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTag(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tag", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariant(this AttributesBuilder<SlTag> b, string variant)
    {
        b.SetAttribute("variant", variant);
    }

    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantText(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("variant", "text");
    }

    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlTag> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Draws a pill-style tag with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a pill-style tag with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlTag> b, bool pill)
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Makes the tag removable and shows a remove button. </para>
    /// </summary>
    public static void SetRemovable(this AttributesBuilder<SlTag> b)
    {
        b.SetAttribute("removable", "");
    }

    /// <summary>
    /// <para> Makes the tag removable and shows a remove button. </para>
    /// </summary>
    public static void SetRemovable(this AttributesBuilder<SlTag> b, bool removable)
    {
        if (removable) b.SetAttribute("removable", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTag(this LayoutBuilder b, Action<PropsBuilder<SlTag>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tag", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTag(this LayoutBuilder b, Action<PropsBuilder<SlTag>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tag", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTag(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tag", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTag(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tag", children);
    }
    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("success"));
    }


    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("neutral"));
    }


    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The tag's theme variant. </para>
    /// </summary>
    public static void SetVariantText<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("text"));
    }


    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The tag's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Draws a pill-style tag with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a pill-style tag with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, Var<bool> pill) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), pill);
    }

    /// <summary>
    /// <para> Draws a pill-style tag with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, bool pill) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), b.Const(pill));
    }


    /// <summary>
    /// <para> Makes the tag removable and shows a remove button. </para>
    /// </summary>
    public static void SetRemovable<T>(this PropsBuilder<T> b) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("removable"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the tag removable and shows a remove button. </para>
    /// </summary>
    public static void SetRemovable<T>(this PropsBuilder<T> b, Var<bool> removable) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("removable"), removable);
    }

    /// <summary>
    /// <para> Makes the tag removable and shows a remove button. </para>
    /// </summary>
    public static void SetRemovable<T>(this PropsBuilder<T> b, bool removable) where T: SlTag
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("removable"), b.Const(removable));
    }


    /// <summary>
    /// <para> Emitted when the remove button is activated. </para>
    /// </summary>
    public static void OnSlRemove<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTag
    {
        b.OnEventAction("onsl-remove", action);
    }
    /// <summary>
    /// <para> Emitted when the remove button is activated. </para>
    /// </summary>
    public static void OnSlRemove<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTag
    {
        b.OnEventAction("onsl-remove", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the remove button is activated. </para>
    /// </summary>
    public static void OnSlRemove<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTag
    {
        b.OnEventAction("onsl-remove", action);
    }
    /// <summary>
    /// <para> Emitted when the remove button is activated. </para>
    /// </summary>
    public static void OnSlRemove<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTag
    {
        b.OnEventAction("onsl-remove", b.MakeAction(action));
    }

}

