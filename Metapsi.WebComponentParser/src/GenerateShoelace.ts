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
                        if (dec.name != "SlPopup") {

                            var inputEntities = getInputEntities(dec);
                            var nodes = inputEntities.flatMap(e => convertShoelaceEntity(dec.name, e));
                            var fileStructure = new cswc.WebComponentFileStructure();// cswc.createWebComponentStructure(d.name, "Metapsi.Shoelace");
                            for (var node of nodes) {
                                cswc.addWebComponentNode(fileStructure, node);
                            }
                            var file = cswc.getWebComponentFile(fileStructure, dec.name, "Metapsi.Shoelace");
                            var slFilePath = path.join(outFolder, dec.name + ".cs");
                            console.log(`Generating ${slFilePath} ...`);
                            var csharpFileString = csharpFile.fileToCSharp(file);
                            await fs.writeFile(slFilePath, csharpFileString, 'utf-8');
                            console.log(`done`);
                            //console.log(csharpFileString);
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
                    outEntities.push({ kind: "property", name: member.name, description: member.description ?? "", type: member.type?.text ?? "string" })
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
    if(customElementName.includes("Checkbox")){
        console.log(customElementName);
    }
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

// only handle number explicitly, so we output int/decimal as preffered
function createExplicitTypes(customElementName: string, property: cswc.WebComponentInputEntity): csharp.MethodDefinition[] {
    var propertySetters: csharp.MethodDefinition[] = [];
    if (property.kind == "property") {
        if (customElementName == "SlAnimation") {
            if (property.type == "number") {
                if (["delay", "duration", "endDelay", "iterations"].includes(property.name)) {
                    propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                    propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                }
                if (["iterationStart", "playbackRate"].includes(property.name)) {
                    propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                    propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                }
            }
            if (property.name == "keyframes") {
                propertySetters.push(
                    csr.createValuePropertySetter(
                        customElementName,
                        property.name,
                        {
                            ...csr.varType, typeArguments: [{
                                ...sysTypes.systemCollectionsGenericList, typeArguments: [{
                                    name: "Keyframe", namespace: "Metapsi.Html"
                                }]
                            }]
                        }));
            }

            if (property.name == "currentTime" && property.type == "CSSNumberish") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
        }

        if (customElementName == "SlCarousel") {
            if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }
        if (customElementName == "SlCopyButton") {
            if (property.name == "feedbackDuration") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }

        if (customElementName == "SlDropdown") {
            if (property.name == "containingElement" && property.type == 'HTMLElement | undefined') {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, { ...csr.varType, typeArguments: [{ name: "HTMLElement", namespace: "Metapsi.Html" }] }));
            }
            if (property.type == "number") {
                if (property.name == "distance" || property.name == "skidding") {
                    propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                }
            }
        }

        if (customElementName == "SlFormatBytes") {
            if (property.name == "value") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }

        if (customElementName == "SlFormatNumber") {
            if (property.name == "value") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
            else if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }

        if (customElementName == "SlImageComparer") {
            if (property.name == "position") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }
        if (customElementName == "SlInput") {
            if (property.name == "minlength" || property.name == "maxlength") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
            if (property.name == "min" || property.name == "max") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemString));
            }

            if (property.name == "step" && property.type == "number | 'any'") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createLiteralPropertySetter(customElementName, property.name, "any"));
            }
        }
        if (customElementName == "SlProgressBar") {
            if (property.name == "value" && property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
        }

        if (customElementName == "SlProgressRing") {
            if (property.name == "value" && property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
        }

        if (customElementName == "SlQrCode") {
            if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
        }

        if (customElementName == "SlRange") {
            if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
            if (property.name == "tooltipFormatter" && property.type == "(value: number) => string") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, {
                    ...csr.varType,
                    typeArguments: [{
                        ...sysTypes.systemFunc, typeArguments: [sysTypes.systemDecimal, sysTypes.systemString]
                    }]
                }));
            }
        }

        if (customElementName == "SlRating") {
            if (property.name == "precision") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
            if (property.name == "value" || property.name == "max") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }

            if (property.name == "getSymbol") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, {
                    ...csr.varType,
                    typeArguments: [{
                        ...sysTypes.systemFunc, typeArguments: [sysTypes.systemDecimal, sysTypes.systemString]
                    }]
                }));
            }
        }

        if (customElementName == "SlSelect") {
            if (property.name == "maxOptionsVisible") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
            if (property.name == "getTag" && property.type == "(option: SlOption, index: number) => TemplateResult | string | HTMLElement") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, {
                    ...csr.varType,
                    typeArguments: [{
                        ...sysTypes.systemFunc, typeArguments: [
                            { name: "SlOption", namespace: "Metapsi.Shoelace" },
                            sysTypes.systemInt,
                            sysTypes.systemString
                        ]
                    }]
                }));

                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, {
                    ...csr.varType,
                    typeArguments: [{
                        ...sysTypes.systemFunc, typeArguments: [
                            { name: "SlOption", namespace: "Metapsi.Shoelace" },
                            sysTypes.systemInt,
                            { name: "HTMLElement", namespace: "Metapsi.Html" }
                        ]
                    }]
                }));
            }
        }

        if (customElementName == "SlSplitPanel") {
            if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }

            if (property.name == "snap") {
                //TODO:  No support for SnapFunction yet
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }

        if (customElementName == 'SlTextarea') {
            if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemInt));
            }
        }

        if (customElementName == "SlTooltip") {
            if (property.type == "number") {
                propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
                propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemDecimal));
            }
        }
    }
    return propertySetters;
}

