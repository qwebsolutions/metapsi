import * as csharp from './CSharpContracts.js'
import {
    SyntaxNode,
    NodeType,
    Comment,
    Literal,
    ReturnKeyword,
    Identifier,
    TypeDefinition,
    ConstantDefinition,
    PropertyDefinition,
    MethodDefinition,
    IfStatement,
    NewKeyword,
    TypeReference,
    Call
} from "./CSharpContracts.js"

//export type FillSyntaxNodesFn<TFileStructure, TEntity extends { kind: string }> = (fileStructure: TFileStructure, entity: TEntity, syntaxNodes: csharp.SyntaxNode[]) => void;
//export type GetFileContentFn<TFileStructure> = (fileStructure: TFileStructure) => File;

const indentSize = 4;

export class File {
    usings: string[] = [];
    namespace: string = "";
    content: csharp.SyntaxNode[] = []
}

function spaces(indentLevel: number) {
    return " ".repeat(indentLevel * indentSize);
}


export function fileToCSharp(file: File): string {
    var lines: string[] = [];
    file.usings.forEach(u => {
        if (!u.startsWith("using")) {
            lines.push("using " + u + ";");
        }
        else {
            lines.push(u);
        }
    });
    lines.push("");

    lines.push(`namespace ${file.namespace};`);
    lines.push("");

    file.content.forEach(t => {
        lines.push(toCSharp(t, 0));
    });

    return lines.join("\n");
}


export function toCSharp(node: SyntaxNode, indentLevel: number): string {
    switch (node.nodeType) {
        case NodeType.NewLine:
            return ""; // new line does not actually need to insert a newline '\n', because the file is joined with '\n' in the first place
        case NodeType.Comment:
            return commentToCSharp(node.comment, indentLevel);
        case NodeType.ReturnKeyword:
            return returnKeywordToCSharp(node.keyword, indentLevel);
        case NodeType.NewKeyword:
            return newKeywordToCSharp(node.keyword, indentLevel);
        case NodeType.Literal:
            return literalToCSharp(node.literal);
        case NodeType.Identifier:
            return identifierToCSharp(node.identifier);
        case NodeType.TypeDefinition:
            return typeDefinitionToCSharp(node.definition, indentLevel);
        case NodeType.ConstantDefinition:
            return constantToCSharp(node.constant, indentLevel);
        case NodeType.PropertyDefinition:
            return propertyToCSharp(node.prop, indentLevel);
        case NodeType.MethodDefinition:
            return methodToCSharp(node.method, indentLevel);
        case NodeType.Call:
            return callToCSharp(node.call, indentLevel);
        case NodeType.IfStatement:
            return ifStatementToCSharp(node.ifStatement, indentLevel);
        case NodeType.TypeReference:
            return "" // Type references are directly handled inside the other cases
        default:
            const check: never = node;
            return ""
    }
}

function commentToCSharp(node: Comment, indentLevel: number) {
    return node.lines.map(x => `${spaces(indentLevel)}/// ${x}`).join("\n");
}

function literalToCSharp(node: Literal): string {
    return node.value!;
}

function returnKeywordToCSharp(node: ReturnKeyword, indentLevel: number): string {
    if (node.expression) {
        return `${spaces(indentLevel)}return ${toCSharp(node.expression!, 0)}`
    }
    return `${spaces(indentLevel)}return`
}

function newKeywordToCSharp(node: NewKeyword, indentLevel: number): string {
    if (node.expression!.nodeType == NodeType.TypeReference) {
        return `${spaces(indentLevel)}new ${typeUsageToCSharp(node.expression?.typeRef!)}()`
    }
    throw "new keyword only works with type expresion";
}


function identifierToCSharp(node: Identifier): string {
    return node.identifier!;
}

function typeDefinitionToCSharp(node: TypeDefinition, indentLevel: number) {
    var signature = [];
    signature.push(node.visibility ?? "public");
    if (node.isStatic) signature.push("static");
    if (node.isPartial) signature.push("partial");
    signature.push(node.keyword ?? "class");
    signature.push(node.name);

    var signatureLine = signature.join(' ');

    var typeLines = [];
    typeLines.push(`${spaces(indentLevel)}${signatureLine}`);
    typeLines.push(`${spaces(indentLevel)}{`);
    node.body.forEach((innerNode) => {
        typeLines.push(toCSharp(innerNode, indentLevel + 1));
    })

    typeLines.push(`${spaces(indentLevel)}}`);

    return typeLines.join("\n");
}

