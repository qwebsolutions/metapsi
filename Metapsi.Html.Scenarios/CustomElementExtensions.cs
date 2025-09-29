
using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using System.Reflection;

namespace Metapsi.Html.Scenarios;

public static class CustomElementExtensions
{
    public static IHtmlNode CustomElementSrcScriptTag(
        this HtmlBuilder b,
        ICustomElement customElement)
    {
        var jsFile = $"{customElement.Tag}.js";
        return new HtmlNode()
        {
            Tags = new System.Collections.Generic.List<HtmlTag>()
            {
                SrcScriptTag(jsFile, "metapsi-custom-element", "1.0", customElement.Module.Hash())
            }
        };
    }

    public static HtmlTag SrcScriptTag(
        string jsFile,
        string packageName,
        string packageVersion,
        string fileHash = null)
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
                        ResourceMetadata = new ResourceMetadata()
                        {
                            ResourceType = "metapsi-js-module",
                            LogicalName = jsFile,
                            PackageName = packageName,
                            PackageVersion = packageVersion,
                            FileHash = fileHash
                        }
                    }
                }
            }
        };
    }

    public static HtmlTag CustomElementSrcScriptTag(
        this LayoutBuilder b,
        ICustomElement customElement)
    {
        var jsFile = $"{customElement.Tag}.js";
        return SrcScriptTag(jsFile, "metapsi-custom-element", "1.0", customElement.Module.Hash());
    }

    public static HtmlTag CustomElementSrcScriptTag(
        this LayoutBuilder b,
        string tag,
        string packageName,
        string packageVersion,
        string fileHash = null)
    {
        var jsFile = $"{tag}.js";
        return SrcScriptTag(jsFile, packageVersion, packageVersion, fileHash);
    }
}
