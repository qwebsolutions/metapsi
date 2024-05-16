using Metapsi.Ui;
using System.Text;
using System.Web;
using System;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Dom;
using System.Linq;
using static Metapsi.Html.CustomElementExtensions;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Metapsi.Html;

public static partial class CustomElementExtensions
{
    /// <summary>
    /// Defines a static custom element with no behavior by setting .innerHTML
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="buildContent"></param>
    public static void DefineCustomElement(this HtmlBuilder b, string tagName, params IHtmlNode[] children)
    {
        var innerHtml = HttpUtility.JavaScriptStringEncode(string.Join("\n", children.Select(x => x.ToHtml())));

        StringBuilder scriptBuilder = new StringBuilder();
        scriptBuilder.AppendLine();
        scriptBuilder.AppendLine($"customElements.define(\"{tagName}\", class extends HTMLElement {{");
        scriptBuilder.AppendLine($"    connectedCallback() {{\n        this.innerHTML = '{innerHtml}'    \n}}\n}})");
        b.HeadAppend(b.HtmlScript(b.Text(scriptBuilder.ToString())));
    }

    public static string GetCustomElementTagName<T>()
    {
        var genericTypes = string.Join("-", typeof(T).GenericTypeArguments.Select(x => x.Name.ToLower().Replace("`", string.Empty)));
        return "metapsi-" + typeof(T).Name.ToLower().Replace("`", string.Empty) + genericTypes;
    }

    public static string GetCustomElementTagName<T>(this HtmlBuilder b)
    {
        return GetCustomElementTagName<T>();
    }

    public static string GetCustomElementTagName<T>(this LayoutBuilder b)
    {
        return GetCustomElementTagName<T>();
    }

