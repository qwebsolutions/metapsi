using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlDrawer
{
}
public partial class SlDrawerShowArgs
{
    public IClientSideSlDrawer target { get; set; }
}
public partial class SlDrawerAfterShowArgs
{
    public IClientSideSlDrawer target { get; set; }
}
public partial class SlDrawerHideArgs
{
    public IClientSideSlDrawer target { get; set; }
}
public partial class SlDrawerAfterHideArgs
{
    public IClientSideSlDrawer target { get; set; }
}
public partial class SlDrawerInitialFocusArgs
{
    public IClientSideSlDrawer target { get; set; }
}
public partial class SlDrawerRequestCloseArgs
{
    public IClientSideSlDrawer target { get; set; }
    public partial class Details 
    {
        public string source { get; set; }
    }
    public Details detail { get; set; }
}
public static partial class SlDrawerControl
{
    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Var<IVNode> SlDrawer(this LayoutBuilder b, Action<PropsBuilder<SlDrawer>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-drawer", buildProps, children);
    }
    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Var<IVNode> SlDrawer(this LayoutBuilder b, Action<PropsBuilder<SlDrawer>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-drawer", buildProps, children);
    }
    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
    }
    /// <summary>
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlDrawer> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlDrawer> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementTop(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top"));
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementEnd(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("end"));
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementBottom(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom"));
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementStart(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("start"));
    }
    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static void SetContained(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("contained"), b.Const(true));
    }
    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static void SetNoHeader(this PropsBuilder<SlDrawer> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("noHeader"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlDrawerShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerShowArgs>>("onsl-show"), action);
    }
    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDrawerShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerShowArgs>>("onsl-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlDrawerAfterShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerAfterShowArgs>>("onsl-after-show"), action);
    }
    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDrawerAfterShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerAfterShowArgs>>("onsl-after-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlDrawerHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerHideArgs>>("onsl-hide"), action);
    }
    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDrawerHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerHideArgs>>("onsl-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlDrawerAfterHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerAfterHideArgs>>("onsl-after-hide"), action);
    }
    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDrawerAfterHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerAfterHideArgs>>("onsl-after-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlDrawerInitialFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerInitialFocusArgs>>("onsl-initial-focus"), action);
    }
    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDrawerInitialFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerInitialFocusArgs>>("onsl-initial-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// event detail: { source: 'close-button' | 'keyboard' | 'overlay' }
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlDrawerRequestCloseArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerRequestCloseArgs>>("onsl-request-close"), action);
    }
    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// event detail: { source: 'close-button' | 'keyboard' | 'overlay' }
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDrawerRequestCloseArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDrawerRequestCloseArgs>>("onsl-request-close"), b.MakeAction(action));
    }
}

/// <summary>
/// Drawers slide in from a container to expose additional options and information.
/// </summary>
public partial class SlDrawer : HtmlTag
{
    public SlDrawer()
    {
        this.Tag = "sl-drawer";
    }

    public static SlDrawer New()
    {
        return new SlDrawer();
    }
    public static class Slot
    {
        /// <summary> 
        /// The drawer's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Optional actions to add to the header. Works best with `<sl-icon-button>`.
        /// </summary>
        public const string HeaderActions = "header-actions";
        /// <summary> 
        /// The drawer's footer, usually one or more buttons representing various options.
        /// </summary>
        public const string Footer = "footer";
    }
}

public static partial class SlDrawerControl
{
    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static SlDrawer SetOpen(this SlDrawer tag)
    {
        return tag.SetAttribute("open", "true");
    }
    /// <summary>
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static SlDrawer SetLabel(this SlDrawer tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static SlDrawer SetPlacementTop(this SlDrawer tag)
    {
        return tag.SetAttribute("placement", "top");
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static SlDrawer SetPlacementEnd(this SlDrawer tag)
    {
        return tag.SetAttribute("placement", "end");
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static SlDrawer SetPlacementBottom(this SlDrawer tag)
    {
        return tag.SetAttribute("placement", "bottom");
    }
    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static SlDrawer SetPlacementStart(this SlDrawer tag)
    {
        return tag.SetAttribute("placement", "start");
    }
    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static SlDrawer SetContained(this SlDrawer tag)
    {
        return tag.SetAttribute("contained", "true");
    }
    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static SlDrawer SetNoHeader(this SlDrawer tag)
    {
        return tag.SetAttribute("noHeader", "true");
    }
}

