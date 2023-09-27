using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// You can add as many children as you like
/// </summary>
public class NestedHtmlSpanMoreChildren : TutorialSample<NestedHtmlSpanMoreChildren.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var span = b.Span();
        b.Add(span, b.Text("Blue text inside span", "text-blue-600"));
        b.Add(span, b.Text("Green text inside span", "text-green-600"));
        b.Add(span, b.Text("Red text inside span", "text-red-600"));
        return span;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}