    private static string DefineCustomElement(
        this HtmlBuilder b,
        string tagName,
        HashSet<string> properties,
        Action<SyntaxBuilder, Var<DomElement>> render,
        Action<SyntaxBuilder, Var<DomElement>> attach = null,
        Action<SyntaxBuilder, Var<DomElement>> cleanup = null)
    {
        if (attach == null) attach = (SyntaxBuilder b, Var<DomElement> node) => { };
        if (cleanup == null) cleanup = (SyntaxBuilder b, Var<DomElement> node) => { };

        ModuleBuilder moduleBuilder = new ModuleBuilder();
        moduleBuilder.Define("render", render);
        moduleBuilder.Define("attach", attach);
        moduleBuilder.Define("cleanup", cleanup);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(JavaScript.PrettyBuilder.Generate(moduleBuilder.Module, ""));

        stringBuilder.AppendLine($"customElements.define('{tagName}', class extends HTMLElement {{");
        stringBuilder.AppendLine("    constructor(){");
        stringBuilder.AppendLine("        super();");
        stringBuilder.AppendLine("        attach(this);");
        stringBuilder.AppendLine("    }");

        foreach (var property in properties)
        {
            stringBuilder.AppendLine($"    _{property} = null;");
            // client-side render is not null anymore, if it was null it is equal to 'attach'
            stringBuilder.AppendLine($"    set {property} (value) {{ this._{property} = value; render(this) }}");
            stringBuilder.AppendLine($"    get {property}() {{ return this._{property} }}");
        }

        stringBuilder.AppendLine($"    connectedCallback(){{ render(this) }}");
        if (cleanup != null)
        {
            stringBuilder.AppendLine("    disconnectedCallback() { cleanup(this); }");
        }
        stringBuilder.AppendLine("});");

        b.HeadAppend(
            b.HtmlScript(
                b =>
                {
                    b.SetAttribute("type", "module");
                },
                b.Text(stringBuilder.ToString())));

        return tagName;
    }
    public static string DefineCustomElement(
        this HtmlBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<DomElement>> render,
        Action<SyntaxBuilder, Var<DomElement>> attach = null,
        Action<SyntaxBuilder, Var<DomElement>> cleanup = null)
    {
        return b.DefineCustomElement(tagName, new HashSet<string>(), render, attach, cleanup);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProps"></typeparam>
    /// <param name="b"></param>
    /// <param name="attach"></param>
    public static string DefineCustomElement<TProps>(
        this HtmlBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<DomElement>> render,
        Action<SyntaxBuilder, Var<DomElement>> attach = null,
        Action<SyntaxBuilder, Var<DomElement>> cleanup = null)
    {
        var properties = typeof(TProps).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

        return b.DefineCustomElement(
            tagName,
            properties.Select(x => x.Name).ToHashSet(),
            render,
            attach,
            cleanup);
    }

    public static string DefineCustomElement<TProps>(
        this HtmlBuilder b,
        Action<SyntaxBuilder, Var<DomElement>> render,
        Action<SyntaxBuilder, Var<DomElement>> attach = null,
        Action<SyntaxBuilder, Var<DomElement>> cleanup = null)
    {
        return b.DefineCustomElement<TProps>(b.GetCustomElementTagName<TProps>(), render, attach, cleanup);
    }

    private static object NoModel = new object();

    private static Var<bool> IsModelInitialized<TModel>(SyntaxBuilder b, Var<TModel> model)
    {
        // If model is not null/undefine, check if it is not NoModel
        return b.If(
            b.Not(
                b.HasObject(model)),
            b => b.Const(false),
            b => b.Not(b.AreEqual(model.As<object>(), b.Const(NoModel))));
    }



    /// <summary>
    /// Must return the custom element itself as root!
    /// </summary>
    /// <typeparam name="TComponent"></typeparam>
    /// <param name="b"></param>
    /// <param name="render"></param>
    /// <param name="subscriptions"></param>
    /// <returns></returns>
    public static string DefineCustomElement<TComponent>(
        this HtmlBuilder b,
        Func<LayoutBuilder, string, Var<TComponent>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<HyperType.Subscription>>[] subscriptions)
    {
        var tagName = GetCustomElementTagName<TComponent>();

        Reference<HyperType.Dispatcher<TComponent>> dispatchRef = new();
        b.DefineCustomElement(
            tagName,
            (SyntaxBuilder b, Var<DomElement> node) =>
            {
                var model = node.As<TComponent>();// b.GetProperty<TComponent>(node, "Component");
                b.Log("Render component", model);
                b.If(
                    IsModelInitialized(b, model),
                    b =>
                    {
                        b.Call(
                            b.GetRef(b.GlobalRef(dispatchRef)).As<Action<Func<TComponent, TComponent>>>(),
                            b.Def((SyntaxBuilder b, Var<TComponent> _) => model));
                    });
            },
            attach: (SyntaxBuilder b, Var<DomElement> node) =>
            {
                var appConfig = b.NewObj<HyperType.App<TComponent>>();

                var view = b.Def((LayoutBuilder b, Var<TComponent> model) =>
                {
                    return b.If(
                        IsModelInitialized(b, model),
                        b => render(b, tagName, model),
                        b => b.H(tagName));
                });

                b.Set(appConfig, x => x.view, view);
                b.Set(appConfig, x => x.init, b.MakeInit(b.Const(NoModel)));
                b.Set(appConfig, x => x.node, node);
                b.Set(appConfig, x => x.subscriptions, b.MakeSubscriptionsFunction<TComponent>(subscriptions.ToList()));

                var dispatch = b.App(appConfig.As<HyperType.App<TComponent>>());
                b.SetRef(b.GlobalRef(dispatchRef), dispatch);
            },
            cleanup: (SyntaxBuilder b, Var<DomElement> node) =>
            {
                b.Call(b.GetRef(b.GlobalRef(dispatchRef)).As<System.Action>());
            });

        return tagName;
    }

    /// <summary>
    /// Must return the custom element itself as root!
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="render"></param>
    public static string DefineCustomElement<TProps, TModel>(
        this HtmlBuilder b,
        Func<LayoutBuilder, string, Var<TModel>, Var<TProps>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<HyperType.Subscription>>[] subscriptions)
        where TProps : IHasDataModel<TModel>, new()
    {
        var tagName = GetCustomElementTagName<TProps>();

        HashSet<string> properties = new HashSet<string>();
        foreach (var property in typeof(TProps).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public))
        {
            properties.Add(property.Name);
        }

        Reference<HyperType.Dispatcher<TModel>> dispatchRef = new();
        b.DefineCustomElement(
            tagName, 
            properties,
            (SyntaxBuilder b, Var<DomElement> node) =>
            {
                Var<TProps> nodeWithModel = node.As<TProps>();
                var getModel = b.GetProperty<Func<TModel>>(node, "GetModel");
                var model = b.Call(getModel);
                b.If(
                    IsModelInitialized(b, model),
                    b =>
                    {
                        b.Call(
                            b.GetRef(b.GlobalRef(dispatchRef)).As<Action<Func<TModel, TModel>>>(),
                            b.Def((SyntaxBuilder b, Var<TModel> _) => model));
                    });
            },
            attach: (SyntaxBuilder b, Var<DomElement> node) =>
            {
                var appConfig = b.NewObj<HyperType.App<TModel>>();

                var view = b.Def((LayoutBuilder b, Var<TModel> model) =>
                {
                    var props = b.NewObjFrom<TProps>(node);
                    return b.If(
                        IsModelInitialized(b, model),
                        b => render(b, tagName, model, props),
                        b => b.H(tagName));
                });

                b.Set(appConfig, x => x.view, view);
                b.Set(appConfig, x => x.init, b.MakeInit(b.Const(NoModel)));
                b.Set(appConfig, x => x.node, node);
                b.Set(appConfig, x => x.subscriptions, b.MakeSubscriptionsFunction<TModel>(subscriptions.ToList()));
                b.Set(appConfig, x => x.dispatch, b.Def((SyntaxBuilder b, Var<HyperType.Dispatcher<TModel>> dispatch) =>
                {
                    var customDispatch = b.Def((SyntaxBuilder b, Var<HyperType.Action<TModel, object>> action, Var<object> payload) =>
                    {
                        b.Dispatch(dispatch, action, payload);
                    });

                    return customDispatch.As<HyperType.Dispatcher<TModel>>();
                }));

                var dispatch = b.App(appConfig.As<HyperType.App<TModel>>());
                b.SetRef(b.GlobalRef(dispatchRef), dispatch);
            },
            cleanup: (SyntaxBuilder b, Var<DomElement> node) =>
            {
                b.Call(b.GetRef(b.GlobalRef(dispatchRef)).As<System.Action>());
            });

        return tagName;
    }
    /// <summary>
    /// Must return the custom element itself as root!
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="render"></param>
    public static string DefineCustomElement<TProps, TModel>(
        this HtmlBuilder b,
        Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> render)
        where TProps : IHasDataModel<TModel>, new()
    {
        return b.DefineCustomElement((LayoutBuilder b, string tagName, Var<TModel> model, Var<TProps> props) =>
        {
            return render(b, tagName, model);
        });
    }

    public static Var<HyperType.StateWithEffects> BroadcastModel<TModel>(this SyntaxBuilder b, Var<TModel> updatedModel)
    {
        var cloned = b.Clone(updatedModel);
        return b.MakeStateWithEffects(
            cloned,
            b.MakeEffect((SyntaxBuilder b) =>
            {
                b.DispatchEvent(b.Const($"modelUpdated_{typeof(TModel).Name}"), b.Clone(cloned));
            }));
    }
}

public interface IHasDataModel<TModel>
{

}

