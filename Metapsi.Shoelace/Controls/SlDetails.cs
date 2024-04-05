using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlDetails : SlComponent
{
    public SlDetails() : base("sl-details") { }
    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public bool open
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("open");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("open", value.ToString());
        }
    }

    /// <summary>
    /// The summary to show in the header. If you need to display HTML, use the `summary` slot instead.
    /// </summary>
    public string summary
    {
        get
        {
            return this.GetTag().GetAttribute<string>("summary");
        }
        set
        {
            this.GetTag().SetAttribute("summary", value.ToString());
        }
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// The details' summary. Alternatively, you can use the `summary` attribute.
        /// </summary>
        public const string Summary = "summary";
        /// <summary> 
        /// Optional expand icon to use instead of the default. Works best with `<sl-icon>`.
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary> 
        /// Optional collapse icon to use instead of the default. Works best with `<sl-icon>`.
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
    public static class Method
    {
        /// <summary> 
        /// Shows the details.
        /// </summary>
        public const string Show = "show";
        /// <summary> 
        /// Hides the details
        /// </summary>
        public const string Hide = "hide";
    }
}

public static partial class SlDetailsControl
{
    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Var<IVNode> SlDetails(this LayoutBuilder b, Action<PropsBuilder<SlDetails>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-details", buildProps, children);
    }
    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Var<IVNode> SlDetails(this LayoutBuilder b, Action<PropsBuilder<SlDetails>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-details", buildProps, children);
    }
    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlDetails> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("open"), b.Const(string.Empty));
    }

    /// <summary>
    /// The summary to show in the header. If you need to display HTML, use the `summary` slot instead.
    /// </summary>
    public static void SetSummary(this PropsBuilder<SlDetails> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("summary"), value);
    }
    /// <summary>
    /// The summary to show in the header. If you need to display HTML, use the `summary` slot instead.
    /// </summary>
    public static void SetSummary(this PropsBuilder<SlDetails> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("summary"), b.Const(value));
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlDetails> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

