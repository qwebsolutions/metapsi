using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp;

//public class SubscriptionsBuilder : SyntaxBuilder
//{
//    public List<Var<Func<HyperType.Subscription>>> Subscriptions { get; set; } = new();
//}

//public static class SubscriptionsBuilderExtensions
//{
//    public static void Add(this SubscriptionsBuilder b, Func<SyntaxBuilder, Var<HyperType.Subscription>> buildSubscription)
//    {
//        b.Subscriptions.Add(b.Def(buildSubscription));
//    }

//    public static void Add<TModel>(this SubscriptionsBuilder b, Func<SyntaxBuilder, Var<Func<TModel, HyperType.Subscription>>> buildSubscription)
//    {
//        b.Subscriptions.Add(b.Def((SyntaxBuilder b) =>
//        {

//        }));
//    }
//}
