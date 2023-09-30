﻿using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.CodeAnalysis;
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

public class SandboxModel : ApiSupportModel
{
    public CodeSample CodeSample { get; set; } = new();
    public string ResultHtml { get; set; } = "<p style=\"font-family:sans-serif;\">Run the code sample to see HTML output here</p>";
}

public class MinimapProps
{
    public bool enabled { get; set; }
}

public class MonacoProps
{
    // Metapsi specific
 
    public string EditorId { get; set; }
    public string Class { get; set; } = "w-full h-72 bg-white";

    // actual props

    public string value { get; set; }
    public string language { get; set; }
    public MinimapProps minimap { get; set; } = new();
}

public static partial class Control
{
    public static Var<HyperNode> MonacoEditor(this BlockBuilder b, Var<MonacoProps> props)
    {
        var containerId = b.Get(props, x => x.EditorId);

        var container = b.Div(b.Get(props, x=>x.Class));
        b.SetAttr(container, Html.id, containerId);

        b.CallExternal("Metapsi.Tutorial", "AttachMonaco", props);

        return container;

    }

    public static string TabPanelName(this System.Linq.Expressions.Expression<Func<CodeSample, string>> property)
    {
        return $"id-tab-{property.PropertyName()}";
    }

    public static string MonacoDivContainerId(System.Linq.Expressions.Expression<Func<CodeSample, string>> property)
    {
        return $"id-monaco-{property.PropertyName()}";
    }


    public static HtmlTag SandboxApp()
    {
        var sandboxContainer = Tutorial.ClientSide(new SandboxModel(), DesktopSandboxWithTabs, (BlockBuilder b, Var<SandboxModel> model) =>
        {
            b.AddSubscription<SandboxModel>(
                "ExploreSample_Sub",
                (BlockBuilder b, Var<SandboxModel> _) =>
                {
                    return b.Listen<SandboxModel, CodeSample>(
                        b.Const("ExploreSample"),
                        b.MakeAction((BlockBuilder b, Var<SandboxModel> _, Var<CodeSample> newSample) =>
                        {
                            return b.MakeAction((BlockBuilder b, Var<SandboxModel> _) =>
                            {
                                var resetModel = b.NewObj<SandboxModel>();
                                b.Set(resetModel, x => x.CodeSample, newSample);
                                //b.AddMonaco(b.Get(resetModel, x => x.CodeSample));
                                return resetModel;
                            });
                        }));
                });

            b.AddSubscription<SandboxModel>(
                "MonacoAdded_Sub",
                (BlockBuilder b, Var<SandboxModel> _) =>
                {
                    return b.Listen<SandboxModel, SandboxModel>(
                        b.Const("monaco-added"),
                        b.MakeAction((BlockBuilder b, Var<SandboxModel> model, Var<SandboxModel> _) =>
                        {
                            b.Log("monaco-added");
                            b.Log(model);
                            return b.Clone(model);
                        }));
                });

            return b.Call(OnInit, model);
        });

        return sandboxContainer;
    }
    /*
    public static Var<HyperNode> MobileSandbox(BlockBuilder b, Var<SandboxModel> clientModel)
    {
        var liveSample = b.Get(clientModel, x => x.CodeSample);

        var container = b.Div("flex flex-col gap-2 bg-gray-50 rounded p-2");

        var cSharpModelDefinition = b.NewObj<Textarea>();
        b.Set(cSharpModelDefinition, x => x.Value, b.Get(liveSample, x => x.CSharpModel));
        b.Set(cSharpModelDefinition, x => x.Label, b.Const("C# model"));
        b.Set(cSharpModelDefinition, x => x.HelpText, b.Const("A POCO class declaration"));
        var cSharpModelDefinitionControl = b.Add(container, b.Textarea(cSharpModelDefinition));
        b.SetOnSlChange(cSharpModelDefinitionControl, b.MakeAction<SandboxModel, string>((b, model, v) =>
        {
            var liveSample = b.Get(model, x => x.CodeSample);
            b.Set(liveSample, x => x.CSharpModel, v);
            return b.Clone(model);
        }));

        var jsonModelData = b.NewObj<Textarea>();
        b.Set(jsonModelData, x => x.Label, "JSON model data");
        b.Set(jsonModelData, x => x.HelpText, b.Const("Matching the class declaration above"));
        b.Set(jsonModelData, x => x.Value, b.Get(liveSample, x => x.JsonModel));

        var jsonModelControl = b.Add(container, b.Textarea(jsonModelData));

        b.SetOnSlChange(jsonModelControl, b.MakeAction<SandboxModel, string>((b, model, v) =>
        {
            var liveSample = b.Get(model, x => x.CodeSample);
            b.Set(liveSample, x => x.JsonModel, v);
            return b.Clone(model);
        }));

        var codeArea = b.NewObj<Textarea>();
        b.Set(codeArea, x => x.Label, "C# page builder");
        b.Set(codeArea, x => x.HelpText, "Server-side builder for client-side JavaScript");
        b.Set(codeArea, x => x.Value, b.Get(liveSample, x => x.CSharpCode));
        var codeControl = b.Add(container, b.Textarea(codeArea));

        b.SetOnSlChange(codeControl, b.MakeAction<SandboxModel, string>((b, model, v) =>
        {
            var liveSample = b.Get(model, x => x.CodeSample);
            b.Set(liveSample, x => x.CSharpCode, v);
            return b.Clone(model);
        }));

        var compileButtonProps = b.NewObj<Button>();
        b.Set(compileButtonProps, x => x.Text, "Run!");
        b.Set(compileButtonProps, x => x.Variant, ButtonVariant.Primary);
        b.Set(compileButtonProps, x => x.Loading, b.Get(clientModel, x => x.ApiSupport.InProgress));
        b.Set(compileButtonProps, x => x.Disabled, b.Not(b.HasValue(b.Get(liveSample, x => x.CSharpCode))));

        var compile = b.Add(container, b.Button(compileButtonProps));


        b.SetOnClick(compile, b.MakeServerAction(clientModel, Compile));

        var iframe = b.Add(container, b.Node("iframe", "w-full h-96 rounded border border-blue-500"));
        b.SetAttr(iframe, Html.id, "output-frame");

        SetOutputHtml(b, b.Get(clientModel, x => x.ResultHtml));

        return container;
    }*/

