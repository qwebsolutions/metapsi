using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace Metapsi;

public static class StaticFiles
{
    private static Dictionary<string, EmbeddedStaticFile> embeddedResources = new Dictionary<string, EmbeddedStaticFile>();

    public class EmbeddedStaticFile
    {
        public string OriginalCaseResourceName { get; set; }
        public string LowerCaseFileName { get; set; }
        public Assembly Assembly { get; set; }
        public byte[] Content { get; set; }
        public string Hash { get; set; }
    }

    private static TaskQueue<Dictionary<string, EmbeddedStaticFile>> taskQueue = new TaskQueue<Dictionary<string, EmbeddedStaticFile>>(embeddedResources);

    public static async Task AddAll(Assembly assembly, string pattern = null)
    {
        foreach (var resourceName in assembly.GetManifestResourceNames())
        {
            bool include = true;
            if (pattern != null)
            {
                if (!resourceName.Contains(pattern))
                {
                    include = false;
                }
            }
            if (include)
            {
                await AddResource(assembly, resourceName);
            }
        }
    }

    public static async Task AutoAdd(string byPrefix = "Metapsi")
    {
        foreach (Assembly assembly in System.AppDomain.CurrentDomain.GetAssemblies())
        {
            if (assembly.GetName().Name.StartsWith(byPrefix))
            {
                await AddAll(assembly);
            }
        }
    }

    public static async Task AddResource(Assembly assembly, string resourceName)
    {
        await taskQueue.Enqueue(async (embeddedResources) =>
        {
            var lowercaseFileName = resourceName.ToLowerInvariant();
            if (!embeddedResources.ContainsKey(lowercaseFileName))
            {
                var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                {
                    throw new Exception($"Embedded resource {resourceName} not found");
                }

                EmbeddedStaticFile staticFileReference = new EmbeddedStaticFile()
                {
                    Assembly = assembly,
                    LowerCaseFileName = lowercaseFileName,
                    OriginalCaseResourceName = resourceName
                };

                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    staticFileReference.Content = ms.ToArray();
                }
                var hash = System.IO.Hashing.XxHash32.HashToUInt32(staticFileReference.Content);
                staticFileReference.Hash = hash.ToString();
                embeddedResources.Add(lowercaseFileName, staticFileReference);
            }
            else
            {
                if (embeddedResources[lowercaseFileName].Assembly != assembly)
                {
                    Console.Error.WriteLine($"Embedded resource conflict! {lowercaseFileName} is included in multiple assemblies!");
                    throw new Exception($"Embedded resource conflict! {lowercaseFileName} is included in multiple assemblies!");
                }
            }
        });
    }

    public static EmbeddedStaticFile Get(string fileName)
    {
        // The file name is probably already lowercase, as it's generally requested by the web server
        fileName = fileName.ToLower();

        var existingStaticResource = embeddedResources.GetValueOrDefault(fileName);

        if (existingStaticResource == null)
        {
            return null;
        }

        return existingStaticResource;
    }
}