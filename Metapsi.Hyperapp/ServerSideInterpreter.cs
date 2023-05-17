using System;
using System.Collections.Generic;
using System.Dynamic;
//using System.Dynamic;
using System.Linq;

namespace Metapsi.Syntax
{

    public static class ServerSideInterpreter
    {
        public class CallStackLevel
        {
            public CallStackLevel(string functionName)
            {
                this.FunctionName = functionName;
            }

            public string FunctionName { get; set; }
            public int Level { get; set; } = 0;
            public Dictionary<string, object> References { get; set; } = new Dictionary<string, object>();
        }

        public class CallStack
        {
            public class Reference
            {
                public bool found { get; set; }
                public object reference { get; set; }
                public CallStackLevel Level { get; set; }
            }

            private CallStack()
            {

            }

            public CallStack(CallStack previous, string functionName, Dictionary<string, object> arguments)
            {
                if (previous != null)
                {
                    this.StackLevels.AddRange(previous.StackLevels);
                }

                this.StackLevels.Add(
                    new CallStackLevel(functionName)
                    {
                        Level = this.StackLevels.Count,
                        References = arguments
                    });
            }

            public List<CallStackLevel> StackLevels { get; set; } = new();
            public Reference GetReference(string name)
            {
                foreach (var level in StackLevels.OrderByDescending(x=>x.Level))
                {
                    if (level.References.ContainsKey(name))
                        return new Reference()
                        {
                            found = true,
                            reference = level.References[name],
                            Level = level
                        };
                }

                return new Reference()
                {
                    found = false
                };
            }

            private static Dictionary<int, object> mappings = new Dictionary<int, object>();

            public void SetMapping(int indirectHashcode, object toObject)
            {
                mappings[indirectHashcode] = toObject;
            }

            public object GetMapping(int indirectHashcode)
            {
                return mappings[indirectHashcode];
            }

            public void SetReference(string name, object o)
            {
                StackLevels.Last().References[name] = o;
            }

            public void OverwriteReference(string name, object o)
            {
                var prevRef = GetReference(name);
                prevRef.Level.References[name] = o;
            }


            public static CallStack Empty()
            {
                return new CallStack();
            }

        }

        public static object GetValue(Module module, string name, CallStack callStack)
        {
            var onStack = callStack.GetReference(name);
            if (onStack.found)
                return onStack.reference;

            return module.Constants.Single(x => x.Name == name).Value;
        }

        public static dynamic RunFunction(Module module, string functionName, List<object> arguments)
        {
            var function = module.Constants.Single(x => x.Name == functionName);

            //CallStack newStack = new CallStack(functionName);
            List<IVariable> args = new List<IVariable>();
            foreach (var arg in arguments)
            {
                new ModuleBuilder(module).Const(arg);
                args.Add(module.Constants.Single(x => x.Value == arg));
            }

            var call = new FunctionCall()
            {
                Arguments = args,
                Function = function,
                IntoVariable = new Var<object>(new ModuleBuilder(module).NewName())
            };
            return RunCall(module, call);
        }

        //public static dynamic RunDefinedFunction(Module module, IFunction function, List<object> arguments, CallStack callstack)
        //{
        //    var parameters = function.Parameters;
        //    int argIndex = 0;

        //    Dictionary<string, object> localArguments = new Dictionary<string, object>();

        //    foreach (var arg in parameters)
        //    {
        //        localArguments[arg.Name] = arguments[argIndex];
        //        argIndex++;
        //    }

        //    var newStack = callstack.NewCall(localArguments);

        //    RunBlock(module, function.ChildBlock, newStack);
        //    return newStack.GetReference(function.ReturnVariable.Name);
        //}

        public static List<object> GetArguments(Module module, List<IVariable> fromVariables, CallStack callStack)
        {
            List<object> arguments = new List<object>();
            foreach (var arg in fromVariables)
            {
                arguments.Add(GetValue(module, arg.Name, callStack));
            }

            return arguments;
        }

        enum FunctionType
        {
            Defined,
            External,
            Expression
        }

        public static object RunCall(Module module, FunctionCall functionCall, CallStack callStack = null)
        {
            if (callStack == null)
                callStack = CallStack.Empty();

            object outResult = null;

            //Console.WriteLine(functionCall.Function.Name);

