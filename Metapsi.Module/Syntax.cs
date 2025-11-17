using System;
using System.ComponentModel;

namespace Metapsi.Syntax
{
    public abstract class IVariable
    {
        internal string Name { get; set; }

        [Obsolete]
        public void RememberToUseTheBuilder_b__VariablesAreJustEmptyPlaceholders()
        {
        }

        [Obsolete]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [Obsolete]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        [Obsolete]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Var<T> : IVariable
    {
        public Var() { }

        public Var(string name)
        {
            Name = name;
        }

        //internal string Name { get; set; }

        internal Type Type => typeof(T);
    }
}

