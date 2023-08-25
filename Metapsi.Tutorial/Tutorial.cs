﻿using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public static class CodeSampleId
{
    public const string _001_HelloWorld = "HelloWorld";
    public const string _002_HelloWorldColor = "HelloWorldColor";
    public const string _003_HelloWorldNestedArrow = "HelloWorldNestedArrow";
    public const string _004_HelloWorldNestedAdd = "HelloWorldNestedAdd";
    public const string _005_HelloWorldProperty = "HelloWorldProperty";
    public const string _006_HelloWorldIfValue = "HelloWorldIf";
    public const string _007_HelloWorldIfElse = "HelloWorldIfElse";
    public const string _008_HelloWorldIfExpression = "HelloWorldIfEExpression";
}

public class TutorialModel : IApiSupportState, IHasTreeMenu
{
    public List<Route> Routes { get; set; } = new();
    public List<Doc> Docs { get; set; } = new();

    public Doc Doc { get; set; }
    public List<DocSlice> Slices { get; set; } = new();
    public List<CodeSample> Samples { get; set; } = new();

    public CodeSample LiveSample { get; set; } = new();

    public ApiSupport ApiSupport { get; set; } = new();

    public string ResultHtml { get; set; } = "<!DOCTYPE html> Run the example to see the result here";

    public bool MenuIsExpanded { get; set; } = false;
}

public class TutorialRenderer : ShoelaceHyperPage<TutorialModel>
{
    public override IHtmlNode ModifyHtml(IHtmlNode root, Syntax.Module module)
    {
        root = base.ModifyHtml(root, module);

        var body = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "body");

        var prismScript = new HtmlTag("script");
        prismScript.AddAttribute("src", "/prism.js");
        body.AddChild(prismScript);

