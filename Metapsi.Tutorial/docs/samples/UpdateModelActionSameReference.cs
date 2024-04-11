using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Click it!
/// </summary>
public class UpdateModelActionSameReference : TutorialSample<UpdateModelActionSameReference.Model>
{
    public class Model
    {
        public int Value { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row items-center gap-8 p-2");
                },
                b.HtmlButton(
                    b =>
                    {
                        b.SetClass("bg-green-600 rounded shadow p-2 text-white");

                        b.OnClickAction((SyntaxBuilder b, Var<Model> model) =>
                        {
                            var incremented = b.Get(model, x => x.Value + 1);
                            b.Set(model, x => x.Value, incremented);
                            return model;
                        });
                    },
                    b.Text("Go up!")),
                b.HtmlSpanText(
                    b.Concat(
                        b.Const("from "),
                        b.AsString(b.Get(model, x => x.Value)))));
    }

    public override Model GetSampleData()
    {
        return new Model() { Value = 1 };
    }
}
