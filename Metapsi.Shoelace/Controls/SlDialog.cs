using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlDialog
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The dialog's label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Optional actions to add to the header. Works best with `&lt;sl-icon-button&gt;`. </para>
        /// </summary>
        public const string HeaderActions = "header-actions";
        /// <summary>
        /// <para> The dialog's footer, usually one or more buttons representing various options. </para>
        /// </summary>
        public const string Footer = "footer";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the dialog. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the dialog </para>
        /// </summary>
        public const string Hide = "hide";
    }
}

public static partial class SlDialogControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDialog(this HtmlBuilder b, Action<AttributesBuilder<SlDialog>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-dialog", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDialog(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-dialog", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDialog(this HtmlBuilder b, Action<AttributesBuilder<SlDialog>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-dialog", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDialog(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-dialog", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDialog> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDialog> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlDialog> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog. </para>
    /// </summary>
    public static void SetNoHeader(this AttributesBuilder<SlDialog> b)
    {
        b.SetAttribute("no-header", "");
    }

    /// <summary>
    /// <para> Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog. </para>
    /// </summary>
    public static void SetNoHeader(this AttributesBuilder<SlDialog> b, bool noHeader)
    {
        if (noHeader) b.SetAttribute("no-header", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDialog(this LayoutBuilder b, Action<PropsBuilder<SlDialog>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-dialog", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDialog(this LayoutBuilder b, Action<PropsBuilder<SlDialog>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-dialog", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDialog(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-dialog", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDialog(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-dialog", children);
    }
    /// <summary>
    /// <para> Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the dialog is open. You can toggle this attribute to show and hide the dialog, or you can use the `show()` and `hide()` methods and this attribute will reflect the dialog's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(open));
    }


    /// <summary>
    /// <para> The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The dialog's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog. </para>
    /// </summary>
    public static void SetNoHeader<T>(this PropsBuilder<T> b) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noHeader"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog. </para>
    /// </summary>
    public static void SetNoHeader<T>(this PropsBuilder<T> b, Var<bool> noHeader) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noHeader"), noHeader);
    }

    /// <summary>
    /// <para> Disables the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the dialog. </para>
    /// </summary>
    public static void SetNoHeader<T>(this PropsBuilder<T> b, bool noHeader) where T: SlDialog
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noHeader"), b.Const(noHeader));
    }


    /// <summary>
    /// <para> Emitted when the dialog opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the dialog opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dialog opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the dialog opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dialog opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the dialog opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dialog opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the dialog opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dialog closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the dialog closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dialog closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the dialog closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dialog closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the dialog closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dialog closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the dialog closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the dialog opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// <para> Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// <para> Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlRequestCloseEventArgs>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-request-close", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user attempts to close the dialog by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the dialog open. Avoid using this unless closing the dialog will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRequestCloseEventArgs>, Var<TModel>> action) where TComponent: SlDialog
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action), "detail");
    }

}

