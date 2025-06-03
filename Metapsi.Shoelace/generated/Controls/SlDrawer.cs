using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Drawers slide in from a container to expose additional options and information.
/// </summary>
public partial class SlDrawer
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The drawer's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Optional actions to add to the header. Works best with `&lt;sl-icon-button&gt;`.
        /// </summary>
        public const string HeaderActions = "header-actions";
        /// <summary>
        /// The drawer's footer, usually one or more buttons representing various options.
        /// </summary>
        public const string Footer = "footer";
    }
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlDrawer
/// </summary>
public static partial class SlDrawerControl
{
    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDrawer(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDrawer>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-drawer", buildAttributes, children);
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDrawer(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-drawer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDrawer(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDrawer>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-drawer", buildAttributes, children);
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDrawer(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-drawer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDrawer> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlDrawer> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementTop(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementEnd(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("placement", "end");
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementBottom(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementStart(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("placement", "start");
    }

    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static void SetContained(this Metapsi.Html.AttributesBuilder<SlDrawer> b, bool contained) 
    {
        if (contained) b.SetAttribute("contained", "");
    }

    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static void SetContained(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("contained", "");
    }

    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static void SetNoHeader(this Metapsi.Html.AttributesBuilder<SlDrawer> b, bool noHeader) 
    {
        if (noHeader) b.SetAttribute("no-header", "");
    }

    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static void SetNoHeader(this Metapsi.Html.AttributesBuilder<SlDrawer> b) 
    {
        b.SetAttribute("no-header", "");
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDrawer(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDrawer>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-drawer", buildProps, children);
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDrawer(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-drawer", children);
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDrawer(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDrawer>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-drawer", buildProps, children);
    }

    /// <summary>
    /// Drawers slide in from a container to expose additional options and information.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDrawer(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-drawer", children);
    }

    /// <summary>
    /// Exposes the internal modal utility that controls focus trapping. To temporarily disable focus trapping and allow third-party modals spawned from an active Shoelace modal, call `modal.activateExternal()` when the third-party modal opens. Upon closing, call `modal.deactivateExternal()` to restore Shoelace's focus trapping.
    /// </summary>
    public static void SetModal<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> modal) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("modal"), modal);
    }

    /// <summary>
    /// Exposes the internal modal utility that controls focus trapping. To temporarily disable focus trapping and allow third-party modals spawned from an active Shoelace modal, call `modal.activateExternal()` when the third-party modal opens. Upon closing, call `modal.deactivateExternal()` to restore Shoelace's focus trapping.
    /// </summary>
    public static void SetModal<T>(this Metapsi.Syntax.PropsBuilder<T> b, string modal) where T: SlDrawer
    {
        b.SetModal(b.Const(modal));
    }

    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlDrawer
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlDrawer
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("end"));
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }

    /// <summary>
    /// The direction from which the drawer will open.
    /// </summary>
    public static void SetPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("start"));
    }

    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static void SetContained<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetContained(b.Const(true));
    }

    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static void SetContained<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> contained) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("contained"), contained);
    }

    /// <summary>
    /// By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent.
    /// </summary>
    public static void SetContained<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool contained) where T: SlDrawer
    {
        b.SetContained(b.Const(contained));
    }

    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static void SetNoHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetNoHeader(b.Const(true));
    }

    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static void SetNoHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> noHeader) where T: SlDrawer
    {
        b.SetProperty(b.Props, b.Const("noHeader"), noHeader);
    }

    /// <summary>
    /// Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer.
    /// </summary>
    public static void SetNoHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool noHeader) where T: SlDrawer
    {
        b.SetNoHeader(b.Const(noHeader));
    }

    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the drawer opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the drawer opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the drawer closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the drawer closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-initial-focus", action);
    }

    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlInitialFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-initial-focus", action);
    }

    /// <summary>
    /// Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input.
    /// </summary>
    public static void OnSlInitialFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlInitialFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-request-close", action);
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlRequestClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-request-close", action);
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDrawer
    {
        b.OnSlRequestClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss.
    /// </summary>
    public static void OnSlRequestClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlRequestCloseDetail>>> action) where T: SlDrawer
    {
        b.OnSlEvent("onsl-request-close", action);
    }

}