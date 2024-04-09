using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlIcon : SlComponent
{
    public SlIcon() : base("sl-icon") { }
    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public string name
    {
        get
        {
            return this.GetTag().GetAttribute<string>("name");
        }
        set
        {
            this.GetTag().SetAttribute("name", value.ToString());
        }
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
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
    /// An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices.
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
    /// The name of a registered custom icon library.
    /// </summary>
    public string library
    {
        get
        {
            return this.GetTag().GetAttribute<string>("library");
        }
        set
        {
            this.GetTag().SetAttribute("library", value.ToString());
        }
    }

    public static class Method
    {
        /// <summary> 
        /// Given a URL, this function returns the resulting SVG element or an appropriate error symbol.
        /// </summary>
        public const string ResolveIcon = "resolveIcon";
    }
}

public static partial class SlIconControl
{
    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, Action<PropsBuilder<SlIcon>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon", buildProps, children);
    }
    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, Action<PropsBuilder<SlIcon>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon", buildProps, children);
    }
    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon", children);
    }
    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon", children);
    }
    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName(this PropsBuilder<SlIcon> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName(this PropsBuilder<SlIcon> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlIcon> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), value);
    }
    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this PropsBuilder<SlIcon> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(value));
    }

    /// <summary>
    /// An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlIcon> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlIcon> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary(this PropsBuilder<SlIcon> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), value);
    }
    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary(this PropsBuilder<SlIcon> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlIcon> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlIcon> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlIcon> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<TModel>(this PropsBuilder<SlIcon> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlIcon> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlIcon> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlIcon> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<TModel>(this PropsBuilder<SlIcon> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

}

