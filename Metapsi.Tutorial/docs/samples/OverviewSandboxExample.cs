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

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        return b.Text(b.Serialize(model));
    }

    public override Model GetSampleData()
    {
        return new Model() { ModelProperty1 = "Value 1", ModelProperty2 = "Value 2" };
    }
}

/*
 * public class CodeSample
{
    public string SampleId { get; set; } = string.Empty;
    public string SampleLabel { get; set; } = string.Empty;
    public string CSharpModel { get; set; } = " "; // because model is not always mandatory & code sample span collapses if there is no text
    public string CSharpCode { get; set; } = string.Empty; // because code is always mandatory & compile button is disabled if there's none
    public string JsonModel { get; set; } = "{}";
}*/