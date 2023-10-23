using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;

namespace Metapsi.Shoelace;

public record ShoelaceTag(string tag);

public static class Import
{
    public static void Shoelace(LayoutBuilder b, ShoelaceVersion shoelaceVersion = null)
    {
        if (shoelaceVersion == null)
        {
            shoelaceVersion = JsDelivr("latest");
        }

        b.AddScript(shoelaceVersion.AutoloaderUrl, "module");
        b.AddStylesheet(shoelaceVersion.StylesheetUrl);
    }

    public static Var<HyperNode> SlNode(this LayoutBuilder b, string tag)
    {
        Import.Shoelace(b);
        b.Const(new ShoelaceTag(tag));
        return b.Node(tag);
    }

    public class ShoelaceVersion
    {
        public string AutoloaderUrl { get; set; }
        public string StylesheetUrl { get; set; }
    }

    public static ShoelaceVersion JsDelivr(string version)
    {
        return new ShoelaceVersion()
        {
            AutoloaderUrl = $"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{version}/cdn/shoelace-autoloader.js",
            StylesheetUrl = $"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{version}/cdn/themes/light.css"
        };
    }

    public static void AddShoelace(this DocumentTag document, ShoelaceVersion shoelaceVersion = null)
    {
        if (shoelaceVersion == null)
        {
            shoelaceVersion = JsDelivr("latest");
        }

        document.Head.AddChild(new ExternalScriptTag(shoelaceVersion.AutoloaderUrl, "module"));
        document.Head.AddChild(new LinkTag("stylesheet", shoelaceVersion.StylesheetUrl));
    }
}

public static class PropExtensions
{
    public static void SetOptionalAttribute(
        this LayoutBuilder b,
        Var<HyperNode> node,
        string htmlAttribute,
        Var<string> value)
    {
        b.If(b.HasValue(value), b => b.SetAttr(node, new DynamicProperty<string>(htmlAttribute), value));
    }
}