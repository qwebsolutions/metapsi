﻿using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;


public class HomeModel : IHasTreeMenu
{
    public List<Route> Routes { get; set; } = new();
    public List<Doc> Docs { get; set; } = new();
    public bool MenuIsExpanded { get; set; }
}

public class ComponentModel
{
    public string P1 { get; set; }
    public string P2 { get; set; }

    public int count { get; set; }

    public Nested Nested { get; set; } = new();

    public bool SomeBool { get; set; }
}

public class XXXModel : IApiSupportState
{
    public ApiSupport ApiSupport { get; set; } = new();
    public ComponentModel First { get; set; } = new();
    public ComponentModel Second { get; set; } = new();

    public List<ComponentModel> CompList { get; set; } = new();
}

public class Nested
{
    public bool ShowStuff { get; set; }
}

public class XXXHandler : Http.Get<Metapsi.Tutorial.Routes.XXX, string, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string firstParam, string secondParam)
    {
        return Page.Result(new XXXModel()
        {
            First = new()
            {
                P1 = firstParam + "_1",
                P2 = secondParam + "_1"
            },
            Second = new()
            {
                P1 = firstParam + "_2",
                P2 = secondParam + "_2"
            },
            CompList = new List<ComponentModel>()
            {
                new ComponentModel()
                {
                    P1 = "P1_1",
                    P2 = "P2_1"
                },
                new ComponentModel()
                {
                    P1 = "P1_2",
                    P2 = "P2_2"
                }
            }
        });
    }
}

public static class VisibilityExtensions
{
    //public static HyperAppNode<TModel> VisibleIf<TModel>(
    //    this HyperAppNode<TModel> clientSideNode,
    //    System.Linq.Expressions.Expression<Func<TModel, bool>> byProperty)
    //{
    //    var initialRender = clientSideNode.Render;

    //    clientSideNode.Render = (b, model) =>
    //    {
    //        return b.If(
    //            b.Get(model, byProperty),
    //            b => initialRender(b, model),
    //            b => b.Div());
    //    };

    //    return clientSideNode;
    //}

    public static HyperAppNode<TModel, TComponentModel, TControl> VisibleIf<TModel, TComponentModel, TControl>(
        this HyperAppNode<TModel, TComponentModel, TControl> clientSideNode,
        System.Linq.Expressions.Expression<Func<TModel, TComponentModel>> getComponentModel,
        System.Linq.Expressions.Expression<Func<TComponentModel, bool>> byProperty)
        where TControl : IHtmlElement
    {
        var initialRender = clientSideNode.Render;

        clientSideNode.Render = (b, model) =>
        {
            var componentState = b.Get(model, getComponentModel);

            b.Log(model);
            var v = b.Get(componentState, byProperty);
            b.Log("v", v);

            return b.If(
                b.Get(componentState, byProperty),
                b => initialRender(b, model),
                b => b.Div());
        };

        return clientSideNode;
    }

    //public static Var<HyperNode> ServerToClient(this BlockBuilder b, IHtmlElement tag)
    //{
    //    var node = b.Node(tag.GetTag().Tag);

    //    foreach (var attribute in tag.GetTag().Attributes)
    //    {
    //        b.SetAttr(node, DynamicProperty.String(attribute.Key), attribute.Value);
    //    }

    //    foreach (var child in tag.GetTag().Children)
    //    {
    //        if(child is IHtmlElement)
    //        {
    //            b.Add(node, b.ServerToClient(child as IHtmlElement));
    //        }
    //        if(child is HtmlText)
    //        {
    //            b.Add(node, b.TextNode((child as HtmlText).Text));
    //        }
    //    }

    //    return node;
    //}

    public static Var<HyperNode> ServerToClient<TModel>(this BlockBuilder b, IHtmlElement tag, Var<TModel> model)
    {
        var node = b.Node(tag.GetTag().Tag);

        foreach (var attribute in tag.GetTag().Attributes)
        {
            b.SetAttr(node, DynamicProperty.String(attribute.Key), attribute.Value);
        }

        foreach (var child in tag.GetTag().Children)
        {
            if (child is IHtmlElement)
            {
                b.Add(node, b.ServerToClient<TModel>(child as IHtmlElement, model));
            }
            if (child is HtmlText)
            {
                b.Add(node, b.TextNode((child as HtmlText).Text));
            }

            if (child is IClientSideNode<TModel>)
            {
                IClientSideNode<TModel> clientNode = child as IClientSideNode<TModel>;

                if (!tag.HasAttribute("id", clientNode.TakeoverId))
                {
                    if (!clientNode.AlreadyRendered)
                    {
                        clientNode.AlreadyRendered = true;
                        b.Add(node, clientNode.Render(b, model));
                    }
                }
            }
        }

        return node;
    }
}

public interface IMagicBuilder
{
    List<System.Linq.Expressions.LambdaExpression> ReferencesStack { get; set; }
}

public class MagicBuilder<TModel, TSubmodel> : IMagicBuilder
{
    public List<System.Linq.Expressions.LambdaExpression> ReferencesStack { get; set; } = new();
}

public class RootMagicBuilder<TModel> : IMagicBuilder
{
    public List<System.Linq.Expressions.LambdaExpression> ReferencesStack { get; set; } = new();
}

public class ClientControl
{

}

public class WhatIsThis
{

}

//public class DataContext
//{
//    public ClientControl Control()
//    {

//    }

//    public WhatIsThis Code()
//    {

//    }

//    public DataContext OnProperty()
//    {

//    }

//    public DataContext OnList()
//    {

//    }
//}

//public static class MagicBuilder
//{
//    public static MagicBuilder<TRootModel, TSubmodel> OnSubmodel<TRootModel, TSubmodel>(
//        this RootMagicBuilder<TRootModel> parentBuilder,
//        System.Linq.Expressions.Expression<Func<TRootModel, TSubmodel>> selector)
//    {
//        var subBuilder = new MagicBuilder<TRootModel, TSubmodel>();
//        subBuilder.ReferencesStack = new List<System.Linq.Expressions.LambdaExpression>(parentBuilder.ReferencesStack);
//        subBuilder.ReferencesStack.Add(selector);
//        return subBuilder;
//    }

//    public static MagicBuilder<TModel, TSubmodel> OnProperty<TModel, TParentModel, TSubmodel>(
//        this MagicBuilder<TModel, TParentModel> parentBuilder,
//        System.Linq.Expressions.Expression<Func<TParentModel, TSubmodel>> selector)
//    {
//        var subBuilder = new MagicBuilder<TModel, TSubmodel>();
//        subBuilder.ReferencesStack = new List<System.Linq.Expressions.LambdaExpression>(parentBuilder.ReferencesStack);
//        subBuilder.ReferencesStack.Add(selector);
//        return subBuilder;
//    }

