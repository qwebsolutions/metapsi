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

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        return b.Div(
            "flex flex-col",
            b => b.Span(
                "flex flex-row justify-between",
                b => b.Text(
                    "Blue text inside span",
                    "text-blue-600"),
                b => b.Text(
                    "Green text inside span",
                    "text-green-600")),
            b => b.Text(
                "Red text inside div",
                "text-red-600"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}