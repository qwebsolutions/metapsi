using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Metapsi.Syntax
{
    public static partial class MetadataExtensions
    {
        public static void AddMetadata(this ModuleBuilder b, Metadata metadata)
        {
            b.Module.Metadata.Add(metadata);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="set"></param>
        public static void AddMetadata(this SyntaxBuilder b, Metadata metadata)
        {
            b.moduleBuilder.AddMetadata(metadata);
        }

        //public static void AddEmbeddedResourceMetadata(
        //    HashSet<Metadata> metadata,
        //    ResourceMetadata resourceMetadata)
        //{
        //    metadata.Add(new Metadata()
        //    {
        //        Type = "embedded-resource",
        //        Value = Metapsi.Serialize.ToJson(resourceMetadata)
        //    });

        //    metadata.Add(new Metadata()
        //    {
        //        Type = "embedded-resource-name",
        //        Value = resourceMetadata.RelativePath
        //    });
        //}

        //public static List<ResourceMetadata> GetEmbeddedResourcesMetadata(this HashSet<Metadata> metadata)
        //{
        //    return metadata.Where(x => x.Type == "embedded-file").Select(x => Metapsi.Serialize.FromJson<ResourceMetadata>(x.Value)).ToList();
        //}

        public static ResourceMetadata AddEmbeddedResourceMetadata(this SyntaxBuilder b, Assembly assembly, string logicalName)
        {
            return b.moduleBuilder.Module.Metadata.AddEmbeddedResourceMetadata(assembly, logicalName);
        }

        /// <summary>
        /// This is called when defining the page/module, says "Hey, when the page was defined, this particular hash of <paramref name="logicalName"/> was used"
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="assembly"></param>
        /// <param name="logicalName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static ResourceMetadata AddEmbeddedResourceMetadata(this HashSet<Metadata> metadata, Assembly assembly, string logicalName)
        {
            logicalName = logicalName.ToLowerInvariant();
            logicalName = logicalName.Trim('/');

            ResourceMetadata resourceMetadata = null;

            foreach (var rn in assembly.GetManifestResourceNames())
            {
                var resourceName = rn.ToLowerInvariant().Trim('/');
                if (resourceName == logicalName)
                {
                    using var stream = assembly.GetManifestResourceStream(rn);
                    using (var ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        var content = ms.ToArray();
                        var hash = System.IO.Hashing.XxHash32.HashToUInt32(content).ToString();
                        resourceMetadata = new ResourceMetadata()
                        {
                            PackageName = assembly.GetName().Name,
                            PackageVersion = assembly.GetName().Version.ToString(),
                            LogicalName = logicalName,
                            FileHash = hash
                        };
                    }
                }
            }

            if (resourceMetadata == null)
            {
                throw new Exception($"{logicalName} is not an embedded resource of {assembly.FullName}");
            }
            else
            {
                metadata.Add(new Metadata()
                {
                    Type = "embedded-resource",
                    Value = Metapsi.Serialize.ToJson(resourceMetadata)
                });
                return resourceMetadata;
            }
        }
    }
}