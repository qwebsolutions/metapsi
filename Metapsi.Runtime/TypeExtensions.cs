using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public enum TypeQualifier
    {
        Short,
        Root,
        All
    }

    public class TypeData
    {
        /// <summary>
        /// Short type name
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// Namespace
        /// </summary>
        public string Namespace { get; set; }
        /// <summary>
        /// Parent types for nested classes
        /// </summary>
        public List<String> DeclaringTypes { get; set; } = new List<string>();
        /// <summary>
        /// Generic types of the current type
        /// </summary>
        public List<TypeData> GenericTypes { get; set; } = new List<TypeData>();
    }

    public static class TypeExtensions
    {
        public static string PropertyName<TObject, TProperty>(this System.Linq.Expressions.Expression<Func<TObject, TProperty>> expression)
        {
            return (expression.Body as System.Linq.Expressions.MemberExpression).Member.Name;
        }

        public static string PropertyName(this System.Linq.Expressions.LambdaExpression expression)
        {
            return (expression.Body as System.Linq.Expressions.MemberExpression).Member.Name;
        }

        public static Dictionary<string, string> PrimitiveTypes = new Dictionary<string, string>
        {
            { "Boolean", "bool" },
            {"Byte","byte"},
            {"SByte","sbyte"},
            {"Int16","short"},
            {"UInt16","ushort"},
            {"Int32","int"},
            {"UInt32","uint"},
            {"Int64","long"},
            {"UInt64","ulong"},
            {"IntPtr","nint"},
            {"UIntPtr","nuint"},
            {"Char","char"},
            {"Double","double"},
            {"Single","float"},
            {"String","string"},
            {"Decimal","decimal"}
        };

        public static TypeData GetTypeData(this System.Type type)
        {
            TypeData typeData = new TypeData()
            {
                Namespace = type.Namespace,
                DeclaringTypes = type.GetDeclaringTypes().Select(x=>x.Name).ToList()
            };

            if (!type.IsGenericType)
            {
                typeData.TypeName = type.Name;
            }
            else
            {
                typeData.TypeName = type.Name.Split('`').First();

                // Root should only add namespace for parent type, not for children
                foreach (var t in type.GetGenericArguments())
                {
                    typeData.GenericTypes.Add(GetTypeData(t));
                }
            }

            return typeData;
        }

        public static List<Type> GetDeclaringTypes(this System.Type type)
        {
            List<Type> types = new List<Type>();
            while (true)
            {
                if (type.DeclaringType != null)
                {
                    types.Add(type.DeclaringType);
                    type = type.DeclaringType;
                }
                else
                {
                    return types;
                }
            }
        }

        public static string CSharpTypeName(this TypeData type, TypeQualifier typeQualifier = TypeQualifier.Short, bool usePrimitiveNames = false)
        {
            string currentTypeName = type.TypeName;
            if (usePrimitiveNames)
            {
                if (PrimitiveTypes.ContainsKey(type.TypeName))
                {
                    currentTypeName = PrimitiveTypes[type.TypeName];
                }
            }

            string namespacePlaceholder = "";
            if (typeQualifier != TypeQualifier.Short)
            {
                namespacePlaceholder = $"{type.Namespace}.";
            }

            string declaringTypePlaceholder = "";
            if (type.DeclaringTypes.Any())
            {
                declaringTypePlaceholder = string.Join(".", type.DeclaringTypes) + ".";
            }

            string genericsPlaceholder = "";

            if (type.GenericTypes.Any())
            {
                // Root should only add namespace for parent type, not for children
                var childTypeQualifier = typeQualifier;
                if (typeQualifier == TypeQualifier.Root)
                {
                    childTypeQualifier = TypeQualifier.Short;
                }

                genericsPlaceholder = $"<{string.Join(",", type.GenericTypes.Select(x => x.CSharpTypeName(typeQualifier, usePrimitiveNames)))}>";
            }

            return $"{namespacePlaceholder}{declaringTypePlaceholder}{currentTypeName}{genericsPlaceholder}";
        }

        public static string CSharpTypeName(this System.Type type, TypeQualifier typeQualifier = TypeQualifier.Short, bool usePrimitiveNames = false)
        {
            return type.GetTypeData().CSharpTypeName(typeQualifier, usePrimitiveNames);
        }

        /// <summary>
        /// Get full type name + assembly name, but ignore version
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetSemiQualifiedTypeName(this System.Type type)
        {
            return $"{type.FullName}, {type.Assembly.GetName().Name}";
        }
    }
}
