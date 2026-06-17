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
    public Element Container { get; set; }
    public System.Action<HyperType.Dispatcher, Element> OnVisible { get; set; }
    public System.Func<object, Element> MapItemToElement { get; set; }
}

public static class IntersectionObserverExtensions
{
    /// <summary>
    /// scroll element -> IntersectionObserver
    /// </summary>
    internal static Reference<WeakMap> scrollContainerObservers { get; set; } = new Reference<WeakMap>();
    /// <summary>
    /// scroll element -> List Element 
    /// </summary>
    internal static Reference<WeakMap> scrollContainerObservedElements { get; set; } = new Reference<WeakMap>();

    /// <summary>
    /// scroll container - List of data objects
    /// </summary>
    internal static Reference<WeakMap> scrollContainerItemsToObserve { get; set; } = new Reference<WeakMap>();

    /// <summary>
    /// Creates and returns an <see cref="IntersectionObserver"/> that triggers <paramref name="onVisible"/> on intersection.
    /// The intersection observer is added to <see cref="scrollContainerObservers"/>.
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
        var observersWeakMap =
        b.If(
            b.Not(
                b.HasObject(b.GetRef(b.Const(scrollContainerObservers)))),
            b =>
            {
                var observersWeakMap = b.On(b.WeakMap(), b => b.Construct());
                b.SetRef(b.Const(scrollContainerObservers), observersWeakMap);
                b.SetProperty(b.Window(), b.Const(nameof(scrollContainerObservers)), observersWeakMap);
                return observersWeakMap;
            },
            b =>
            {
                return b.GetRef(b.Const(scrollContainerObservers));
            });

        b.If(b.On(observersWeakMap, b => b.has(scrollContainer)), b => b.Throw(b.Const("IntersectionObserver is already registered!")));

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

        b.On(observersWeakMap, b => b.set(scrollContainer, observer));

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

    /// <summary>
    /// Get the <seealso cref="IntersectionObserver"/> associated to the scroll element in <see cref="scrollContainerObservers"/>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="scrollElement"></param>
    /// <returns></returns>
    private static Var<IntersectionObserver> GetIntersectionObserver(
        this SyntaxBuilder b,
        Var<Element> scrollElement)
    {
        var undefined = b.GetProperty<IntersectionObserver>(b.Window(), "undefined");
        return b.If(b.HasObject(b.GetRef(b.Const(scrollContainerObservers))),
            b =>
            {
                var weakMap = b.GetRef(b.Const(scrollContainerObservers));
                return b.On(weakMap, b => b.get<IntersectionObserver>(scrollElement));
            },
            b =>
            {
                return undefined;
            });
    }

    /// <summary>
    /// Associates the list of data items to observe to the scroll container in <see cref="scrollContainerItemsToObserve"/>
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="scrollContainer"></param>
    /// <param name="toObserve"></param>
    private static void SetItemsToObserve<TItem>(
        this ISyntaxBuilder b,
        Var<Element> scrollContainer,
        Var<List<TItem>> toObserve)
    {
        var itemsWeakMap =
        b.If(
            b.Not(
                b.HasObject(b.GetRef(b.Const(scrollContainerItemsToObserve)))),
            b =>
            {
                var itemsWeakMap = b.On(b.GetClass<WeakMap>(), b => b.Construct());
                b.SetRef(b.Const(scrollContainerItemsToObserve), itemsWeakMap);
                b.SetProperty(b.GetProperty<Window>(b.Self(), "window"), b.Const(nameof(scrollContainerItemsToObserve)), itemsWeakMap);
                return itemsWeakMap;
            },
            b =>
            {
                return b.GetRef(b.Const(scrollContainerItemsToObserve));
            });

        b.On(itemsWeakMap, b => b.set(scrollContainer, toObserve));
    }

