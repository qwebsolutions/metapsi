using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// If statement
/// </summary>
public class IfStatement : TutorialSample<IfStatement.Model>
{
    public class Model
    {
        public List<string> LoggedUsers { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var anyLoggedUser = b.Get(model, x => x.LoggedUsers.Any());
        var loggedUsersCount = b.Get(model, x => x.LoggedUsers.Count());

        var nodeChildren = b.NewCollection<IVNode>();

        b.If(anyLoggedUser,
            b =>
            b.Push(
                nodeChildren,
                b.Text(
                    b.Concat(
                        b.Const("There are "),
                        b.AsString(loggedUsersCount),
                        b.Const(" logged users")))));

        return b.HtmlSpan(nodeChildren);
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<string> { "Mary", "Patricia", "Michael", "David", "Linda", "Elizabeth" }
        };
    }
}