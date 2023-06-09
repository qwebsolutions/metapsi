using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public static class TypeReflectionExtensions
    {
        public static List<Type> NestedTypes(this Type type)
        {
            List<Type> allTypes = new List<Type> { type };
            while (true)
            {
                type = type.DeclaringType;
                if (type == null)
                    break;
                allTypes.Add(type);
            }

            allTypes.Reverse();
            return allTypes;
        }

        public static List<string> NestedTypeNames(this Type type)
        {
            return type.NestedTypes().Select(x => x.Name).ToList();
        }
    }
}
