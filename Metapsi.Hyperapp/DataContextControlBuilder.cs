using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp;

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