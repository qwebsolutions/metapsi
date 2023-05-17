using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static partial class Validation
    {
        public class Entry
        {
            public string Id { get; set; }
            public string Message { get; set; }
        }

        public class State
        {
            public List<Entry> Validations { get; set; } = new List<Entry>();
        }

        public static void SetValidation(this BlockBuilder b, Var<State> validationState, Var<string> id, Var<string> message)
        {
            b.ClearValidation(validationState, id);
            b.Push(b.Get(validationState, x => x.Validations), b.NewObj<Entry>(b =>
            {
                b.Set(x => x.Id, id);
                b.Set(x => x.Message, message);
            }));
        }

        public static void ClearValidation(this BlockBuilder b, Var<State> validationState, Var<string> id)
        {
            var withoutPrevious = b.Get(validationState, id, (x, id) => x.Validations.Where(x => x.Id != id).ToList());
            b.Set(validationState, x => x.Validations, withoutPrevious);
        }

        public static Var<string> GetValidation(this BlockBuilder b, Var<State> validationState, Var<string> id)
        {
            var validationEntry = b.Get(validationState, id, (x, id) => x.Validations.SingleOrDefault(x => x.Id == id));
            return b.If(b.HasObject(validationEntry), b => b.Get(validationEntry, x => x.Message), b => b.Const(string.Empty));
        }

        public static Var<bool> IsValid(this BlockBuilder b, Var<State> validationState, Var<string> id)
        {
            return b.Not(b.HasError(validationState, id));
        }

        public static Var<bool> HasError(this BlockBuilder b, Var<State> validationState, Var<string> id)
        {
            return b.HasValue(b.GetValidation(validationState, id));
        }

        public static Var<bool> AllValid(this BlockBuilder b, Var<State> validationState)
        {
            return b.Get(validationState, x => !x.Validations.Any());
        }
    }
}

