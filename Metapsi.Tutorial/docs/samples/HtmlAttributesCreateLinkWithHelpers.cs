using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Setting typed attributes
/// </summary>
public class HtmlAttributesCreateLinkWithHelpers : TutorialSample<HtmlAttributesCreateLinkWithHelpers.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlA(
            b =>
            {
                b.SetHref("https://www.w3schools.com/tags/tag_a.asp");
                b.SetTarget("_blank");
                b.SetClass("underline text-blue-500");
            },
            b.Text("link"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}