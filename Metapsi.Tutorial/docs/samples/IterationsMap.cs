using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Map a collection
/// </summary>
public class IterationsMap : TutorialSample<IterationsMap.Model>
{
    public class Model
    {
        public class User
        {
            public string Name { get; set; }
            public bool IsLoggedIn { get; set; }
        }
        public List<User> AllUsers { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var status = b.Map(
            b.Get(model, x => x.AllUsers),
            (b, user) =>
            {
                return b.If(
                    b.Get(user, x => x.IsLoggedIn),
                    b => b.Concat(b.Get(user, x => x.Name), b.Const(" is logged in")),
                    b => b.Concat(b.Get(user, x => x.Name), b.Const(" is not logged in")));
            });

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col");
            },
            b.Map(status, (b, status) => b.HtmlSpanText(status)));
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            AllUsers = new List<Model.User>()
            {
                new Model.User()
                {
                    Name = "Denzel",
                    IsLoggedIn = true,
                },
                new Model.User()
                {
                    Name = "Orson",
                    IsLoggedIn = false,
                },
                new Model.User()
                {
                    Name = "Sybil",
                    IsLoggedIn = true,
                },
                new Model.User()
                {
                    Name = "Ulysses",
                    IsLoggedIn = true,
                },
                new Model.User()
                {
                    Name = "Phineas",
                    IsLoggedIn = false,
                },
                new Model.User()
                {
                    Name = "Neva",
                    IsLoggedIn = true
                }
            }
        };
    }
}