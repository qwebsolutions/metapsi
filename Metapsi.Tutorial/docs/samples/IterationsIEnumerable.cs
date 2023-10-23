using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Iterating on a LINQ expression result
/// </summary>
public class IterationsIEnumerable : TutorialSample<IterationsIEnumerable.Model>
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

    public static Var<HyperNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var container = b.Div("flex flex-col");

        // This will result in a compile error
        //var loggedUsers =
        //    b.Get(
        //        model,
        //        x => x.AllUsers.Where(x => x.IsLoggedIn));

        // While this will work
        var loggedUsers = 
            b.Get(
                model, 
                x => x.AllUsers.Where(x => x.IsLoggedIn).ToList());

        b.Foreach(loggedUsers,
            (b, user) =>
            {
                var userName = b.Get(user, x => x.Name);
                b.Add(
                    container,
                    b.Text(userName));
            });

        return container;
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