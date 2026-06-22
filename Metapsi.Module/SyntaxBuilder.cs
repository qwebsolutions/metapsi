using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Metapsi.Syntax
{
    public interface ISyntaxBuilder : ICanResolveResourcePath
    {
        ModuleBuilder ModuleBuilder { get; }
        void AddSyntaxNode(SyntaxNode syntaxNode);
        //List<SyntaxNode> Nodes { get; }
        List<SyntaxNode> GetNodes();
    }

    public class SyntaxBuilder :
        ISyntaxBuilder,
        IIfStatementBuilder<SyntaxBuilder>,
        IIfExpressionBuilder<SyntaxBuilder>,
        IForeachBuilder<SyntaxBuilder>,
        ICanResolveResourcePath,
        ICanRequireDependency
    {
        private ModuleBuilder moduleBuilder;
        private List<SyntaxNode> nodes { get; set; } = new List<SyntaxNode>();

        ModuleBuilder ISyntaxBuilder.ModuleBuilder => this.moduleBuilder;

        //List<SyntaxNode> ISyntaxBuilder.Nodes => this.nodes;

        public SyntaxBuilder(ModuleBuilder moduleBuilder, List<SyntaxNode> nodes)
        {
            this.moduleBuilder = moduleBuilder;
            this.nodes = nodes;
        }

        public string ResolvePath(IResource resource)
        {
            return moduleBuilder.Resolver.ResolvePath(resource);
        }

        public void Require(IDependency dependency)
        {
            moduleBuilder.Resolver.Import(dependency);
        }

        public void If(Var<bool> check, Action<SyntaxBuilder> ifTrue, Action<SyntaxBuilder> ifFalse)
        {
            Core.If(this, check, ifTrue, ifFalse);
        }

        public void If(Var<bool> check, Action<SyntaxBuilder> ifTrue)
        {
            Core.If(this, check, ifTrue);
        }

        public Var<TResult> If<TResult>(Var<bool> check, Func<SyntaxBuilder, Var<TResult>> ifTrue, Func<SyntaxBuilder, Var<TResult>> ifFalse)
        {
            return Core.If(this, check, ifTrue, ifFalse);
        }

        public Var<TResult> Switch<TResult, TInput>(Var<TInput> v, Func<SyntaxBuilder, Var<TResult>> @default, params (TInput, Func<SyntaxBuilder, Var<TResult>>)[] cases)
        {
            return Core.Switch(this, v, @default, cases);
        }

        public void Foreach<TItem>(Var<List<TItem>> collection, Action<SyntaxBuilder, Var<TItem>, Var<int>> onItem)
        {
            Core.Foreach(this, collection, onItem);
        }

        public void Foreach<TItem>(Var<List<TItem>> collection, Action<SyntaxBuilder, Var<TItem>> onItem)
        {
            Core.Foreach(this, collection, onItem);
        }

        void ISyntaxBuilder.AddSyntaxNode(SyntaxNode syntaxNode)
        {
            this.nodes.Add(syntaxNode);
        }

        List<SyntaxNode> ISyntaxBuilder.GetNodes()
        {
            return this.nodes;
        }
    }

    public static class SyntaxBuilderExtensions
    {

        /// <summary>
        /// Add or reuse a module-wide constant
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constant"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static Var<T> Const<T>(this ISyntaxBuilder b, T constant)
        {
            if (constant is IVariable)
                throw new ArgumentException("Constant is not a server-side value");
            return b.ModuleBuilder.Const(constant);
        }

        /// <summary>
        /// Add or reuse a module-wide constant. Use specified name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constant"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Var<T> Const<T>(this ISyntaxBuilder b, T constant, string name)
        {
            var outConst = b.Const(constant);
            (outConst as IClientVar).Name = name;
            return outConst;
        }

        public static Var<T> As<T>(this IVariable variable)
        {
            return new ClientVar<T>((variable as IClientVar).Name);
        }

        /// <summary>
        /// Creates a new object of type T, initialized from obj
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Var<T> NewObj<T>(this ISyntaxBuilder b, T obj)
        {
            var assignmentNode = new AssignmentNode()
            {
                Name = b.ModuleBuilder.NewName(),
                Node = new SyntaxNode()
                {
                    Literal = new LiteralNode()
                    {
                        Value = Metapsi.Serialize.ToJson(obj, "to-js")
                    }
                }
            };
            assignmentNode.AddDebugType(typeof(T));
            b.AddSyntaxNode(new SyntaxNode() { Assignment = assignmentNode });
            return new ClientVar<T>(assignmentNode.Name)
            {
                AssignmentNode = assignmentNode
            };
        }

        /// <summary>
        /// Creates a new empty object
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Var<object> NewObj(this ISyntaxBuilder b)
        {
            return b.NewObj<object>();
        }

        /// <summary>
        /// Creates a new object of type T, using the server-side initializer of properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Var<T> NewObj<T>(this ISyntaxBuilder b) where T : new()
        {
            return b.NewObj(new T());
        }

        /// <summary>
        /// Creates an empty collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <remarks>To initialize a collection based on </remarks>
        public static Var<List<T>> NewCollection<T>(this ISyntaxBuilder b)
        {
            return b.NewObj<List<T>>();
        }

        public static Var<T> ImportName<T>(this ISyntaxBuilder b, string source, string importName)
        {
            b.ModuleBuilder.Module.ImportName(source, importName);
            return new ClientVar<T>(importName);
        }

        public static void ImportDefault(this ISyntaxBuilder b, string source, string asName)
        {
            b.ModuleBuilder.Module.ImportDefault(source, asName);
        }

        public static Var<T> ImportDefault<T>(this ISyntaxBuilder b, string source, string asName)
        {
            ImportDefault(b, source, asName);
            return new ClientVar<T>(asName);
        }

        public static void ImportSideEffect(this ISyntaxBuilder b, string source)
        {
            b.ModuleBuilder.Module.ImportSideEffect(source);
        }

        public static void DebugComment(this ISyntaxBuilder b, string comment)
        {
#if DEBUG
            Comment(b, comment);
#endif
        }

        public static void Comment(this ISyntaxBuilder b, string comment)
        {
            b.AddSyntaxNode(new SyntaxNode() { Comment = new CommentNode() { Comment = comment } });
        }


        public static Var<T> CallDynamic<T>(this ISyntaxBuilder b, Var<Delegate> f, params IVariable[] arguments)
        {
            var assignmentNode = new AssignmentNode()
            {
                Name = b.ModuleBuilder.NewName(),
                Node = new SyntaxNode()
                {
                    Call = new CallNode()
                    {
                        Fn = new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = (f as IClientVar).Name
                            }
                        },
                        //Arguments = arguments.Select(x => new SyntaxNode() { Identifier = new IdentifierNode() { Name = x.Name } }).ToList()
                        Arguments = ArgumentsToSyntaxNodes(b, arguments)
                    }
                }
            };

            assignmentNode.AddDebugType(typeof(T));

            b.AddSyntaxNode(new SyntaxNode() { Assignment = assignmentNode });
            return new ClientVar<T>(assignmentNode.Name)
            {
                AssignmentNode = assignmentNode
            };
        }

        public static void CallDynamic(this ISyntaxBuilder b, Var<Delegate> f, params IVariable[] arguments)
        {
            var callNode = new CallNode()
            {
                Fn = new SyntaxNode()
                {
                    Identifier = new IdentifierNode()
                    {
                        Name = (f as IClientVar).Name
                    }
                },
                //Arguments = arguments.Select(x => new SyntaxNode() { Identifier = new IdentifierNode() { Name = x.Name } }).ToList()
                Arguments = ArgumentsToSyntaxNodes(b, arguments)
            };

            b.AddSyntaxNode(new SyntaxNode() { Call = callNode });
        }

        private static List<SyntaxNode> ArgumentsToSyntaxNodes(this ISyntaxBuilder b, IEnumerable<IVariable> arguments)
        {
            List<SyntaxNode> syntaxArguments = new List<SyntaxNode>();
            foreach (var argument in arguments)
            {

                syntaxArguments.Add(new SyntaxNode() { Identifier = new IdentifierNode() { Name = (argument as IClientVar).Name } });
            }

            return syntaxArguments;
        }
    }
}