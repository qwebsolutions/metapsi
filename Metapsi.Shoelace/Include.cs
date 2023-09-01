using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public enum IncludeMode
{
    Cors,
    NoCors,
    SameOrigin
}

public class Include
{
    public string Src { get; set; }
    public IncludeMode Mode { get; set; }
    public bool AllowScripts { get; set; }
}

public static partial class Control
{
    public static Var<HyperNode> Include(this BlockBuilder b, Var<Include> props)
    {
        var include = b.Node("sl-include");
        b.SetAttr(include, DynamicProperty.String("src"), b.Get(props, x => x.Src));
        b.SetAttr(include, DynamicProperty.String("mode"), IncludeModeToString(b, b.Get(props, x => x.Mode)));
        b.SetAttr(include, DynamicProperty.Bool("allow-scripts"), b.Get(props, x => x.AllowScripts));

        return include;
    }

    public static Var<HyperNode> Include(this BlockBuilder b, Var<string> src)
    {
        return b.Include(b.NewObj<Include>(b => b.Set(x => x.Src, src)));
    }

    public static Var<HyperNode> Include(this BlockBuilder b, string src)
    {
        return b.Include(b.Const(src));
    }

    public static Var<string> IncludeModeToString(BlockBuilder b, Var<IncludeMode> mode)
    {
        return b.Switch(
            mode,
            b => b.Const("cors"),
            (IncludeMode.NoCors, b => b.Const("no-cors")),
            (IncludeMode.SameOrigin, b => b.Const("same-origin")));
    }
}