import * as ts from "typescript";
import * as fsp from "fs/promises";
import * as fs from "fs";
import * as path from "path";
import * as gen from 'metapsi-csharp-generator'

var configFilePath = "c:/github/qwebsolutions/metapsi/Metapsi.Luxon.Generate/tsconfig.json";

var luxonLibPath = "c:/github/qwebsolutions/metapsi/Metapsi.Luxon.Generate/node_modules/@types/luxon";

var csOutPath = "c:/github/qwebsolutions/metapsi/Metapsi.Luxon/generated";

try {
    await fsp.rm(csOutPath, { recursive: true, force: true });
} catch (err) {
    console.error(`Output folder ${csOutPath} not removed`, err);
}

fs.mkdirSync(csOutPath);

var configFile = ts.readConfigFile(configFilePath, ts.sys.readFile);

const configParseResult = ts.parseJsonConfigFileContent(
    configFile.config,
    ts.sys,
    //path.dirname(configFilePath)
    luxonLibPath
);

const program = ts.createProgram({
    rootNames: configParseResult.fileNames,
    options: configParseResult.options,
});

const checker = program.getTypeChecker();

console.log(program.getSourceFiles().length);

var outFiles: Map<string, string> = new Map<string, string>();

for (const sourceFile of program.getSourceFiles()) {
    // Ignore lib files
    //if (sourceFile.isDeclarationFile) continue;

    ts.forEachChild(sourceFile, function visit(node) {
        if (sourceFile.fileName.includes("luxon")) {
            if (ts.isClassDeclaration(node)) {
                if (node.name?.text == "DateTime") {
                    var classDefinition = CreateClassDefinition(node);

                    var csFile: gen.File = {
                        namespace: "Metapsi.Luxon",

                        content: [
                            { nodeType: gen.NodeType.TypeDefinition, definition: classDefinition }
                        ],
                        usings: ["Metapsi.Syntax", "Metapsi.Html"]
                    };



                    var typeName = node.name?.getText()!;
                    outFiles.set(typeName + ".cs", gen.fileToCSharp(csFile));


                    //console.log(gen.fileToCSharp(csFile));

                }
            }

            // if (ts.isTypeAliasDeclaration(node) || ts.isInterfaceDeclaration(node) || ts.isClassDeclaration(node)) {


            //     if (node.name?.text == "DateTime") {
            //         console.log("Date time!")
            //         const symbol = checker.getSymbolAtLocation(node);
            //         if (symbol) {
            //             // Print the name of the type or interface
            //             //console.log(`Type: ${symbol.getName()}`);

            //             // Optionally, get its type and print a string representation
            //             const type = checker.getTypeAtLocation(node);
            //             const typeString = checker.typeToString(type);
            //             //console.log(`Structure: ${typeString}\n`);
            //         }

            //         ts.forEachChild(node, visit);
            //     }
            // }

            // if (ts.isMethodDeclaration(node)) {
            //     var signature = checker.getSignatureFromDeclaration(node);
            //     for (var p of signature?.getParameters()!) {
            //         var paramType = checker.getTypeOfSymbolAtLocation(p, node);
            //         //console.log("  " + p.name)
            //     }

            //     var returnType = checker.getReturnTypeOfSignature(signature!);//) signature?.getReturnType();
            //     //console.log(checker.typeToString(returnType));
            //     //console.log(signature?.parameters);
            //     //console.log(node.name.getText());
            // }

            // if (ts.isGetAccessorDeclaration(node)) {
            //     const isStatic = node.modifiers?.some(mod => mod.kind === ts.SyntaxKind.StaticKeyword);
            //     if (isStatic) {
            //         console.log(GenerateStaticProperty(node))
            //     }
            //     else {
            //         console.log(GenerateInstanceProperty(node));
            //     }
            // }
        }
    });
}

for (var fileName of outFiles.keys()) {
    await fsp.writeFile(path.join(csOutPath, fileName), outFiles.get(fileName)!, "utf-8");
}

function isConditionalType(type: ts.Type): type is ts.ConditionalType {
    return (type.flags & ts.TypeFlags.Conditional) !== 0;
}

function isBooleanType(type: ts.Type): type is ts.ConditionalType {
    return (type.flags & ts.TypeFlags.Boolean) !== 0;
}

function IsLuxonIfValidConditionalType(condType: ts.ConditionalType): boolean {
    return condType.aliasSymbol?.name == "IfValid";
    //return checker.typeToString(condType.checkType) == "IsValid";
}

