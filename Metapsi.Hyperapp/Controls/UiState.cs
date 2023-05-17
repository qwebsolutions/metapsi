//using Metapsi.Syntax;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Metapsi.Hyperapp
//{
//    public static partial class UiState
//    {
//        public class StateContainer
//        {
//            // control id -> property : value
//            public List<ControlState> State { get; set; } = new List<ControlState>();
//        }

//        public class ControlState
//        {
//            public string ControlId { get; set; }
//            public string SerializedState { get; set; } = string.Empty;
//        }

//        private static StateContainer State { get; set; } = new StateContainer();

//        public static Var<StateContainer> GetState(BlockBuilder b)
//        {
//            var uiState = b.Const(State, "uiState");
//            return uiState;
//        }

//        public static void SetUiState(this BlockBuilder b, Var<List<ControlState>> from)
//        {
//            b.Set(GetState(b), x => x.State, from);
//        }

//        public static Var<T> GetControlState<T>(this BlockBuilder b, Var<string> controlId) where T : new()
//        {
//            var controlState = b.Get(GetState(b), controlId, (x, controlId) => x.State.SingleOrDefault(x => x.ControlId == controlId));
//            return b.If(
//                b.IsNull(controlState),
//                b => b.NewObj<T>(),
//                b => b.Deserialize<T>(b.Get(controlState, x => x.SerializedState)));
//        }

//        public static Var<T> GetControlState<T>(this BlockBuilder b, Var<string> controlId, Action<Modifier<T>> ifEmpty) where T : new()
//        {
//            var controlState = b.Get(GetState(b), controlId, (x, controlId) => x.State.SingleOrDefault(x => x.ControlId == controlId));
//            return b.If(
//                b.IsNull(controlState),
//                b =>
//                {
//                    b.UpdateControlState<T>(controlId, ifEmpty);
//                    return b.GetControlState<T>(controlId);
//                },
//                b => b.Deserialize<T>(b.Get(controlState, x => x.SerializedState)));
//        }

//        public static void Add<T>(this StateContainer state, string controlName, T controlState)
//        {
//            state.State.Add(
//                new ControlState()
//                {
//                    ControlId = controlName,
//                    SerializedState = Serialize.ToJson(controlState)
//                });
//        }

//        public static void UpdateControlState<T>(this BlockBuilder b, Var<string> controlId, Action<Modifier<T>> update) where T : new()
//        {
//            var controlsList = b.Get(GetState(b), x => x.State);
//            var initialControlState = b.Get(GetState(b), controlId, (x, controlId) => x.State.SingleOrDefault(x => x.ControlId == controlId));
//            b.If(b.IsNull(initialControlState), b =>
//            {
//                Var<string> newProperties = b.Serialize(b.NewObj<T>(update));
//                var newState = b.NewObj<ControlState>(b =>
//                {
//                    b.Set(x => x.ControlId, controlId);
//                    b.Set(x => x.SerializedState, newProperties);
//                });
//                b.Push(controlsList, newState);
//                b.Comment("b.Push(state, newState);");
//                b.Set(GetState(b), x => x.State, controlsList);
//            },
//            b =>
//            {
//                var newState = b.Deserialize<T>(b.Get(initialControlState, x => x.SerializedState));
//                b.Modify(newState, update);
//                b.Set(initialControlState, x => x.SerializedState, b.Serialize(newState));
//                b.Set(GetState(b), x => x.State, controlsList);
//            });
//        }
//    }
//}

