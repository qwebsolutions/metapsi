const indentSize = 4;

export enum NodeType {
    NewLine,
    Comment,
    Literal,
    TypeDefinition,
    TypeReference,
    ConstantDefinition,
    Identifier,
    PropertyDefinition,
    MethodDefinition,
    Call,
    IfStatement,
    ReturnKeyword,
    NewKeyword
}

function spaces(indentLevel: number) {
    return " ".repeat(indentLevel * indentSize);
}

export class File {
    usings: string[] = [];
    namespace: string = "";
    content: SyntaxNode[] = []
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
        lines.push(toCSharp(t,  0));
    });

    return lines.join("\n");
}

export class Comment {
    lines: string[] = [];
}

export class ReturnKeyword {
    expression?: SyntaxNode;
}

export class NewKeyword {
    expression?: SyntaxNode
}

/**
 * This represents a standalone type with name + namespace. 
 */
export interface IType {
    name: string;
    namespace?: string;
}

/**
 * The actual definition we output, with declaration & body
 */
export class TypeDefinition implements IType {
    keyword: "class" | "interface" = "class";
    name: string = "";
    namespace?: string;
    typeParameters: TypeParameter[] = [];
    isPartial: boolean = false;
    isStatic: boolean = false;
    visibility: string = "public";
    body: SyntaxNode[] = []
}

/**
 * A namespaceless type placeholder with type constraints
 */
export class TypeParameter implements IType {
    constructor(name:string) {
        this.name = name;
    }
    name: string = "";
    typeConstraints: string[] = [];
}

/**
 * The type reference can point to a type that has type parameters that can be concrete type or other type parameters, hence IType
 */
export class TypeReference {
    /**
     *
     */
    constructor(baseTypeDefinition: IType) {
        this.baseType = baseTypeDefinition;
    }

    baseType: IType;

    typeArguments: TypeReference[] = [];
}

export class ConstantDefinition {
    name: string = "";
    type?: TypeReference;
    value?: Literal;
    visibility: string = "public";
}

export class PropertyDefinition {
    name: string = "";
    type?: TypeReference;
    visibility: string = "public";
    isStatic: boolean = false;
}

export class MethodDefinition {
    name: string = "";
    returnType?: TypeReference;
    parameters: Parameter[] = [];
    typeParameters: TypeParameter[] = [];
    visibility: string = "public";
    isStatic: boolean = false;
    body: SyntaxNode[] = [];
}

export class Parameter {
    /**
     *
     */
    constructor(name: string, type: TypeReference) {
        this.name = name;
        this.type = type;
    }
    name: string = "";
    type?: TypeReference;
    isParams: boolean = false;
    isThis: boolean = false;
}

export class Identifier {
    /**
     *
     */
    constructor(identifier: string) {
        this.identifier = identifier;
    }
    identifier?: string;
}

export class Literal {
    /**
     *
     */
    constructor(value: string) {
        this.value = value;
    }
    value?: string;
}

export class IfStatement {
    onExpression?: SyntaxNode;
    ifBlock: SyntaxNode[] = [];
    elseBlock: SyntaxNode[] = [];
}

export class Call {
    onInstance?: Identifier;
    methodName?: string;
    arguments: SyntaxNode[] = []
}

export type SyntaxNode =
    { nodeType: NodeType.NewLine } |
    { nodeType: NodeType.Comment, comment: Comment } |
    { nodeType: NodeType.ReturnKeyword, keyword: ReturnKeyword } |
    { nodeType: NodeType.NewKeyword, keyword: NewKeyword } |
    { nodeType: NodeType.Literal, literal: Literal } |
    { nodeType: NodeType.Identifier, identifier: Identifier } |
    { nodeType: NodeType.TypeDefinition, definition: TypeDefinition } |
    { nodeType: NodeType.TypeReference, typeRef: TypeReference } |
    { nodeType: NodeType.ConstantDefinition, constant: ConstantDefinition } |
    { nodeType: NodeType.PropertyDefinition, prop: PropertyDefinition } |
    { nodeType: NodeType.MethodDefinition, method: MethodDefinition } |
    { nodeType: NodeType.Call, call: Call } |
    { nodeType: NodeType.IfStatement, ifStatement: IfStatement }

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
        default:
            throw `Not implemented ${node}`;
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
    signature.push(node.visibility);
    if (node.isStatic) signature.push("static");
    if (node.isPartial) signature.push("partial");
    signature.push(node.keyword);
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

