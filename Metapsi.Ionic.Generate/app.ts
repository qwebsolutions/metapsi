import * as gen from "metapsi-csharp-generator"
import * as fsp from "fs/promises";
import * as fs from "fs";
import path from "path";

import * as ionic from "@ionic/core"
import { exit } from "process";
function ionicTests() {

    var a: ionic.DatetimeHighlight;
}

export type IonicMetadata = {
    components: IonicComponentMetadata[];
    typeLibrary?: Record<string, IonicLibraryInterface>;
};

export type IonicTypeOptions = {
    IsCollection: boolean;
    IsLiteral: boolean;
    IsFunction: boolean;
    LeafType: string;
    Options: IonicTypeOptions[];
};

export type IonicComponentMetadata = {
    tag: string;
    docs: string;
    props: IonicPropMetadata[];
    events: IonicEventMetadata[];
    slots: IonicSlotMetadata[];
    methods: IonicMethodMetadata[];
};

export type IonicPropMetadata = {
    name: string;
    attr: string;
    type: string;
    docs: string;
    default?: string;   // 'default' is a reserved word, but allowed as a property
    optional: boolean;
    required: boolean;
};

export type IonicEventMetadata = {
    event: string;  // '@event' in C# mapped to 'event' here
    detail: string;
    docs: string;
    complexType: IonicEventTypeMetadata;
};

export type IonicEventTypeMetadata = {
    original: string;
    resolved: string;
};

export type IonicSlotMetadata = {
    name: string;
    docs: string;
};

export type IonicMethodMetadata = {
    name: string;
    docs: string;
    complexType: IonicMethodType;
};

export type IonicMethodType = {
    signature: string;
    parameters: IonicMethodParameter[];
};

export type IonicMethodParameter = {
    name: string;
    type: string;
    docs: string;
};

export type IonicLibraryInterface = {
    declaration: string;
};

var nodeModulePath = path.join(process.cwd(), "node_modules", "@ionic", "core")
var packageJsonPath = path.join(nodeModulePath, "package.json");
var ionicVersion = JSON.parse(await fsp.readFile(packageJsonPath, { encoding: "utf-8" })).version;
console.log(`Generating Ionic version ${ionicVersion}`)
var distFolder = path.join(process.cwd(), "node_modules", "@ionic", "core", "dist")
var docsFilePath = path.join(distFolder, "docs.json");
var docsFileContent = await fsp.readFile(docsFilePath, { encoding: "utf-8" });
var docsObject = JSON.parse(docsFileContent) as IonicMetadata;

// for (var c of docsObject.components) {
//     for (var e of c.events) {
//         if (e.complexType.resolved.includes("<"))
//             console.log(`${c.tag} ${e.event} ${e.complexType.resolved}`);
//     }
// }

// throw new Error();

var csProjPath = path.join(process.cwd(), "..", "Metapsi.Ionic");
var generateToPath = path.join(csProjPath, "generated");

try {
    await fsp.rm(generateToPath, { recursive: true, force: true });
} catch (err) {
    console.error(`Output folder ${generateToPath} not removed`, err);
}

fs.mkdirSync(path.join(generateToPath, "controls"), { recursive: true });

function getFilePathsRecursiveSync(currentPath: string): string[] {
    var outPaths: string[] = []
    // Check if source exists
    if (!fs.existsSync(currentPath)) {
        throw new Error(`Source path does not exist: ${currentPath}`);
    }

    const stats = fs.statSync(currentPath);

    if (stats.isDirectory()) {
        // Read all entries in the source directory
        const entries = fs.readdirSync(currentPath);

        for (const entry of entries) {
            const srcPath = path.join(currentPath, entry);

            // Recursively copy each entry
            outPaths.push(...getFilePathsRecursiveSync(srcPath));
        }
    } else if (stats.isFile()) {
        // Copy file
        //fs.copyFileSync(src, dest);
        outPaths.push(currentPath);
    } else {
        // Handle other types (symlinks, etc.) if needed
        console.warn(`Skipping unsupported file type: ${currentPath}`);
    }

    return outPaths;
}