//    public static MagicBuilder<TModel, TItem> OnList<TModel, TParentModel, TItem>(
//        this MagicBuilder<TModel, TParentModel> parentBuilder,
//        System.Linq.Expressions.Expression<Func<TParentModel, List<TItem>>> selector)
//    {
//        var subBuilder = new MagicBuilder<TModel, TItem>();
//        subBuilder.ReferencesStack = new List<System.Linq.Expressions.LambdaExpression>(parentBuilder.ReferencesStack);
//        subBuilder.ReferencesStack.Add(selector);
//        return subBuilder;
//    }


//    public static MagicBuilder<TModel, TModel> Root<TModel>()
//    {
//        var magicBuilder = new MagicBuilder<TModel, TModel>();
//        System.Linq.Expressions.Expression<Func<TModel, TModel>> itself = x => x;
//        magicBuilder.ReferencesStack.Add(itself);
//        return magicBuilder;
//    }
//}

public static class TestInputExtensions
{
    //public static Var<HyperNode> TestInput<TData>(
    //    this BlockBuilder b, 
    //    Var<ItemModelContext<TData>> itemContext,
    //    System.Linq.Expressions.Expression<Func<TData, string>> boundProperty)
    //{
    //    var input = b.Node("input");
    //    b.SetAttr(input, Html.type, "string");
    //    b.SetAttr(input, Html.value, b.Get(b.Get(itemContext, x => x.Item), boundProperty));

    //    b.SetOnInput(input, b.MakeAction((BlockBuilder b, Var<object> model, Var<string> newValue) =>
    //    {
    //        var currentItem = b.Call(b.Get(itemContext, x => x.GetItem), model);
    //        b.Set(currentItem, boundProperty, newValue);
    //        return b.Clone(model);
    //    }));

    //    return input;
    //}

    //public static ClientObjectBuilder<TContext> With<TContext>(this BlockBuilder b, Var<ItemModelContext<TContext>> context)
    //{
    //    return new ClientObjectBuilder<TContext>(context);
    //}

    //public static Var<TResult> With<TContext, TResult>(
    //    this BlockBuilder b,
    //    Var<ItemModelContext<TContext>> context,
    //    System.Func<ClientObjectBuilder<TContext>, ClientObjectBuilder<TContext, TResult>> build)
    //    where TResult : new()
    //{
    //    var builder = build(new ClientObjectBuilder<TContext>(context));
    //    var newObject = b.NewObj<TResult>();
    //    foreach (var binding in builder.BindingFunctions)
    //    {
    //        b.Call(binding, newObject.As<object>());
    //    }

    //    return newObject;
    //}
}

//public class ClientObjectBuilder<TContext>
//{
//    public Var<ItemModelContext<TContext>> Context { get; set; }

//    public ClientObjectBuilder(Var<ItemModelContext<TContext>> context)
//    {
//        this.Context = context;
//    }

//    public ClientObjectBuilder<TContext, T> New<T>()
//    {
//        return new ClientObjectBuilder<TContext, T>(this.Context);
//    }
//}

//public class ContextBinding
//{
//    public System.Linq.Expressions.LambdaExpression ObjectProperty { get; set; }
//    public System.Linq.Expressions.LambdaExpression ContextProperty { get; set; }

//    public Action<BlockBuilder, Var<object>> ApplyInputValue { get; set; }
//    public Action<BlockBuilder, Var<object>> ApplyOutputEvent { get; set; }
//}

//public class ClientObjectBuilder<TContext, TObject>
//{
//    public ClientObjectBuilder(Var<ItemModelContext<TContext>> context)
//    {
//        this.Context = context;
//    }

//    public List<Action<BlockBuilder, Var<object>>> BindingFunctions { get; set; } = new();
//    public List<ContextBinding> Bindings { get; set; } = new();
//    public Var<ItemModelContext<TContext>> Context { get; set; } 

//    /// <summary>
//    /// One-way binding based on model data
//    /// </summary>
//    /// <typeparam name="TProp"></typeparam>
//    /// <param name="objectProperty"></param>
//    /// <param name="contextProperty"></param>
//    /// <returns></returns>
//    public ClientObjectBuilder<TContext, TObject> BindInput<TProp>(
//        System.Linq.Expressions.Expression<Func<TObject, TProp>> objectProperty,
//        System.Linq.Expressions.Expression<Func<TContext, TProp>> contextProperty)
//    {
//        Action<BlockBuilder, Var<object>> applyInputValue = (b, intoObject) =>
//        {
//            var dataItem = b.Get(this.Context, x => x.Item);

//            var contextValue = b.Get<TContext, object>(dataItem, contextProperty);
//            b.Set(intoObject, objectProperty, contextValue);
//        };

//        this.BindingFunctions.Add(applyInputValue);
//        this.Bindings.Add(new ContextBinding()
//        {
//            ContextProperty = contextProperty,
//            ObjectProperty = objectProperty
//        });
//        return this;
//    }
//}

//public interface IHasCheckedBool
//{
//    bool Checked { get; set; }
//}

public class ContextControlBuilder<TPageModel, TContext, TProps>
{
    public ContextControlBuilder(Var<DataContext<TPageModel, TContext>> context)
    {
        this.Context = context;
    }

    public Var<DataContext<TPageModel, TContext>> Context { get; set; }

    public List<Action<BlockBuilder, Var<TProps>>> PropsBuilderActions { get; set; } = new();
    public List<Action<BlockBuilder, Var<HyperNode>>> ControlBuilderActions { get; set; } = new();
}

public static class CheckboxBindingExtensions
{
    //public static ClientObjectBuilder<TContext, TObject> BindChecked<TContext, TObject>(
    //    this ClientObjectBuilder<TContext, TObject> builder,
    //    System.Linq.Expressions.Expression<Func<TContext, bool>> contextProperty)
    //    where TObject : IHasCheckedProperty
    //{
    //    builder.BindInput(x => x.Checked, contextProperty);

    //    Action<BlockBuilder, Var<object>> applyEvent = (BlockBuilder b, Var<object> control) =>
    //    {

    //    };

    //    builder.BindingFunctions.Add(applyEvent);
    //    var plm = builder.Bindings.SingleOrDefault(x => x.ObjectProperty.PropertyName() == nameof(IHasCheckedProperty.Checked));

    //    return builder;

    //    //Action<BlockBuilder, Var<object>, Var<bool>> setter =
    //    //    (BlockBuilder b, Var<object> modelRoot, Var<bool> newValue) =>
    //    //    {
    //    //        var contextEntity = b.Call(b.Get(builder.Context, x => x.GetItem), modelRoot);
    //    //        b.Set(contextEntity, contextProperty, newValue);
    //    //    };




    //    //b.SetOnInput(input, b.MakeAction((BlockBuilder b, Var<object> model, Var<string> newValue) =>
    //    //{
    //    //    var currentItem = b.Call(b.Get(itemContext, x => x.GetItem), model);
    //    //    b.Set(currentItem, boundProperty, newValue);
    //    //    return b.Clone(model);
    //    //}));

    //    //return input;
    //}

