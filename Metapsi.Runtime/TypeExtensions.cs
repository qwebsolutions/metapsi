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
        public string TypeName { get; set; }
        public string Namespace { get; set; }
        public List<TypeData> GenericTypes { get; set; } = new List<TypeData>();
    }

    public static class TypeExtensions
    {
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
                Namespace = type.Namespace
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

            return $"{namespacePlaceholder}{currentTypeName}{genericsPlaceholder}";
        }

        public static string CSharpTypeName(this System.Type type, TypeQualifier typeQualifier = TypeQualifier.Short, bool usePrimitiveNames = false)
        {
            return type.GetTypeData().CSharpTypeName(typeQualifier, usePrimitiveNames);
        }
    }
}
