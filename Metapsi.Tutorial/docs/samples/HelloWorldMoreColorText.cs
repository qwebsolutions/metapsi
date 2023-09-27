using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Hello world with more styling classes
/// </summary>
public class HelloWorldMoreColorText : TutorialSample<HelloWorldMoreColorText.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        return b.Text(
            "Hello world", 
            "text-blue-600 bg-green-100 border border-red-500");
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}