    /// <summary>
    /// Associates the list of observed elements to the <paramref name="scrollContainer"/> in <see cref="scrollContainerObservedElements"/>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="scrollContainer"></param>
    /// <param name="toObserve"></param>
    private static void SyncObservedElements(
        this SyntaxBuilder b,
        Var<Element> scrollContainer,
        Var<List<Element>> toObserve)
    {
        // The whole sync only makes sense if the intersection observer is already created.
        // Otherwise, syncing later is not possible because observers do not list observed elements,
        // so there's no list to compare to
        var intersectionObsever = b.GetIntersectionObserver(scrollContainer);
        b.If(
            b.HasObject(intersectionObsever),
            b =>
            {
                //b.LogDebug("SetObservedElements.intersectionObsever", intersectionObsever);
                //b.LogDebug("SetObservedElements.toObserve", toObserve);
                var elementsWeakMap =
                b.If(
                    b.Not(
                        b.HasObject(b.GetRef(b.Const(scrollContainerObservedElements)))),
                    b =>
                    {
                        var elementsWeakMap = b.On(b.WeakMap(), b => b.Construct());
                        b.SetRef(b.Const(scrollContainerObservedElements), elementsWeakMap);
                        return elementsWeakMap;
                    },
                    b =>
                    {
                        return b.GetRef(b.Const(scrollContainerObservedElements));
                    });

                var currentlyObserved = b.If(
                    b.HasObject(b.On(elementsWeakMap, x => x.get<List<Element>>(scrollContainer))),
                    b => b.On(elementsWeakMap, x => x.get<List<Element>>(scrollContainer)),
                    b =>
                    {
                        var emptyList = b.NewCollection<Element>();
                        b.On(elementsWeakMap, b => b.set(scrollContainer, emptyList));
                        return emptyList;
                    });


                var alreadyHandled = b.Get(currentlyObserved, toObserve, (currentlyObserved, toObserve) => currentlyObserved.Except(toObserve).ToList());
                var newElements = b.Get(currentlyObserved, toObserve, (currentlyObserved, toObserve) => toObserve.Except(currentlyObserved).ToList());

                b.Foreach(alreadyHandled, (b, element) =>
                {
                    b.On(intersectionObsever, b => b.unobserve(element));
                    b.Remove(currentlyObserved, element);
                });

                b.Foreach(newElements, (b, element) =>
                {
                    b.On(intersectionObsever, b => b.observe(element));
                    //b.LogDebug("observe", element);
                    b.Push(currentlyObserved, element);
                });

                //b.LogDebug("currentlyObserved", currentlyObserved);
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
                var scrollContainer = b.Call(b.Get(options, x => x.GetContainer));
                return b.If(
                    b.HasObject(scrollContainer),
                    b =>
                    {
                        //b.LogDebug("scrollContainer", scrollContainer);

                        var mapItemToElement = b.Def((SyntaxBuilder b, Var<object> item) =>
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

                        b.SetItemsToObserve(scrollContainer, observedItems);
                        b.SyncItemsToObserveToIntersectionObserver(scrollContainer, mapItemToElement);

                        // Inside the subscription, handle elements
                        var subscription = b.MakeSubscription(IntersectionObserverSubscriber, b.NewObj<IntersectionObserverSubscriberOptions>(
                            b =>
                            {
                                b.Set(x => x.Container, scrollContainer);
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
                                b.Set(x => x.MapItemToElement, mapItemToElement);
                            }));

                        //b.LogDebug("IntersectionObserverSubscription.IntersectionObserverSubscriber", subscription);
                        return subscription;
                    },
                    b =>
                    {
                        //b.LogDebug("Intersection observer unsubscribe!");
                        return b.NoSubscription();
                    });
            });
    }

    private static void SyncItemsToObserveToIntersectionObserver(
        this SyntaxBuilder b,
        Var<Element> container,
        Var<Func<object, Element>> mapItemToElement)
    {
        var toObserveItemsWeakMap = b.GetRef(b.Const(scrollContainerItemsToObserve));
        b.If(
            b.HasObject(toObserveItemsWeakMap),
            b =>
            {
                var toObserveItems = b.On(toObserveItemsWeakMap, b => b.get<List<object>>(container));
                b.If(
                    b.HasObject(toObserveItems),
                    b =>
                    {
                        var validElements = b.Get(
                            b.Map(toObserveItems, mapItemToElement),
                            b.Def((SyntaxBuilder b, Var<Element> element) =>
                            {
                                return b.HasObject(element);
                            }),
                            (elements, hasObject) => elements.Where(hasObject).ToList());

                        //b.LogDebug("SyncItemsToObserveToIntersectionObserver.validElements", validElements);
                        b.SyncObservedElements(container, validElements);
                    });
            });
    }

    public static Var<System.Action> IntersectionObserverSubscriber(
        this SyntaxBuilder b,
        Var<HyperType.Dispatcher> dispatch,
        Var<IntersectionObserverSubscriberOptions> options)
    {
        //b.LogDebug("IntersectionObserverSubscriber");
        var container = b.Get(options, x => x.Container);
        var observer = b.CreateIntersectionObserver(container, b.Def((SyntaxBuilder b, Var<Element> element) =>
        {
            b.Call(b.Get(options, x => x.OnVisible), dispatch, element);
        }));

        b.Call<SyntaxBuilder, Element, Func<object, Element>>(SyncItemsToObserveToIntersectionObserver, container, b.Get(options, x => x.MapItemToElement));

        var mutationObserver = b.CreateMutationObserver(
            container, b.Def((SyntaxBuilder b) =>
            {
                //b.LogDebug("=== MUTATION ===");
                b.Call<SyntaxBuilder, Element, Func<object, Element>>(SyncItemsToObserveToIntersectionObserver, container, b.Get(options, x => x.MapItemToElement));
            }));

        return b.Def((SyntaxBuilder b) =>
        {
            b.If(
                b.HasObject(observer),
                b =>
                {
                    b.On(observer, b => b.disconnect());
                });
            b.On(b.GetRef(b.Const(scrollContainerObservers)), b => b.delete(container));
            b.On(b.GetRef(b.Const(scrollContainerObservedElements)), b => b.delete(container));

            b.If(
                b.HasObject(mutationObserver),
                b =>
                {
                    b.On(mutationObserver, b => b.disconnect());
                });

            //b.LogDebug("Cleanup observer subscription");
        });
    }

}
