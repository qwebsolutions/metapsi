using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Setting attributes for a link
/// </summary>
public class HtmlAttributesCreateLink : TutorialSample<HtmlAttributesCreateLink.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var a = b.Node("a");
        b.SetAttr(a, Html.href, "https://www.w3schools.com/tags/tag_a.asp");
        b.SetAttr(a, Html.target, "_blank");
        b.Add(a, b.Text("link"));
        return a;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}