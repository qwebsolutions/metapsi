using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Metapsi.Html;

public static class ModuleExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="metadata"></param>
    /// <param name="tag"></param>
    public static void AddRequiredTagMetadata(this HashSet<Metadata> metadata, HtmlTag tag)
    {
        var newMetadata = new Metadata()
        {
            Type = "required-tag",
            Value = Metapsi.Serialize.ToJson(tag)
        };

        metadata.Add(newMetadata);
    }

    public static void AddMetadata(this HtmlBuilder b, Metapsi.Syntax.Metadata metadata)
    {
        b.Document.Metadata.Add(metadata);
    }

    //private static Metadata ToMetadata(IHtmlNode node)
    //{
    //    if (node is HtmlText textTag)
    //    {
    //        return new Metadata()
    //        {
    //            Key = "text",
    //            Value = textTag.Text
    //        };
    //    }
    //    else
    //    {
    //        var tag = node as HtmlTag;
    //        return new Metadata()
    //        {
    //            Key = tag.Tag,
    //            Data = new HashSet<Metadata>()
    //            {
    //                new Metadata()
    //                {
    //                    Key = "attr",
    //                    Data = new HashSet<Metadata>(tag.Attributes.Select(x=> new Metadata()
    //                    {
    //                        Key = x.Key,
    //                        Value = x.Value
    //                    }))
    //                },
    //                new Metadata()
    //                {
    //                    Key = "children",
    //                    Data = new HashSet<Metadata>(tag.Children.Select(ToMetadata))
    //                }
    //            }
    //        };
    //    }
    //}

    public static void AddEmbeddedResourceMetadata(this HtmlDocument document, Assembly assembly, string filePath)
    {
        document.Metadata.AddEmbeddedResourceMetadata(assembly, filePath);
    }

    public static List<HtmlTag> GetRequiredTagsMetadata(this Metapsi.Syntax.Module module)
    {
        List<HtmlTag> requiredTags = new List<HtmlTag>();

        var requiredTagMetadata = module.Metadata.Where(x => x.Type == "required-tag");
        foreach (var metadata in requiredTagMetadata)
        {
            requiredTags.Add(Metapsi.Serialize.FromJson<HtmlTag>(metadata.Value));
        }

        return requiredTags;
    }

    //private static IHtmlNode GetTag(this Metapsi.Syntax.Metadata metadata)
    //{
    //    var tag = new HtmlTag(metadata.Key);

    //    var attr = metadata.Data.SingleOrDefault(x => x.Key == "attr");
    //    if (attr != null)
    //    {
    //        foreach (var attribute in attr.Data)
    //        {
    //            tag.Attributes[attribute.Key] = attribute.Value;
    //        }
    //    }

    //    var children = metadata.Data.SingleOrDefault(x => x.Key == "children");
    //    if (children != null)
    //    {
    //        foreach (var child in children.Data)
    //        {
    //            tag.Children.Add(GetTag(child));
    //        }
    //    }

    //    return tag;
    //}
}
