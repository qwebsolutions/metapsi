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
            return $"{parentSegment}_{methodInfo.Name}_{methodInfo.GetParameters().Count() - 1}";// All start with BlockBuilder, skip that
        }

        //public IVariable Define<TFunc>(TFunc builder) where TFunc : Delegate
        //{
        //    return Define(QualifiedName(builder.Method), builder);
        //}

        public Var<Action> Define(string functionName, System.Action<BlockBuilder> builder)
        {
            var action = new Function<Action>() { Name = functionName };
            this.AddFunction(action);
            BuildActionBody(action, builder);
            return new(action.Name);
        }

        public Var<Action> Define<P1>(string functionName, System.Action<BlockBuilder, Var<P1>> builder)
        {
            var action = new Function<Action>() { Name = functionName };
            this.AddFunction(action);
            BuildActionBody(action, builder);
            return new(action.Name);
        }

        public Var<Func<P1, TOut>> Define<P1, TOut>(string functionName, System.Func<BlockBuilder, Var<P1>, Var<TOut>> builder)
        {
            var func = new Function<Func<P1, TOut>>() { Name = functionName };
            this.AddFunction(func);
            BuildFuncBody(func, builder);
            return new(func.Name);
        }

        ////Referinte
        ////Obiecte? Serializabile
        ////Functii? Buildere
        //Astea "constante", dar îs referințe in sine. nu au nume
        //    Variabilele sunt o asociere nume-constanta
        //    sau nume -> .. ce? nume si atâta

        // de fapt builder-ul ar trebui să stocheze sursele
        // ca o formă de caching?
        // si modulul să aiba direct obiectele de sintaxă

        private void AddParameters(IFunction function, params IVariable[] parameters)
        {
            function.Parameters.AddRange(parameters);
        }

        public void BuildActionBody(IFunction function, System.Action<BlockBuilder> builder)
        {
            builder(new BlockBuilder(this, function.ChildBlock));
        }

        public void BuildActionBody<P1>(IFunction function, System.Action<BlockBuilder, Var<P1>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            AddParameters(function, p1);
            builder(new BlockBuilder(this, function.ChildBlock), p1);
        }

        public void BuildActionBody<P1, P2>(IFunction function, System.Action<BlockBuilder, Var<P1>, Var<P2>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            var p2 = new Var<P2>(parameters[2].Name);
            AddParameters(function, p1, p2);
            builder(new BlockBuilder(this, function.ChildBlock), p1, p2);
        }

        public void BuildActionBody<P1, P2, P3>(IFunction function, System.Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            var p2 = new Var<P2>(parameters[2].Name);
            var p3 = new Var<P3>(parameters[3].Name);
            AddParameters(function, p1, p2, p3);
            builder(new BlockBuilder(this, function.ChildBlock), p1, p2, p3);
        }

        public void BuildActionBody<P1, P2, P3, P4>(IFunction function, System.Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            var p2 = new Var<P2>(parameters[2].Name);
            var p3 = new Var<P3>(parameters[3].Name);
            var p4 = new Var<P4>(parameters[4].Name);
            AddParameters(function, p1, p2, p3, p4);
            builder(new BlockBuilder(this, function.ChildBlock), p1, p2, p3, p4);
        }


        public void BuildFuncBody<TOut>(IFunction function, System.Func<BlockBuilder, Var<TOut>> builder)
        {
            function.ReturnVariable = builder(new BlockBuilder(this, function.ChildBlock));
        }

        public void BuildFuncBody<P1, TOut>(IFunction function, System.Func<BlockBuilder, Var<P1>, Var<TOut>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            AddParameters(function, p1);
            function.ReturnVariable = builder(new BlockBuilder(this, function.ChildBlock), p1);
        }

        public void BuildFuncBody<P1, P2, TOut>(IFunction function, System.Func<BlockBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            var p2 = new Var<P2>(parameters[2].Name);
            AddParameters(function, p1, p2);
            function.ReturnVariable = builder(new BlockBuilder(this, function.ChildBlock), p1, p2);
        }

        public void BuildFuncBody<P1, P2, P3, TOut>(IFunction function, System.Func<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            var p2 = new Var<P2>(parameters[2].Name);
            var p3 = new Var<P3>(parameters[3].Name);
            AddParameters(function, p1, p2, p3);
            function.ReturnVariable = builder(new BlockBuilder(this, function.ChildBlock), p1, p2, p3);
        }

        public void BuildFuncBody<P1, P2, P3, P4, TOut>(IFunction function, System.Func<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> builder)
        {
            var parameters = builder.Method.GetParameters();
            var p1 = new Var<P1>(parameters[1].Name);
            var p2 = new Var<P2>(parameters[2].Name);
            var p3 = new Var<P3>(parameters[3].Name);
            var p4 = new Var<P4>(parameters[4].Name);
            AddParameters(function, p1, p2, p3, p4);
            function.ReturnVariable = builder(new BlockBuilder(this, function.ChildBlock), p1, p2, p3, p4);
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

        public IVariable AddFunction(IFunction function)
        {
            if(!functionsCache.ContainsKey(function.Name))
            {
                Module.Functions.Add(function);
                functionsCache[function.Name] = function;
            }

            return new Var<object>(function.Name);
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

