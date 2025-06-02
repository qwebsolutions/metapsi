import * as fs from "fs/promises";
import * as customElementManifestSchema from 'custom-elements-manifest';
import * as csharp from './CSharpContracts.js';
import * as csharpFile from './CSharpOutput.js'
import * as cswc from './CSharpWebComponentContracts.js';
import path from "path";
import * as typeParser from './TypeParser.js'
import * as csr from './ClientSideRendering.js'
import * as ssr from './ServerSideRendering.js'
import * as sysTypes from './CSharpSystemTypes.js'
import { text } from "stream/consumers";

export async function GenerateShoelace(version: string, outFolder: string): Promise<void> {
    var response = await fetch(`https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@${version}/dist/custom-elements.json`)
    var shoelaceManifest: customElementManifestSchema.Package = await response.json();
    for (const m of shoelaceManifest.modules) {
        for (const d of m.declarations!) {
            {
                switch (d.kind) {
                    case "class":

                        var dec = d as customElementManifestSchema.CustomElement;

                        if (dec.name == "SlButton") {
                            var inputEntities = getInputEntities(dec);
                            var nodes = inputEntities.flatMap(e => convertShoelaceEntity(dec.name, e));
                            var fileStructure = new cswc.WebComponentFileStructure();// cswc.createWebComponentStructure(d.name, "Metapsi.Shoelace");
                            for (var node of nodes) {
                                cswc.addWebComponentNode(fileStructure, node);
                            }
                            var file = cswc.getWebComponentFile(fileStructure, dec.name, "Metapsi.Shoelace");
                            var slFilePath = path.join(outFolder, dec.name + ".cs");
                            var csharpFileString = csharpFile.fileToCSharp(file);
                            //await fs.writeFile(slFilePath, csharpFileString, 'utf-8');
                            console.log(slFilePath);
                            console.log(csharpFileString);
                        }
                }
            }
        }
    }
}

function getInputEntities(def: customElementManifestSchema.CustomElement): cswc.WebComponentInputEntity[] {
    var outEntities: cswc.WebComponentInputEntity[] = [];
    outEntities.push({ kind: "customElement", name: def.name, description: def.summary ?? "", tag: def.tagName! })
    if (def.slots) {
        for (var slot of def.slots) {
            if (slot.name) {
                outEntities.push({ kind: "slot", name: slot.name, description: slot.summary ?? "" })
            }
        }
    }
    if (def.members) {
        for (var method of def.members) {
            if (method.kind == "method") {
                if (method.description && method.privacy != "private") {
                    outEntities.push({ kind: "method", name: method.name, description: method.summary ?? "" })
                }
            }
        }
    }

    if (def.attributes) {
        for (var attr of def.attributes) {
            outEntities.push({ kind: "attribute", name: attr.name, description: attr.description ?? "", type: attr.type?.text ?? "string" })
        }
    }

    if (def.members) {
        for (var member of def.members) {
            if (member.kind == "field") {
                if (member.description && member.privacy != "private") {
                    outEntities.push({ kind: "property", name: member.name, description: member.summary ?? "", type: member.type?.text ?? "string" })
                }
            }
        }
    }

    if (def.events) {
        for (var event of def.events) {
            if (event.description) {
                if (!event.deprecated) {
                    outEntities.push({ kind: "event", name: event.name, description: event.description ?? "", customDetailType: event.type?.text ?? "" })
                }
            }
        }
    }

    return outEntities;
}

/**
 * From one input entity to multiple nodes
 * @param inputEntity 
 * @returns 
 */
export function convertShoelaceEntity(customElementName: string, inputEntity: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
    switch (inputEntity.kind) {
        case "customElement":
            return [
                {
                    kind: "ssrConstructor",
                    node: ssr.createActionParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag")
                },
                {
                    kind: "ssrConstructor",
                    node: ssr.createParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag")
                },
                {
                    kind: "ssrConstructor",
                    node: ssr.createActionListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag")
                },
                {
                    kind: "ssrConstructor",
                    node: ssr.createListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag")
                },
                {
                    kind: "csrConstructor",
                    node: csr.createActionParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode")
                },
                {
                    kind: "csrConstructor",
                    node: csr.createParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode")
                },
                {
                    kind: "csrConstructor",
                    node: csr.createActionListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode")
                },
                {
                    kind: "csrConstructor",
                    node: csr.createListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode")
                }
            ]
        case "attribute": return createShoelaceAttributeSetters(customElementName, inputEntity)
        case "method": return [{
            kind: "methodConstant",
            node: cswc.createMethodNameConstant(inputEntity.name)
        }]
        case "property": return createShoelacePropertySetters(customElementName, inputEntity)
        case "event": return createShoelaceEventSetters(customElementName, inputEntity);
        case "slot": return [{
            kind: "slotConstant",
            node: cswc.createSlotNameConstant(inputEntity.name)
        }]
        default:
            const check: never = inputEntity;
            return []
    }
}

