using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Do you even notice it?
/// </summary>
public class NestedHtmlWrongReturn : TutorialSample<NestedHtmlWrongReturn.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var container = b.HtmlSpan(
            b =>
            {
                b.SetClass("flex flex-row justify-between");
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
                    b.Text("Green text inside span"))));

        var mainContainer = b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col");
            },
            container,
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-red-600");
                },
                b.Text("Red text inside div")));

        return container;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}