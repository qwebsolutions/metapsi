using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlInclude : SlComponent
{
    public SlInclude() : base("sl-include") { }
    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public string src
    {
        get
        {
            return this.GetTag().GetAttribute<string>("src");
        }
        set
        {
            this.GetTag().SetAttribute("src", value.ToString());
        }
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public bool allowScripts
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("allow-scripts");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("allow-scripts", value.ToString());
        }
    }

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
        b.SetDynamic(b.Props, DynamicProperty.String("allow-scripts"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, SlErrorEventArgs>> action)
    {
        b.OnEventAction("onsl-error", action, "detail");
    }
    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlErrorEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action), "detail");
    }

}

