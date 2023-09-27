using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// You can nest HTML elements multiple levels deep
/// </summary>
public class NestedHtmlLevels : TutorialSample<NestedHtmlLevels.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var container = b.Div("flex flex-col");

        var firstRow = b.Add(
            container, 
            b.Span("flex flex-row justify-between"));
        
        b.Add(
            firstRow, 
            b.Text(
                "Blue text inside span", 
                "text-blue-600"));

        b.Add(
            firstRow, 
            b.Text(
                "Green text inside span", 
                "text-green-600"));

        b.Add(
            container,
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