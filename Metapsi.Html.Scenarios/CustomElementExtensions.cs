
using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html.Scenarios;

public static class CustomElementExtensions
{
    //public static Var<IVNode> InlineCustomElement<TInitProps>(
    //    this LayoutBuilder b, 
    //    CustomElement customElement,
    //    Action<PropsBuilder<TInitProps>> setProps)
    //{
    //    b.Metadata().AddRequiredTagMetadata(
    //        new HtmlTag("script")
    //        {
    //            Children = new List<HtmlNode>()
    //            {
    //                new HtmlNode()
    //                {
    //                    Modules = new List<Module>()
    //                    {
    //                        customElement.Module
    //                    }
    //                }
    //            }
    //        });

    //    return b.H(customElement.Tag, setProps);
    //}

    //public static IHtmlNode InlineCustomElement<TInitProps>(
    //    this HtmlBuilder b,
    //    ICustomElement customElement,
    //    Action<AttributesBuilder<TInitProps>> setAttributes)
    //{
    //    b.HeadAppend(new HtmlNode()
    //    {
    //        Tags = new System.Collections.Generic.List<HtmlTag>()
    //        {
    //            new HtmlTag("script")
    //            {
    //                Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
    //                {
    //                    { "type", new HtmlAttribute(){Value = "module" } },
    //                },
    //                Children = new System.Collections.Generic.List<HtmlNode>()
    //                {
    //                    new HtmlNode()
    //                    {
    //                        Modules = new System.Collections.Generic.List<Module>()
    //                        {
    //                            customElement.Module
    //                        }
    //                    }
    //                }
    //        }
    //    }
    //    });
    //    return b.Tag<TInitProps>(
    //        customElement.Tag,
    //        setAttributes);
    //}

    public static IHtmlNode CustomElementSrcScript(this HtmlBuilder b, string tagName)
    {
        return new HtmlNode()
        {
            Tags = new System.Collections.Generic.List<HtmlTag>()
            {
                new HtmlTag("script")
                {
                    Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
                    {
                        { "type", new HtmlAttribute() { Value = "module" } },
                        {
                            "src",
                            new HtmlAttribute()
                            {
                                //VariableName = $"custom-element-path:{customElement.Tag}"
                                ResourceMetadata = new ResourceMetadata()
                                {
                                    LogicalName = $"{tagName}.js",
                                    ResourceType = "metapsi-js-module"
                                }
                            }
                        }
                    }
                }
            }
        };
    }

    public static HtmlTag CustomElementSrcScript(this LayoutBuilder b, string tagName)
    {
        return new HtmlTag("script")
        {
            Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
                    {
                        { "type", new HtmlAttribute() { Value = "module" } },
                        {
                            "src",
                            new HtmlAttribute()
                            {
                                //VariableName = $"custom-element-path:{customElement.Tag}"
                                ResourceMetadata = new ResourceMetadata()
                                {
                                    LogicalName = $"{tagName}.js",
                                    ResourceType = "metapsi-js-module"
                                }
                            }
                        }
                    }
        };
    }
}
