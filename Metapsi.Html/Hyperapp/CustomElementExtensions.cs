using System.Web;
using System;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Linq;
using System.Collections.Generic;

namespace Metapsi.Html;

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
        b.AddEmbeddedResourceMetadata(typeof(CustomElementExtensions).Assembly, ExternalScriptName);
        var define = b.ImportName<Action<string, Action<Element>, Action<Element>, Action<Element>>>(ExternalScriptName, "defineRACCustomElement");
        b.Call(define, tagName, render, attach, cleanup);
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
}


