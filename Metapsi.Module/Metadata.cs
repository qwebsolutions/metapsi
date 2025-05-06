using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Syntax
{
    public class Metadata
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public HashSet<Metadata> Data { get; set; } = new HashSet<Metadata>();

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Metadata)) return false;

            var other = obj as Metadata;

            if (other.Key != Key) return false;
            if (other.Value != Value) return false;

            if (!Data.SetEquals(other.Data)) return false;

            return true;
        }

        public override int GetHashCode()
        {
            var keyHashCode = Key != null ? Key.GetHashCode() : 0;
            var valueHashCode = Value != null ? Value.GetHashCode() : 0;
            return keyHashCode ^ valueHashCode;
        }
    }

    //public static class MetadataExtensions
    //{
    //    public static void AddMetadata(this ModuleBuilder b, Metadata metadata)
    //    {
    //        b.Module.Metadata.Add(metadata);
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="b"></param>
    //    /// <param name="set"></param>
    //    public static void AddMetadata(this SyntaxBuilder b, Metadata metadata)
    //    {
    //        b.moduleBuilder.AddMetadata(metadata);
    //    }

    //    public static void AddEmbeddedResourceMetadata(
    //        this SyntaxBuilder b,
    //        string sourceAssembly,
    //        string filePath,
    //        string hash)
    //    {
    //        b.AddMetadata(new Metadata()
    //        {
    //            Key = "embedded-file",
    //            Value = filePath,
    //            Data = new HashSet<Metadata>()
    //            {
    //                new Metadata()
    //                {
    //                    Key = "source-assembly",
    //                    Value = sourceAssembly,
    //                },
    //                new Metadata()
    //                {
    //                    Key = "hash",
    //                    Value= hash
    //                }
    //            }
    //        });
    //    }

    //    public static List<Metadata> GetEmbeddedResourcesMetadata(this Module module)
    //    {
    //        return module.Metadata.Where(x => x.Key == "embedded-file").ToList();
    //    }
    //}
}