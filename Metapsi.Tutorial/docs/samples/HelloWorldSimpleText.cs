using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Hello world - output simple text
/// </summary>
public class HelloWorldSimpleText : TutorialSample<HelloWorldSimpleText.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        return b.Text("Hello world");
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}