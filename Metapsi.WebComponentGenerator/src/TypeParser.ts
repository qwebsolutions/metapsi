import { exit } from "process";
import * as ts from "typescript";
import * as path from "path";

const mainTypeName = "TempType";

export class TypeHandler {
    onType?: (jsType: string) => void;
    onLiteral?: (literal: string, jsType: string) => void;
    // parsing the function just not seems to be worth it
    onFunction?: (fText: string) => void;
    onArray?: (itemJsType: string) => void;
}

function handleType(typeNode: ts.TypeNode, checker: ts.TypeChecker, typeHandler: TypeHandler): void {
    if (typeNode.getFullText().includes("Play")) {
        //console.log(typeNode.getFullText());
    }
    // explicit primitive types
    switch (typeNode.kind) {
        case ts.SyntaxKind.UndefinedKeyword:
            // Ignore 'undefined' type
            return;
        case ts.SyntaxKind.NullKeyword:
            // Ignore 'null' type
            return;
        case ts.SyntaxKind.BooleanKeyword:
            typeHandler.onType!("boolean");
            return;
        case ts.SyntaxKind.StringKeyword:
            typeHandler.onType!("string");
            return;
        case ts.SyntaxKind.NumberKeyword:
            typeHandler.onType!("number");
            return;
    }

    // recurse on union type
    if (ts.isUnionTypeNode(typeNode)) {
        typeNode.types.forEach(t => handleType(t, checker, typeHandler));
        return;
    }

    // literals can be of any type
    if (ts.isLiteralTypeNode(typeNode)) {
        switch (typeNode.literal.kind) {
            case ts.SyntaxKind.StringLiteral:
                typeHandler.onLiteral!(typeNode.literal.text, "string");
                return;
            case ts.SyntaxKind.NumericLiteral:
                typeHandler.onLiteral!(typeNode.literal.text, "number");
                return;
            case ts.SyntaxKind.NullKeyword:
                // Ignore 'null' type
                return;
            default:
                throw `Literal SyntaxKind ${typeNode.literal.kind} not supported!`
        }
    }

    if(ts.isTypeLiteralNode(typeNode)) {
        typeHandler.onType!(typeNode.getText());
        return;
    }
    if (ts.isFunctionTypeNode(typeNode)) {
        typeHandler.onFunction!(typeNode.getFullText());
        return;
    }
    if (ts.isArrayTypeNode(typeNode)) {
        typeHandler.onArray!(typeNode.elementType.getText());
        return;
        // if (ts.isTypeReferenceNode(typeNode.elementType)) {
        //     //if(ts.isTypeReferenceNode(typeNode.elementType.typeName))
        //     typeHandler.onArray!(typeNode.elementType.typeName.getText());
        //     return;
        // }
        // typeNode.elementType.getText();
    }
    if (ts.isTypeAliasDeclaration(typeNode)) {
        console.log("Direct type alias");
        throw "Not implemented";
    }

    if(ts.isIntersectionTypeNode(typeNode)) {
        console.log(typeNode.getText());
    }

    if (ts.isTypeReferenceNode(typeNode)) {
        if (ts.isIdentifier(typeNode.typeName)) {
            var symbolAtLocation = checker.getSymbolAtLocation(typeNode.typeName);
            if (symbolAtLocation) {
                if (symbolAtLocation.declarations) {
                    for (var declaration of symbolAtLocation.declarations) {
                        if (ts.isTypeAliasDeclaration(declaration)) {
                            handleType(declaration.type, checker, typeHandler);
                            return;
                        }
                        if (ts.isInterfaceDeclaration(declaration)) {
                            typeHandler.onType!(declaration.name.text);
                            //handleType(checker.getDeclaredTypeOfSymbol(declaration.symbol), checker, typeHandler);
                            return;
                        }
                    }
                }
            }
        }

        // if no reference to the type was found, just use the type name as text and hope for the best
        typeHandler.onType!(typeNode.typeName.getText());
        return;
    }

    throw `SyntaxKind ${typeNode.kind} not supported in ${typeNode}!`
}

export type ConstituentType =
    { kind: "literal", type: string, value: string } |
    { kind: "type", type: string } |
    { kind: "array", itemType: string } |
    { kind: "function", text: string }

