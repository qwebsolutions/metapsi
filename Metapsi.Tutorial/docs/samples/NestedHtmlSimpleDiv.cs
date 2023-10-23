using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Creating a styled div with styled text inside
/// </summary>
public class NestedHtmlSimpleDiv : TutorialSample<NestedHtmlSimpleDiv.Model>
{
    public class Model
    {
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var div = b.Div("bg-blue-100");
        b.Add(div, b.Text("Text inside div", "text-blue-600"));
        return div;
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}