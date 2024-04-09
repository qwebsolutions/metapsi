using Metapsi.Html;
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

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlA(
            b =>
            {
                b.SetAttribute("href", "https://www.w3schools.com/tags/tag_a.asp");
                b.SetAttribute("target", b.Const("_blank"));
                b.SetAttribute("class", "underline text-blue-500");
            },
            b.Text("link"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}