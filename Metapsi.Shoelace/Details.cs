﻿using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Shoelace;

public class Details
{
    public string Summary { get; set; } = string.Empty;
    public bool Open { get; set; } = false;
}

public static partial class Control
{
    public static Var<HyperNode> Details(this LayoutBuilder b, Var<Details> props, Func<LayoutBuilder, Var<HyperNode>> content = null)
    {
        var details = b.SlNode("sl-details");
        var summary = b.Get(props, x => x.Summary);

        b.SetAttr(details, new DynamicProperty<bool>("open"), b.Get(props, x => x.Open));

        b.If(
            b.HasValue(summary),
            b =>
            {
                b.SetAttr(details, new DynamicProperty<string>("summary"), summary);
            });

        if (content != null)
        {
            b.Add(details, content(b));
        }

        return details;
    }
}