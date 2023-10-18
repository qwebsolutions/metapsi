using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp;

public class BindingContext<TPageModel, TSubmodel, TBoundObject>
{
    public List<Action<BlockBuilder, Var<DataContext<TPageModel, TSubmodel>>, Var<TBoundObject>>> BindingActions { get; set; } = new();
}

public static class BindingContextExtensions
{
    public static void Add<TPageModel, TSubmodel, TBoundObject>(
        this BindingContext<TPageModel, TSubmodel, TBoundObject> bindingContext,
        Action<BlockBuilder, Var<DataContext<TPageModel, TSubmodel>>, Var<TBoundObject>> bindingAction)
    {
        bindingContext.BindingActions.Add(bindingAction);
    }

    public static void InBindingContext<TPageModel, TLocalModel, TBoundObject>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TLocalModel>> dataContext,
        Var<TBoundObject> boundObject,
        Action<BindingContext<TPageModel, TLocalModel, TBoundObject>> bindingAction)
    {
        BindingContext<TPageModel, TLocalModel, TBoundObject> bindingContext = new();
        bindingAction(bindingContext);

        foreach (var builderAction in bindingContext.BindingActions)
        {
            builderAction(b, dataContext, boundObject);
        }
    }
}