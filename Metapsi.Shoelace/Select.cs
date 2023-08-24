using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Shoelace;

public class Select
{
    public string Label { get; set; } = string.Empty;
    public string HelpText { get; set; } = string.Empty;
}

public static partial class Control
{
    public static Var<HyperNode> Select(this BlockBuilder b, Var<Select> props, Var<List<Option>> options)
    {
        var select = b.SlNode("sl-select");
        b.SetOptionalAttribute(select, "label", b.Get(props, x => x.Label));
        b.SetOptionalAttribute(select, "help-text", b.Get(props, x => x.HelpText));

        b.AddChildren(select, b.Map(options, Control.Option));

        return select;
    }

    public static Var<HyperNode> Select(this BlockBuilder b, Select props, Var<List<Option>> options)
    {
        return b.Select(b.Const(props), options);
    }
}
