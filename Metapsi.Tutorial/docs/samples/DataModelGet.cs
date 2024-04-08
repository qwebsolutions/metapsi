using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Access model properties
/// </summary>
public class DataModelGet : TutorialSample<DataModelGet.Model>
{
    public class Model
    {
        public string Name { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var name = b.Get(model, x => x.Name);
        return b.Text(name);
    }

    public override Model GetSampleData()
    {
        return new Model() { Name = "John" };
    }
}