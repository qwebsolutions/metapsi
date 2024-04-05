using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// A grid of users
/// </summary>
public class WrapUpTable : TutorialSample<WrapUpTable.Model>
{
    public class Model
    {
        public class User
        {
            public string Name { get; set; }
            public bool IsLoggedIn { get; set; }
            public DateTime LastLogIn { get; set; }
        }
        public List<User> AllUsers { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var headerCss = "py-3 px-2 font-medium text-left bg-blue-400 text-white ";
        var baseRowCss = b.Const("py-3 px-2 font-light text-left text-gray-700 ");

        var gridNodes = b.NewCollection<IVNode>();
        b.Push(gridNodes,
            b.HtmlDiv(
                b =>
                {
                    b.SetClass(headerCss);
                },
                b.T("User")));
        b.Push(gridNodes,
            b.HtmlDiv(
                b =>
                {
                    b.SetClass(headerCss);
                },
                b.T("Is logged in")));

        b.Push(gridNodes,
            b.HtmlDiv(
                b =>
                {
                    b.SetClass(headerCss + " col-span-2 ");
                },
                b.T("Last log in")));

        b.Foreach(
            b.Get(
                model,
                x => x.AllUsers.OrderByDescending(x => x.LastLogIn).ToList()),
            (b, user, index) =>
            {
                var rowCss = b.If(
                    b.Get(index, x => x % 2 == 0),
                    b => baseRowCss,
                    b => b.Concat(
                        baseRowCss,
                        b.Const(" bg-gray-100 ")));

                b.Push(gridNodes,
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass(rowCss);
                        },
                        b.T(b.Get(user, x => x.Name))));

                b.Push(gridNodes,
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass(rowCss);
                        },
                        b.Optional(
                            b.Get(user, x => x.IsLoggedIn),
                            b => b.HtmlSpan(
                                b =>
                                {
                                    b.SetClass("text-green-500");
                                },
                                b.T("✓")))));

                b.Push(gridNodes,
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass(b.Concat(rowCss, b.Const(" col-span-2 ")));
                        },
                        b.T(
                            b.FormatDatetime(b.Get(user, x => x.LastLogIn)))));
            });

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("grid grid-cols-4 w-full p-4 rounded ");
            },
            gridNodes);
    }

    public override Model GetSampleData()
    {
        List<string> userNames = new()
        {
            "Denzel",
            "Orson",
            "Sybil",
            "Ulysses",
            "Phineas",
            "Neva"
        };

        var model = new Model() { AllUsers = new() };

        var random = new Random();

        foreach (var userName in userNames)
        {
            model.AllUsers.Add(new Model.User()
            {
                Name = userName,
                LastLogIn = DateTime.Now.AddMinutes(new Random().Next(60 * 24) * -1)
            });
        }

        // Make sure that some users are logged in, but not all of them
        for (int i = 0; i < userNames.Count - 2; i++)
        {
            model.AllUsers[random.Next(userNames.Count)].IsLoggedIn = true;
        }

        return model;
    }
}