        return root;
    }

    public override Var<HyperNode> OnRender(BlockBuilder b, Var<TutorialModel> model)
    {
        b.AddModuleStylesheet();
        b.AddStylesheet("prism.css");

        var container = b.Div(
            "pt-16 text-gray-700",
            b => b.Div("w-2/3 overflow-auto p-8", b => DocsPage(b, model)),
            b => b.AddClass(Sandbox(b, model), "bg-white fixed right-0 top-0 bottom-0 w-1/3 overflow-auto pt-24 px-8"));

        var breadcrumbs = b.Breadcrumb();
        b.Add(breadcrumbs, b.BreadcrumbButtonItem(b.Const("Tutorial")));
        b.Add(breadcrumbs, b.BreadcrumbButtonItemLast(b.Get(model, x => x.Doc.Title)));

        b.Add(container, b.Header(model, b => breadcrumbs));

        //b.Add(
        //    container, 
        //    b.Div(
        //        "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl", 
        //        b=>
        //        {
        //            var showMenuButton = b.IconButton("list");
        //            b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
        //            {
        //                b.Set(model, x => x.MenuIsExpanded, true);
        //                return b.Clone(model);
        //            }));

        //            return showMenuButton;
        //        },
        //        b => breadcrumbs));

        b.Add(container, b.DrawerTreeMenu(model));

        //b.If(
        //    b.Get(model, x => x.MenuIsExpanded),
        //    b => b.Add(container, b.Drawer(menuDrawerProps)));

        return container;
    }

    public static Var<HyperNode> DocsPage(BlockBuilder b, Var<TutorialModel> model)
    {
        var container = b.Div("flex flex-col gap-4");

        b.Foreach(
            b.Get(model, x => x.Slices.OrderBy(x => x.OrderIndex).ToList()),
            (b, slice) =>
            {
                var sliceType = b.Get(slice, x => x.SliceType);
                var sliceNode = b.Switch(
                    sliceType,
                    b => b.VoidNode(),
                    (nameof(Paragraph), b => b.Include(b.Url<Metapsi.Tutorial.Routes.Paragraph, string>(b.Get(slice, x => x.SliceCode)))),
                    (nameof(CodeSample), b => Sample(b, GetSample(b, model, b.Get(slice, x => x.SliceCode))))
                    );

                b.Add(container, sliceNode);
            });

        return container;

        //return b.Div(
        //    "flex flex-col gap-4",
        //    b => b.Text("Docs here"),
        //    b => b.Text("Code samples can be sent to the side panel for edit & run"),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._001_HelloWorld))),
        //    b => b.Text("So we just move along step by step"),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._002_HelloWorldColor))),
        //    b => b.Text("Nested controls"),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._003_HelloWorldNestedArrow))),
        //    b => b.Text("And if more complex ..."),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._004_HelloWorldNestedAdd))),
        //    b => b.Text("Adding properties ..."),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._005_HelloWorldProperty))),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._006_HelloWorldIfValue))),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._007_HelloWorldIfElse))),
        //    b => Sample(b, GetSample(b, model, b.Const(CodeSampleId._008_HelloWorldIfExpression)))
        //    );
    }



    public static Var<CodeSample> GetSample(BlockBuilder b, Var<TutorialModel> model, Var<string> sampleId)
    {
        return b.Get(model, sampleId, (model, sampleId) => model.Samples.Single(x => x.SampleId == sampleId));
    }

    public static  Var<HyperNode> Sample(BlockBuilder b, Var<CodeSample> sample)
    {
        var container = b.Div("flex flex-col border rounded");

        var tabGroupProps = b.NewObj<TabGroup>();
        //b.Set(tabGroupProps, x => x.Placement, TabPlacement.Bottom);

        var tabGroup = b.Add(container, b.TabGroup(tabGroupProps));
        b.AddClass(tabGroup, "bg-white");

        b.TabPage(
            tabGroup,
            b.Const("CSharpModel"),
            b.Const("Model"),
            b.Node(
                "pre",
                "",
                b => b.Node(
                    "code",
                    "language-csharp",
                    b => b.TextNode(b.Get(sample, x => x.CSharpModel)))));
        b.TabPage(
            tabGroup,
            b.Const("JsonData"),
            b.Const("JSON data"),
            b.Node(
                "pre",
                "",
                b => b.Node(
                    "code",
                    "language-json",
                    b => b.TextNode(b.Get(sample, x => x.JsonModel)))));

        b.TabPage(
            tabGroup,
            b.Const("CSharpView"),
            b.TextNode("View"),
            b.Node(
                "pre",
                "",
                b => b.Node(
                    "code",
                    "language-csharp",
                    b => b.TextNode(b.Get(sample, x => x.CSharpCode)))),
            b.Const(true));

        var footerToolbar = b.Add(container, b.Div("flex flex-row items-center justify-between p-4 bg-gray-100 text-lg"));

        b.Add(footerToolbar, b.Text(b.Get(sample, x => x.SampleLabel), "text-xs"));
        
        var sendToCompilePanelButton = b.Add(
            footerToolbar, 
            b.Tooltip(
                b.Const("Send to live panel"), 
                b=>  b.IconButton("arrow-right-square")));
        b.SetOnClick(sendToCompilePanelButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
        {
            b.Set(model, x => x.LiveSample, b.Clone(sample));
            b.Set(model, x => x.ResultHtml, b.Const("<!DOCTYPE html> Run sample to see output here"));
            return b.Clone(model);
        }));

        return container;
    }

    public static Var<HyperNode> Sandbox(BlockBuilder b, Var<TutorialModel> clientModel)
    {
        var liveSample = b.Get(clientModel, x => x.LiveSample);

        var container = b.Div("flex flex-col gap-2");

        var cSharpModelDefinition = b.NewObj<Textarea>();
        b.Set(cSharpModelDefinition, x => x.Value, b.Get(liveSample, x => x.CSharpModel));
        b.Set(cSharpModelDefinition, x => x.Label, b.Const("C# model"));
        b.Set(cSharpModelDefinition, x => x.HelpText, b.Const("A POCO class declaration"));
        var cSharpModelDefinitionControl = b.Add(container, b.Textarea(cSharpModelDefinition));
        b.SetOnSlChange(cSharpModelDefinitionControl, b.MakeAction<TutorialModel, string>((b, model, v) =>
        {
            var liveSample = b.Get(model, x => x.LiveSample);
            b.Set(liveSample, x => x.CSharpModel, v);
            return b.Clone(model);
        }));

        var jsonModelData = b.NewObj<Textarea>();
        //b.Set(jsonModelData, x => x.Rows, b.Const(10));
        b.Set(jsonModelData, x => x.Label, "JSON model data");
        b.Set(jsonModelData, x => x.HelpText, b.Const("Matching the class declaration above"));
        b.Set(jsonModelData, x => x.Value, b.Get(liveSample, x => x.JsonModel));

        var jsonModelControl = b.Add(container, b.Textarea(jsonModelData));

        b.SetOnSlChange(jsonModelControl, b.MakeAction<TutorialModel, string>((b, model, v) =>
        {
            var liveSample = b.Get(model, x => x.LiveSample);
            b.Set(liveSample, x => x.JsonModel, v);
            return b.Clone(model);
        }));

        var codeArea = b.NewObj<Textarea>();
        b.Set(codeArea, x => x.Label, "C# page builder");
        b.Set(codeArea, x => x.HelpText, "Server-side builder for client-side JavaScript");
        b.Set(codeArea, x => x.Value, b.Get(liveSample, x => x.CSharpCode));
        var codeControl = b.Add(container, b.Textarea(codeArea));
        
        b.SetOnSlChange(codeControl, b.MakeAction<TutorialModel, string>((b, model, v) =>
        {
            var liveSample = b.Get(model, x => x.LiveSample);
            b.Set(liveSample, x => x.CSharpCode, v);
            return b.Clone(model);
        }));

        //var compile = b.Add(container, b.Node("button", "rounded p-4 bg-blue-500 text-white", b => b.TextNode("Run!")));

        var compileButtonProps = b.NewObj<Button>();
        b.Set(compileButtonProps, x => x.Text, "Run!");
        b.Set(compileButtonProps, x => x.Variant, ButtonVariant.Primary);
        b.Set(compileButtonProps, x => x.Loading, b.Get(clientModel, x => x.ApiSupport.InProgress));

        var compile = b.Add(container, b.Button(compileButtonProps));


        b.SetOnClick(compile, b.MakeServerAction(clientModel, Compile));

        var iframe = b.Add(container, b.Node("iframe", "w-full h-96 rounded border border-blue-500"));
        b.SetAttr(iframe, Html.id, "output-frame");

        SetOutputHtml(b, b.Get(clientModel, x => x.ResultHtml));


        return container;
    }

    public static void SetOutputHtml(BlockBuilder b, Var<string> content)
    {
        var domFrame = b.GetElementById(b.Const("output-frame"));
        b.If(
            b.HasObject(domFrame),
            b =>
            {
                b.CallExternal("Metapsi.Tutorial", "SetIframeContent", domFrame, content);
            },
            b =>
            {
                b.Log("iframe not found!");
            });
    }

    public override Var<HyperType.StateWithEffects> OnInit(BlockBuilder b, Var<TutorialModel> model)
    {
        //b.Set(model, x => x.LiveSample, b.Clone(b.Get(model, x => x.Samples.First())));

        return b.MakeStateWithEffects(b.Clone(model), b.MakeEffect(b.MakeEffecter<TutorialModel>((b, disp) =>
        {
            b.RequestAnimationFrame(
                b.DefineAction(b =>
                {
                    var domFrame = b.GetElementById(b.Const("output-frame"));
                    b.If(
                        b.HasObject(domFrame),
                        b =>
                        {
                            b.CallExternal("Metapsi.Tutorial", "SetIframeContent", domFrame, b.Get(model, x => x.ResultHtml));
                        },
                        b =>
                        {
                            b.Log("iframe not found!");
                        });

                    b.CallExternal("Metapsi.Tutorial", "HighlightWhenDefined");

                }));
        })));
    }

    public static async Task<TutorialModel> Compile(CommandContext commandContext, TutorialModel model)
    {
        var workspace = MSBuildWorkspace.Create();
        var sln = await workspace.OpenSolutionAsync("D:\\qwebsolutions\\metapsi\\Metapsi.Tutorial.Template\\Metapsi.Tutorial.Template.sln");

        //var project = workspace.CurrentSolution.AddProject("temp", "temp", "C#");
        //var textDocument = project.AddDocument("Program.cs", "namespace Whatever { public static class Program {public static async Task Main() {Console.WriteLine(\"abc\");}}}");
        var csDoc = sln.Projects.First().Documents.Single(x => x.Name == "Renderer.cs");
        var project = sln.Projects.First().RemoveDocument(csDoc.Id);
        var initialText = await csDoc.GetTextAsync();
        var code = initialText.ToString();
        code = code.Replace("public class Model { }", $"public class Model {{ {model.LiveSample.CSharpModel} }}");
        code = code.Replace("return null;", model.LiveSample.CSharpCode);
        csDoc = project.AddDocument(csDoc.Name, code);

        var semanticModel = await csDoc.GetSemanticModelAsync();
        var syntaxTree = await csDoc.GetSyntaxTreeAsync();
        var syntaxRoot = await csDoc.GetSyntaxRootAsync();

        var allMemberAccessExpressions = syntaxRoot.DescendantNodes().OfType<MemberAccessExpressionSyntax>();

        foreach (var memberAccess in allMemberAccessExpressions)
        {
            var accessSymbol = semanticModel.GetSymbolInfo(memberAccess);
            if (!IsMetapsiSymbol(accessSymbol))
            {
                var errorHtml = new ErrorPage().Render(new List<string>()
                {
                    "This sandbox can only be used for building Metapsi views"
                });
                model.ResultHtml = errorHtml;
                return model;
            }
        }

        var compilation = await csDoc.Project.GetCompilationAsync();

        var binaries = compilation.EmitToArray();

        if (!binaries.Errors.Any())
        {

            AssemblyLoadContext assemblyLoadContext = new AssemblyLoadContext("temp");
            var assembly = assemblyLoadContext.LoadFromArray(binaries.Assembly);
            var rendererType = assembly.GetTypes().First(x => x.Name == "Renderer");
            var getHtml = rendererType.GetMethods().First(x => x.Name == "Render");
            var deserializeModel = rendererType.GetMethods().First(x => x.Name == "DeserializeModel");

            var rendererObject = Activator.CreateInstance(rendererType);
            var modelObject = deserializeModel.Invoke(rendererObject, new object[] { model.LiveSample.JsonModel });

            var html = (string)getHtml.Invoke(rendererObject, new object[] { modelObject });
            model.ResultHtml = html;
        }
        else
        {
            var errorHtml = new ErrorPage().Render(binaries.Errors.Select(x => x.ToString()).ToList());
            model.ResultHtml = errorHtml;
        }
        return model;
    }

    public static bool IsDeserialize(SymbolInfo symbolInfo)
    {
        return symbolInfo.Symbol.ToString().Contains("Metapsi.Serialize");
    }

    public static bool IsMetapsiSymbol(SymbolInfo symbolInfo)
    {
        HashSet<string> whitelistedNamespaces = new HashSet<string>();
        whitelistedNamespaces.Add("Metapsi.Hyperapp");
        whitelistedNamespaces.Add("Metapsi.Syntax");
        whitelistedNamespaces.Add("Metapsi.Tutorial.Template");

        // Is syntax error, could be valid, move on
        if (symbolInfo.Symbol == null)
            return true;

        if (IsDeserialize(symbolInfo))
            return true;

        return whitelistedNamespaces.Contains(symbolInfo.Symbol.ContainingNamespace.ToString());
    }
}