    //public static ControlBuilder<TContext, TProps> BindChecked<TContext, TProps>(
    //   this ControlBuilder<TContext, TProps> builder,
    //   System.Linq.Expressions.Expression<Func<TContext, bool>> contextProperty)
    //   where TProps : IHasCheckedProperty
    //{
    //    builder.BindInput(x => x.Checked, contextProperty);

    //    Action<BlockBuilder, Var<object>> applyEvent = (BlockBuilder b, Var<object> control) =>
    //    {

    //    };

    //    builder.BindingFunctions.Add(applyEvent);
    //    var plm = builder.Bindings.SingleOrDefault(x => x.ObjectProperty.PropertyName() == nameof(IHasCheckedProperty.Checked));

    //    return builder;

    //    //Action<BlockBuilder, Var<object>, Var<bool>> setter =
    //    //    (BlockBuilder b, Var<object> modelRoot, Var<bool> newValue) =>
    //    //    {
    //    //        var contextEntity = b.Call(b.Get(builder.Context, x => x.GetItem), modelRoot);
    //    //        b.Set(contextEntity, contextProperty, newValue);
    //    //    };




    //    //b.SetOnInput(input, b.MakeAction((BlockBuilder b, Var<object> model, Var<string> newValue) =>
    //    //{
    //    //    var currentItem = b.Call(b.Get(itemContext, x => x.GetItem), model);
    //    //    b.Set(currentItem, boundProperty, newValue);
    //    //    return b.Clone(model);
    //    //}));

    //    //return input;
    //}

    public static Var<HyperNode> BuildControl<TPageModel, TDataModel, TControlProps>(
        this BlockBuilder b,
        Var<DataContext<TPageModel , TDataModel>> dataContext,
        Action<ContextControlBuilder<TPageModel, TDataModel, TControlProps>> builder,
        Func<BlockBuilder, Var<TControlProps>, Var<HyperNode>> controlConstructor)
        where TControlProps : new()
    {
        var controlBuilder = new ContextControlBuilder<TPageModel, TDataModel, TControlProps>(dataContext);
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

    public static Var<HyperNode> Checkbox<TPageModel, TItem>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TItem>> dataContext,
        Action<ContextControlBuilder<TPageModel, TItem, Checkbox>> builder)
    {
        return b.BuildControl(dataContext, builder, Shoelace.Control.Checkbox);
    }

    public static void BindInput<TPageModel, TContext, TControlProps, TProperty>(
        this ContextControlBuilder<TPageModel, TContext, TControlProps> builder,
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

    //public static Var<TItem> GetDataItem<TItem>(this BlockBuilder b, Var<ItemModelContext<TItem>> context, Var<object> pageModel)
    //{
    //    var getter = b.Get(context, x => x.GetItem);
    //    var contextData = b.Call(getter, pageModel);
    //    return contextData;
    //}

    //public static Var<T> GetData<T>(this BlockBuilder b, Var<ItemModelContext<T>> context)
    //{
    //    return b.Call(b.Get(context, x => x.GetContextData));
    //}

    public static void BindChecked<TPageModel, TContext, TControlProps>(
        this ContextControlBuilder<TPageModel, TContext, TControlProps> builder,
        System.Linq.Expressions.Expression<Func<TContext, bool>> contextProperty)
        where TControlProps : IHasCheckedProperty
    {
        builder.BindInput(x => x.Checked, contextProperty);

        Action<BlockBuilder, Var<HyperNode>> eventAction = (b, node) =>
        {
            b.SetOnSlChange(node, b.MakeAction(
                (BlockBuilder b, Var<TPageModel> pageModel, Var<bool> isChecked) =>
                {
                    var dataItem = b.Call(b.Get(builder.Context, x => x.AccessData), pageModel);
                    b.Set(dataItem, contextProperty, isChecked);
                    return b.Broadcast(pageModel);
                }));
        };
        builder.ControlBuilderActions.Add(eventAction);
    }
}

//public static class ModelAccessor
//{
//    public static Var<TModel> Itself<TModel>(this BlockBuilder b, Var<TModel> model)
//    {
//        return model;
//    }

//    public static Var<Action<TModel>> InContext<TModel, TContextData>(
//        this BlockBuilder b,
//        Var<Func<TModel, TContextData>> accessFunc,
//        Action<BlockBuilder, Var<TContextData>> builder)
//    {
//        return b.DefineAction(
//            (BlockBuilder b, Var<TModel> model) =>
//            {
//                var submodel = b.Call(accessFunc, model);
//                b.Call(builder, submodel);
//            });
//    }

//    public static Var<Action<TModel>> InContext<TModel, TContextData>(
//        this BlockBuilder b,
//        Var<Func<TModel, TContextData>> accessFunc,
//        Action<BlockBuilder, Var<ItemModelContext<TContextData>>> builder)
//    {
//        return b.DefineAction(
//            (BlockBuilder b, Var<TModel> model) =>
//            {
//                var submodel = b.Call(accessFunc, model);

//                var itemModelContext = b.NewObj<ItemModelContext<TContextData>>();
//                b.Set(itemModelContext, x => x.GetItem, accessFunc.As<Func<object, TContextData>>());
//                b.Set(itemModelContext, x => x.Item, submodel);
//                b.Set(itemModelContext, x => x.GetContextData, b.DefineFunc((BlockBuilder b) =>
//                {
//                    return b.Call(accessFunc, model);
//                }));

//                b.Call(builder, itemModelContext);
//            });
//    }
//}

//public static class TestNestedAccess
//{
//    public static Var<HyperNode> ShowNestedData(this BlockBuilder b, Var<ItemModelContext<Nested>> dataContext)
//    {
//        var nested = b.GetData(dataContext);
//        var showStuff = b.Get(nested, x => x.ShowStuff);
//        var container = b.Div(
//            "flex flex-col",
//            b => b.Text(b.AsString(showStuff), "font-semibold text-red-400"),
//            b => b.Checkbox(dataContext, b =>
//            {
//                b.BindChecked(x => x.ShowStuff);
//            }));

//        return container;
//    }
//}

public class ModelAccessor<TPageModel, TSubmodel>
{
    public Func<BlockBuilder, Var<TPageModel>, Var<TSubmodel>> Accessor { get; set; }

    public Var<TSubmodel> GetData(BlockBuilder b, Var<TPageModel> pageModel)
    {
        return b.Call(Accessor, pageModel);
    }
}

public class ClientSideDataContext<TDataContext>
{
    public Func<BlockBuilder, TDataContext> GetDataContext { get; set; }
}

public interface IModelBinder<TPageModel>
{
    //Action<BlockBuilder, Var<TPageModel>> GetRunner(BlockBuilder b);
}

public interface IBinderDoerIDontKnowWhatImDoing<TPageModel>
{
    Action<BlockBuilder, Var<TPageModel>> GetRunner(BlockBuilder b);
    List<IBinderDoerIDontKnowWhatImDoing<TPageModel>> ChildrenDoers { get; set; }
}

public interface IAccessor<TPageModel, TSubmodel>
{
    Func<BlockBuilder, Var<TPageModel>, Var<TSubmodel>> GetSubmodel { get; set; }
}


public class BinderDoerWhatever<TPageModel, TSubmodel>  : IBinderDoerIDontKnowWhatImDoing<TPageModel>, IAccessor<TPageModel, TSubmodel>
{
    public Func<BlockBuilder, Var<TPageModel>, Var<TSubmodel>> GetSubmodel { get; set; }
    public Action<BlockBuilder, ModelBinder<TPageModel, TSubmodel>> DoStuffHere { get; set; }

