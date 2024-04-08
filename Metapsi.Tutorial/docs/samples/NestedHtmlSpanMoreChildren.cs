using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// You can add as many children as you like
/// </summary>
public class NestedHtmlSpanMoreChildren : TutorialSample<NestedHtmlSpanMoreChildren.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlSpan(
            b => { },
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-blue-600");
                },
                b.Text("Blue text inside span")),
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-green-600");
                },
                b.Text("Green text inside span")),
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-red-600");
                },
                b.Text("Red text inside span")));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}