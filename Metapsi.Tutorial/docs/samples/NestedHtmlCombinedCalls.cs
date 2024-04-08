using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Nested calls with combined style
/// </summary>
public class NestedHtmlCombinedCalls : TutorialSample<NestedHtmlCombinedCalls.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var firstRow = b.HtmlSpan(
            b =>
            {
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
                b.Text("Green text inside span")));

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col");
            },
            firstRow,
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