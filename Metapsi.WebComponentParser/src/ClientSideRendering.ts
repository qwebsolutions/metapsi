import * as csharp from './CSharpContracts.js';
import { SetterFnName, EventFnName, toCSharpValidName } from './CSharpWebComponentContracts.js';
import * as ts from "typescript";
import * as typeParser from './TypeParser.js';
import * as sysTypes from './CSharpSystemTypes.js';

const varType: csharp.TypeReference = { name: "Var", namespace: "Metapsi.Syntax" }
const iVNodeType = { name: "IVNode", namespace: "Metapsi.Hyperapp" }
const varIVNodeType: csharp.TypeReference = { ...varType, typeArguments: [iVNodeType] }
const layoutBuilderType: csharp.TypeReference = { name: "LayoutBuilder", namespace: "Metapsi.Hyperapp" }
const propsBuilderType = { name: "PropsBuilder", namespace: "Metapsi.Syntax" }
const hyperappActionType = { name: "HyperType.Action", namespace: "Metapsi.Hyperapp" }
const domEventType = { name: "Event", namespace: "Metapsi.Html" }

export function createHyperappNodeConstructor(controlTypeName: string, parameters: csharp.Parameter[], body: csharp.SyntaxNode[]): csharp.MethodDefinition {
    return {
        name: controlTypeName,
        returnType: varIVNodeType,
        isStatic: true,
        visibility: 'public',
        parameters: [
            {
                isThis: true,
                name: "b",
                type: layoutBuilderType
            },
            ...parameters
        ],
        body
    }
}

export function createActionParamsChildrenHyperappNodeConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createHyperappNodeConstructor(
        controlTypeName, [{
            name: "buildProps",
            type: {
                ...sysTypes.systemAction,
                typeArguments: [{
                    ...propsBuilderType,
                    typeArguments: [{ name: controlTypeName }]
                }]
            }
        }, {
            isParams: true,
            name: "children",
            type: varIVNodeType
        }
    ],
        [
            csharp.returnNode(
                csharp.functionCallNode(
                    "b",
                    constructorFnName,
                    csharp.stringLiteralNode(tagName),
                    csharp.identifierNode("buildProps"),
                    csharp.identifierNode("children")
                )
            )
        ]
    )
}


export function createParamsChildrenHyperappNodeConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createHyperappNodeConstructor(
        controlTypeName, [{
            isParams: true,
            name: "children",
            type: varIVNodeType
        }
    ],
        [
            csharp.returnNode(
                csharp.functionCallNode(
                    "b",
                    constructorFnName,
                    csharp.stringLiteralNode(tagName),
                    csharp.identifierNode("children")
                )
            )
        ]
    )
}


export function createActionListChildrenHyperappNodeConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createHyperappNodeConstructor(
        controlTypeName, [{
            name: "buildProps",
            type: {
                ...sysTypes.systemAction,
                typeArguments: [{
                    ...propsBuilderType,
                    typeArguments: [{ name: controlTypeName }]
                }]
            }
        }, {
            name: "children",
            type: {
                ...varType,
                typeArguments: [{
                    ...sysTypes.systemCollectionsGenericList,
                    typeArguments: [iVNodeType]
                }]
            }
        }
    ],
        [
            csharp.returnNode(
                csharp.functionCallNode(
                    "b",
                    constructorFnName,
                    csharp.stringLiteralNode(tagName),
                    csharp.identifierNode("buildProps"),
                    csharp.identifierNode("children")
                )
            )
        ]
    )
}


export function createListChildrenHyperappNodeConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createHyperappNodeConstructor(
        controlTypeName, [{
            name: "children",
            type: {
                ...varType,
                typeArguments: [{
                    ...sysTypes.systemCollectionsGenericList,
                    typeArguments: [iVNodeType]
                }]
            }
        }
    ],
        [
            csharp.returnNode(
                csharp.functionCallNode(
                    "b",
                    constructorFnName,
                    csharp.stringLiteralNode(tagName),
                    csharp.identifierNode("children")
                )
            )
        ]
    )
}
export function createPropertySetter(setterFnName: string, controlTypeName: string, parameters: csharp.Parameter[], body: csharp.SyntaxNode[]): csharp.MethodDefinition {
    return {
        visibility: "public",
        isStatic: true,
        returnType: sysTypes.systemVoid,
        name: setterFnName,
        typeParameters: [{ name: "T", typeConstraints: [controlTypeName] }],
        parameters: [
            {
                isThis: true,
                name: "b",
                type: {
                    name: "PropsBuilder", namespace: "Metapsi.Syntax", typeArguments: [
                        { name: "T" }
                    ]
                }
            },
            ...parameters
        ],
        body
    }
}

