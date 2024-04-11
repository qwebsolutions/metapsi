using Metapsi.Dom;
using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// The customary 'To Do' app
/// </summary>
public class ToDoApp : TutorialSample<ToDoApp.Model>
{
    public class Model
    {
        public class ToDoItem
        {
            public Guid Id { get; set; }
            public bool Done { get; set; }
            public string Action { get; set; } = "";
        }

        public List<ToDoItem> ToDoList { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-6 p-4");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row gap-6 p-4 items-center");
                },
                b.HtmlSpanText(
                    b=>
                    {
                        b.SetClass("font-bold");
                    },
                    "My TO DO list"),
                b.HtmlButton(
                    b =>
                    {
                        b.SetClass("flex flex-row items-center justify-center rounded border border-gray-200 w-10 h-10");
                        b.OnClickAction((SyntaxBuilder b, Var<Model> model) =>
                        {
                            var newToDo = b.NewObj<Model.ToDoItem>();
                            b.Set(newToDo, x => x.Id, b.NewId());
                            b.Push(b.Get(model, x => x.ToDoList), newToDo);
                            return b.Clone(model);
                        });
                    },
                    b.HtmlSpanText("+"))),
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-col gap-2 p-4");
                },
                b.Map(
                    b.Get(model, x => x.ToDoList.OrderBy(x => x.Done).ToList()),
                    (b, toDo) =>
                    {
                        var id = b.Get(toDo, x => x.Id);
                        var done = b.Get(toDo, x => x.Done);

                        var getToDo = (SyntaxBuilder b, Var<Model> model) => b.Get(model, id, (model, id) => model.ToDoList.Single(x => x.Id == id));

                        return b.HtmlDiv(
                            b =>
                            {
                                b.SetClass("flex flex-row gap-2");
                            },
                            b.HtmlCheckbox(
                                b =>
                                {
                                    b.SetChecked(done);
                                    b.BindTo(model, getToDo, x => x.Done);
                                }),
                            b.If(
                                done,
                                b => b.HtmlSpanText(
                                    b=>
                                    {
                                        b.SetClass("line-through text-gray-400");
                                    },
                                    b.Get(toDo, x => x.Action)),
                                b => b.HtmlInput(
                                    b =>
                                    {
                                        b.SetClass("rounded border border-gray-200 p-2");
                                        b.BindTo(model, getToDo, x => x.Action);
                                    })),
                            b.HtmlButton(b=>
                            {
                                b.SetClass("text-red-300 hover:text-red-500");
                                b.OnClickAction((SyntaxBuilder b, Var<Model> model) =>
                                {
                                    b.Remove(b.Get(model, x => x.ToDoList), b.Call(getToDo, model));
                                    return b.Clone(model);
                                });
                            },
                            b.Text("🞫")));
                    })));
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            ToDoList = new List<Model.ToDoItem>()
            {
                new Model.ToDoItem()
                {
                    Id = Guid.NewGuid(),
                    Action = "Read the Metapsi tutorial",
                    Done = true
                },
            }
        };
    }
}
