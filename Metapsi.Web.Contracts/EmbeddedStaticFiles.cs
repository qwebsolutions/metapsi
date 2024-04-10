﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Metapsi;

public static class StaticFiles
{
    class EmbeddedStaticFileReference
    {
        public string OriginalCaseResourceName { get; set; }
        public string LowerCaseFileName { get; set; }
        public Assembly Assembly { get; set; }
        public byte[] Content { get; set; }
    }

    private static TaskQueue taskQueue = new TaskQueue();

    private static List<EmbeddedStaticFileReference> staticFileReferences = new();

    // This keeps references to the assembly because it can be called multiple times

    public static void Add(Assembly assembly, string resourceName)
    {
        var notAwaited = taskQueue.Enqueue(async () =>
        {
            var lowercaseFileName = resourceName.ToLowerInvariant();

            var existingStaticResource = staticFileReferences.SingleOrDefault(x => x.LowerCaseFileName == lowercaseFileName);

            if (existingStaticResource == null)
            {
                var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                {
                    throw new Exception($"Embedded resource {resourceName} not found");
                }

                EmbeddedStaticFileReference staticFileReference = new EmbeddedStaticFileReference()
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

                staticFileReferences.Add(staticFileReference);
            }
            else
            {
                if (existingStaticResource.Assembly.FullName != assembly.FullName)
                {
                    throw new Exception($"Embedded resource conflict! {lowercaseFileName} is included in multiple assemblies!");
                }
            }
        });
    }

    public static async Task<byte[]> Get(string fileName)
    {
        // The file name is probably already lowercase, as it's generally requested by the web server
        fileName = fileName.ToLower();

        return await taskQueue.Enqueue(async () =>
        {
            var existingStaticResource = staticFileReferences.SingleOrDefault(x => x.LowerCaseFileName == fileName);

            if(existingStaticResource == null)
            {
                return null;
            }

            return existingStaticResource.Content;
        });
    }
}