    public List<IBinderDoerIDontKnowWhatImDoing<TPageModel>> ChildrenDoers { get; set; } = new();

    public Action<BlockBuilder, Var<TPageModel>> GetRunner(BlockBuilder b)
    {
        return (BlockBuilder b, Var<TPageModel> model) =>
        {
            ModelBinder<TPageModel, TSubmodel> binder = new ModelBinder<TPageModel, TSubmodel>();

            var submodel = b.Call(GetSubmodel, model);
            //b.Call(DoStuffHere, submodel);

            foreach (var childDoer in ChildrenDoers)
            {
                var childRunner = childDoer.GetRunner(b);
                childRunner(b, model);
            }
        };
    }
}

//public class AccessorNavigatorWhatever<TPageModel, TSubmodel>
//{
//    public Func<TPageModel, TSubmodel> AccessorFunc { get; set; }
//}

public class DataContext<TPageModel, TSubmodel>
{
    public Func<TPageModel, TSubmodel> AccessData { get; set; }
    public TSubmodel InputData { get; set; }
}

public class AccessorAction<TPageModel, TSubmodel>
{
    //public Func<BlockBuilder, Var<TPageModel>, Var<TSubmodel>> GetSubmodelFromModel { get; set; }
    //public Var<TSubmodel> InputSubmodel { get; set; }
    public DataContext<TPageModel, TSubmodel> Accessor { get; set; }
    public Action<BlockBuilder, DataContext<TPageModel, TSubmodel>> DoStuff { get; set; }
}

public static class AccessorNavigatorWhateverExtensions
{
    //public static Func<BlockBuilder, Var<TPageModel>, Var<TChild>> On<TPageModel, TParent, TChild>(
    //    this BlockBuilder b,
    //    Func<BlockBuilder, Var<TPageModel>, Var<TParent>> parentAccessor,
    //    Func<BlockBuilder, Var<TParent>, Var<TChild>> onChild)
    //{
    //    return (BlockBuilder b, Var<TPageModel> pageModel) =>
    //    {
    //        var parent = b.Call(parentAccessor, pageModel);
    //        var child = b.Call(onChild, parent);
    //        return child;
    //    };
    //}

    public static void On<TPageModel, TParent, TChild>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        Func<BlockBuilder, Var<TParent>, Var<TChild>> onChild,
        Action<BlockBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
    {
        var parentData = b.Get(parentAccessor, x => x.InputData);
        var inputSubmodel = b.Call(onChild, parentData);

        var childAccessor = b.NewObj<DataContext<TPageModel, TChild>>();
        b.Set(childAccessor, x => x.InputData, inputSubmodel);
        b.Set(childAccessor,
            x => x.AccessData,
            b.Def((BlockBuilder b, Var<TPageModel> pageModel) =>
            {
                var parent = b.Call(b.Get(parentAccessor, x => x.AccessData), pageModel);
                var child = b.Call(onChild, parent);
                return child;
            }));

        doStuff(b, childAccessor);
    }

    public static void OnProperty<TPageModel, TParent, TChild>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        System.Linq.Expressions.Expression<Func<TParent, TChild>> property,
        Action<BlockBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
    {
        var getProperty = (BlockBuilder b, Var<TParent> parent) => b.Get(parent, property);
        b.On(parentAccessor, getProperty, doStuff);
    }

    public static void OnList<TPageModel, TParent, TChild>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        Func<BlockBuilder, Var<TParent>, Var<List<TChild>>> onChild,
        Action<BlockBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
    {
        var inputList = b.Call(onChild, b.Get(parentAccessor, x => x.InputData));

        var indexRef = b.Ref(b.Const(0));

        b.Foreach(inputList, (b, item) =>
        {
            var itemIndex = b.GetRef(indexRef);
            var getItem = b.DefineFunc((BlockBuilder b, Var<TPageModel> state) =>
            {
                var parentData = b.Call(b.Get(parentAccessor, x => x.AccessData), state);
                var childListReference = b.Call(onChild, parentData);

                var innerIndex = b.Ref(b.Const(0));
                var currentItem = b.Ref(b.Const(new object()));
                b.Foreach(childListReference,
                    (b, item) =>
                    {
                        b.If(b.AreEqual(itemIndex, b.GetRef(innerIndex)),
                            b =>
                            {
                                //b.Log("item set for index", itemIndex);
                                //b.Log("to value", item);
                                b.SetRef(currentItem, item.As<object>());
                            });
                        b.SetRef(innerIndex, b.Get(b.GetRef(innerIndex), x => x + 1));
                    });

                return b.GetRef(currentItem).As<TChild>();
            });

            var childAccessor = b.NewObj<DataContext<TPageModel, TChild>>();
            b.Set(childAccessor, x => x.InputData, item);
            b.Set(childAccessor, x => x.AccessData, getItem);
            doStuff(b, childAccessor);

            b.SetRef(indexRef, b.Get(b.GetRef(indexRef), x => x + 1));
        });
    }

    public static void OnList<TPageModel, TParent, TChild>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        System.Linq.Expressions.Expression<Func<TParent, List<TChild>>> onList,
        Action<BlockBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
    {
        var getList = (BlockBuilder b, Var<TParent> parent) => b.Get(parent, onList);
        b.OnList(parentAccessor, getList, doStuff);
    }


    //public ModelContext<TChild> OnList<TChild>(System.Linq.Expressions.Expression<Func<T, List<TChild>>> drill, Action<BlockBuilder, Var<ItemModelContext<TChild>>> action)
    //{
    //    ModelContext<TChild> childContext = new ModelContext<TChild>();
    //    childContext.drill = this.drill.Down<T, List<TChild>>(drill);
    //    childContext.b = b;
    //    var childListReference = b.Get<T, List<TChild>>(contextReference, childContext.drill);
    //    var indexRef = b.Ref(b.Const(0));
    //    b.Foreach(childListReference, (b, item) =>
    //    {
    //        var itemIndex = b.GetRef(indexRef);
    //        var getItem = b.DefineFunc((BlockBuilder b, Var<object> state) =>
    //        {
    //            b.Log("getItem itemIndex", itemIndex);
    //            //var drillFunc = b.GetDrillFunc<object, List<TChild>>(childContext.drill);
    //            var childListReference = b.Get<T, List<TChild>>(contextReference, childContext.drill);
    //            var innerIndex = b.Ref(b.Const(0));
    //            var currentItem = b.Ref(b.Const(new object()));
    //            b.Foreach(childListReference,
    //                (b, item) =>
    //                {
    //                    b.If(b.AreEqual(itemIndex, b.GetRef(innerIndex)),
    //                        b =>
    //                        {
    //                            //b.Log("item set for index", itemIndex);
    //                            //b.Log("to value", item);
    //                            b.SetRef(currentItem, item.As<object>());
    //                        });
    //                    b.SetRef(innerIndex, b.Get(b.GetRef(innerIndex), x => x + 1));
    //                });

