using Metapsi.Html;
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

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var anyLoggedUser = b.Get(model, x => x.LoggedUsers.Any());
        var loggedUsersCount = b.Get(model, x => x.LoggedUsers.Count());

        return b.HtmlSpan(
            b =>
            {
            },
            b.If(
                anyLoggedUser,
                b => b.Text(
                    b.Concat(
                        b.Const("There are "),
                        b.AsString(loggedUsersCount),
                        b.Const(" logged users"))),
                b => b.Text("There are no logged users")));
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<string> { }
        };
    }
}