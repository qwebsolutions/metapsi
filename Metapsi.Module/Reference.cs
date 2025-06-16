namespace Metapsi.Syntax
{
    public class Reference<T>
    {
        public T Value { get; set; }
    }

    public static class ReferenceExtensions
    {
        public static Var<Reference<T>> Ref<T>(this SyntaxBuilder b, Var<T> value)
        {
            var obj = b.NewObj<Reference<T>>();
            b.Set(obj, x => x.Value, value);
            return obj;
        }

        public static Var<Reference<T>> GlobalRef<T>(this SyntaxBuilder b, Reference<T> reference)
        {
            return b.Const(reference);
        }

        public static Var<Reference<T>> GlobalRef<T>(this SyntaxBuilder b, T initialValue)
        {
            return b.Const(new Reference<T>() { Value = initialValue });
        }

        public static void SetRef<TSyntaxBuilder, T>(this TSyntaxBuilder b, Var<Reference<T>> reference, Var<T> value)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Set(reference, x => x.Value, value);
        }

        public static Var<T> GetRef<T>(this SyntaxBuilder b, Var<Reference<T>> reference)
        {
            return b.Get(reference, x => x.Value);
        }
    }
}

