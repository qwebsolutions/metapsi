using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Loader;

public static class Program
{
    public static void Main()
    {
        try
        {
            // code for class A
            var classAString =
                @"public class A 
                    {
                        public static string Print() 
                        { 
                            return ""Hello "";
                        }
                    }";

            // code for class B (to spice it up, it is a 
            // subclass of A even though it is almost not needed
            // for the demonstration)
            var classBString =
                @"public class B : A
                    {
                        public static string Print()
                        { 
                            return ""World!"";
                        }
                    }";

            // the main class Program contain static void Main() 
            // that calls A.Print() and B.Print() methods
            var mainProgramString =
                @"public class Program
                    {
                        public static void Main()
                        {
                            System.Console.Write(A.Print()); 
                            System.Console.WriteLine(B.Print());
                        }
                    }";

            #region class A compilation into A.netmodule
            // create Roslyn compilation for class A
            var compilationA =
                CreateCompilationWithMscorlib
                (
                    "A",
                    classAString,
                    compilerOptions: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                );

            // emit the compilation result to a byte array 
            // corresponding to A.netmodule byte code
            var compilationAResult = compilationA.EmitToArray();

            MemoryStream compilationAStream = new MemoryStream();
            compilationAStream.Write(compilationAResult);
            compilationAStream.Seek(0, SeekOrigin.Begin);

            MetadataReference referenceA = MetadataReference.CreateFromStream(compilationAStream, filePath: "a.dll");

            var compilationB =
                CreateCompilationWithMscorlib
                (
                    "B",
                    classBString,
                    compilerOptions: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary),

                    // since class B extends A, we need to 
                    // add a reference to A.netmodule
                    references: new[] { referenceA }
                );

            // emit the compilation result to a byte array 
            // corresponding to B.netmodule byte code
            var compilationBResult = compilationB.EmitToArray();

            // create a reference to B.netmodule
            MemoryStream compilationBStream = new MemoryStream();
            compilationBStream.Write(compilationBResult);
            compilationBStream.Seek(0, SeekOrigin.Begin);

            var referenceB = MetadataReference.CreateFromStream(compilationBStream, filePath: "b.dll");
            #endregion class B compilation into B.netmodule

            #region main program compilation into the assembly
            // create the Roslyn compilation for the main program with
            // ConsoleApplication compilation options
            // adding references to A.netmodule and B.netmodule
            var mainCompilation =
                CreateCompilationWithMscorlib
                (
                    "program",
                    mainProgramString,
                    compilerOptions: new CSharpCompilationOptions
                                     (OutputKind.ConsoleApplication),
                    references: new[] { referenceA, referenceB }
                );

            // Emit the byte result of the compilation
            var result = mainCompilation.EmitToArray();

            // create a reference to B.netmodule
            MemoryStream ms = new MemoryStream();
            ms.Write(result);
            ms.Seek(0, SeekOrigin.Begin);

            var loadContext = new AssemblyLoadContext("program");
            loadContext.LoadFromStream(ms);

            ms = new MemoryStream();
            ms.Write(compilationAResult);
            ms.Seek(0, SeekOrigin.Begin);
            loadContext.LoadFromStream(ms);

            ms = new MemoryStream();
            ms.Write(compilationBResult);
            ms.Seek(0, SeekOrigin.Begin);
            loadContext.LoadFromStream(ms);

            var assemblies = loadContext.Assemblies;
            var assembly = loadContext.Assemblies.Single(x => x.GetTypes().Any(x => x.Name == "Program"));

            //loadContext.LoadFromStream(compilationBResult);

            #endregion main program compilation into the assembly

            // load the A.netmodule and B.netmodule into the assembly.
            //assembly.LoadModule("A.netmodule", compilationAResult);
            //assembly.LoadModule("B.netmodule", compilationBResult);

            #region Test the program
            // here we get the Program type and 
            // call its static method Main()
            // to test the program. 
            // It should write "Hello world!"
            // to the console

            // get the type Program from the assembly
            Type programType = assembly.GetType("Program");

            // Get the static Main() method info from the type
            MethodInfo method = programType.GetMethod("Main");

            // invoke Program.Main() static method
            method.Invoke(null, null);
            #endregion Test the program
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static Module Assembly_ModuleResolve(object sender, ResolveEventArgs e)
    {
        return null;
    }

    // a utility method that creates Roslyn compilation
    // for the passed code. 
    // The compilation references the collection of 
    // passed "references" arguments plus
    // the mscore library (which is required for the basic
    // functionality).
    private static CSharpCompilation CreateCompilationWithMscorlib
    (
        string assemblyOrModuleName,
        string code,
        CSharpCompilationOptions compilerOptions = null,
        IEnumerable<MetadataReference> references = null)
    {
        // create the syntax tree
        SyntaxTree syntaxTree = SyntaxFactory.ParseSyntaxTree(code, null, "");

        // get the reference to mscore library
        MetadataReference mscoreLibReference =
            AssemblyMetadata
                .CreateFromFile(typeof(string).Assembly.Location)
                .GetReference();

        MetadataReference consoleReference =
            AssemblyMetadata
            .CreateFromFile(typeof(System.Console).Assembly.Location)
            .GetReference();

        var objectAssemblyPath = Path.GetDirectoryName(typeof(System.Object).Assembly.Location);

        var runtimeReference = AssemblyMetadata
            .CreateFromFile(Path.Combine(objectAssemblyPath, "System.Runtime.dll"))
            .GetReference();

        //references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Private.CoreLib.dll")));
        //references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Console.dll")));
        //references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.dll")));

        // create the allReferences collection consisting of 
        // mscore reference and all the references passed to the method
        IEnumerable <MetadataReference> allReferences =
            new MetadataReference[] { mscoreLibReference, consoleReference, runtimeReference };
        if (references != null)
        {
            allReferences = allReferences.Concat(references);
        }

        // create and return the compilation
        CSharpCompilation compilation = CSharpCompilation.Create
        (
            assemblyOrModuleName,
            new[] { syntaxTree },
            options: compilerOptions,
            references: allReferences
        );

        return compilation;
    }

    // emit the compilation result into a byte array.
    // throw an exception with corresponding message
    // if there are errors
    private static byte[] EmitToArray
    (
        this Compilation compilation
    )
    {
        var stream = new MemoryStream();
        // emit result into a stream
        var emitResult = compilation.Emit(stream);

        if (!emitResult.Success)
        {
            // if not successful, throw an exception
            Diagnostic firstError =
                emitResult
                    .Diagnostics
                    .FirstOrDefault
                    (
                        diagnostic =>
                            diagnostic.Severity == DiagnosticSeverity.Error
                    );

            throw new Exception(firstError?.GetMessage());
        }
        stream.Seek(0, SeekOrigin.Begin);
        // get the byte array from a stream
        return stream.ToArray();
    }
}