import * as csharp from './CSharpContracts.js';
import { toCSharpValidName, metapsiHtmlNamespace, toCSharpValidAttribute } from './CSharpWebComponentContracts.js';
import { getDictionaryType, getActionType, getListType } from './CSharpContracts.js';
import * as typeParser from './TypeParser.js';
import * as attr from './AttributeTypeHandler.js'

export function getHtmlBuilderType() {
    return new csharp.TypeReference({ name: "HtmlBuilder", namespace: metapsiHtmlNamespace });
}

export function getHtmlBuilderParameter() {
    var thisHtmlBuilder = new csharp.Parameter("b", getHtmlBuilderType());
    thisHtmlBuilder.isThis = true;
    return thisHtmlBuilder;
}

export function createServerSideConstructors(controlType: string, tagName: string, nodeBuilderName: string): csharp.SyntaxNode[] {
    var methods: csharp.SyntaxNode[] = [];

    var currentControlType = new csharp.TypeReference({ name: controlType });

    var actionOnTypeBuilderParameter = new csharp.Parameter("buildAttributes", getActionType(attr.getAttributesBuilderType(currentControlType)));

    var withAttrsAndParams = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b => {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);

            var nodeParams = new csharp.Parameter("children", getIHtmlNodeType());
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

    var withoutAttrsWithParams = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b => {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());
            var nodeParams = new csharp.Parameter("children", getIHtmlNodeType());
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
        b => {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());
            b.parameters.push(actionOnTypeBuilderParameter);
            var nodeParams = new csharp.Parameter("children", getListType(getIHtmlNodeType()));
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

    var withoutAttrsWithList = csharp.MethodDefinitionNode(
        controlType,
        getIHtmlNodeType(),
        b => {
            b.isStatic = true;
            b.parameters.push(getHtmlBuilderParameter());
            var nodeParams = new csharp.Parameter("children", getListType(getIHtmlNodeType()));
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


export function getIHtmlNodeType() {
    return new csharp.TypeReference({ name: "IHtmlNode", namespace: metapsiHtmlNamespace });
}

export function CreateServerSideAttributes(componentClass: csharp.TypeReference, attribute: string, typeDefinition: string): csharp.SyntaxNode[] {

    var outList: csharp.SyntaxNode[] = [];
    var attrTypeHandler = attr.GetDefaultAttributeTypeHandler(componentClass, attribute,outList);

    if (attribute) {
        typeParser.handleTypeDefinition(typeDefinition, attrTypeHandler);
    }

    return outList;
}