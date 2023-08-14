using System;

namespace Metapsi.Syntax;

public static class EnumExtensions
{
    public static Var<string> EnumToLowercase<TEnum>(this BlockBuilder b, Var<TEnum> @enum)
        where TEnum : struct, System.Enum
    {
        return b.EnumToString(@enum, s => s.ToLowerInvariant());
    }

    public static Var<string> EnumToFirstLowercase<TEnum>(this BlockBuilder b, Var<TEnum> @enum)
        where TEnum : struct, System.Enum
    {
        Func<string, string> transform = (s) => s.Length == 1 ? s.ToLowerInvariant() : s.Substring(0, 1).ToLowerInvariant() + s.Substring(1);

        return b.EnumToString(@enum, transform);
    }

    public static Var<string> EnumToString<TEnum>(this BlockBuilder b, Var<TEnum> @enum, Func<string,string> transform = null)
        where TEnum : struct, System.Enum
    {
        if (transform == null)
            transform = (s) => s;

        var outRef = b.Ref(b.Const(string.Empty));

        foreach (var value in Enum.GetValues<TEnum>())
        {
            b.If(
                b.AreEqual(b.Const(value), @enum),
                b =>
                {
                    b.SetRef(outRef, b.Const(transform(Enum.GetName<TEnum>(value))));
                });
        }
        return b.GetRef(outRef);
    }
}