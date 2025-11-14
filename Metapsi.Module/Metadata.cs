using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Syntax
{
    public class Metadata
    {
        public string Type { get; set; }
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Metadata)) return false;

            var other = obj as Metadata;

            if (other.Type != Type) return false;
            if (other.Value != Value) return false;

            return true;
        }

        public override int GetHashCode()
        {
            var keyHashCode = Type != null ? Type.GetHashCode() : 0;
            var valueHashCode = Value != null ? Value.GetHashCode() : 0;
            return keyHashCode ^ valueHashCode;
        }
    }

    public class PathResolution
    {
        public string Type { get; set; }
        public string Idenfifier { get; set; }
        public string ResolvedPath { get; set; }
    }
}