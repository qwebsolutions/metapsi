using Metapsi.Dom;
using Metapsi.Html;
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
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class SandboxModel : ApiSupportModel
{
    public CodeSample CodeSample { get; set; } = new();
    public string ResultHtml { get; set; } = "<p style=\"font-family:sans-serif;\">Run the code sample to see HTML output here</p>";
}
public enum Editor
{
    Monaco,
    CodeMirror
}

public class SandboxSample
{
    public string CSharpModel { get; set; } = " "; // because model is not always mandatory & code sample span collapses if there is no text
    public string CSharpCode { get; set; } = string.Empty; // because code is always mandatory & compile button is disabled if there's none
    public string JsonModel { get; set; } = "{}";
}

public class CompileResponse : ApiResponse
{
    public string ResultHtml { get; set; }
}

public static class SandboxApi
{
    public static Request<CompileResponse, SandboxSample> CompileSample { get; set; } = new(nameof(CompileSample));
}

public static partial class Control
{
    public static Var<IVNode> CodeEditor(this LayoutBuilder b, Editor editor, Action<PropsBuilder<EditorProps>> buildProps)
    {
        PropsBuilder<EditorProps> propsBuilder = new PropsBuilder<EditorProps>();
        propsBuilder.InitializeFrom(b);
        propsBuilder.Props = b.NewObj<EditorProps>();
        buildProps(propsBuilder);
        var props = propsBuilder.Props;

        if (editor == Editor.Monaco)
        {
            StaticFiles.Add(typeof(Control).Assembly, "codicon.ttf");
            StaticFiles.Add(typeof(Control).Assembly, "metapsi.monaco.js");
            Var<MonacoProps> monacoProps = b.NewObj<MonacoProps>();
            b.Set(monacoProps, (MonacoProps x) => x.EditorId, b.Get(props, (EditorProps x) => x.EditorId));
            b.Set(monacoProps, (MonacoProps x) => x.value, b.Get(props, (EditorProps x) => x.value));
            b.Set(monacoProps, (MonacoProps x) => x.language, b.If(b.AreEqual(b.Get(props, (EditorProps x) => x.language), b.Const("json")), (SyntaxBuilder b) => b.Const("javascript"), (SyntaxBuilder b) => b.Const("csharp")));
            b.CallExternal("Metapsi.Monaco", "AttachMonaco", monacoProps);
        }
        else
        {
            StaticFiles.Add(typeof(Control).Assembly, "metapsi.codemirror.js");
            Var<CodeMirrorProps> codeMirrorProps = b.NewObj<CodeMirrorProps>();
            b.Set(codeMirrorProps, (CodeMirrorProps x) => x.EditorId, b.Get(props, (EditorProps x) => x.EditorId));
            b.Set(codeMirrorProps, (CodeMirrorProps x) => x.value, b.Get(props, (EditorProps x) => x.value));
            b.Set(codeMirrorProps, (CodeMirrorProps x) => x.mode, b.Get(props, (EditorProps x) => x.language));
            b.CallExternal("Metapsi.CodeMirror", "AttachCodeMirror", codeMirrorProps);
        }

        return b.HtmlDiv(
            b =>
            {
                b.SetClass(b.Get(props, x => x.Class));
                b.SetId(b.Get(props, x => x.EditorId));
                // TODO: Find a better way
                b.SetProperty(b.Props, b.Const("oneditor-change"), b.GetProperty<object>(props, b.Const("oneditor-change")));
            });
    }


    public static string TabPanelName(this System.Linq.Expressions.Expression<Func<CodeSample, string>> property)
    {
        return $"id-tab-{property.PropertyName()}";
    }

    public static string EditorDivContainerId(Expression<Func<CodeSample, string>> property)
    {
        return "id-editor-" + property.PropertyName();
    }


    public static IHtmlNode SandboxApp(Editor editor)
    {
        return new HyperAppNode<SandboxModel>()
        {
            Render = (LayoutBuilder b, Var<SandboxModel> model) => Sandbox(b, editor, model),
            Init = (SyntaxBuilder b) =>
            {
                b.AddSubscription("ExploreSample_Sub", (SyntaxBuilder b, Var<SandboxModel> _) => b.Listen(b.Const("ExploreSample"), LoadSample(b)));
                return b.Call(OnInit, b.Const(new SandboxModel()));
            }
        };
    }

