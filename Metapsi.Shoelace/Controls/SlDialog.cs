using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlDialog : SlComponent
{
    public SlDialog() : base("sl-dialog") { }
    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
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
    /// The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
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
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public bool noHeader
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("no-header");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("no-header", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// The dialog's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Optional actions to add to the header. Works best with `<sl-icon-button>`.
        /// </summary>
        public const string HeaderActions = "header-actions";
        /// <summary> 
        /// The dialog's footer, usually one or more buttons representing various options.
        /// </summary>
        public const string Footer = "footer";
    }
    public static class Method
    {
        /// <summary> 
        /// Shows the dialog.
        /// </summary>
        public const string Show = "show";
        /// <summary> 
        /// Hides the dialog
        /// </summary>
        public const string Hide = "hide";
    }
}

public static partial class SlDialogControl
{
    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Var<IVNode> SlDialog(this LayoutBuilder b, Action<PropsBuilder<SlDialog>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-dialog", buildProps, children);
    }
    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Var<IVNode> SlDialog(this LayoutBuilder b, Action<PropsBuilder<SlDialog>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-dialog", buildProps, children);
    }
    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlDialog> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
    }

    /// <summary>
    /// The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlDialog> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlDialog> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public static void SetNoHeader(this PropsBuilder<SlDialog> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("noHeader"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDialog> b, Var<HyperType.Action<TModel, SlRequestCloseEventArgs>> action)
    {
        b.OnEventAction("onsl-request-close", action, "detail");
    }
    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<TModel>(this PropsBuilder<SlDialog> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRequestCloseEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action), "detail");
    }

}

