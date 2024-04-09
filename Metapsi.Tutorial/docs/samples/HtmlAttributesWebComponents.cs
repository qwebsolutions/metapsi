using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Shoelace web component
/// </summary>
public class HtmlAttributesWebComponents : TutorialSample<HtmlAttributesWebComponents.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("p-8"); // padding of 8 tailwind units
            },
            b.SlButton(
                b =>
                {
                    b.SetVariantText();
                },
                b.Text("Warnings"),
                b.SlBadge(
                    b =>
                    {
                        b.SetVariantWarning();
                        b.SetPill();
                        b.SetPulse();
                    },
                b.Text("17"))));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}