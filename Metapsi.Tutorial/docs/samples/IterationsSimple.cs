using Metapsi.Html;
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

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var textNodes = b.NewCollection<IVNode>();

        b.Foreach(
            b.Get(model, x => x.LoggedUsers),
            (b, user, index) =>
            {
                b.Push(
                    textNodes,
                    b.T(
                        b.Concat(
                            b.AsString(index),
                            b.Const(". "),
                            user)));
            });

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col");
            },
            textNodes);
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<string> { "Mary", "Patricia", "Michael", "David", "Linda", "Elizabeth" }
        };
    }
}