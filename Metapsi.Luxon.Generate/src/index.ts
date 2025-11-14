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

    if (typeString == "string | undefined")
        return true;

    if (typeString == "DateTimeUnit") {
        return true;
    }

    return false;
}

function isLocaleOptions(type: ts.Type) {
    var typeString = checker.typeToString(type);
    if (typeString == "Required<LocaleOptions>")
        return true;

    if (typeString == "LocaleOptions")
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

    if (checker.typeToString(typeDef) == "DateInput") {
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

    if (checker.typeToString(typeDef) == "DurationLikeObject") {
        return true;
    }

    if (checker.typeToString(typeDef) == "DurationLike") {
        return true;
    }

    return false;
}

function isDurationOptions(typeDef: ts.Type): boolean {
    if (checker.typeToString(typeDef) == "DurationOptions | undefined") {
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

    if (className == "DateTime" && propertyName == "dateTimes") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "DateTime" }] }
    }

    if (propertyName == "get") {
        return gen.systemInt
    }

    if (isDateTime(typeDef)) {
        return { name: "DateTime" }
    }

    if (isDuration(typeDef)) {
        return { name: "Duration" }
    }

    if (isDurationOptions(typeDef)) {
        return { name: "DurationOptions" }
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

    if (checker.typeToString(typeDef) == "unknown") {
        return { name: "object" }
    }

    if (checker.typeToString(typeDef) == "this[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: className }] }
    }

    if (checker.typeToString(typeDef) == "DateTimeFormatPart[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "Intl.DateTimeFormatPart" }] }
    }

    if (checker.typeToString(typeDef) == "Date") {
        return gen.systemObject
    }

    if (checker.typeToString(typeDef) == "ToObjectOutput<IncludeConfig, IsValid>") {
        return { name: "object" }
    }

    if (checker.typeToString(typeDef) == "(Interval<true> | Interval<false>)[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "Interval" }] }
    }

    if (checker.typeToString(typeDef) == "Interval<boolean>[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "Interval" }] }
    }

    if (checker.typeToString(typeDef) == "DateTimeFormatOptions | undefined") {
        return { name: "Intl.DateTimeFormatOptions" }
    }

    if (checker.typeToString(typeDef) == "DurationFormatOptions | undefined") {
        return { name: "DurationFormatOptions" }
    }

    if (checker.typeToString(typeDef) == "DateTimeOptions | undefined") {
        return { name: "DateTimeOptions" }
    }

    if (checker.typeToString(typeDef) == "DateTimeJSOptions | undefined") {
        return { name: "DateTimeJSOptions" }
    }

    if (checker.typeToString(typeDef) == "LocaleOptions | undefined") {
        return { name: "LocaleOptions" }
    }

    if (checker.typeToString(typeDef) == "{ zone?: string | Zone<boolean> | undefined; } | undefined") {
        return { name: "Zone" }
    }

    if (checker.typeToString(typeDef) == "string | Zone<boolean> | undefined") {
        return { name: "Zone" }
    }

    if (checker.typeToString(typeDef) == "ToHumanDurationOptions | undefined") {
        return { name: "ToHumanDurationOptions" }
    }

    if (checker.typeToString(typeDef) == "ToISOTimeDurationOptions | undefined") {
        return { name: "ToISOTimeDurationOptions" }
    }

    if (checker.typeToString(typeDef) == "keyof DurationLikeObject") {
        return gen.systemString
    }

    if (checker.typeToString(typeDef) == "keyof DurationLikeObject | undefined") {
        return gen.systemString
    }

    if (checker.typeToString(typeDef) == "DateTime<boolean>[]") {
        return { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "DateTime" }] }
    }

    if (checker.typeToString(typeDef) == "ToISOTimeOptions | undefined") {
        return { name: "ToISOTimeOptions" }
    }

    if (checker.typeToString(typeDef) == "{ separator?: string | undefined; } | undefined") {
        return gen.systemObject
    }

    if (checker.typeToString(typeDef) == "ZoneOptions | undefined") {
        return { name: "ZoneOptions" }
    }

    if (checker.typeToString(typeDef) == "_UseLocaleWeekOption | undefined") {
        return gen.systemObject
    }

    if (checker.typeToString(typeDef) == "ToISODateOptions | undefined") {
        return { name: "ToISODateOptions" }
    }

    if (checker.typeToString(typeDef) == "ToSQLOptions | undefined") {
        return { name: "ToSQLOptions " }
    }

    if (checker.typeToString(typeDef) == "DurationUnits | undefined") {
        return {
            ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString]
        }
    }

    if (checker.typeToString(typeDef) == "DiffOptions | undefined") {
        return { name: "DiffOptions" }
    }

    if (checker.typeToString(typeDef) == "ToRelativeOptions | undefined") {
        return { name: "ToRelativeOptions" }
    }

    if (checker.typeToString(typeDef) == "ToRelativeCalendarOptions | undefined") {
        return { name: "ToRelativeCalendarOptions" }
    }

    if (checker.typeToString(typeDef) == "number" || checker.typeToString(typeDef) == "number | undefined") {
        if (propertyName == "count") return gen.systemInt
        if (propertyName == "year") return gen.systemInt
        if (propertyName == "month") return gen.systemInt
        if (propertyName == "day") return gen.systemInt
        if (propertyName == "hour") return gen.systemInt
        if (propertyName == "minute") return gen.systemInt
        if (propertyName == "second") return gen.systemInt
        if (propertyName == "millisecond") return gen.systemInt
        if (propertyName == "milliseconds") return gen.systemInt
        if (propertyName == "seconds") return gen.systemInt
        if (propertyName == "numberOfParts") return gen.systemInt
        if (propertyName == "offset") return gen.systemInt

        console.log(propertyName);
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

        if (typeSymbol.name == "DateObjectUnits") {
            return { name: "DateObjectUnits" }
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



function GenerateStaticMethod(className: string, md: ts.MethodDeclaration): gen.MethodDefinition[] {

    var outMethods: gen.MethodDefinition[] = [];

    console.log("\n");
    console.log(md.getText());

    // Returns the type of the method itself
    //var typeDef = checker.getTypeAtLocation(md);

    var mandatoryCount = md.parameters.filter(x => x.questionToken == undefined).length;
    var totalCount = md.parameters.length;
    if (mandatoryCount != totalCount) {
        console.log("Optional!")
    }

    if(md.getText() == "fromDateTimes"){
        console.log("HERE");
    }
    for (var i = mandatoryCount; i <= totalCount; i++) {

        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ClassBuilderType(className) }];

        var currentParameters = md.parameters.slice(0, i);
        for (var p of currentParameters) {
            var inParameterType = checker.getTypeAtLocation(p);
            //checker.getSymbolsOfParameterPropertyDeclaration(p, p.name.getText());
            var parameterType = GetReturnType(inParameterType, p.name.getText(), className)
            csharpSignatureParameters.push({
                name: p.name.getText(),
                type: { ...gen.varType, typeArguments: [parameterType] }
            })
            console.log(p.name.getText() + " - " + p.type?.getText() + " - " + (p.questionToken == undefined ? "mandatory" : "optional"))
        }

        var typeDef = checker.getReturnTypeOfSignature(checker.getSignatureFromDeclaration(md)!);
        var methodName = md.name.getText();
        var returnType = GetReturnType(typeDef, methodName, className);
        //var returnType = { namespace: "Metapsi.Html", name: accessor.type?.getText()! }

        var fullType = gen.typeUsageToCSharp(returnType)

        outMethods.push({
            name: methodName,
            isStatic: true,
            visibility: "public",
            returnType: { name: "ObjBuilder", typeArguments: [returnType] },
            parameters: csharpSignatureParameters,
            body: [
                gen.returnNode(
                    gen.functionCallNode(
                        "b",
                        "Call<" + fullType + ">",
                        gen.stringLiteralNode(methodName),
                        ...csharpSignatureParameters.slice(1).map(x => gen.identifierNode(x.name))
                    )
                )
            ]
        })
    }

    return outMethods;
}

