using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public class UiVar
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }

    public static class ClientSideUiExtensions
    {
        private static DynamicProperty<DynamicObject> ClientSideVars = new("_ui");

        public static void SetVar<TModel>(this BlockBuilder b, Var<TModel> clientModel, string group, Var<string> key, Var<string> value)
        {
            var dynamicModel = clientModel.As<DynamicObject>();

            var clientVars = b.GetDynamic(dynamicModel, ClientSideVars);

            // If not initialized at all, initialize now
            b.If(
                b.Not(
                    b.HasObject(clientVars)),
                b =>
                {
                    b.SetDynamic(dynamicModel, ClientSideVars, b.NewObj<DynamicObject>());
                });

            // & retrieve again
            clientVars = b.GetDynamic(dynamicModel, ClientSideVars);

            var varsGroup = b.GetDynamic(clientVars, new DynamicProperty<List<UiVar>>(group));

            b.If(
                b.Not(
                    b.HasObject(varsGroup)),
                b =>
                {
                    b.SetDynamic(clientVars, new DynamicProperty<List<UiVar>>(group), b.NewCollection<UiVar>());
                });

            varsGroup = b.GetDynamic(clientVars, new DynamicProperty<List<UiVar>>(group));

            var entry = b.Get(varsGroup, key, (varsGroup, key) => varsGroup.SingleOrDefault(x => x.Key == key));

            b.Log("value", value);

            b.If(
                b.HasObject(entry),
                b =>
                {
                    b.Log("Set entry value", value.As<object>());
                    b.Set(entry, x => x.Value, value.As<object>());
                },
                b =>
                {
                    var newVar = b.NewObj<UiVar>(
                        b =>
                        {
                            b.Set(x => x.Key, key);
                            b.Set(x => x.Value, value);
                        });
                    b.Push(varsGroup, newVar);
                    b.Log(newVar);
                });
        }

        public static void SetVar<TModel>(this BlockBuilder b, Var<TModel> clientModel, Var<string> key, Var<string> value)
        {
            b.SetVar(clientModel, "_default", key, value);
        }

        public static Var<string> GetVar<TModel>(this BlockBuilder b, Var<TModel> clientModel, string group, Var<string> key, Var<string> defaultValue)
        {
            var dynamicModel = clientModel.As<DynamicObject>();

            var clientVars = b.GetDynamic(dynamicModel, ClientSideVars);

            return b.If(
                b.Not(
                    b.HasObject(clientVars)),
                b => defaultValue,
                b =>
                {
                    var varsGroup = b.GetDynamic(clientVars, new DynamicProperty<List<UiVar>>(group));
                    b.Log("varsGroup", varsGroup);
                    return b.If(
                        b.Not(
                            b.HasObject(varsGroup)),
                        b => defaultValue,
                        b =>
                        {
                            b.Log("key", key);
                            var entry = b.Get(varsGroup, key, (varsGroup, key) => varsGroup.SingleOrDefault(x => x.Key == key));
                            b.Log("entry", entry);

                            return b.If(
                                b.Not(
                                    b.HasObject(entry)),
                                b => defaultValue,
                                b => b.Get(entry, x => x.Value));
                        });
                });
        }

        public static Var<string> GetVar<TModel>(this BlockBuilder b, Var<TModel> clientModel, string group, Var<string> key)
        {
            return b.GetVar<TModel>(clientModel, group, key, b.Const(string.Empty));
        }

        public static Var<string> GetVar<TModel, TVar>(this BlockBuilder b, Var<TModel> clientModel, Var<string> key)
        {
            return b.GetVar<TModel>(clientModel, "_default", key);
        }
    }
}