var allPaths = getFilePathsRecursiveSync(distFolder);
var jsPaths = allPaths.filter(x => {
    var relative = x.replace(distFolder, "").slice(1);
    return relative.startsWith("ionic")
})

var cssPath = path.join(nodeModulePath, "css", "ionic.bundle.css");

var cdnCsContent = `namespace Metapsi.Ionic;

public static partial class Cdn
{
    public const string Version = "${ionicVersion}";
}
`
fs.writeFileSync(path.join(generateToPath, "Cdn.cs"), cdnCsContent, { encoding: "utf8" });

copyAssets(path.join(distFolder, "ionic"), jsPaths, path.join(generateToPath, "embedded"))
fs.copyFileSync(
    cssPath,
    path.join(
        generateToPath,
        "embedded",
        cssPath.replace(path.join(nodeModulePath, "css"), "").slice(1)
    ));

function copyAssets(relativeToPath: string, sourcePaths: string[], intoFolder: string) {
    for (var assetPath of sourcePaths) {
        var assetRelativePath = assetPath.replace(relativeToPath, "");
        var destinationPath = path.join(intoFolder, assetRelativePath);
        var folder = path.dirname(destinationPath);
        if (!fs.existsSync(folder)) {
            fs.mkdirSync(folder, { recursive: true });
        }
        fs.copyFileSync(assetPath, destinationPath);
    }
}

var relativePaths = allPaths.filter(x => {
    var relative = x.replace(distFolder, "").slice(1);
    return relative.startsWith("ionic")
}).map(x => {
    var relative = x.replace(distFolder, "").slice(1);
    return relative.replace("ionic\\", "")
})

relativePaths.push("ionic.bundle.css")

function getTargetFileContent(version: string, relativePaths: string[]): string {
    var outLines: string[] = [];
    outLines.push('<Project>')
    outLines.push('  <PropertyGroup>')
    outLines.push(`    <IonicVersion>${version}</IonicVersion>`)
    outLines.push('  </PropertyGroup>')
    outLines.push('  <ItemGroup>')
    for (const assetPath of relativePaths) {
        outLines.push(`    <EmbeddedResource Include="generated\\embedded\\${assetPath}" LogicalName="ionic@${version}/${assetPath.replaceAll("\\", "/")}" />`)
    }
    outLines.push('  </ItemGroup>')
    outLines.push('</Project>')
    return outLines.join("\n");
}

var targetFile = getTargetFileContent(ionicVersion, relativePaths);
await fsp.writeFile(path.join(generateToPath, "ionic.target"), targetFile, 'utf-8');

for (var component of docsObject.components) {
    var skippedTags = ["ion-picker-legacy", "ion-select-modal"]
    if (!skippedTags.includes(component.tag)) {
        var className = gen.toCSharpValidName(component.tag);
        var csPath = path.join(generateToPath, "controls", className + ".cs");
        console.log(`Generating ${csPath} ...`)
        writeWebComponentFile(component, csPath);
        console.log("Done")
    }
}

console.log(`Complete!`)

function getInputEntities(def: IonicComponentMetadata): gen.WebComponentInputEntity[] {
    var outEntities: gen.WebComponentInputEntity[] = [];
    var className = gen.toCSharpValidName(def.tag);
    outEntities.push({ kind: "customElement", name: className, description: def.docs ?? "", tag: def.tag })
    if (def.slots) {
        for (var slot of def.slots) {
            if (slot.name) {
                outEntities.push({ kind: "slot", name: slot.name, description: slot.docs ?? "" })
            }
        }
    }
    if (def.methods) {
        for (var method of def.methods) {
            if (method.docs) {
                outEntities.push({ kind: "method", name: method.name, description: method.docs ?? "" })
            }
        }
    }

    if (def.props) {
        for (var attr of def.props) {
            if (attr.attr) {
                outEntities.push({ kind: "attribute", name: attr.name, description: attr.docs ?? "", type: attr.type })
            }
        }

        for (var property of def.props) {
            if (!skipProperty(def, property)) {
                outEntities.push({ kind: "property", name: property.name, description: property.docs ?? "", type: property.type })
            }
        }
    }

    if (def.events) {
        for (var event of def.events) {
            //console.log("event type:"+ event.complexType.original + " "+event.complexType.resolved);
            //console.log("event detail:"+ event.detail);
            var detailType = event.complexType.resolved;
            if (detailType == "void")
                detailType = "";
            if (detailType == "any")
                detailType = "";
            outEntities.push({ kind: "event", name: event.event, description: event.docs ?? "", customDetailType: detailType })
        }
    }

    return outEntities;
}

