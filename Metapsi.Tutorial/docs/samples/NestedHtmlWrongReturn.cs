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

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var mainContainer = b.Div("flex flex-col");

        var container = b.Add(
            mainContainer,
            b.Span("flex flex-row justify-between"));

        b.Add(
            container,
            b.Text(
                "Blue text inside span",
                "text-blue-600"));

        b.Add(
            container,
            b.Text(
                "Green text inside span",
                "text-green-600"));

        b.Add(
            mainContainer,
            b.Text(
                "Red text inside div",
                "text-red-600"));

        return container;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}