export function createLiteralPropertySetter(controlTypeName: string, propertyName: string, literalValue: string): csharp.MethodDefinition {
    return createPropertySetter(
        SetterFnName(propertyName, literalValue),
        controlTypeName,
        [],
        [
            csharp.functionCallNode(
                "b",
                "SetProperty",
                csharp.identifierNode("b.Props"),
                csharp.functionCallNode(
                    "b",
                    "Const",
                    csharp.stringLiteralNode(propertyName)),
                csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(literalValue)))
        ])
}

export function createValuePropertySetter(controlTypeName: string, propertyName: string, csharpType: csharp.TypeReference): csharp.MethodDefinition {
    return createPropertySetter(
        SetterFnName(propertyName),
        controlTypeName,
        [{
            name: propertyName,
            type: { ...varType, typeArguments: [csharpType] }
        }],
        [
            csharp.functionCallNode(
                "b",
                "SetProperty",
                csharp.identifierNode("b.Props"),
                csharp.functionCallNode(
                    "b",
                    "Const",
                    csharp.stringLiteralNode(propertyName)),
                csharp.identifierNode(propertyName))
        ])
}

export function createConstRedirectPropertySetter(controlTypeName: string, propertyName: string, csharpType: csharp.TypeReference): csharp.MethodDefinition {
    return createPropertySetter(
        SetterFnName(propertyName),
        controlTypeName,
        [{
            name: propertyName,
            type: csharpType
        }],
        [
            csharp.functionCallNode(
                "b",
                SetterFnName(propertyName),
                csharp.functionCallNode(
                    "b",
                    "Const",
                    csharp.identifierNode(propertyName)))
        ])
}

export function createEventSetter(setterFnName: string, controlTypeName: string, parameters: csharp.Parameter[], body: csharp.SyntaxNode[]): csharp.MethodDefinition {
    var propertySetter = createPropertySetter(setterFnName, controlTypeName, parameters, body);
    return {
        ...propertySetter,
        typeParameters: [... (propertySetter.typeParameters ?? []), { name: "TModel" }]
    }
}

export function createVarActionEventEventSetter(controlTypeName: string, eventName: string): csharp.MethodDefinition {
    return createEventSetter(
        EventFnName(eventName),
        controlTypeName,
        [
            {
                name: "action",
                type: {
                    ...varType,
                    typeArguments: [
                        {
                            ...hyperappActionType,
                            typeArguments: [
                                { name: "TModel" },
                                domEventType
                            ]
                        }
                    ]
                }

            }
        ], [
        csharp.functionCallNode(
            "b",
            "SetProperty",
            csharp.identifierNode("b.Props"),
            csharp.functionCallNode("b", "Const", csharp.stringLiteralNode("on" + eventName)),
            csharp.identifierNode("action")
        )
    ]
    )
}

// export function getDefaultAddEvent(componentClass: csharp.TypeDefinition, e: schema.Event): csharp.SyntaxNode[] {
//     var outNodes: csharp.SyntaxNode[] = [];
//     var commentNode = csharp.commentNode(`<para> ${escapeComment(e.description!)} </para>`);
//     var eventHandlers = csr.createEventHandlers(componentClass.name, e.name);
//     eventHandlers.forEach(handler => {
//         outNodes.push(commentNode);
//         outNodes.push(handler);
//         outNodes.push(csharp.newLineNode());
//     })
//     return outNodes;
// }

