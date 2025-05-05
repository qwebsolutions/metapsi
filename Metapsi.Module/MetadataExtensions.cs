using System;

namespace Metapsi.Syntax
{
    public static class MetadataExtensions
    {
        public static void AddMetadata(this ModuleBuilder b, Metadata metadata)
        {
            b.Module.Metadata.Add(metadata);
        }

        //public static void SetKey(this Metadata metadata, string key)
        //{
        //    metadata.SetKey(key);
        //}

        //public static void SetValue(this Metadata metadata, string value)
        //{
        //    metadata.SetValue(value);
        //}

        //public static void AddData(this Metadata metadata, Action<Metadata> data)
        //{
        //    var childData = new Metadata();
        //    data(childData);
        //    metadata.Data.Add(childData);
        //}

        //public static void AddData(this Metadata metadata, string key, Action<Metadata> setData)
        //{
        //    Metadata child = new Metadata() { Key= key };
        //    setData(child);
        //    metadata.Data.Add(child);
        //}

        //public static void AddComment(this ModuleBuilder b, string comment)
        //{
        //    b.AddMetadata(b =>
        //    {
        //        b.SetKey("comment");
        //        b.SetValue(comment);
        //    });
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="set"></param>
        public static void AddMetadata(this SyntaxBuilder b, Metadata metadata)
        {
            b.moduleBuilder.AddMetadata(metadata);
        }
    }
}