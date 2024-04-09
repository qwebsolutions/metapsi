using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Custom tags - Carbon drop down
/// </summary>
public class CustomTagsCarbonComponent : TutorialSample<CustomTagsCarbonComponent.Model>
{
    public class Model
    {
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        // Imports the js & css of a web components library.
        b.AddScript("https://1.www.s81c.com/common/carbon/web-components/tag/v2/latest/dropdown.min.js", "module");
        b.AddStylesheet("https://1.www.s81c.com/common/carbon-for-ibm-dotcom/tag/latest/plex.css");

        return b.H(
            "cds-dropdown",
            b=>
            {
                b.SetAttribute("value", "option2");
            },
            b.H(
                "cds-dropdown-item",
                b =>
                {
                    b.SetAttribute("value", "option1");
                },
                b.Text("Option 1")),
            b.H(
                "cds-dropdown-item",
                b =>
                {
                    b.SetAttribute("value", "option2");
                },
                b.Text("Option 2")));
    }

    public override Model GetSampleData()
    {
        return new Model();
    }
}