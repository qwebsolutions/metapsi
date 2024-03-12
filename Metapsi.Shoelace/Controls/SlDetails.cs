using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlDetails
{
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
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
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
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-show"), eventAction);
    }
    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-show"), eventAction);
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-show"), eventAction);
    }
    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-show"), eventAction);
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-hide"), eventAction);
    }
    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-hide"), eventAction);
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDetails> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-hide"), eventAction);
    }
    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDetails> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-hide"), eventAction);
    }

}

