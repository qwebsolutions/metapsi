/*
This handles the part of generating C#.
It just defines contracts for C# output.
It is not directly related to web components.
*/

export type AccessModifierKeyword =
    | "public"
    | "private"
    | "protected"
    | "internal"
    | "protected internal"
    | "private protected"
    | "file"
    | ""

type TypeDeclarationKeyword =
    | "class"
    | "struct"
    | "interface"
    | "enum"
    | "delegate"
    | "record";

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


export type Comment = {
    lines: string[]
}

export type ReturnKeyword = {
    expression?: SyntaxNode;
}

export type NewKeyword = {
    expression?: SyntaxNode
}

/**
 * The actual definition of a class/interface, with declaration & body
 */
export type TypeDefinition = {
    keyword?: TypeDeclarationKeyword
    name: string
    namespace?: string
    typeParameters?: TypeParameter[]
    isPartial?: boolean
    isStatic?: boolean
    visibility?: AccessModifierKeyword
    body: SyntaxNode[]
}

/**
 * A namespaceless type placeholder with type constraints
 */
export type TypeParameter = {
    name: string
    typeConstraints?: string[]
}

/**
 * Can represent generic types with typeArguments
 */
export type TypeReference = {
    name: string
    namespace?: string;
    typeArguments?: TypeReference[]
}

export type ConstantDefinition = {
    name: string
    type: TypeReference
    value: Literal
    visibility?: AccessModifierKeyword
}

export type PropertyDefinition = {
    name: string
    type: TypeReference
    visibility: AccessModifierKeyword
    isStatic?: boolean
}

export type MethodDefinition = {
    name: string
    returnType: TypeReference
    parameters?: Parameter[]
    typeParameters?: TypeParameter[]
    visibility?: AccessModifierKeyword
    isStatic?: boolean
    body: SyntaxNode[]
}

export type Parameter = {
    name: string
    type: TypeReference
    isParams?: boolean
    isThis?: boolean
}

export type Identifier = {
    identifier: string;
}

export type Literal = {
    value: string;
}

export type IfStatement =
    // at least one branch must exist
    | { onExpression: SyntaxNode, ifBlock: SyntaxNode[], elseBlock?: SyntaxNode[] }
    | { onExpression: SyntaxNode, ifBlock?: SyntaxNode[], elseBlock: SyntaxNode[] }

export type Call = {
    onInstance: Identifier;
    methodName: string;
    arguments?: SyntaxNode[]
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


// export class TypeBuilder {
//     typeDef: TypeDefinition;
//     /**
//      *
//      */
//     constructor(t: TypeDefinition) {
//         this.typeDef = t;
//     }

//     addProperty(name: string, builder: (b: PropertyDefinition) => void) {
//         var propertyDefinition = new PropertyDefinition();
//         propertyDefinition.name = name;
//         builder(propertyDefinition);
//         this.typeDef.body.push({ nodeType: NodeType.PropertyDefinition, prop: propertyDefinition })
//     }

//     addMethod(name: string, builder: (md: MethodDefinition) => void) {
//         var methodDefinition = new MethodDefinition();
//         methodDefinition.name = name;
//         builder(methodDefinition);
//         this.typeDef.body.push({ nodeType: NodeType.MethodDefinition, method: methodDefinition });
//     }
// }

// export function CreateType(name: string, builder: (b: TypeBuilder) => void) {
//     var td = new TypeDefinition();
//     td.name = name;
//     var b = new TypeBuilder(td);
//     builder(b);
//     return b.typeDef;
// }

export function stringLiteral(value: string): Literal {
    return { value: "\"" + value + "\"" }
}

export function stringLiteralNode(value: string): SyntaxNode {
    return { nodeType: NodeType.Literal, literal: { value: "\"" + value + "\"" } }
}

export function trueLiteralNode(): SyntaxNode {
    return { nodeType: NodeType.Literal, literal: { value: "true" } }
}

export function identifierNode(name: string): SyntaxNode {
    return { nodeType: NodeType.Identifier, identifier: { identifier: name } };
}

export function functionCallNode(onIdentifier: string, functionName: string, ...args: SyntaxNode[]): SyntaxNode {
    return {
        nodeType: NodeType.Call,
        call: {
            onInstance: { identifier: onIdentifier },
            methodName: functionName,
            arguments: args
        }
    };
}

export function returnNode(returnExpression?: SyntaxNode): SyntaxNode {
    return { nodeType: NodeType.ReturnKeyword, keyword: { expression: returnExpression } };
}

export function newKeywordNode(type: TypeReference): SyntaxNode {
    return {
        nodeType: NodeType.NewKeyword,
        keyword: {
            expression: {
                nodeType: NodeType.TypeReference, typeRef: type
            }
        }
    };
}

export function methodDefinitionNode(method: MethodDefinition): SyntaxNode {
    return { nodeType: NodeType.MethodDefinition, method }
}

export function ifNode(onExpression: SyntaxNode, ifTrue: SyntaxNode[], ifFalse?: SyntaxNode[]): SyntaxNode {
    return {
        nodeType: NodeType.IfStatement, ifStatement: {
            onExpression,
            ifBlock: ifTrue,
            elseBlock: ifFalse
        }
    };
}

export function commentNode(summary: string, lines?: string[]): SyntaxNode {
    return {
        nodeType: NodeType.Comment, comment: {
            lines: ["<summary>", summary, "</summary>", ...(lines ??[])]
        }
    }
}

export function newLineNode(): SyntaxNode {
    return { nodeType: NodeType.NewLine };
}

export function constantNode(c: ConstantDefinition) : SyntaxNode {
    return {nodeType: NodeType.ConstantDefinition, constant: c}
}