//using System;
//using System.Text;
//using Metapsi.Syntax;

//namespace Metapsi.JavaScript;

//public static class JsModule
//{
//    public enum GenerateStyle
//    {
//        /// <summary>
//        /// Generates Pretty in debug mode and Ugly in release mode
//        /// </summary>
//        Default,
//        /// <summary>
//        /// Indent generated JS
//        /// </summary>
//        Pretty,
//        /// <summary>
//        /// Do not indent JS
//        /// </summary>
//        Ugly
//    }

//    public class GenerateJsProps
//    {
//        public GenerateStyle Style { get; set; }
//    }

//    public static string GetJs(Action<SyntaxBuilder> main, GenerateStyle style = GenerateStyle.Default)
//    {
//        var moduleBuilder = new ModuleBuilder();
//        moduleBuilder.AddFunction("main", main);
//        return moduleBuilder.Module.ToJs();
//    }

//    /// <summary>
//    /// Gets the JavaScript code of the module, including the call of 'main'
//    /// </summary>
//    /// <param name="module"></param>
//    /// <param name="style"></param>
//    /// <returns></returns>
//    public static string ToJs(this Module module, GenerateStyle style = GenerateStyle.Default, bool callMain = true)
//    {
//        StringBuilder stringBuilder = new StringBuilder();

//        stringBuilder.AppendLine(module.ToJs());

////        switch (style)
////        {
////            case GenerateStyle.Default:
////#if DEBUG
////                stringBuilder.AppendLine(PrettyBuilder.Generate(module));
////#else
////                stringBuilder.AppendLine(UglyBuilder.Generate(moduleBuilder.Module, string.Empty));
////#endif
////                break;
////            case GenerateStyle.Pretty:
////                stringBuilder.AppendLine(PrettyBuilder.Generate(module));
////                break;
////            case GenerateStyle.Ugly:
////                stringBuilder.AppendLine(UglyBuilder.Generate(module, string.Empty));
////                break;
////        }
//        if (callMain)
//        {
//            stringBuilder.AppendLine("main()");
//        }
//        return stringBuilder.ToString();
//    }
//}

