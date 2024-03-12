using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlInclude
{
}

public static partial class SlIncludeControl
{
    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Var<IVNode> SlInclude(this LayoutBuilder b, Action<PropsBuilder<SlInclude>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-include", buildProps, children);
    }
    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Var<IVNode> SlInclude(this LayoutBuilder b, Action<PropsBuilder<SlInclude>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-include", buildProps, children);
    }
    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlInclude> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), value);
    }
    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlInclude> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(value));
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeCors(this PropsBuilder<SlInclude> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("cors"));
    }
    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeNoCors(this PropsBuilder<SlInclude> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("no-cors"));
    }
    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeSameOrigin(this PropsBuilder<SlInclude> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("same-origin"));
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetAllowScripts(this PropsBuilder<SlInclude> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("allowScripts"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-load"), eventAction);
    }
    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-load"), eventAction);
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-error"), eventAction);
    }
    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-error"), eventAction);
    }

}