    private static Var<bool> SampleHasProperty(BlockBuilder b, Var<CodeSample> sample, System.Linq.Expressions.Expression<Func<CodeSample, string>> property)
    {
        var modelText = b.Get(sample, property);

        return b.Switch(
            modelText,
            b => b.HasValue(modelText),
            (" ", b => b.Const(false)),
            ("{}", b => b.Const(false)));
    }

    public static Var<HyperNode> DesktopSandboxWithTabs(BlockBuilder b, Var<SandboxModel> clientModel)
    {
        var liveSample = b.Get(clientModel, x => x.CodeSample);

        var container = b.Div("flex flex-col gap-2 bg-gray-50 rounded p-2");

        // MODEL

        var modelTab = b.Tab(b.NewObj<Tab>(b =>
        {
            b.Set(x => x.Panel, b.Const(Control.TabPanelName(x => x.CSharpModel)));
        }));
        b.SetAttr(modelTab, DynamicProperty.String("slot"), "nav");
        b.Add(modelTab, b.TextNode("Model"));

        var modelPanel = b.TabPanel(b.NewObj<TabPanel>(b =>
        {
            b.Set(x => x.Name, b.Const(Control.TabPanelName(x => x.CSharpModel)));
        }));

        var modelEditorProps = b.NewObj<MonacoProps>();
        b.Set(modelEditorProps, x => x.EditorId, Control.MonacoDivContainerId(x => x.CSharpModel));
        b.Set(modelEditorProps, x => x.language, "csharp");
        b.Set(modelEditorProps, x => x.value, b.Get(liveSample, x => x.CSharpModel));

        var modelEditor = b.Add(modelPanel, b.MonacoEditor(modelEditorProps));

        // JSON

        var jsonTab = b.Tab(b.NewObj<Tab>(b =>
        {
            b.Set(x => x.Panel, b.Const(Control.TabPanelName(x=>x.JsonModel)));
        }));
        b.SetAttr(jsonTab, DynamicProperty.String("slot"), "nav");
        b.Add(jsonTab, b.TextNode("JSON data"));
        
        var jsonPanel = b.TabPanel(b.NewObj<TabPanel>(b =>
        {
            b.Set(x => x.Name, b.Const(Control.TabPanelName(x => x.JsonModel)));
        }));

        var jsonEditorProps = b.NewObj<MonacoProps>();
        b.Set(jsonEditorProps, x => x.EditorId, Control.MonacoDivContainerId(x => x.JsonModel));
        b.Set(jsonEditorProps, x => x.language, "javascript");
        b.Set(jsonEditorProps, x => x.value, b.Get(liveSample, x => x.JsonModel));

        b.Add(jsonPanel, b.MonacoEditor(jsonEditorProps));

        // VIEW

        var viewTab = b.Tab(b.NewObj<Tab>(b =>
        {
            b.Set(x => x.Panel, b.Const(Control.TabPanelName(x => x.CSharpCode)));
        }));
        b.SetAttr(viewTab, DynamicProperty.String("slot"), "nav");
        b.Add(viewTab, b.TextNode("View"));

        var viewPanel = b.TabPanel(b.NewObj<TabPanel>(b =>
        {
            b.Set(x => x.Name, b.Const(Control.TabPanelName(x=>x.CSharpCode)));
        }));


        var viewEditorProps = b.NewObj<MonacoProps>();
        b.Set(viewEditorProps, x => x.EditorId, Control.MonacoDivContainerId(x => x.CSharpCode));
        b.Set(viewEditorProps, x => x.language, "csharp");
        b.Set(viewEditorProps, x => x.value, b.Get(liveSample, x => x.CSharpCode));

        b.Add(viewPanel, b.MonacoEditor(viewEditorProps));

        var tabGroup = b.Add(container, b.TabGroup());
        b.Add(tabGroup, modelTab);
        b.Add(tabGroup, jsonTab);
        b.Add(tabGroup, viewTab);
        b.Add(tabGroup, modelPanel);
        b.Add(tabGroup, jsonPanel);
        b.Add(tabGroup, viewPanel);

        var compileButtonProps = b.NewObj<Button>();
        b.Set(compileButtonProps, x => x.Text, "Run!");
        b.Set(compileButtonProps, x => x.Variant, ButtonVariant.Primary);
        b.Set(compileButtonProps, x => x.Loading, b.Get(clientModel, x => x.ApiSupport.InProgress));
        b.Set(compileButtonProps, x => x.Disabled, b.Not(b.HasValue(b.Get(liveSample, x => x.CSharpCode))));

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

    public static Var<HyperType.StateWithEffects> OnInit(BlockBuilder b, Var<SandboxModel> model)
    {
        return b.MakeStateWithEffects(b.Clone(model), b.MakeEffect(b.MakeEffecter<SandboxModel>((b, disp) =>
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

    public static async Task<SandboxModel> Compile(CommandContext commandContext, SandboxModel model)
    {
        var workspace = MSBuildWorkspace.Create();
        var sln = await workspace.OpenSolutionAsync(await Arguments.TemplateSlnFullPath());

        //var project = workspace.CurrentSolution.AddProject("temp", "temp", "C#");
        //var textDocument = project.AddDocument("Program.cs", "namespace Whatever { public static class Program {public static async Task Main() {Console.WriteLine(\"abc\");}}}");
        var csDoc = sln.Projects.First().Documents.Single(x => x.Name == "Renderer.cs");
        var project = sln.Projects.First().RemoveDocument(csDoc.Id);
        var initialText = await csDoc.GetTextAsync();
        var code = initialText.ToString();
        code = code.Replace("public class Model { }", $"public class Model {{ {model.CodeSample.CSharpModel} }}");
        code = code.Replace("return null;", model.CodeSample.CSharpCode);
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
            var modelObject = deserializeModel.Invoke(rendererObject, new object[] { model.CodeSample.JsonModel });

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
        whitelistedNamespaces.Add("System.Linq");

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
    public override IHtmlNode GetHtmlTree(List<string> dataModel)
    {
        var document = DocumentTag.Create();
        var head = document.Head;
        var body = document.Body;

        var script = head.AddChild(new HtmlTag("link"));
        script.SetAttribute("rel", "stylesheet");
        script.SetAttribute("href", "/metapsi.tutorial.css");

        foreach (var error in dataModel)
        {
            var errorDiv = body.AddChild(new HtmlTag("div"));
            errorDiv.SetAttribute("class", "text-red-500");
            errorDiv.AddChild(new HtmlText(error));
        }

        return document;
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