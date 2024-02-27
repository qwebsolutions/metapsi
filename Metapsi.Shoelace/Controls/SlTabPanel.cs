using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTabPanel
{
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

/// <summary>
/// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
/// </summary>
public partial class SlTabPanel : HtmlTag
{
    public SlTabPanel()
    {
        this.Tag = "sl-tab-panel";
    }

    public static SlTabPanel New()
    {
        return new SlTabPanel();
    }
}

public static partial class SlTabPanelControl
{
    /// <summary>
    /// The tab panel's name.
    /// </summary>
    public static SlTabPanel SetName(this SlTabPanel tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static SlTabPanel SetActive(this SlTabPanel tag)
    {
        return tag.SetAttribute("active", "true");
    }
}

