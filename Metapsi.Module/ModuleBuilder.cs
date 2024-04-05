using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Metapsi.Syntax
{
    public class ModuleBuilder
    {
        private Dictionary<string, IFunction> functionsCache = new();
        private Dictionary<object, IVariable> constantsCache = new();

        private Dictionary<string, IVariable> expressionsCache = new();

        public static List<Type> ScalarTypes = new List<Type>() { typeof(string), typeof(int), typeof(bool), typeof(Guid) };

        public ModuleBuilder()
        {
            this.Module = new Module();
        }

        public Module Module { get; set; }

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
            var parentSegment = string.Join('_', parentTypes.ToArray().Reverse());

            // Add parameters count because C# supports method overloading
            return $"{parentSegment}_{methodInfo.Name}_{methodInfo.GetParameters().Count() - 1}";// All start with SyntaxBuilder, skip that
        }

        // Module actions

        public Var<Action> Define(string actionName, System.Action<SyntaxBuilder> builder)
        {
            return DefineAction(actionName, builder).As<Action>();
        }

        public Var<Action<P1>> Define<P1>(string actionName, System.Action<SyntaxBuilder, Var<P1>> builder)
        {
            return DefineAction(actionName, builder).As<Action<P1>>();
        }

        // Module functions

        public Var<Func<TOut>> Define<TOut>(string funcName, System.Func<SyntaxBuilder, Var<TOut>> builder)
        {
            return DefineFunc(funcName, builder).As<Func<TOut>>();
        }

        public Var<Func<P1, TOut>> Define<P1, TOut>(string funcName, System.Func<SyntaxBuilder, Var<P1>, Var<TOut>> builder)
        {
            return DefineFunc(funcName, builder).As<Func<P1, TOut>>();
        }

        internal IVariable DefineFunc<TDelegate>(string functionName, TDelegate builder)
            where TDelegate : Delegate
        {
            var func = new Function<TDelegate>() { Name = functionName };
            this.AddFunction(func);
            BuildBody(func, builder);
            return MakeVar(func.Name, ClientFuncType(builder));
        }

        internal IVariable DefineAction<TDelegate>(string actionName, TDelegate builder)
            where TDelegate : Delegate
        {
            var action = new Function<TDelegate>() { Name = actionName };
            this.AddFunction(action);
            BuildBody(action, builder);
            return MakeVar(action.Name, ClientActionType(builder));
        }

        public IVariable MakeVar(string name, Type type)
        {
            var varType = typeof(Var<>).MakeGenericType(type);
            return Activator.CreateInstance(varType, new object[] { name }) as IVariable;
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

        public void BuildBody(IFunction function, Delegate builder)
        {
            var parameters = builder.Method.GetParameters();
            foreach (var parameter in parameters.Skip(1))
            {
                var parameterVariable = Activator.CreateInstance(parameter.ParameterType, new object[] { parameter.Name });
                function.Parameters.Add(parameterVariable as IVariable);
            }

            SyntaxBuilder b = Activator.CreateInstance(builder.GetType().GenericTypeArguments.First()) as SyntaxBuilder;
            b.blockBuilder = new BlockBuilder(this, function.ChildBlock);

            List<object> arguments = new List<object> { b };

            arguments.AddRange(function.Parameters);

            var result = builder.DynamicInvoke(arguments.ToArray());
            if (result != null)
            {
                function.ReturnVariable = result as IVariable;
            }
        }

        public IVariable AddExpression<T>(T expression)
        {
            var s = expression.ToString();
            if (!expressionsCache.ContainsKey(s))
            {
                Var<T> c = new Var<T>(NewName());
                Module.Consts.Add(new Constant()
                {
                    Name = c.Name,
                    Value = expression
                });
                expressionsCache[s] = c;
            }

            return expressionsCache[s];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="function"></param>
        /// <returns>True if added, false if already defined</returns>
        public bool AddFunction(IFunction function)
        {
            if (!functionsCache.ContainsKey(function.Name))
            {
                Module.Functions.Add(function);
                functionsCache[function.Name] = function;
                return true;
            }

            return false;
        }

        public Var<T> Const<T>(T value, string name)
        {
            if (!this.constantsCache.ContainsKey(value))
            {
                Var<T> c = new Var<T>(name);
                Module.Consts.Add(new Constant()
                {
                    Name = c.Name,
                    Value = value
                });
                constantsCache[value] = c;
            }

            return new Var<T>(constantsCache[value].Name);
        }

        public Var<T> Const<T>(T value)
        {
            return Const(value, NewName());
        }

        //public Const<T> Const<T>(T value)
        //{
        //    IConstant c = null;
        //    if (value is IFunction)
        //    {
        //        string functionName = (value as IFunction).Name;
        //        c = Module.Constants.SingleOrDefault(x => x.Name == functionName);
        //        if (c == null)
        //        {
        //            c = new Const<T>() { Name = functionName, Value = value };
        //            Module.Constants.Add(c);
        //        }
        //    }
        //    else
        //    {
        //        c = Module.Constants.SingleOrDefault(x => x.Value.Equals(value));
        //        if (c == null)
        //        {
        //            c = new Const<T>()
        //            {
        //                Name = NewName(),
        //                Value = value
        //            };
        //            Module.Constants.Add(c);
        //        }
        //    }

        //    return c as Const<T>;
        //}

        public IVariable AddImport(string module, string symbol)
        {
            Import import = new Import(module, symbol);
            Module.Imports.Add(import);

            return new Var<object>(symbol);
        }
    }

}

