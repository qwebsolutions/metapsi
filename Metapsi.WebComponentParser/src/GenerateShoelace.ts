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

export async function GenerateShoelace(version: string, outFolder: string): Promise<void> {
    var response = await fetch(`https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@${version}/dist/custom-elements.json`)
    var shoelaceManifest: customElementManifestSchema.Package = await response.json();
    for (const m of shoelaceManifest.modules) {
        for (const d of m.declarations!) {
            {
                switch (d.kind) {
                    case "class":

                        var dec = d as customElementManifestSchema.CustomElement;

                        var file = cswc.CreateWebComponentFile(dec, createShoelaceConverter(), "Metapsi.Shoelace");
                        var controlName = dec.name;
                        var slFilePath = path.join(outFolder, controlName + ".cs");
                        // var csharpDefinition = cswc.fromManifest(
                        //     dec,
                        //     "Metapsi.Shoelace",
                        //     cswc.GetDefaultWebComponentConverter({
                        //         ssrConstructorName: "SlTag",
                        //         csrConstructorName: "SlNode"
                        //     }));
                        var csharpFileString = csharpFile.fileToCSharp(file);
                        //await fs.writeFile(slFilePath, csharpFileString, 'utf-8');
                        console.log(slFilePath);
                        console.log(csharpFileString);
                }
            }
        }
    }
}

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

function CreateShoelaceAttributes(type: typeParser.ConstituentType, classType: csharp.TypeDefinition, attribute: customElementManifestSchema.Attribute): csharp.SyntaxNode[] {
    var outNodes: csharp.SyntaxNode[] = [];
    if (classType.name == "SlAlert") {
        if (attribute.name == "duration") {
            //outNodes.push(ssr.(classType,property.name));
        }
    }

    var types = typeParser.getConstituentTypes(attribute.type!.text);
    for (var type of types) {
        //outNodes.push(...CreateShoelaceAttributes(type, classType, attribute))
    }
    return outNodes;
}

function createShoelaceConverter(): cswc.WebComponentConverter {
    return {
        createSsrConstructors: (c) => [

        ],// ssr.createServerSideConstructors(c.name, c.tagName!, "SlTag"),
        createCsrConstructors: (c) => [], // csr.createClientSideConstructors(c.name, c.tagName!, "SlNode"),
        createSlot: cswc.createSlotNameConstant,
        createMethod: cswc.createMethodNameConstant,
        createAttribute: (classType, attribute) => {
            var outNodes: csharp.SyntaxNode[] = [];
            // var types = typeParser.getConstituentTypes(attribute.type!.text);
            // for (var type of types) {
            //     outNodes.push(...CreateShoelaceAttributes(type, classType, attribute))
            // }
            return outNodes;
        },
        createProperty: (c: csharp.TypeReference, p: customElementManifestSchema.ClassField): csharp.SyntaxNode[] => {
            var methodDefinitions: csharp.MethodDefinition[] = createShoelaceProperty(c, p);
            return methodDefinitions.map(x => ({ nodeType: csharp.NodeType.MethodDefinition, method: x }))
        },
        // createProperty: (classType, property) => {
        //     var outNodes: csharp.SyntaxNode[] = [];
        //     var types = typeParser.getConstituentTypes(property.type!.text);
        //     for (var type of types) {
        //         outNodes.push(...CreateShoelaceAttributes(type, classType, property))
        //     }
        //     return outNodes;
        // },
        createEvent: () => []
    }
}

// async function LoadIonic() {
//     const docs = await import('@ionic/core/dist/docs.json', { assert: { type: 'json' } });
//     console.log(docs.default);
// }
