import * as csharp from './CSharpContracts';
import * as schema from 'custom-elements-manifest/schema';
import * as ssr from './ServerSideRendering';
import * as csr from './ClientSideRendering'

//import * as typeParser from "./TypeParser";

export function toCSharpValidName(name: string):string{
    if(!name)
        return "";
    return name.split(/[\/-]/).map(x=> capitalize(x)).join("");
}

export function capitalize(s: string) : string {
    if(!s) return "";
    return s.charAt(0).toUpperCase() + s.slice(1);
}

function escapeAngleBrackets(str: string) {
  return str.replace(/</g, '&lt;').replace(/>/g, '&gt;');
}

export function fromManifest(
    manifestWebComponent: schema.CustomElement,
    namespace: string) : csharp.File {
    var outFile = new csharp.File();

    outFile.namespace = namespace;

    var slotsClass = csharp.CreateType("Slots",
        b=>
        {
            manifestWebComponent.slots?.forEach(s=>{
                // If not default slot
                if(s.name){
                    var slotConstant = new csharp.ConstantDefinition();
                    slotConstant.name = toCSharpValidName(s.name);
                    slotConstant.type = csharp.CreateType("string", b=>{});
                    slotConstant.value = new csharp.Literal("\""+s.name+"\"");
                    var comment = new csharp.Comment();
                    comment.lines.push("<summary>");
                    comment.lines.push(`<para> ${escapeAngleBrackets(s.description!)} </para>`);
                    comment.lines.push("</summary>");
                    b.typeDef.body.push({nodeType:csharp.NodeType.Comment, comment:comment});
                    b.typeDef.body.push({nodeType: csharp.NodeType.ConstantDefinition, constant: slotConstant});
                }
            })
        }
    )

    var methodsClass = csharp.CreateType("Method",
        b=>
        {
            manifestWebComponent.members?.forEach(m=>
            {
                if(m.kind == "method") {
                    if(m.description){
                        var methodNameConstant = new csharp.ConstantDefinition();
                        methodNameConstant.name = toCSharpValidName(m.name);
                        methodNameConstant.type = csharp.CreateType("string", b=>{});
                        methodNameConstant.value = new csharp.Literal("\""+m.name+"\"");
                        var comment = new csharp.Comment();
                        comment.lines.push("<summary>");
                        comment.lines.push(`<para> ${escapeAngleBrackets(m.description!)} </para>`);
                        comment.lines.push("</summary>");
                        b.typeDef.body.push({nodeType:csharp.NodeType.Comment, comment:comment});
                        b.typeDef.body.push({nodeType: csharp.NodeType.ConstantDefinition, constant: methodNameConstant});
                    }
                }
            });
        });


    var componentClass = csharp.CreateType(
        manifestWebComponent.name,
        b=>
        {
            b.typeDef.body.push({nodeType: csharp.NodeType.TypeDefinition, definition: slotsClass});
            b.typeDef.body.push({nodeType: csharp.NodeType.TypeDefinition, definition: methodsClass});
        })

    outFile.types.push(componentClass);

    var extensionsClass = csharp.CreateType(
        manifestWebComponent.name+"Control",
        b=>
        {
            b.typeDef.isStatic = true;
            b.typeDef.isPartial = true;

            var ssConstructors = ssr.createServerSideConstructors(manifestWebComponent.name, manifestWebComponent.tagName!, "SlNode", "");
            b.typeDef.body.push(...ssConstructors);

            // Set attributes for server-side rendering
            manifestWebComponent.members?.forEach(
                m=>{
                    if(m.kind == "field"){
                        if(m.description){                           
                            // Only add if there is an equivalent attribute for the property
                            var attribute = (m as any)["attribute"];
                            if(attribute){
                                var setters = ssr.CreateServerSideAttributes(componentClass, attribute, m.type?.text!);
                                b.typeDef.body.push(...setters);
                            }
                        }
                    }
                })

            var csConstructors = csr.createClientSideConstructors(manifestWebComponent.name, manifestWebComponent.tagName!, "SlNode", "");
            b.typeDef.body.push(...csConstructors);

            // Set properties for client-side rendering
            manifestWebComponent.members?.forEach(
                m=>{
                    if(m.kind == "field"){
                        if(m.description){
                            var propName = m.name;
                            if(m.type)
                            {
                                if(m.type.text){
                                    b.typeDef.body.push(...csr.CreatClientSidePropSetters(componentClass, propName, m.type!.text!));
                                }
                            }
                            
                            // var propTypeHandler: typeParser.TypeHandler = new typeParser.TypeHandler();
                            // propTypeHandler.onStringLiteral = (value) => {
                            //     b.typeDef.body.push(createStringLiteralAttribute(componentClass, attribute, value));
                            // }
                            // propTypeHandler.onBoolean = () => {
                            //     b.typeDef.body.push(createBoolSetAttribute(componentClass, attribute));
                            //     b.typeDef.body.push(createBoolValueAttribute(componentClass, attribute));
                            // }
                            // propTypeHandler.onString = () => {
                            //     b.typeDef.body.push(createStringAttribute(componentClass, attribute));
                            // }
                            // typeParser.handleTypeDefinition(m.type?.text!, propTypeHandler);
                        }
                    }
                })
        });

    outFile.types.push(extensionsClass);

    return outFile;
}

export const metapsiHtmlNamespace:string = "Metapsi.Html";

export function getVarType(typeArg: csharp.TypeArgument) : csharp.TypeDefinition {
    var varType = new csharp.TypeDefinition();
    varType.name = "Var";
    varType.namespace = "Metapsi.Syntax";
    varType.typeArguments.push(typeArg);
    return varType;
}
