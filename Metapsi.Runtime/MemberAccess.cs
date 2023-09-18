using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi
{
    public class MemberAccessVisitor : ExpressionVisitor
    {
        private List<MemberExpression> AllMemberExpressions = new List<MemberExpression>();

        [return: NotNullIfNotNull("node")]
        public override Expression Visit(Expression node)
        {
            if (node.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = node as MemberExpression;
                AllMemberExpressions.Add(memberExpression);
            }

            return base.Visit(node);
        }

        public MemberAccessExpressions GetExpressions()
        {
            var rootType = AllMemberExpressions.Last().Expression.Type;

            var entityType = AllMemberExpressions.First().Expression.Type;
            var propertyType = AllMemberExpressions.First().Type;

            var entityProperty = Expression.Lambda(
                Expression.MakeMemberAccess(Expression.Parameter(entityType, "x"),
                AllMemberExpressions.First().Member),
                Expression.Parameter(entityType, "x"));

            LambdaExpression getEntity = AllMemberExpressions.Count() == 1 ?
                Expression.Lambda(Expression.Variable(rootType, "x"), Expression.Parameter(rootType, "x")) :
                Expression.Lambda(AllMemberExpressions.Last(), Expression.Parameter(rootType, "x"));

            return new MemberAccessExpressions()
            {
                EntityProperty = entityProperty,
                EntityReference = getEntity
            };
        }
    }


    public class MemberAccessExpressions
    {
        public LambdaExpression EntityReference { get; set; }
        public LambdaExpression EntityProperty { get; set; }
    }

    public static class NestedAccessExtensions
    {
        public static MemberAccessExpressions GetMemberAccess<TModel, TProp>(this Expression<Func<TModel, TProp>> expression)
        {
            var parentPropertyVisitor = new MemberAccessVisitor();
            parentPropertyVisitor.Visit(expression);
            return parentPropertyVisitor.GetExpressions();
        }
    }
}