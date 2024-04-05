using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlDrawer : SlComponent
{
    public SlDrawer() : base("sl-drawer") { }
    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
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
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public string placement
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placement");
        }
        set
        {
            this.GetTag().SetAttribute("placement", value.ToString());
        }
    }

    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public bool contained
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("contained");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("contained", value.ToString());
        }
    }

    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public bool noHeader
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("noHeader");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("noHeader", value.ToString());
        }
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
    public static class Method
    {
        /// <summary> 
        /// Shows the drawer.
        /// </summary>
        public const string Show = "show";
        /// <summary> 
        /// Hides the drawer
        /// </summary>
        public const string Hide = "hide";
    }
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
    public static void OnSlShow<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, Var<HyperType.Action<TModel, SlRequestCloseEventArgs>> action)
    {
        b.OnEventAction("onsl-request-close", action, "detail");
    }
    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDrawer> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRequestCloseEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action), "detail");
    }

}