            var arguments = GetArguments(module, functionCall.Arguments, callStack);
            //Console.WriteLine(String.Join(" ", arguments.Select(x =>
            //{
            //    if (x == null)
            //        return x;
            //    return x.ToString();

            //    //if (x is Delegate)
            //    //{
            //    //    return (x as Delegate).ToString();
            //    //}
            //    //else
            //    //{
            //    //    return Metapsi.Serialize.ToJson(x);
            //    //}
            //})));

            FunctionType functionType = FunctionType.Defined;

            if (functionCall.Function is IConstant)
            {
                if ((functionCall.Function as IConstant).Value is Import)
                {
                    functionType = FunctionType.External;
                }
                else
                {
                    if ((functionCall.Function as IConstant).Value is System.Linq.Expressions.Expression)
                    {
                        functionType = FunctionType.Expression;
                    }
                }
            }

            switch (functionType)
            {
                case FunctionType.Defined:
                    {
                        IFunction function = null;
                        var functionConst = module.Constants.SingleOrDefault(x => x.Name == functionCall.Function.Name);
                        if (functionConst != null)
                        {
                            function = functionConst.Value as IFunction;
                        }
                        else
                        {
                            var funcVar = callStack.GetReference(functionCall.Function.Name).reference;

                            if (funcVar is IFunction)
                            {
                                function = funcVar as IFunction;
                            }
                            else
                            {
                                // If invoked function is just a wrapper, map to the real one

                                //string funcRefKey = $"funcRef|{callStack.GetReference(functionCall.Function.Name).GetHashCode()}";

                                var indirectFunc = callStack.GetMapping(funcVar.GetHashCode());
                                function = indirectFunc as IFunction;
                            }
                        }

                        var parameters = function.Parameters;
                        int argIndex = 0;

                        Dictionary<string, object> localArguments = new Dictionary<string, object>();

                        foreach (var arg in parameters)
                        {
                            localArguments[arg.Name] = arguments[argIndex];
                            argIndex++;
                        }

                        var newStack = new CallStack(callStack, function.Name, localArguments);

                        RunBlock(module, function.ChildBlock, newStack);

                        if (function.ReturnVariable != null)
                        {
                            outResult = newStack.GetReference(function.ReturnVariable.Name).reference;
                        }
                    }
                    break;
                case FunctionType.External:
                    {
                        var externalFunction = typeof(HyperappFunctions).GetMethod(functionCall.Function.Name);
                        var result = externalFunction.Invoke(null, arguments.ToArray());
                        outResult = result;
                    }
                    break;
                case FunctionType.Expression:
                    {
                        var expr = (functionCall.Function as IConstant).Value as System.Linq.Expressions.LambdaExpression;
                        var compiled = expr.Compile();
                        var result = compiled.DynamicInvoke(arguments.ToArray());
                        outResult = result;
                        //callStack.SetReference(functionCall.IntoVariable.Name, result);
                    }
                    break;
                default:
                    {
                        throw new NotSupportedException();
                    }
            }
            if (callStack.StackLevels.Any())
            {
                // Set it into local variable
                callStack.SetReference(functionCall.IntoVariable.Name, outResult);
            }
            // But also return for top level call
            return outResult;
        }


        public static void RunPropertyAccess(Module module, PropertyAccess propertyAccess, CallStack callstack)
        {
            var fromVar = GetValue(module, propertyAccess.FromVar.Name, callstack);
            var propertyName = GetValue(module, propertyAccess.Property.PropertyName, callstack) as string;

            object propertyValue = null;

            var property = fromVar.GetType().GetProperty(propertyName);
            if (property != null)
            {
                propertyValue = property.GetValue(fromVar);
            }
            else
            {
                Dictionary<string, object> dynamicObject = fromVar as Dictionary<string, object>;
                if (dynamicObject.ContainsKey(propertyName))
                {
                    propertyValue = dynamicObject[propertyName];
                }
            }
            callstack.SetReference(propertyAccess.IntoVar.Name, propertyValue);
        }

