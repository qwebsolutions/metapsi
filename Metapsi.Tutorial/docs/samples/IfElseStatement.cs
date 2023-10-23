using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// If statement with else branch
/// </summary>
public class IfElseStatement : TutorialSample<IfElseStatement.Model>
{
    public class Model
    {
        public List<string> LoggedUsers { get; set; }
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var container = b.Span();

        var anyLoggedUser = b.Get(model, x => x.LoggedUsers.Any());
        var loggedUsersCount = b.Get(model, x => x.LoggedUsers.Count());

        b.If(
            anyLoggedUser,
            b =>
            {
                b.Add(container,
                    b.Text(
                        b.Concat(
                            b.Const("There are "),
                            b.AsString(loggedUsersCount),
                            b.Const(" logged users"))));
            },
            b=>
            {
                b.Add(container, b.Text("There are no logged users"));
            });

        return container;
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<string> { }
        };
    }
}