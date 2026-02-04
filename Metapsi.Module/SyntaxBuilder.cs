using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Syntax
{
    public class SyntaxBuilder
    {
        internal ModuleBuilder moduleBuilder;
        internal List<SyntaxNode> nodes { get; set; } = new List<SyntaxNode>();

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

        public HashSet<Metadata> Metadata()
        {
            return this.moduleBuilder.Module.Metadata;
        }

        public Var<T> ImportName<T>(string source, string importName)
        {
            this.moduleBuilder.Module.ImportName(source, importName);
            return new Var<T>(importName);
        }

        public Var<T> ImportName<T>(ResourceMetadata source, string importName)
        {
            this.moduleBuilder.Module.ImportName(source, importName);
            return new Var<T>(importName);
        }

        public void ImportDefault(string source, string asName)
        {
            this.moduleBuilder.Module.ImportDefault(source, asName);
        }

        public void ImportDefault(ResourceMetadata source, string asName)
        {
            this.moduleBuilder.Module.ImportDefault(source, asName);
        }

        public Var<T> ImportDefault<T>(string source, string asName)
        {
            ImportDefault(source, asName);
            return new Var<T>(asName);
        }

        public void ImportSideEffect(string source)
        {
            this.moduleBuilder.Module.ImportSideEffect(source);
        }

        public void ImportSideEffect(ResourceMetadata source)
        {
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
            this.nodes.Add(new SyntaxNode() { Comment = new CommentNode() { Comment = comment } });
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
                Node = new SyntaxNode()
                {
                    Literal = new LiteralNode()
                    {
                        Value = Metapsi.Serialize.ToJson(obj, "to-js")
                    }
                }
            };
            assignmentNode.AddDebugType(typeof(T));
            nodes.Add(new SyntaxNode() { Assignment = assignmentNode });
            return new Var<T>(assignmentNode.Name)
            {
                AssignmentNode = assignmentNode
            };
        }

        public Var<T> CallDynamic<T>(Var<Delegate> f, params IVariable[] arguments)
        {
            var assignmentNode = new AssignmentNode()
            {
                Name = moduleBuilder.NewName(),
                Node = new SyntaxNode()
                {
                    Call = new CallNode()
                    {
                        Fn = new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = f.Name
                            }
                        },
                        Arguments = arguments.Select(x => new SyntaxNode() { Identifier = new IdentifierNode() { Name = x.Name } }).ToList()
                    }
                }
            };

            assignmentNode.AddDebugType(typeof(T));

            nodes.Add(new SyntaxNode() { Assignment = assignmentNode });
            return new Var<T>(assignmentNode.Name)
            {
                AssignmentNode = assignmentNode
            };
        }

        public void CallDynamic(Var<Delegate> f, params IVariable[] arguments)
        {
            var callNode = new CallNode()
            {
                Fn = new SyntaxNode()
                {
                    Identifier = new IdentifierNode()
                    {
                        Name = f.Name
                    }
                },
                Arguments = arguments.Select(x => new SyntaxNode() { Identifier = new IdentifierNode() { Name = x.Name } }).ToList()
            };

            nodes.Add(new SyntaxNode() { Call = callNode });
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
        public static Var<object> NewObj(this SyntaxBuilder b)
        {
            return b.NewObj<object>();
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
}

