using Metapsi.Syntax;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Metapsi.Html;

public static class ModuleExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tag"></param>
    public static void AddRequiredTagMetadata(this SyntaxBuilder b, HtmlTag tag)
    {
        var metadata = new Metadata()
        {
            Key = "required-tag"
        };

        metadata.Data.Add(ToMetadata(tag));
        b.AddMetadata(metadata);
    }

    private static Metadata ToMetadata(IHtmlNode node)
    {
        if (node is HtmlText textTag)
        {
            return new Metadata()
            {
                Key = "text",
                Value = textTag.Text
            };
        }
        else
        {
            var tag = node as HtmlTag;
            return new Metadata()
            {
                Key = tag.Tag,
                Data = new HashSet<Metadata>()
                {
                    new Metadata()
                    {
                        Key = "attr",
                        Data = tag.Attributes.Select(x=> new Metadata()
                        {
                            Key = x.Key,
                            Value = x.Value
                        }).ToHashSet()
                    },
                    new Metadata()
                    {
                        Key = "children",
                        Data = new HashSet<Metadata>(tag.Children.Select(ToMetadata))
                    }
                }
            };
        }
    }

    public static List<IHtmlNode> GetRequiredTagsMetadata(this Metapsi.Syntax.Module module)
    {
        List<IHtmlNode> requiredNodes = new List<IHtmlNode>();

        var requiredTags = module.Metadata.Where(x => x.Key == "required-tag");
        foreach (var tag in requiredTags)
        {
            var data = tag.Data.SingleOrDefault();
            if (data != null)
            {
                requiredNodes.Add(GetTag(data));
            }
        }

        return requiredNodes;
    }

    private static IHtmlNode GetTag(this Metapsi.Syntax.Metadata metadata)
    {
        var tag = new HtmlTag(metadata.Key);

        var attr = metadata.Data.SingleOrDefault(x => x.Key == "attr");
        if (attr != null)
        {
            foreach (var attribute in attr.Data)
            {
                tag.Attributes[attribute.Key] = attribute.Value;
            }
        }

        var children = metadata.Data.SingleOrDefault(x => x.Key == "children");
        if (children != null)
        {
            foreach (var child in children.Data)
            {
                tag.Children.Add(GetTag(child));
            }
        }

        return tag;
    }

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="b"></param>
    ///// <param name="action"></param>
    //public static void AddRequiredTagMetadata(this SyntaxBuilder b, Action<HtmlTag> action)
    //{
    //    HtmlTag tag = new HtmlTag();
    //    action(tag);
    //    b.AddRequiredTagMetadata(tag);
    //}

    //    /// <summary>
    //    /// Gets HTML related module required tags of type <paramref name="tag"/>
    //    /// </summary>
    //    /// <param name="module"></param>
    //    /// <param name="tag"></param>
    //    /// <returns></returns>
    //    public static List<DistinctTag> GetDistinctTags(this ModuleDefinition module, string tag)
    //    {
    //        var distinctTagConstants = module.Consts.Where(x => x.Value is DistinctTag);
    //        var tagConstants = distinctTagConstants.Where(x => (x.Value as DistinctTag).Tag == tag).ToList();
    //        var tags = tagConstants.Select(x => x.Value as DistinctTag).ToList();
    //        return tags;
    //    }

    //    /// <summary>
    //    /// Removes and returns HTML related module required tags of type <paramref name="tag"/>
    //    /// </summary>
    //    /// <param name="module"></param>
    //    /// <param name="tag"></param>
    //    /// <returns></returns>
    //    /// <remarks>Removing distinct tags from the module ensures HTML dependencies of a script are not included in the script code itself</remarks>
    //    public static List<DistinctTag> PopDistinctTags(this Module module, string tag)
    //    {
    //        var tags = GetDistinctTags(module, tag);
    //        module.Consts.RemoveAll(x => tags.Contains(x.Value));
    //        return tags;
    //    }

    //    /// <summary>
    //    /// Gets script tags required by the module if executed in an HTML page
    //    /// </summary>
    //    /// <param name="module"></param>
    //    /// <returns></returns>
    //    public static List<DistinctTag> GetScriptTags(this Module module)
    //    {
    //        return module.GetDistinctTags("script");
    //    }

    //    /// <summary>
    //    /// Removes and returns script tags required by the module if executed in an HTML page
    //    /// </summary>
    //    /// <param name="module"></param>
    //    /// <returns></returns>
    //    /// <remarks>Removing script tags from the module ensures they are not included in the script code itself</remarks>
    //    public static List<DistinctTag> PopScriptTags(this Module module)
    //    {
    //        return module.PopDistinctTags("script");
    //    }

    //    public static IHtmlNode DynamicTagLoader(this HtmlBuilder b)
    //    {
    //        return b.HtmlScriptModule(
    //            b =>
    //            {
    //                b.SetId("id-dynamic-tag-loader");
    //            },
    //            b =>
    //            {
    //                var loadScriptHandler = b.Def(
    //                    (SyntaxBuilder b) =>
    //                    {
    //                        var lastPromise = b.Ref(b.PromiseResolve(b.Const(true)));

    //                        b.AddEventListener(b.Window(), b.Const("addHeadTag"), b.Def((SyntaxBuilder b, Var<CustomEvent<AddHeadTagDetails>> e) =>
    //                        {
    //                            b.SetRef(lastPromise, b.PromiseThen(b.GetRef(lastPromise), (SyntaxBuilder b, Var<object> _) =>
    //                            {
    //                                var tagName = b.Get(e, x => x.detail.Tag.Tag);
    //                                var attributes = b.Get(e, x => x.detail.Tag.Attributes);
    //                                var selector = b.Ref(tagName);
    //                                b.Foreach(
    //                                    b.ObjectKeys(attributes),
    //                                    (b, attribute) =>
    //                                    {
    //                                        b.SetRef(selector, b.Concat(b.GetRef(selector), b.Const("["), attribute, b.Const("=\""), b.GetProperty<string>(attributes, attribute), b.Const("\"]")));
    //                                    });

    //                                var existingTag = b.QuerySelector(b.GetRef(selector));

    //                                return b.If(
    //                                    b.HasObject(existingTag),
    //                                    b =>
    //                                    {
    //                                        var added = b.Get(e, x => x.detail.Added);
    //                                        b.If(
    //                                            b.HasObject(added),
    //                                            b =>
    //                                            {
    //                                                b.Call(added);
    //                                            });
    //                                        return b.Const(true);
    //                                    },
    //                                    b =>
    //                                    {
    //                                        var element = b.CreateElement(tagName);
    //                                        b.ObjectAssign(element, attributes);
    //                                        b.NodeAppendChild(b.Get(b.Document(), x => x.head), element);
    //                                        var added = b.Get(e, x => x.detail.Added);
    //                                        b.If(
    //                                            b.HasObject(added),
    //                                            b =>
    //                                            {
    //                                                b.Call(added);
    //                                            });
    //                                        return b.Const(true);
    //                                    });
    //                            }));
    //                        }));

    //                        //b.AddEventListener(b.Window(), b.Const("loadScript"), b.Def((SyntaxBuilder b, Var<CustomEvent<HeadScriptTagDetails>> e) =>
    //                        //{
    //                        //    b.SetRef(lastPromise, b.PromiseThen(b.GetRef(lastPromise), (SyntaxBuilder b, Var<object> _) =>
    //                        //    {
    //                        //        var scriptSrc = b.Get(e, x => x.detail.Src);

    //                        //        var query = b.StringConcat(b.Const("script[src=\""), scriptSrc, b.Const("\"]"));
    //                        //        b.Log("src query", query);
    //                        //        var existingScript = b.QuerySelector(query);

    //                        //        return b.If(
    //                        //            b.HasObject(existingScript),
    //                        //            b => b.Const(true),
    //                        //            b =>
    //                        //            {
    //                        //                var script = b.CreateElement(b.Const("script"));
    //                        //                b.SetProperty(script, b.Const("src"), scriptSrc);
    //                        //                b.If(
    //                        //                    b.HasValue(b.Get(e, x => x.detail.Type)),
    //                        //                    b =>
    //                        //                    {
    //                        //                        b.SetProperty(script, b.Const("type"), b.Get(e, x => x.detail.Type));
    //                        //                    });
    //                        //                b.NodeAppendChild(b.Get(b.Document(), x => x.head), script);
    //                        //                return b.Const(true);
    //                        //            });
    //                        //    }));
    //                        //}));

    //                        //b.AddEventListener(b.Window(), b.Const("loadStylesheet"), b.Def((SyntaxBuilder b, Var<CustomEvent<HeadLinkTagDetails>> e) =>
    //                        //{
    //                        //    b.SetRef(lastPromise, b.PromiseThen(b.GetRef(lastPromise), (SyntaxBuilder b, Var<object> _) =>
    //                        //    {
    //                        //        var href = b.Get(e, x => x.detail.Href);

    //                        //        var query = b.StringConcat(b.Const("link[href=\""), href, b.Const("\"]"));
    //                        //        b.Log("href query", query);
    //                        //        var existingTag = b.QuerySelector(query);

    //                        //        return b.If(
    //                        //            b.HasObject(existingTag),
    //                        //            b => b.Const(true),
    //                        //            b =>
    //                        //            {
    //                        //                var link = b.CreateElement(b.Const("link"));
    //                        //                b.SetProperty(link, b.Const("href"), href);
    //                        //                b.If(
    //                        //                    b.HasValue(b.Get(e, x => x.detail.Rel)),
    //                        //                    b =>
    //                        //                    {
    //                        //                        b.SetProperty(link, b.Const("rel"), b.Get(e, x => x.detail.Rel));
    //                        //                    });
    //                        //                b.NodeAppendChild(b.Get(b.Document(), x => x.head), link);
    //                        //                return b.Const(true);
    //                        //            });
    //                        //    }));
    //                        //}));
    //                    });

    //                var readyState = b.Get(b.Document(), x => x.readyState);

    //                b.If(
    //                    b.AreEqual(readyState, b.Const("loading")),
    //                    b =>
    //                    {
    //                        b.AddEventListener(
    //                            b.Window(),
    //                            b.Const("DOMContentLoaded"),
    //                            loadScriptHandler);
    //                    },
    //                    b =>
    //                    {
    //                        b.Call(loadScriptHandler);
    //                    });

    //            });
    //    }

    //public static Var<Promise> AddHeadTag(this SyntaxBuilder b, DistinctTag tag)
    //{
    //    var tagLoader = b.GetElementById("id-dynamic-tag-loader");
    //    return b.If(
    //        b.Not(b.HasObject(tagLoader)),
    //        b =>
    //        {
    //            return b.PromiseReject(b.New<Html.Error>(b.Const("Dynamic tag loader not found")));
    //        },
    //        b =>
    //        {
    //            var resolve = b.Ref(b.NewObj().As<Action<bool>>());
    //            var addedPromise = b.NewPromise(b.Def((SyntaxBuilder b, Var<Action<bool>> resolveFunc, Var<Action<Html.Error>> rejectFunc) =>
    //            {
    //                b.SetRef(resolve, resolveFunc);
    //            }));
    //            b.DispatchEvent(
    //                b.Window(),
    //                b.NewCustomEvent<AddHeadTagDetails>(
    //                    b.Const("addHeadTag"),
    //                    b.SetProps<AddHeadTagDetails>(
    //                        b.NewObj(),
    //                        b =>
    //                        {
    //                            b.Set(x => x.Tag, b.Const(tag));
    //                            b.Set(x => x.Added, b.Def((SyntaxBuilder b) => { b.Call(b.GetRef(resolve), b.Const(true)); }));
    //                            b.Set(x => x.Loaded, b.Def((SyntaxBuilder b) => { }));
    //                        })));
    //            return addedPromise;
    //        });
    //}
}

//public interface AddHeadTagDetails
//{
//    DistinctTag Tag { get; set; }
//    System.Action Added { get; set; }
//    System.Action Loaded { get; set; }
//}

//public interface HeadScriptTagDetails
//{
//    string Src { get; set; }
//    string Type { get; set; }
//    System.Action Added { get; set; }
//    System.Action Loaded { get; set; }
//}

//public interface HeadLinkTagDetails
//{
//    string Href { get; set; }
//    string Rel { get; set; }
//    System.Action Added { get; set; }
//    System.Action Loaded { get; set; }
//}