using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
/// </summary>
public partial class SlDialog
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The dialog's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Optional actions to add to the header. Works best with `&lt;sl-icon-button&gt;`.
        /// </summary>
        public const string HeaderActions = "header-actions";
        /// <summary>
        /// The dialog's footer, usually one or more buttons representing various options.
        /// </summary>
        public const string Footer = "footer";
    }
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlDialog
/// </summary>
public static partial class SlDialogControl
{
    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDialog(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDialog>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-dialog", buildAttributes, children);
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDialog(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-dialog", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDialog(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDialog>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-dialog", buildAttributes, children);
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDialog(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-dialog", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDialog> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDialog> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlDialog> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public static void SetNoHeader(this Metapsi.Html.AttributesBuilder<SlDialog> b, bool noHeader) 
    {
        if (noHeader) b.SetAttribute("no-header", "");
    }

    /// <summary>
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public static void SetNoHeader(this Metapsi.Html.AttributesBuilder<SlDialog> b) 
    {
        b.SetAttribute("no-header", "");
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDialog(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDialog>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-dialog", buildProps, children);
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDialog(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-dialog", children);
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDialog(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDialog>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-dialog", buildProps, children);
    }

    /// <summary>
    /// Dialogs, sometimes called "modals", appear above the page and require the user's immediate attention.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDialog(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-dialog", children);
    }

    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDialog
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlDialog
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlDialog
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlDialog
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlDialog
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public static void SetNoHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDialog
    {
        b.SetNoHeader(b.Const(true));
    }

    /// <summary>
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public static void SetNoHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> noHeader) where T: SlDialog
    {
        b.SetProperty(b.Props, b.Const("noHeader"), noHeader);
    }

    /// <summary>
    /// Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog.
    /// </summary>
    public static void SetNoHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool noHeader) where T: SlDialog
    {
        b.SetNoHeader(b.Const(noHeader));
    }

    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the dialog opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the dialog opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the dialog closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the dialog closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-initial-focus", action);
    }

    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlInitialFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-initial-focus", action);
    }

    /// <summary>
    /// Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlInitialFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-request-close", action);
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlRequestClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-request-close", action);
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDialog
    {
        b.OnSlRequestClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlRequestCloseDetail>>> action) where T: SlDialog
    {
        b.OnSlEvent("onsl-request-close", action);
    }

}