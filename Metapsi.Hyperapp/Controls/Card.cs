using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public static class Card
    {
        public enum Style
        {
            Info,
            Ok,
            Warning,
            Danger
        }

        public class Props
        {
            public Style Style { get; set; }
        }
    }

    public static partial class UiState
    {
        //public static Var<HyperNode> Card(
        //    this BlockBuilder b)
        //{
        //    return b.Div("flex flex-col rounded-md border border-black");
        //}
    }
}

