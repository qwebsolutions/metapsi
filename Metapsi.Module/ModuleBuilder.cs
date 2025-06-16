﻿using System;
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
        private Dictionary<object, IVariable> constantsCache = new Dictionary<object, IVariable>();

        private Dictionary<string, IVariable> expressionsCache = new Dictionary<string, IVariable>();

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

        //// Module actions

        //public Var<Action> Define(string actionName, System.Action<SyntaxBuilder> builder)
        //{
        //    return DefineAction(actionName, builder).As<Action>();
        //}

        //public Var<Action<P1>> Define<P1>(string actionName, System.Action<SyntaxBuilder, Var<P1>> builder)
        //{
        //    return DefineAction(actionName, builder).As<Action<P1>>();
        //}

        //public Var<Action<P1, P2>> Define<P1, P2>(string actionName, System.Action<SyntaxBuilder, Var<P1>, Var<P2>> builder)
        //{
        //    return DefineAction(actionName, builder).As<Action<P1, P2>>();
        //}

        //// Module functions

        //public Var<Func<TOut>> Define<TOut>(string funcName, System.Func<SyntaxBuilder, Var<TOut>> builder)
        //{
        //    return DefineFunc(funcName, builder).As<Func<TOut>>();
        //}

        //public Var<Func<P1, TOut>> Define<P1, TOut>(string funcName, System.Func<SyntaxBuilder, Var<P1>, Var<TOut>> builder)
        //{
        //    return DefineFunc(funcName, builder).As<Func<P1, TOut>>();
        //}

        //public Var<Func<P1, P2, TOut>> Define<P1, P2, TOut>(string funcName, System.Func<SyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
        //{
        //    return DefineFunc(funcName, builder).As<Func<P1, P2, TOut>>();
        //}

        //public Var<Func<P1, TOut>> Define<TSyntaxBuilder, P1, TOut>(string funcName, System.Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder)
        //    where TSyntaxBuilder : SyntaxBuilder
        //{
        //    return DefineFunc(funcName, builder).As<Func<P1, TOut>>();
        //}

        //public IVariable DefineFunc<TDelegate>(string functionName, TDelegate builder)
        //    where TDelegate : Delegate
        //{
        //    var func = new Function<TDelegate>() { Name = functionName };
        //    this.AddFunction(func);
        //    BuildBody(func, builder);
        //    return MakeVar(func.Name, ClientFuncType(builder));
        //}

        //public IVariable DefineAction<TDelegate>(string actionName, TDelegate builder)
        //    where TDelegate : Delegate
        //{
        //    var action = new Function<TDelegate>() { Name = actionName };
        //    this.AddFunction(action);
        //    BuildBody(action, builder);
        //    return MakeVar(action.Name, ClientActionType(builder));
        //}

        //public IVariable MakeVar(string name, Type type)
        //{
        //    var varType = typeof(Var<>).MakeGenericType(type);
        //    return Activator.CreateInstance(varType, new object[] { name }) as IVariable;
        //}

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

        //public void BuildBody(IFunction function, Delegate builder)
        //{
        //    var parameters = builder.Method.GetParameters();
        //    foreach (var parameter in parameters.Skip(1))
        //    {
        //        var parameterVariable = Activator.CreateInstance(parameter.ParameterType, new object[] { parameter.Name });
        //        function.Parameters.Add(parameterVariable as IVariable);
        //    }

        //    SyntaxBuilder b = Activator.CreateInstance(builder.GetType().GenericTypeArguments.First()) as SyntaxBuilder;
        //    b.blockBuilder = new BlockBuilder(this, function.ChildBlock);

        //    List<object> arguments = new List<object> { b };

        //    arguments.AddRange(function.Parameters);

        //    var result = builder.DynamicInvoke(arguments.ToArray());
        //    if (result != null)
        //    {
        //        function.ReturnVariable = result as IVariable;
        //    }
        //}

        public IVariable AddExpression<T>(System.Linq.Expressions.LambdaExpression expression)
        {
            var s = expression.ToString();
            if (!expressionsCache.ContainsKey(s))
            {
                Var<T> c = new Var<T>(NewName());
                Module.Nodes.Add(new AssignmentNode()
                {
                    Name = c.Name,
                    Node = LinqNodeExtensions.FromLambda(expression)
                });
                expressionsCache[s] = c;
            }

            return expressionsCache[s];
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

                Module.Nodes.Add(new AssignmentNode()
                {
                    Name = name,
                    Node = FnNodeExtensions.FromDelegate(new SyntaxBuilder(this), function)
                });
            }

            return new Var<T>(name);
        }

        public Var<T> Const<T>(T value, string name)
        {
            if (!this.constantsCache.ContainsKey(value))
            {
                Var<T> c = new Var<T>(name);
                Module.Nodes.Add(new AssignmentNode()
                {
                    Name = name,
                    Node = new LiteralNode()
                    {
                        Value = System.Text.Json.JsonSerializer.Serialize(value)
                    }
                });
                constantsCache[value] = c;
            }

            return new Var<T>(constantsCache[value].Name);
        }

        public Var<T> Const<T>(T value)
        {
            return Const(value, NewName());
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
            this.Module.Nodes.Add(new CallNode() { Fn = new IdentifierNode() { Name = action.Name } });
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

