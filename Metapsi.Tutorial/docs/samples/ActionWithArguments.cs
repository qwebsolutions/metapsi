using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Input string as argument
/// </summary>
public class ActionWithArguments : TutorialSample<ActionWithArguments.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlInput(
            b=>
            {
                b.SetClass("rounded p-2 border border-gray-200");
                b.SetPlaceholder("Here you can write some text");

                b.OnInputAction((SyntaxBuilder b, Var<Model> model, Var<string> inputValue) =>
                {
                    // we have the model and input value here
                    // now what?
                    return model;
                });
            });
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}
