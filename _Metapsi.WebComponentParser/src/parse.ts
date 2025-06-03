import * as ts from "typescript";
import * as fs from "fs";

import * as schema from 'custom-elements-manifest/schema';

const customElementManifestSchema = require('custom-elements-manifest');

function parseTypeScript(sourceCode: string) {
  const sourceFile = ts.createSourceFile(
    "file.ts",
    sourceCode,
    ts.ScriptTarget.Latest,
    true,
    ts.ScriptKind.TS
  );
  return sourceFile;
}

// Example usage:
var code = `
interface User {
  name: string;
  age: number;
}
`;

code = `export interface RadioGroupChangeEventDetail<T = any> {\n  value: T;\n  event?: Event;\n}`

fs.truncateSync('output.ts', 0);

function visit(node: ts.Node) {

const jsonSafe = {
  kind: ts.SyntaxKind[node.kind],
  text: node.getText(),
  // add other properties you want
};

	//console.log(node);
  //const printer = ts.createPrinter({ newLine: ts.NewLineKind.LineFeed });
  // Print the interface node as TypeScript code
  //const printedCode = printer.printNode(ts.EmitHint.Unspecified, node, sourceFile);	
	fs.appendFileSync("output.ts", JSON.stringify(jsonSafe), { encoding: "utf-8" });
	fs.appendFileSync("output.ts", "\n", { encoding: "utf-8" });
	children: node.getChildren().map(visit)
  // Extract relevant info from node, e.g. kind and text
//  return {
//    kind: ts.SyntaxKind[node.kind],
//    text: node.getText(),
//    children: node.getChildren().map(visit)
//  };
}

const ast = parseTypeScript(code);
const simplifiedAst = visit(ast);
//console.log(JSON.stringify(simplifiedAst, null, 2));



//console.log(JSON.stringify(ast, null, 2));