using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Table
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

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var headerCss = "py-3 px-2 font-medium text-left bg-blue-400 text-white ";
        var baseRowCss = b.Const("py-3 px-2 font-light text-left text-gray-700 ");

        var table = b.Div(
            "grid grid-cols-4 w-full p-4 rounded ",
            b => b.Div(headerCss, b => b.Text("User")),
            b => b.Div(headerCss, b => b.Text("Is logged in")),
            b => b.Div(headerCss + " col-span-2 ", b => b.Text("Last log in")));

        b.Foreach(
            b.Get(model, x => x.AllUsers),
            (b, user, index) =>
            {
                var rowCss = b.If(
                    b.Get(index, x => x % 2 == 0),
                    b => baseRowCss,
                    b => b.Concat(baseRowCss, b.Const(" bg-gray-100 ")));

                b.Add(table, b.Div(rowCss, b => b.Text(b.Get(user, x => x.Name))));
                b.Add(table, b.Div(rowCss, b => b.Optional(b.Get(user, x => x.IsLoggedIn), b => b.Text("✓", "text-green-500"))));
                b.Add(table, b.Div(b.Concat(rowCss, b.Const(" col-span-2 ")), b => b.Text(b.FormatDatetime(b.Get(user, x => x.LastLogIn)))));
            });

        return table;
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
                    LastLogIn = DateTime.Now.AddDays(-1)
                },
                new Model.User()
                {
                    Name = "Orson",
                    IsLoggedIn = false,
                    LastLogIn = DateTime.Now.AddDays(-1)
                },
                new Model.User()
                {
                    Name = "Sybil",
                    IsLoggedIn = true,
                    LastLogIn = DateTime.Now.AddDays(-1)
                },
                new Model.User()
                {
                    Name = "Ulysses",
                    IsLoggedIn = true,
                    LastLogIn = DateTime.Now.AddDays(-1)
                },
                new Model.User()
                {
                    Name = "Phineas",
                    IsLoggedIn = false,
                    LastLogIn = DateTime.Now.AddDays(-1)
                },
                new Model.User()
                {
                    Name = "Neva",
                    IsLoggedIn = true,
                    LastLogIn = DateTime.Now.AddDays(-1)
                }
            }
        };
    }
}