using System.Web;
using System;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Linq;
using System.Collections.Generic;

namespace Metapsi.Html;

public interface IModuleResource: IAutoLoader
{
    public string ModulePath { get; }
    public Module Module { get; }
}

public class ModuleResource : IModuleResource
{
    public ModuleResource()
    {
        this.ModulePath = this.GetType() + ".js";
    }

    public string ModulePath { get; set; } 
    public Module Module { get; set; }
}

public interface ICustomElement
{
    string Tag { get; }
    public Module Module { get; }
}

/// <summary>
/// Keeps on-the-spot custom element definitions 
/// </summary>
public class CustomElement : ICustomElement, IModuleResource
{
    public string Tag { get; set; }
    public Module Module { get; set; }

    public string ModulePath => this.Tag + ".js";
}

public interface ICustomElementProps<T>
{

}

public interface IRootControl
{
}

internal class RootControl : IRootControl
{
    public Var<IVNode> RootVirtualNode { get; set; }
}

public abstract class CustomElement<TModel> : ICustomElement, IModuleResource
{
    public string Tag { get; set; }

    public string ModulePath => this.Tag + ".js";

    public CustomElement()
    {
        this.Tag = CustomElementExtensions.GetCustomElementTagName(this.GetType());
    }

    internal LayoutBuilder rootLayoutBuilder { get; set; }
    /// <summary>
    /// could be different in case we use shadowDom
    /// </summary>
    internal Var<string> layoutRootTag { get; set; }

    public abstract Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<Element> element);

    public abstract IRootControl OnRender(LayoutBuilder b, Var<TModel> model);

    public virtual Var<Node> OnAttach(SyntaxBuilder b, Var<Element> element)
    {
        return element.As<Node>();
    }

    public virtual void OnCleanup(SyntaxBuilder b, Var<Element> element)
    {

    }

    public virtual void OnSubscribe(SyntaxBuilder b, Var<TModel> model, Var<List<HyperType.Subscription>> subscriptions)
    {
    }

    // style cannot be set on shadow root, so hide this one until I figure out how to do it better
    private IRootControl Root(Action<PropsBuilder<object>> setProps, params Var<IVNode>[] children)
    {
        return new RootControl() { RootVirtualNode = rootLayoutBuilder.H(this.layoutRootTag, setProps, children) };
    }

    public IRootControl Root(params Var<IVNode>[] children)
    {
        return Root(b => { }, children);
    }

    public Module Module
    {
        get
        {
            var module = ModuleBuilder.New(
                b =>
                {
                    b.Call(b =>
                    {
                        //AppMapExtensions.SetAppMap(b, appMap);
                        //var empty = b.NewObj<object>(b => { });

                        b.DefineCustomElement(
                            b.NewObj<HyperappCustomElementDefinition>(
                                b=>
                                {
                                    b.Set(x => x.Tag, b.Const(this.Tag));
                                    b.Set(x => x.Init, b.Def<SyntaxBuilder, Element, HyperType.StateWithEffects>(this.OnInit).As<Func<Element, HyperType.Init>>());
                                    b.Set(x => x.View, b.Def((LayoutBuilder b, Var<string> tagName, Var<TModel> model) =>
                                    {
                                        this.rootLayoutBuilder = b;
                                        this.layoutRootTag = tagName;
                                        return (this.OnRender(b, model) as RootControl).RootVirtualNode;
                                    }).As<Func<string, object, IVNode>>());
                                    b.Set(x => x.SubscribeFn, b.Def((SyntaxBuilder b, Var<TModel> model) =>
                                    {
                                        var subscriptions = b.NewCollection<HyperType.Subscription>();
                                        this.OnSubscribe(b, model, subscriptions);
                                        return subscriptions;
                                    }).As<Func<object, List<HyperType.Subscription>>>());
                                    b.Set(x => x.Attach, b.Def<SyntaxBuilder, Element, Node>(this.OnAttach));
                                    b.Set(x => x.Cleanup, b.Def<SyntaxBuilder, Element>(this.OnCleanup));
                                }));
                            
                           //,
                           // b.Def((LayoutBuilder b, Var<string> tagName, Var<TModel> model) =>
                           // {
                           //     this.rootLayoutBuilder = b;
                           //     this.layoutRootTag = tagName;
                           //     return (this.OnRender(b, model) as RootControl).RootVirtualNode;
                           // }),
                           // b.Def((SyntaxBuilder b, Var<TModel> model) =>
                           // {
                           //     var subscriptions = b.NewCollection<HyperType.Subscription>();
                           //     this.OnSubscribe(b, model, subscriptions);
                           //     return subscriptions;
                           // }));
                    });
                });

            return module;
        }
    }
}

public abstract class CustomElement<TModel, TProps> : CustomElement<TModel>, ICustomElementProps<TProps>
{
    public override Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<Element> element)
    {
        return OnInitProps(b, b.GetInitProps<TProps>(element));
    }
    public abstract Var<HyperType.StateWithEffects> OnInitProps(SyntaxBuilder b, Var<TProps> props);
}


public class ArcCustomElementDefinition
{
    public string Tag { get; set; }
    public Action<Element> Render { get; set; }
    public Action<Element> Attach { get; set; }
    public Action<Element> Cleanup { get; set; }
}

public static partial class CustomElementExtensions
{
    private const string ExternalScriptName = "metapsi-custom-elements.js";

