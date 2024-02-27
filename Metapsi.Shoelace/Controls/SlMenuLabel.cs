using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlMenuLabel
{
}
public static partial class SlMenuLabelControl
{
    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Var<IVNode> SlMenuLabel(this LayoutBuilder b, Action<PropsBuilder<SlMenuLabel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu-label", buildProps, children);
    }
    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Var<IVNode> SlMenuLabel(this LayoutBuilder b, Action<PropsBuilder<SlMenuLabel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu-label", buildProps, children);
    }
}

/// <summary>
/// Menu labels are used to describe a group of menu items.
/// </summary>
public partial class SlMenuLabel : HtmlTag
{
    public SlMenuLabel()
    {
        this.Tag = "sl-menu-label";
    }

    public static SlMenuLabel New()
    {
        return new SlMenuLabel();
    }
}

public static partial class SlMenuLabelControl
{
}

