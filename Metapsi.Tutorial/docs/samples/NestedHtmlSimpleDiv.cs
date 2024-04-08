using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Creating a styled div with styled text inside
/// </summary>
public class NestedHtmlSimpleDiv : TutorialSample<NestedHtmlSimpleDiv.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("bg-blue-100");
            },
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-blue-600");
                },
                b.Text("Text inside div")));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}