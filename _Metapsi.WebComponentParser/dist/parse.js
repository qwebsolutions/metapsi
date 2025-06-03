"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || (function () {
    var ownKeys = function(o) {
        ownKeys = Object.getOwnPropertyNames || function (o) {
            var ar = [];
            for (var k in o) if (Object.prototype.hasOwnProperty.call(o, k)) ar[ar.length] = k;
            return ar;
        };
        return ownKeys(o);
    };
    return function (mod) {
        if (mod && mod.__esModule) return mod;
        var result = {};
        if (mod != null) for (var k = ownKeys(mod), i = 0; i < k.length; i++) if (k[i] !== "default") __createBinding(result, mod, k[i]);
        __setModuleDefault(result, mod);
        return result;
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
const ts = __importStar(require("typescript"));
const fs = __importStar(require("fs"));
const customElementManifestSchema = require('custom-elements-manifest');
function parseTypeScript(sourceCode) {
    const sourceFile = ts.createSourceFile("file.ts", sourceCode, ts.ScriptTarget.Latest, true, ts.ScriptKind.TS);
    return sourceFile;
}
// Example usage:
var code = `
interface User {
  name: string;
  age: number;
}
`;
code = `export interface RadioGroupChangeEventDetail<T = any> {\n  value: T;\n  event?: Event;\n}`;
fs.truncateSync('output.ts', 0);
function visit(node) {
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
    children: node.getChildren().map(visit);
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
