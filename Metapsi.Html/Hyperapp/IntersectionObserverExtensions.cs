using Metapsi;
using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi;

/// <summary>
/// Options for mapping the intersection observer to the data model
/// </summary>
/// <typeparam name="TItem"></typeparam>
public class IntersectionObserverSubscriptionOptions<TItem>
{
    /// <summary>
    /// Gets the scroll container the intersection applies to
    /// </summary>
    public Func<Element> GetContainer { get; set; }
    /// <summary>
    /// Gets the list of data items that represent the source of the observed elements
    /// </summary>
    public Func<List<TItem>> GetObservedItems { get; set; }
    /// <summary>
    /// Triggered on intersection
    /// </summary>
    public Action<HyperType.Dispatcher, TItem> OnSeen { get; set; }
    /// <summary>
    /// Returns the DOM Element that used the data item as the source
    /// </summary>
    public Func<TItem, Element> MapElement { get; set; }
    /// <summary>
    /// Returns the data item that was the source of the DOM Element
    /// </summary>
    public Func<Element, TItem> MapItem { get; set; }
}

/// <summary>
/// Options for the intersection observer subscriber
/// </summary>
public class IntersectionObserverSubscriberOptions
{
    public Func<Element> GetContainer { get; set; }
    public System.Action<HyperType.Dispatcher, Element> OnVisible { get; set; }
    public System.Func<List<Element>> GetObservedElements { get; set; }
}

public static class IntersectionObserverExtensions
{
    /// <summary>
    /// Creates and returns an <see cref="IntersectionObserver"/> that triggers <paramref name="onVisible"/> on intersection.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="scrollContainer"></param>
    /// <param name="onVisible"></param>
    /// <returns></returns>
    private static Var<IntersectionObserver> CreateIntersectionObserver(
        this SyntaxBuilder b,
        Var<Element> scrollContainer,
        Var<System.Action<Element>> onVisible)
    {
        var callback = b.Def((SyntaxBuilder b, Var<List<IntersectionObserverEntry>> entries, Var<IntersectionObserver> observer) =>
        {
            var intersecting = b.Get(entries, x => x.Where(x => x.isIntersecting).ToList());
            b.If(
                b.Get(intersecting, x => x.Any()),
                b =>
                {
                    b.If(
                        b.Not(b.HasObject(onVisible)),
                        b =>
                        {
                            b.LogDebug("onVisible not defined");
                        },
                        b =>
                        {
                            b.Foreach(intersecting, (b, entry) =>
                            {
                                var target = b.Get(entry, x => x.target);
                                b.If(
                                    b.HasObject(target),
                                    b =>
                                    {
                                        b.Call(onVisible, target);
                                    });
                            });
                        });
                });
        });

        var options = b.SetProps<IntersectionObserverOptions>(
            b.NewObj(),
            b =>
            {
                b.Set(x => x.root, scrollContainer.As<Node>());
                b.Set(x => x.threshold, 0.8m);
            });

        var observer = b.On(
            b.IntersectionObserver(),
            b =>
            {
                return b.New(callback, options);
            });

        return observer;
    }

    /// <summary>
    /// Creates and returns a <see cref="MutationObserver"/> that observes <paramref name="scrollContainer"/>.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="scrollContainer"></param>
    /// <param name="onElementsChanged"></param>
    /// <returns></returns>
    private static Var<MutationObserver> CreateMutationObserver(
        this SyntaxBuilder b,
        Var<Element> scrollContainer,
        Var<Action> onElementsChanged)
    {
        var callback = b.Def((SyntaxBuilder b, Var<List<MutationRecord>> mutations) =>
        {
            // Trigger refresh of tracked items for ANY type of mutation, not just added items
            // The entire children list might change based on the data model
            b.Call(onElementsChanged);
        });
        return b.On(
            b.MutationObserver(),
            b =>
            {
                var mutationObserver = b.New(callback);
                mutationObserver.observe(
                    scrollContainer,
                    new MutationObserver.ObserveOptions()
                    {
                        childList = true,
                        attributes = true,
                        subtree = true
                    });

                return mutationObserver;
            });
    }


