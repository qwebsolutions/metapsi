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
    public class ObjBuilder<T> : Var<T>, IObjBuilder
    {
        private readonly ModuleBuilder moduleBuilder;
        private readonly List<SyntaxNode> nodes;

        public ObjBuilder(ModuleBuilder moduleBuilder, IVariable var)
        {
            this.moduleBuilder = moduleBuilder;
            this.nodes = new List<SyntaxNode>();
            this.Name = var.Name;
        }

        ModuleBuilder ISyntaxBuilder.ModuleBuilder => this.moduleBuilder;

        List<SyntaxNode> ISyntaxBuilder.Nodes => this.nodes;

        public ObjBuilder<TOut> Call<TOut>(string methodName, params IVariable[] parameters)
        {
            return new ObjBuilder<TOut>(this.moduleBuilder, this.CallOnObject<TOut>(this, methodName, parameters));
        }

        public void Call(string methodName, params IVariable[] parameters)
        {
            this.CallOnObject(this, methodName, parameters);
        }

        public ObjBuilder<TOut> Get<TOut>(string property)
        {
            return new ObjBuilder<TOut>(this.moduleBuilder, this.GetProperty<TOut>(this, property));
        }

        public ObjBuilder<TOut> Get<TOut>(System.Linq.Expressions.Expression<Func<T, TOut>> property)
        {
            return this.Get<TOut>(property.PropertyName());
        }
    }

    public static class ObjectBuilderExtensions
    {
        public static Var<TOut> On<TIn, TOut>(this ISyntaxBuilder b, Var<TIn> input, Func<ObjBuilder<TIn>, Var<TOut>> transform)
        {
            var result = transform(new ObjBuilder<TIn>((b as ISyntaxBuilder).ModuleBuilder, input));
            return result;
        }

        public static Var<TOut> On<TIn, TOut>(this ISyntaxBuilder b, Var<TIn> input, Func<ObjBuilder<TIn>, ObjBuilder<TOut>> transform)
        {
            var result = transform(new ObjBuilder<TIn>((b as ISyntaxBuilder).ModuleBuilder, input));
            return result;
        }

        public static void On<TIn>(this ISyntaxBuilder b, Var<TIn> input, Action<ObjBuilder<TIn>> call)
        {
            call(new ObjBuilder<TIn>((b as ISyntaxBuilder).ModuleBuilder, input));
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
            return new ObjBuilder<T>((b as ISyntaxBuilder).ModuleBuilder, b.Construct<T>(b, args));
        }
    }
}