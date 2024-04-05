using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.JavaScript;

namespace Metapsi.Shoelace;

public static partial class SlNodeExtensions
{
    private static void ImportShoelaceTag(LayoutBuilder b, string tag)
    {
        b.AddStylesheet($"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/themes/light.css");
        b.AddScript($"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/{Cdn.ImportPaths[tag]}", "module");
        b.AddScript(SlComponent.BasePathScript($"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/"));
        b.Const(new WebComponentTag(tag));
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
}