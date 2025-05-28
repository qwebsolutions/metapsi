import * as csharp from './CSharpContracts.js';
import { getVarType } from './CSharpWebComponentContracts.js';
import { getActionType, getListType } from './CSharpContracts.js';
import { toCSharpValidName } from './CSharpWebComponentContracts.js';
import * as ts from "typescript";
import * as typeParser from './TypeParser.js';

export function getIVNodeType() {
    return new csharp.TypeReference({ name: "IVNode", namespace: "Metapsi.Hyperapp" });
}

export function getVarIVNodeType() {
    return getVarType(getIVNodeType());
}

export function getLayoutBuilderType() {
    return new csharp.TypeReference({ name: "LayoutBuilder", namespace: "Metapsi.Hyperapp" });
}

export function getPropsBuilderType(controlType: csharp.TypeReference) {
    var attributesBuilderType = new csharp.TypeReference({ name: "PropsBuilder", namespace: "Metapsi.Syntax" });
    attributesBuilderType.typeArguments.push(controlType);
    return attributesBuilderType;
}

function getPropsBuilderParameter(controlType: csharp.TypeReference) {
    var parameter = new csharp.Parameter("b", getPropsBuilderType(controlType));
    parameter.isThis = true;
    return parameter;
}

export function getLayoutBuilderParameter() {
    var thisHtmlBuilder = new csharp.Parameter("b", getLayoutBuilderType());
    thisHtmlBuilder.isThis = true;
    return thisHtmlBuilder;
}

export function createClientSideConstructors(controlType: string, tagName: string, nodeBuilderName: string, comment: string) {
    var methods: csharp.SyntaxNode[] = [];

    var currentControlType = new csharp.TypeReference({ name: controlType });

    var actionOnTypeBuilderParameter = new csharp.Parameter("buildProps", getActionType(getPropsBuilderType(currentControlType)));

    var withPropsAndParams = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b => {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);

            var nodeParams = new csharp.Parameter("children", getVarIVNodeType());
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

    var withoutPropsWithParams = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b => {
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
        b => {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);
            var nodeParams = new csharp.Parameter("children", getVarType(getListType(getIVNodeType())));
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

    var withoutPropsWithList = csharp.MethodDefinitionNode(
        controlType,
        getVarIVNodeType(),
        b => {
            b.isStatic = true;
            b.parameters.push(getLayoutBuilderParameter());
            var nodeParams = new csharp.Parameter("children", getVarType(getListType(getIVNodeType())));
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

export function createClientSidePropSetters(componentClass: csharp.TypeDefinition, propertyName: string, typeDefinition: string): csharp.SyntaxNode[] {
    var outList: csharp.SyntaxNode[] = [];
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

    attrTypeHandler.onNumber = () => {
        outList.push(createIntProperty(componentClass, propertyName));
        outList.push(createDecimalProperty(componentClass, propertyName));
    }

    attrTypeHandler.onArray = (itemType: ts.TypeNode) =>
    {
        
        //outList.push(createListProperty(componentClass, propertyName, ))
    }

    typeParser.handleTypeDefinition(typeDefinition, attrTypeHandler);

    return outList;
}

export function createStringLiteralProperty(controlType: csharp.TypeDefinition, propertyName: string, value: string): csharp.SyntaxNode {
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);

    return csharp.MethodDefinitionNode(
        "Set" + toCSharpValidName(propertyName) + toCSharpValidName(value),
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));
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
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);

    return csharp.MethodDefinitionNode(
        "Set" + toCSharpValidName(propertyName),
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemBoolType())));
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
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);

    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    methodName,
                    csharp.FunctionCallNode("b", "Const", csharp.trueLiteralNode())));
        });
}

export function createBoolSetConstProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);

    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemBoolType()));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    methodName,
                    csharp.FunctionCallNode("b", "Const", csharp.identifierNode(propertyName))));
        });
}

export function createStringProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);

    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemStringType())));

            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetProperty",
                    csharp.identifierNode("b.Props"),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
                    csharp.identifierNode(propertyName)));
        });
}

export function createIntProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);
    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemIntType())));

            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetProperty",
                    csharp.identifierNode("b.Props"),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
                    csharp.identifierNode(propertyName)));
        });
}

export function createDecimalProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);
    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemDecimalType())));

            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetProperty",
                    csharp.identifierNode("b.Props"),
                    csharp.FunctionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
                    csharp.identifierNode(propertyName)));
        });
}

