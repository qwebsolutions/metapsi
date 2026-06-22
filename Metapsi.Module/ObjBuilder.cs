using System;
using System.Collections.Generic;

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

        public ObjBuilder<TOut> Call<TOut>(string methodName, params IVariable[] parameters)
        {
            var result = this.CallOnObject<TOut>(this, methodName, parameters);
            // It seems this MUST receive the nodes as parameters, because it chains the calls into the syntax block
            return new ObjBuilder<TOut>(this.moduleBuilder, this.nodes, result);
        }

        public void Call(string methodName, params IVariable[] parameters)
        {
            this.CallOnObject(this, methodName, parameters);
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
            return this.moduleBuilder.Resolver.ResolvePath(resource);
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
            var onObject = b.Construct<T>(b, args);
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