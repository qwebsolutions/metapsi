using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Switch expression
/// </summary>
public class SwitchExpression : TutorialSample<SwitchExpression.Model>
{
    public class Model
    {
        public List<string> LoggedUsers { get; set; }
    }

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var loggedUsersCount = b.Get(model, x => x.LoggedUsers.Count());

        var loggedUsersMessage = 
            b.Switch(
                loggedUsersCount,
                b => b.Concat(
                    b.Const("There are "),
                    b.AsString(loggedUsersCount),
                    b.Const(" logged users")),
                (0, b => b.Const("There are no logged users")),
                (1, b => b.Const("There is one logged user")));

        return b.Text(loggedUsersMessage);
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<string> { "Ringo" }
        };
    }
}