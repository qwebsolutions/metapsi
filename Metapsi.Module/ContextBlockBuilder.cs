//using System;
//using System.Reflection;

//namespace Metapsi.Syntax;

//public class ContextBlockBuilder<TPageModel, TContext> : BlockBuilder
//{
//    public Var<DataContext<TPageModel, TContext>> DataContext { get; set; }

//    public ContextBlockBuilder(
//        ModuleBuilder moduleBuilder,
//        Block block,
//        Var<DataContext<TPageModel, TContext>> dataContext) : base(moduleBuilder, block)
//    {
//        this.DataContext = dataContext;
//    }

//    public Var<TContext> GetContext()
//    {
//        return this.Get(DataContext, x => x.InputData);
//    }

//    public Var<T> GetContext<T>(System.Linq.Expressions.Expression<Func<TContext, T>> expression)
//    {
//        return this.Get(this.Get(DataContext, x => x.InputData), expression);
//    }

//    public void OnProperty<TChild>(
//        System.Linq.Expressions.Expression<Func<TContext, TChild>> property,
//        Action<ContextBlockBuilder<TPageModel, TChild>> doStuff)
//    {
//        var getProperty = (BlockBuilder b, Var<TContext> parent) => b.Get(parent, property);
//        this.On(getProperty, doStuff);
//    }

//    public void On<TChild>(
//        Func<BlockBuilder, Var<TContext>, Var<TChild>> onChild,
//        Action<ContextBlockBuilder<TPageModel, TChild>> doStuff)
//    {
//        var parentData = this.Get(this.DataContext, x => x.InputData);
//        var inputSubmodel = this.Call(onChild, parentData);

//        var childAccessor = this.NewObj<DataContext<TPageModel, TChild>>();
//        this.Set(childAccessor, x => x.InputData, inputSubmodel);
//        this.Set(childAccessor,
//            x => x.AccessData,
//            this.Def((BlockBuilder b, Var<TPageModel> pageModel) =>
//            {
//                var parent = b.Call(b.Get(this.DataContext, x => x.AccessData), pageModel);
//                var child = b.Call(onChild, parent);
//                return child;
//            }));

//        doStuff(new ContextBlockBuilder<TPageModel, TChild>(this.ModuleBuilder, this.Block, childAccessor));
//    }
//}