// export function createClientSidePropSetters(componentClass: csharp.TypeDefinition, propertyName: string, typeDefinition: string): csharp.SyntaxNode[] {
//     var outList: csharp.SyntaxNode[] = [];
//     var attrTypeHandler: typeParser.TypeHandler = new typeParser.TypeHandler();
//     attrTypeHandler.onLiteral = (value, jsType) => {
//         switch (jsType) {
//             case "string":
//                 outList.push(createStringLiteralProperty(componentClass, propertyName, value));
//                 break;
//         }
//     }
//     attrTypeHandler.onType = (jsType: string) => {
//         switch (jsType) {
//             case "boolean":
//                 outList.push(createBoolSetValueProperty(componentClass, propertyName));
//                 outList.push(createBoolSetTrueProperty(componentClass, propertyName));
//                 outList.push(createBoolSetConstProperty(componentClass, propertyName));
//                 break;
//             case "string":
//                 outList.push(createStringProperty(componentClass, propertyName));
//                 outList.push(createStringConstProperty(componentClass, propertyName));
//                 break;
//             case "number":
//                 outList.push(createIntProperty(componentClass, propertyName));
//                 outList.push(createDecimalProperty(componentClass, propertyName));
//                 break;
//         }
//     }

//     attrTypeHandler.onArray = (itemType: string) => {
//         outList.push(createListProperty(componentClass, propertyName, csharp.createTypeReference(itemType)))
//     }

//     attrTypeHandler.onFunction = (fnText: string) => {
//         if (fnText == "(value: number) => string") {
//             outList.push(createFormatterFunctionProperty(componentClass, propertyName));
//             outList.push(createSelfDefiningFormatterFunctionProperty(componentClass, propertyName));
//             return;
//         }

//         if (fnText == '(option: SlOption, index: number) => TemplateResult | string | HTMLElement') {

//         }

//         throw `Function type ${fnText} not supported`;
//     }

//     typeParser.handleTypeDefinition(typeDefinition, attrTypeHandler);

//     return outList;
// }

// export function createStringLiteralProperty(controlType: csharp.TypeDefinition, propertyName: string, value: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     return csharp.methodDefinitionNode(
//         "Set" + toCSharpValidName(propertyName) + toCSharpValidName(value),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(value))));
//         });
// }

// export function createBoolSetValueProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     return csharp.methodDefinitionNode(
//         "Set" + toCSharpValidName(propertyName),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemBoolType())));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.identifierNode(propertyName)));
//         });
// }

// export function createBoolSetTrueProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     methodName,
//                     csharp.functionCallNode("b", "Const", csharp.trueLiteralNode())));
//         });
// }

// export function createBoolSetConstProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemBoolType()));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     methodName,
//                     csharp.functionCallNode("b", "Const", csharp.identifierNode(propertyName))));
//         });
// }

// export function createStringProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemStringType())));

//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.identifierNode(propertyName)));
//         });
// }

// export function createIntProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);
//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemIntType())));

//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.identifierNode(propertyName)));
//         });
// }

// export function createDecimalProperty(controlType: csharp.TypeReference, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);
//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getSystemDecimalType())));

//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.identifierNode(propertyName)));
//         });
// }

// export function createListProperty(controlType: csharp.TypeDefinition, propertyName: string, itemType: csharp.TypeReference): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);
//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getVarType(csharp.getListType(itemType))));

//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.identifierNode(propertyName)));
//         });
// }

// export function createStringConstProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemStringType()));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     methodName,
//                     csharp.functionCallNode("b", "Const", csharp.identifierNode(propertyName))));
//         });
// }

// export function createFormatterFunctionProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getVarType(getSystemFunc(csharp.getSystemDecimalType(), csharp.getSystemStringType()))));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetProperty",
//                     csharp.identifierNode("b.Props"),
//                     csharp.functionCallNode("b", "Const", csharp.stringLiteralNode(propertyName)),
//                     csharp.identifierNode(propertyName)));
//         });
// }

// export function createSelfDefiningFormatterFunctionProperty(controlType: csharp.TypeDefinition, propertyName: string): csharp.SyntaxNode {
//     var genericControlType = new csharp.TypeParameter("T");
//     genericControlType.typeConstraints.push(controlType.name);

//     var methodName = "Set" + toCSharpValidName(propertyName);
//     return csharp.methodDefinitionNode(
//         methodName,
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(genericControlType);
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(genericControlType)));

//             b.parameters.push(new csharp.Parameter(propertyName, getSystemFunc(getSyntaxBuilderType(), getVarType(csharp.getSystemDecimalType()), getVarType(csharp.getSystemStringType()))));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     methodName,
//                     csharp.functionCallNode("b", "Def", csharp.identifierNode(propertyName))));
//         });
// }