    private static Var<HyperType.Action<SandboxModel, CodeSample>> LoadSample(SyntaxBuilder b)
    {
        return b.MakeAction((SyntaxBuilder b, Var<SandboxModel> _, Var<CodeSample> newSample) =>
        {
            return b.MakeStateWithEffects(
                b.Clone(_),
                b.MakeEffect<SandboxModel>(
                    b.Def((SyntaxBuilder b, Var<HyperType.Dispatcher<SandboxModel>> dispatcher) =>
                    {
                        var resetModel = b.NewObj<SandboxModel>();
                        b.Set(resetModel, x => x.CodeSample, newSample);
                        b.Dispatch(dispatcher, b.MakeAction((SyntaxBuilder b, Var<SandboxModel> prevState) =>
                        {
                            return resetModel;
                        }));
                    })));
        });
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

    private static Var<bool> SampleHasProperty(SyntaxBuilder b, Var<CodeSample> sample, System.Linq.Expressions.Expression<Func<CodeSample, string>> property)
    {
        var modelText = b.Get(sample, property);

        return b.Switch(
            modelText,
            b => b.HasValue(modelText),
            (" ", b => b.Const(false)),
            ("{}", b => b.Const(false)));
    }
    public static void MonacoOnEdit<TState, TControl>(
        this PropsBuilder<TControl> b,
        Var<HyperType.Action<TState, string>> onEdit)
        where TControl : new()
    {
        b.OnEventAction("editor-change", onEdit, "detail");
    }

    public static void BindToSample<TControl>(
        this PropsBuilder<TControl> b,
        System.Linq.Expressions.Expression<Func<CodeSample, string>> property)
        where TControl : new()
    {
        b.MonacoOnEdit(b.MakeAction((SyntaxBuilder b, Var<SandboxModel> model, Var<string> newText) =>
        {
            var codeSample = b.Get(model, x => x.CodeSample);
            b.Set(codeSample, property, newText);
            return b.Clone(model);
        }));
    }

    public static Var<IVNode> Sandbox(LayoutBuilder b, Editor editor, Var<SandboxModel> clientModel)
    {
        Var<CodeSample> liveSample = b.Get(clientModel, (SandboxModel x) => x.CodeSample);
        var modelTab = b.SlTab(b =>
        {
            b.SetPanel(b.Const(TabPanelName((CodeSample x) => x.CSharpModel)));
            b.SetSlot("nav");
        },
        b.Text("Model"));


        //var modelEditor = b.CodeEditor(editor, b =>
        //{
        //    b.Set(b.Props, x => x.EditorId, EditorDivContainerId((CodeSample x) => x.CSharpModel));
        //    b.Set(b.Props, x => x.language, "csharp");
        //    b.Set(b.Props, x => x.value, b.Get(liveSample, (CodeSample x) => x.CSharpModel));
        //    b.BindToSample(x => x.CSharpModel);
        //});

        var modelPanel = b.SlTabPanel(
            b =>
            {
                b.SetName(b.Const(TabPanelName((CodeSample x) => x.CSharpModel)));
                b.SetId(TabPanelName((CodeSample x) => x.CSharpModel));
            },
            b.CodeEditor(
                editor,
                b =>
                {
                    b.Set(b.Props, x => x.EditorId, EditorDivContainerId((CodeSample x) => x.CSharpModel));
                    b.Set(b.Props, x => x.language, "csharp");
                    b.Set(b.Props, x => x.value, b.Get(liveSample, (CodeSample x) => x.CSharpModel));
                    b.BindToSample(x => x.CSharpModel);
                }));

        //Var<EditorProps> modelEditorProps = b.NewObj<EditorProps>();
        //b.Set(modelEditorProps, (EditorProps x) => x.EditorId, EditorDivContainerId((CodeSample x) => x.CSharpModel));
        //b.Set(modelEditorProps, (EditorProps x) => x.language, "csharp");
        //b.Set(modelEditorProps, (EditorProps x) => x.value, b.Get(liveSample, (CodeSample x) => x.CSharpModel));

       

        //Var<HyperNode> modelEditor = b.Add(modelPanel.As<HyperNode>(), b.CodeEditor(editor, modelEditorProps));
        //b.BindToSample(modelEditor, (CodeSample x) => x.CSharpModel);

        var jsonTab = b.SlTab(
            b =>
            {
                b.SetPanel(b.Const(TabPanelName((CodeSample x) => x.JsonModel)));
                b.SetSlot("nav");
            },
            b.Text("JSON data"));

        var jsonPanel = b.SlTabPanel(
            b =>
            {
                b.SetName(b.Const(TabPanelName((CodeSample x) => x.JsonModel)));
                b.SetId(TabPanelName((CodeSample x) => x.JsonModel));
            },
            b.CodeEditor(
                editor,
                b =>
                {
                    b.Set(b.Props, x => x.EditorId, EditorDivContainerId((CodeSample x) => x.JsonModel));
                    b.Set(b.Props, x => x.language, "json");
                    b.Set(b.Props, x => x.value, b.Get(liveSample, (CodeSample x) => x.JsonModel));
                    b.BindToSample(x => x.JsonModel);
                }));

        var viewTab = b.SlTab(
            b =>
            {
                b.SetPanel(b.Const(TabPanelName((CodeSample x) => x.CSharpCode)));
                b.SetSlot("nav");
            },
            b.Text("View"));

        var viewPanel = b.SlTabPanel(
            b =>
            {
                b.SetName(b.Const(TabPanelName((CodeSample x) => x.CSharpCode)));
                b.SetId(TabPanelName((CodeSample x) => x.CSharpCode));
            },
            b.CodeEditor(
                editor,
                b =>
                {
                    b.Set(b.Props, x => x.EditorId, EditorDivContainerId((CodeSample x) => x.CSharpCode));
                    b.Set(b.Props, x => x.language, "csharp");
                    b.Set(b.Props, x => x.value, b.Get(liveSample, (CodeSample x) => x.CSharpCode));
                    b.BindToSample(x => x.CSharpCode);
                }));

        //b.Add(container,
        var tabGroup = b.SlTabGroup(
            b =>
            {

            },
            modelTab,
            jsonTab,
            viewTab,
            modelPanel,
            jsonPanel,
            viewPanel);

        var isLoading = b.Get(clientModel, x => x.ApiSupport.InProgress);

        var compileAction = b.MakeAction((SyntaxBuilder b, Var<SandboxModel> model) =>
        {
            b.Set(b.Get(model, x => x.ApiSupport), x => x.InProgress, b.Const(true));

            var sample = b.NewObj<SandboxSample>();
            b.Set(sample, x => x.JsonModel, b.Get(model, x => x.CodeSample.JsonModel));
            b.Set(sample, x => x.CSharpModel, b.Get(model, x => x.CodeSample.CSharpModel));
            b.Set(sample, x => x.CSharpCode, b.Get(model, x => x.CodeSample.CSharpCode));

            return b.MakeStateWithEffects(
                b.Clone(model),
                b.PostJson(
                    SandboxApi.CompileSample,
                    sample,
                    b.MakeAction((SyntaxBuilder b, Var<SandboxModel> model, Var<CompileResponse> response) =>
                    {
                        b.Set(b.Get(model, x => x.ApiSupport), x => x.InProgress, b.Const(false));
                        b.Set(model, x => x.ResultHtml, b.Get(response, x => x.ResultHtml));
                        return b.Clone(model);
                    }),
                    b.MakeAction((SyntaxBuilder b, Var<SandboxModel> model, Var<ClientSideException> error) =>
                    {
                        b.Log(b.Get(error, x => x.message));
                        b.Set(b.Get(model, x => x.ApiSupport), x => x.InProgress, b.Const(false));
                        b.Set(model, x => x.ResultHtml, b.Const("Compile error"));
                        return b.Clone(model);
                    }))
                );
        });

        var compileButton = b.SlButton(
            b =>
            {
                b.SetVariantPrimary();
                //TODO: Cannot set conditional because .Props is not copied
                b.If(isLoading, b => b.SetLoading());
                b.If(
                    b.Not(
                        b.HasValue(
                            b.Get(liveSample, (CodeSample x) => x.CSharpCode))),
                    b => b.SetDisabled());
                b.OnClickAction(compileAction);
            },
            b.Text("Run!"));

        var container = b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-2 bg-gray-50 rounded p-2");
            },
            tabGroup,
            compileButton,
            b.HtmlIframe(
                b =>
                {
                    b.SetClass("w-full h-96 rounded border border-blue-500");
                    b.SetId("output-frame");
                }));


