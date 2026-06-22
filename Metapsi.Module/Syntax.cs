using System;
using System.ComponentModel;

namespace Metapsi.Syntax
{
    public abstract class IVariable
    {
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
    }

    internal interface IClientVar
    {
        string Name { get; set; }
    }

    internal class ClientVar<T> : Var<T>, IClientVar
    {
        public ClientVar() { }

        public ClientVar(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        /// <summary>
        /// Used to support derived classes
        /// </summary>
        /// <param name="variable"></param>
        public ClientVar(IVariable variable)
        {
            Name = (variable as IClientVar).Name;
        }

        //internal string Name { get; set; }

        internal Type Type => typeof(T);
        internal AssignmentNode AssignmentNode { get; set; }

    }
}

