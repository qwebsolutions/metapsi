using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// q tag
/// </summary>
public class CustomTagsQTag: TutorialSample<CustomTagsQTag.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.H("q", b.T("The obscure q tag is supposed to represent a quotation"));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}