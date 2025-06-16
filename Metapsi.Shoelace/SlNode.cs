﻿using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using System.Threading.Tasks;

namespace Metapsi.Shoelace;

public static partial class SlNodeExtensions
{
    public static IHtmlNode SlTag<T>(
        this HtmlBuilder b,
        string tag,
        Action<AttributesBuilder<T>> setAttributes,
        List<IHtmlNode> children)
    {
        ImportShoelaceTag(b, tag);
        return b.Tag(tag, setAttributes, children);
    }

    public static IHtmlNode SlTag<T>(
        this HtmlBuilder b,
        string tag,
        Action<AttributesBuilder<T>> setAttributes,
        params IHtmlNode[] children)
    {
        ImportShoelaceTag(b, tag);
        return b.Tag(tag, setAttributes, children);
    }

    public static IHtmlNode SlTag(
        this HtmlBuilder b,
        string tag,
        Dictionary<string, string> attributes,
        List<IHtmlNode> children)
    {
        ImportShoelaceTag(b, tag);
        return b.Tag(tag, attributes, children);
    }

    public static IHtmlNode SlTag(
        this HtmlBuilder b,
        string tag,
        Dictionary<string, string> attributes,
        params IHtmlNode[] children)
    {
        ImportShoelaceTag(b, tag);
        return b.Tag(tag, attributes, children);
    }

    public static IHtmlNode SlTag<T>(
        this HtmlBuilder b,
        string tag,
        List<IHtmlNode> children)
    {
        ImportShoelaceTag(b, tag);
        return b.Tag(tag, children);
    }

    public static IHtmlNode SlTag<T>(
        this HtmlBuilder b,
        string tag,
        params IHtmlNode[] children)
    {
        ImportShoelaceTag(b, tag);
        return b.Tag(tag, children);
    }

    public static void AddShoelaceStylesheet(this HtmlBuilder b)
    {
        string stylesheetPath = $"/shoelace@{Cdn.Version}/themes/light.css";
        b.Document.Metadata.AddEmbeddedResourceMetadata(typeof(Metapsi.Shoelace.SlNodeExtensions).Assembly, stylesheetPath);
        b.AddStylesheet(stylesheetPath);
    }

    public static void ImportShoelaceTag(HtmlBuilder b, string tag)
    {
        b.AddShoelaceStylesheet();
        string scriptPath = $"/shoelace@{Cdn.Version}/{Cdn.ImportPaths[tag]}";
        b.Document.Metadata.AddEmbeddedResourceMetadata(typeof(Metapsi.Shoelace.SlNodeExtensions).Assembly, scriptPath);

        b.AddScript($"/shoelace@{Cdn.Version}/{Cdn.ImportPaths[tag]}", "module");
        b.HeadAppend(
            b.HtmlScript(
                b =>
                {
                    b.SetTypeModule();
                },
                b.Text($"import {{ setBasePath }} from '/shoelace@{Cdn.Version}/utilities/base-path.js';\r\n  setBasePath('/shoelace@{Cdn.Version}/');\r\n")));
        b.TrackWebComponent(tag);
    }

    private static Reference<bool> basePathSet = new Reference<bool>();

    private static void SetBasePath(SyntaxBuilder b)
    {
        var setBasePath = b.ImportName<Action<string>>($"/shoelace@{Cdn.Version}/utilities/base-path.js", "setBasePath");

        b.If(b.Not(b.GetRef(b.Const(basePathSet))),
            b =>
            {
                b.Call(setBasePath, b.Const($"/shoelace@{Cdn.Version}/"));
            });
    }

    public static void ImportShoelaceTag(SyntaxBuilder b, string tag)
    {
        string stylesheetPath = $"/shoelace@{Cdn.Version}/themes/light.css";
        string scriptPath = $"/shoelace@{Cdn.Version}/{Cdn.ImportPaths[tag]}";

        b.AddRequiredStylesheetMetadata(typeof(Metapsi.Shoelace.SlNodeExtensions).Assembly, stylesheetPath);
        b.AddEmbeddedResourceMetadata(typeof(Metapsi.Shoelace.SlNodeExtensions).Assembly, scriptPath);
        SetBasePath(b);
        b.ImportSideEffect(scriptPath);
    }

    public static Var<IVNode> SlNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
        where TProps : new()
    {
        ImportShoelaceTag(b, tag);
        return b.H(tag, buildProps, children);
    }

    public static Var<IVNode> SlNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<IVNode>[] children)
        where TProps : new()
    {
        ImportShoelaceTag(b, tag);
        return b.H(tag, buildProps, children);
    }

    public static Var<IVNode> SlNode(
        this LayoutBuilder b,
        string tag,
        Var<List<IVNode>> children)
    {
        ImportShoelaceTag(b, tag);
        return b.H(tag, children);
    }

    public static Var<IVNode> SlNode(
        this LayoutBuilder b,
        string tag,
        Var<IVNode>[] children)
    {
        ImportShoelaceTag(b, tag);
        return b.H(tag, children);
    }

    internal static Var<HyperType.Effect> AwaitUpdateCompleteEffect<TState>(SyntaxBuilder b, Var<Html.Event> e, Var<HyperType.Action<TState, Html.Event>> action)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                var slControl = b.Get(e, x => x.target);
                var updateComplete = b.GetProperty<Promise>(slControl, b.Const("updateComplete"));
                b.PromiseThen<object>(updateComplete, (b, _) =>
                {
                    b.Dispatch(dispatch, action, e);
                });
            });
    }

    internal static Var<HyperType.Action<TState, Html.Event>> AwaitUpdateCompleteAction<TState>(SyntaxBuilder b, Var<HyperType.Action<TState, Html.Event>> action)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TState> model, Var<Html.Event> e) =>
        {
            return b.MakeStateWithEffects(model, b.Call(AwaitUpdateCompleteEffect, e, action));
        });
    }

    internal static void OnSlEvent<TState, T>(this PropsBuilder<T> b, string eventName, Var<HyperType.Action<TState, Html.Event>> action)
    {
        b.SetProperty(b.Props, b.Const(eventName), b.Call(AwaitUpdateCompleteAction, action));
    }

    internal static void OnSlEvent<TState,T>(this PropsBuilder<T> b, string eventName, Var<HyperType.Action<TState>> action)
    {
        b.SetProperty(b.Props, b.Const(eventName), b.Call(AwaitUpdateCompleteAction, action.As<HyperType.Action<TState, Html.Event>>()));
    }

    internal static void OnSlEvent<TState, T, TEventDetail>(this PropsBuilder<T> b, string eventName, Var<HyperType.Action<TState, Html.CustomEvent<TEventDetail>>> action)
    {
        b.SetProperty(b.Props, b.Const(eventName), b.Call(AwaitUpdateCompleteAction, action.As<HyperType.Action<TState, Html.Event>>()));
    }
}