using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlInclude
{
}
public partial class SlIncludeLoadArgs
{
    public IClientSideSlInclude target { get; set; }
}
public partial class SlIncludeErrorArgs
{
    public IClientSideSlInclude target { get; set; }
    public partial class Details 
    {
        public int status { get; set; }
    }
    public Details detail { get; set; }
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
    public static void SetModeNocors(this PropsBuilder<SlInclude> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("no-cors"));
    }
    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeSameorigin(this PropsBuilder<SlInclude> b)
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
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, SlIncludeLoadArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlIncludeLoadArgs>>("onsl-load"), action);
    }
    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlIncludeLoadArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlIncludeLoadArgs>>("onsl-load"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// event detail: { status: number }
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, Var<HyperType.Action<TModel, SlIncludeErrorArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlIncludeErrorArgs>>("onsl-error"), action);
    }
    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// event detail: { status: number }
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlInclude> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlIncludeErrorArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlIncludeErrorArgs>>("onsl-error"), b.MakeAction(action));
    }
}

/// <summary>
/// Includes give you the power to embed external HTML files into the page.
/// </summary>
public partial class SlInclude : HtmlTag
{
    public SlInclude()
    {
        this.Tag = "sl-include";
    }

    public static SlInclude New()
    {
        return new SlInclude();
    }
}

public static partial class SlIncludeControl
{
    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static SlInclude SetSrc(this SlInclude tag, string value)
    {
        return tag.SetAttribute("src", value.ToString());
    }
    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static SlInclude SetModeCors(this SlInclude tag)
    {
        return tag.SetAttribute("mode", "cors");
    }
    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static SlInclude SetModeNocors(this SlInclude tag)
    {
        return tag.SetAttribute("mode", "no-cors");
    }
    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static SlInclude SetModeSameorigin(this SlInclude tag)
    {
        return tag.SetAttribute("mode", "same-origin");
    }
    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static SlInclude SetAllowScripts(this SlInclude tag)
    {
        return tag.SetAttribute("allowScripts", "true");
    }
}