function GenerateInstanceMethod(className: string, md: ts.MethodDeclaration): gen.MethodDefinition[] {
    console.log(md.getText());


    if (className == "Duration" && md.name.getText() == "mapUnits") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "mapUnits",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "fn", type:
                        {
                            ...gen.varType,
                            typeArguments: [{ name: "Func", namespace: "System", typeArguments: [gen.systemInt, gen.systemInt] }]
                        }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("mapUnits"),
                            gen.identifierNode("fn")
                        )
                    )
                ]
            }, {
                name: "mapUnits",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "fn", type:
                        {
                            ...gen.varType,
                            typeArguments: [
                                {
                                    name: "Func",
                                    namespace: "System",
                                    typeArguments: [
                                        gen.systemInt,
                                        gen.systemString,
                                        gen.systemInt]
                                }]
                        }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("mapUnits"),
                            gen.identifierNode("fn")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "Duration" && md.name.getText() == "shiftTo") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "shiftTo",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "units",
                        isParams: true,
                        type: { ...gen.varType, typeArguments: [gen.systemString] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("shiftTo"),
                            gen.identifierNode("units")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "Interval" && md.name.getText() == "count") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "count",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Interval" }] },
                parameters: csharpSignatureParameters,
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Interval>",
                            gen.stringLiteralNode("count")
                        )
                    )
                ]
            },
            {
                name: "count",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Interval" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "unit",
                        type: { ...gen.varType, typeArguments: [gen.systemString] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Interval>",
                            gen.stringLiteralNode("count"),
                            gen.identifierNode("unit")
                        )
                    )
                ]
            }, {
                name: "count",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Interval" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "unit",
                        type: { ...gen.varType, typeArguments: [gen.systemString] }
                    },
                    {
                        name: "opts",
                        type: { ...gen.varType, typeArguments: [{ name: "CountOptions" }] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Interval>",
                            gen.stringLiteralNode("count"),
                            gen.identifierNode("unit"),
                            gen.identifierNode("opts")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "Interval" && md.name.getText() == "set") {
        return []
    }

    if (className == "Interval" && md.name.getText() == "toDuration") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "toDuration",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: csharpSignatureParameters,
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("toDuration")
                        )
                    )
                ]
            },
            {
                name: "toDuration",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "unit",
                        type: { ...gen.varType, typeArguments: [gen.systemString] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("toDuration"),
                            gen.identifierNode("unit")
                        )
                    )
                ]
            },
            {
                name: "toDuration",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "unit",
                        type: { ...gen.varType, typeArguments: [{ ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString] }] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("toDuration"),
                            gen.identifierNode("unit")
                        )
                    )
                ]
            }, {
                name: "toDuration",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Interval" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "unit",
                        type: { ...gen.varType, typeArguments: [gen.systemString] }
                    },
                    {
                        name: "opts",
                        type: { ...gen.varType, typeArguments: [{ name: "DiffOptions" }] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Interval>",
                            gen.stringLiteralNode("toDuration"),
                            gen.identifierNode("unit"),
                            gen.identifierNode("opts")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "Interval" && md.name.getText() == "mapEndpoints") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "mapEndpoints",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "Duration" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    {
                        name: "mapFn",
                        type: { ...gen.varType, typeArguments: [{ ...gen.systemFunc, typeArguments: [{ name: "DateTime" }, { name: "DateTime" }] }] }
                    }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<Duration>",
                            gen.stringLiteralNode("mapEndpoints"),
                            gen.identifierNode("mapFn")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "DateTime" && md.name.getText() == "get") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "get",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "DateTime" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    { name: "unit", type: { ...gen.varType, typeArguments: [gen.systemString] } }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<DateTime>",
                            gen.stringLiteralNode("get"),
                            gen.identifierNode("unit")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "DateTime" && md.name.getText() == "resolvedLocaleOptions") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "resolvedLocaleOptions",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "DateTime" }] },
                parameters: csharpSignatureParameters,
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<DateTime>",
                            gen.stringLiteralNode("resolvedLocaleOptions")
                        )
                    )
                ]
            },
            {
                name: "resolvedLocaleOptions",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [{ name: "DateTime" }] },
                parameters: [
                    ...csharpSignatureParameters,
                    { name: "opts", type: { ...gen.varType, typeArguments: [gen.systemObject] } }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<DateTime>",
                            gen.stringLiteralNode("resolvedLocaleOptions"),
                            gen.identifierNode("opts")
                        )
                    )
                ]
            }
        ]
    }

    if (className == "DateTime" && md.name.getText() == "toObject") {
        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]
        return [
            {
                name: "toObject",
                isStatic: true,
                visibility: "public",
                returnType: { name: "ObjBuilder", typeArguments: [gen.systemObject] },
                parameters: [
                    ...csharpSignatureParameters,
                    { name: "opts", type: { ...gen.varType, typeArguments: [gen.systemObject] } }
                ],
                body: [
                    gen.returnNode(
                        gen.functionCallNode(
                            "b",
                            "Call<object>",
                            gen.stringLiteralNode("toObject"),
                            gen.identifierNode("opts")
                        )
                    )
                ]
            }
        ]
    }

    var outMethods: gen.MethodDefinition[] = [];


    var mandatoryCount = md.parameters.filter(x => x.questionToken == undefined).length;
    var totalCount = md.parameters.length;
    if (mandatoryCount != totalCount) {
        console.log("Optional!")
    }
    for (var i = mandatoryCount; i <= totalCount; i++) {

        var csharpSignatureParameters: gen.Parameter[] = [{ isThis: true, name: "b", type: ObjBuilderType(className) }]

        var currentParameters = md.parameters.slice(0, i);
        for (var p of currentParameters) {
            var inParameterType = checker.getTypeAtLocation(p);
            //checker.getSymbolsOfParameterPropertyDeclaration(p, p.name.getText());
            var parameterType = GetReturnType(inParameterType, p.name.getText(), className)
            csharpSignatureParameters.push({
                name: p.name.getText(),
                type: { ...gen.varType, typeArguments: [parameterType] }
            })
            console.log(p.name.getText() + " - " + p.type?.getText() + " - " + (p.questionToken == undefined ? "mandatory" : "optional"))
        }

        var typeDef = checker.getReturnTypeOfSignature(checker.getSignatureFromDeclaration(md)!);
        var methodName = md.name.getText();
        var returnType = GetReturnType(typeDef, methodName, className);
        if (className == "Duration" && methodName == "toObject") {
            returnType = gen.systemObject
        }
        //var returnType = { namespace: "Metapsi.Html", name: accessor.type?.getText()! }


        // var fullType = returnType.namespace ?
        //     returnType.namespace + "." + returnType.name :
        //     returnType.name;

        var fullType = gen.typeUsageToCSharp(returnType)

        var validMethodName = methodName;
        if (validMethodName == "as") validMethodName = "@as";

        outMethods.push({
            name: validMethodName,
            isStatic: true,
            visibility: "public",
            returnType: { name: "ObjBuilder", typeArguments: [returnType] },
            parameters: csharpSignatureParameters,
            body: [
                gen.returnNode(
                    gen.functionCallNode(
                        "b",
                        "Call<" + fullType + ">",
                        gen.stringLiteralNode(methodName),
                        ...csharpSignatureParameters.slice(1).map(x => gen.identifierNode(x.name))
                    )
                )
            ]
        })
    }

    return outMethods;
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
                var nodes = GenerateStaticMethod(typeName, node).map(x => gen.methodDefinitionNode(x));
                staticMethods.push(...nodes);
            }
            else {
                var nodes = GenerateInstanceMethod(typeName, node).map(x => gen.methodDefinitionNode(x));
                instanceMethods.push(...nodes);
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