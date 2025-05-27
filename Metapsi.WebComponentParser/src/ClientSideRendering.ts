import * as csharp from './CSharpContracts';
import { getVarType } from './CSharpWebComponentContracts';
import { getActionType, getListType } from './CSharpContracts';
import { toCSharpValidName, metapsiHtmlNamespace } from './CSharpWebComponentContracts';
import * as typeParser from './TypeParser';

export function getIVNodeType() {
    var ivNodeType = new csharp.TypeDefinition();
    ivNodeType.name = "IVNode";
    ivNodeType.namespace = "Metapsi.Hyperapp";
    return ivNodeType;
}

export function getVarIVNodeType() {
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
    attributesBuilderType.typeArguments.push({ argType: "TypeDefinition", typeDefinition: controlType });

    return attributesBuilderType;
}

function getPropsBuilderParameter(controlType: csharp.TypeDefinition) {
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

    var currentControlType = new csharp.TypeDefinition();
    currentControlType.name = controlType;

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
            var nodeParams = new csharp.Parameter("children", getVarType(csharp.ClosedTypeArgument(getListType(csharp.ClosedTypeArgument(getIVNodeType())))));
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
            var nodeParams = new csharp.Parameter("children", getVarType(csharp.ClosedTypeArgument(getListType(csharp.ClosedTypeArgument(getIVNodeType())))));
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
        "Set" + toCSharpValidName(propertyName) + toCSharpValidName(value),
        csharp.getVoidType(),
        b => {
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
        "Set" + toCSharpValidName(propertyName),
        csharp.getVoidType(),
        b => {
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


    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
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


    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
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

    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
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

    var methodName = "Set" + toCSharpValidName(propertyName);
    return csharp.MethodDefinitionNode(
        methodName,
        csharp.getVoidType(),
        b => {
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

function getTModelGenericType() {
    var tModelGenericType = new csharp.GenericType();
    tModelGenericType.name = "TModel";
    return tModelGenericType;
}

function getTModelConcreteType() {
    var tModelType = new csharp.TypeDefinition();
    tModelType.name = "TModel";
    return tModelType;
}

function getTComponentGenericType(componentClassName: string) {
    var tComponentGenericType = new csharp.GenericType();
    tComponentGenericType.name = "TComponent";
    tComponentGenericType.genericTypeConstraints.push(componentClassName);
    return tComponentGenericType;
}

function getTComponentConcreteType() {
    var tComponentType = new csharp.TypeDefinition();
    tComponentType.name = "TComponent";
    return tComponentType;
}

function createBaseHyperappActionHandler(componentClass: string, eventName: string, fill: (md: csharp.MethodDefinition) => void) {

    return csharp.MethodDefinitionNode(
        "On" + toCSharpValidName(eventName),
        csharp.getVoidType(),
        b => {
            b.isStatic = true;
            b.genericTypes.push(getTComponentGenericType(componentClass));
            b.genericTypes.push(getTModelGenericType());
            b.parameters.push(getPropsBuilderParameter(getTComponentConcreteType()));
            fill(b);
        });
}

function getHtmlEventType() {
    var htmlEventType = new csharp.TypeDefinition();
    htmlEventType.name = "Event";
    htmlEventType.namespace = "Metapsi.Html";
    return htmlEventType;
}

export function createEventHandlers(componentClass: string, eventName: string): csharp.SyntaxNode[] {
    var hyperappActionType = new csharp.TypeDefinition();
    hyperappActionType.name = "HyperType.Action";
    hyperappActionType.namespace = "Metapsi.Hyperapp";

    var tModelHyperActionType = { ...hyperappActionType };
    tModelHyperActionType.typeArguments.push(csharp.OpenTypeArgument(getTModelGenericType()));

    var tModelEventHyperActionType = { ...tModelHyperActionType };
    tModelHyperActionType.typeArguments.push(csharp.OpenTypeArgument(getTModelGenericType()));

    var outList: csharp.SyntaxNode[] = [];
    // HyperType.Action<TModel,Event>
    outList.push(createBaseHyperappActionHandler(componentClass, eventName,
        b => {
            b.parameters.push(new csharp.Parameter("action", getVarType(csharp.ClosedTypeArgument(tModelEventHyperActionType))))
            b.body.push(csharp.FunctionCallNode(
                "b",
                "OnEventAction",
                csharp.stringLiteralNode(eventName),
                csharp.identifierNode("action")
            ))
        }
    ));

    var funcType = new csharp.TypeDefinition();
    funcType.name = "Func";
    funcType.namespace = "System";

    var syntaxBuilderType = new csharp.TypeDefinition();
    syntaxBuilderType.name = "SyntaxBuilder";
    syntaxBuilderType.namespace = "Metapsi.Syntax";

    var funcTypeSyntaxBuilder = {...funcType};
    funcTypeSyntaxBuilder.typeArguments.push(csharp.ClosedTypeArgument(syntaxBuilderType));

    var funcTypeSyntaxBuilderModel = {...funcTypeSyntaxBuilder};

    // Func<SyntaxBuilder, Var<TModel>, Var<TEvent>, Var<TModel>>
    outList.push(createBaseHyperappActionHandler(componentClass, eventName,
        b => {


            // b.parameters.push(new csharp.Parameter("action", csharp getVarType(csharp.ClosedTypeArgument(tModelEventHyperActionType))))
            // b.body.push(csharp.FunctionCallNode(
            //     "b",
            //     "OnEventAction",
            //     csharp.stringLiteralNode(eventName),
            //     csharp.identifierNode("action")
            // ))
        }
    ));

    return outList;
}
