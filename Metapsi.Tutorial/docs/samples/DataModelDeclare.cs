using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Declare data model
/// </summary>
public class DataModelDeclare : TutorialSample<DataModelDeclare.Model>
{
    public class Model
    {
        public string Name { get; set; }
    }

    public Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.Text(b.Serialize(model));
    }

    public override Model GetSampleData()
    {
        return new Model() { Name = "John" };
    }
}