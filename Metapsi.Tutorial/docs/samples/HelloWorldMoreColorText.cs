using Metapsi.Html;
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

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlSpan(
            b =>
            {
                b.SetClass("text-blue-600 bg-green-100 border border-red-500");
            }, 
            b.T("Hello world"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}