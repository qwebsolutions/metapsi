using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// List iteration
/// </summary>
public class IterationsSimple : TutorialSample<IterationsSimple.Model>
{
    public class Model
    {
        public List<string> LoggedUsers { get; set; }
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var container = b.Div("flex flex-col");
        b.Foreach(
            b.Get(model, x => x.LoggedUsers),
            (b, user, index) =>
            {
                b.Add(
                    container,
                    b.Text(
                        b.Concat(
                            b.AsString(index),
                            b.Const(". "),
                            user)));
            });

        return container;

    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<string> { "Mary", "Patricia", "Michael", "David", "Linda", "Elizabeth" }
        };
    }
}