        SetOutputHtml(b, b.Get(clientModel, (SandboxModel x) => x.ResultHtml));

        return container;
    }

    public static void SetOutputHtml(SyntaxBuilder b, Var<string> content)
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
                //b.Log("iframe not found!");
            });
    }

    public static Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<SandboxModel> model)
    {
        return b.MakeStateWithEffects(b.Clone(model), b.MakeEffect<SandboxModel>(
            b.Def(
                (SyntaxBuilder b, Var<HyperType.Dispatcher<SandboxModel>> disp) =>
        {
            b.RequestAnimationFrame(
                b.Def((SyntaxBuilder b) =>
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

                    b.Dispatch(disp, b.MakeAction((SyntaxBuilder b, Var<SandboxModel> model) =>
                    {
                        return b.Clone(model);
                    }));
                }));
        })));
    }

    public static async Task<string> Compile(CommandContext commandContext, SandboxSample sample)
    {
        var workspace = MSBuildWorkspace.Create();
        var sln = await workspace.OpenSolutionAsync(
            System.IO.Path.Combine(
                (await Arguments.Load()).TemplateSlnFolder,
                "Metapsi.Tutorial.Template.sln"));

        //var project = workspace.CurrentSolution.AddProject("temp", "temp", "C#");
        //var textDocument = project.AddDocument("Program.cs", "namespace Whatever { public static class Program {public static async Task Main() {Console.WriteLine(\"abc\");}}}");
        
        var csDoc = sln.Projects.First().Documents.Single(x => x.Name == "Renderer.cs");
        var project = sln.Projects.First().RemoveDocument(csDoc.Id);
        var initialText = await csDoc.GetTextAsync();
        var code = initialText.ToString();
        code = code.Replace("public class Model { }", $"public class Model {{ {sample.CSharpModel} }}");
        code = code.Replace("return null;", sample.CSharpCode);
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
                return errorHtml;
            }
        }

        var compilation = await csDoc.Project.GetCompilationAsync();

        var binaries = compilation.EmitToArray();

        if (!binaries.Errors.Any())
        {
            try
            {
                AssemblyLoadContext assemblyLoadContext = new AssemblyLoadContext("temp");
                var assembly = assemblyLoadContext.LoadFromArray(binaries.Assembly);
                var rendererType = assembly.GetTypes().First(x => x.Name == "Renderer");
                var getHtml = rendererType.GetMethods().First(x => x.Name == "Render");
                var deserializeModel = rendererType.GetMethods().First(x => x.Name == "DeserializeModel");

                var rendererObject = Activator.CreateInstance(rendererType);
                var modelObject = deserializeModel.Invoke(rendererObject, new object[] { sample.JsonModel });

                var html = (string)getHtml.Invoke(rendererObject, new object[] { modelObject });
                return html;
            }
            catch(Exception ex)
            {
                if(ex.InnerException is System.Text.Json.JsonException)
                {
                    System.Text.Json.JsonException jsonException = ex.InnerException as System.Text.Json.JsonException;

                    var errorHtml = new ErrorPage().Render(new List<string>() { jsonException.Message });
                    return errorHtml;
                }
                else
                {
                    var errorHtml = new ErrorPage().Render(new List<string>() { ex.Message });
                    return errorHtml;
                }
            }
        }
        else
        {
            var errorHtml = new ErrorPage().Render(binaries.Errors.Select(x => x.ToString()).ToList());
            return errorHtml;
        }
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
        whitelistedNamespaces.Add("Metapsi.Html");
        whitelistedNamespaces.Add("Metapsi.Dom");
        whitelistedNamespaces.Add("Metapsi.Shoelace");
        whitelistedNamespaces.Add("Metapsi.Ionic");
        whitelistedNamespaces.Add("Metapsi.Tutorial.Template");
        whitelistedNamespaces.Add("System.Linq");
        whitelistedNamespaces.Add("System.Collection.Generic");

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
    public override void FillHtml(List<string> dataModel, DocumentTag document)
    {
        document.Head.AddStylesheet("/metapsi.tutorial.css");

        foreach (var error in dataModel)
        {
            var errorDiv = document.Body.AddChild(new HtmlTag("div"));
            errorDiv.SetAttribute("class", "text-red-500");
            errorDiv.AddChild(new HtmlText(error));
        }
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