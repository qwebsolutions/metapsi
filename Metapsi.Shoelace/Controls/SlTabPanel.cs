using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTabPanel : SlComponent
{
    public SlTabPanel() : base("sl-tab-panel") { }
    /// <summary>
    /// The tab panel's name.
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
    /// When true, the tab panel will be shown.
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

}

public static partial class SlTabPanelControl
{
    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Var<IVNode> SlTabPanel(this LayoutBuilder b, Action<PropsBuilder<SlTabPanel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab-panel", buildProps, children);
    }
    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Var<IVNode> SlTabPanel(this LayoutBuilder b, Action<PropsBuilder<SlTabPanel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab-panel", buildProps, children);
    }
    /// <summary>
    /// The tab panel's name.
    /// </summary>
    public static void SetName(this PropsBuilder<SlTabPanel> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The tab panel's name.
    /// </summary>
    public static void SetName(this PropsBuilder<SlTabPanel> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static void SetActive(this PropsBuilder<SlTabPanel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("active"), b.Const(true));
    }

}

