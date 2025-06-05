/*
This handles conversion of web component schema to C# types 
It specifies the way component schema is navigated and the output C# file structure.
The creation of the actual nodes is delegated to (possibly custom) implementations through WebComponentConverter
*/

import * as csharp from './CSharpContracts.js';
import * as schema from 'custom-elements-manifest';
import * as csharpFile from './CSharpOutput.js'
import * as sysTypes from './CSharpSystemTypes.js'

export const metapsiHtmlNamespace: string = "Metapsi.Html";

export type WebComponentInputEntity =
    | { kind: "customElement", name: string, tag: string, description: string }
    | { kind: "slot", name: string, description: string }
    | { kind: "method", name: string, description: string }
    | { kind: "attribute", name: string, description: string, type: string }
    | { kind: "property", name: string, description: string, type: string }
    | { kind: "event", name: string, description: string, customDetailType: string }

// type WebComponentDefinition = {
//     element: schema.CustomElement;
//     slots: schema.Slot[];
//     methods: schema.ClassMethod[];
//     attributes: schema.Attribute[];
//     properties: schema.ClassField[];
//     events: schema.Event[]
// }
export type WebComponentNode =
    { kind: "ssrConstructor", node: csharp.MethodDefinition, comment: string } |
    { kind: "csrConstructor", node: csharp.MethodDefinition, comment: string } |
    { kind: "slotConstant", node: csharp.ConstantDefinition, comment: string } |
    { kind: "methodConstant", node: csharp.ConstantDefinition, comment: string } |
    { kind: "attributeSetter", node: csharp.MethodDefinition, comment: string } |
    { kind: "propertySetter", node: csharp.MethodDefinition, comment: string } |
    { kind: "event", node: csharp.MethodDefinition, comment: string } |
    { kind: "classMember", node: csharp.PropertyDefinition, comment: string }

export class WebComponentFileStructure {
    members: csharp.SyntaxNode[] = []
    slots: csharp.SyntaxNode[] = []
    methods: csharp.SyntaxNode[] = []
    ssrConstructors: csharp.SyntaxNode[] = []
    attributeSetters: csharp.SyntaxNode[] = []
    csrConstructors: csharp.SyntaxNode[] = []
    propertySetters: csharp.SyntaxNode[] = []
    events: csharp.SyntaxNode[] = []
}

export function addWebComponentNode(fs: WebComponentFileStructure, entity: WebComponentNode): void {
    switch (entity.kind) {
        case "ssrConstructor":
            fs.ssrConstructors.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.ssrConstructors.push(csharp.methodDefinitionNode(entity.node));
            fs.ssrConstructors.push(csharp.newLineNode());
            break;
        case "csrConstructor":
            fs.csrConstructors.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.csrConstructors.push(csharp.methodDefinitionNode(entity.node));
            fs.csrConstructors.push(csharp.newLineNode());
            break;
        case "slotConstant":
            fs.slots.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.slots.push(csharp.constantNode(entity.node));
            break;
        case "methodConstant":
            fs.methods.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.methods.push(csharp.constantNode(entity.node));
            break;
        case "attributeSetter":
            fs.attributeSetters.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.attributeSetters.push(csharp.methodDefinitionNode(entity.node));
            fs.attributeSetters.push(csharp.newLineNode());
            break;
        case "propertySetter":
            fs.propertySetters.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.propertySetters.push(csharp.methodDefinitionNode(entity.node));
            fs.propertySetters.push(csharp.newLineNode());
            break;
        case "event":
            fs.events.push(csharp.commentNode(escapeComment(entity.comment)));
            fs.events.push(csharp.methodDefinitionNode(entity.node));
            fs.events.push(csharp.newLineNode());
            break;
        case "classMember":
            //fs.members.push(csharp.commentNode(escapeComment(entity.comment)));
            //fs.members.push( entity.node);
            break;
        default:
            const c: never = entity;
    }
}

export function getWebComponentFile(
    fs: WebComponentFileStructure,
    customElementName: string,
    namespace: string,
    componentComment: string): csharpFile.File {

    var outFile = new csharpFile.File();

    outFile.usings.push("Metapsi.Html");
    outFile.usings.push("Metapsi.Syntax");
    outFile.usings.push("Metapsi.Hyperapp");
    outFile.namespace = namespace;

    var slotsClass: csharp.TypeDefinition = {
        name: "Slot",
        isStatic: true,
        body: fs.slots
    }
    var methodsClass: csharp.TypeDefinition = {
        name: "Method",
        isStatic: true,
        body: fs.methods
    }
    var componentClass: csharp.TypeDefinition = {
        name: customElementName,
        isPartial: true,
        body: [
            csharp.commentNode(``),
            { nodeType: csharp.NodeType.TypeDefinition, definition: slotsClass },
            csharp.commentNode(``),
            { nodeType: csharp.NodeType.TypeDefinition, definition: methodsClass }
        ]
    }
    var extensionsClass: csharp.TypeDefinition = {
        name: customElementName + "Control",
        isStatic: true,
        isPartial: true,
        body: [
            ...fs.ssrConstructors,
            ...fs.attributeSetters,
            ...fs.csrConstructors,
            ...fs.propertySetters,
            ...fs.events
        ]
    }

    outFile.content.push(csharp.commentNode(escapeComment(componentComment)));
    outFile.content.push({ nodeType: csharp.NodeType.TypeDefinition, definition: componentClass });
    outFile.content.push(csharp.commentNode(`Setter extensions of ${customElementName}`));
    outFile.content.push({ nodeType: csharp.NodeType.TypeDefinition, definition: extensionsClass });
    return outFile;
}

