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
                            var fileStructure = cswc.createWebComponentStructure(d.name, "Metapsi.Shoelace");
                            for (var node of nodes) {
                                cswc.addWebComponentNode(fileStructure, node);
                            }
                            var file = cswc.getWebComponentFile(fileStructure);
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
                    node: csharp.methodDefinitionNode(ssr.createActionParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"))
                },
                {
                    kind: "ssrConstructor",
                    node: csharp.methodDefinitionNode(ssr.createParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"))
                },
                {
                    kind: "ssrConstructor",
                    node: csharp.methodDefinitionNode(ssr.createActionListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"))
                },
                {
                    kind: "ssrConstructor",
                    node: csharp.methodDefinitionNode(ssr.createListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"))
                },
                {
                    kind: "csrConstructor",
                    node: csharp.methodDefinitionNode(csr.createActionParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"))
                },
                {
                    kind: "csrConstructor",
                    node: csharp.methodDefinitionNode(csr.createParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"))
                },
                {
                    kind: "csrConstructor",
                    node: csharp.methodDefinitionNode(csr.createActionListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"))
                },
                {
                    kind: "csrConstructor",
                    node: csharp.methodDefinitionNode(csr.createListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"))
                }
            ]
        case "attribute": return CreateShoelaceAttributeSetters(customElementName, inputEntity)
        case "method": return [{
            kind: "methodConstant",
            node: cswc.createMethodNameConstant(inputEntity.name)
        }]
        case "property": return []
        case "event": return []
        case "slot": return [{
            kind: "slotConstant",
            node: cswc.createSlotNameConstant(inputEntity.name)
        }]
        default:
            const check: never = inputEntity;
            return []
    }
}


// export function GetDefaultDefinitionNavigator(): WebComponentDefinitionNavigator<schema.CustomElement> {
//     return {
//         getElement: (def: schema.CustomElement) => def,
//         getSlots: (def: schema.CustomElement) => def.slots!,
//         getMethods: (def: schema.CustomElement) => def.members?.filter(x => x.kind == "method")!,
//         getAttributes: (def: schema.CustomElement) => def.members?.filter(x => x.kind == "field" && x.description && (x as any).attribute)!,
//         getProperties: (def: schema.CustomElement): schema.ClassField[] => def.members?.filter(x => x.kind == "field").filter(x => x.description)!,
//         getEvents: (def: schema.CustomElement) => def.events?.filter(x => !x.deprecated)!
//     }
// }


// var file = cswc.CreateWebComponentFile(dec, createShoelaceConverter(), "Metapsi.Shoelace");
// var controlName = dec.name;
// var slFilePath = path.join(outFolder, controlName + ".cs");
// // var csharpDefinition = cswc.fromManifest(
// //     dec,
// //     "Metapsi.Shoelace",
// //     cswc.GetDefaultWebComponentConverter({
// //         ssrConstructorName: "SlTag",
// //         csrConstructorName: "SlNode"
// //     }));
// var csharpFileString = csharpFile.fileToCSharp(file);
// //await fs.writeFile(slFilePath, csharpFileString, 'utf-8');
// console.log(slFilePath);
// console.log(csharpFileString);

function createShoelaceProperty(classType: csharp.TypeReference, property: customElementManifestSchema.ClassField): csharp.MethodDefinition[] {
    var outNodes: csharp.MethodDefinition[] = [];
    if (property.default == "Infinity") {
        outNodes.push(csr.createValuePropertySetter(classType.name, property.name, sysTypes.systemDecimal));
        return outNodes;
    }
    // if (classType.name == "SlAlert") {
    //     if (property.name == "duration") {

    //     }
    // }

    var types = typeParser.getConstituentTypes(property.type!.text);
    for (var type of types) {
        //outNodes.push(...CreateShoelaceAttributes(type, classType, property))
    }
    return outNodes;
}

function CreateShoelaceAttributeSetters(customElementName: string, attribute: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
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
    return outNodes.map(x => ({ kind: "attributeSetter", node: csharp.methodDefinitionNode(x) }));
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
