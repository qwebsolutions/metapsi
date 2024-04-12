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
        const string AddIcon = "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 16 16\" fill=\"currentColor\" class=\"w-4 h-4\">\r\n  <path d=\"M8.75 3.75a.75.75 0 0 0-1.5 0v3.5h-3.5a.75.75 0 0 0 0 1.5h3.5v3.5a.75.75 0 0 0 1.5 0v-3.5h3.5a.75.75 0 0 0 0-1.5h-3.5v-3.5Z\" />\r\n</svg>\r\n";
        const string RemoveIcon= "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 16 16\" fill=\"currentColor\" class=\"w-4 h-4\">\r\n  <path d=\"M5.28 4.22a.75.75 0 0 0-1.06 1.06L6.94 8l-2.72 2.72a.75.75 0 1 0 1.06 1.06L8 9.06l2.72 2.72a.75.75 0 1 0 1.06-1.06L9.06 8l2.72-2.72a.75.75 0 0 0-1.06-1.06L8 6.94 5.28 4.22Z\" />\r\n</svg>\r\n";

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-6 p-8");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row gap-6 items-center");
                },
                b.HtmlSpanText(
                    b=>
                    {
                        b.SetClass("font-semibold text-gray-800");
                    },
                    "My TO DO list"),
                b.HtmlButton(
                    b =>
                    {
                        b.SetClass("flex flex-row items-center justify-center rounded p-1 bg-blue-500 hover:bg-blue-600 text-white");
                        b.OnClickAction((SyntaxBuilder b, Var<Model> model) =>
                        {
                            var newToDo = b.NewObj<Model.ToDoItem>();
                            b.Set(newToDo, x => x.Id, b.NewId());
                            b.Push(b.Get(model, x => x.ToDoList), newToDo);
                            return b.Clone(model);
                        });
                        b.SetInnerHtml(AddIcon);
                    })),
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-col gap-2");
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
                                b.SetInnerHtml(RemoveIcon);
                            }));
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
