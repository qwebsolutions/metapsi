using System;
using System.Collections.Generic;
//using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{

    public static class CSharpRoslynBuilder
    {

    }

    public static class CSharpDynamicBuilder
    {
        public static CSharpModule CompileModule(Module module)
        {
            CSharpModule cSharpModule = new CSharpModule();

            foreach (var c in module.Constants)
            {
                if (c.Value is IFunction)
                {
                    cSharpModule.References.Add(new Reference()
                    {
                        Name = c.Name,
                        ObjectReference = BuildFunction(module, c.Value as IFunction, cSharpModule)
                    });
                }
            }

            return cSharpModule;
        }

        public class CSharpModule
        {
            public List<Reference> References { get; set; } = new List<Reference>();
        }

        //public enum ObjectType
        //{
        //    Constant,
        //    Variable
        //}

        public class Reference
        {
            public string Name { get; set; }
            //public ObjectType ObjectType { get; set; }
            public LambdaExpression ObjectReference { get; set; }
        }

        public class Context
        {
            public List<Reference> References { get; set; }
        }

        //public static 

        public static LambdaExpression BuildFunction(Module module, IFunction function, CSharpModule cSharpModule)
        {
            var result = Expression.Variable(function.ReturnVariable.Type, function.ReturnVariable.Name);

            List<Expression> funcBlocks = new List<Expression>();
            var log = HyperappFunctions.Log;
            List<ParameterExpression> parameters = new List<ParameterExpression>();
            int index = 0;
            foreach (IVariable param in function.Parameters)
            {
                parameters.Add(Expression.Parameter(param.Type, param.Name));
                funcBlocks.Add(Expression.Call(log.Method, Expression.Convert(Expression.Constant(param.Name), typeof(object))));
                funcBlocks.Add(Expression.Call(log.Method, Expression.Convert(parameters[index], typeof(object))));
                index++;
            }

            funcBlocks.Add(BuildBlock(module, function.ChildBlock, parameters.ToList(), cSharpModule));

            var l = Expression.Lambda(
                Expression.Block(parameters, funcBlocks),
                parameters);

            return l;
        }

        //public static List<object> GetArguments(Module module, List<IVariable> fromVariables, CallStack callStack)
        //{
        //    List<object> arguments = new List<object>();
        //    foreach (var arg in fromVariables)
        //    {
        //        arguments.Add(GetValue(module, arg.Name, callStack));
        //    }

        //    return arguments;
        //}

        public static ParameterExpression GetValue(string name, Module module, List<ParameterExpression> variables)
        {
            var localVar = variables.SingleOrDefault(x => x.Name == name);
            if (localVar != null)
                return localVar;

            var constant = module.Constants.Single(x => x.Name == name);
            var localConstant = Expression.Parameter(constant.Type, constant.Name);
            Expression.Assign(localConstant, Expression.Constant(constant.Value));

            return localConstant;
        }

        public static object GetProperty(object fromObject, string propertyName)
        {
            return fromObject.GetType().GetProperty(propertyName).GetValue(fromObject);
        }

        public static void SetProperty(object intoObject, string propertyName, object value)
        {
            intoObject.GetType().GetProperty(propertyName).SetValue(intoObject, value);
        }

        public static Expression<Func<System.Collections.IList, int>> GetListSize()
        {
            return (list) => list.Count;
        }

        public static Expression<Func<System.Collections.IList, int, object>> GetListIndex()
        {
            return (list, index) => list[index];
        }

        //public static void Log(object s)
        //{
        //    try
        //    {

        //    }

        //    Console.WriteLine(s);
        //}

        public static Expression BuildBlock(Module module, Block block, List<ParameterExpression> variables, CSharpModule cSharpModule)
        {
            List<Expression> blockExpressions = new List<Expression>();
            variables = new List<ParameterExpression>(variables);
            foreach (var line in block.Lines)
            {
                switch (line)
                {
                    case FunctionCall functionCall:
                        {
                            HashSet<string> alreadyRegisteredNames = new HashSet<string>();

                            Action<string> logCall = HyperappFunctions.Log;
                            blockExpressions.Add(Expression.Call(logCall.Method, Expression.Constant(functionCall.Function.Name)));

                            foreach(var arg in functionCall.Arguments)
                            {
                                var param = GetValue(arg.Name, module, variables);
                                alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                                if (!alreadyRegisteredNames.Contains(param.Name))
                                    variables.Add(param);

                                blockExpressions.Add(Expression.Call(logCall.Method, Expression.Convert(param, typeof(object))));
                            }

                            var intoVar = Expression.Variable(functionCall.IntoVariable.Type, functionCall.IntoVariable.Name);
                            blockExpressions.Add(intoVar);
                            variables.Add(intoVar);

                            var arguments = functionCall.Arguments.Select(x => GetValue(x.Name, module, variables));
                            alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            variables.AddRange(arguments.Where(x => !alreadyRegisteredNames.Contains(x.Name)));

                            if(functionCall.Function is IConstant)
                            {
                                IConstant constantFunc = functionCall.Function as IConstant;
                                if (constantFunc.Value is Import)
                                {
                                    Import import = constantFunc.Value as Import;

                                    if (import.Symbol == "Deserialize")
                                    {
                                        var callExpression = Expression.Call(typeof(HyperappFunctions).GetMethod(import.Symbol), new Expression[] { Expression.Constant(intoVar.Type), Expression.Convert(arguments.Single(), typeof(string)) });
                                        blockExpressions.Add(Expression.Assign(intoVar, callExpression));

                                        if (callExpression.Type != typeof(void))
                                        {
                                            blockExpressions.Add(Expression.Assign(intoVar, Expression.Convert(callExpression, intoVar.Type)));
                                        }
                                        else
                                        {
                                            blockExpressions.Add(callExpression);
                                        }
                                    }
                                    else
                                    {
                                        var method = typeof(HyperappFunctions).GetMethod(import.Symbol);

                                        List<Expression> convertedArgs = new List<Expression>();
                                        int index = 0;
                                        foreach (var arg in arguments)
                                        {
                                            convertedArgs.Add(Expression.Convert(arg, method.GetParameters()[index].ParameterType));
                                            index++;
                                        }

                                        var callExpression = Expression.Call(method, convertedArgs.ToArray());

                                        if (callExpression.Type != typeof(void))
                                        {
                                            blockExpressions.Add(Expression.Assign(intoVar, Expression.Convert(callExpression, intoVar.Type)));
                                        }
                                        else
                                        {
                                            blockExpressions.Add(callExpression);
                                        }
                                    }
                                }
                                else
                                {
                                    if (constantFunc.Value is Expression)
                                    {
                                        var lambda = constantFunc.Value as LambdaExpression;
                                        List<Expression> convertedArgs = new List<Expression>();
                                        int index = 0;
                                        foreach (var arg in arguments)
                                        {
                                            convertedArgs.Add(Expression.Convert(arg, lambda.Parameters[index].Type));
                                            index++;
                                        }
                                        var callExpression = Expression.Invoke(lambda, convertedArgs.ToArray());

                                        if (callExpression.Type != typeof(void))
                                        {
                                            blockExpressions.Add(Expression.Assign(intoVar, Expression.Convert(callExpression, intoVar.Type)));
                                        }
                                        else
                                        {
                                            blockExpressions.Add(callExpression);
                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                                
                            }
                            else
                            {
                                var builtMethod = cSharpModule.References.SingleOrDefault(x => x.Name == functionCall.Function.Name);
                                if(builtMethod == null)
                                {
                                    builtMethod = new Reference()
                                    {
                                        Name = functionCall.Function.Name,
                                        ObjectReference = BuildFunction(module, functionCall.Function as IFunction, cSharpModule)
                                    };

                                    cSharpModule.References.Add(builtMethod);
                                }

                                Delegate compiled = builtMethod.ObjectReference.Compile();

                                //var callExpression = Expression.Call(compiled.Method, arguments.ToArray());
                                var callExpression = Expression.Invoke(builtMethod.ObjectReference, arguments.ToArray());

                                if (callExpression.Type != typeof(void))
                                {
                                    blockExpressions.Add(Expression.Assign(intoVar, Expression.Convert(callExpression, intoVar.Type)));
                                }
                                else
                                {
                                    blockExpressions.Add(callExpression);
                                }

                            }

                            //Expression.Call()
                            //if (functionCall.Function.Name != "Log")
                            //{
                            //    Console.WriteLine($"functionCall {functionCall.Function.Name}");
                            //}
                            //RunCall(module, functionCall, callStack);

                        };
                        break;
                    case PropertyAccess propertyAccess:
                        {
                            var intoVar = Expression.Variable(propertyAccess.IntoVar.Type, propertyAccess.IntoVar.Name);
                            variables.Add(intoVar);
                            var propertyName = GetValue(propertyAccess.Property.PropertyName, module, variables);
                            
                            HashSet<string> alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            if(!alreadyRegisteredNames.Contains(propertyName.Name))
                            {
                                variables.Add(propertyName);
                            }


                            Func<object, string, object> getProperty = GetProperty;

                            var fromVar = GetValue(propertyAccess.FromVar.Name, module, variables);

                            alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            if (!alreadyRegisteredNames.Contains(propertyName.Name))
                            {
                                variables.Add(fromVar);
                            }


                            var propValue = Expression.Call(getProperty.Method, fromVar, propertyName);

                            //alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            //if (!alreadyRegisteredNames.Contains(propertyName.Name))
                            //{
                            //    variables.Add(propValue);
                            //}


                            blockExpressions.Add(Expression.Assign(intoVar, propValue));
                        };
                        break;
                    case ICollectionConstructor collectionConstructor:
                        {
                            var colType = typeof(List<>).MakeGenericType(collectionConstructor.ItemType);
                            var intoVar = Expression.Variable(colType, collectionConstructor.IntoVar.Name);
                            variables.Add(intoVar);
                            blockExpressions.Add(Expression.Assign(intoVar, Expression.New(colType)));
                        };
                        break;
                    case IObjectConstructor objectConstructor:
                        {
                            var intoVar = Expression.Variable(objectConstructor.IntoVar.Type, objectConstructor.IntoVar.Name);
                            variables.Add(intoVar);
                            blockExpressions.Add(Expression.Assign(intoVar, Expression.New(objectConstructor.IntoVar.Type)));
                        }
                        break;
                    case PropertyAssignment propertyAssignment:
                        {
                            var intoObject = GetValue(propertyAssignment.ObjectVar.Name, module, variables);

                            HashSet<string> alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            if (!alreadyRegisteredNames.Contains(intoObject.Name))
                            {
                                variables.Add(intoObject);
                            }

                            var fromVar = GetValue(propertyAssignment.FromVar.Name, module, variables);

                            alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            if (!alreadyRegisteredNames.Contains(fromVar.Name))
                            {
                                variables.Add(fromVar);
                            }

                            var varContainingPropertyName = GetValue(propertyAssignment.Property.PropertyName, module, variables);

                            alreadyRegisteredNames = variables.Select(x => x.Name).ToHashSet();
                            if (!alreadyRegisteredNames.Contains(varContainingPropertyName.Name))
                            {
                                variables.Add(varContainingPropertyName);
                            }

                            Action<object, string, object> setProperty = SetProperty;

                            var setPropertyExpression = Expression.Call(setProperty.Method, intoObject, varContainingPropertyName, fromVar);
                            blockExpressions.Add(setPropertyExpression);

                            //if (propertyAssignment.PropertyVar is IConstant)
                            //{
                            //    string propertyName = (propertyAssignment.PropertyVar as IConstant).Value as string;
                            //    blockExpressions.Add(Expression.Property(variables.Single(x => x.Name == propertyAssignment.FromVar.Name), propertyName));
                            //}
                            //else
                            //{
                            //    var varContainingPropertyName = GetValue(propertyAssignment.PropertyVar.Name, module, variables);

                            //    Action<object, string, object> setProperty = SetProperty;
                            //    var fromVar = GetValue(propertyAssignment.FromVar.Name, module, variables);
                            //    var propValue = Expression.Call(setProperty.Method,  fromVar, varContainingPropertyName);

                            //    blockExpressions.Add();

                            //    throw new NotImplementedException();
                            //    //string propertyName = propertyAssignment.ObjectVar 
                            //    //Expression.Property(blockVariables.Single(x => x.Name == propertyAssignment.FromVar.Name), );
                            //}
                        }
                        break;
                    case IForeachBlock foreachBlock:
                        {
                            var returnLabel = Expression.Label();

                            var collection = GetValue(foreachBlock.CollectionVarName, module, variables);
                            var size = Expression.Invoke(GetListSize(), Expression.Convert(collection, typeof(System.Collections.IList)));
                            var currentIndex = Expression.Variable(typeof(int), "currentIndex");
                            variables.Add(currentIndex);

                            var isDone = Expression.IsFalse(Expression.LessThan(currentIndex, currentIndex));

                            var overVar = Expression.Parameter(typeof(object), foreachBlock.OverVarName);
                            variables.Add(overVar);

                            var loop = Expression.Loop(
                                Expression.Block(
                                    variables,
                                    Expression.Assign(overVar, GetListIndex()),
                                    BuildBlock(module, foreachBlock.ChildBlock, variables, cSharpModule),
                                    Expression.Assign(currentIndex, Expression.Increment(currentIndex)),
                                    Expression.IfThen(
                                        isDone,
                                        Expression.Break(returnLabel))),
                                returnLabel);

                            blockExpressions.Add(loop);

                            //RunForeachBlock(module, foreachBlock, callStack);
                        }
                        break;
                    case IfBlock ifBlock:
                        {
                            var testValue = Expression.Convert(GetValue(ifBlock.Var.Name, module, variables), typeof(bool));
                            if (ifBlock.FalseBlock != null)
                            {
                                blockExpressions.Add(
                                    Expression.IfThenElse(
                                        testValue,
                                        BuildBlock(module, ifBlock.TrueBlock, variables, cSharpModule),
                                        BuildBlock(module, ifBlock.FalseBlock, variables, cSharpModule)));
                            }
                            else
                            {
                                blockExpressions.Add(
                                    Expression.IfThen(testValue,
                                    BuildBlock(module, ifBlock.TrueBlock, variables, cSharpModule)));
                            }
                        }
                        break;
                    case IFunction functionDefinition:
                        {
                            Console.WriteLine($"Lambda {functionDefinition.Name}");
                            // inline function
                            //InspectBlock(module, functionDefinition.ChildBlock, callStack);
                            //callStack.SetReference(functionDefinition.Name, functionDefinition);
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

            var outBlock = Expression.Block(variables, blockExpressions.ToArray());
            return outBlock;
        }


        public static object RunFunction(CSharpModule module, string functionName, List<object> arguments)
        {
            var f = module.References.Single(x => x.Name == functionName).ObjectReference;
            return f.Compile().DynamicInvoke(arguments.ToArray());
        }
    }
}