public class ErrorPage : HtmlPage<List<string>>
{
    public override IHtmlNode GetHtml(List<string> dataModel)
    {
        return Template.BlankPage(head =>
        {
            var script = head.AddChild(new HtmlTag("link"));
            script.AddAttribute("rel", "stylesheet");
            script.AddAttribute("href", "/metapsi.tutorial.css");
        },
        body =>
        {
            foreach (var error in dataModel)
            {
                var errorDiv = body.AddChild(new HtmlTag("div"));
                errorDiv.AddAttribute("class", "text-red-500");
                errorDiv.AddChild(new HtmlText(error));
            }
        });
    }
}

public class EmitResult
{
    public byte[] Assembly { get; set; }
    public List<Diagnostic> Errors { get; set; } = new();
}

public static class EmitExtensions
{
    

    public static EmitResult EmitToArray(this Compilation compilation)
    {
        var stream = new MemoryStream();
        // emit result into a stream
        var emitResult = compilation.Emit(stream);

        if (!emitResult.Success)
        {
            return new EmitResult()
            {
                Errors = emitResult.Diagnostics.Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error).ToList()
            };
        }
        else
        {
            stream.Seek(0, SeekOrigin.Begin);
            // get the byte array from a stream
            return new EmitResult() { Assembly = stream.ToArray() };
        }
    }

    public static Assembly LoadFromArray(this AssemblyLoadContext assemblyLoadContext, byte[] binaries)
    {
        var ms = new MemoryStream();
        ms.Write(binaries);
        ms.Seek(0, SeekOrigin.Begin);
        return assemblyLoadContext.LoadFromStream(ms);
    }
}