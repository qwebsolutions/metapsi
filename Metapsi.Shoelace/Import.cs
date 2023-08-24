using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public record ShoelaceTag(string tag);

public static class Import
{
    public static void Shoelace(BlockBuilder b)
    {
        b.AddScript("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module");
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css");
    }

    public static Var<HyperNode> SlNode(this BlockBuilder b, string tag)
    {
        Import.Shoelace(b);
        b.Const(new ShoelaceTag(tag));
        return b.Node(tag);
    }
}

public static class PropExtensions
{
    public static void SetOptionalAttribute(
        this BlockBuilder b,
        Var<HyperNode> node,
        string htmlAttribute,
        Var<string> value)
    {
        b.If(b.HasValue(value), b => b.SetAttr(node, new DynamicProperty<string>(htmlAttribute), value));
    }
}