function createShoelacePropertySetters(customElementName: string, property: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
    var propertySetters: csharp.MethodDefinition[] = [];

    if (property.kind == "property") {
        var explicit = createExplicitTypes(customElementName, property);
        if (explicit.length) {
            propertySetters.push(...explicit);
        } else if (property.type == "boolean") {
            propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemBool));
            propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemBool));
        } else if (property.type == "string") {
            propertySetters.push(csr.createValuePropertySetter(customElementName, property.name, sysTypes.systemString));
            propertySetters.push(csr.createConstRedirectValuePropertySetter(customElementName, property.name, sysTypes.systemString));
        } else if (property.type.includes("|")) {
            var types = typeParser.getConstituentTypes(property.type);
            for (var constituentType of types) {
                if (constituentType.kind == "literal") {
                    if (constituentType.type == "string") {
                        propertySetters.push(csr.createLiteralPropertySetter(customElementName,property.name, constituentType.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (constituentType.kind == "type") {
                        if (constituentType.type == "string") {
                            propertySetters.push(csr.createValuePropertySetter(customElementName,property.name, sysTypes.systemString))
                        }
                        else if (constituentType.type == "Date") {
                            console.warn(`Ignoring Date property on ${customElementName}.${property.name}`)
                            // Ignore built-in Date types because ... well...
                        }
                        else throw new Error(`Unsupported type in ${property.type}`)
                    }
                    else if (constituentType.kind == "array") {
                        if (constituentType.itemType == "string") {
                            propertySetters.push(
                                csr.createValuePropertySetter(
                                    customElementName,
                                    property.name,
                                    {
                                        ...csr.varType, typeArguments: [{
                                            ...sysTypes.systemCollectionsGenericList, typeArguments: [sysTypes.systemString]
                                        }]
                                    }));
                        }
                        else {
                            throw new Error(`Unsupported type in ${property.type}`)
                        }
                    }
                    else throw new Error(`Unsupported type in ${property.type}`)
                }
            }
        } else {
            // If DOM type

            var types = typeParser.getConstituentTypes(property.type);
            for (var constituentType of types) {
                if (constituentType.kind == "literal") {
                    if (constituentType.type == "string") {
                        propertySetters.push(csr.createLiteralPropertySetter(customElementName,property.name, constituentType.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (constituentType.kind == "type") {
                        if (constituentType.type == "string") {
                            propertySetters.push(csr.createValuePropertySetter(customElementName,property.name, sysTypes.systemString))
                        }
                        else throw new Error(`Unsupported type ${property.type} in ${customElementName}.${property.name}`)
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

function skipAttribute(customElementName: string, attribute: cswc.WebComponentInputEntity) {
    if (attribute.kind == "attribute") {
        if (customElementName == "SlPopup") {
            return true; // SlPopup does not make sense as a stand-alone component
        }
        if (customElementName == "SlSelect" && attribute.name == "getTag") return true;
    }
    return false;
}

function createShoelaceAttributeSetters(customElementName: string, attribute: cswc.WebComponentInputEntity): cswc.WebComponentNode[] {
    var outNodes: csharp.MethodDefinition[] = [];
    if (attribute.kind == "attribute") {

        if (skipAttribute(customElementName, attribute))
            return [];

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
                        else if (types.some(x => x.kind == "type" && x.type == "string")) {
                            // is part of string | other type, already handled
                        }
                        else if (type.type == "number") {
                            outNodes.push(ssr.createStringValueAttributeSetter(attribute.name, customElementName))
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                    else if (type.kind == "array" && type.itemType == "string") {
                        if (types.some(x => x.kind == "type" && x.type == "string")) {
                            // is part of string | string[], already handled
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                    else {
                        throw new Error(`Unsupported type in ${attribute.type}`)
                    }
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