    //            return b.GetRef(currentItem).As<TChild>();
    //        });

    //        var itemModelContext = b.NewObj<ItemModelContext<TChild>>();
    //        b.Set(itemModelContext, x => x.Item, item);
    //        b.Set(itemModelContext, x => x.GetItem, getItem);

    //        b.Call(action, itemModelContext);
    //        b.SetRef(indexRef, b.Get(b.GetRef(indexRef), x => x + 1));
    //    });
    //    return childContext;
    //}
    //}

public static void OnModel<TPageModel>(
        this BlockBuilder b,
        Var<TPageModel> model,
        Action<BlockBuilder, Var<DataContext<TPageModel, TPageModel>>> doStuff)
    {
        var clientModelContext = b.NewObj<DataContext<TPageModel, TPageModel>>();
        b.Set(clientModelContext, x => x.InputData, model);
        b.Set(clientModelContext, x => x.AccessData, b.Def((BlockBuilder b, Var<TPageModel> model) => model));

        doStuff(b, clientModelContext);
    }
}

public class ModelBinder<TPageModel, TSubmodel> : IModelBinder<TPageModel>
{
    public BinderDoerWhatever<TPageModel, TSubmodel> doer;


    //public Var<TPageModel> InputModel { get; set; }

    //public ModelAccessor<TPageModel, TSubmodel> modelAccessor { get; set; }

    //public Action<BlockBuilder, ModelBinder<TPageModel, TSubmodel>> Builder { get; set; }
    //public Action<BlockBuilder, Var<TPageModel>> Builder { get; set; }

    //public List<IModelBinder<TPageModel>> ChildrenBindings { get; set; } = new();

    //internal Func<BlockBuilder, Var<TPageModel>> getPageModel;
    //public ModelBinder(Func<BlockBuilder, Var<TPageModel>> getPageModel)
    //{
    //    this.getPageModel = getPageModel;
    //}

    //public Func<BlockBuilder, Var<TPageModel>, Var<TSubmodel>> Accessor { get; set; }
    //public List<Action<BlockBuilder, Var<TPageModel>>> Builders { get; set; } = new();

    //public Var<TSubmodel> GetData(BlockBuilder b)
    //{
    //    var pageModel = this.getPageModel(b);
    //    return b.Call(Accessor, pageModel);
    //}

    //public Action<BlockBuilder, Var<TPageModel>> GetRunner(BlockBuilder b)
    //{
    //    return (BlockBuilder b, Var<TPageModel> model) =>
    //    {
    //        Builder(b, this);
    //        foreach (var childContext in ChildrenBindings)
    //        {
    //            var childRunner = childContext.GetRunner(b);
    //            childRunner(b, model);
    //        }
    //    };
    //}
}


public static class ModelNavigatorExtensions
{
    public static void On<TPageModel, TParent, TChild>(
        this BlockBuilder b, 
        ModelBinder<TPageModel, TParent> parentBinder,
        Func<BlockBuilder, Var<TParent>, Var<TChild>> accessChild,
        Action<BlockBuilder, ModelBinder<TPageModel, TChild>> contextBuilder)
    {
        ModelBinder<TPageModel, TChild> childBinder = new ModelBinder<TPageModel, TChild>();
        contextBuilder(b, childBinder);

        parentBinder.doer.ChildrenDoers.Add(childBinder.doer);

        BinderDoerWhatever<TPageModel, TChild> childDoer = new();
        childDoer.GetSubmodel = (BlockBuilder b, Var<TPageModel> pageModel) =>
        {
            var parent = b.Call(parentBinder.doer.GetSubmodel, pageModel);
            return b.Call(accessChild, parent);
        };

        //childDoer.DoStuffHere = 

        //ModelAccessor<TPageModel, TChild> childAccessor = new ModelAccessor<TPageModel, TChild>();
        //childAccessor.Accessor = (BlockBuilder b, Var<TPageModel> model) =>
        //{
        //    var parent = b.Call(parentBinder.modelAccessor.GetData, model);
        //    var child = b.Call(accessChild, parent);
        //    return child;
        //};

        //ModelBinder<TPageModel, TChild> childModelBinder = new ModelBinder<TPageModel, TChild>()
        //{
        //    modelAccessor = childAccessor,
        //};
        //childModelBinder.Builder = contextBuilder;

        //parentBinder.ChildrenBindings.Add(childModelBinder);
    }

    public static Var<Func<TRoot, TChild>> MakeDrillDown<TRoot, TParent, TChild>(
        this BlockBuilder b,
        Var<Func<TRoot, TParent>> parentAccessor,
        Func<BlockBuilder, Var<TParent>, Var<TChild>> drillFunc)
    {
        return b.DefineFunc((BlockBuilder b, Var<TRoot> root) =>
        {
            var parent = b.Call(parentAccessor, root);
            var child = b.Call(drillFunc, parent);
            return child;
        });
    }

    public static Func<BlockBuilder, Var<TRoot>, Var<TChild>> MakeDrillDown<TRoot, TParent, TChild>(
        this BlockBuilder b,
        Func<BlockBuilder, Var<TRoot>, Var<TParent>> parentAccessor,
        Func<BlockBuilder, Var<TParent>, Var<TChild>> drillFunc)
    {
        return (BlockBuilder b, Var<TRoot> root) =>
        {
            var parent = b.Call(parentAccessor, root);
            var child = b.Call(drillFunc, parent);
            return child;
        };
    }

    public static Var<TContextData> GetContextData<TRootModel, TContextData>(this BlockBuilder b, Var<ModelNavigator> navigator, Var<TRootModel> model)
    {
        var currentData = b.Ref(model.As<object>());

        b.Foreach(
            b.Get(navigator, x => x.NavigatorStack),
            (b, item) =>
            {
                b.SetRef(currentData, b.Call(item.As<Func<object, object>>(), item));
            });

        return b.GetRef(currentData).As<TContextData>();
    }

    //public static Var<ModelNavigator> NavigateTo<TParent, TChild>(
    //    this BlockBuilder b,
    //    Var<ModelNavigator> navigator,
    //    Func<BlockBuilder, Var<TParent>, Var<TChild>> navigate,
    //    Action<BlockBuilder, Var<ItemModelContext<TChild>>> contextAction)
    //{
    //    var newNavigator = b.Clone(navigator);
    //    var stack = b.Get(newNavigator, x => x.NavigatorStack);
    //    b.Push(stack, b.Def(navigate).As<object>());