// function getTModelTypeParameter() {
//     return new csharp.TypeParameter("TModel");
// }

// function getTComponentTypeParameter(componentClassName: string) {
//     var tComponentGenericType = new csharp.TypeParameter("TComponent");
//     tComponentGenericType.typeConstraints.push(componentClassName);
//     return tComponentGenericType;
// }

// function createBaseHyperappActionHandler(componentClass: string, eventName: string, fill: (md: csharp.MethodDefinition) => void) {

//     return csharp.methodDefinitionNode(
//         "On" + toCSharpValidName(eventName),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.typeParameters.push(getTComponentTypeParameter(componentClass));
//             b.typeParameters.push(getTModelTypeParameter());
//             b.parameters.push(getPropsBuilderParameter(new csharp.TypeReference(getTComponentTypeParameter(componentClass))));
//             fill(b);
//         });
// }

// function getHtmlEventType() {
//     return new csharp.TypeReference({ name: "Event", namespace: "Metapsi.Html" });
// }

// function getHypertypeAction(...typeArguments: csharp.TypeReference[]) {
//     return csharp.getGenericType(
//         csharp.createTypeReference("HyperType.Action", "Metapsi.Hyperapp"),
//         typeArguments);
// }

// function getSystemFunc(...typeArguments: csharp.TypeReference[]) {
//     return csharp.getGenericType(
//         csharp.createTypeReference("Func", "System"),
//         typeArguments);
// }

// function getSyntaxBuilderType() {
//     return csharp.createTypeReference("SyntaxBuilder", "Metapsi.Syntax");
// }

// export function createEventHandlers(componentClass: string, eventName: string): csharp.SyntaxNode[] {
//     var outList: csharp.SyntaxNode[] = [];

//     // Var<HyperType.Action<TModel,Event>>
//     outList.push(createBaseHyperappActionHandler(componentClass, eventName,
//         b => {
//             b.parameters.push(
//                 new csharp.Parameter("action", getVarType(getHypertypeAction(csharp.createTypeReference("TModel"), getHtmlEventType()))));
//             b.body.push(csharp.functionCallNode(
//                 "b",
//                 "OnEventAction",
//                 csharp.stringLiteralNode("on" + eventName),
//                 csharp.identifierNode("action")
//             ))
//         }
//     ));

//     // Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>>
//     outList.push(createBaseHyperappActionHandler(componentClass, eventName,
//         b => {
//             b.parameters.push(new csharp.Parameter(
//                 "action",
//                 getSystemFunc(
//                     getSyntaxBuilderType(),
//                     getVarType(new csharp.TypeReference(getTModelTypeParameter())),
//                     getVarType(getHtmlEventType()),
//                     getVarType(new csharp.TypeReference(getTModelTypeParameter())))));
//             b.body.push(csharp.functionCallNode(
//                 "b",
//                 b.name, // call same function with client-side action
//                 csharp.functionCallNode(
//                     "b",
//                     "MakeAction",
//                     csharp.identifierNode("action"))));
//         }
//     ));

//     // Ignore event
//     // Var<HyperType.Action<TModel>>
//     outList.push(createBaseHyperappActionHandler(componentClass, eventName,
//         b => {
//             b.parameters.push(
//                 new csharp.Parameter("action", getVarType(getHypertypeAction(csharp.createTypeReference("TModel")))));
//             b.body.push(csharp.functionCallNode(
//                 "b",
//                 "OnEventAction",
//                 csharp.stringLiteralNode("on" + eventName),
//                 csharp.identifierNode("action")
//             ))
//         }
//     ));

//     // Ignore event
//     // Func<SyntaxBuilder, Var<TModel>, Var<TModel>>
//     outList.push(createBaseHyperappActionHandler(componentClass, eventName,
//         b => {
//             b.parameters.push(new csharp.Parameter(
//                 "action",
//                 getSystemFunc(
//                     getSyntaxBuilderType(),
//                     getVarType(new csharp.TypeReference(getTModelTypeParameter())),
//                     getVarType(new csharp.TypeReference(getTModelTypeParameter())))));
//             b.body.push(csharp.functionCallNode(
//                 "b",
//                 b.name, // call same function with client-side action
//                 csharp.functionCallNode(
//                     "b",
//                     "MakeAction",
//                     csharp.identifierNode("action"))));
//         }
//     ));

//     return outList;
// }
