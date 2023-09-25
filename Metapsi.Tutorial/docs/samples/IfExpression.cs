using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

public interface ITutorialSample
{

}

public abstract class TutorialSample<TModel> : ITutorialSample
{
    public abstract TModel GetSampleData();
}

/// <summary>
/// If expression
/// </summary>
public class IfExpression : TutorialSample<IfExpression.Model>
{
    public class Model
    {
        public string Greeting { get; set; } = "";
        public int SomeOther { get; set; }
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var greeting = b.Get(model, x => x.Greeting);
        return b.Text(
            b.If(
                b.HasValue(greeting),
                b => greeting,
                b => b.Const("Greeting default!")));
    }

    public override Model GetSampleData()
    {
        return new Model();
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