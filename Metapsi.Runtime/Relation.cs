using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Metapsi;

namespace Metapsi
{
    // From Parent Type + Parent Id to child type + parent ID in child
    // Same parent type + parent id => More relations on different types
    // Parent is not known & not necessarily part of a specific data structure
    // When adding children, we add them relative to a parent, the children knows how to take parent ID
    // So a relation is children relative to parent, not the other way around?
    // Relation is between record types, not between data itself, because data can be 1/many, inside or outside of data structure
    // Root relation is "children of ID"

    //public interface ITypeRelation<TProp>
    //{
    //    Type ParentType { get; }
    //    Type ChildType { get; }
    //    Func<IRecord, TProp> GetParentIdFunction { get; }
    //}

    //// Type relation does not have a concept of collection
    //public class TypeRelation<TParent, TChild, TProp> : ITypeRelation<TProp>
    //    where TParent : IRecord
    //    where TChild : IRecord
    //{
    //    public Expression<Func<TChild, TProp>> GetParentIdExpression { get; set; }

    //    public Type ParentType => typeof(TParent);
    //    public Type ChildType => typeof(TChild);
    //    public Func<IRecord, TProp> GetParentIdFunction => (IRecord record) => GetParentIdExpression.Compile()((TChild)record);
    //}

    //public class RelateChildToParent<TChild, TProp>
    //{
    //    public Expression<Func<TChild, TProp>> GetParentIdExpression { get; set; }
    //}

    public interface IDowntreeRelation
    {
        Type RecordType { get; }
        LambdaExpression DowntreeIdExpression { get; }
        Func<IRecord, object> DowntreeIdFunction { get; } // From parent to child property, primary key, basically (not always Id, but usually)

        List<IUptreeRelation> ChildrenNodes { get; }
    }

    public interface IUptreeRelation
    {
        Type RecordType { get; }
        LambdaExpression UptreePropExpression { get; }
        Func<IRecord, object> UptreePropFunction { get; }// From child to parent property (not always an Id)

        Func<IRecord, object> FillPropertyFunction { get; set; }

        List<IDowntreeRelation> ChildrenNodes { get; }
    }

    public class DowntreeRelation<TRecord> : IDowntreeRelation
    {
        public Type RecordType => typeof(TRecord);
        public LambdaExpression DowntreeIdExpression { get; set; }
        public Func<IRecord, object> DowntreeIdFunction { get; set; }
        public List<IUptreeRelation> ChildrenNodes { get; } = new List<IUptreeRelation>();
    }

    public class UptreeRelation<TRecord> : IUptreeRelation
    {
        public Type RecordType => typeof(TRecord);

        // Set by Children()
        public LambdaExpression FillPropertyExpression { get; set; } // From data structure to collection/item property
        public Func<IRecord, object> FillPropertyFunction { get; set; }

        public LambdaExpression UptreePropExpression { get; set; }
        public Func<IRecord, object> UptreePropFunction { get; set; }


        // Set by FromParentId()
        public LambdaExpression DowntreeIdExpression { get; set; }
        public Func<IRecord, object> DowntreeIdFunction { get; set; }

        public List<IDowntreeRelation> ChildrenNodes { get; } = new List<IDowntreeRelation>();
    }

    public class DowntreeBuilder<TRecord>
    {
        public DowntreeBuilder(UptreeRelation<TRecord> parentNode)
        {
            this.parentNode = parentNode;
        }

        internal UptreeRelation<TRecord> parentNode;

        public void FromParentId<TId>(
            Expression<Func<TRecord, TId>> primaryKeyExpression,
            Action<UptreeBuilder<TRecord, TId>> build)
        {
            DowntreeRelation<TRecord> newNode = new DowntreeRelation<TRecord>()
            {
                DowntreeIdExpression = primaryKeyExpression,
                DowntreeIdFunction = (IRecord record) => primaryKeyExpression.Compile()((TRecord) record)
            };

            parentNode.ChildrenNodes.Add(newNode);

            var builder = new UptreeBuilder<TRecord, TId>(newNode);
            build(builder);
        }
    }

    public class UptreeBuilder<TRecord, TIdProp>
    {
        public UptreeBuilder(DowntreeRelation<TRecord> parentNode)
        {
            this.parentNode = parentNode;
        }

        internal DowntreeRelation<TRecord> parentNode;

        public DowntreeBuilder<TChild> Child<TChild>(
            Expression<Func<TRecord, TChild>> childExpression,
            Expression<Func<TChild, TIdProp>> getParentId)
        {
            throw new NotImplementedException();
        }

        public void Children<TChild>(
            Expression<Func<TRecord, IEnumerable<TChild>>> childrenExpression,
            Expression<Func<TChild, TIdProp>> getParentId, 
            Action<DowntreeBuilder<TChild>> childrenRelations)
        {
            UptreeRelation<TChild> newNode = new UptreeRelation<TChild>()
            {
                FillPropertyExpression = childrenExpression,
                FillPropertyFunction = (IRecord record) => childrenExpression.Compile()((TRecord) record),
                UptreePropExpression = getParentId,
                UptreePropFunction = (IRecord record) => getParentId.Compile()((TChild)record)
            };

            parentNode.ChildrenNodes.Add(newNode);

            var builder = new DowntreeBuilder<TChild>(newNode);
            childrenRelations(builder);
        }
    }

    public static partial class Relation
    {
        public static UptreeRelation<TRecord> On<TRecord>(Action<DowntreeBuilder<TRecord>> build)
        {
            UptreeRelation<TRecord> rootNode = new UptreeRelation<TRecord>();

            DowntreeBuilder<TRecord> relationBuilder = new DowntreeBuilder<TRecord>(rootNode);
            build(relationBuilder);
            return rootNode;
        }
    }
}