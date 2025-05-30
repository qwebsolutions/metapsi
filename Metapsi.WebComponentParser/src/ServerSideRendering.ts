import * as csharp from './CSharpContracts.js';
import { SetterFnName, metapsiHtmlNamespace, toCSharpValidParameterName } from './CSharpWebComponentContracts.js';
import * as sysTypes from './CSharpSystemTypes.js';
import * as typeParser from './TypeParser.js';
import * as attr from './AttributeTypeHandler.js'

const iHtmlNodeType: csharp.TypeReference = { name: "IHtmlNode", namespace: "Metapsi.Html" }
const attributesBuilderType: csharp.TypeReference = { name: "AttributesBuilder", namespace: "Metapsi.Html" }

export function createTagConstructor(controlTypeName: string, parameters: csharp.Parameter[], body: csharp.SyntaxNode[]): csharp.MethodDefinition {
    return {
        name: controlTypeName,
        returnType: iHtmlNodeType,
        isStatic: true,
        visibility: 'public',
        parameters: [
            {
                isThis: true,
                name: "b",
                type: {
                    name: "HtmlBuilder",
                    namespace: "Metapsi.Html"
                }
            },
            ...parameters
        ],
        body
    }
}

export function createActionParamsChildrenTagConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createTagConstructor(
        controlTypeName, [{
            name: "buildAttributes",
            type: {
                ...sysTypes.systemAction,
                typeArguments: [{ ...attributesBuilderType, typeArguments: [{ name: controlTypeName }] }]
            }
        }, {
            isParams: true,
            name: "children",
            type: iHtmlNodeType
        }
    ], [
        csharp.returnNode(
            csharp.functionCallNode(
                "b",
                constructorFnName,
                csharp.stringLiteralNode(tagName),
                csharp.identifierNode("buildAttributes"),
                csharp.identifierNode("children")))
    ]);
}

export function createParamsChildrenTagConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createTagConstructor(
        controlTypeName, [{
            isParams: true,
            name: "children",
            type: iHtmlNodeType
        }
    ], [
        csharp.returnNode(
            csharp.functionCallNode(
                "b",
                constructorFnName,
                csharp.stringLiteralNode(tagName),
                csharp.newKeywordNode({ ...sysTypes.systemCollectionsGenericDictionary, typeArguments: [sysTypes.systemString, sysTypes.systemString] }),
                csharp.identifierNode("children")))
    ]);
}

export function createActionListChildrenTagConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createTagConstructor(
        controlTypeName, [{
            name: "buildAttributes",
            type: {
                ...sysTypes.systemAction,
                typeArguments: [{ ...attributesBuilderType, typeArguments: [{ name: controlTypeName }] }]
            }
        }, {
            name: "children",
            type: { ...sysTypes.systemCollectionsGenericList, typeArguments: [iHtmlNodeType] }
        }
    ], [
        csharp.returnNode(
            csharp.functionCallNode(
                "b",
                constructorFnName,
                csharp.stringLiteralNode(tagName),
                csharp.identifierNode("buildAttributes"),
                csharp.identifierNode("children")))
    ]);
}


export function createListChildrenTagConstructor(controlTypeName: string, tagName: string, constructorFnName: string): csharp.MethodDefinition {
    return createTagConstructor(
        controlTypeName, [{
            name: "children",
            type: { ...sysTypes.systemCollectionsGenericList, typeArguments: [iHtmlNodeType] }
        }
    ], [
        csharp.returnNode(
            csharp.functionCallNode(
                "b",
                constructorFnName,
                csharp.stringLiteralNode(tagName),
                csharp.newKeywordNode({ ...sysTypes.systemCollectionsGenericDictionary, typeArguments: [sysTypes.systemString, sysTypes.systemString] }),                
                csharp.identifierNode("children")))
    ]);
}
export function createAttributeSetter(setterFnName: string, controlTypeName: string, attrParameters: csharp.Parameter[], body: csharp.SyntaxNode[]): csharp.MethodDefinition {
    return {
        visibility: "public",
        isStatic: true,
        returnType: sysTypes.systemVoid,
        name: setterFnName,
        parameters: [
            {
                isThis: true,
                name: "b",
                type: {
                    name: "AttributesBuilder", namespace: metapsiHtmlNamespace, typeArguments: [
                        { name: controlTypeName }
                    ]
                }
            },
            ...attrParameters
        ],
        body
    }
}

export function createBoolAttributeSetter(attributeName: string, controlTypeName: string): csharp.MethodDefinition {
    var boolParameterName = toCSharpValidParameterName(attributeName);
    return createAttributeSetter(
        SetterFnName(attributeName),
        controlTypeName,
        [{
            name: boolParameterName,
            type: sysTypes.systemBool
        }],
        [
            csharp.ifNode(
                csharp.identifierNode(boolParameterName),
                [
                    csharp.functionCallNode(
                        "b",
                        "SetAttribute",
                        csharp.stringLiteralNode('""')
                    )
                ]
            )
        ]
    )
}

