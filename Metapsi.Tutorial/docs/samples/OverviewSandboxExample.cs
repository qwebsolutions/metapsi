using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Code sample
/// </summary>
public class OverviewSandboxExample : TutorialSample<OverviewSandboxExample.Model>
{
    public class Model
    {
        public string ModelProperty1 { get; set; }
        public string ModelProperty2 { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.T(b.Serialize(model));
    }

    public override Model GetSampleData()
    {
        return new Model() { ModelProperty1 = "Value 1", ModelProperty2 = "Value 2" };
    }
}