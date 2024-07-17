using Markdig;
using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Syntax.Inlines;
using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;
public class CodeSample
{
    public string SampleId { get; set; } = string.Empty;
    public string SampleLabel { get; set; } = string.Empty;
    public string CSharpModel { get; set; } = " "; // because model is not always mandatory & code sample span collapses if there is no text
    public string CSharpCode { get; set; } = string.Empty; // because code is always mandatory & compile button is disabled if there's none
    public string JsonModel { get; set; } = "{}";
}

public static partial class Control
{

    public static HtmlTag Sample(CodeSample sample, InlineSample inlineSample)
    {
        const string ModelTab = nameof(ModelTab);
        const string JsonDataTab = nameof(JsonDataTab);
        const string CSharpCodeTab = nameof(CSharpCodeTab);

        var sendToPanelButtonId = "send_to_live_panel_" + sample.SampleId;

        var modelTab = new SlTab() { panel = ModelTab }.SetAttribute("slot", "nav").WithChild(HtmlText.CreateTextNode("Model"));
        var jsonTab = new SlTab(){ panel = JsonDataTab }.SetAttribute("slot", "nav").WithChild(HtmlText.CreateTextNode("JSON data"));
        var viewTab = new SlTab(){ panel = CSharpCodeTab }.SetAttribute("slot", "nav").WithChild(HtmlText.CreateTextNode("View"));

        var modelPanel = new SlTabPanel()
        {
            name = ModelTab,
        }
        .WithChild(
            new HtmlTag("pre").WithChild(
                new HtmlTag("code").WithClass("language-csharp").WithChild(
                    HtmlText.CreateTextNode(System.Web.HttpUtility.HtmlEncode(sample.CSharpModel)))));

        var jsonPanel = new SlTabPanel()
        {
            name = JsonDataTab
        }.WithChild(
            new HtmlTag("pre").WithChild(
                new HtmlTag("code").WithClass("language-javascript").WithChild(
                    HtmlText.CreateTextNode(sample.JsonModel))));

        var viewPanel = new SlTabPanel()
        {
            name = CSharpCodeTab
        }.WithChild(
                new HtmlTag("pre").WithChild(
                    new HtmlTag("code").WithClass("language-csharp").WithChild(
                        HtmlText.CreateTextNode(System.Web.HttpUtility.HtmlEncode(sample.CSharpCode)))));

        if (inlineSample.SelectedTab == SampleTab.Json)
        {
            jsonTab.SetAttribute("active", "true");
            jsonPanel.SetAttribute("active", "true");
        }

        if (inlineSample.SelectedTab == SampleTab.View)
        {
            viewTab.SetAttribute("active", "true");
            viewPanel.SetAttribute("active", "true");
        }

        var container = DivTag.CreateStyled(
            "flex flex-col border rounded",
            new SlTabGroup()
            .WithChild(modelTab)
            .WithChild(jsonTab)
            .WithChild(viewTab)
            .WithChild(modelPanel)
            .WithChild(jsonPanel)
            .WithChild(viewPanel)
            .WithChild(
                DivTag.CreateStyled(
                    "flex flex-row items-center justify-between p-4 bg-gray-100 text-lg",
                    HtmlText.Create(sample.SampleLabel).WithClass("text-xs"),
                    new SlIconButton() { name = "caret-right-square" }).SetAttribute("id", sendToPanelButtonId)));

        container.AddJs(b =>
        {
            var control = b.GetElementById(b.Const(sendToPanelButtonId));
            b.SetDynamic(control.As<DynamicObject>(), new DynamicProperty<Action>("onclick"), b.Def((SyntaxBuilder b) =>
            {
                b.DispatchCustomEvent(b.Const("ExploreSample"), b.Const(sample));
            }));
        });

        return container;
    }
}

public class TutorialArticleNode : IHtmlNode
{
    public string Markdown { get; set; } = string.Empty;
    public List<CodeSample> CodeSamples { get; set; } = new();

    public string ToHtml()
    {
        var pipeline = new MarkdownPipelineBuilder()
            .Use<CodeSampleMarkdownExtension>()
            .Build();
        var markdown = Markdig.Markdown.ToHtml(this.Markdown, pipeline);
        return markdown;
    }
}

public class CodeSampleMarkdownExtension : IMarkdownExtension
{
    public void Setup(MarkdownPipelineBuilder pipeline)
    {
        pipeline.InlineParsers.Add(new CodeSampleParser());
    }

    public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
    {
        renderer.ObjectRenderers.AddIfNotAlready<CodeSampleRenderer>();
    }
}

public enum SampleTab
{
    Class,
    Json,
    View
}

public class InlineSample : LeafInline
{
    public string SampleId { get; set; }
    public SampleTab SelectedTab { get; set; } = SampleTab.Class;
}

public class CodeSampleParser : Markdig.Parsers.InlineParser
{
    public override bool Match(InlineProcessor processor, ref StringSlice slice)
    {
        if (slice.ToString().StartsWith("CodeSample:"))
        {
            var inlineSample = new InlineSample() {  };

            var segments = slice.ToString().Split(":");

            inlineSample.SampleId = segments[1];

            if (segments.Count() == 3)
            {
                var selectedTab = segments.Last();
                if(selectedTab == SampleTab.Json.ToString())
                {
                    inlineSample.SelectedTab = SampleTab.Json;
                }

                if(selectedTab == SampleTab.View.ToString())
                {
                    inlineSample.SelectedTab = SampleTab.View;
                }
            }

            var length = slice.Length;

            for (int i = 0; i < length; i++)
            {
                slice.NextChar();
            }

            processor.Inline = inlineSample;
            return true;
        }

        return false;
    }
}