    /// <summary>
    /// Define a render/attach/cleanup custom element
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="render"></param>
    /// <param name="attach"></param>
    /// <param name="cleanup"></param>
    public static void DefineCustomElement(
        this SyntaxBuilder b,
        Var<string> tagName,
        Var<Action<Element>> render,
        Var<Action<Element>> attach,
        Var<Action<Element>> cleanup)
    {
        var metapsiCustomElementsJsResource = b.AddEmbeddedResourceMetadata(typeof(CustomElementExtensions).Assembly, ExternalScriptName);
        var define = b.ImportName<Action<string, Action<Element>, Action<Element>, Action<Element>>>(metapsiCustomElementsJsResource, "defineRACCustomElement");
        b.Call(define, tagName, render, attach, cleanup);
    }

    public static void DefineCustomElement(
        SyntaxBuilder b,
        Var<ArcCustomElementDefinition> definition)
    {
        b.DefineCustomElement(
            b.Get(definition, x => x.Tag),
            b.Get(definition, x => x.Render),
            b.Get(definition, x => x.Attach),
            b.Get(definition, x => x.Cleanup));
    }

    /// <summary>
    /// Define a render/attach/cleanup custom element
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="render"></param>
    /// <param name="attach"></param>
    /// <param name="cleanup"></param>
    public static void DefineCustomElement(
        this SyntaxBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<Element>> render,
        Action<SyntaxBuilder, Var<Element>> attach = null,
        Action<SyntaxBuilder, Var<Element>> cleanup = null)
    {
        if (attach == null) attach = (SyntaxBuilder b, Var<Element> node) => { };
        if (cleanup == null) cleanup = (SyntaxBuilder b, Var<Element> node) => { };

        var jsRender = b.Def("render", render);
        var jsAttach = b.Def("attach", attach);
        var jsCleanup = b.Def("cleanup", cleanup);
        b.DefineCustomElement(b.Const(tagName), jsRender, jsAttach, jsCleanup);
    }

    public static IHtmlNode HtmlCustomElement(
        this HtmlBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<Element>> render,
        Action<SyntaxBuilder, Var<Element>> attach = null,
        Action<SyntaxBuilder, Var<Element>> cleanup = null)
    {
        return b.HtmlScriptModule(b =>
        {
            b.DefineCustomElement(tagName, render, attach, cleanup);
        });
    }

    public static void AddCustomElement(
        this HtmlBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<Element>> render,
        Action<SyntaxBuilder, Var<Element>> attach = null,
        Action<SyntaxBuilder, Var<Element>> cleanup = null)
    {
        b.HeadAppend(b.HtmlCustomElement(tagName, render, attach, cleanup));
    }


    /// <summary>
    /// Retrieves the 'props' property of element as T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static Var<T> GetInitProps<T>(this SyntaxBuilder b, Var<Element> e)
    {
        var initProps = b.GetProperty<T>(e, "props");
        return initProps;
    }


    //public static IHtmlNode CustomElementSrcScriptTag(
    //    this HtmlBuilder b,
    //    ICustomElement customElement)
    //{
    //    var jsFile = $"{customElement.Tag}.js";
    //    return new HtmlNode()
    //    {
    //        Tags = new System.Collections.Generic.List<HtmlTag>()
    //        {
    //            SrcScriptTag(jsFile, "metapsi-custom-element", "1.0", customElement.Module.Hash())
    //        }
    //    };
    //}

    //public static HtmlTag SrcScriptTag(
    //    string jsFile,
    //    string packageName,
    //    string packageVersion,
    //    string fileHash = null)
    //{
    //    return new HtmlTag("script")
    //    {
    //        Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
    //        {
    //            {
    //                "type",
    //                new HtmlAttribute()
    //                {
    //                    Value = "module"
    //                }
    //            },
    //            {
    //                "src",
    //                new HtmlAttribute()
    //                {
    //                    ResourceMetadata = new ResourceMetadata()
    //                    {
    //                        ResourceType = "metapsi-js-module",
    //                        LogicalName = jsFile,
    //                        PackageName = packageName,
    //                        PackageVersion = packageVersion,
    //                        FileHash = fileHash
    //                    }
    //                }
    //            }
    //        }
    //    };
    //}


    public static HtmlTag SrcScriptTag(this IModuleResource moduleResource)
    {
        return new HtmlTag("script")
        {
            Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
            {
                {
                    "type",
                    new HtmlAttribute()
                    {
                        Value = "module"
                    }
                },
                {
                    "src",
                    new HtmlAttribute()
                    {
                        Value = $"/metapsi-js-module/{moduleResource.ModulePath}"
                    }
                }
            }
        };
    }

    //public static HtmlTag CustomElementSrcScriptTag(
    //    this LayoutBuilder b,
    //    ICustomElement customElement)
    //{
    //    var jsFile = $"{customElement.Tag}.js";
    //    return SrcScriptTag(jsFile, "metapsi-custom-element", "1.0", customElement.Module.Hash());
    //}

    //public static HtmlTag CustomElementSrcScriptTag(
    //    this LayoutBuilder b,
    //    string tag,
    //    string packageName,
    //    string packageVersion,
    //    string fileHash = null)
    //{
    //    var jsFile = $"{tag}.js";
    //    return SrcScriptTag(jsFile, packageVersion, packageVersion, fileHash);
    //}
}


