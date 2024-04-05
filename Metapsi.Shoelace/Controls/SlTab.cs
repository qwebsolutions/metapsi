using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTab : SlComponent
{
    public SlTab() : base("sl-tab") { }
    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public string panel
    {
        get
        {
            return this.GetTag().GetAttribute<string>("panel");
        }
        set
        {
            this.GetTag().SetAttribute("panel", value.ToString());
        }
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public bool active
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("active");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("active", value.ToString());
        }
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public bool closable
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("closable");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("closable", value.ToString());
        }
    }

    /// <summary>
    /// Disables the tab and prevents selection.
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

    public static class Method
    {
        /// <summary> 
        /// Sets focus to the tab.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the tab.
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlTabControl
{
    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Action<PropsBuilder<SlTab>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab", buildProps, children);
    }
    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Action<PropsBuilder<SlTab>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab", buildProps, children);
    }
    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel(this PropsBuilder<SlTab> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("panel"), value);
    }
    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel(this PropsBuilder<SlTab> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("panel"), b.Const(value));
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive(this PropsBuilder<SlTab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("active"), b.Const(true));
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable(this PropsBuilder<SlTab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("closable"), b.Const(true));
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlTab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-close", action);
    }
    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-close", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-close", action);
    }
    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-close", b.MakeAction(action));
    }

}