    //    var dataAccesor = b.NewObj<ItemModelContext<TChild>>();
    //    b.Set(dataAccesor, x => x.GetItem, b.Def((BlockBuilder b, Var<object> rootModel) =>
    //    {
    //        return b.Call(GetContextData<object, TChild>, newNavigator, rootModel);
    //    }));

    //    b.Call(contextAction, dataAccesor);

    //    return newNavigator;
    //}

    public static Var<ModelNavigator> NavigateToList<TParent, TChild>(this BlockBuilder b, Var<ModelNavigator> navigator, Func<BlockBuilder, Var<TParent>, Var<List<TChild>>> navigate)
    {
        var newNavigator = b.Clone(navigator);
        var stack = b.Get(newNavigator, x => x.NavigatorStack);
        b.Push(stack, b.Def(navigate).As<object>());
        return newNavigator;
    }

    public static Action<BlockBuilder, Var<TModel>> BindModel<TModel>(this BlockBuilder b, Action<BlockBuilder, ModelBinder<TModel, TModel>> action)
    {
        ModelBinder<TModel, TModel> modelBinder = new()
        {
            doer = new BinderDoerWhatever<TModel, TModel>()
        };

        return modelBinder.doer.GetRunner(b);

        //BinderDoerWhatever<TModel, TModel> rootDoer = new BinderDoerWhatever<TModel, TModel>();
        //rootDoer.DoStuffHere = modelBinder.CreateDoer().GetRunner();
        //rootDoer.GetSubmodel = (b, model) => model;

        ////ModelBinder<TModel, TModel> binder = new();

        //binder.modelAccessor = new ModelAccessor<TModel, TModel>();
        //binder.modelAccessor.Accessor = (b, model) => model;
        //binder.Builder = (b, model) =>
        //{
        //    action(b, binder);
        //};
        //return binder.GetRunner(b);
    }
}



public class XXXRenderer : HtmlPage<XXXModel>
{
    public static async Task<XXXModel> IncrementFirst(CommandContext commandContext, XXXModel model)
    {
        model.First.count++;
        return model;
    }

    public static async Task<XXXModel> IncrementSecond(CommandContext commandContext, XXXModel model)
    {
        model.Second.count++;
        return model;
    }

    //public DivTag CreateMainContainer<TModel>(
    //    TModel dataModel, 
    //    System.Linq.Expressions.Expression<Func<TModel, ComponentModel>> getComponentModel,
    //    Func<CommandContext, TModel, Task<TModel>> onClickServer)
    //    where TModel: IApiSupportState
    //{
    //    var mainContainer =
    //        DivTag.Create(
    //            "flex flex-col p-4 gap-4",
    //            HyperApp.ClientNode(
    //                dataModel,
    //                getComponentModel,
    //                DivTag.Create(
    //                    "",
    //                    new HtmlText("This appears only if checkbox is checked"))).VisibleIf(getComponentModel, x => x.Nested.ShowStuff),
    //            HyperApp.ClientNode(
    //                dataModel, 
    //                getComponentModel,
    //                SlCheckbox.Create(
    //                "",

    //                new HtmlText(
    //                    "Show div. This checkbox only appears if count < 5 "))).BindChecked(getComponentModel, x => x.Nested.ShowStuff).VisibleIf(getComponentModel, x => x.count < 5),
    //            DivTag.Create(
    //                "px-4 py-2 bg-blue-500 text-white rounded",
    //                HyperApp.ClientNode(
    //                    dataModel,
    //                    getComponentModel,
    //                    DivTag.Create("", new HtmlText("RUN SERVEEEEER!!!")))
    //                .OnClickServer(onClickServer)));

    //    return mainContainer;
    //}

