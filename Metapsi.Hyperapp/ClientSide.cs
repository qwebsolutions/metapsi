using Metapsi.Syntax;
using Metapsi.Ui;
using System;

namespace Metapsi.Hyperapp;

public class ClientSide
{
    public static HtmlTag Create<TDataModel>(
        TDataModel model,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render = null,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null,
        System.Action<DocumentTag, IHtmlElement, Module> onModuleAttached  = null)
    {
        var mountDivId = $"id_{Guid.NewGuid()}";
        var appContainer = new DivTag().SetAttribute("id", mountDivId);

        var hyperApp = new HyperAppNode<TDataModel>()
        {
            Model = model,
            Init = init,
            Render = render,
            TakeoverNode = appContainer,
            OnModuleAttached = onModuleAttached
        };

        appContainer.AddChild(hyperApp);

        return appContainer;
    }
}


public static class HyperappNodeExtensions
{
    public static void AddClientSide<TDataModel>(
        this HtmlTag parentNode,
        TDataModel model,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render = null,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null,
        System.Action<DocumentTag, IHtmlElement, Module> onModuleAttached = null)
    {
        parentNode.AddChild(ClientSide.Create(model, render, init));
    }
}