    internal class ObservedElementsDiff
    {
        public List<Element> ToRemove { get; set; } = new List<Element>();
        public List<Element> ToAdd { get; set; } = new List<Element>();
    }

    private static Var<ObservedElementsDiff> DiffElements(
        this SyntaxBuilder b,
        Var<List<Element>> previous,
        Var<List<Element>> next)
    {
        var alreadyHandled = b.Get(previous, next, (currentlyObserved, toObserve) => currentlyObserved.Except(toObserve).ToList());
        var newElements = b.Get(previous, next, (currentlyObserved, toObserve) => toObserve.Except(currentlyObserved).ToList());
        var diff = b.NewObj<ObservedElementsDiff>(
            b =>
            {
                b.Set(x => x.ToRemove, alreadyHandled);
                b.Set(x => x.ToAdd, newElements);
            });

        return diff;
    }

    private static void ApplyObservedElementsDiff(
        this SyntaxBuilder b,
        Var<IntersectionObserver> intersectionObserver,
        Var<List<Element>> observedList,
        Var<ObservedElementsDiff> diff)
    {
        b.Foreach(b.Get(diff, x => x.ToRemove), (b, element) =>
        {
            b.On(intersectionObserver, b => b.unobserve(element));
            b.Remove(observedList, element);
        });

        b.Foreach(b.Get(diff, x=>x.ToAdd) , (b, element) =>
        {
            b.On(intersectionObserver, b => b.observe(element));
            //b.LogDebug("observe", element);
            b.Push(observedList, element);
        });
    }

    public static Var<HyperType.Subscription> IntersectionObserverSubscription<TItem>(
        this SyntaxBuilder b,
        Var<IntersectionObserverSubscriptionOptions<TItem>> options)
    {
        var observedItems = b.Call(b.Get(options, x => x.GetObservedItems));
        //b.LogDebug("observed items", observedItems);
        return b.If(
            // No items
            b.Get(observedItems, x => !x.Any()),
            b =>
            {
                //b.LogDebug("No items to observe, unsubscribe");
                return b.NoSubscription();
            },
            b =>
            {
                //b.LogDebug("scrollContainer", scrollContainer);

                var mapItemToElement = b.Def((SyntaxBuilder b, Var<TItem> item) =>
                {
                    var element = b.Call(b.Get(options, x => x.MapElement), item.As<TItem>());
                    b.If(
                        b.Not(b.HasObject(element)),
                        b =>
                        {
                            b.LogDebug("item has no element", item);
                        });
                    return element;
                });

                //b.SetItemsToObserve(scrollContainer, observedItems);
                //b.SyncItemsToObserveToIntersectionObserver(scrollContainer, mapItemToElement);

                // Inside the subscription, handle elements
                var subscription = b.MakeSubscription(IntersectionObserverSubscriber, b.NewObj<IntersectionObserverSubscriberOptions>(
                    b =>
                    {
                        b.Set(x => x.GetContainer, b.Get(options, x => x.GetContainer));
                        b.Set(x => x.OnVisible, b.Def((SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Element> element) =>
                        {
                            var item = b.Call(b.Get(options, x => x.MapItem), element);
                            b.If(
                                b.Not(b.HasObject(item)),
                                b =>
                                {
                                    b.LogDebug("No item for element", element);
                                },
                                b =>
                                {
                                    b.Call(b.Get(options, x => x.OnSeen), dispatch, item);
                                });
                        }));
                        b.Set(x => x.GetObservedElements, b.Def((SyntaxBuilder b) =>
                        {
                            return b.Map(observedItems, mapItemToElement);
                        }));
                    }));

                //b.LogDebug("IntersectionObserverSubscription.IntersectionObserverSubscriber", subscription);
                return subscription;
            });
    }