export function createListProperty(controlType: csharp.TypeDefinition, propertyName: string, itemType: csharp.TypeReference): csharp.SyntaxNode {
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);
    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getListType(itemType))));

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
    var genericControlType = new csharp.TypeParameter("T");
    genericControlType.typeConstraints.push(controlType.name);

    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(genericControlType);
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

            b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemStringType()));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    methodName,
                    csharp.FunctionCallNode("b", "Const", csharp.identifierNode(propertyName))));
        });
}

function getTModelTypeParameter() {
    return new csharp.TypeParameter("TModel");
}

function getTComponentTypeParameter(componentClassName: string) {
    var tComponentGenericType = new csharp.TypeParameter("TComponent");
    tComponentGenericType.typeConstraints.push(componentClassName);
    return tComponentGenericType;
}

function createBaseHyperappActionHandler(componentClass: string, eventName: string, fill: (md: csharp.MethodDefinition) => void) {

    return csharp.MethodDefinitionNode(
        "On" + toCSharpValidName(eventName),
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.typeParameters.push(getTComponentTypeParameter(componentClass));
            b.typeParameters.push(getTModelTypeParameter());
            b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(getTComponentTypeParameter(componentClass))));
            fill(b);
        });
}

function getHtmlEventType() {
    return new csharp.TypeReference({ name: "Event", namespace: "Metapsi.Html" });
}

function getHypertypeAction(...typeArguments: csharp.TypeReference[]) {
    return csharp.getGenericType(
        csharp.getTypeReference("HyperType.Action", "Metapsi.Hyperapp"),
        typeArguments);
}

function getSystemFunc(...typeArguments: csharp.TypeReference[]) {
    return csharp.getGenericType(
        csharp.getTypeReference("Func", "System"),
        typeArguments);
}

function getSyntaxBuilderType() {
    return csharp.getTypeReference("SyntaxBuilder", "Metapsi.Syntax");
}

export function createEventHandlers(componentClass: string, eventName: string): csharp.SyntaxNode[] {
    var outList: csharp.SyntaxNode[] = [];

    // Var<HyperType.Action<TModel,Event>>
    outList.push(createBaseHyperappActionHandler(componentClass, eventName,
        b => {
            b.parameters.push(
                new csharp.Parameter("action", getVarType(getHypertypeAction(csharp.getTypeReference("TModel"), getHtmlEventType()))));
            b.body.push(csharp.FunctionCallNode(
                "b",
                "OnEventAction",
                csharp.stringLiteralNode("on" + eventName),
                csharp.identifierNode("action")
            ))
        }
    ));

    // Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>>
    outList.push(createBaseHyperappActionHandler(componentClass, eventName,
        b => {
            b.parameters.push(new csharp.Parameter(
                "action",
                getSystemFunc(
                    getSyntaxBuilderType(),
                    getVarType(new csharp.TypeReference(getTModelTypeParameter())),
                    getVarType(getHtmlEventType()),
                    getVarType(new csharp.TypeReference(getTModelTypeParameter())))));
            b.body.push(csharp.FunctionCallNode(
                "b",
                b.name, // call same function with client-side action
                csharp.FunctionCallNode(
                    "b",
                    "MakeAction",
                    csharp.identifierNode("action"))));
        }
    ));

    // Ignore event
    // Var<HyperType.Action<TModel>>
    outList.push(createBaseHyperappActionHandler(componentClass, eventName,
        b => {
            b.parameters.push(
                new csharp.Parameter("action", getVarType(getHypertypeAction(csharp.getTypeReference("TModel")))));
            b.body.push(csharp.FunctionCallNode(
                "b",
                "OnEventAction",
                csharp.stringLiteralNode("on" + eventName),
                csharp.identifierNode("action")
            ))
        }
    ));

    // Ignore event
    // Func<SyntaxBuilder, Var<TModel>, Var<TModel>>
    outList.push(createBaseHyperappActionHandler(componentClass, eventName,
        b => {
            b.parameters.push(new csharp.Parameter(
                "action",
                getSystemFunc(
                    getSyntaxBuilderType(),
                    getVarType(new csharp.TypeReference(getTModelTypeParameter())),
                    getVarType(new csharp.TypeReference(getTModelTypeParameter())))));
            b.body.push(csharp.FunctionCallNode(
                "b",
                b.name, // call same function with client-side action
                csharp.FunctionCallNode(
                    "b",
                    "MakeAction",
                    csharp.identifierNode("action"))));
        }
    ));

    return outList;
}
