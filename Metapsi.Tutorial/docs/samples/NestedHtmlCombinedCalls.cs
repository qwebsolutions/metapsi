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

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var firstRow = b.Span("flex flex-row justify-between");

        b.Add(
            firstRow,
            b.Text(
                "Blue text inside span",
                "text-blue-600"));

        b.Add(firstRow,
            b.Text(
                "Green text inside span",
                "text-green-600"));

        return b.Div(
            "flex flex-col",
            b => firstRow,
            b => b.Text(
                "Red text inside div",
                "text-red-600"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}