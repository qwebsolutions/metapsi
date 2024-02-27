using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTab
{
}
public partial class SlTabCloseArgs
{
    public IClientSideSlTab target { get; set; }
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
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, Var<HyperType.Action<TModel, SlTabCloseArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTabCloseArgs>>("onsl-close"), action);
    }
    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabCloseArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTabCloseArgs>>("onsl-close"), b.MakeAction(action));
    }
}

/// <summary>
/// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
/// </summary>
public partial class SlTab : HtmlTag
{
    public SlTab()
    {
        this.Tag = "sl-tab";
    }

    public static SlTab New()
    {
        return new SlTab();
    }
}

public static partial class SlTabControl
{
    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static SlTab SetPanel(this SlTab tag, string value)
    {
        return tag.SetAttribute("panel", value.ToString());
    }
    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static SlTab SetActive(this SlTab tag)
    {
        return tag.SetAttribute("active", "true");
    }
    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static SlTab SetClosable(this SlTab tag)
    {
        return tag.SetAttribute("closable", "true");
    }
    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static SlTab SetDisabled(this SlTab tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
}

