using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;

namespace Metapsi.Shoelace;

public enum TooltipPlacement
{
    Top,
    TopStart,
    TopEnd,
    Right,
    RightStart,
    RightEnd,
    Bottom,
    BottomStart,
    BottomEnd,
    Left,
    LeftStart,
    LeftEnd
}

public class Tooltip
{
    public string Content { get; set; }
    public TooltipPlacement Placement { get; set; } = TooltipPlacement.Top;

    public static Component<Tooltip> Create(Tooltip tooltip, IHtmlNode hoverNode, IHtmlElement tooltipContent)
    {
        var component = new Component<Tooltip>("sl-tooltip", tooltip);
        component.AddChild(hoverNode);
        component.AddChild(tooltipContent).SetAttribute("slot", "content");
        return component;
    }

    public static Component<Tooltip> Create(IHtmlNode hoverNode, string tooltipMessage)
    {
        return new Component<Tooltip>("sl-tooltip", new Tooltip() { Content = tooltipMessage });
    }
}

public static partial class Control
{
    public static Var<HyperNode> Tooltip(this BlockBuilder b, Var<Tooltip> props, Func<BlockBuilder, Var<HyperNode>> anchorNode = null)
    {
        var tooltip = b.SlNode("sl-tooltip");

        b.SetAttrIfNotEmptyString(tooltip, DynamicProperty.String("content"), b.Get(props, x => x.Content));

        if (anchorNode != null)
        {
            b.Add(tooltip, b.Call(anchorNode));
        }

        return tooltip;
    }

    public static Var<HyperNode> Tooltip(this BlockBuilder b, Var<string> text, Func<BlockBuilder, Var<HyperNode>> content = null)
    {
        var props = b.NewObj<Tooltip>(
            b =>
            {
                b.Set(x => x.Content, text);
            });

        return b.Tooltip(props, content);
    }
}