//TODO: This properties will need to be handled, I just don't have support now
function skipProperty(component: IonicComponentMetadata, prop: IonicPropMetadata) {
    if (prop.type == "((baseEl: any, opts?: any) => Animation) | undefined")
        return true;
}

export function writeWebComponentFile(customElement: IonicComponentMetadata, intoFile: string) {
    try {
        var className = gen.toCSharpValidName(customElement.tag);
        var inputEntities = getInputEntities(customElement);

        var nodes: gen.WebComponentNode[] = [];
        for (const inputEntity of inputEntities) {
            var outNodes = convertEntity(className, inputEntity);
            nodes.push(...outNodes);
        }

        var fileStructure = new gen.WebComponentFileStructure();
        for (var node of nodes) {
            gen.addWebComponentNode(fileStructure, node);
        }
        var file = gen.getWebComponentFile(fileStructure, className, "Metapsi.Ionic", customElement.docs!);

        var csharpFileString = gen.fileToCSharp(file);
        fs.writeFileSync(intoFile, csharpFileString, { encoding: "utf8" });
    }
    catch (ex) {
        console.error(ex);
    }
}


/**
 * From one input entity to multiple nodes
 * @param inputEntity 
 * @returns 
 */
export function convertEntity(customElementName: string, inputEntity: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    switch (inputEntity.kind) {
        case "customElement":
            return [
                {
                    kind: "ssrConstructor",
                    node: gen.createActionParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "IonicTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "ssrConstructor",
                    node: gen.createParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "IonicTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "ssrConstructor",
                    node: gen.createActionListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "IonicTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "ssrConstructor",
                    node: gen.createListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "IonicTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createActionParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "IonicNode"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "IonicNode"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createActionListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "IonicNode"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "IonicNode"),
                    comment: inputEntity.description
                }
            ]
        case "attribute": return createAttributeSetters(customElementName, inputEntity)
        case "method": return [{
            kind: "methodConstant",
            node: gen.createMethodNameConstant(inputEntity.name),
            comment: inputEntity.description
        }]
        case "property": return createPropertySetters(customElementName, inputEntity)
        case "event": return createEventSetters(customElementName, inputEntity);
        case "slot": return [{
            kind: "slotConstant",
            node: gen.createSlotNameConstant(inputEntity.name),
            comment: inputEntity.description
        }]
        default:
            const check: never = inputEntity;
            return []
    }
}

