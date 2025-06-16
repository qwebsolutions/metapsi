import { TypeHandler } from "./TypeParser.js";
import * as typeHandler from './TypeParser.js'
import * as csharp from './CSharpContracts.js'
import { toCSharpValidName, toCSharpValidParameterName, metapsiHtmlNamespace } from "./CSharpWebComponentContracts.js";


// export function getAttributesBuilderType(controlType: csharp.TypeReference) {
//     var attributesBuilderType = new csharp.TypeReference({ name: "AttributesBuilder", namespace: metapsiHtmlNamespace });
//     attributesBuilderType.typeArguments.push(controlType);
//     return attributesBuilderType;
// }

// export function getAttributesBuilderParameter(controlType: csharp.TypeReference) {
//     var parameter = new csharp.Parameter("b", getAttributesBuilderType(controlType));
//     parameter.isThis = true;
//     return parameter;
// }

// export function GetDefaultAttributeTypeHandler(componentClass: csharp.TypeReference, attribute: string, outList: csharp.SyntaxNode[]): TypeHandler {
//     var attrTypeHandler: TypeHandler = new TypeHandler();
//     attrTypeHandler.onLiteral = (value, jsType) => {
//         switch (jsType) {
//             case "string":
//                 outList.push(createStringLiteralAttribute(componentClass, attribute, value));
//                 break;
//         }
//     }

//     attrTypeHandler.onType = (jsType) => {
//         switch (jsType) {
//             case "boolean":
//                 outList.push(createBoolSetAttribute(componentClass, attribute));
//                 outList.push(createBoolValueAttribute(componentClass, attribute));
//                 break;
//             case "string":
//                 outList.push(createStringAttribute(componentClass, attribute));
//                 break;
//             case "number":
//                 outList.push(createStringAttribute(componentClass, attribute));
//                 break;
//         }
//     }

//     attrTypeHandler.onArray = () => {
//         // Arrays are not attributes
//         console.warn(`Attribute ${attribute} is array. Skipped`)
//     };

//     attrTypeHandler.onFunction = () => {
//         // Functions are not attributes
//         console.warn(`Attribute ${attribute} is function. Skipped`)
//     };

//     return attrTypeHandler;
// }


// export function createStringLiteralAttribute(controlType: csharp.TypeReference, attribute: string, value: string): csharp.SyntaxNode {

//     return csharp.methodDefinitionNode(
//         "Set" + toCSharpValidName(attribute) + toCSharpValidName(value),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getAttributesBuilderParameter(controlType));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetAttribute",
//                     csharp.stringLiteralNode(attribute),
//                     csharp.stringLiteralNode(value)));
//         });
// }

// /**
//  * if (attr) b.SetAttribute("attr", "");
//  * @param controlType 
//  * @param propertyName 
//  * @returns 
//  */
// export function createBoolValueAttribute(controlType: csharp.TypeReference, attribute: string): csharp.SyntaxNode {

//     var propertyName = toCSharpValidParameterName(attribute);

//     return csharp.methodDefinitionNode(
//         "Set" + toCSharpValidName(attribute),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getAttributesBuilderParameter(controlType));
//             b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemBoolType()));
//             b.body.push(
//                 csharp.ifNode(
//                     csharp.identifierNode(propertyName),
//                     b => {
//                         b.push(csharp.functionCallNode(
//                             "b",
//                             "SetAttribute",
//                             csharp.stringLiteralNode(attribute),
//                             csharp.stringLiteralNode("")));
//                     }));
//         });
// }

// /**
//  * b.SetAttribute("attributeName", "");
//  * @param controlType 
//  * @param propertyName 
//  * @returns 
//  */
// export function createBoolSetAttribute(controlType: csharp.TypeReference, attribute: string): csharp.SyntaxNode {

//     var propertyName = toCSharpValidParameterName(attribute);

//     return csharp.methodDefinitionNode(
//         "Set" + toCSharpValidName(attribute),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getAttributesBuilderParameter(controlType));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetAttribute",
//                     csharp.stringLiteralNode(attribute),
//                     csharp.stringLiteralNode("")));
//         });
// }

// /**
//  * b.SetAttribute("attr", attr);
//  * @param controlType 
//  * @param propertyName 
//  * @returns 
//  */
// export function createStringAttribute(controlType: csharp.TypeReference, attribute: string): csharp.SyntaxNode {

//     var propertyName = toCSharpValidParameterName(attribute);

//     return csharp.methodDefinitionNode(
//         "Set" + toCSharpValidName(attribute),
//         csharp.getVoidType(),
//         b => {
//             b.isStatic = true;
//             b.parameters.push(getAttributesBuilderParameter(controlType));
//             b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemStringType()));
//             b.body.push(
//                 csharp.functionCallNode(
//                     "b",
//                     "SetAttribute",
//                     csharp.stringLiteralNode(attribute),
//                     csharp.identifierNode(propertyName)));
//         });
// }