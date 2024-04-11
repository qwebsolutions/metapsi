﻿using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Sets initial value
/// </summary>
public class UpdateModelActionWithSetValue : TutorialSample<UpdateModelActionWithSetValue.Model>
{
    public class Model
    {
        public string Text { get; set; }
    }

    public static Var<IVNode> Render(LayoutBuilder b, Var<Model> model)
    {
        return
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row items-center gap-8 p-2");
                },
                b.HtmlInput(
                    b =>
                    {
                        b.SetValue(b.Get(model, x => x.Text));
                        b.SetClass("rounded p-2 border border-gray-200");
                        b.SetPlaceholder("Here you can write some text");
                        b.OnInputAction((SyntaxBuilder b, Var<Model> model, Var<string> inputValue) =>
                        {
                            b.Set(model, x => x.Text, inputValue);
                            return b.Clone(model);
                        });
                    }),
                b.HtmlSpanText(
                    b.Concat(
                        b.Const("You wrote:"),
                        b.AsString(b.Get(model, x => x.Text))))); ;
    }

    public override Model GetSampleData()
    {
        return new Model() { Text = string.Empty };
    }
}