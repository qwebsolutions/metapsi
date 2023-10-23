using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Setting the class attribute
/// </summary>
public class HtmlAttributesSetClass : TutorialSample<HtmlAttributesSetClass.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var a = b.Node("a");
        b.SetAttr(a, Html.href, "https://www.w3schools.com/tags/tag_a.asp");
        b.SetAttr(a, Html.target, "_blank");
        b.SetAttr(a, Html.@class, "underline text-blue-500");
        b.Add(a, b.Text("link"));
        return a;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}