export function createDefaultTrueBoolAttributeSetter(attributeName: string, controlTypeName: string): csharp.MethodDefinition {
    return createAttributeSetter(
        SetterFnName(attributeName),
        controlTypeName,
        [],
        [csharp.functionCallNode(
            "b",
            "SetAttribute",
            csharp.stringLiteralNode('""')
        )]
    )
}


// export function getHtmlBuilderType() {
//     return new csharp.TypeReference({ name: "HtmlBuilder", namespace: metapsiHtmlNamespace });
// }

// export function getHtmlBuilderParameter() {
//     var thisHtmlBuilder = new csharp.Parameter("b", getHtmlBuilderType());
//     thisHtmlBuilder.isThis = true;
//     return thisHtmlBuilder;
// }

// export function createServerSideConstructors(controlType: string, tagName: string, nodeBuilderName: string): csharp.SyntaxNode[] {
//     var methods: csharp.SyntaxNode[] = [];

//     var currentControlType = new csharp.TypeReference({ name: controlType });

//     var actionOnTypeBuilderParameter = new csharp.Parameter("buildAttributes", getActionType(attr.getAttributesBuilderType(currentControlType)));

//     var withAttrsAndParams = csharp.methodDefinitionNode(
//         controlType,
//         getIHtmlNodeType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getHtmlBuilderParameter());
//             b.parameters.push(actionOnTypeBuilderParameter);

//             var nodeParams = new csharp.Parameter("children", getIHtmlNodeType());
//             nodeParams.isParams = true;
//             b.parameters.push(nodeParams);
//             b.body.push(
//                 csharp.returnNode(
//                     csharp.functionCallNode(
//                         "b",
//                         nodeBuilderName,
//                         csharp.stringLiteralNode(tagName),
//                         csharp.identifierNode(actionOnTypeBuilderParameter.name),
//                         csharp.identifierNode(nodeParams.name))));
//         });
//     methods.push(withAttrsAndParams);

//     var withoutAttrsWithParams = csharp.methodDefinitionNode(
//         controlType,
//         getIHtmlNodeType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getHtmlBuilderParameter());
//             var nodeParams = new csharp.Parameter("children", getIHtmlNodeType());
//             nodeParams.isParams = true;
//             b.parameters.push(nodeParams);
//             b.body.push(
//                 csharp.returnNode(
//                     csharp.functionCallNode(
//                         "b",
//                         nodeBuilderName,
//                         csharp.stringLiteralNode(tagName),
//                         csharp.newKeywordNode(
//                             getDictionaryType(
//                                 csharp.getSystemStringType(),
//                                 csharp.getSystemStringType())),
//                         csharp.identifierNode(nodeParams.name))));
//         });

//     methods.push(withoutAttrsWithParams);

//     var withAttrsWithList = csharp.methodDefinitionNode(
//         controlType,
//         getIHtmlNodeType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getHtmlBuilderParameter());
//             b.parameters.push(actionOnTypeBuilderParameter);
//             var nodeParams = new csharp.Parameter("children", getListType(getIHtmlNodeType()));
//             b.parameters.push(nodeParams);
//             b.body.push(
//                 csharp.returnNode(
//                     csharp.functionCallNode(
//                         "b",
//                         nodeBuilderName,
//                         csharp.stringLiteralNode(tagName),
//                         csharp.identifierNode(actionOnTypeBuilderParameter.name),
//                         csharp.identifierNode(nodeParams.name))));
//         });

//     methods.push(withAttrsWithList);

//     var withoutAttrsWithList = csharp.methodDefinitionNode(
//         controlType,
//         getIHtmlNodeType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getHtmlBuilderParameter());
//             var nodeParams = new csharp.Parameter("children", getListType(getIHtmlNodeType()));
//             b.parameters.push(nodeParams);
//             b.body.push(
//                 csharp.returnNode(
//                     csharp.functionCallNode(
//                         "b",
//                         nodeBuilderName,
//                         csharp.stringLiteralNode(tagName),
//                         csharp.newKeywordNode(
//                             getDictionaryType(csharp.getSystemStringType(), csharp.getSystemStringType())),
//                         csharp.identifierNode(nodeParams.name))));
//         });

//     methods.push(withoutAttrsWithList);

//     return methods;
// }


// export function getIHtmlNodeType() {
//     return new csharp.TypeReference({ name: "IHtmlNode", namespace: metapsiHtmlNamespace });
// }

// export function CreateServerSideAttributes(componentClass: csharp.TypeReference, attribute: string, typeDefinition: string): csharp.SyntaxNode[] {

//     var outList: csharp.SyntaxNode[] = [];
//     var attrTypeHandler = attr.GetDefaultAttributeTypeHandler(componentClass, attribute,outList);

//     if (attribute) {
//         typeParser.handleTypeDefinition(typeDefinition, attrTypeHandler);
//     }

//     return outList;
// }