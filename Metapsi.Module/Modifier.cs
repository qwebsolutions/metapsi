using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    // TODO: Remove, replace with PropsBuilder

    /// <summary>
    /// 
    /// </summary>
    public class Modifier<T>
    {
        internal readonly SyntaxBuilder b;
        internal readonly Var<T> var;

        public Modifier(SyntaxBuilder b, Var<T> var)
        {
            this.b = b;
            this.var = var;
        }

        public Var<TResult> Get<TResult>(Expression<Func<T, TResult>> expression)
        {
            return b.Get(var, expression);
        }

        public void Set<TProp>(Expression<Func<T, TProp>> expr, Var<TProp> value)
        {
            b.Set(var, expr, value);
        }

        public void Set<TProp>(Expression<Func<T, TProp>> expr, TProp value)
        {
            b.Set(var, expr, b.Const(value));
        }

        public void Update<TProp>(Expression<Func<T, TProp>> expr, Action<Modifier<TProp>> update) where TProp : new()
        {
            var item = b.Get(var, expr);
            b.If(
                b.IsNull(item),
                b => b.Set(var, expr, b.NewObj<TProp>(update)),
                b => update(new Modifier<TProp>(b, item)));
        }

        public void Update(System.Action<Modifier<T>> update)
        {
            if (update != null)
            {
                update(new Modifier<T>(b, var));
            }
        }

        public Var<TConst> Const<TConst>(TConst constant)
        {
            return b.blockBuilder.ModuleBuilder.Const(constant);
        }

        public Var<bool> Not(Var<bool> var) => b.Not(var);
    }

    public static class ListModifier
    {
        public static void Add<T>(this Modifier<List<T>> on, Action<Modifier<T>> update) where T : new()
        {
            var newItem = on.b.NewObj<T>();
            on.b.Push(on.var, newItem);
            update(new Modifier<T>(on.b, newItem));
        }
    }
}