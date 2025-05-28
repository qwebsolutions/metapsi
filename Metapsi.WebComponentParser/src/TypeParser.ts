import * as ts from "typescript";

export class TypeHandler {
    onUnion:(union:ts.UnionTypeNode) => boolean = (union) => false;
    onString?: () => void;
    onStringLiteral?: (literal: string) => void;
    onBoolean?: () => void;
    onFunction?: (f: ts.FunctionOrConstructorTypeNode) => void;
    onArray?: (item: ts.TypeNode) => void;
    onTypeReference?: (type: ts.EntityName) => void;
}

export function handleType(typeNode: ts.TypeNode, typeHandler: TypeHandler): void {

    // explicit primitive types
    switch(typeNode.kind){
        case ts.SyntaxKind.UndefinedKeyword:
            // Ignore 'undefined' type
            return;
        case ts.SyntaxKind.BooleanKeyword:
            typeHandler.onBoolean!();
            return;
        case ts.SyntaxKind.StringKeyword:
            typeHandler.onString!();
            return;
    } 

    // recurse on union type
    if (ts.isUnionTypeNode(typeNode)) {
        var stop = typeHandler.onUnion(typeNode);
        if(!stop){
            typeNode.types.forEach(t => handleType(t, typeHandler));
        }
        return;
    }

    // literals can be of any type
    if (ts.isLiteralTypeNode(typeNode)) {
        switch(typeNode.literal.kind) {
            case ts.SyntaxKind.StringLiteral:
                typeHandler.onStringLiteral!(typeNode.literal.text);
                return;
        default:
            throw `Literal SyntaxKind ${typeNode.literal.kind} not supported!`
        }
    }

    if (ts.isFunctionTypeNode(typeNode)) {
        typeHandler.onFunction!(typeNode);
        return;
    } 
    if (ts.isArrayTypeNode(typeNode)) {
        typeHandler.onArray!(typeNode.elementType);
        return;
    }
    if (ts.isTypeReferenceNode(typeNode)) {
        typeHandler.onTypeReference!(typeNode.typeName);
        return;
    } 

    throw `SyntaxKind ${typeNode.kind} not supported in ${typeNode}!`
}

export function handleTypeDefinition(typeDefinition: string, typeHandler: TypeHandler) : void {
    try{
        var type = parseTypeText(typeDefinition);
        handleType(type, typeHandler);
    }
    catch(ex){
        console.log(typeDefinition)
        throw ex;
    }
}

export function parseTypeText(typeText: string) {
  // Create a virtual source file with a type alias declaration
  const sourceCode = `type TempType = ${typeText};`;

  // Create a SourceFile object from the string
  const sourceFile = ts.createSourceFile(
    "temp.ts",
    sourceCode,
    ts.ScriptTarget.Latest,
    /*setParentNodes*/ true,
    ts.ScriptKind.TS
  );

  // Find the TypeAliasDeclaration node
  let typeNode: ts.TypeNode | undefined;

  ts.forEachChild(sourceFile, node => {
    if (ts.isTypeAliasDeclaration(node) && node.name.text === "TempType") {
      typeNode = node.type;
    }
  });

  if (!typeNode) {
    throw new Error("Type node not found");
  }

  
//   // Check if the type is a union type
//   if (ts.isUnionTypeNode(typeNode)) {
//     console.log("Type is a union with members:");
//     typeNode.types.forEach(t => {
//       console.log(" -", t.getText());
//     });
//   } else {
//     console.log("Type is not a union. It is:", typeNode.getText());
//   }

  return typeNode;
}

// export function getJsDocSummary(jsDoc: string) : string {

//   const sourceCode = `${jsDoc}\ntype TempType = undefined;`;

//   // Create a SourceFile object from the string
//   const sourceFile = ts.createSourceFile(
//     "temp.ts",
//     sourceCode,
//     ts.ScriptTarget.Latest,
//     /*setParentNodes*/ true,
//     ts.ScriptKind.TS
//   );

//   ts.forEachChild(sourceFile, node => {
//     console.log(node);
//   });

//   return "";
// }