using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Text binding on model
/// </summary>
public class BindingOnEntity : TutorialSample<BindingOnEntity.Model>
{
    public class Model
    {
        public class User
        {
            public string UserName { get; set; }
            public string DisplayName { get; set; }
            public string HomeAddress { get; set; }
        }

        public List<User> Users { get; set; } = new();
        public string InEditUserName { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        var getInEditUser = (SyntaxBuilder b, Var<Model> model) => b.Get(model, model => model.Users.SingleOrDefault(x => x.UserName == model.InEditUserName));

        var user = getInEditUser(b, model);

        return
            b.If(
                b.HasObject(user),
                b =>
                b.HtmlDiv(
                    b =>
                    {
                        b.SetClass("grid grid-cols-2 place-items-baseline p-4");
                    },
                    b.HtmlSpanText(b => b.SetClass("text-sm text-gray-600 h-8"), "User name"),
                    b.HtmlSpanText(b.Get(user, x => x.UserName)),
                    b.HtmlSpanText(b => b.SetClass("text-sm text-gray-600 h-8"), "Display name"),
                    b.HtmlInput(
                        b =>
                        {
                            b.SetClass("rounded p-2 border border-gray-200");
                            b.BindTo(model, getInEditUser, x => x.DisplayName);
                        }),
                    b.HtmlSpanText(b => b.SetClass("text-sm text-gray-600 h-8"), "Home Address"),
                    b.HtmlInput(
                        b =>
                        {
                            b.SetClass("rounded p-2 border border-gray-200");
                            b.BindTo(model, getInEditUser, x => x.HomeAddress);
                        })),
                b => 
                b.HtmlSpanText(b => b.SetClass("text-red-500 font-semibol"), "User not found!"));
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            InEditUserName = "yogi",
            Users = new List<Model.User>()
            {
                new Model.User()
                {
                    UserName = "yogi",
                    DisplayName = "Yogi Bear",
                    HomeAddress = "Jellystone Park"
                },
                new Model.User()
                {
                    UserName = "pooh",
                    DisplayName = "Winnie-the-Pooh",
                    HomeAddress = "100 Aker Wood"
                }
            }
        };
    }
}
