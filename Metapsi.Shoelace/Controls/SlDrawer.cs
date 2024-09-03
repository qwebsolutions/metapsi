using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlDrawer
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The drawer's label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Optional actions to add to the header. Works best with `&lt;sl-icon-button&gt;`. </para>
        /// </summary>
        public const string HeaderActions = "header-actions";
        /// <summary>
        /// <para> The drawer's footer, usually one or more buttons representing various options. </para>
        /// </summary>
        public const string Footer = "footer";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the drawer. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the drawer </para>
        /// </summary>
        public const string Hide = "hide";
    }
}

public static partial class SlDrawerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDrawer(this HtmlBuilder b, Action<AttributesBuilder<SlDrawer>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-drawer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDrawer(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-drawer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDrawer(this HtmlBuilder b, Action<AttributesBuilder<SlDrawer>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-drawer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDrawer(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-drawer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDrawer> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlDrawer> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacement(this AttributesBuilder<SlDrawer> b, string placement)
    {
        b.SetAttribute("placement", placement);
    }

    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementTop(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementEnd(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("placement", "end");
    }

    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementBottom(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementStart(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("placement", "start");
    }

    /// <summary>
    /// <para> By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent. </para>
    /// </summary>
    public static void SetContained(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("contained", "");
    }

    /// <summary>
    /// <para> By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent. </para>
    /// </summary>
    public static void SetContained(this AttributesBuilder<SlDrawer> b, bool contained)
    {
        if (contained) b.SetAttribute("contained", "");
    }

    /// <summary>
    /// <para> Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer. </para>
    /// </summary>
    public static void SetNoHeader(this AttributesBuilder<SlDrawer> b)
    {
        b.SetAttribute("no-header", "");
    }

    /// <summary>
    /// <para> Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer. </para>
    /// </summary>
    public static void SetNoHeader(this AttributesBuilder<SlDrawer> b, bool noHeader)
    {
        if (noHeader) b.SetAttribute("no-header", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDrawer(this LayoutBuilder b, Action<PropsBuilder<SlDrawer>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-drawer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDrawer(this LayoutBuilder b, Action<PropsBuilder<SlDrawer>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-drawer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDrawer(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-drawer", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDrawer(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-drawer", children);
    }
    /// <summary>
    /// <para> Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the drawer is open. You can toggle this attribute to show and hide the drawer, or you can use the `show()` and `hide()` methods and this attribute will reflect the drawer's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(open));
    }


    /// <summary>
    /// <para> The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The drawer's label as displayed in the header. You should always include a relevant label even when using `no-header`, as it is required for proper accessibility. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementTop<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("top"));
    }


    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementEnd<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("end"));
    }


    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementBottom<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The direction from which the drawer will open. </para>
    /// </summary>
    public static void SetPlacementStart<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("start"));
    }


    /// <summary>
    /// <para> By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent. </para>
    /// </summary>
    public static void SetContained<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("contained"), b.Const(true));
    }


    /// <summary>
    /// <para> By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent. </para>
    /// </summary>
    public static void SetContained<T>(this PropsBuilder<T> b, Var<bool> contained) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("contained"), contained);
    }

    /// <summary>
    /// <para> By default, the drawer slides out of its containing block (usually the viewport). To make the drawer slide out of its parent element, set this attribute and add `position: relative` to the parent. </para>
    /// </summary>
    public static void SetContained<T>(this PropsBuilder<T> b, bool contained) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("contained"), b.Const(contained));
    }


    /// <summary>
    /// <para> Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer. </para>
    /// </summary>
    public static void SetNoHeader<T>(this PropsBuilder<T> b) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noHeader"), b.Const(true));
    }


    /// <summary>
    /// <para> Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer. </para>
    /// </summary>
    public static void SetNoHeader<T>(this PropsBuilder<T> b, Var<bool> noHeader) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noHeader"), noHeader);
    }

    /// <summary>
    /// <para> Removes the header. This will also remove the default close button, so please ensure you provide an easy, accessible way for users to dismiss the drawer. </para>
    /// </summary>
    public static void SetNoHeader<T>(this PropsBuilder<T> b, bool noHeader) where T: SlDrawer
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noHeader"), b.Const(noHeader));
    }


    /// <summary>
    /// <para> Emitted when the drawer opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the drawer opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the drawer opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the drawer opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the drawer opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the drawer opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the drawer opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the drawer opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the drawer closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the drawer closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the drawer closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the drawer closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the drawer closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the drawer closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the drawer closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the drawer closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-initial-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the drawer opens and is ready to receive focus. Calling `event.preventDefault()` will prevent focusing and allow you to set it on a different element, such as an input. </para>
    /// </summary>
    public static void OnSlInitialFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-initial-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// <para> Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-request-close", action);
    }
    /// <summary>
    /// <para> Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlRequestCloseEventArgs>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-request-close", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user attempts to close the drawer by clicking the close button, clicking the overlay, or pressing escape. Calling `event.preventDefault()` will keep the drawer open. Avoid using this unless closing the drawer will result in destructive behavior such as data loss. </para>
    /// </summary>
    public static void OnSlRequestClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRequestCloseEventArgs>, Var<TModel>> action) where TComponent: SlDrawer
    {
        b.OnEventAction("onsl-request-close", b.MakeAction(action), "detail");
    }

}