export function getConstituentTypes(typeDefinition: string) {
    var outList: ConstituentType[] = [];
    var typeHandler: TypeHandler = new TypeHandler();
    typeHandler.onLiteral = (value, jsType) => {
        outList.push({ kind: "literal", type: jsType, value })
    }
    typeHandler.onType = (jsType: string) => {
        outList.push({ kind: "type", type: jsType });
    }
    typeHandler.onArray = (itemType: string) => {
        outList.push({ kind: "array", itemType })
    }
    typeHandler.onFunction = (fnText: string) => {

        outList.push({ kind: "function", text: fnText });
    }
    handleTypeDefinition(typeDefinition, typeHandler);
    return outList;
}

export function handleTypeDefinition(typeDefinition: string, typeHandler: TypeHandler): void {
    try {
        var typeAnalyzer = parseTypeText(typeDefinition);
        handleType(typeAnalyzer.mainType!, typeAnalyzer.typeChecker!, typeHandler);
    }
    catch (ex) {
        console.log(typeDefinition)
        throw ex;
    }
}

class TypeAnalyzer {
    tempType?: ts.TypeNode;
    mainType?: ts.TypeNode;
    typeChecker?: ts.TypeChecker;
}

export function parseTypeText(typeText: string): TypeAnalyzer {
    // Create a virtual source file with a type alias declaration
    const sourceCode = `type ${mainTypeName}=${typeText};`;

    // if (sourceCode.includes("Playback")) {
    //     console.log(sourceCode);
    // }

    // Create a SourceFile object from the string
    const sourceFile = ts.createSourceFile(
        "temp.ts",
        sourceCode,
        ts.ScriptTarget.ESNext,
    /*setParentNodes*/ true,
        ts.ScriptKind.TS
    );
    // Identical to current tsconfig.json

    const options: ts.CompilerOptions = loadTsConfig().compilerOptions;
    var defaultHost = ts.createCompilerHost(options);
    var compilerHost = {
        ...defaultHost,
        getSourceFile: (fileName: string, languageVersion: ts.ScriptTarget | ts.CreateSourceFileOptions) => {
            if (fileName === "temp.ts") {
                return sourceFile;
            }
            var file = defaultHost.getSourceFile(fileName, languageVersion);
            return file;
        }
    };

    const program = ts.createProgram(["temp.ts"], options, compilerHost);
    var typeChecker = program.getTypeChecker();

    // var allFiles = program.getSourceFiles();
    // for (var f of allFiles) {
    //     //console.log(f.fileName);
    // }

    var outAnalyzer = new TypeAnalyzer();
    outAnalyzer.typeChecker = typeChecker;

    if (sourceCode.includes("Play")) {
        var syntactic = program.getSemanticDiagnostics();
        for (var error of syntactic) {
            console.error(error.messageText);
        }
        if (syntactic.length) {
            exit(0);
        }
        var semantic = program.getSyntacticDiagnostics();


    }

    var symbols = typeChecker.getSymbolsInScope(sourceFile, ts.SymbolFlags.Type);
    var currentType = symbols.find(sym => sym.name == mainTypeName);
    var declaration = currentType?.declarations![0];
    if (ts.isTypeAliasDeclaration(declaration!)) {
        outAnalyzer.mainType = declaration.type;
    }

    return outAnalyzer;
}

function loadTsConfig(currentDir = process.cwd()) {
    // 1. Find the tsconfig.json file path starting from currentDir
    const configFilePath = ts.findConfigFile(
        currentDir,
        ts.sys.fileExists,
        "tsconfig.json"
    );
    if (!configFilePath) {
        throw new Error("Could not find a tsconfig.json file.");
    }

    // 2. Read the tsconfig.json file content and parse it
    const configFile = ts.readConfigFile(configFilePath, ts.sys.readFile);
    if (configFile.error) {
        throw new Error(ts.formatDiagnosticsWithColorAndContext([configFile.error], {
            getCurrentDirectory: ts.sys.getCurrentDirectory,
            getCanonicalFileName: (f) => f,
            getNewLine: () => ts.sys.newLine,
        }));
    }

    // 3. Parse the JSON config content into compiler options and file list
    const parsedConfig = ts.parseJsonConfigFileContent(
        configFile.config,
        ts.sys,
        path.dirname(configFilePath)
    );

    if (parsedConfig.errors.length > 0) {
        throw new Error(ts.formatDiagnosticsWithColorAndContext(parsedConfig.errors, {
            getCurrentDirectory: ts.sys.getCurrentDirectory,
            getCanonicalFileName: (f) => f,
            getNewLine: () => ts.sys.newLine,
        }));
    }

    // 4. Return the parsed config object
    return {
        configFilePath,
        compilerOptions: parsedConfig.options,
        fileNames: parsedConfig.fileNames,
        errors: parsedConfig.errors,
    };
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