export function toCSharpValidName(name: string): string {
    if (!name)
        return "";
    return name.split(/[\/-]/).map(x => capitalize(x)).join("");
}

const reservedKeywords = ["checked", "event", "readonly", "fixed"];

export function toCSharpValidParameterName(name: string): string {
    var csharpValidName = toCSharpValidName(name);
    var name = csharpValidName[0].toLowerCase() + csharpValidName.substring(1);
    if (reservedKeywords.includes(name))
        name = "@" + name;
    return name;
}

export function capitalize(s: string): string {
    if (!s) return "";
    return s.charAt(0).toUpperCase() + s.slice(1);
}

function escapeComment(str: string | undefined) {
    if (!str) return "";
    return str.replaceAll(/</g, '&lt;').replaceAll(/>/g, '&gt;').replaceAll('\r', "").replaceAll('\n', " ");
}


export function createSlotNameConstant(slotName: string): csharp.ConstantDefinition {
    return {
        name: toCSharpValidName(slotName),
        type: sysTypes.systemString,
        value: csharp.stringLiteral(slotName),
        visibility: "public"
    }
}

export function createMethodNameConstant(methodName: string): csharp.ConstantDefinition {
    return {
        name: toCSharpValidName(methodName),
        type: sysTypes.systemString,
        value: csharp.stringLiteral(methodName),
        visibility: "public"
    }
}


export function SetterFnName(propertyName: string, toLiteralValue?: string): string {
    if (toLiteralValue) {
        return "Set" + toCSharpValidName(propertyName) + toCSharpValidName(toLiteralValue)
    }
    else return "Set" + toCSharpValidName(propertyName);
}

export function EventFnName(eventName: string): string {
    return "On" + toCSharpValidName(eventName);
}

/**
 * Equivalent of
 * public static void (this Metapsi.Html.AttributesBuilder<> b,
 * Method name not set, parameters not set, body not set
 */

// export const emptyAttributeSetter = {
//     visibility: "public",
//     isStatic: true,
//     returnType: sysTypes.systemVoid,
//     name: "",
//     parameters: [
//         {
//             isThis: true,
//             name: "b",
//             type: {
//                 name: "AttributesBuilder", namespace: metapsiHtmlNamespace,
//             }
//         }
//     ],
//     body: []
// }

// export function createEmptyAttributeSetter(controlTypeName: string): csharp.MethodDefinition {
//     return {
//         visibility: "public",
//         isStatic: true,
//         returnType: sysTypes.systemVoid,
//         name: "",
//         parameters: [
//             {
//                 isThis: true,
//                 name: "b",
//                 type: {
//                     name: "AttributesBuilder", namespace: metapsiHtmlNamespace, typeArguments: [
//                         { name: controlTypeName }
//                     ]
//                 }
//             }
//         ],
//         body: []
//     }
// }

// export function getDefaultAddAttribute(componentClass: csharp.TypeReference, m: schema.Attribute): csharp.SyntaxNode[] {
//     var outNodes: csharp.SyntaxNode[] = [];
//     var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);

//     var setters: csharp.SyntaxNode[] = [];
//     var attrTypeHandler = GetDefaultAttributeTypeHandler(componentClass, m.name, setters);
//     typeParser.handleTypeDefinition(m.type?.text!, attrTypeHandler);

//     //var setters = ssr.CreateServerSideAttributes(new csharp.TypeReference(componentClass), m.name, m.type?.text!);
//     setters.forEach(setter => {
//         outNodes.push(commentNode);
//         outNodes.push(setter);
//         outNodes.push(csharp.newLineNode());
//     });
//     return outNodes;
// }

// export function getDefaultAddProperty(componentClass: csharp.TypeDefinition, m: schema.Attribute): csharp.SyntaxNode[] {
//     var outNodes: csharp.SyntaxNode[] = [];
//     var propName = m.name;
//     if (m.type) {
//         if (m.type.text) {
//             var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);
//             var setters = csr.createClientSidePropSetters(componentClass, propName, m.type!.text!);
//             setters.forEach(setter => {
//                 outNodes.push(commentNode);
//                 outNodes.push(setter);
//                 outNodes.push(csharp.newLineNode());
//             });
//         }
//     }
//     return outNodes;
// }


