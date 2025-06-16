using System;
using Metapsi.Syntax;

namespace Metapsi.Syntax
{

    public static class EnumExtensions
    {
        public static Var<string> EnumToLowercase<TEnum>(this SyntaxBuilder b, Var<TEnum> @enum)
            where TEnum : struct, System.Enum
        {
            return b.EnumToString(@enum, s => s.ToLowerInvariant());
        }

        public static Var<string> EnumToFirstLowercase<TEnum>(this SyntaxBuilder b, Var<TEnum> @enum)
            where TEnum : struct, System.Enum
        {
            Func<string, string> transform = (s) => s.Length == 1 ? s.ToLowerInvariant() : s.Substring(0, 1).ToLowerInvariant() + s.Substring(1);

            return b.EnumToString(@enum, transform);
        }

        public static Var<string> EnumToString<TEnum>(this SyntaxBuilder b, Var<TEnum> @enum, Func<string, string> transform = null)
            where TEnum : struct, System.Enum
        {
            if (transform == null)
                transform = (s) => s;

            var outRef = b.Ref(b.Const(string.Empty));

            foreach (var o in Enum.GetValues(typeof(TEnum)))
            {
                var value = (TEnum)o;
                b.If(
                    b.AreEqual(b.Const(value), @enum),
                    b =>
                    {
                        b.SetRef(outRef, b.Const(transform(Enum.GetName(typeof(TEnum), value))));
                    });
            }
            return b.GetRef(outRef);
        }
    }
}