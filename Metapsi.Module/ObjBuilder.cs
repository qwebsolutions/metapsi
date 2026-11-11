using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Metapsi.Syntax
{
    /// <summary>
    /// Points to the class definition of T, allowing access to constructor and static properties/methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ClassDef<T>
    {

    }

    public interface IObjBuilder : ISyntaxBuilder
    {
    }

    /// <summary>
    /// Wraps a specific object for property and method access. Does not allow creating new blocks (branching, loops)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjBuilder<T> : Var<T>, IObjBuilder, IClientVar
    {
        private readonly ModuleBuilder moduleBuilder;
        private readonly List<SyntaxNode> nodes;

        public ObjBuilder(ModuleBuilder moduleBuilder, List<SyntaxNode> nodes, IVariable var)
        {
            this.moduleBuilder = moduleBuilder;
            this.nodes = nodes;
            (this as IClientVar).Name = (var as IClientVar).Name;
        }

        ModuleBuilder ISyntaxBuilder.ModuleBuilder => this.moduleBuilder;

        string IClientVar.Name { get; set; }

        public ObjBuilder<TOut> Call<TOut>(string methodName, Var<CallArguments> args)
        {
            var result = Core.Call<TOut>(this, this.NewObj<MethodCallArguments>(b =>
            {
                b.Set(x => x.OnObject, this.As<object>());
                b.Set(x => x.FunctionName, b.Const(methodName));
                b.Set(x => x.Fixed, b.Get(args, x => x.Fixed));
                b.Set(x => x.Rest, b.Get(args, x => x.Rest));
            }));
            return new ObjBuilder<TOut>(this.moduleBuilder, this.nodes, result);
        }

        public ObjBuilder<TOut> Call<TOut>(string methodName, params IVariable[] parameters)
        {
            return this.Call<TOut>(methodName, this.NewObj<CallArguments>(b =>
            {
                b.SetFixed(parameters);
            }));
        }

        public void Call(string methodName, params IVariable[] parameters)
        {
            this.Call<object>(methodName, this.NewObj<CallArguments>(b =>
            {
                b.SetFixed(parameters);
            }));
        }

        public void Call(string methodName, Var<CallArguments> args)
        {
            this.Call<object>(methodName, args);
        }

        /// <summary>
        /// Invokes the current object itself as a function
        /// </summary>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        public ObjBuilder<TOut> Invoke<TOut>(Var<CallArguments> args)
        {
            var result = Core.Call<TOut>(this, this.NewObj<FunctionCallArguments>(b =>
            {
                b.Set(x => x.FunctionReference, this.As<Delegate>());
                b.Set(x => x.Fixed, b.Get(args, x => x.Fixed));
                b.Set(x => x.Rest, b.Get(args, x => x.Rest));
            }));
            return new ObjBuilder<TOut>(this.moduleBuilder, this.nodes, result);
        }

        public ObjBuilder<TOut> Invoke<TOut>(params IVariable[] args)
        {
            return this.Invoke<TOut>(this.NewObj<CallArguments>(b =>
            {
                b.SetFixed(args);
            }));
        }

        public void Invoke(Var<CallArguments> args)
        {
            this.Invoke<object>(args);
        }

        public void Invoke(params IVariable[] args)
        {
            this.Invoke(this.NewObj<CallArguments>(b =>
            {
                b.SetFixed(args);
            }));
        }

        public ObjBuilder<TOut> Get<TOut>(string property)
        {
            return new ObjBuilder<TOut>(this.moduleBuilder, this.nodes, this.GetProperty<TOut>(this, property));
        }

        public ObjBuilder<TOut> Get<TOut>(System.Linq.Expressions.Expression<Func<T, TOut>> property)
        {
            return this.Get<TOut>(property.PropertyName());
        }

        public string ResolvePath(IResource resource)
        {
            return this.moduleBuilder.ResourcePathResolver.ResolvePath(resource);
        }

        void ISyntaxBuilder.AddSyntaxNode(SyntaxNode syntaxNode)
        {
            this.nodes.Add(syntaxNode);
        }

        List<SyntaxNode> ISyntaxBuilder.GetNodes()
        {
            return this.nodes;
        }

        public void SetProperty<TProp>(Var<string> propertyName, Var<TProp> value)
        {
            this.SetProperty(this, propertyName, value);
        }
    }

    public static class ObjectBuilderExtensions
    {
        public static Var<TOut> On<TIn, TOut>(this ISyntaxBuilder b, Var<TIn> input, Func<ObjBuilder<TIn>, Var<TOut>> transform)
        {
            var objBuilder = new ObjBuilder<TIn>(b.ModuleBuilder, b.GetNodes(), input);
            var result = transform(objBuilder);
            return result;
        }

        public static Var<TOut> On<TIn, TOut>(this ISyntaxBuilder b, Var<TIn> input, Func<ObjBuilder<TIn>, ObjBuilder<TOut>> transform)
        {
            var objBuilder = new ObjBuilder<TIn>(b.ModuleBuilder, b.GetNodes(), input);
            var result = transform(objBuilder);
            return result;
        }

        public static void On<TIn>(this ISyntaxBuilder b, Var<TIn> input, Action<ObjBuilder<TIn>> call)
        {
            var objBuilder = new ObjBuilder<TIn>(b.ModuleBuilder, b.GetNodes(), input);
            call(objBuilder);
        }

        /// <summary>
        /// Call new operator on this class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static ObjBuilder<T> Construct<T>(this ObjBuilder<ClassDef<T>> b, params IVariable[] args)
        {
            return b.Construct(b.NewObj<CallArguments>(b =>
            {
                b.SetFixed(args);
            }));
        }

        public static ObjBuilder<T> Construct<T>(this ObjBuilder<ClassDef<T>> b, Var<CallArguments> args)
        {
            var classRef = b.As<object>();
            var onObject = Core.Construct<T>(b, b.NewObj<ConstructArguments>(
                b =>
                {
                    b.Set(x => x.Class, classRef);
                    b.Set(x => x.Fixed, b.Get(args, x => x.Fixed));
                    b.Set(x => x.Rest, b.Get(args, x => x.Rest));
                }));
            var objBuilder = new ObjBuilder<T>((b as ISyntaxBuilder).ModuleBuilder, (b as ISyntaxBuilder).GetNodes(), onObject);
            return objBuilder;
        }

        public static void Set<T, TItem>(this ObjBuilder<T> b, System.Linq.Expressions.Expression<Func<T, TItem>> expression, Var<TItem> item)
        {
            b.Set(b, expression, item);
        }

        public static void Set<T, TItem>(this ObjBuilder<T> b, System.Linq.Expressions.Expression<Func<T, TItem>> expression, TItem item)
        {
            b.Set(b, expression, item);
        }
    }
}