function GetReturnType(tsType: ts.SignatureDeclarationBase, propertyName: string, className: string): gen.TypeReference {
    var typeDef = checker.getTypeAtLocation(tsType);

    if (isBooleanType(typeDef)) {
        return gen.systemBool;
    }

    console.log(checker.typeToString(typeDef));
    if (isConditionalType(typeDef)) {
        if (IsLuxonIfValidConditionalType(typeDef)) {
            var validType = checker.typeToString(typeDef.aliasTypeArguments![0]);
            console.log(validType)

            if (validType == "null") {
                validType = checker.typeToString(typeDef.aliasTypeArguments![1]);
            }

            if (validType == "true") {
                return gen.systemBool;
            }

            if (validType == "boolean") {
                return gen.systemBool
            }

            if (validType == "string") {
                return gen.systemString
            }

            if (validType == "string | null") {
                return gen.systemString
            }

            if (validType == "number") {
                if (propertyName == "year") {
                    return gen.systemInt
                }

                if (propertyName == "millisecond") {
                    return gen.systemInt
                }

                if (propertyName == "weekYear") {
                    return gen.systemInt
                }

                if (propertyName == "localWeekNumber") {
                    return gen.systemInt
                }

                if (propertyName == "localWeekYear") {
                    return gen.systemInt
                }

                if (propertyName == "ordinal") {
                    return gen.systemInt
                }

                if (propertyName == "offset") {
                    return gen.systemInt
                }
            }

            if (validType == "QuarterNumbers") {
                return gen.systemInt
            }

            if (validType == "MonthNumbers") {
                return gen.systemInt
            }

            if (validType == "WeekNumbers") {
                return gen.systemInt
            }

            if (validType == "WeekdayNumbers") {
                return gen.systemInt
            }

            if (validType == "DayNumbers") {
                return gen.systemInt
            }

            if (validType == "HourNumbers") {
                return gen.systemInt
            }

            if (validType == "SecondNumbers") {
                return gen.systemInt
            }

            if (validType == "PossibleDaysInMonth") {
                return gen.systemInt
            }

            if (validType == "PossibleDaysInYear") {
                return gen.systemInt
            }

            if (validType == "PossibleWeeksInYear") {
                return gen.systemInt
            }
        }
    }

    var typeSymbol = typeDef.getSymbol();
    if (typeSymbol) {
        if (typeSymbol.name == "Zone") {
            return { name: "Zone" }
        }
    }

    throw new Error(checker.typeToString(typeDef))
}

function GenerateInstanceProperty(className: string, accessor: ts.GetAccessorDeclaration): gen.MethodDefinition {

    var propertyName = accessor.name.getText();
    console.log(className + "." + propertyName);
    var returnType = GetReturnType(accessor, propertyName, className);//  { namespace: "", name: accessor.type?.getText()! }
    console.log(returnType);

    return {
        name: propertyName,
        isStatic: true,
        visibility: "public",
        returnType: { ...gen.varType, typeArguments: [returnType] },
        parameters: [{ isThis: true, name: "b", type: ObjBuilderType(className) }],
        body: [
            gen.returnNode(
                gen.functionCallNode(
                    "b",
                    "GetProperty<" + returnType.name + ">",
                    gen.stringLiteralNode(propertyName)
                )
            )
        ]
    }
}

function ClassBuilderType(className: string): gen.TypeReference {
    return {
        name: "ObjBuilder",
        typeArguments: [{
            ...gen.varType,
            typeArguments: [{ name: "ClassDef", typeArguments: [{ name: className }] }]
        }]
    }
}

function ObjBuilderType(className: string): gen.TypeReference {
    return {
        name: "ObjBuilder",
        typeArguments: [{
            ...gen.varType,
            typeArguments: [{ name: className }]
        }]
    }
}

function GenerateStaticProperty(className: string, accessor: ts.GetAccessorDeclaration): gen.MethodDefinition {
    //console.log(accessor.type);

    var propertyName = accessor.name.getText();
    var returnType = { namespace: "Metapsi.Html", name: accessor.type?.getText()! }

    return {
        name: propertyName,
        isStatic: true,
        visibility: "public",
        returnType: { ...gen.varType, typeArguments: [returnType] },
        parameters: [{ isThis: true, name: "b", type: ClassBuilderType(className) }],
        body: [
            gen.returnNode(
                gen.functionCallNode(
                    "b",
                    "GetProperty<" + returnType.name + ">",
                    gen.stringLiteralNode(propertyName)
                )
            )
        ]
    }
}

function CreateClassDefinition(node: ts.ClassDeclaration): gen.TypeDefinition {


    var typeName = node.name?.getText()!;
    var extensionClassName = typeName + "Extensions";

    var staticProperties: gen.SyntaxNode[] = [];
    var instanceProperties: gen.SyntaxNode[] = [];

    ts.forEachChild(node, (node) => {
        if (ts.isGetAccessorDeclaration(node)) {
            const isStatic = node.modifiers?.some(mod => mod.kind === ts.SyntaxKind.StaticKeyword);
            if (isStatic) {
                staticProperties.push(gen.methodDefinitionNode(GenerateStaticProperty(typeName, node)))
            }
            else {
                instanceProperties.push(gen.methodDefinitionNode(GenerateInstanceProperty(typeName, node)));
            }
        }
    });

    var outClass: gen.TypeDefinition = {
        name: extensionClassName,
        isStatic: false,
        isPartial: true,
        body: [...staticProperties, ...instanceProperties]
    }

    return outClass;
}