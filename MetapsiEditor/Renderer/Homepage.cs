using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Linq;

public static partial class Render
{
    public class Homepage : HyperPage<Handler.Home.Model>
    {
        public override IHtmlNode GetHtml(Handler.Home.Model dataModel)
        {
            var html = base.GetHtml(dataModel);

            var bodyNode = (html as HtmlTag).Children.Single(x => (x is HtmlTag) && (x as HtmlTag).Tag == "body");

            if (bodyNode == null)
            {
                throw new ArgumentException("No body present!");
            }

            //var body = bodyNode as HtmlTag;

            //var eachSecondScript = new HtmlTag("script");

            //eachSecondScript.Children.Add(new HtmlText()
            //{
            //    Text = "setInterval(function () {dispatchEvent(new CustomEvent('metapsi.second.tick')}, 1000);"
            //});

            //body.Children.Add(eachSecondScript);

            return html;
        }

        public override Var<HyperNode> OnRender(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            b.AddStylesheet("metapsi.live.css");

            b.AddSubscription(
                "metapsi_each_second",
                (BlockBuilder b, Var<Handler.Home.Model> model) =>
                {
                    return b.Every<Handler.Home.Model>(
                        b.Const(1000),
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            return b.Switch<HyperType.StateWithEffects, Handler.View>(
                                b.Get(model, x => x.CurrentView),
                                b => b.MakeStateWithEffects(model),
                                (Handler.View.WaitingCompile, b => PoolCompile(b, model)));
                        }));
                });

            return b.Switch(
                b.Get(model, x => x.CurrentView),
                b => ListSolutions(b, model),
                (Handler.View.WaitingCompile, b => WaitCompile(b, model)),
                (Handler.View.ListRenderers, b => ListRenderers(b, model)),
                (Handler.View.FocusRenderer, b => FocusRenderer(b, model)));
        }

        public static Var<HyperType.StateWithEffects> PoolCompile(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.AsyncResult(
                model,
                b.Request<Handler.Home.Model, Frontend.RenderersResponse, bool>(
                    Frontend.GetRenderers,
                    b.Const(true),
                    b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<Frontend.RenderersResponse> result) =>
                    {
                        return b.If(
                            b.Get(result, x => x.IsLoading),
                            b => model,
                            b =>
                            {
                                b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRenderers));
                                b.Set(model, x => x.Renderers, b.Get(result, x => x.Renderers));
                                return b.Clone(model);
                            });
                    })));
        }

        public Var<HyperNode> ListSolutions(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col",
                b.Map(
                    b.Get(model, x => x.Solutions),
                    SelectSolutionButton));
        }

        public Var<HyperNode> SelectSolutionButton(BlockBuilder b, Var<Metapsi.Live.Db.Solution> sln)
        {
            var button = b.Node("button", "", b => b.Text(b.Get(sln, x => x.Path)));

            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                b.Set(model, x => x.CurrentView, b.Const(Handler.View.WaitingCompile));
                b.Set(model, x => x.SelectedSolutionId, b.Get(sln, x => x.Id));

                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SelectSolution,
                        b.Get(sln, x => x.Id),
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<ApiResponse> result) =>
                        {
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> ListRenderers(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col",
                b.Map(
                    b.Get(model, x => x.Renderers), 
                    SelectRendererButton));
        }

        public Var<HyperNode> SelectRendererButton(BlockBuilder b, Var<string> renderer)
        {
            var button = b.Node("button", "", b => b.Text(renderer));

            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SelectRenderer,
                        renderer,
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<Backend.RendererResponse> result) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.FocusRenderer));
                            b.Set(model, x => x.SelectedRenderer, renderer);
                            b.Set(model, x => x.Inputs, b.Get(result, x => x.Inputs));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> WaitCompile(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));

            return b.Text(b.Concat(b.Const("Compiling "), b.Get(selectedSolution, x => x.Path)));
        }

        public Var<HyperNode> FocusRenderer(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col",
                b => b.Text(b.Get(model, x => x.SelectedRenderer)),
                b => b.Div(
                    "flex flex-col",
                    b.Map(
                        b.Get(model, x => x.Inputs),
                        (b, input) =>
                        SelectInputButton(
                            b,
                            input,
                            b.Get(
                                model,
                                b.Get(input, x => x.Id),
                                (model, currentInputId) => model.SelectedInputId == currentInputId)))));
        }

        public Var<HyperNode> SelectInputButton(BlockBuilder b, Var<Metapsi.Live.Db.Input> input, Var<bool> isSelected)
        {
            var inputName = b.Get(input, x => x.InputName);
            var inputId = b.Get(input, x => x.Id);

            var button = b.Node("button", "", b => b.Text(inputName));

            b.If(isSelected, b => b.AddClass(button, "text-red-500"));

            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SetInputId,
                        inputId,
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<ApiResponse> result) =>
                        {
                            b.Set(model, x => x.SelectedInputId, b.Get(input, x => x.Id));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }
    }

    //public class Homepage : HtmlPage<Handler.Home.Model>
    //{
    //    public override IHtmlNode GetHtml(Handler.Home.Model dataModel)
    //    {
    //        var html = new HtmlTag("html");
    //        var body = html.AddChild(new HtmlTag("body"));

    //        foreach (var solution in dataModel.Solutions)
    //        {
    //            var link = body.AddChild(new HtmlTag("a").AddAttribute("href", Metapsi.Route.Path<Metapsi.Live.Route.Sln, Guid>(solution.Id)));
    //            link.AddChild(new HtmlText(solution.Path));
    //        }

    //        return html;
    //    }
    //}
}