function typeUsageToCSharp(type: TypeReference) : string {
    var usage = [];
    var baseType = type.baseType;
    if (baseType.namespace) usage.push(baseType.namespace);
    usage.push(baseType.name)
    var qualifiedBaseType = usage.join(".");

    if (!type.typeArguments.length)
        return qualifiedBaseType;

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
    var genericTypes = node.typeParameters.map(x => x.name).join(",")
    if (genericTypes) crammedName.push(`<${genericTypes}>`);
    crammedName.push("(");
    var methodParameter: string[] = [];
    node.parameters.forEach((p) => {
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

    node.typeParameters.forEach((tp) => {
        if (tp.typeConstraints.length) {
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

    node.arguments.forEach((arg) => {
        args.push(toCSharp(arg!, 0));
    });

    return `${spaces(indentLevel)}${identifierToCSharp(node.onInstance!)}.${node.methodName}(${args.join(", ")})`
}

function ifStatementToCSharp(node: IfStatement, indentLevel: number) {
    if (node.ifBlock?.length == 1 && node.elseBlock?.length == 0) {
        return `${spaces(indentLevel)} if (${toCSharp(node.onExpression!, 0)}) ${toCSharp(node.ifBlock.at(0)!, 0)}`
    }
    var lines: string[] = [];

    lines.push(`${spaces(indentLevel)} if (${toCSharp(node.onExpression!, 0)})`);
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

export class TypeBuilder {
    typeDef: TypeDefinition;
    /**
     *
     */
    constructor(t: TypeDefinition) {
        this.typeDef = t;
    }

    addProperty(name: string, builder: (b: PropertyDefinition) => void) {
        var propertyDefinition = new PropertyDefinition();
        propertyDefinition.name = name;
        builder(propertyDefinition);
        this.typeDef.body.push({ nodeType: NodeType.PropertyDefinition, prop: propertyDefinition })
    }

    addMethod(name: string, builder: (md: MethodDefinition) => void) {
        var methodDefinition = new MethodDefinition();
        methodDefinition.name = name;
        builder(methodDefinition);
        this.typeDef.body.push({ nodeType: NodeType.MethodDefinition, method: methodDefinition });
    }
}

export function CreateType(name: string, builder: (b: TypeBuilder) => void) {
    var td = new TypeDefinition();
    td.name = name;
    var b = new TypeBuilder(td);
    builder(b);
    return b.typeDef;
}

export function stringLiteralNode(value: string): SyntaxNode {
    return { nodeType: NodeType.Literal, literal: new Literal("\"" + value + "\"") };
}

export function trueLiteralNode(): SyntaxNode {
    return { nodeType: NodeType.Literal, literal: new Literal("true") };
}

export function identifierNode(name: string): SyntaxNode {
    return { nodeType: NodeType.Identifier, identifier: new Identifier(name) };
}

export function FunctionCallNode(onIdentifier: string, functionName: string, ...args: SyntaxNode[]): SyntaxNode {
    var call = new Call();
    call.onInstance = new Identifier(onIdentifier);
    call.methodName = functionName;
    call.arguments.push(...args);
    return { nodeType: NodeType.Call, call: call };
}

export function ReturnNode(returnExpression?: SyntaxNode): SyntaxNode {
    var returnKeyword = new ReturnKeyword();
    if (returnExpression) {
        returnKeyword.expression = returnExpression;
    }

    return { nodeType: NodeType.ReturnKeyword, keyword: returnKeyword };
}

export function NewKeywordNode(type: TypeReference): SyntaxNode {
    var newKeyword = new NewKeyword();
    newKeyword.expression = { nodeType: NodeType.TypeReference, typeRef: type };
    return { nodeType: NodeType.NewKeyword, keyword: newKeyword };
}

export function MethodDefinitionNode(name: string, returnType: TypeReference, buildMethod?: (m: MethodDefinition) => void): SyntaxNode {
    var outMethod = new MethodDefinition();
    outMethod.returnType = returnType;
    outMethod.name = name;
    if (buildMethod) {
        buildMethod(outMethod);
    }

    return { nodeType: NodeType.MethodDefinition, method: outMethod };
}

export function ifNode(onExpression: SyntaxNode, ifTrue: (ifBlock: SyntaxNode[]) => void, ifFalse?: (ifBlock: SyntaxNode[]) => void): SyntaxNode {

    var ifStatement = new IfStatement();
    ifStatement.onExpression = onExpression;
    ifTrue(ifStatement.ifBlock!);
    if (ifFalse) {
        ifFalse(ifStatement.elseBlock);
    }

    return { nodeType: NodeType.IfStatement, ifStatement: ifStatement };
}

export function commentNode(summary: string, add?: (lines: string[]) => void): SyntaxNode {
    var comment = new Comment();
    comment.lines.push("<summary>");
    comment.lines.push(summary);
    comment.lines.push("</summary>");
    if (add) add(comment.lines);
    return { nodeType: NodeType.Comment, comment: comment };
}

export function newLineNode(): SyntaxNode {
    return { nodeType: NodeType.NewLine };
}

export function getSystemStringType(): TypeReference {
    return new TypeReference({name : "string"});
}

export function getSystemIntType(): TypeReference {
    return new TypeReference({name : "int"});
}

export function getSystemDecimalType(): TypeReference {
    return new TypeReference({name : "decimal"});
}

export function getSystemBoolType(): TypeReference {
    return new TypeReference({name : "bool"});
}

export function getVoidType(): TypeReference {
    return new TypeReference({name: "void"});
}


export function getDictionaryType(keyType: TypeReference, value: TypeReference): TypeReference {
    var outType = new TypeReference({name: "Dictionary", namespace: "System.Collections.Generic"});
    outType.typeArguments.push(keyType);
    outType.typeArguments.push(value);
    return outType;
}

export function getListType(itemType: TypeReference): TypeReference {
    var outType = new TypeReference({name: "List", namespace : "System.Collections.Generic"});
    outType.typeArguments.push(itemType);
    return outType;
}

export function getActionType(onType: TypeReference) {
    var action = new TypeReference({name : "Action", namespace : "System"});
    action.typeArguments.push(onType);
    return action;
}

export function getTypeReference(name:string, namespace?: string) : TypeReference {
    return new TypeReference({name, namespace});
}
export function getGenericType(baseType:TypeReference, typeArguments: TypeReference[]) : TypeReference {
    var clone = {...baseType};
    clone.typeArguments.push(...typeArguments);
    return clone;
}