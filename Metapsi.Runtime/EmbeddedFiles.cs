using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Metapsi;

public static class EmbeddedFiles
{
    private static ConcurrentDictionary<string, EmbeddedFile> embeddedResources = new();

    /// <summary>
    /// Searches for <paramref name="fileName"/> through all the embedded resources of Metapsi assemblies
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns>Embedded file reference</returns>
    /// <remarks>Found files are cached in memory, only slow on first request</remarks>
    public static EmbeddedFile Get(string fileName)
    {
        // The file name is probably already lowercase, as it's generally requested by the web server
        fileName = fileName.ToLowerInvariant().Trim('/');

        if (string.IsNullOrWhiteSpace(fileName))
        {
            return null;
        }

        embeddedResources.TryGetValue(fileName, out var embeddedFile);

        if (embeddedFile != null)
            return embeddedFile;

        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (!assembly.IsDynamic)
            {
                var actualCaseResourceName = assembly.GetManifestResourceNames().SingleOrDefault(x => x.ToLowerInvariant() == fileName);
                if (actualCaseResourceName != null)
                {
                    var stream = assembly.GetManifestResourceStream(actualCaseResourceName);
                    var embeddedReference = CreateEmbeddedReference(assembly, stream, actualCaseResourceName);
                    embeddedResources[fileName] = embeddedReference;
                    return embeddedReference;
                }
            }
        }

        return null;
    }

    private static EmbeddedFile CreateEmbeddedReference(Assembly assembly, Stream stream, string resourceName)
    {
        var lowercaseFileName = resourceName.ToLowerInvariant();

        var embeddedFile = new EmbeddedFile()
        {
            Assembly = assembly,
            LowerCaseFileName = lowercaseFileName,
            OriginalCaseResourceName = resourceName
        };

        using (var ms = new MemoryStream())
        {
            stream.CopyTo(ms);
            embeddedFile.Content = ms.ToArray();
        }
        embeddedFile.Hash = Hash(embeddedFile.Content);

        return embeddedFile;
    }


    public class EmbeddedFile
    {
        public string OriginalCaseResourceName { get; set; }
        public string LowerCaseFileName { get; set; }
        public Assembly Assembly { get; set; }
        public byte[] Content { get; set; }
        public string Hash { get; set; }
    }

    public static string Hash(byte[] bytes)
    {
        return System.IO.Hashing.XxHash32.HashToUInt32(bytes).ToString();
    }

    public static string Hash(string content)
    {
        return Hash(System.Text.Encoding.UTF8.GetBytes(content));
    }
}