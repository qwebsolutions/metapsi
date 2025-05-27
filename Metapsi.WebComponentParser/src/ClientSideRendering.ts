import * as csharp from './CSharpContracts';
import {getVarType}  from './CSharpWebComponentContracts';
import { getActionType, getListType } from './CSharpContracts';
import { toCSharpValidName, metapsiHtmlNamespace } from './CSharpWebComponentContracts';
import * as typeParser from './TypeParser';

export function getIVNodeType() {
    var ivNodeType = new csharp.TypeDefinition();
    ivNodeType.name = "IVNode";
    ivNodeType.namespace = "Metapsi.Hyperapp";
    return ivNodeType;
}

export function getVarIVNodeType(){
    return getVarType(csharp.ClosedTypeArgument(getIVNodeType()));
}

export function getLayoutBuilderType() {
    var htmlBuilderType = new csharp.TypeDefinition();
    htmlBuilderType.name = "LayoutBuilder";
    htmlBuilderType.namespace = "Metapsi.Hyperapp";
    return htmlBuilderType;
}

export function getPropsBuilderType(controlType: csharp.TypeDefinition) {
    var attributesBuilderType = new csharp.TypeDefinition();
    attributesBuilderType.name = "PropsBuilder";
    attributesBuilderType.namespace = "Metapsi.Syntax";
    attributesBuilderType.typeArguments.push({argType: "TypeDefinition", typeDefinition : controlType});

    return attributesBuilderType;
}

function getPropsBuilderParameter(controlType: csharp.TypeDefinition) {
    var parameter = new csharp.Parameter("b",  getPropsBuilderType(controlType));
    parameter.isThis = true;
    return parameter;
}

export function getLayoutBuilderParameter() {
    var thisHtmlBuilder = new csharp.Parameter("b", getLayoutBuilderType());
    thisHtmlBuilder.isThis = true;
    return thisHtmlBuilder;
}

export function createClientSideConstructors(controlType: string, tagName: string, nodeBuilderName: string, comment: string){
    var methods : csharp.SyntaxNode[] = [];

    var currentControlType = new csharp.TypeDefinition();
    currentControlType.name = controlType;

    var actionOnTypeBuilderParameter = new csharp.Parameter("buildProps",getActionType(getPropsBuilderType(currentControlType)));

    var withPropsAndParams = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);
                   
            var nodeParams = new csharp.Parameter("children",getVarIVNodeType());
            nodeParams.isParams = true;
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.identifierNode(actionOnTypeBuilderParameter.name),
                        csharp.identifierNode(nodeParams.name))));
        });
    methods.push(withPropsAndParams);

    var withoutPropsWithParams  = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());                  
            var nodeParams = new csharp.Parameter("children", getVarIVNodeType());
            nodeParams.isParams = true;
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withoutPropsWithParams);

    var withPropsWithList = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());                  
            b.parameters.push(actionOnTypeBuilderParameter);
            var nodeParams = new csharp.Parameter("children",getVarType(csharp.ClosedTypeArgument(getListType(csharp.ClosedTypeArgument(getIVNodeType())))));
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.identifierNode(actionOnTypeBuilderParameter.name),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withPropsWithList);

    var withoutPropsWithList  = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());                  
            var nodeParams = new csharp.Parameter("children",getVarType(csharp.ClosedTypeArgument(getListType(csharp.ClosedTypeArgument(getIVNodeType())))));
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withoutPropsWithList);

    return methods;
}

export function CreateClientSidePropSetters(componentClass: csharp.TypeDefinition, propertyName: string, typeDefinition: string) : csharp.SyntaxNode[] {
    var outList : csharp.SyntaxNode[] = [];
    var attrTypeHandler: typeParser.TypeHandler = new typeParser.TypeHandler();
    attrTypeHandler.onStringLiteral = (value) => {
        outList.push(createStringLiteralProperty(componentClass, propertyName, value));
    }
    attrTypeHandler.onBoolean = () => {
        outList.push(createBoolSetValueProperty(componentClass, propertyName));    
        outList.push(createBoolSetTrueProperty(componentClass, propertyName));
        outList.push(createBoolSetConstProperty(componentClass, propertyName));
    }
    attrTypeHandler.onString = () => {
        outList.push(createStringProperty(componentClass, propertyName));
        outList.push(createStringConstProperty(componentClass, propertyName));
    }
    typeParser.handleTypeDefinition(typeDefinition, attrTypeHandler);

    return outList;
}

