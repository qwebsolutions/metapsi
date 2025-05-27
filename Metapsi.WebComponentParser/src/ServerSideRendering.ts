import * as csharp from './CSharpContracts';
import { toCSharpValidName, metapsiHtmlNamespace } from './CSharpWebComponentContracts';
import { getDictionaryType, getActionType, getListType } from './CSharpContracts';
import * as typeParser from './TypeParser';

export function getHtmlBuilderType() {
    return new csharp.TypeReference({name:"HtmlBuilder", namespace: metapsiHtmlNamespace});
}

export function getHtmlBuilderParameter() {
    var thisHtmlBuilder = new csharp.Parameter("b",getHtmlBuilderType());
    thisHtmlBuilder.isThis = true;
    return thisHtmlBuilder;
}

export function getAttributesBuilderType(controlType: csharp.TypeReference) {
    var attributesBuilderType = new csharp.TypeReference({name: "AttributesBuilder", namespace : metapsiHtmlNamespace});
    attributesBuilderType.typeArguments.push(controlType);
    return attributesBuilderType;
}

export function getAttributesBuilderParameter(controlType: csharp.TypeReference) {
    var parameter = new csharp.Parameter("b",  getAttributesBuilderType(controlType));
    parameter.isThis = true;
    return parameter;
}

export function createServerSideConstructors(controlType: string, tagName: string, nodeBuilderName: string, comment: string) : csharp.SyntaxNode[] {
    var methods : csharp.SyntaxNode[] = [];

    var currentControlType = new csharp.TypeReference({name: controlType});

    var actionOnTypeBuilderParameter = new csharp.Parameter("buildAttributes",getActionType(getAttributesBuilderType(currentControlType)));

    var withAttrsAndParams = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);
                   
            var nodeParams = new csharp.Parameter("children",getIHtmlNodeType());
            nodeParams.isParams = true;
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
            var nodeParams = new csharp.Parameter("children",getIHtmlNodeType());
            nodeParams.isParams = true;
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.NewKeywordNode(
                            getDictionaryType(
                                csharp.getSystemStringType(),
                                csharp.getSystemStringType())),
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
            var nodeParams = new csharp.Parameter("children",getListType(getIHtmlNodeType()));
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
            var nodeParams = new csharp.Parameter("children",getListType(getIHtmlNodeType()));
            b.parameters.push(nodeParams);
            b.body.push(
                csharp.ReturnNode(
                    csharp.FunctionCallNode(
                        "b",
                        nodeBuilderName,
                        csharp.stringLiteralNode(tagName),
                        csharp.NewKeywordNode(
                            getDictionaryType(csharp.getSystemStringType(), csharp.getSystemStringType())),
                        csharp.identifierNode(nodeParams.name))));
        });

    methods.push(withoutAttrsWithList);

    return methods;
}

export function createStringLiteralAttribute(controlType: csharp.TypeReference, propertyName: string, value: string): csharp.SyntaxNode {
    return csharp.MethodDefinitionNode(
        "Set"+ toCSharpValidName(propertyName) + toCSharpValidName(value),
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;            
            b.parameters.push(getAttributesBuilderParameter(controlType));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetAttribute",
                    csharp.stringLiteralNode(propertyName),
                    csharp.stringLiteralNode(value)));
        });
}

/**
 * if (attr) b.SetAttribute("attr", "");
 * @param controlType 
 * @param propertyName 
 * @returns 
 */
export function createBoolValueAttribute(controlType: csharp.TypeReference, propertyName: string): csharp.SyntaxNode {
    return csharp.MethodDefinitionNode(
        "Set"+ toCSharpValidName(propertyName),
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getAttributesBuilderParameter(controlType));
            b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemBoolType()));
            b.body.push(
                csharp.ifNode(
                    csharp.identifierNode(propertyName),
                    b=>
                    {
                        b.push(csharp.FunctionCallNode(
                            "b",
                            "SetAttribute",
                            csharp.stringLiteralNode(propertyName),
                            csharp.stringLiteralNode("")));
                }));
        });
    }

/**
 * b.SetAttribute("attributeName", "");
 * @param controlType 
 * @param propertyName 
 * @returns 
 */
export function createBoolSetAttribute(controlType: csharp.TypeReference, propertyName: string): csharp.SyntaxNode {
    return csharp.MethodDefinitionNode(
        "Set"+ toCSharpValidName(propertyName),
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getAttributesBuilderParameter(controlType));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetAttribute",
                    csharp.stringLiteralNode(propertyName),
                    csharp.stringLiteralNode("")));
        });
}

/**
 * b.SetAttribute("attr", attr);
 * @param controlType 
 * @param propertyName 
 * @returns 
 */
export function createStringAttribute(controlType: csharp.TypeReference, propertyName: string): csharp.SyntaxNode {
    return csharp.MethodDefinitionNode(
        "Set"+ toCSharpValidName(propertyName),
        csharp.getVoidType(),
        b=>
        {
            b.isStatic = true;
            b.parameters.push(getAttributesBuilderParameter(controlType));
            b.parameters.push(new csharp.Parameter(propertyName, csharp.getSystemStringType()));
            b.body.push(
                csharp.FunctionCallNode(
                    "b",
                    "SetAttribute",
                    csharp.stringLiteralNode(propertyName),
                    csharp.identifierNode(propertyName)));
        });
    }

export function getIHtmlNodeType(){
    return new csharp.TypeReference({name: "IHtmlNode", namespace: metapsiHtmlNamespace});
}

export function CreateServerSideAttributes(componentClass: csharp.TypeReference, attribute: string, typeDefinition: string) : csharp.SyntaxNode[] {
    var outList : csharp.SyntaxNode[] = [];
    var attrTypeHandler: typeParser.TypeHandler = new typeParser.TypeHandler();
    attrTypeHandler.onStringLiteral = (value) => {
        outList.push(createStringLiteralAttribute(componentClass, attribute, value));
    }
    attrTypeHandler.onBoolean = () => {
        outList.push(createBoolSetAttribute(componentClass, attribute));
        outList.push(createBoolValueAttribute(componentClass, attribute));
    }
    attrTypeHandler.onString = () => {
        outList.push(createStringAttribute(componentClass, attribute));
    }
    if(attribute) {
        typeParser.handleTypeDefinition(typeDefinition, attrTypeHandler);
    }

    return outList;
}