// only handle number explicitly, so we output int/decimal as preffered
function createExplicitTypes(customElementName: string, property: gen.WebComponentInputEntity): gen.MethodDefinition[] {
    var propertySetters: gen.MethodDefinition[] = [];
    if (property.kind == "property") {
        if (customElementName == "IonActionSheet" && property.name == "buttons" && property.type == "(string | ActionSheetButton<any>)[]") {
            var actionSheetButtonSetter = gen.createValuePropertySetter(
                customElementName,
                property.name,
                {
                    ...gen.systemCollectionsGenericList, typeArguments: [{ name: "ActionSheetButton", namespace: "Metapsi.Ionic" }]
                })
            return [
                gen.createValuePropertySetter(
                    customElementName,
                    property.name,
                    {
                        ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString]
                    }),
                actionSheetButtonSetter
            ]
        }

        if (customElementName == "IonAlert") {
            if (property.type == "(string | AlertButton)[]") {
                return [
                    gen.createValuePropertySetter(
                        customElementName,
                        property.name,
                        {
                            ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString]
                        }),
                    gen.createValuePropertySetter(
                        customElementName,
                        property.name,
                        {
                            ...gen.systemCollectionsGenericList, typeArguments: [{ name: "AlertButton", namespace: "Metapsi.Ionic" }]
                        }),
                ]
            }
            if (property.type == "AlertInput[]") {
                return [
                    gen.createValuePropertySetter(
                        customElementName,
                        property.name,
                        {
                            ...gen.systemCollectionsGenericList, typeArguments: [{ name: "AlertInput", namespace: "Metapsi.Ionic" }]
                        }),
                ]
            }
        }

        if (customElementName == "IonBreadcrumbs") {
            if (property.type == "number" || property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }
        }

        if (customElementName == "IonButton") {
            // is actually HTMLFormElement | string | undefined
            if (property.name == "form") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonCheckbox") {
            if (property.name == "value" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonDatetime") {
            if (property.type == "number | number[] | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemCollectionsGenericList, typeArguments: [gen.systemInt] }),
                ]
            }

            if (property.name == "firstDayOfWeek" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt),
                ]
            }
            if (property.name == "formatOptions") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }

            if (property.name == "highlightedDates" && property.type == "((dateIsoString: string) => DatetimeHighlightStyle | undefined) | DatetimeHighlight[] | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "DatetimeHighlight", namespace: "Metapsi.Ionic" }] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemString, { name: "DatetimeHighlightStyle", namespace: "Metapsi.Ionic" }] }),
                ]
            }

            if (property.name == "isDateEnabled" && property.type == "((dateIsoString: string) => boolean) | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "DatetimeHighlight", namespace: "Metapsi.Ionic" }] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemString, gen.systemBool] }),
                ]
            }
            if (property.name == "titleSelectedDatesFormatter" && property.type == "((selectedDates: string[]) => string) | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, {
                        ...gen.systemFunc, typeArguments: [{
                            ...gen.systemCollectionsGenericList, typeArguments: [
                                gen.systemString]
                        },
                        gen.systemString]
                    }),
                ]
            }
        }

        if (customElementName == "IonInput") {
            if (property.name == "counterFormatter" && property.type == "((inputLength: number, maxLength: number) => string) | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, {
                        ...gen.systemFunc,
                        typeArguments: [
                            gen.systemInt,
                            gen.systemInt,
                            gen.systemString]
                    }),
                ]
            }
            if (property.name == "debounce" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "max" && property.type == "number | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }

            if (property.name == "min" && property.type == "number | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }

            if (property.name == "maxlength" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "minlength" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "value" && property.type == "null | number | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonLoading" && property.name == "duration" && property.type == "number") {
            return [
                gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
            ]
        }

        if (customElementName == "IonMenu") {
            if (property.name == "maxEdgeStart" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }
        }

        if (customElementName == "IonModal") {
            if (property.name == "backdropBreakpoint" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal)
                ]
            }

            if (property.name == "breakpoints" && property.type == "number[] | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemCollectionsGenericList, typeArguments: [gen.systemDecimal] })
                ]
            }

            if (property.name == "initialBreakpoint" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "canDismiss" && property.type == "((data?: any, role?: string | undefined) => Promise<boolean>) | boolean") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemBool),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemObject, gen.systemString, { name: "Promise", namespace: "Metapsi.Html" }] })
                ]
            }

            if (property.name == "presentingElement" && property.type == "HTMLElement | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { name: "HTMLElement", namespace: "Metapsi.Html" })
                ]
            }
        }

        if (customElementName == "IonNav") {
            if (property.name == "root" && property.type == "Function | HTMLElement | ViewController | null | string | undefined") {
                return [
                    // Don't know much about how to use the other types
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonNavLink") {
            if (property.name == "component" && property.type == "Function | HTMLElement | ViewController | null | string | undefined") {
                return [
                    // Don't know much about how to use the other types
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonPopover") {
            if (property.name == "component" && property.type == "Function | HTMLElement | null | string | undefined") {
                return [
                    // Don't know much about how to use the other types
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }

            if (property.name == "event" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonPickerColumn") {
            if (property.name == "value" && property.type == "number | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonPickerColumnOption") {
            if (property.name == "value" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonProgressBar") {
            if (property.name == "buffer" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal)
                ]
            }

            if (property.name == "value" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal)
                ]
            }
        }

        if (customElementName == "IonRadio") {
            if (property.name == "value" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonRadioGroup") {
            if (property.name == "compareWith" && property.type == "((currentValue: any, compareValue: any) => boolean) | null | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemObject, gen.systemObject, gen.systemBool] })
                ]
            }

            if (property.name == "value" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonRange") {
            if (property.name == "activeBarStart" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "max" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "min" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "debounce" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "pinFormatter" && property.type == "(value: number) => string | number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemDecimal, gen.systemInt] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemDecimal, gen.systemString] })
                ]
            }

            if (property.name == "step" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal)
                ]
            }
            if (property.name == "value" && property.type == "number | { lower: number; upper: number; }") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonRefresher") {
            if (property.name == "pullFactor" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal)
                ]
            }
            if (property.name == "pullMax" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }
            if (property.name == "pullMin" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }
        }

        if (customElementName == "IonRoute") {
            if (property.name == "beforeEnter" && property.type == "(() => NavigationHookResult | Promise<NavigationHookResult>) | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemBool] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [{ name: "NavigationHookOptions", namespace: "Metapsi.Ionic" }] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [{ name: "Promise", namespace: "Metapsi.Html", typeArguments: [gen.systemBool] }] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [{ name: "Promise", namespace: "Metapsi.Html", typeArguments: [{ name: "NavigationHookOptions", namespace: "Metapsi.Ionic" }] }] }),
                ]
            }
        }

        if (customElementName == "IonRoute") {
            if (property.name == "beforeLeave" && property.type == "(() => NavigationHookResult | Promise<NavigationHookResult>) | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemBool] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [{ name: "NavigationHookOptions", namespace: "Metapsi.Ionic" }] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [{ name: "Promise", namespace: "Metapsi.Html", typeArguments: [gen.systemBool] }] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [{ name: "Promise", namespace: "Metapsi.Html", typeArguments: [{ name: "NavigationHookOptions", namespace: "Metapsi.Ionic" }] }] }),
                ]
            }
        }

        if (customElementName == "IonSearchbar") {
            if (property.name == "debounce" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                ]
            }
            if (property.name == "maxlength" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                ]
            }
            if (property.name == "minlength" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                ]
            }
        }

        if (customElementName == "IonSegment") {
            if (property.name == "value" && property.type == "number | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonSegmentButton") {
            if (property.name == "value" && property.type == "number | string") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemString),
                ]
            }
        }

        if (customElementName == "IonSelect") {
            if (property.name == "compareWith" && property.type == "((currentValue: any, compareValue: any) => boolean) | null | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemObject, gen.systemObject, gen.systemBool] })
                ]
            }

            if (property.name == "interfaceOptions" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }

            if (property.name == "value" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonSelectOption") {
            if (property.name == "value" && property.type == "any") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemObject)
                ]
            }
        }

        if (customElementName == "IonSpinner") {
            if (property.name == "duration" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }
        }

        if (customElementName == "IonTab") {
            if (property.name == "component" && property.type == "Function | HTMLElement | null | string | undefined") {
                return [
                    // Don't know much about how to use the other types
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString)
                ]
            }
        }

        if (customElementName == "IonTextarea") {
            if (property.name == "cols" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "counterFormatter" && property.type == "((inputLength: number, maxLength: number) => string) | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemFunc, typeArguments: [gen.systemInt, gen.systemInt, gen.systemString] })
                ]
            }

            if (property.name == "debounce" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "maxlength" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "minlength" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "rows" && property.type == "number | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }
        }

        if (customElementName == "IonToast") {
            if (property.name == "buttons" && property.type == "(string | ToastButton)[] | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString] }),
                    gen.createValuePropertySetter(customElementName, property.name, { ...gen.systemCollectionsGenericList, typeArguments: [{ name: "ToastButton", namespace: "Metapsi.Ionic" }] })
                ]
            }

            if (property.name == "duration" && property.type == "number") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemInt),
                    gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt)
                ]
            }

            if (property.name == "positionAnchor" && property.type == "HTMLElement | string | undefined") {
                return [
                    gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                    gen.createValuePropertySetter(customElementName, property.name, { name: "HTMLElement", namespace: "Metapsi.Html" })
                ]
            }
        }

        // Globally reused types

        if (property.type == "((baseEl: any, opts?: any) => Animation) | undefined") {
            console.warn(`${customElementName}.${property.name} is animation, skipped`)
        }

        if (property.type == "undefined | { [key: string]: any; }") {
            return [
                gen.createValuePropertySetter(
                    customElementName,
                    property.name,
                    {
                        ...gen.systemCollectionsGenericList, typeArguments: [gen.systemObject]
                    }),
            ]
        }

        if (property.type == "IonicSafeString | string | undefined") {
            return [
                gen.createValuePropertySetter(customElementName, property.name, gen.systemString),
                gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemString),
            ]
        }

        if (property.type == "number") {
            throw new Error("Not implemented")
        }
    }
    return propertySetters;
}

