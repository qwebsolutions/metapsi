using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Lazy button
/// </summary>
public class SimpleAction : TutorialSample<SimpleAction.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlButton(
            b=>
            {
                b.SetClass("bg-green-600 rounded shadow p-2 text-white");

                b.OnClickAction((SyntaxBuilder b, Var<Model> model) =>
                {
                    return model;
                });
            },
            b.Text("Do nothing!"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}
