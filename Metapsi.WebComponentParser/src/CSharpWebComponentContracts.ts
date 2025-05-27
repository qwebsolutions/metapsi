import * as csharp from './CSharpContracts';

import * as ts from "typescript";
import * as schema from 'custom-elements-manifest/schema';

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
            var ssConstructors = createServerSideConstructors(manifestWebComponent.name, manifestWebComponent.tagName!, "SlNode", "");
            b.typeDef.body.push(...ssConstructors);
        });


    outFile.types.push(extensionsClass);

    return outFile;
}

const metapsiHtmlNamespace:string = "Metapsi.Html";

export function getIHtmlNodeType(){
    var iHtmlNodeType = new csharp.TypeDefinition();
    iHtmlNodeType.name = "IHtmlNode";
    iHtmlNodeType.namespace = metapsiHtmlNamespace;

    return iHtmlNodeType;
}

export function getHtmlBuilderType() {
    var htmlBuilderType = new csharp.TypeDefinition();
    htmlBuilderType.name = "HtmlBuilder";
    htmlBuilderType.namespace = metapsiHtmlNamespace;

    return htmlBuilderType;
}

export function getAttributesBuilderType(controlType: csharp.TypeDefinition) {
    var attributesBuilderType = new csharp.TypeDefinition();
    attributesBuilderType.name = "AttributesBuilder";
    attributesBuilderType.namespace = metapsiHtmlNamespace;
    attributesBuilderType.typeArguments.push({argType: "TypeDefinition", typeDefinition : controlType});

    return attributesBuilderType;
}

export function getActionType(onType: csharp.TypeDefinition){
    var action = new csharp.TypeDefinition();
    action.name = "Action";
    action.namespace = "System";
    action.typeArguments.push({argType: "TypeDefinition", typeDefinition: onType});
    return action;
}

export function getHtmlBuilderParameter() {
    var thisHtmlBuilder = new csharp.Parameter("b");
    thisHtmlBuilder.isThis = true;
    thisHtmlBuilder.type = getHtmlBuilderType();
    return thisHtmlBuilder;
}

export function getDictionaryType(keyType: csharp.TypeArgument , value: csharp.TypeArgument) : csharp.TypeDefinition {
    var outType = new csharp.TypeDefinition();
    outType.name = "Dictionary";
    outType.namespace = "System.Collections.Generic";
    outType.typeArguments.push(keyType);
    outType.typeArguments.push(value);
    return outType;
}

export function getListType(itemType: csharp.TypeArgument) : csharp.TypeDefinition {
    var outType = new csharp.TypeDefinition();
    outType.name = "List";
    outType.namespace = "System.Collections.Generic";
    outType.typeArguments.push(itemType);
    return outType;
}


export function createServerSideConstructors(controlType: string, tagName: string, nodeBuilderName: string, comment: string){
    var methods : csharp.SyntaxNode[] = [];

    var currentControlType = new csharp.TypeDefinition();
    currentControlType.name = controlType;

    var actionOnTypeBuilderParameter = new csharp.Parameter("buildAttributes");
    actionOnTypeBuilderParameter.type = getActionType(getAttributesBuilderType(currentControlType));

    var withAttrsAndParams = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);
                   
            var nodeParams = new csharp.Parameter("children");
            nodeParams.isParams = true;
            nodeParams.type = getIHtmlNodeType();
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.identifierNode(actionOnTypeBuilderParameter.name),
                        csharp.identifierNode(nodeParams.name))));
        });
    methods.push(withAttrsAndParams);

    var withoutAttrsWithParams  = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());                  
            var nodeParams = new csharp.Parameter("children");
            nodeParams.isParams = true;
            nodeParams.type = getIHtmlNodeType();
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.NewKeywordNode(
                            getDictionaryType(
                                csharp.ClosedTypeArgument(csharp.getSystemStringType()),
                                csharp.ClosedTypeArgument(csharp.getSystemStringType()))),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withoutAttrsWithParams);

    var withAttrsWithList = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());                  
            b.parameters.push(actionOnTypeBuilderParameter);
            var nodeParams = new csharp.Parameter("children");
            nodeParams.type = getListType(csharp.ClosedTypeArgument(getIHtmlNodeType()));
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.identifierNode(actionOnTypeBuilderParameter.name),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withAttrsWithList);

    var withoutAttrsWithList  = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());                  
            var nodeParams = new csharp.Parameter("children");
            nodeParams.type = getListType(csharp.ClosedTypeArgument(getIHtmlNodeType()));
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.NewKeywordNode(
                            getDictionaryType(
                                csharp.ClosedTypeArgument(csharp.getSystemStringType()),
                                csharp.ClosedTypeArgument(csharp.getSystemStringType()))),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withoutAttrsWithList);

    return methods;
}