import * as csharp from './CSharpContracts';
import * as schema from 'custom-elements-manifest/schema';
import * as ssr from './ServerSideRendering';
import * as csr from './ClientSideRendering'

//import * as typeParser from "./TypeParser";

export function toCSharpValidName(name: string): string {
    if (!name)
        return "";
    return name.split(/[\/-]/).map(x => capitalize(x)).join("");
}

export function capitalize(s: string): string {
    if (!s) return "";
    return s.charAt(0).toUpperCase() + s.slice(1);
}

function escapeComment(str: string) {
    return str.replaceAll(/</g, '&lt;').replaceAll(/>/g, '&gt;').replaceAll('\r', "").replaceAll('\n', " ");
}

export function fromManifest(
    manifestWebComponent: schema.CustomElement,
    namespace: string): csharp.File {
    var outFile = new csharp.File();

    outFile.usings.push("Metapsi.Html");
    outFile.usings.push("Metapsi.Syntax");
    outFile.namespace = namespace;

    var slotsClass = csharp.CreateType("Slots",
        b => {
            b.typeDef.isStatic = true;
            manifestWebComponent.slots?.forEach(s => {
                // If not default slot
                if (s.name) {
                    var slotConstant = new csharp.ConstantDefinition();
                    slotConstant.name = toCSharpValidName(s.name);
                    slotConstant.type = csharp.CreateType("string", b => { });
                    slotConstant.value = new csharp.Literal("\"" + s.name + "\"");
                    var comment = new csharp.Comment();
                    comment.lines.push("<summary>");
                    comment.lines.push(`<para> ${escapeComment(s.description!)} </para>`);
                    comment.lines.push("</summary>");
                    b.typeDef.body.push({ nodeType: csharp.NodeType.Comment, comment: comment });
                    b.typeDef.body.push({ nodeType: csharp.NodeType.ConstantDefinition, constant: slotConstant });
                }
            })
        }
    )

    var methodsClass = csharp.CreateType("Method",
        b => {
            b.typeDef.isStatic = true;
            manifestWebComponent.members?.forEach(m => {
                if (m.kind == "method") {
                    if (m.description) {
                        var methodNameConstant = new csharp.ConstantDefinition();
                        methodNameConstant.name = toCSharpValidName(m.name);
                        methodNameConstant.type = csharp.CreateType("string", b => { });
                        methodNameConstant.value = new csharp.Literal("\"" + m.name + "\"");
                        var comment = new csharp.Comment();
                        comment.lines.push("<summary>");
                        comment.lines.push(`<para> ${escapeComment(m.description!)} </para>`);
                        comment.lines.push("</summary>");
                        b.typeDef.body.push({ nodeType: csharp.NodeType.Comment, comment: comment });
                        b.typeDef.body.push({ nodeType: csharp.NodeType.ConstantDefinition, constant: methodNameConstant });
                    }
                }
            });
        });


    var componentClass = csharp.CreateType(
        manifestWebComponent.name,
        b => {
            b.typeDef.isPartial = true;
            b.typeDef.body.push({ nodeType: csharp.NodeType.TypeDefinition, definition: slotsClass });
            b.typeDef.body.push({ nodeType: csharp.NodeType.TypeDefinition, definition: methodsClass });
        })

    outFile.types.push(componentClass);

    var extensionsClass = csharp.CreateType(
        manifestWebComponent.name + "Control",
        b => {
            b.typeDef.isStatic = true;
            b.typeDef.isPartial = true;

            var ssConstructors = ssr.createServerSideConstructors(manifestWebComponent.name, manifestWebComponent.tagName!, "SlTag", "");
            b.typeDef.body.push(...ssConstructors);

            // Set attributes for server-side rendering
            manifestWebComponent.members?.forEach(
                m => {
                    if (m.kind == "field") {
                        if (m.description) {
                            // Only add if there is an equivalent attribute for the property
                            var attribute = (m as any)["attribute"];
                            if (attribute) {
                                var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);
                                var setters = ssr.CreateServerSideAttributes(componentClass, attribute, m.type?.text!);
                                setters.forEach(setter => {
                                    b.typeDef.body.push(commentNode);
                                    b.typeDef.body.push(setter);
                                    b.typeDef.body.push(csharp.newLineNode());
                                });
                                //b.typeDef.body.push(...setters);
                            }
                        }
                    }
                })

            var csConstructors = csr.createClientSideConstructors(manifestWebComponent.name, manifestWebComponent.tagName!, "SlNode", "");
            b.typeDef.body.push(...csConstructors);

            // Set properties for client-side rendering
            manifestWebComponent.members?.forEach(
                m => {
                    if (m.kind == "field") {
                        if (m.description) {
                            var propName = m.name;
                            if (m.type) {
                                if (m.type.text) {
                                    var commentNode = csharp.commentNode(`<para> ${escapeComment(m.description)} </para>`);
                                    var setters = csr.createClientSidePropSetters(componentClass, propName, m.type!.text!);
                                    setters.forEach(setter => {
                                        b.typeDef.body.push(commentNode);
                                        b.typeDef.body.push(setter);
                                        b.typeDef.body.push(csharp.newLineNode());
                                    });
                                }
                            }
                        }
                    }
                })
            manifestWebComponent.events?.forEach(
                e => {
                    if (!e.deprecated) {
                        var commentNode = csharp.commentNode(`<para> ${escapeComment(e.description!)} </para>`);
                        var eventHandlers = csr.createEventHandlers(componentClass.name, e.name);
                        eventHandlers.forEach(handler =>{
                            b.typeDef.body.push(commentNode);
                            b.typeDef.body.push(handler);
                            b.typeDef.body.push(csharp.newLineNode());
                        })
                    }
                }
            )

        });

    outFile.types.push(extensionsClass);

    return outFile;
}

export const metapsiHtmlNamespace: string = "Metapsi.Html";

export function getVarType(typeArg: csharp.TypeArgument): csharp.TypeDefinition {
    var varType = new csharp.TypeDefinition();
    varType.name = "Var";
    varType.namespace = "Metapsi.Syntax";
    varType.typeArguments.push(typeArg);
    return varType;
}
