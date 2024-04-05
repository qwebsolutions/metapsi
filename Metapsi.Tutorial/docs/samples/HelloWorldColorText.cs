using Metapsi.Html;
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

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlSpan(
            b =>
            {
                b.AddClass("text-blue-600");
            },
            b.T("Hello world"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}