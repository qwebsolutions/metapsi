using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonTabButton : IonComponent
{
    public IonTabButton() : base("ion-tab-button") { }
    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public string download
    {
        get
        {
            return this.GetTag().GetAttribute<string>("download");
        }
        set
        {
            this.GetTag().SetAttribute("download", value.ToString());
        }
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public string href
    {
        get
        {
            return this.GetTag().GetAttribute<string>("href");
        }
        set
        {
            this.GetTag().SetAttribute("href", value.ToString());
        }
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public string layout
    {
        get
        {
            return this.GetTag().GetAttribute<string>("layout");
        }
        set
        {
            this.GetTag().SetAttribute("layout", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
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
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public string rel
    {
        get
        {
            return this.GetTag().GetAttribute<string>("rel");
        }
        set
        {
            this.GetTag().SetAttribute("rel", value.ToString());
        }
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public bool selected
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("selected");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("selected", value.ToString());
        }
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public string tab
    {
        get
        {
            return this.GetTag().GetAttribute<string>("tab");
        }
        set
        {
            this.GetTag().SetAttribute("tab", value.ToString());
        }
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public string target
    {
        get
        {
            return this.GetTag().GetAttribute<string>("target");
        }
        set
        {
            this.GetTag().SetAttribute("target", value.ToString());
        }
    }

}

public static partial class IonTabButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTabButton(this LayoutBuilder b, Action<PropsBuilder<IonTabButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tab-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTabButton(this LayoutBuilder b, Action<PropsBuilder<IonTabButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tab-button", buildProps, children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonTabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this PropsBuilder<IonTabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonTabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this PropsBuilder<IonTabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconBottom(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-bottom"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconEnd(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-end"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconHide(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-hide"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconStart(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-start"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconTop(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-top"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutLabelHide(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("label-hide"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonTabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this PropsBuilder<IonTabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected(this PropsBuilder<IonTabButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("selected"), b.Const(true));
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this PropsBuilder<IonTabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), value);
    }
    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this PropsBuilder<IonTabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), b.Const(value));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonTabButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this PropsBuilder<IonTabButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

}