        public static void RunPropertyAssignment(Module module, PropertyAssignment propertyAssignment, CallStack callStack)
        {
            var fromObject = GetValue(module, propertyAssignment.FromVar.Name, callStack);
            var intoObject = GetValue(module, propertyAssignment.ObjectVar.Name, callStack);
            var propertyName = GetValue(module, propertyAssignment.Property.PropertyName, callStack) as string;

            var objectProperty = intoObject.GetType().GetProperty(propertyName);

            if (objectProperty != null)
            {
                if (!(objectProperty.PropertyType.IsAssignableTo(typeof(Delegate))))
                {
                    // There is nothing to convert
                    if (objectProperty.PropertyType == fromObject.GetType())
                    {
                        objectProperty.SetValue(intoObject, fromObject);
                    }
                    else
                    {
                        if (fromObject is System.Collections.Generic.IList<object>)
                        {
                            dynamic typedList = Activator.CreateInstance(typeof(List<>).MakeGenericType(objectProperty.PropertyType.GenericTypeArguments.First()));
                            foreach (object o in (fromObject as System.Collections.Generic.IList<object>))
                            {
                                typedList.Add((dynamic)o);
                            }
                            objectProperty.SetValue(intoObject, typedList);
                        }
                    }
                }
                else
                {
                    var paramTypes = (fromObject as IFunction).Parameters.Select(x => x.Type).ToList();
                    object funcRef = null;

                    if (objectProperty.PropertyType.Name.Contains("Action"))
                    {
                        funcRef = FuncBuilder.BuildAction(() => { Console.WriteLine($"Action {fromObject} {intoObject} {propertyName}"); }, paramTypes.ToArray());
                    }
                    else
                    {
                        paramTypes.Add((fromObject as IFunction).ReturnVariable.Type);
                        funcRef = FuncBuilder.BuildFunc(() => { Console.WriteLine($"Action {fromObject} {intoObject} {propertyName}"); }, paramTypes.ToArray());
                    }

                    objectProperty.SetValue(intoObject, funcRef);
                    callStack.SetMapping(funcRef.GetHashCode(), fromObject);
                    //callStack.SetReference($"funcRef|{funcRef.GetHashCode()}", fromObject);
                }
            }
            else
            {
                var dynamicObject = intoObject as Dictionary<string, object>;
                if (dynamicObject == null)
                {
                    dynamicObject = new Dictionary<string, object>();
                }
                callStack.SetReference(propertyAssignment.ObjectVar.Name, dynamicObject);
                dynamicObject[propertyName] = fromObject;
            }
        }

        public static void RunCollectionConstructor(Module module, ICollectionConstructor collectionConstructor, CallStack callStack)
        {
            callStack.SetReference(collectionConstructor.IntoVar.Name, new List<object>());
        }

        public static void RunObjectConstructor(Module module, IObjectConstructor objectConstructor, CallStack callStack)
        {
            if (objectConstructor.From == null)
                throw new NotSupportedException();

            callStack.SetReference(objectConstructor.IntoVar.Name, objectConstructor.From);
        }

        public static void RunForeachBlock(Module module, IForeachBlock foreachBlock, CallStack callStack)
        {
            var collection = GetValue(module, foreachBlock.CollectionVarName, callStack) as System.Collections.IEnumerable;
            foreach (object item in collection)
            {
                callStack.SetReference(foreachBlock.OverVarName, item);
                RunBlock(module, foreachBlock.ChildBlock, callStack);
                //Console.WriteLine($"foreach item: {Metapsi.Serialize.ToJson(item)}");
            }
        }

        public static void RunIfBlock(Module module, IfBlock ifBlock, CallStack callStack)
        {
            bool val = (bool)GetValue(module, ifBlock.Var.Name, callStack);
            if (val)
            {
                RunBlock(module, ifBlock.TrueBlock, callStack);
            }
            else
            {
                if (ifBlock.FalseBlock != null)
                {
                    RunBlock(module, ifBlock.FalseBlock, callStack);
                }
            }
        }