// export function fromManifest(
//     manifestWebComponent: schema.CustomElement,
//     namespace: string,
//     converter: WebComponentConverter): csharp.File {
//     var outFile = new csharp.File();

//     outFile.usings.push("Metapsi.Html");
//     outFile.usings.push("Metapsi.Syntax");
//     outFile.usings.push("Metapsi.Hyperapp");
//     outFile.namespace = namespace;

//     var slotsClass = csharp.CreateType("Slot",
//         b => {
//             b.typeDef.isStatic = true;
//             manifestWebComponent.slots?.forEach(s => {
//                 b.typeDef.body.push(...converter.createSlot!(s));
//             })
//         })

//     var methodsClass = csharp.CreateType("Method",
//         b => {
//             b.typeDef.isStatic = true;
//             manifestWebComponent.members?.forEach(m => {
//                 if (m.kind == "method") {
//                     b.typeDef.body.push(...converter.createMethod!(m))
//                 }
//             })
//         });

//     var componentClass = csharp.CreateType(
//         manifestWebComponent.name,
//         b => {
//             b.typeDef.isPartial = true;
//             b.typeDef.body.push(csharp.commentNode(``));
//             b.typeDef.body.push({ nodeType: csharp.NodeType.TypeDefinition, definition: slotsClass });
//             b.typeDef.body.push(csharp.commentNode(``));
//             b.typeDef.body.push({ nodeType: csharp.NodeType.TypeDefinition, definition: methodsClass });
//         })

//     outFile.content.push(csharp.commentNode(`<para> ${escapeComment(manifestWebComponent.summary!)} </para>`));
//     outFile.content.push({ nodeType: csharp.NodeType.TypeDefinition, definition: componentClass });

//     var extensionsClass = csharp.CreateType(
//         manifestWebComponent.name + "Control",
//         b => {
//             b.typeDef.isStatic = true;
//             b.typeDef.isPartial = true;

//             b.typeDef.body.push(...converter.createSsrConstructors!(manifestWebComponent));

//             // Set attributes for server-side rendering
//             manifestWebComponent.members?.forEach(
//                 m => {
//                     if (m.kind == "field") {
//                         if (m.description) {
//                             // Only add if there is an equivalent attribute for the property
//                             var attribute = (m as any)["attribute"];
//                             if (attribute) {
//                                 b.typeDef.body.push(...converter.createAttribute!(componentClass, m as schema.Attribute));
//                             }
//                         }
//                     }
//                 })

//             b.typeDef.body.push(...converter.createCsrConstructors!(manifestWebComponent));

//             // Set properties for client-side rendering
//             manifestWebComponent.members?.forEach(
//                 m => {
//                     if (m.kind == "field") {
//                         if (m.description) {
//                             b.typeDef.body.push(...converter.createProperty!(componentClass, m))
//                         }
//                     }
//                 })
//             manifestWebComponent.events?.forEach(
//                 e => {
//                     if (!e.deprecated) {
//                         b.typeDef.body.push(...converter.createEvent!(componentClass, e));
//                     }
//                 }
//             )
//         });

//     outFile.content.push({ nodeType: csharp.NodeType.TypeDefinition, definition: extensionsClass });

//     return outFile;
// }



// export function getVarType(typeArg: csharp.TypeReference): csharp.TypeReference {
//     var varType = new csharp.TypeReference({ name: "Var", namespace: "Metapsi.Syntax" });
//     varType.typeArguments.push(typeArg);
//     return varType;
// }

// export function GetDefaultAttributeTypeHandler(componentClass: csharp.TypeReference, attribute: string, outList: csharp.SyntaxNode[]): typeParser.TypeHandler {
//     var attrTypeHandler = new typeParser.TypeHandler();
//     attrTypeHandler.onLiteral = (value, jsType) => {
//         switch (jsType) {
//             case "string":
//                 outList.push(attr.createStringLiteralAttribute(componentClass, attribute, value));
//                 break;
//         }
//     };
//     attrTypeHandler.onType = (jsType) => {
//         switch (jsType) {
//             case "boolean":
//                 outList.push(attr.createBoolSetAttribute(componentClass, attribute));
//                 outList.push(attr.createBoolValueAttribute(componentClass, attribute));
//                 break;
//             case "string":
//                 outList.push(attr.createStringAttribute(componentClass, attribute));
//                 break;
//             case "number":
//                 outList.push(attr.createStringAttribute(componentClass, attribute));
//                 break;
//         }
//     };
//     attrTypeHandler.onArray = () => {
//         // Arrays are not attributes
//         console.warn(`Attribute ${attribute} is array. Skipped`);
//     };
//     attrTypeHandler.onFunction = () => {
//         // Functions are not attributes
//         console.warn(`Attribute ${attribute} is function. Skipped`);
//     };
//     return attrTypeHandler;
// }