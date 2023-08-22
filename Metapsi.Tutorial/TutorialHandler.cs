using Metapsi;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class TutorialHandler : Http.Get<Metapsi.Tutorial.Routes.Tutorial.Step, int>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, int stepNumber)
    {
        TutorialModel model = new TutorialModel();
        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._001_HelloWorld,
            SampleLabel = "Hello world - output simple text",
            CSharpCode = "return b.Text(\"Hello world\");",
            JsonModel = "{}"
        });

        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._002_HelloWorldColor,
            SampleLabel = "Hello world in color - basics of styling",
            CSharpCode = "return b.Text(\"Hello World!\", \"text-blue-800 p-4 bg-green-500\");",
            JsonModel = "{}"
        });

        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._003_HelloWorldNestedArrow,
            SampleLabel = "Nesting simple controls",
            CSharpCode = "return b.Div(\n\"text-blue-800 p-4 bg-green-500\",\n    b=> b.Text(\"Hello\"),\n    b=> b.Text(\"World\"));",
            JsonModel = "{}"
        });

        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._004_HelloWorldNestedAdd,
            SampleLabel = "Nesting complex controls",
            CSharpCode = "var container = b.Div(\"text-blue-800 p-4 bg-green-500\");\nb.Add(container, b.Text(\"Hello\"));\nb.Add(container, b.Text(\"World\"));\nreturn container;",
            JsonModel = "{}"
        });

        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._005_HelloWorldProperty,
            SampleLabel = "Accessing model properties",
            CSharpModel = "public string Greeting { get; set; }",
            CSharpCode = "return b.Text(\n    b.Get(model, x=>x.Greeting),\n    \"text-blue-800 p-4 bg-green-500\");",
            JsonModel = "{\"Greeting\" : \"Hello world from a model property!\"}"
        });

        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._006_HelloWorldIfValue,
            SampleLabel = "If statement",
            CSharpModel = "public string Greeting { get; set; }",
            CSharpCode = "var greeting = b.Get(model, x=>x.Greeting);\nvar container = b.Div();\nb.If(\n    b.HasValue(greeting),\n    b=>\n    {\n        b.Add(container, b.Text(greeting));\n    });\nreturn container;",
            JsonModel = "{\"Greeting\" : \"\"}"
        });


        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._007_HelloWorldIfElse,
            SampleLabel = "If statement with else branch",
            CSharpModel = "public string Greeting { get; set; }",
            CSharpCode = "var greeting = b.Get(model, x=>x.Greeting);\nvar container = b.Div();\nb.If(\n    b.HasValue(greeting),\n    b=>\n    {        b.Add(container, b.Text(greeting));\n    },\n    b=>\n    {        b.Add(container, b.Text(\"Greeting default!\"));\n    });\nreturn container;",
            JsonModel = "{\"Greeting\" : \"\"}"
        });

        model.Samples.Add(new CodeSample()
        {
            SampleId = CodeSampleId._008_HelloWorldIfExpression,
            SampleLabel = "If expression",
            CSharpModel = "public string Greeting { get; set; }",
            CSharpCode = "var greeting = b.Get(model, x=>x.Greeting);\nreturn b.Text(\n    b.If(\n        b.HasValue(greeting),\n        b=> greeting,\n        b=> b.Const(\"Greeting default!\")));",
            JsonModel = "{\"Greeting\" : \"\"}"
        });

        return Page.Result(model);
    }
}