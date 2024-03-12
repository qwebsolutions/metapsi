using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlIconButton
{
    public static class Method
    {
        /// <summary> 
        /// Simulates a click on the icon button.
        /// </summary>
        public const string Click = "click";
        /// <summary> 
        /// Sets focus on the icon button.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the icon button.
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlIconButtonControl
{
    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Var<IVNode> SlIconButton(this LayoutBuilder b, Action<PropsBuilder<SlIconButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon-button", buildProps, children);
    }
    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Var<IVNode> SlIconButton(this LayoutBuilder b, Action<PropsBuilder<SlIconButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon-button", buildProps, children);
    }
    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName(this PropsBuilder<SlIconButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName(this PropsBuilder<SlIconButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary(this PropsBuilder<SlIconButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), value);
    }
    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary(this PropsBuilder<SlIconButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), b.Const(value));
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlIconButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), value);
    }
    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlIconButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(value));
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`.
    /// </summary>
    public static void SetHref(this PropsBuilder<SlIconButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`.
    /// </summary>
    public static void SetHref(this PropsBuilder<SlIconButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_blank(this PropsBuilder<SlIconButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_blank"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_parent(this PropsBuilder<SlIconButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_parent"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_self(this PropsBuilder<SlIconButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_self"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_top(this PropsBuilder<SlIconButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_top"));
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is set.
    /// </summary>
    public static void SetDownload(this PropsBuilder<SlIconButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is set.
    /// </summary>
    public static void SetDownload(this PropsBuilder<SlIconButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlIconButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlIconButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlIconButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the icon button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlIconButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }
    /// <summary>
    /// Emitted when the icon button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlIconButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }

    /// <summary>
    /// Emitted when the icon button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlIconButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }
    /// <summary>
    /// Emitted when the icon button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlIconButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }

}

