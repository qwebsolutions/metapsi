using System;

namespace Metapsi
{
    /// <summary>
    /// Record collection reflection metadata
    /// </summary>
    public class CollectionInfo
    {
        public System.Reflection.PropertyInfo PropertyInfo { get; set; }
        public int Order { get; set; }
        public Type RecordType { get; set; }
        public DataStructureRelation Relation { get; set; }

        public string Name => PropertyInfo.Name;
    }
}