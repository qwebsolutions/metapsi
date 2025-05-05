using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Syntax
{
    public class SyntaxBuilder
    {
        internal ModuleBuilder moduleBuilder;
        internal List<ISyntaxNode> nodes { get; set; } = new List<ISyntaxNode>();

        internal SyntaxBuilder(ModuleBuilder moduleBuilder)
        {
            this.moduleBuilder = moduleBuilder;
        }

        public SyntaxBuilder(SyntaxBuilder parent)
        {
            this.moduleBuilder = parent.moduleBuilder;
        }

        public string NewVarName()
        {
            return this.moduleBuilder.NewName();
        }

        private string FixSource(string source)
        {
            if (!source.EndsWith(".js") && !source.EndsWith(".mjs"))
            {
                source += ".js";
            }
            if (!source.StartsWith("http://") && !source.StartsWith("https://"))
            {
                if (!source.StartsWith("/"))
                {
                    source = "/" + source;
                }
            }
            return source;
        }

        public Var<T> ImportName<T>(string source, string importName)
        {
            source = FixSource(source);
            this.moduleBuilder.Module.ImportName(source, importName);
            return new Var<T>(importName);
        }

        public void ImportDefault(string source, string asName)
        {
            source = FixSource(source);
            this.moduleBuilder.Module.ImportDefault(source, asName);
        }

        public void ImportSideEffect(string source)
        {
            source = FixSource(source);
            this.moduleBuilder.Module.ImportSideEffect(source);
        }

        public void DebugComment(string comment)
        {
#if DEBUG
            Comment(comment);
#endif
        }

        public void Comment(string comment)
        {
            this.nodes.Add(new CommentNode() { Comment = comment });
        }


        /// <summary>
        /// Add or reuse a module-wide constant
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constant"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Var<T> Const<T>(T constant)
        {
            if (constant is IVariable)
                throw new ArgumentException("Constant is not a server-side value");
            return moduleBuilder.Const(constant);
        }

        /// <summary>
        /// Add or reuse a module-wide constant. Use specified name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constant"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Var<T> Const<T>(T constant, string name)
        {
            var outConst = Const(constant);
            outConst.Name = name;
            return outConst;
        }

        /// <summary>
        /// Creates a new object of type T, initialized from obj
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Var<T> NewObj<T>(T obj)
        {
            var assignmentNode = new AssignmentNode()
            {
                Name = moduleBuilder.NewName(),
                Node = new LiteralNode()
                {
                    Value = System.Text.Json.JsonSerializer.Serialize(obj)
                }
            };
            nodes.Add(assignmentNode);
            return new Var<T>(assignmentNode.Name);
        }

        public Var<T> CallDynamic<T>(Var<Delegate> f, params IVariable[] arguments)
        {
            var assignmentNode = new AssignmentNode()
            {
                Name = moduleBuilder.NewName(),
                Node = new CallNode()
                {
                    Fn = new IdentifierNode()
                    {
                        Name = f.Name
                    },
                    Arguments = arguments.Select(x => new IdentifierNode() { Name = x.Name }).Cast<ISyntaxNode>().ToList()
                }
            };

            nodes.Add(assignmentNode);
            return new Var<T>(assignmentNode.Name);
        }

        public void CallDynamic(Var<Delegate> f, params IVariable[] arguments)
        {
            var assignmentNode = new AssignmentNode()
            {
                Name = moduleBuilder.NewName(),
                Node = new CallNode()
                {
                    Fn = new IdentifierNode()
                    {
                        Name = f.Name
                    },
                    Arguments = arguments.Select(x => new IdentifierNode() { Name = x.Name }).Cast<ISyntaxNode>().ToList()
                }
            };

            nodes.Add(assignmentNode);
        }
    }


    public static class SyntaxBuilderExtensions
    {
        public static Var<T> As<T>(this IVariable variable)
        {
            return new Var<T>(variable.Name);
        }

        /// <summary>
        /// Creates a new empty object
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Var<DynamicObject> NewObj(this SyntaxBuilder b)
        {
            return b.NewObj<DynamicObject>();
        }

        /// <summary>
        /// Creates a new object of type T, using the server-side initializer of properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Var<T> NewObj<T>(this SyntaxBuilder b) where T : new()
        {
            return b.NewObj(new T());
        }

        /// <summary>
        /// Creates an empty collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <remarks>To initialize a collection based on </remarks>
        public static Var<List<T>> NewCollection<T>(this SyntaxBuilder b)
        {
            return b.NewObj<List<T>>();
        }
    }

    //public class SyntaxBuilder
    //{
    //    public virtual void InitializeFrom(SyntaxBuilder parent)
    //    {
    //        if (this.blockBuilder == null)
    //        {
    //            this.blockBuilder = parent.blockBuilder; // TODO: Seems shady?
    //        }
    //    }

    //    internal static TSyntaxBuilder New<TSyntaxBuilder>(BlockBuilder b, TSyntaxBuilder source)
    //        where TSyntaxBuilder : SyntaxBuilder, new()
    //    {
    //        TSyntaxBuilder syntaxBuilder = new TSyntaxBuilder() { blockBuilder = b };
    //        syntaxBuilder.InitializeFrom(source);
    //        return syntaxBuilder;
    //    }

    //    //public static TSyntaxBuilder New<TSyntaxBuilder>(TSyntaxBuilder source)
    //    //    where TSyntaxBuilder : SyntaxBuilder, new()
    //    //{
    //    //    TSyntaxBuilder syntaxBuilder = new() { blockBuilder = b };
    //    //    return syntaxBuilder;
    //    //}

    //    internal BlockBuilder blockBuilder;

    //    public Metapsi.Module.ModuleDefinition Module => blockBuilder.ModuleBuilder.Module;

    //    public SyntaxBuilder()
    //    {
    //    }

    //    public SyntaxBuilder(SyntaxBuilder b)
    //    {
    //        this.blockBuilder = b.blockBuilder;
    //    }


    //    public Var<TOut> CallExternal<TOut>(string module, string function, params IVariable[] arguments)
    //    {
    //        return blockBuilder.CallExternal<TOut>(module, function, arguments);
    //    }

    //    public void CallExternal(string module, string function, params IVariable[] arguments)
    //    {
    //        blockBuilder.CallExternal(module, function, arguments);
    //    }



    //    public void Comment(string comment,
    //        [System.Runtime.CompilerServices.CallerFilePath] String file = "",
    //        [System.Runtime.CompilerServices.CallerLineNumber] Int32 line = 0)
    //    {
    //        blockBuilder.Comment(comment, file, line);
    //    }


}

