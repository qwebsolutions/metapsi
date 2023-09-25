using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// If statement
/// </summary>
public class IfStatement : TutorialSample<IfStatement.Model>
{
    public class Model
    {
        public string Greeting { get; set; } = "";
        public int SomeOther { get; set; }
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var container = b.Div();

        var greeting = b.Get(model, x => x.Greeting);
        b.If(
            b.HasValue(greeting),
            b => b.Add(container, b.Text(greeting)));

        return container;
    }

    public override Model GetSampleData()
    {
        return new Model() { Greeting = "Has value" };
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