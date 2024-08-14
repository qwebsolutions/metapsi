using Metapsi.Syntax;
using System;

public class PropsBuilder<TProps> : SyntaxBuilder
{
    public Var<TProps> Props { get; set; }

    public override void InitializeFrom(SyntaxBuilder parent)
    {
        base.InitializeFrom(parent);

        if (parent is PropsBuilder<TProps>)
        {
            this.Props = ((PropsBuilder<TProps>)parent).Props;
        }
    }
}

public static class PropsBuilderExtensions
{
    public static Var<T> SetProps<T>(this SyntaxBuilder b, IVariable obj, Action<PropsBuilder<T>> setProps)
    {
        var propsBuilder = new PropsBuilder<T>();
        propsBuilder.InitializeFrom(b);
        propsBuilder.Props = obj.As<T>();
        if (setProps != null)
        {
            setProps(propsBuilder);
        }
        return propsBuilder.Props;
    }

    public static Var<T> NewObj<T>(this SyntaxBuilder b, Action<PropsBuilder<T>> setProps)
        where T : new()
    {
        var propsBuilder = new PropsBuilder<T>();
        propsBuilder.InitializeFrom(b);
        propsBuilder.Props = b.NewObj<T>();
        if (setProps != null)
        {
            setProps(propsBuilder);
        }
        return propsBuilder.Props;
    }

    public static void Set<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> onProperty, Var<TValue> value)
    {
        b.Set(b.Props, onProperty, value);
    }

    public static void Set<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> onProperty, TValue value)
    {
        b.Set(onProperty, b.Const(value));
    }

    public static Var<TValue> Get<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> property)
    {
        return b.Get(b.Props, property);
    }

    public static void SetIfExists<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> onProperty, Var<TValue> value)
    {
        b.If(b.HasObject(value), b => b.Set(onProperty, value));
    }

    public static void AddProps<T>(this PropsBuilder<T> b, System.Action<PropsBuilder<T>> setProps)
    {
        if (setProps != null)
            setProps(b);
    }
}