        public static void RunBlock(Module module, Block block, CallStack callStack)
        {
            foreach (var line in block.Lines)
            {
                switch(line)
                {
                    case FunctionCall functionCall:
                        {
                            if (functionCall.Function.Name != "Log")
                            {
                                Console.WriteLine($"functionCall {functionCall.Function.Name}");
                            }
                            RunCall(module, functionCall, callStack);
                            
                        };
                        break;
                    case PropertyAccess propertyAccess:
                        {
                            RunPropertyAccess(module, propertyAccess, callStack);
                        };
                        break;
                    case ICollectionConstructor collectionConstructor:
                        {
                            RunCollectionConstructor(module, collectionConstructor, callStack);
                        };
                        break;
                    case IObjectConstructor objectConstructor:
                        {
                            RunObjectConstructor(module, objectConstructor, callStack);
                        }
                        break;
                    case PropertyAssignment propertyAssignment:
                        {
                            RunPropertyAssignment(module, propertyAssignment, callStack);
                        }
                        break;
                    case IForeachBlock foreachBlock:
                        {
                            RunForeachBlock(module, foreachBlock, callStack);
                        }
                        break;
                    case IfBlock ifBlock:
                        {
                            RunIfBlock(module, ifBlock, callStack);
                        }
                        break;
                    case IFunction functionDefinition:
                        {
                            Console.WriteLine($"Lambda {functionDefinition.Name}");
                            // inline function
                            InspectBlock(module, functionDefinition.ChildBlock, callStack);
                            callStack.SetReference(functionDefinition.Name, functionDefinition);
                        }
                        break;
                    case LineComment lineComment:
                        {
                            // Nothing to do, this is an interpreter
                        }
                        break;
                    default:
                        throw new NotImplementedException(line.GetType().Name);
                }
            }
        }

        public static void GetAllClosures(IFunction lambdaFunction)
        {

        }

        public static void InspectBlock(Module module, Block block, CallStack callStack)
        {
            foreach (var line in block.Lines)
            {
                switch (line)
                {
                    case FunctionCall functionCall:
                        {
                            Console.WriteLine($"FunctionCall {functionCall.Function.Name}");
                            //RunCall(module, functionCall, callStack);
                        };
                        break;
                    case PropertyAccess propertyAccess:
                        {
                            var foundRef = callStack.GetReference(propertyAccess.FromVar.Name);
                            if (foundRef.found)
                            {
                                Console.WriteLine($"{propertyAccess.FromVar.Name} level {foundRef.Level.Level}");
                            }
                            //RunPropertyAccess(module, propertyAccess, callStack);
                        };
                        break;
                    case ICollectionConstructor collectionConstructor:
                        {
                            //RunCollectionConstructor(module, collectionConstructor, callStack);
                        };
                        break;
                    case IObjectConstructor objectConstructor:
                        {
                            //RunObjectConstructor(module, objectConstructor, callStack);
                        }
                        break;
                    case PropertyAssignment propertyAssignment:
                        {
                            //RunPropertyAssignment(module, propertyAssignment, callStack);
                        }
                        break;
                    case IForeachBlock foreachBlock:
                        {
                            RunForeachBlock(module, foreachBlock, callStack);
                        }
                        break;
                    case IfBlock ifBlock:
                        {
                            InspectBlock(module, ifBlock.TrueBlock, callStack);
                            if (ifBlock.FalseBlock != null)
                                InspectBlock(module, ifBlock.FalseBlock, callStack);
                        }
                        break;
                    case IFunction functionDefinition:
                        {
                            // inline function
                            callStack.SetReference(functionDefinition.Name, functionDefinition);
                            //Console.WriteLine($"Lambda {functionDefinition.Name}");
                        }
                        break;
                    case LineComment lineComment:
                        {
                            // Nothing to do, this is an interpreter
                        }
                        break;
                    default:
                        throw new NotImplementedException(line.GetType().Name);
                }
            }
        }
    }

    public class FuncSignatureBuilder<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public Action BuildAction0(Action action)
        {
            return () => { action(); };
        }

        public Action<T1> BuildAction1(Action action)
        {
            return (p1) => { };
        }

        public Action<T1,T2> BuildAction2(Action action)
        {
            return (p1,p2) => { action(); };
        }

        public Action<T1, T2, T3> BuildAction3(Action action)
        {
            return (p1, p2, p3) => { action(); };
        }

        public Func<T1> BuildFunc0(Action action)
        {
            return () =>
            {
                action();
                return
                default(T1);
            };
        }

        public Func<T1, T2> BuildFunc1(Action action)
        {
            return (p1) =>
            {
                action();
                return default(T2);
            };
        }

        public Func<T1, T2, T3> BuildFunc2(Action action)
        {
            return (p1, p2) =>
            {
                action();
                return default(T3);
            };
        }