function createPropertySetters(customElementName: string, property: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    var propertySetters: gen.MethodDefinition[] = [];

    if (property.kind == "property") {
        var explicit = createExplicitTypes(customElementName, property);
        if (explicit.length) {
            propertySetters.push(...explicit);
        } else if (property.type == "boolean" || property.type == "boolean | undefined") {
            propertySetters.push(gen.createDefaultTrueBoolPropertySetter(customElementName, property.name));
            propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemBool));
            propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemBool));
        } else if (property.type == "string" || property.type == "string | undefined") {
            propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemString));
            propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemString));
        } else if (property.type.includes("|")) {
            var types = gen.getConstituentTypes(property.type);
            for (var constituentType of types) {
                if (constituentType.kind == "literal") {
                    if (constituentType.type == "string") {
                        propertySetters.push(gen.createLiteralPropertySetter(customElementName, property.name, constituentType.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (constituentType.kind == "type") {
                        if (constituentType.type == "string") {
                            propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemString))
                        }
                        else if (constituentType.type == "string & Record<never, never>") {
                            propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemString))
                        }
                        else if (constituentType.type == "boolean") {
                            propertySetters.push(gen.createDefaultTrueBoolPropertySetter(customElementName, property.name));
                            propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemBool));
                            propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemBool));
                        }
                        else if (constituentType.type == "Date") {
                            console.warn(`Ignoring Date property on ${customElementName}.${property.name}`)
                            // Ignore built-in Date types because ... well...
                        }
                        else throw new Error(`Unsupported type ${property.type} in ${customElementName}.${property.name}`)
                    }
                    else if (constituentType.kind == "array") {
                        if (constituentType.itemType == "string") {
                            propertySetters.push(
                                gen.createValuePropertySetter(
                                    customElementName,
                                    property.name,
                                    {
                                        ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString]
                                    }));
                        }
                        else {
                            throw new Error(`Unsupported type in ${property.type}`)
                        }
                    }
                    else throw new Error(`Unsupported type in ${property.type}`)
                }
            }
        } else {
            // If DOM type

            var types = gen.getConstituentTypes(property.type);
            for (var constituentType of types) {
                if (constituentType.kind == "literal") {
                    if (constituentType.type == "string") {
                        propertySetters.push(gen.createLiteralPropertySetter(customElementName, property.name, constituentType.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (constituentType.kind == "type") {
                        if (constituentType.type == "string") {
                            propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemString))
                        }
                        else throw new Error(`Unsupported type ${property.type} in ${customElementName}.${property.name}`)
                    }
                    else throw new Error(`Unsupported type in ${property.type}`)
                }
            }
        }

        if (!propertySetters.length)
            throw new Error(`Type ${property.type} unsupported in ${customElementName}.${property.name}`)
    }

    return propertySetters.map(x => ({ kind: "propertySetter", node: x, comment: property.description }));
}

