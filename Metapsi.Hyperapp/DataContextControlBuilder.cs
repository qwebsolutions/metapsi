using Metapsi.Syntax;
using Microsoft.AspNetCore.HttpLogging;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp;

public class BindingContext<TPageModel, TSubmodel, TBoundObject>
{
    public List<Action<BlockBuilder, Var<DataContext<TPageModel, TSubmodel>>, Var<TBoundObject>>> BindingActions { get; set; } = new();
}

public class DataContextControlBuilder<TPageModel, TContext, TProps>
{
    public DataContextControlBuilder(Var<DataContext<TPageModel, TContext>> context)
    {
        this.Context = context;
    }

    public Var<DataContext<TPageModel, TContext>> Context { get; set; }

    public List<Action<BlockBuilder, Var<TProps>>> PropsBuilderActions { get; set; } = new();
    public List<Action<BlockBuilder, Var<HyperNode>>> ControlBuilderActions { get; set; } = new();
}

public class ControlBuilder<TProps>
{
    public List<Action<BlockBuilder, Var<TProps>>> PropsBuilderActions { get; set; } = new();
    public List<Action<BlockBuilder, Var<HyperNode>>> ControlBuilderActions { get; set; } = new();
}

public static class DataContextControlBuilderExtensions
{
    public static Var<HyperNode> BuildControl<TPageModel, TDataModel, TControlProps>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TDataModel>> dataContext,
        Action<DataContextControlBuilder<TPageModel, TDataModel, TControlProps>> builder,
        Func<BlockBuilder, Var<TControlProps>, Var<HyperNode>> controlConstructor)
        where TControlProps : new()
    {
        var controlBuilder = new DataContextControlBuilder<TPageModel, TDataModel, TControlProps>(dataContext);
        builder(controlBuilder);

        var props = b.NewObj<TControlProps>();
        foreach (var propAction in controlBuilder.PropsBuilderActions)
        {
            propAction(b, props);
        }

        var control = controlConstructor(b, props);

        foreach (var controlAction in controlBuilder.ControlBuilderActions)
        {
            controlAction(b, control);
        }

        return control;
    }

    public static Var<HyperNode> BuildControl<TProps>(
        this BlockBuilder b,
        Var<string> tag,
        Var<TProps> props)
    {
        return b.H(tag, b.ToDynamicProps(props));
    }

    public static Var<HyperNode> BuildControl<TProps>(
        this BlockBuilder b,
        Var<string> tag,
        Action<BlockBuilder, Var<TProps>> buildProps)
        where TProps : new()
    {
        var props = b.NewObj<TProps>();
        buildProps(b, props);
        return b.BuildControl(tag, props);
    }


    public static Var<DynamicObject> ToDynamicProps<T>(this BlockBuilder b, Var<T> props)
    {
        var outProps = b.NewObj<DynamicObject>();
        var publicProperties = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        foreach (var property in publicProperties)
        {
            var inPropertyName = property.Name;
            var outPropertyName = inPropertyName.ToLowerInvariant();

            var propertyType = property.PropertyType;

            if (propertyType.IsEnum)
            {
                throw new NotImplementedException();
            }
            else
            {
                b.SetDynamic(outProps, new DynamicProperty<object>(outPropertyName), b.GetDynamic(props, new DynamicProperty<object>(inPropertyName)));
            }
        }

        return outProps;
    }

    public static Var<HyperNode> BuildControl<TProps>(
        this BlockBuilder b,
        Action<ControlBuilder<TProps>> builder,
        Func<BlockBuilder, Var<TProps>, Var<HyperNode>> controlConstructor)
        where TProps : new()
    {
        var controlBuilder = new ControlBuilder<TProps>();
        builder(controlBuilder);

        var props = b.NewObj<TProps>();
        foreach (var propAction in controlBuilder.PropsBuilderActions)
        {
            propAction(b, props);
        }

        var control = controlConstructor(b, props);

        foreach (var controlAction in controlBuilder.ControlBuilderActions)
        {
            controlAction(b, control);
        }

        return control;
    }

    public static void BindInput<TPageModel, TContext, TControlProps, TProperty>(
        this DataContextControlBuilder<TPageModel, TContext, TControlProps> builder,
        System.Linq.Expressions.Expression<Func<TControlProps, TProperty>> objectProperty,
        System.Linq.Expressions.Expression<Func<TContext, TProperty>> contextProperty)
    {
        Action<BlockBuilder, Var<TControlProps>> propertyAction = (b, props) =>
        {
            var propertyValue = b.Get(b.Get(builder.Context, x => x.InputData), contextProperty);
            b.Set(props, objectProperty, propertyValue);
        };
        builder.PropsBuilderActions.Add(propertyAction);
    }
}