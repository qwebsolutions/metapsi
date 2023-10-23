using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Custom tags - Shoelace avatar
/// </summary>
public class CustomTagsShoelaceComponent : TutorialSample<CustomTagsShoelaceComponent.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        // Imports the js & css of a web components library. We'll get to that later
        b.AddScript("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.8.0/cdn/shoelace-autoloader.js", "module");
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.8.0/cdn/themes/light.css");

        return b.Node("sl-avatar");
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}