        public Func<T1, T2, T3, T4> BuildFunc3(Action action)
        {
            return (p1, p2, p3) =>
            {
                action();
                return default(T4);
            };
        }
    }

    public static class FuncBuilder
    {
        public static object BuildFunc(Action action, params Type[] paramTypes)
        {
            object builder = BuildBuilder(paramTypes);
            return builder.GetType().GetMethod("BuildFunc" + (paramTypes.Length - 1)).Invoke(builder, new object[] { action });
        }

        public static object BuildAction(Action action, params Type[] paramTypes)
        {
            object builder = BuildBuilder(paramTypes);
            return builder.GetType().GetMethod("BuildAction" + paramTypes.Length).Invoke(builder, new object[] { action });
        }

        public static object BuildBuilder(params Type[] paramTypes)
        {
            List<Type> tenTypes = new List<Type>();
            for (int i = 0; i < 10; i++)
            {
                tenTypes.Add(typeof(object));
                if (i < paramTypes.Length)
                {
                    tenTypes[i] = paramTypes[i];
                }
            }
            Type funcBuilder = typeof(FuncSignatureBuilder<,,,,,,,,,>).MakeGenericType(tenTypes.ToArray());
            return Activator.CreateInstance(funcBuilder);
        }
    }



    public static class HyperappFunctions
    {
        public static HyperNode h(string tag, DynamicObject attributes, List<HyperNode> children)
        {

            return new HyperNode()
            {
                tag = tag,
                props = attributes,// as Dictionary<string,object>,
                children = children
            };
        }

        public static HyperNode text(object text)
        {
            return new HyperNode()
            {
                tag = "text",
                text = text.ToString()
            };
        }

        public static void Push<T>(List<T> intoList, T item)
        {
            intoList.Add(item);
        }

        public static string Concat(System.Collections.IList list)
        {
            string output = string.Empty;
            foreach (object item in list)
            {
                if (item != null)
                {
                    output += item.ToString();
                }
            }

            return output;
        }

        public static bool Not(bool v)
        {
            return !v;
        }

        public static bool HasValue(string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        public static bool HasObject(object o)
        {
            return o != null;
        }

        public static bool IsEmptyObject(object o)
        {
            return o == null;
        }

        public static bool IsEmptyString(string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsEmptyGuid(Guid guid)
        {
            return Guid.Empty == guid;
        }

        public static Guid EmptyId()
        {
            return Guid.Empty;
        }

        public static bool AreEqual(object v1, object v2)
        {
            var areEqual = Equals(v1, v2);
            //Console.WriteLine($"AreEqual {v1} {v2} = {areEqual}");
            return areEqual;
        }

        public static bool IsNull(object o)
        {
            return o == null;
        }

        public static Guid NewId()
        {
            return Guid.NewGuid();
        }

        public static void Log(object o)
        {
            try
            {
                Console.WriteLine(Metapsi.Serialize.ToJson(o));
            }
            catch
            {
                Console.WriteLine(o.ToString());
            }
        }

        public static string Serialize(object o)
        {
            return Metapsi.Serialize.ToJson(o);
        }

        public static object Deserialize(Type type, string json)
        {
            return Metapsi.Serialize.FromJson(type, json);
        }

        public static T Deserialize<T>(string json)
        {
            return Metapsi.Serialize.FromJson<T>(json);
        }

        public static DateTime ParseDate(object o)
        {
            if(o is string)
                return DateTime.Parse(o as string);

            if (o is DateTime)
                return (DateTime)o;

            throw new ArgumentException();
        }

        public static object CloneObject(object o)
        {
            return System.Text.Json.JsonSerializer.Deserialize(System.Text.Json.JsonSerializer.Serialize(o), o.GetType());
        }

        public static string FormatLocaleDate(DateTime d, string cultureCode)
        {
            return d.ToString("G", new System.Globalization.CultureInfo(cultureCode));
        }

        public static object GetProperty(DynamicObject d, string propertyName)
        {
            return d.Get(new DynamicProperty<object>(propertyName));
        }

        public static void SetProperty(DynamicObject d, string propertyName, object v)
        {
            d.Set(new DynamicProperty() { Type = v.GetType(), PropertyName = propertyName }, v);
        }

        public static string AsString(object o)
        {
            return o.ToString();
        }

        public static Guid ParseId(string s)
        {
            return Guid.Parse(s);
        }

        public static void plusZoom()
        {
            throw new NotSupportedException();
        }

        public static void minusZoom()
        {
            throw new NotImplementedException();
        }

        public static void minimize()
        {
            throw new NotImplementedException();
        }

        public static void maximize()
        {
            throw new NotImplementedException();
        }

        public static void setGraph(object o)
        {
            // do nothing
        }

        public static bool getMaximized()
        {
            return false;
        }
    }
}