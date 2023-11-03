using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Metapsi.Syntax;

public class DataContext<TPageModel, TSubmodel>
{
    public Func<TPageModel, TSubmodel> AccessData { get; set; }
    public TSubmodel InputData { get; set; }
}

public static partial class DataContextExtensions
{
    public static Var<DataContext<TPageModel, TPageModel>> GetDataContext<TSyntaxBuilder, TPageModel>(
        this TSyntaxBuilder b,
        Var<TPageModel> model)
        where TSyntaxBuilder : SyntaxBuilder
    {
        var clientModelContext = b.NewObj<DataContext<TPageModel, TPageModel>>();
        b.Set(clientModelContext, x => x.InputData, model);
        b.Set(clientModelContext, x => x.AccessData, b.Def((TSyntaxBuilder b, Var<TPageModel> model) => model));
        return clientModelContext;
    }

    public static Var<DataContext<TPageModel, TSubmodel>> GetDataContext<TSyntaxBuilder, TPageModel, TSubmodel>(
        this TSyntaxBuilder b,
        Var<TPageModel> model,
        Func<TSyntaxBuilder, Var<TPageModel>, Var<TSubmodel>> onSubmodel)
        where TSyntaxBuilder : SyntaxBuilder
    {
        var getSubmodel = b.Def(onSubmodel);

        var dataContext = b.NewObj<DataContext<TPageModel, TSubmodel>>();
        b.Set(dataContext, x => x.InputData, b.Call(getSubmodel, model));
        b.Set(dataContext, x => x.AccessData, getSubmodel);
        return dataContext;
    }

    public static Var<DataContext<TPageModel, TSubmodel>> GetDataContext<TSyntaxBuilder, TPageModel, TSubmodel>(
        this TSyntaxBuilder b,
        Var<TPageModel> model,
        System.Linq.Expressions.Expression<Func<TPageModel, TSubmodel>> property)
        where TSyntaxBuilder : SyntaxBuilder
    {
        var getProperty = (TSyntaxBuilder b, Var<TPageModel> parent) => b.Get(parent, property);
        return b.GetDataContext(model, getProperty);
    }

    public static void On<TSyntaxBuilder, TPageModel, TParent, TChild>(
        this TSyntaxBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        Func<TSyntaxBuilder, Var<TParent>, Var<TChild>> onChild,
        Action<TSyntaxBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var parentData = b.Get(parentAccessor, x => x.InputData);
        var inputSubmodel = b.Call(onChild, parentData);

        var childAccessor = b.NewObj<DataContext<TPageModel, TChild>>();
        b.Set(childAccessor, x => x.InputData, inputSubmodel);
        b.Set(childAccessor,
            x => x.AccessData,
            b.Def((TSyntaxBuilder b, Var<TPageModel> pageModel) =>
            {
                var parent = b.Call(b.Get(parentAccessor, x => x.AccessData), pageModel);
                var child = b.Call(onChild, parent);
                return child;
            }));

        doStuff(b, childAccessor);
    }

    public static void OnProperty<TSyntaxBuilder, TPageModel, TParent, TChild>(
        this TSyntaxBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        System.Linq.Expressions.Expression<Func<TParent, TChild>> property,
        Action<TSyntaxBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var getProperty = (TSyntaxBuilder b, Var<TParent> parent) => b.Get(parent, property);
        b.On(parentAccessor, getProperty, doStuff);
    }

    public static void OnList<TSyntaxBuilder, TPageModel, TParent, TChild>(
        this TSyntaxBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        Func<TSyntaxBuilder, Var<TParent>, Var<List<TChild>>> onChild,
        Action<TSyntaxBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var inputList = b.Call(onChild, b.Get(parentAccessor, x => x.InputData));

        var indexRef = b.Ref(b.Const(0));

        b.Foreach(inputList, (b, item) =>
        {
            var itemIndex = b.GetRef(indexRef);
            var getItem = b.Def((TSyntaxBuilder b, Var<TPageModel> state) =>
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

    public static void OnList<TSyntaxBuilder, TPageModel, TParent, TChild>(
        this TSyntaxBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        System.Linq.Expressions.Expression<Func<TParent, List<TChild>>> onList,
        Action<TSyntaxBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var getList = (TSyntaxBuilder b, Var<TParent> parent) => b.Get(parent, onList);
        b.OnList(parentAccessor, getList, doStuff);
    }


    public static void OnList<TSyntaxBuilder, TPageModel, TParent, TChild>(
        this TSyntaxBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        System.Linq.Expressions.Expression<Func<TParent, IEnumerable<TChild>>> onList,
        Action<TSyntaxBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var getList = (TSyntaxBuilder b, Var<TParent> parent) =>
        {
            var enumerable = b.Get(parent, onList);
            return b.Get(enumerable, x => x.ToList());
        };
        b.OnList(parentAccessor, getList, doStuff);
    }

    public static void OnModel<TSyntaxBuilder, TPageModel>(
        this TSyntaxBuilder b,
        Var<TPageModel> model,
        Action<TSyntaxBuilder, Var<DataContext<TPageModel, TPageModel>>> doStuff)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var clientModelContext = b.NewObj<DataContext<TPageModel, TPageModel>>();
        b.Set(clientModelContext, x => x.InputData, model);
        b.Set(clientModelContext, x => x.AccessData, b.Def((TSyntaxBuilder b, Var<TPageModel> model) => model));

        doStuff(b, clientModelContext);
    }

    //public static void OnModel<TPageModel>(
    //    this BlockBuilder b,
    //    Var<TPageModel> model,
    //    Action<ContextBlockBuilder<TPageModel, TPageModel>> doStuff)
    //{
    //    var clientModelContext = b.NewObj<DataContext<TPageModel, TPageModel>>();
    //    b.Set(clientModelContext, x => x.InputData, model);
    //    b.Set(clientModelContext, x => x.AccessData, b.Def((BlockBuilder b, Var<TPageModel> model) => model));
    //    doStuff(new ContextBlockBuilder<TPageModel, TPageModel>(b.ModuleBuilder, b.Block, clientModelContext));
    //}

    public static Var<TContextData> Get<TSyntaxBuilder, TPageModel, TContextData>(this TSyntaxBuilder b, Var<DataContext<TPageModel, TContextData>> dataContext)
        where TSyntaxBuilder: SyntaxBuilder
    {
        return b.Get(dataContext, x => x.InputData);
    }
}