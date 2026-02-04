using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Syntax
{
    /// <summary>
    /// Wrapper class for a module that enforces module constraints:
    /// <para> - Constants are not declared twice</para>
    /// <para> - Local variables have unique names</para>
    /// </summary>
    public class ModuleBuilder
    {
        /// <summary>
        /// Store function name to avoid duplicate signatures. 
        /// Use name as because static functions with different generic arguments create different delegates
        /// </summary>
        private HashSet<string> functionsCache = new HashSet<string>();
        
        // constant value -> associated variable
        private Dictionary<object, IVariable> constantsCache = new Dictionary<object, IVariable>();
        
        // constant name -> constant value
        private Dictionary<string, SyntaxNode> constantLiteralNodes = new Dictionary<string, SyntaxNode>();

        public static List<Type> ScalarTypes = new List<Type>() { typeof(string), typeof(int), typeof(bool), typeof(Guid) };

        public ModuleBuilder()
        {
            this.Module = new Module();
        }

        public ModuleBuilder(Module module)
        {
            this.Module = module;
        }

        public Metapsi.Syntax.Module Module { get; private set; }

        public int CurrentVarIndex { get; set; } = 0;

        public string NewName()
        {
            return $"_{++CurrentVarIndex}";
        }

        public static string SanitizeName(string name)
        {
            return name
                .Replace("<", string.Empty)
                .Replace(">", string.Empty)
                .Replace(".", string.Empty)
                .Replace(",", string.Empty)
                .Replace("+", string.Empty);
        }

        public static string QualifiedName(System.Reflection.MethodInfo methodInfo)
        {
            // Allow nested types, useful for ParentClass.Defs type of pattern
            List<string> parentTypes = new List<string>();
            Type parentType = methodInfo.DeclaringType;
            parentTypes.Add(parentType.Name);
            while (true)
            {
                parentType = parentType.DeclaringType;
                if (parentType == null)
                    break;
                parentTypes.Add(parentType.Name);
            }
            var parentSegment = string.Join("_", parentTypes.ToArray().Reverse());

            // Add parameters count because C# supports method overloading
            return $"{parentSegment}_{methodInfo.Name}_{methodInfo.GetParameters().Count() - 1}";// All start with SyntaxBuilder, skip that
        }

        public static Type[] FuncTypes =
            new Type[]
            {
                typeof(Func<>),
                typeof(Func<,>),
                typeof(Func<,,>),
                typeof(Func<,,,>),
                typeof(Func<,,,,>),
                typeof(Func<,,,,,>),
                typeof(Func<,,,,,,>),
                typeof(Func<,,,,,,,>),
                typeof(Func<,,,,,,,,>),
                typeof(Func<,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,,,,,,>),
                typeof(Func<,,,,,,,,,,,,,,,,>),
            };

        public static Type[] ActionTypes =
            new Type[]
            {
                typeof(Action),
                typeof(Action<>),
                typeof(Action<,>),
                typeof(Action<,,>),
                typeof(Action<,,,>),
                typeof(Action<,,,,>),
                typeof(Action<,,,,,>),
                typeof(Action<,,,,,,>),
                typeof(Action<,,,,,,,>),
                typeof(Action<,,,,,,,,>),
                typeof(Action<,,,,,,,,,>),
                typeof(Action<,,,,,,,,,,>),
                typeof(Action<,,,,,,,,,,,>),
                typeof(Action<,,,,,,,,,,,,>),
                typeof(Action<,,,,,,,,,,,,,>),
                typeof(Action<,,,,,,,,,,,,,,>),
                typeof(Action<,,,,,,,,,,,,,,,>)
            };

        public Type ClientActionType(Delegate action)
        {
            // The minimal Action has 1 type arguments, SyntaxBuilder
            // Action<SyntaxBuilder> example = (SyntaxBuilder b) => { };

            var serverTypeArguments = action.GetType().GenericTypeArguments;
            Type genericClientType = ActionTypes[serverTypeArguments.Length];

            return genericClientType.MakeGenericType(serverTypeArguments.ToArray());
        }

        public Type ClientFuncType(Delegate func)
        {
            // The minimal Func has 2 type arguments, SyntaxBuilder & return variable
            // Func<SyntaxBuilder, Var<TOut>> example = (SyntaxBuilder b) => new Var<TOut>();

            var serverTypeArguments = func.GetType().GenericTypeArguments;
            Type genericClientType = FuncTypes[serverTypeArguments.Length - 1];

            return genericClientType.MakeGenericType(serverTypeArguments.ToArray());
        }

        internal Var<T> AddFunction<T>(Delegate function, string name = null)
            where T : Delegate
        {
            if (name == null)
            {
                if (!function.Method.IsStatic)
                {
                    throw new ArgumentException("Function name cannot be identified. Either make the function static of provide a name");
                }

                name = ModuleBuilder.QualifiedName(function.Method);
            }

            if (!functionsCache.Contains(name))
            {
                // Add it to the cache BEFORE building the function.
                // This avoids infinite recursion
                functionsCache.Add(name);

                var assignmentNode = new AssignmentNode()
                {
                    Name = name,
                    Node = new SyntaxNode()
                    {
                        Fn = FnNodeExtensions.FromDelegate(new SyntaxBuilder(this), function)
                    }
                };

                assignmentNode.AddDebugType(function.Method.ReturnType);

                Module.Nodes.Add(new SyntaxNode() { Assignment = assignmentNode });
            }

            return new Var<T>(name);
        }

        public Var<T> Const<T>(T value, string name)
        {
            if (!this.constantsCache.ContainsKey(value))
            {
                var assignmentNode = new AssignmentNode()
                {
                    Name = name,
                    Node = new SyntaxNode()
                    {
                        Literal = new LiteralNode()
                        {
                            Value = Metapsi.Serialize.ToJson(value, "to-js")
                        }
                    }
                };

                assignmentNode.AddDebugType(typeof(T));

                Module.Nodes.Add(new SyntaxNode()
                {
                    Assignment = assignmentNode
                });
                constantsCache[value] = new Var<T>(name)
                {
                    AssignmentNode = assignmentNode
                };

                // Also keep variable name to string literal mapping to generate clearer code in output
                // Used just for strings at this point, it's safer
                if (value is string)
                {
                    constantLiteralNodes[name] = assignmentNode.Node;
                }
            }

            Var<T> existing = constantsCache[value] as Var<T>;
            if (existing == null)
                throw new Exception();
            return existing;
        }

        public Var<T> Const<T>(T value)
        {
            return Const(value, NewName());
        }

        internal SyntaxNode GetConstLiteralNode(IVariable variable)
        {
            constantLiteralNodes.TryGetValue(variable.Name, out var value);
            return value;
        }

        public Var<Action> AddFunction(string functionName, Action<SyntaxBuilder> b)
        {
            return this.AddFunction<Action>(b, functionName);
        }

        public Var<Func<TResult>> AddFunction<TResult>(string functionName, Func<SyntaxBuilder, Var<TResult>> b)
        {
            return this.AddFunction<Func<TResult>>(b, functionName);
        }

        /// <summary>
        /// Calls a defined action
        /// </summary>
        /// <param name="action"></param>
        public void Call(Var<Action> action)
        {
            this.Module.Nodes.Add(new SyntaxNode() { Call = new CallNode() { Fn = new SyntaxNode() { Identifier = new IdentifierNode() { Name = action.Name } } } });
        }

        /// <summary>
        /// Calls an anonymous action directly in the module root scope
        /// </summary>
        /// <param name="action"></param>
        public void Call(Action<SyntaxBuilder> action)
        {
            SyntaxBuilder b = new SyntaxBuilder(this);
            action(b);
            this.Module.Nodes.AddRange(b.nodes);
        }

        public static Module New(Action<ModuleBuilder> build)
        {
            var builder = new ModuleBuilder();
            build(builder);
            return builder.Module;
        }
    }
}