    public override IHtmlNode GetHtmlTree(XXXModel dataModel)
    {
        var document = DocumentTag.Create(dataModel.First.P1);
        document.Head.AddModuleStylesheet();

        //document.AddChild(HyperApp.ClientNode(dataModel, (BlockBuilder b, Var<XXXModel> model) =>
        //{
        //    return b.TextNode("Whatever");
        //}));

        document.Body.AddDynamic(dataModel, (b, model) =>
        {
            var container = b.Div("flex flex-col");

            b.OnModel(model,
                (b, dataContext) =>
                {
                    b.OnProperty(dataContext, x => x.First.Nested,
                        (b, dataContext) =>
                        {
                            var data = b.Get(dataContext, x => x.InputData);

                            var showStuff = b.Get(data, x => x.ShowStuff);

                            b.Add(container, b.Checkbox(dataContext, b =>
                            {
                                b.BindChecked(x => x.ShowStuff);
                            }));

                            b.OnProperty(dataContext, x => x.ShowStuff,
                                (b, dataContext) =>
                                {
                                    var data = b.Get(dataContext, x => x.InputData);

                                    b.Add(container, b.Text(b.AsString(data)));
                                });
                        });

                    b.OnList(dataContext, x => x.CompList,
                        (b, dataContext) =>
                        {
                            b.Log(b.Get(dataContext, x => x.InputData));

                            b.Add(container, b.Checkbox(dataContext, b =>
                            {
                                b.BindChecked(x => x.SomeBool);
                            }));
                        });

                    b.OnList(
                        dataContext, x => x.CompList.Where(x => x.SomeBool).ToList(),
                        (b, dataContext) =>
                        {
                            var data = b.Get(dataContext, x => x.InputData);
                            b.Add(container, b.Text(b.Get(data, x => x.P1)));
                        });
                });

            return container;
        });


        //document.Body.AddHyperapp(dataModel, (b, model) =>
        //{
        //    var container = b.Div("");

        //    var rootContext = ModelContext.Root(b, model);
        //    rootContext.OnProperty(
        //        x => x.First,
        //        (b, model) =>
        //        {
        //            b.Add(container, b.Text(b.Get(model, x => x.P2)));
        //        });

        //    rootContext.OnProperty(x => x.Second,
        //        (b, model) =>
        //        {
        //            b.Add(container, b.Text(b.Get(model, x => x.P2)));
        //        });

        //    rootContext.OnList(x=>x.CompList,
        //        (b, itemContext) =>
        //        {
        //            b.Add(container, b.Checkbox(itemContext, b =>
        //            {
        //                b.BindChecked(x => x.SomeBool);
        //            }));

        //            b.If(
        //                b.Get(itemContext, x => x.Item.P2 == "P2_2"),
        //                b =>
        //                {
        //                    b.Add(container, b.Text("IS P2_2"));
        //                });
        //        });

        //    return container;
        //});

        //var mainContainer = document.AddChild(
        //    DivTag.Create(
        //        "flex flex-col p-4 gap-4",
        //        DivTag.Create(
        //            "",
        //            new HtmlText("This appears only if checkbox is checked")).ToClientSide(dataModel).VisibleIf(x => x.Nested.ShowStuff),
        //        HyperApp.ToClientSide(dataModel, SlCheckbox.Create(
        //            "",
        //            new HtmlText(
        //                "Show div. This checkbox only appears if count < 5 "))).BindChecked(x => x.Nested.ShowStuff).VisibleIf(x => x.count < 5),
        //        DivTag.Create(
        //            "px-4 py-2 bg-blue-500 text-white rounded",
        //            new HtmlText("RUN SERVEEEEER!!!")).ToClientSide(dataModel)
        //            .OnClickServer(async (cc, model) =>
        //            {
        //                model.count++;
        //                return model;
        //            })));

        //MagicBuilder<XXXModel, XXXModel> rootBuilder = MagicBuilder.Root<XXXModel>();
        //rootBuilder.OnProperty(x => x.First).OnProperty(x => x.Nested);

        //document.Body.AddChild(HyperApp.ClientNode(
        //    dataModel,
        //    x => x.First,
        //    CreateMainContainer(dataModel, x => x.First, IncrementFirst))).VisibleIf(x => x.First, x => x.P1 == "show");
        //document.Body.AddChild(HyperApp.ClientNode(dataModel, CreateMainContainer(dataModel.Second, IncrementSecond)).VisibleIf(x => x.Second.P1 == "show"));

        //document.AddChild(
        //        HyperApp.ClientNode(dataModel, SlCheckbox.Create(
        //            "",
        //            new HtmlText(
        //                "Show div. This checkbox only appears if count < 5 "))).BindChecked(x => x.Nested.ShowStuff).VisibleIf(x => x.count < 5));

        //document.Body.AddChild(
        //HyperApp.ClientNode(dataModel, SlCheckbox.Create(
        //    "",
        //    HyperApp.ClientNode(
        //        dataModel, new ClientTextNode()).WithText(x => x.P1)))).BindChecked(x => x.Nested.ShowStuff);



        //document.Body.AddChild(
        //    HyperApp.ClientNode(
        //        dataModel,
        //        SlCheckbox.Create(
        //            "",
        //            HyperApp.ClientNode(
        //                dataModel, new ClientTextNode()).WithText(x => x.P1))).BindChecked(x => x.Nested.ShowStuff));


        //document.AddChild(HyperApp.ClientNode(dataModel, new ClientTextNode()).WithText(x => x.P1));

        //var buttonRenderer = clientButton.Render;
        //clientButton.Render = (BlockBuilder b, Var<XXXModel> model) =>
        //{
        //    var btn = buttonRenderer(b, model);
        //    b.SetOnClick(btn, b.MakeServerAction(model, async (cc, model) =>
        //    {
        //        model.count++;
        //        return model;
        //    }));

        //    return btn;
        //};
        //mainContainer.AddHyperapp(
        //    dataModel,
        //    (b, model) =>
        //    {
        //        var container = b.Span("flex flex-row gap-4 items-center");

        //        var button = b.Add(container, b.Node("button", "px-4 py-2 bg-blue-500 text-white rounded"));
        //        b.Add(button, b.TextNode("INCREMENT!"));

        //        b.SetOnClick(button, b.MakeServerAction(model, async (cc, model) =>
        //        {
        //            model.count++;
        //            return model;
        //        }));

        //        b.Add(container, b.Text(b.AsString(b.Get(model, x => x.count))));

        //        return container;
        //    });

        //var div = document.Body.AddChild(new DivTag());

        //div.AddHyperapp(dataModel,
        //    (b, model) =>
        //    {
        //        var container = b.Span();

        //        var button = b.Add(container, b.Node("button"));
        //        b.Add(button, b.TextNode(" +2 !"));

        //        b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<XXXModel> model) =>
        //        {
        //            b.Set(model, x => x.count, b.Get(model, x => x.count + 2));
        //            b.Log(model);
        //            return b.Broadcast(model);
        //        }));

        //        b.Add(container, b.Text(b.AsString(b.Get(model, x => x.count))));

        //        return container;
        //    });

        document.AttachComponents();

        //var components = document.Body.Descendants().OfType<IHtmlComponent>();
        //foreach (var component in components)
        //{
        //    component.OnMount(document);
        //}

        return document;
    }
}

public class HomeHandler : Http.Get<Metapsi.Tutorial.Routes.Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        HomeModel model = new HomeModel();
        await model.LoadRoutes();
        return Page.Result(model);
    }
}


public class HomeRenderer : HtmlPage<HomeModel>
{
    public override IHtmlNode GetHtmlTree(HomeModel dataModel)
    {
        var htmlDocument = DocumentTag.Create();
        var head = htmlDocument.Head;
        var body = htmlDocument.Body;

        head.AddModuleStylesheet();
        var largeHeader = new DivTag().AddTextSpan("Metapsi").AddInlineStyle("font-size", "var(--sl-font-size-large)");
        body.AddChild(Header(dataModel, largeHeader, head));

        //body.AddHyperapp(
        //    dataModel,
        //    (b, model) =>
        //    {
        //        return b.DrawerTreeMenu(model);
        //    });

        var allNodes = body.Descendants();

        var slTags = allNodes.Where(x => x is IHtmlElement).Where(x => (x as IHtmlElement).GetTag().Tag.StartsWith("sl-"));

        if (slTags.Any())
        {
            head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
            head.AddStylesheet("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css");
        }

        htmlDocument.AttachComponents();

        //var components = htmlDocument.Body.Descendants().OfType<IHtmlComponent>();
        //foreach (var component in components)
        //{
        //    component.OnMount(htmlDocument);
        //}

        //declare server-side shoelace with common props
        //await slTags. Also include client-side tags
        return htmlDocument;
    }



    public DivTag Header<TModel>(TModel model, IHtmlNode content, HeadTag headTag)
        where TModel: IHasTreeMenu
    {
        var container = new DivTag()
            .AddClass("flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl");

        //var icon = container.AddChild(new HtmlTag("sl-icon").AddAttribute("name", "list"));

        //container.AddHyperapp(
        //    model,
        //    (b, model) =>
        //    {
        //        var showMenuButton = b.IconButton("list");
        //        b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
        //        {
        //            b.Set(model, x => x.MenuIsExpanded, true);
        //            return b.Broadcast(model);
        //        }));

        //        return showMenuButton;
        //    });

        if (content != null)
        {
            container.AddChild(content);
        }

        return container;
    }


    //public static Var<HyperNode> Header<TModel>(this BlockBuilder b, Var<TModel> model, Func<BlockBuilder, Var<HyperNode>> headerContent)
    //{
    //    var header = b.Div(
    //        "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl",
    //        b =>
    //        {
    //            var showMenuButton = b.IconButton("list");
    //            b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
    //            {
    //                b.Set(model, x => x.MenuIsExpanded, true);
    //                return b.Clone(model);
    //            }));

    //            return showMenuButton;
    //        },
    //        headerContent);

    //    return header;
    //}
}

