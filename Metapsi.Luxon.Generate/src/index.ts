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
                if (node.name?.text == "DateTime" || node.name?.text == "Interval" || node.name?.text == "Duration") {
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

function isStringType(type: ts.Type): boolean {
    var typeString = checker.typeToString(type);
    if (typeString == "string")
        return true;

    if (typeString == "string | null")
        return true;

    return false;
}

function isLocaleOptions(type: ts.Type) {
    var typeString = checker.typeToString(type);
    if (typeString == "Required<LocaleOptions>")
        return true;

    return false;
}

function IsLuxonIfValidConditionalType(condType: ts.ConditionalType): boolean {
    return condType.aliasSymbol?.name == "IfValid";
    //return checker.typeToString(condType.checkType) == "IsValid";
}

function isDateTime(typeDef: ts.Type): boolean {
    var symbol = typeDef.symbol;
    if (symbol)
        if (symbol.name == "DateTime")
            return true;

    if (checker.typeToString(typeDef) == "DateTime<true> | DateTime<false>") {
        return true;
    }

    if (checker.typeToString(typeDef) == "DateTime<true>") {
        return true;
    }

    if (checker.typeToString(typeDef) == "PickedDateTime<Values>") {
        return true;
    }

    return false;
}

function isDuration(typeDef: ts.Type): boolean {
    var symbol = typeDef.symbol;
    if (symbol)
        if (symbol.name == "Duration")
            return true;

    if (checker.typeToString(typeDef) == "Duration<IsValid>") {
        return true;
    }

    if (checker.typeToString(typeDef) == "Duration<true> | Duration<false>") {
        return true;
    }

    return false;
}

function isInterval(typeDef: ts.Type): boolean {
    var symbol = typeDef.symbol;
    if (symbol)
        if (symbol.name == "Interval")
            return true;

    if (checker.typeToString(typeDef) == "Interval<false>") {
        return true;
    }

    if (checker.typeToString(typeDef) == "Interval<true> | Interval<false>") {
        return true;
    }

    if (checker.typeToString(typeDef) == "Interval<boolean> | null") {
        return true;
    }

    return false;
}

function GetReturnType(typeDef: ts.Type, propertyName: string, className: string): gen.TypeReference {
    // if (propertyName == "local") {
    //     return { name: "DateTime" }
    // }

    // if (propertyName == "utc") {
    //     return { name: "DateTime" }
    // }


    if (propertyName == "get") {
        return gen.systemInt
    }

    if (isDateTime(typeDef)) {
        return { name: "DateTime" }
    }

    if (isDuration(typeDef)) {
        return { name: "Duration" }
    }

    if (isInterval(typeDef)) {
        return { name: "Interval" }
    }

    if (isBooleanType(typeDef)) {
        return gen.systemBool;
    }

    if (isStringType(typeDef)) {
        return gen.systemString
    }

    if (isLocaleOptions(typeDef)) {
        return { name: "LocaleOptions" }
    }

    if (checker.typeToString(typeDef) == "this[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: className }] }
    }

    if (checker.typeToString(typeDef) == "DateTimeFormatPart[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "Intl.DateTimeFormatPart" }] }
    }

    if (checker.typeToString(typeDef) == "Date") {
        return { name: "Date", namespace: "Metapsi.Html" }
    }

    if (checker.typeToString(typeDef) == "ToObjectOutput<IncludeConfig, IsValid>") {
        return { name: "object" }
    }

    if (checker.typeToString(typeDef) == "(Interval<true> | Interval<false>)[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "Interval" }] }
    }

    //console.log(checker.typeToString(typeDef));
    if (isConditionalType(typeDef)) {
        if (IsLuxonIfValidConditionalType(typeDef)) {
            var validType = checker.typeToString(typeDef.aliasTypeArguments![0]);
            //console.log(validType)

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

            if (validType == "DateTime<true>") {
                return { name: "DateTime" }
            }

            if (validType == "Interval<boolean>[]") {
                return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "Interval" }] }
            }

            if (validType == "number") {
                if (propertyName == "year") {
                    return gen.systemInt
                }

                if (propertyName == "years") {
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

                if (propertyName == "valueOf") {
                    return gen.systemInt
                }

                if (propertyName == "toMillis") {
                    return gen.systemInt
                }

                if (propertyName == "toSeconds") {
                    return gen.systemInt
                }

                if (propertyName == "toUnixInteger") {
                    return gen.systemInt
                }

                if (propertyName == "as") {
                    return gen.systemInt
                }

                if (propertyName == "quarters") {
                    return gen.systemInt;
                }

                if (propertyName == "months") {
                    return gen.systemInt
                }

                if (propertyName == "weeks") {
                    return gen.systemInt
                }

                if (propertyName == "days") {
                    return gen.systemInt
                }

                if (propertyName == "hours") {
                    return gen.systemInt
                }

                if (propertyName == "minutes") {
                    return gen.systemInt
                }

                if (propertyName == "seconds") {
                    return gen.systemInt
                }

                if (propertyName == "milliseconds") {
                    return gen.systemInt
                }

                if (propertyName == "length") {
                    return gen.systemInt
                }

                if (propertyName == "count") {
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

            if (validType == "Interval<true>") {
                return { name: "Interval" }
            }
        }
    }

    var typeSymbol = typeDef.getSymbol();
    if (typeSymbol) {
        if (typeSymbol.name == "Zone") {
            return { name: "Zone" }
        }
        if (typeSymbol.name == "DateTime") {
            return { name: "DateTime" }
        }

        if (typeSymbol.name == "ExplainedFormat") {
            return { name: "ExplainedFormat" }
        }

        if (typeSymbol.name == "TokenParser") {
            return { name: "TokenParser" }
        }

        if (typeSymbol.name == "DurationObjectUnits") {
            return { name: "DurationObjectUnits" }
        }
    }

    throw new Error(checker.typeToString(typeDef))
}

function GenerateInstanceProperty(className: string, accessor: ts.GetAccessorDeclaration): gen.MethodDefinition {

    var propertyName = accessor.name.getText();
    //console.log(className + "." + propertyName);
    var typeDef = checker.getTypeAtLocation(accessor);
    var returnType = GetReturnType(typeDef, propertyName, className);//  { namespace: "", name: accessor.type?.getText()! }
    //console.log(returnType);

    return {
        name: propertyName,
        isStatic: true,
        visibility: "public",
        returnType: { name: "ObjBuilder", typeArguments: [returnType] },
        parameters: [{ isThis: true, name: "b", type: ObjBuilderType(className) }],
        body: [
            gen.returnNode(
                gen.functionCallNode(
                    "b",
                    "Get<" + returnType.name + ">",
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
            name: "ClassDef", typeArguments: [{ name: className }]
        }]
    }
}

function ObjBuilderType(className: string): gen.TypeReference {
    return {
        name: "ObjBuilder",
        typeArguments: [{ name: className }]
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
        returnType: { name: "ObjBuilder", typeArguments: [returnType] },
        parameters: [{ isThis: true, name: "b", type: ClassBuilderType(className) }],
        body: [
            gen.returnNode(
                gen.functionCallNode(
                    "b",
                    "Get<" + returnType.name + ">",
                    gen.stringLiteralNode(propertyName)
                )
            )
        ]
    }
}



function GenerateStaticMethod(className: string, md: ts.MethodDeclaration): gen.MethodDefinition {
    console.log(md.getText());

    // Returns the type of the method itself
    //var typeDef = checker.getTypeAtLocation(md);

    var typeDef = checker.getReturnTypeOfSignature(checker.getSignatureFromDeclaration(md)!);
    var methodName = md.name.getText();
    var returnType = GetReturnType(typeDef, methodName, className);
    //var returnType = { namespace: "Metapsi.Html", name: accessor.type?.getText()! }

    return {
        name: methodName,
        isStatic: true,
        visibility: "public",
        returnType: { name: "ObjBuilder", typeArguments: [returnType] },
        parameters: [{ isThis: true, name: "b", type: ClassBuilderType(className) }],
        body: [
            gen.returnNode(
                gen.functionCallNode(
                    "b",
                    "Call<" + returnType.name + ">",
                    gen.stringLiteralNode(methodName)
                )
            )
        ]
    }
}

function GenerateInstanceMethod(className: string, md: ts.MethodDeclaration): gen.MethodDefinition {
    console.log(md.getText());

    // Returns the type of the method itself
    //var typeDef = checker.getTypeAtLocation(md);

    var typeDef = checker.getReturnTypeOfSignature(checker.getSignatureFromDeclaration(md)!);
    var methodName = md.name.getText();
    var returnType = GetReturnType(typeDef, methodName, className);
    //var returnType = { namespace: "Metapsi.Html", name: accessor.type?.getText()! }

    return {
        name: methodName,
        isStatic: true,
        visibility: "public",
        returnType: { name: "ObjBuilder", typeArguments: [returnType] },
        parameters: [{ isThis: true, name: "b", type: ObjBuilderType(className) }],
        body: [
            gen.returnNode(
                gen.functionCallNode(
                    "b",
                    "Call<" + returnType.name + ">",
                    gen.stringLiteralNode(methodName)
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
    var staticMethods: gen.SyntaxNode[] = [];
    var instanceMethods: gen.SyntaxNode[] = []

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
        else if (ts.isMethodDeclaration(node)) {
            const isStatic = node.modifiers?.some(mod => mod.kind === ts.SyntaxKind.StaticKeyword);
            if (isStatic) {
                staticMethods.push(gen.methodDefinitionNode(GenerateStaticMethod(typeName, node)));
            }
            else {
                instanceMethods.push(gen.methodDefinitionNode(GenerateInstanceMethod(typeName, node)));
            }
        }
        else if (ts.isMethodSignature(node)) {
            console.log("Method signature");
        }
        else if (node.getText() == "export") {
            console.log("export");
        }
        else if (node.kind == ts.SyntaxKind.Identifier) {
            console.log(node.getText())
        }
        else if (node.kind == ts.SyntaxKind.TypeParameter) {
            console.log(node.getText())
        }
        else if (node.kind == ts.SyntaxKind.Constructor) {
            console.log("constructor");
        }
        else throw node.getText();
    });

    var outClass: gen.TypeDefinition = {
        name: extensionClassName,
        isStatic: true,
        isPartial: true,
        body: [...staticProperties, ...instanceProperties, ...staticMethods, ...instanceMethods]
    }

    return outClass;
}