﻿using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Shoelace;

public class Tooltip
{
    public string Text { get; set; }
}

public static partial class Control
{
    public static Var<HyperNode> Tooltip(this BlockBuilder b, Var<Tooltip> props, Func<BlockBuilder, Var<HyperNode>> anchorNode = null)
    {
        var tooltip = b.SlNode("sl-tooltip");

        b.SetAttrIfNotEmptyString(tooltip, DynamicProperty.String("content"), b.Get(props, x => x.Text));

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
                b.Set(x => x.Text, text);
            });

        return b.Tooltip(props, content);
    }
}