    //private static void SyncItemsToObserveToIntersectionObserver(
    //    this SyntaxBuilder b,
    //    Var<Element> container,
    //    Var<Func<object, Element>> mapItemToElement)
    //{
    //    var toObserveItemsWeakMap = b.GetRef(b.Const(scrollContainerItemsToObserve));
    //    b.If(
    //        b.HasObject(toObserveItemsWeakMap),
    //        b =>
    //        {
    //            var toObserveItems = b.On(toObserveItemsWeakMap, b => b.get<List<object>>(container));
    //            b.If(
    //                b.HasObject(toObserveItems),
    //                b =>
    //                {
    //                    var validElements = b.Get(
    //                        b.Map(toObserveItems, mapItemToElement),
    //                        b.Def((SyntaxBuilder b, Var<Element> element) =>
    //                        {
    //                            return b.HasObject(element);
    //                        }),
    //                        (elements, hasObject) => elements.Where(hasObject).ToList());

    //                    //b.LogDebug("SyncItemsToObserveToIntersectionObserver.validElements", validElements);
    //                    b.SyncObservedElements(container, validElements);
    //                });
    //        });
    //}

    internal class IntersectionObserverSubscriberState
    {
        public Element Container { get; set; }
        public IntersectionObserver IntersectionObserver { get; set; }
        public List<Element> ObservedElements { get; set; } = new List<Element>();
        public MutationObserver MutationObserver { get; set; }
    }

    public static Var<System.Action> IntersectionObserverSubscriber(
        this SyntaxBuilder b,
        Var<HyperType.Dispatcher> dispatch,
        Var<IntersectionObserverSubscriberOptions> options)
    {
        var intersectionObserverState = b.NewObj<IntersectionObserverSubscriberState>();

        b.RequestAnimationFrame(b => b.RequestAnimationFrame(
            b =>
            {
                var container = b.Call(b.Get(options, x => x.GetContainer));
                b.If(b.HasObject(container),
                    b =>
                    {
                        b.LogDebug("observed container", container);
                        b.Set(intersectionObserverState, x => x.Container, container);

                        var observer = b.CreateIntersectionObserver(container, b.Def((SyntaxBuilder b, Var<Element> element) =>
                        {
                            b.Call(b.Get(options, x => x.OnVisible), dispatch, element);
                        }));

                        b.Set(intersectionObserverState, x => x.IntersectionObserver, observer);

                        var mutationObserver = b.CreateMutationObserver(
                            container, b.Def((SyntaxBuilder b) =>
                            {
                                var newObservedElementsList = b.Call(b.Get(options, x => x.GetObservedElements));
                                var diff = b.DiffElements(
                                    b.Get(intersectionObserverState, x => x.ObservedElements),
                                    newObservedElementsList);
                                b.ApplyObservedElementsDiff(
                                    b.Get(intersectionObserverState, x => x.IntersectionObserver),
                                    b.Get(intersectionObserverState, x => x.ObservedElements),
                                    diff);

                                //b.Call<SyntaxBuilder, Element, Func<object, Element>>(SyncItemsToObserveToIntersectionObserver, container, b.Get(options, x => x.MapItemToElement));
                            }));
                        b.Set(intersectionObserverState, x => x.MutationObserver, mutationObserver);
                    },
                    b =>
                    {
                        b.LogDebug("No observed container");
                    });
            }));

        return b.Def((SyntaxBuilder b) =>
        {
            var container = b.Get(intersectionObserverState, x => x.Container);
            var intersectionObserver = b.Get(intersectionObserverState, x => x.IntersectionObserver);
            var mutationObserver = b.Get(intersectionObserverState, x => x.MutationObserver);
            b.If(
                b.HasObject(intersectionObserver),
                b =>
                {
                    b.On(intersectionObserver, b => b.disconnect());
                });

            b.If(
                b.HasObject(mutationObserver),
                b =>
                {
                    b.On(mutationObserver, b => b.disconnect());
                });
        });
    }
}
