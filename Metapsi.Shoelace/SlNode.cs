using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;

public record ShoelaceTag(string tag);

public static class SlNodeExtensions
{
    public static void Shoelace(LayoutBuilder b, ShoelaceVersion shoelaceVersion = null)
    {
        if (shoelaceVersion == null)
        {
            shoelaceVersion = JsDelivr("latest");
        }

        b.AddScript(shoelaceVersion.AutoloaderUrl, "module");
        b.AddStylesheet(shoelaceVersion.StylesheetUrl);
    }

    public static Var<IVNode> SlNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
        where TProps : new()
    {
        SlNodeExtensions.Shoelace(b);
        b.Const(new ShoelaceTag(tag));
        return b.H(tag, buildProps, children);
    }

    public static Var<IVNode> SlNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<IVNode>[] children)
        where TProps : new()
    {
        SlNodeExtensions.Shoelace(b);
        b.Const(new ShoelaceTag(tag));
        return b.H(tag, buildProps, children);
    }

    public class ShoelaceVersion
    {
        public string AutoloaderUrl { get; set; }
        public string StylesheetUrl { get; set; }
    }

    public static ShoelaceVersion JsDelivr(string version)
    {
        return new ShoelaceVersion()
        {
            AutoloaderUrl = $"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{version}/cdn/shoelace-autoloader.js",
            StylesheetUrl = $"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{version}/cdn/themes/light.css"
        };
    }

    public static void AddShoelace(this DocumentTag document, ShoelaceVersion shoelaceVersion = null)
    {
        if (shoelaceVersion == null)
        {
            shoelaceVersion = JsDelivr("latest");
        }

        document.Head.AddChild(new ExternalScriptTag(shoelaceVersion.AutoloaderUrl, "module"));
        document.Head.AddChild(new LinkTag("stylesheet", shoelaceVersion.StylesheetUrl));
    }
}