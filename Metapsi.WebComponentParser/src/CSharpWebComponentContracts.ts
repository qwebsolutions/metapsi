/*
This handles conversion of web component schema to C# types 
It specifies the way component schema is navigated and the output C# file structure.
The creation of the actual nodes is delegated to (possibly custom) implementations through WebComponentConverter
*/

import * as csharp from './CSharpContracts.js';
import * as schema from 'custom-elements-manifest';
import * as ssr from './ServerSideRendering.js';
import * as csr from './ClientSideRendering.js'
import * as typeParser from './TypeParser.js';

/**
 * Converter functions return more than one syntax node as a single entity can have multiple C# representations + possibly comments
 */
export class WebComponentConverter {
    addSsrConstructors?: (component: schema.CustomElement) => csharp.SyntaxNode[];
    addCsrConstructors?: (component: schema.CustomElement) => csharp.SyntaxNode[];
    addSlot?: (slot: schema.Slot) => csharp.SyntaxNode[];
    addMethod?: (method: schema.ClassMethod) => csharp.SyntaxNode[];
    addAttribute?: (classType: csharp.IType, attribute: schema.Attribute) => csharp.SyntaxNode[];
    addProperty?: (classType: csharp.TypeDefinition, property: schema.ClassField) => csharp.SyntaxNode[];
    addEvent?: (classType: csharp.TypeDefinition, e: schema.Event) => csharp.SyntaxNode[];
}

export function GetDefaultWebComponentConverter(options: { ssrConstructorName: string, csrConstructorName: string }): WebComponentConverter {
    return {
        addSsrConstructors: (c) => ssr.createServerSideConstructors(c.name, c.tagName!, options.ssrConstructorName),
        addCsrConstructors: (c) => csr.createClientSideConstructors(c.name, c.tagName!, options.csrConstructorName),
        addSlot: getDefaultAddSlot,
        addMethod: getDefaultAddMethod,
        addAttribute: (classType, attribute) => getDefaultAddAttribute(classType, attribute),
        addProperty: (classType, property) => getDefaultAddProperty(classType, property),
        addEvent: getDefaultAddEvent
    }
}

export function getDefaultAddSlot(s: schema.Slot): csharp.SyntaxNode[] {
    // If not default slot
    if (s.name) {
        var slotConstant = new csharp.ConstantDefinition();
        slotConstant.name = toCSharpValidName(s.name);
        slotConstant.type = csharp.getSystemStringType();
        slotConstant.value = new csharp.Literal("\"" + s.name + "\"");
        var commentNode = csharp.commentNode(`<para> ${escapeComment(s.description!)} </para>`);
        return [
            commentNode,
            { nodeType: csharp.NodeType.ConstantDefinition, constant: slotConstant }]
    }
    return []
}

export function getDefaultAddMethod(m: schema.ClassMethod): csharp.SyntaxNode[] {
    if (m.description) {
        var methodNameConstant = new csharp.ConstantDefinition();
        methodNameConstant.name = toCSharpValidName(m.name);
        methodNameConstant.type = csharp.getSystemStringType();
        methodNameConstant.value = new csharp.Literal("\"" + m.name + "\"");
        var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);
        return [
            commentNode,
            { nodeType: csharp.NodeType.ConstantDefinition, constant: methodNameConstant }]
    }
    return []
}

export function getDefaultAddAttribute(componentClass: csharp.IType, m: schema.Attribute): csharp.SyntaxNode[] {
    var outNodes: csharp.SyntaxNode[] = [];
    var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);
    var setters = ssr.CreateServerSideAttributes(new csharp.TypeReference(componentClass), m.name, m.type?.text!);
    setters.forEach(setter => {
        outNodes.push(commentNode);
        outNodes.push(setter);
        outNodes.push(csharp.newLineNode());
    });
    return outNodes;
}

export function getDefaultAddProperty(componentClass: csharp.TypeDefinition, m: schema.Attribute): csharp.SyntaxNode[] {
    var outNodes: csharp.SyntaxNode[] = [];
    var propName = m.name;
    if (m.type) {
        if (m.type.text) {
            var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);
            var setters = csr.createClientSidePropSetters(componentClass, propName, m.type!.text!);
            setters.forEach(setter => {
                outNodes.push(commentNode);
                outNodes.push(setter);
                outNodes.push(csharp.newLineNode());
            });
        }
    }
    return outNodes;
}