/*

public class HomeRenderer : ShoelaceHyperPage<HomeModel>
{
    public override Var<HyperNode> OnRender(BlockBuilder b, Var<HomeModel> model)
    {
        b.AddModuleStylesheet();

        var largeHeader = b.Div("", b =>
        {
            var text = b.Text("Metapsi");
            b.AddStyle(text, "font-size", "var(--sl-font-size-large)");
            return text;
        });

        var page = b.Div("flex flex-col");

        var slogan = b.Add(page, b.Div(
            "flex flex-col justify-center items-center pt-36 text-gray-800",
            b =>
            {
                return b.Animation(b.Const(new Animation()
                {
                    Name = "fadeInDown",
                    Iterations = 1,
                    Duration = 300,
                    Delay = 500,
                    Play = true,
                    Fill = "both",
                    Easing = "easeOut"
                }),
                b =>
                {
                    var text = b.Span(
                        "",
                        b => b.Text("The "),
                        b => b.Text("full stack C#", "bg-blue-50"),
                        b => b.Text(" framework"));
                    b.AddStyle(text, "font-size", "var(--sl-font-size-2x-large)");
                    return text;
                });
            },
            b =>
            {
            return b.Animation(b.Const(new Animation()
            {
                Name = "fadeIn",
                Iterations = 1,
                Delay = 1000,
                Duration = 500,
                Play = true,
                Fill = "both",
                Easing = "easeOut"
            }),
            b =>
            {
                var text = b.Div(
                        "",
                        b => b.Text("that"),
                        b =>
                        {

                            var tooltip = b.Tooltip(b.Const(new Tooltip()), b => b.Text(" packs ", "underline decoration-dashed"));
                            b.SetAttr(tooltip, DynamicProperty.String("placement"), "bottom");
                            var icon = b.Add(tooltip, b.Icon("box-seam"));
                            b.SetAttr(icon, DynamicProperty.String("slot"), "content");
                            return tooltip;
                        },
                        b => b.Text("everything."));
                    b.AddStyle(text, "font-size", "var(--sl-font-size-2x-large)");
                    return text;
                });
            }));

        b.AddStyle(slogan, "font-family", "var(--sl-font-serif)");
        b.AddStyle(slogan, "font-weight", "var(--sl-font-weight-bold)");

        b.Add(page, b.Div("h-12"));

        var featuresPanel = b.Add(page, b.Div("flex flex-col bg-blue-50"));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your tools"),
            b.Const("Stay inside VS Code/Visual Studio, just add nugets and you're ready to go."),
            b.Const("No node.js, no npm required."),
            b.Const("wrench")));

        b.Add(featuresPanel, b.Div("mx-12 bg-gray-200 h-px"));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your types, everywhere"),
            b.Const("The client-side code speaks C#. One definition, shared"),
            b.Const(string.Empty),
            b.Const("arrow-left-right")));

        b.Add(featuresPanel, Separator(b));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your version, always"),
            b.Const("Resources are embedded, allowing you to upgrade & downgrade atomically"),
            b.Const("This applies to CSS, JS, images & more"),
            b.Const("box")));

        b.Add(featuresPanel, Separator(b));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your solution & nothing else"),
            b.Const("You don't use it? Then it's not included. Each HTML page knows exactly what JS files it needs."),
            b.Const("Also, nugets build on top of each other, allowing you to work as high or low level as you need"),
            b.Const("scissors")));

        b.Add(featuresPanel, Separator(b));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Open source"),
            b.Const("MIT licensed, just like the great projects we build upon"),
            b.Const(string.Empty),
            b.Const("file-text")));

        b.Add(page,
            b.Div(
                "flex flex-row justify-center p-16 text-sm text-gray-500",
                b => b.Text("And many more, but it's late in the evening & this is just a draft anyway...")));

        b.Add(page, b.Header(model, b => largeHeader));
        b.Add(page, b.DrawerTreeMenu(model));

        return page;
    }

    public Var<HyperNode> Separator(BlockBuilder b)
    {
        return b.Div("mx-12 bg-gray-200 h-px");
    }

    public Var<HyperNode> HomeFeature(
        BlockBuilder b,
        Var<string> title,
        Var<string> subtitle,
        Var<string> details,
        Var<string> icon)
    {
        return b.Div(
            "flex flex-row items-center justify-center gap-24 bg-blue-50 p-16",
            b => b.Div(
                "flex-1 basis-1/3 flex flex-row items-center justify-end",
                b => b.Div(
                    "flex flex-row items-center justify-center w-16 h-16 text-3xl rounded-full bg-blue-400 text-white",
                    b => b.Icon(icon))),
            b => b.Div(
                "flex-1 basis-2/3 flex flex-col gap-4 text-gray-700",
                b => b.Text(title, "text-large font-semibold"),
                b => b.Optional(b.HasValue(subtitle), b => b.Text(subtitle, "text-sm")),
                b => b.Optional(b.HasValue(details), b => b.Text(details, "text-sm"))));
    }
}
*/

public static class SharedStateExtensions
{
    public static Var<TModel> Broadcast<TModel>(this BlockBuilder b, Var<TModel> model)
    {
        var clone = b.Clone(model);
        b.DispatchEvent(b.Const("sharedStateUpdate"), clone);
        return clone;
    }

    public static HyperAppNode<TModel, TComponentModel, TControl> OnClickServer<TModel, TComponentModel, TControl>(
        this HyperAppNode<TModel, TComponentModel, TControl> control,
        Func<CommandContext, TModel, System.Threading.Tasks.Task<TModel>> onServerAction)
        where TModel : IApiSupportState
        where TControl: IHtmlElement
    {
        var buttonRenderer = control.Render;
        control.Render = (BlockBuilder b, Var<TModel> model) =>
        {
            var btn = buttonRenderer(b, model);
            b.SetOnClick(btn, b.MakeServerAction(model, onServerAction));
            return btn;
        };
        return control;
    }
}

public abstract class ShoelaceHyperPage<TDataModel> : HyperPage<TDataModel>
{
    public override IHtmlNode ModifyHtml(IHtmlNode root, Module module)
    {
        // sl-tooltip crashes for some reason
        var shoelaceTags = module.Consts.Where(x => x.Value is ShoelaceTag).Select(x => (x.Value as ShoelaceTag).tag).Where(x => x != "sl-tooltip").ToList();

        var head = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "head");
        var style = head.AddChild(new HtmlTag("style"));
        style.AddChild(new HtmlText() { Text = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }" });

        var body = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "body");

        var workaroundDiv = body.AddChild(new HtmlTag() { Tag = "div" });
        workaroundDiv.SetAttribute("class", "hidden");
        foreach (var shoelaceTag in shoelaceTags)
        {
            workaroundDiv.AddChild(new HtmlTag(shoelaceTag));
        }

        var scriptTag = body.AddChild(new HtmlTag("script"));
        scriptTag.SetAttribute("type", "module");

        var whenDefinedArray = string.Join(",\n", shoelaceTags.Select(x => $"customElements.whenDefined('{x}')"));

        scriptTag.AddChild(new HtmlText()
        {
            Text = $" await Promise.allSettled([{whenDefinedArray}]);document.body.classList.add('ready');console.log('document ready');"
        });

        return root;
    }
}