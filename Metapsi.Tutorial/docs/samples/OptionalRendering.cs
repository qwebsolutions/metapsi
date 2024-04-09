using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Optional rendering
/// </summary>
public class OptionalRendering : TutorialSample<OptionalRendering.Model>
{
    public class Model
    {
        public bool ApiCallInProgress { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlDiv(
            b.Optional(
                b.Get(model, x => x.ApiCallInProgress),
                b => b.SlSpinner()));
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            ApiCallInProgress = true
        };
    }
}
