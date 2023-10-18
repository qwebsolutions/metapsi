using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Syntax;

public class DataContext<TPageModel, TSubmodel>
{
    public Func<TPageModel, TSubmodel> AccessData { get; set; }
    public TSubmodel InputData { get; set; }
}


//public class DataContextAction<TPageModel, TSubmodel>
//{
//    public DataContext<TPageModel, TSubmodel> Accessor { get; set; }
//    public Action<BlockBuilder, DataContext<TPageModel, TSubmodel>> DoStuff { get; set; }
//}

public static partial class DataContextExtensions
{
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


    public static void OnList<TPageModel, TParent, TChild>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TParent>> parentAccessor,
        System.Linq.Expressions.Expression<Func<TParent, IEnumerable<TChild>>> onList,
        Action<BlockBuilder, Var<DataContext<TPageModel, TChild>>> doStuff)
    {
        var getList = (BlockBuilder b, Var<TParent> parent) =>
        {
            var enumerable = b.Get(parent, onList);
            return b.Get(enumerable, x => x.ToList());
        };
        b.OnList(parentAccessor, getList, doStuff);
    }

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

    public static Var<TContextData> Get<TPageModel, TContextData>(this BlockBuilder b, Var<DataContext<TPageModel, TContextData>> dataContext)
    {
        return b.Get(dataContext, x => x.InputData);
    }
}