function skipAttribute(customElementName: string, attribute: gen.WebComponentInputEntity) {
    if (attribute.kind == "attribute") {
        if (customElementName == "SlPopup") {
            return true; // SlPopup does not make sense as a stand-alone component
        }
        if (customElementName == "SlSelect" && attribute.name == "getTag") return true;
    }
    return false;
}

function createAttributeSetters(customElementName: string, attribute: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    var outNodes: gen.MethodDefinition[] = [];
    if (attribute.kind == "attribute") {

        if (skipAttribute(customElementName, attribute))
            return [];

        if (attribute.type == "number | number[] | string | undefined") {
            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
        }
        else if (attribute.type == "boolean") {
            outNodes.push(gen.createBoolAttributeSetter(attribute.name, customElementName));
            outNodes.push(gen.createDefaultTrueBoolAttributeSetter(attribute.name, customElementName));
        } else if (attribute.type == "string") {
            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
        } else if (attribute.type.includes("|")) {
            var types = gen.getConstituentTypes(attribute.type);
            for (var type of types) {
                if (type.kind == "literal") {
                    if (type.type == "string") {
                        outNodes.push(gen.createStringLiteralAttributeSetter(attribute.name, customElementName, type.value));
                    }
                    else throw new Error("Literal type not supported!")
                }
                else {
                    if (type.kind == "type") {
                        if (type.type == "string") {
                            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
                        }
                        else if (type.type == "string & Record<never, never>") {
                            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
                        }
                        else if (type.type == "boolean") {
                            outNodes.push(gen.createBoolAttributeSetter(attribute.name, customElementName));
                            outNodes.push(gen.createDefaultTrueBoolAttributeSetter(attribute.name, customElementName));
                        }
                        else if (types.some(x => x.kind == "type" && x.type == "string")) {
                            // is part of string | other type, already handled
                        }
                        else if (type.type == "number") {
                            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
                        }
                        else if (type.type == "{ lower: number; upper: number; }") {
                            // ignore
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                    else if (type.kind == "array" && type.itemType == "string") {
                        if (types.some(x => x.kind == "type" && x.type == "string")) {
                            // is part of string | string[], already handled
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                    else if (type.kind == "function") {
                        // Functions are probably in union with a base type

                    }
                    else {
                        throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                }
            }
        }
    }
    return outNodes.map(x => ({ kind: "attributeSetter", node: x, comment: attribute.description }));
}

function createEventSetters(customElementName: string, event: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    var outNodes: gen.MethodDefinition[] = [];
    if (event.kind == "event") {
        outNodes.push(createVarActionModelEventEventSetter(customElementName, event.name));
        outNodes.push(createSyntaxBuilderActionModelEventEventSetter(customElementName, event.name));
        outNodes.push(createVarActionModelEventSetter(customElementName, event.name));
        outNodes.push(createSyntaxBuilderActionModelEventSetter(customElementName, event.name));
        // outNodes.push(gen.CreateFuncSyntaxBuilderEventEventSetter(customElementName, event.name));
        // outNodes.push(gen.createVarActionEventSetter(customElementName, event.name));
        // outNodes.push(gen.CreateFuncSyntaxBuilderEventSetter(customElementName, event.name));
        if (event.customDetailType) {
            //console.log(`Custom event detail ${event.name}: ${event.customDetailType}`)
            var detailType = event.customDetailType;
            if (detailType.includes("{")) {
                detailType = gen.toCSharpValidName(event.name) + "Detail"
            }
            if (detailType.includes("<any>"))
                detailType = detailType.replace("<any>", "");
            outNodes.push(createIonicVarActionModelCustomEventEventSetter(customElementName, event.name, detailType));
        }
    }
    if (!outNodes.length) {
        throw new Error(`${customElementName}.${event.name} not implemented`)
    }
    return outNodes.map(x => ({ kind: "event", node: x, comment: event.description }));
}


/**
 * Var<Hypertype.Action<TModel, Html.Event>>
 * @param customElementName 
 * @param eventName 
 * @returns 
 */
function createVarActionModelEventEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
    return gen.createEventSetter(
        gen.EventFnName(eventName),
        customElementName,
        [
            {
                name: "action",
                type: {
                    ...gen.varType,
                    typeArguments: [
                        {
                            ...gen.hyperappActionType,
                            typeArguments: [
                                { name: "TModel" },
                                gen.domEventType
                            ]
                        }
                    ]
                }
            }
        ], [
        gen.functionCallNode(
            "b",
            "SetProperty",
            gen.identifierNode("b.Props"),
            gen.stringLiteralNode("on" + eventName),
            gen.identifierNode("action")
        )
    ])
}

/**
 * System.Func<SyntaxBuilder, Var<TModel>, Var<Html.Event>, Var<TModel>>
 * @param customElementName 
 * @param eventName 
 * @returns 
 */
function createSyntaxBuilderActionModelEventEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
    return gen.createEventSetter(
        gen.EventFnName(eventName),
        customElementName,
        [
            {
                name: "action",
                type: {
                    ...gen.systemFunc,
                    typeArguments: [
                        gen.syntaxBuilderType,
                        gen.varTModelType,
                        gen.varDomEventType,
                        gen.varTModelType
                    ]
                }
            }
        ], [
        gen.functionCallNode(
            "b",
            gen.EventFnName(eventName),
            gen.functionCallNode("b", "MakeAction", gen.identifierNode("action"))
        )
    ])
}

/**
 * Var<HyperType.Action<TModel>>
 * @param customElementName 
 * @param eventName 
 * @returns 
 */
function createVarActionModelEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
    return gen.createEventSetter(
        gen.EventFnName(eventName),
        customElementName,
        [
            {
                name: "action",
                type: {
                    ...gen.varType,
                    typeArguments: [
                        {
                            ...gen.hyperappActionType,
                            typeArguments: [
                                { name: "TModel" }
                            ]
                        }
                    ]
                }
            }
        ], [
        gen.functionCallNode(
            "b",
            "SetProperty",
            gen.identifierNode("b.Props"),
            gen.stringLiteralNode("on" + eventName),
            gen.identifierNode("action")
        )
    ])
}


/**
 * System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>>
 * @param customElementName 
 * @param eventName 
 * @returns 
 */
function createSyntaxBuilderActionModelEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
    return gen.createEventSetter(
        gen.EventFnName(eventName),
        customElementName,
        [
            {
                name: "action",
                type: {
                    ...gen.systemFunc,
                    typeArguments: [
                        gen.syntaxBuilderType,
                        gen.varTModelType,
                        gen.varTModelType
                    ]
                }
            }
        ], [
        gen.functionCallNode(
            "b",
            gen.EventFnName(eventName),
            gen.functionCallNode("b", "MakeAction", gen.identifierNode("action"))
        )
    ])
}

function createIonicVarActionModelCustomEventEventSetter(customElementName: string, eventName: string, detailType: string): gen.MethodDefinition {
    return gen.createEventSetter(
        gen.EventFnName(eventName),
        customElementName,
        [
            {
                name: "action",
                type: {
                    ...gen.varType,
                    typeArguments: [
                        {
                            ...gen.hyperappActionType,
                            typeArguments: [
                                { name: "TModel" },
                                {
                                    name: "CustomEvent", namespace: "Metapsi.Html", typeArguments: [{
                                        //name: customElementName + gen.toCSharpValidName(eventName.substring(3)) + "Detail"
                                        name: detailType
                                    }
                                    ]
                                }
                            ]
                        }
                    ]
                }
            }
        ], [
        gen.functionCallNode(
            "b",
            "SetProperty",
            gen.identifierNode("b.Props"),
            gen.stringLiteralNode("on" + eventName),
            gen.identifierNode("action")
        )
    ])
}