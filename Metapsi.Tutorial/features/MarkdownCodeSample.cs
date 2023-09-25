using Markdig;
using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Syntax.Inlines;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

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

public class InlineSample : LeafInline
{
    public string SampleId { get; set; }
}

public class CodeSampleParser : Markdig.Parsers.InlineParser
{
    public override bool Match(InlineProcessor processor, ref StringSlice slice)
    {
        if (slice.ToString().StartsWith("CodeSample:"))
        {
            var sampleId = slice.ToString().Split(":").Last();

            var length = slice.Length;

            for (int i = 0; i < length; i++)
            {
                slice.NextChar();
            }

            processor.Inline = new InlineSample() { SampleId = sampleId };
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
        var sampleHtml = Control.Sample(sample).ToHtml();
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
            .Replace("\n        ", "\n");

        return body;
    }

    private static string GetCSharpModel(ClassDeclarationSyntax classNode)
    {
        return string.Join("\n", classNode.Members.Select(x => x.ToString()));
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
                    && x.GetParameters().First().ParameterType == typeof(Metapsi.Syntax.BlockBuilder)
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