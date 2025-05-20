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
        public static async Task SyntaxCoreEmbeddedFiles(this EmbeddedFiles.ILoader loader)
        {
            await EmbeddedFiles.AddAssembly(typeof(MetadataExtensions).Assembly);
        }

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

        public static void AddEmbeddedResourceMetadata(
            HashSet<Metadata> metadata,
            string sourceAssembly,
            string filePath,
            string hash)
        {
            metadata.Add(new Metadata()
            {
                Key = "embedded-file",
                Value = filePath,
                Data = new HashSet<Metadata>()
                    {
                        new Metadata()
                        {
                            Key = "source-assembly",
                            Value = sourceAssembly,
                        },
                        new Metadata()
                        {
                            Key = "hash",
                            Value= hash
                        }
                    }
            });
        }

        public static List<Metadata> GetEmbeddedResourcesMetadata(this HashSet<Metadata> metadata)
        {
            return metadata.Where(x => x.Key == "embedded-file").ToList();
        }

        public static void AddEmbeddedResourceMetadata(this SyntaxBuilder b, Assembly assembly, string filePath)
        {
            b.moduleBuilder.Module.Metadata.AddEmbeddedResourceMetadata(assembly, filePath);
        }

        public static void AddEmbeddedResourceMetadata(this HashSet<Metadata> metadata, Assembly assembly, string filePath)
        {
            filePath = filePath.ToLowerInvariant();
            filePath = filePath.Trim('/');

            var alreadyExists = metadata.Any(x => x.Key == "embedded-file" && x.Value == filePath);

            if (!alreadyExists)
            {
                var added = false;
                foreach (var rn in assembly.GetManifestResourceNames())
                {
                    var resourceName = rn.ToLowerInvariant().Trim('/');
                    if (resourceName == filePath)
                    {
                        using var stream = assembly.GetManifestResourceStream(rn);
                        using (var ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            var content = ms.ToArray();
                            var hash = System.IO.Hashing.XxHash32.HashToUInt32(content).ToString();
                            AddEmbeddedResourceMetadata(metadata, assembly.GetName().Name, filePath, hash);
                        }
                        added = true;
                    }
                }

                if(!added)
                {
                    throw new ArgumentException($"{filePath} is not an embedded resource");
                }
            }
        }
    }
}