public class CodeSampleRenderer : HtmlObjectRenderer<InlineSample>
{
    public static List<CodeSample> AllCodeSamples { get; set; } =null;

    protected override void Write(HtmlRenderer renderer, InlineSample obj)
    {
        var sample = AllCodeSamples.Single(x => x.SampleId == obj.SampleId);
        var sampleHtml = Control.Sample(sample, obj).ToHtml();
        renderer.Write(sampleHtml);
    }

    public static async Task LoadAllCodeSamples()
    {
        if (AllCodeSamples == null)
        {
            AllCodeSamples = await CodeSamplesLoader.LoadAllCodeSamples();
        }
    }
}

public static class CodeSamplesLoader
{
    public class EmbeddedSample
    {
        public string FileName { get; set; }
        public string SampleCode { get; set; }
    }
    private static string GetCSharpCode(MethodDeclarationSyntax methodDeclarationSyntax)
    {
        var body = methodDeclarationSyntax.Body.ToString()
            .TrimStart('{')
            .TrimEnd('}').Trim()
            .Replace("\n        ", "\n").Trim();

        return body;
    }

    private static string GetCSharpModel(ClassDeclarationSyntax classNode)
    {
        return string.Join("\n", classNode.Members.Select(x => x.ToString().Replace("\n        ", "\n"))).Trim();
    }

    private static string GetClassComment(ClassDeclarationSyntax classNode)
    {
        var trivia = classNode.GetLeadingTrivia().Single(t => t.Kind() == SyntaxKind.SingleLineDocumentationCommentTrivia);
        var xml = trivia.GetStructure();
        var commentedSummary = xml.DescendantNodes().OfType<XmlElementSyntax>().SingleOrDefault();
        if (commentedSummary != default(XmlElementSyntax))
        {
            return commentedSummary.Content.ToString().Replace("///", string.Empty).Trim();
        }

        return string.Empty;
    }

    public static async Task<List<EmbeddedSample>> GetAllEmbeddedSamples(System.Reflection.Assembly assembly)
    {
        List<EmbeddedSample> embeddedSamples = new();

        var allResources = assembly.GetManifestResourceNames();

        foreach (var resourceName in allResources)
        {
            if (resourceName.Contains("sample") && resourceName.EndsWith(".cs"))
            {
                var stream = assembly.GetManifestResourceStream(resourceName);
                StreamReader streamReader = new StreamReader(stream);
                var sampleCode = await streamReader.ReadToEndAsync();

                var fileName = resourceName.Replace(assembly.GetName().Name + ".", string.Empty);
                fileName = fileName.Replace("docs.samples.", string.Empty);

                embeddedSamples.Add(new EmbeddedSample()
                {
                    FileName = fileName,
                    SampleCode = sampleCode
                });
            }
        }

        return embeddedSamples;
    }


    public static async Task<List<CodeSample>> LoadAllCodeSamples()
    {

        List<CodeSample> codeSamples = new List<CodeSample>();

        var samplesAssembly = System.Reflection.Assembly.GetAssembly(typeof(Metapsi.Tutorial.Samples.TutorialSample<object>));

        var embeddedSamples = await GetAllEmbeddedSamples(samplesAssembly);

        var sampleTypes = samplesAssembly.DefinedTypes.Where(x => x.IsAssignableTo(typeof(Metapsi.Tutorial.Samples.ITutorialSample)) && !x.IsAbstract);

        var workspace = Microsoft.CodeAnalysis.MSBuild.MSBuildWorkspace.Create();
        var project = workspace.CurrentSolution.AddProject("samples", "samples", "C#");

        foreach (var sampleType in sampleTypes)
        {
            var embeddedSample = embeddedSamples.SingleOrDefault(x => x.FileName == sampleType.Name + ".cs");
            if (embeddedSample != null)
            {
                var getSampleDataMethod = sampleType.GetMethod("GetSampleData");
                var sampleInstance = System.Activator.CreateInstance(sampleType);
                var sampleData = getSampleDataMethod.Invoke(sampleInstance, new object[] { });
                var modelType = sampleData.GetType();

                var renderMethod = sampleType.DeclaredMethods.SingleOrDefault(
                    x => x.GetParameters().Count() == 2
                    && x.GetParameters().First().ParameterType == typeof(LayoutBuilder)
                    && x.GetParameters().Last().ParameterType.GenericTypeArguments.Count() == 1
                    && x.GetParameters().Last().ParameterType.GenericTypeArguments.First() == modelType);

                var sampleDoc = project.AddDocument(embeddedSample.FileName, embeddedSample.SampleCode);

                var syntaxTree = await sampleDoc.GetSyntaxTreeAsync();
                var syntaxRoot = await syntaxTree.GetRootAsync();

                var sampleClassNode = syntaxRoot.DescendantNodes().OfType<ClassDeclarationSyntax>().SingleOrDefault(x => x.Identifier.Text == sampleType.Name);
                var plm = GetClassComment(sampleClassNode);

                var modelClassNode = syntaxRoot.DescendantNodes().OfType<ClassDeclarationSyntax>().SingleOrDefault(x => x.Identifier.Text == modelType.Name);
                var renderMethodNode = syntaxRoot.DescendantNodes().OfType<MethodDeclarationSyntax>().SingleOrDefault(x => x.Identifier.Text == renderMethod.Name);

                CodeSample codeSample = new CodeSample()
                {
                    SampleId = sampleType.Name,
                    CSharpCode = GetCSharpCode(renderMethodNode),
                    CSharpModel = GetCSharpModel(modelClassNode),
                    JsonModel = Metapsi.Serialize.ToJson(sampleData),
                    SampleLabel = GetClassComment(sampleClassNode)
                };

                codeSamples.Add(codeSample);
            }
        }

        return codeSamples;
    }
}