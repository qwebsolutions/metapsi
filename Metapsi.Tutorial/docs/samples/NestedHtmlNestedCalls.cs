using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Nested builder
/// </summary>
public class NestedHtmlNestedCalls : TutorialSample<NestedHtmlNestedCalls.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col");
            },
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("flex flex-row justify-between");
                },
                b.HtmlSpan(
                    b =>
                    {
                        b.SetClass("text-blue-600");
                    },
                    b.Text("Blue text inside span")),
                b.HtmlSpan(
                    b =>
                    {
                        b.SetClass("text-green-600");
                    },
                    b.Text(
                    "Green text inside span"))),
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-red-600");
                },
                b.Text("Red text inside div")));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}