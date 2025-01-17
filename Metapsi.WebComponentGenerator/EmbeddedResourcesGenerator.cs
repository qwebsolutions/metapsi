using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metapsi.WebComponentGenerator;

public static class EmbeddedResourcesGenerator
{
    public class ResourceElement
    {
        public string Path { get; set; }
        public string LogicalName { get; set; }
    }

    public static string GetEmbeddedFilesTargetFile(string fromFolder, Action<ResourceElement> setLogicalName = null)
    {
        fromFolder = fromFolder.TrimEnd('/').TrimEnd('\\');

        var allFiles = Directory.EnumerateFiles(fromFolder, "*", SearchOption.AllDirectories);

        var projectNode =
          new XElement("Project", new XAttribute("Sdk", "Microsoft.NET.Sdk"));

        var itemGroup = new XElement("ItemGroup");
        projectNode.Add(itemGroup);

        foreach (var file in allFiles)
        {
            var fileRelativePath = System.IO.Path.GetRelativePath(fromFolder, file);
            var embeddedRelativePath = System.IO.Path.Combine(System.IO.Path.GetFileName(fromFolder), fileRelativePath);

            var logicalName = fileRelativePath.Replace("\\", "/");
            if (setLogicalName != null)
            {
                var resourceElement = new ResourceElement()
                {
                    Path = embeddedRelativePath,
                    LogicalName = logicalName
                };
                setLogicalName(resourceElement);

                logicalName = resourceElement.LogicalName;
            }

            itemGroup.Add(
                new XElement(
                    "EmbeddedResource",
                    new XAttribute("Include", embeddedRelativePath),
                    new XAttribute("LogicalName", logicalName)));
        }

        var xmlDocument = new XDocument(projectNode);

        return xmlDocument.ToString();
    }
}