function typeUsageToCSharp(type: TypeReference): string {
    var usage = [];
    if (type.namespace) usage.push(type.namespace);
    usage.push(type.name)
    var qualifiedBaseType = usage.join(".");

    if (!type.typeArguments)
        return qualifiedBaseType;
    if (!type.typeArguments.length) {
        return qualifiedBaseType;
    }

    return qualifiedBaseType + "<" + type.typeArguments.map(ta => typeUsageToCSharp(ta)).join(", ") + ">";
}

function constantToCSharp(node: ConstantDefinition, indentLevel: number) {
    var lines = [];
    if (node.visibility) {
        lines.push(node.visibility);
    }
    lines.push("const");
    lines.push(typeUsageToCSharp(node.type!));
    lines.push(node.name);
    lines.push("=");
    lines.push(literalToCSharp(node.value!));
    return spaces(indentLevel) + lines.join(" ") + ";";
}

function propertyToCSharp(node: PropertyDefinition, indentLevel: number) {
    var lines = [];
    if (node.visibility) lines.push(node.visibility);
    if (node.isStatic) lines.push("static");
    lines.push(typeUsageToCSharp(node.type!));
    lines.push(node.name);
    lines.push("{ get; set; }");
    if (node.initializer) {
        lines.push("= " + literalToCSharp(node.initializer))
    }
    return spaces(indentLevel) + lines.join(" ");
}

function methodToCSharp(node: MethodDefinition, indentLevel: number) {
    var lines = [];

    var signature = [];
    if (node.visibility) signature.push(node.visibility);
    if (node.isStatic) signature.push("static");
    if (!node.returnType)
        signature.push("void")
    else signature.push(typeUsageToCSharp(node.returnType!));

    var crammedName = [];
    crammedName.push(node.name);
    var genericTypes = node.typeParameters?.map(x => x.name).join(",")
    if (genericTypes) crammedName.push(`<${genericTypes}>`);
    crammedName.push("(");
    var methodParameter: string[] = [];
    node.parameters?.forEach((p) => {
        if (p.isParams) {
            methodParameter.push(`params ${typeUsageToCSharp(p.type!)}[] ${p.name}`)
        }

        else if (p.isThis) {
            methodParameter.push(`this ${typeUsageToCSharp(p.type!)} ${p.name}`);
        }
        else methodParameter.push(`${typeUsageToCSharp(p.type!)} ${p.name}`)
    });
    crammedName.push(methodParameter.join(", "));
    crammedName.push(")");
    signature.push(crammedName.join(""));

    var genericConstraints: string[] = [];

    node.typeParameters?.forEach((tp) => {
        if (tp.typeConstraints && tp.typeConstraints.length) {
            genericConstraints.push(`where ${tp.name}: ${tp.typeConstraints.join(", ")}`);
        }
    });

    if (genericConstraints.length > 1) {
        signature.push("\n" + spaces(indentLevel + 1) + genericConstraints.join(`\n${spaces(indentLevel + 1)}`));
    }
    else {
        signature.push(genericConstraints);
    }

    lines.push(signature.join(" "));
    lines.push(spaces(indentLevel) + "{");
    var body: string[] = [];
    node.body.forEach((node) => {
        body.push(toCSharp(node, indentLevel + 1) + ";");
    });
    lines.push(body.join(""));
    lines.push(spaces(indentLevel) + "}");
    return spaces(indentLevel) + lines.join("\n");
}

function callToCSharp(node: Call, indentLevel: number) {
    var args: string[] = [];

    node.arguments?.forEach((arg) => {
        args.push(toCSharp(arg!, 0));
    });

    return `${spaces(indentLevel)}${identifierToCSharp(node.onInstance!)}.${node.methodName}(${args.join(", ")})`
}

function ifStatementToCSharp(node: IfStatement, indentLevel: number) {
    if (node.ifBlock?.length == 1 && !node.elseBlock?.length) {
        return `${spaces(indentLevel)}if (${toCSharp(node.onExpression!, 0)}) ${toCSharp(node.ifBlock.at(0)!, 0)}`
    }
    var lines: string[] = [];

    lines.push(`${spaces(indentLevel)}if (${toCSharp(node.onExpression!, 0)})`);
    lines.push(spaces(indentLevel) + "{");
    node.ifBlock!.forEach(statement => {
        lines.push(toCSharp(statement, indentLevel + 1));
    });
    lines.push(spaces(indentLevel) + "}");
    if (node.elseBlock && node.elseBlock.length) {
        node.elseBlock!.forEach(statement => {
            lines.push(toCSharp(statement, indentLevel + 1));
        });
    }

    return lines.join("\n");
}