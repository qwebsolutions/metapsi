using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Hello world in color - basics of styling
/// </summary>
public class HelloWorldColorText : TutorialSample<HelloWorldColorText.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        return b.Text("Hello world", "text-blue-600");
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}