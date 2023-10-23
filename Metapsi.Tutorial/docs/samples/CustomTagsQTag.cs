using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// q tag
/// </summary>
public class CustomTagsQTag: TutorialSample<CustomTagsQTag.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var quotation = b.Node("q");
        b.Add(
            quotation,
            b.Text(
                "The obscure q tag is supposed to represent a quotation"));
        return quotation;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}