export function getDefaultAddEvent(componentClass: csharp.TypeDefinition, e: schema.Event): csharp.SyntaxNode[] {
    var outNodes: csharp.SyntaxNode[] = [];
    var commentNode = csharp.commentNode(`<para> ${escapeComment(e.description!)} </para>`);
    var eventHandlers = csr.createEventHandlers(componentClass.name, e.name);
    eventHandlers.forEach(handler => {
        outNodes.push(commentNode);
        outNodes.push(handler);
        outNodes.push(csharp.newLineNode());
    })
    return outNodes;
}

export function toCSharpValidName(name: string): string {
    if (!name)
        return "";
    return name.split(/[\/-]/).map(x => capitalize(x)).join("");
}

export function toCSharpValidAttribute(name: string): string {
    var csharpValidName = toCSharpValidName(name);
    return csharpValidName[0].toLowerCase() + csharpValidName.substring(1);
}

export function capitalize(s: string): string {
    if (!s) return "";
    return s.charAt(0).toUpperCase() + s.slice(1);
}

function escapeComment(str: string | undefined) {
    if (!str) return "";
    return str.replaceAll(/</g, '&lt;').replaceAll(/>/g, '&gt;').replaceAll('\r', "").replaceAll('\n', " ");
}

export function fromManifest(
    manifestWebComponent: schema.CustomElement,
    namespace: string,
    converter: WebComponentConverter): csharp.File {
    var outFile = new csharp.File();

    outFile.usings.push("Metapsi.Html");
    outFile.usings.push("Metapsi.Syntax");
    outFile.usings.push("Metapsi.Hyperapp");
    outFile.namespace = namespace;

    var slotsClass = csharp.CreateType("Slot",
        b => {
            b.typeDef.isStatic = true;
            manifestWebComponent.slots?.forEach(s => {
                b.typeDef.body.push(...converter.addSlot!(s));
            })
        })

    var methodsClass = csharp.CreateType("Method",
        b => {
            b.typeDef.isStatic = true;
            manifestWebComponent.members?.forEach(m => {
                if (m.kind == "method") {
                    b.typeDef.body.push(...converter.addMethod!(m))
                }
            })
        });

    var componentClass = csharp.CreateType(
        manifestWebComponent.name,
        b => {
            b.typeDef.isPartial = true;
            b.typeDef.body.push(csharp.commentNode(``));
            b.typeDef.body.push({ nodeType: csharp.NodeType.TypeDefinition, definition: slotsClass });
            b.typeDef.body.push(csharp.commentNode(``));
            b.typeDef.body.push({ nodeType: csharp.NodeType.TypeDefinition, definition: methodsClass });
        })

    outFile.content.push(csharp.commentNode(`<para> ${escapeComment(manifestWebComponent.summary!)} </para>`));
    outFile.content.push({ nodeType: csharp.NodeType.TypeDefinition, definition: componentClass });

    var extensionsClass = csharp.CreateType(
        manifestWebComponent.name + "Control",
        b => {
            b.typeDef.isStatic = true;
            b.typeDef.isPartial = true;

            b.typeDef.body.push(...converter.addSsrConstructors!(manifestWebComponent));

            // Set attributes for server-side rendering
            manifestWebComponent.members?.forEach(
                m => {
                    if (m.kind == "field") {
                        if (m.description) {
                            // Only add if there is an equivalent attribute for the property
                            var attribute = (m as any)["attribute"];
                            if (attribute) {
                                b.typeDef.body.push(...converter.addAttribute!(componentClass, m as schema.Attribute));
                            }
                        }
                    }
                })

            b.typeDef.body.push(...converter.addCsrConstructors!(manifestWebComponent));

            // Set properties for client-side rendering
            manifestWebComponent.members?.forEach(
                m => {
                    if (m.kind == "field") {
                        if (m.description) {
                            b.typeDef.body.push(...converter.addProperty!(componentClass, m))
                        }
                    }
                })
            manifestWebComponent.events?.forEach(
                e => {
                    if (!e.deprecated) {
                        b.typeDef.body.push(...converter.addEvent!(componentClass, e));
                    }
                }
            )
        });

    outFile.content.push({ nodeType: csharp.NodeType.TypeDefinition, definition: extensionsClass });

    return outFile;
}

export const metapsiHtmlNamespace: string = "Metapsi.Html";

export function getVarType(typeArg: csharp.TypeReference): csharp.TypeReference {
    var varType = new csharp.TypeReference({ name: "Var", namespace: "Metapsi.Syntax" });
    varType.typeArguments.push(typeArg);
    return varType;
}
