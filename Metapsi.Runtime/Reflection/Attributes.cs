using System;

namespace Metapsi
{
    public class DataStructureAttribute: System.Attribute
    {
        public Guid Id { get; set; }
        public DataStructureAttribute(string guidString)
        {
            this.Id = Guid.Parse(guidString);
        }
    }

    public class DataItemAttribute : System.Attribute
    {
        public Guid Id { get; set; }
        public DataItemAttribute(string guidString)
        {
            this.Id = Guid.Parse(guidString);
        }
    }

    public class DataItemFieldAttribute : System.Attribute
    {
        public Guid Id { get; set; }
        public DataItemFieldAttribute(string guidString)
        {
            this.Id = Guid.Parse(guidString);
        }
    }

    public class ScalarTypeNameAttribute : System.Attribute
    {
        public string TypeName { get; set; }

        public ScalarTypeNameAttribute(string typeName)
        {
            this.TypeName = TypeName;
        }
    }

    public class OrderAttribute : System.Attribute
    {
        public OrderAttribute(int index)
        {
            Index = index;
        }

        public int Index { get; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class RelationAttribute : System.Attribute
    {
        public RelationAttribute(string parentCollection, string parentId, string childCollection, string childId)
        {
            ParentCollection = parentCollection;
            ParentId = parentId;
            this.ChildCollection = childCollection;
            ChildId = childId;
        }

        public string ParentCollection { get; }
        public string ParentId { get; }
        public string ChildCollection { get; }
        public string ChildId { get; }
    }
}