export function createStringLiteralProperty(controlType: csharp.TypeDefinition, propertyName: string, value: string): csharp.SyntaxNode {
    var genericControlType = new csharp.GenericType();
    genericControlType.name = "T";
    genericControlType.genericTypeConstraints.push(controlType.name);

    var localControlType = new csharp.TypeDefinition();
    localControlType.name = "T";

    return csharp.MethodDefinitionNode(
        "Set"+ toCSharpValidName(propertyName) + toCSharpValidName(value),
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.genericTypes.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(localControlType));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetProperty",
                    csharp.identifierNode("b.Props"),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(value))));
        });
}

export function createBoolSetValueProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.GenericType();
    genericControlType.name = "T";
    genericControlType.genericTypeConstraints.push(controlType.name);

    var localControlType = new csharp.TypeDefinition();
    localControlType.name = "T";

    return csharp.MethodDefinitionNode(
        "Set"+ toCSharpValidName(propertyName),
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.genericTypes.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(localControlType));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.ClosedTypeArgument(csharp.getSystemBoolType()))));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetProperty",
                    csharp.identifierNode("b.Props"),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
                    csharp.identifierNode(propertyName)));
        });
    }

export function createBoolSetTrueProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.GenericType();
    genericControlType.name = "T";
    genericControlType.genericTypeConstraints.push(controlType.name);

    var localControlType = new csharp.TypeDefinition();
    localControlType.name = "T";


    var methodName = "Set"+ toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.genericTypes.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(localControlType));

            //b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.ClosedTypeArgument(csharp.getSystemBoolType()))));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    methodName,
                    csharp.FunctionCallNode("b", "Const", csharp.trueLiteralNode())));
        });
    }

export function createBoolSetConstProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.GenericType();
    genericControlType.name = "T";
    genericControlType.genericTypeConstraints.push(controlType.name);

    var localControlType = new csharp.TypeDefinition();
    localControlType.name = "T";


    var methodName = "Set"+ toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.genericTypes.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(localControlType));

            b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemBoolType()));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    methodName,
                    csharp.FunctionCallNode("b", "Const", csharp.identifierNode(propertyName))));
        });
    }

export function createStringProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.GenericType();
    genericControlType.name = "T";
    genericControlType.genericTypeConstraints.push(controlType.name);

    var localControlType = new csharp.TypeDefinition();
    localControlType.name = "T";

    var methodName = "Set"+ toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.genericTypes.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(localControlType));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.ClosedTypeArgument(csharp.getSystemStringType()))));
            
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetProperty",
                    csharp.identifierNode("b.Props"),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
                    csharp.identifierNode(propertyName)));
        });
    }

export function createStringConstProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.GenericType();
    genericControlType.name = "T";
    genericControlType.genericTypeConstraints.push(controlType.name);

    var localControlType = new csharp.TypeDefinition();
    localControlType.name = "T";

    var methodName = "Set"+ toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.genericTypes.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(localControlType));

            b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemStringType()));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    methodName,
                    csharp.FunctionCallNode("b", "Const", csharp.identifierNode(propertyName))));
        });
    }

// function createStringAttribute(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     return csharp.MethodDefinitionNode(
//         "Set"+ toCSharpValidName(propertyName),
//         csharp.getVoidType(),
//         b=>
//         {
//             b.parameters.push(getAttributesBuilderParameter(controlType));
//             b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemStringType()));
//             b.body.push(
//                 csharp.FunctionCallNode(
//                     "b",
//                     "SetAttribute",
//                     csharp.stringLiteralNode(propertyName),
//                     csharp.identifierNode(propertyName)));
//         });
//     }