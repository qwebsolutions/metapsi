using Metapsi.Html;
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

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlA(
            b =>
            {
                b.SetClass("underline text-blue-500");
                b.SetHref("https://www.w3schools.com/tags/tag_a.asp");
                b.SetDynamic(b.Props, Hyperapp.Html.target, b.Const("_blank"));
            },
            b.T("link"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}