function createShoelacePropertySetters(customElementName: string, property: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
    var propertySetters: csharp.MethodDefinition[] = [];

    if (property.kind == "property") {
        if (property.type == "boolean") {
            propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemBool));
        }

        if (property.type == "string") {
            propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemString));
        }

        if (property.type.includes("|")) {
            var types = typeParser.getConstituentTypes(property.type);
            for (var type of types) {
                if (type.kind == "literal") {
                    if (type.type == "string") {
                        propertySetters.push(ssr.createStringLiteralAttributeSetter(property.name, customElementName, type.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (type.kind == "type") {
                        if (type.type == "string") {
                            propertySetters.push(ssr.createStringValueAttributeSetter(property.name, customElementName))
                        }
                        else throw new Error(`Unsupported type in ${property.type}`)
                    }
                    else throw new Error(`Unsupported type in ${property.type}`)
                }
            }
        }
        if (!propertySetters.length)
            throw new Error(`Type ${property.type} unsupported in ${customElementName}.${property.name}`)
    }

    return propertySetters.map(x => ({ kind: "propertySetter", node: x }));
}

function createShoelaceAttributeSetters(customElementName: string, attribute: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
    var outNodes: csharp.MethodDefinition[] = [];
    if (attribute.kind == "attribute") {
        if (customElementName == "SlAlert") {
            if (attribute.name == "duration") {
                //outNodes.push(ssr.(classType,property.name));
            }
        }

        if (attribute.type == "boolean") {
            outNodes.push(ssr.createBoolAttributeSetter(attribute.name, customElementName));
            outNodes.push(ssr.createDefaultTrueBoolAttributeSetter(attribute.name, customElementName));
        }

        if (attribute.type == "string") {
            outNodes.push(ssr.createStringValueAttributeSetter(attribute.name, customElementName))
        }

        if (attribute.type.includes("|")) {
            var types = typeParser.getConstituentTypes(attribute.type);
            for (var type of types) {
                if (type.kind == "literal") {
                    if (type.type == "string") {
                        outNodes.push(ssr.createStringLiteralAttributeSetter(attribute.name, customElementName, type.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (type.kind == "type") {
                        if (type.type == "string") {
                            outNodes.push(ssr.createStringValueAttributeSetter(attribute.name, customElementName))
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                    else throw new Error(`Unsupported type in ${attribute.type}`)
                }
            }
        }
    }
    return outNodes.map(x => ({ kind: "attributeSetter", node: x }));
}

function createShoelaceEventSetters(customElementName: string, event: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
    var outNodes: csharp.MethodDefinition[] = [];
    if (event.kind == "event") {
        outNodes.push(csr.createVarActionEventEventSetter(customElementName, event.name));
        outNodes.push(csr.CreateFuncSyntaxBuilderEventEventSetter(customElementName, event.name));

        outNodes.push(csr.createVarActionEventSetter(customElementName, event.name));
        outNodes.push(csr.CreateFuncSyntaxBuilderEventSetter(customElementName, event.name));
    }
    if (!outNodes.length) {
        throw new Error(`${customElementName}.${event.name} not implemented`)
    }
    return outNodes.map(x => ({ kind: "event", node: x }));
}

// function createShoelaceConverter(): cswc.WebComponentConverter {
//     return {
//         onCustomElement: (c) => [

//         ],
//         createSsrConstructors: (c) => [

//         ],// ssr.createServerSideConstructors(c.name, c.tagName!, "SlTag"),
//         createCsrConstructors: (c) => [], // csr.createClientSideConstructors(c.name, c.tagName!, "SlNode"),
//         onSlot: cswc.createSlotNameConstant,
//         onMethod: cswc.createMethodNameConstant,
//         onAttribute: (classType, attribute) => {
//             var outNodes: csharp.SyntaxNode[] = [];
//             // var types = typeParser.getConstituentTypes(attribute.type!.text);
//             // for (var type of types) {
//             //     outNodes.push(...CreateShoelaceAttributes(type, classType, attribute))
//             // }
//             return outNodes;
//         },
//         onProperty: (c: csharp.TypeReference, p: customElementManifestSchema.ClassField): csharp.SyntaxNode[] => {
//             var methodDefinitions: csharp.MethodDefinition[] = createShoelaceProperty(c, p);
//             return methodDefinitions.map(x => ({ nodeType: csharp.NodeType.MethodDefinition, method: x }))
//         },
//         // createProperty: (classType, property) => {
//         //     var outNodes: csharp.SyntaxNode[] = [];
//         //     var types = typeParser.getConstituentTypes(property.type!.text);
//         //     for (var type of types) {
//         //         outNodes.push(...CreateShoelaceAttributes(type, classType, property))
//         //     }
//         //     return outNodes;
//         // },
//         onEvent: () => []
//     }
// }

// async function LoadIonic() {
//     const docs = await import('@ionic/core/dist/docs.json', { assert: { type: 'json' } });
//     console.log(docs.default);
// }
