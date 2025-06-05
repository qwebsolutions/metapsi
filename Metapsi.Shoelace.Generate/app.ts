import * as gen from 'metapsi-csharp-generator'
import * as fsp from "fs/promises";
import * as fs from "fs";
import * as cemSchema from 'custom-elements-manifest';
import path from "path";

var shoelaceNodeModulePath = path.join(process.cwd(), "node_modules", "@shoelace-style", "shoelace")
var shoelacePackageJsonPath = path.join(shoelaceNodeModulePath, "package.json");
var shoelaceVersion = JSON.parse(await fsp.readFile(shoelacePackageJsonPath, { encoding: "utf-8" })).version;
console.log(`Generating Shoelace version ${shoelaceVersion}`)
var shoelaceDistFolder = path.join(process.cwd(), "node_modules", "@shoelace-style", "shoelace", "dist")
var customElementsManifestJsonPath = path.join(shoelaceDistFolder, "custom-elements.json");
var customElementsManifestContent = await fsp.readFile(customElementsManifestJsonPath, { encoding: "utf-8" });
var shoelaceManifest = JSON.parse(customElementsManifestContent) as cemSchema.Package;

var metapsiShoelaceProjectPath = path.join(process.cwd(), "..", "Metapsi.Shoelace");
var metapsiGenerateOutputPath = path.join(metapsiShoelaceProjectPath, "generated");

try {
    await fsp.rm(metapsiGenerateOutputPath, { recursive: true, force: true });
} catch (err) {
    console.error(`Output folder ${metapsiGenerateOutputPath} not removed`, err);
}

var metapsiShoelaceControlsPath = path.join(metapsiGenerateOutputPath, "controls");
var metapsiShoelaceEmbeddedPath = path.join(metapsiGenerateOutputPath, "embedded");

var allPaths = getFilePathsRecursiveSync(shoelaceDistFolder);
var assetPaths = allPaths.filter(x => !x.endsWith(".ts")).filter(x => !x.endsWith(".json")).filter(x => {
    var relative = x.replace(shoelaceDistFolder, "").substring(1);
    return !relative.startsWith("react");
});
copyAssets(shoelaceDistFolder, assetPaths, metapsiShoelaceEmbeddedPath)

var relativeAssetPaths = assetPaths.map(x => x.replace(shoelaceDistFolder + "\\", ""));

var targetFile = getTargetFileContent(shoelaceVersion, relativeAssetPaths);
await fsp.writeFile(path.join(metapsiGenerateOutputPath, "shoelace.target"), targetFile, 'utf-8');

fs.mkdirSync(metapsiShoelaceControlsPath);
await generateCodeFiles(shoelaceManifest, metapsiShoelaceControlsPath);

await fsp.writeFile(path.join(metapsiGenerateOutputPath, "Cdn.cs"), getCdnFileContent(shoelaceVersion, shoelaceManifest), "utf-8");

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

function getCdnFileContent(version: string, schema: cemSchema.Package): string {
    let importPaths: { tagName: string, path: string }[] = [];

    for (const m of schema.modules) {
        for (const dec of m.declarations!) {
            if (dec.kind == "class") {
                var customElement: cemSchema.CustomElementDeclaration = dec as cemSchema.CustomElementDeclaration;
                if (customElement.name != "SlPopup") {
                    importPaths.push({ tagName: customElement.tagName!, path: m.path });
                }
            }
        }
    }

    var dictLines = importPaths.map(x => `        { "${x.tagName}", "${x.path}"}`)

    var fakeDictionaryLiteral = "new()\n    {\n" + dictLines.join(",\n") + "\n    };";

    var cdnClass: gen.TypeDefinition = {
        name: "Cdn",
        isStatic: true,
        isPartial: true,
        body: [
            gen.constantNode({ name: "Version", value: gen.stringLiteral(version), type: gen.systemString, visibility: 'public' }),
            {
                nodeType: gen.NodeType.PropertyDefinition,
                prop: {
                    visibility: 'public',
                    isStatic: true,
                    name: "ImportPaths",
                    type: { ...gen.systemCollectionsGenericDictionary, typeArguments: [gen.systemString, gen.systemString] },
                    initializer: { value: fakeDictionaryLiteral }
                }
            }
        ]
    }

    var cdnFile: gen.File = {
        namespace: "Metapsi.Shoelace",
        content: [
            { nodeType: gen.NodeType.TypeDefinition, definition: cdnClass }
        ],
        usings: []
    };

    return gen.fileToCSharp(cdnFile);
}

function getTargetFileContent(version: string, relativePaths: string[]): string {
    var outLines: string[] = [];
    outLines.push('<Project>')
    outLines.push('  <PropertyGroup>')
    outLines.push(`    <ShoelaceVersion>${version}</ShoelaceVersion>`)
    outLines.push('  </PropertyGroup>')
    outLines.push('  <ItemGroup>')
    for (const assetPath of relativePaths) {
        outLines.push(`    <EmbeddedResource Include="generated\\embedded\\${assetPath}" LogicalName="shoelace@${version}/${assetPath.replaceAll("\\", "/")}" />`)
    }
    outLines.push('  </ItemGroup>')
    outLines.push('</Project>')
    return outLines.join("\n");
}

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


// function copyRecursiveSync(src: string, dest: string): string[] {
//     var outPaths: string[] = []
//     // Check if source exists
//     if (!fs.existsSync(src)) {
//         throw new Error(`Source path does not exist: ${src}`);
//     }

//     const stats = fs.statSync(src);

//     if (stats.isDirectory()) {
//         // Ensure destination directory exists
//         if (!fs.existsSync(dest)) {
//             fs.mkdirSync(dest, { recursive: true });
//         }

//         // Read all entries in the source directory
//         const entries = fs.readdirSync(src);

//         for (const entry of entries) {
//             const srcPath = path.join(src, entry);
//             const destPath = path.join(dest, entry);

//             // Recursively copy each entry
//             outPaths.push(...copyRecursiveSync(srcPath, destPath));
//         }
//     } else if (stats.isFile()) {
//         // Copy file
//         //fs.copyFileSync(src, dest);
//         outPaths.push(src);
//     } else {
//         // Handle other types (symlinks, etc.) if needed
//         console.warn(`Skipping unsupported file type: ${src}`);
//     }

//     return outPaths;
// }

export async function generateCodeFiles(shoelaceManifest: cemSchema.Package, outFolder: string): Promise<void> {
    for (const m of shoelaceManifest.modules) {
        for (const d of m.declarations!) {
            {
                switch (d.kind) {
                    case "class":
                        var dec = d as cemSchema.CustomElement;
                        if (dec.name != "SlPopup") {
                            var slFilePath = path.join(outFolder, dec.name + ".cs");
                            console.log(`Generating ${slFilePath} ...`);
                            await generateShoelaceWebComponent(dec, slFilePath);
                            console.log(`done`);
                        }
                }
            }
        }
    }
}

export async function generateShoelaceWebComponent(customElement: cemSchema.CustomElement, intoFile: string) {
    var inputEntities = getInputEntities(customElement);
    var nodes = inputEntities.flatMap(e => convertShoelaceEntity(customElement.name, e));
    var fileStructure = new gen.WebComponentFileStructure();
    for (var node of nodes) {
        gen.addWebComponentNode(fileStructure, node);
    }
    var file = gen.getWebComponentFile(fileStructure, customElement.name, "Metapsi.Shoelace", customElement.summary!);

    var csharpFileString = gen.fileToCSharp(file);
    await fsp.writeFile(intoFile, csharpFileString, 'utf-8');
}

function getInputEntities(def: cemSchema.CustomElement): gen.WebComponentInputEntity[] {
    var outEntities: gen.WebComponentInputEntity[] = [];
    outEntities.push({ kind: "customElement", name: def.name, description: def.summary ?? "", tag: def.tagName! })
    if (def.slots) {
        for (var slot of def.slots) {
            if (slot.name) {
                outEntities.push({ kind: "slot", name: slot.name, description: slot.description ?? "" })
            }
        }
    }
    if (def.members) {
        for (var method of def.members) {
            if (method.kind == "method") {
                if (method.description && method.privacy != "private") {
                    outEntities.push({ kind: "method", name: method.name, description: method.description ?? "" })
                }
            }
        }
    }

    if (def.attributes) {
        for (var attr of def.attributes) {
            outEntities.push({ kind: "attribute", name: attr.name, description: attr.description ?? "", type: attr.type?.text ?? "string" })
        }
    }

    if (def.members) {
        for (var member of def.members) {
            if (member.kind == "field") {
                if (member.description && member.privacy != "private") {
                    outEntities.push({ kind: "property", name: member.name, description: member.description ?? "", type: member.type?.text ?? "string" })
                }
            }
        }
    }

    if (def.events) {
        for (var event of def.events) {
            if (event.description) {
                if (!event.deprecated) {
                    outEntities.push({ kind: "event", name: event.name, description: event.description ?? "", customDetailType: event.type?.text ?? "" })
                }
            }
        }
    }

    return outEntities;
}

/**
 * From one input entity to multiple nodes
 * @param inputEntity 
 * @returns 
 */
export function convertShoelaceEntity(customElementName: string, inputEntity: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    switch (inputEntity.kind) {
        case "customElement":
            return [
                {
                    kind: "ssrConstructor",
                    node: gen.createActionParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "ssrConstructor",
                    node: gen.createParamsChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "ssrConstructor",
                    node: gen.createActionListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "ssrConstructor",
                    node: gen.createListChildrenTagConstructor(inputEntity.name, inputEntity.tag, "SlTag"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createActionParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createParamsChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createActionListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"),
                    comment: inputEntity.description
                },
                {
                    kind: "csrConstructor",
                    node: gen.createListChildrenHyperappNodeConstructor(inputEntity.name, inputEntity.tag, "SlNode"),
                    comment: inputEntity.description
                }
            ]
        case "attribute": return createShoelaceAttributeSetters(customElementName, inputEntity)
        case "method": return [{
            kind: "methodConstant",
            node: gen.createMethodNameConstant(inputEntity.name),
            comment: inputEntity.description
        }]
        case "property": return createShoelacePropertySetters(customElementName, inputEntity)
        case "event": return createShoelaceEventSetters(customElementName, inputEntity);
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
        if (customElementName == "SlAnimation") {
            if (property.type == "number") {
                if (["delay", "duration", "endDelay", "iterations"].includes(property.name)) {
                    propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                    propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
                }
                if (["iterationStart", "playbackRate"].includes(property.name)) {
                    propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                    propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                }
            }
            if (property.name == "keyframes") {
                propertySetters.push(
                    gen.createValuePropertySetter(
                        customElementName,
                        property.name,
                        {
                            ...gen.varType, typeArguments: [{
                                ...gen.systemCollectionsGenericList, typeArguments: [{
                                    name: "Keyframe", namespace: "Metapsi.Html"
                                }]
                            }]
                        }));
            }

            if (property.name == "currentTime" && property.type == "CSSNumberish") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
        }

        if (customElementName == "SlCarousel") {
            if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }
        if (customElementName == "SlCopyButton") {
            if (property.name == "feedbackDuration") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }

        if (customElementName == "SlDropdown") {
            if (property.name == "containingElement" && property.type == 'HTMLElement | undefined') {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, { ...gen.varType, typeArguments: [{ name: "HTMLElement", namespace: "Metapsi.Html" }] }));
            }
            if (property.type == "number") {
                if (property.name == "distance" || property.name == "skidding") {
                    propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                }
            }
        }

        if (customElementName == "SlFormatBytes") {
            if (property.name == "value") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }

        if (customElementName == "SlFormatNumber") {
            if (property.name == "value") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
            else if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }

        if (customElementName == "SlImageComparer") {
            if (property.name == "position") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }
        if (customElementName == "SlInput") {
            if (property.name == "minlength" || property.name == "maxlength") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
            if (property.name == "min" || property.name == "max") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemString));
            }

            if (property.name == "step" && property.type == "number | 'any'") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createLiteralPropertySetter(customElementName, property.name, "any"));
            }
        }
        if (customElementName == "SlProgressBar") {
            if (property.name == "value" && property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
        }

        if (customElementName == "SlProgressRing") {
            if (property.name == "value" && property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
        }

        if (customElementName == "SlQrCode") {
            if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
        }

        if (customElementName == "SlRange") {
            if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
            if (property.name == "tooltipFormatter" && property.type == "(value: number) => string") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, {
                    ...gen.varType,
                    typeArguments: [{
                        ...gen.systemFunc, typeArguments: [gen.systemDecimal, gen.systemString]
                    }]
                }));
            }
        }

        if (customElementName == "SlRating") {
            if (property.name == "precision") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
            if (property.name == "value" || property.name == "max") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }

            if (property.name == "getSymbol") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, {
                    ...gen.varType,
                    typeArguments: [{
                        ...gen.systemFunc, typeArguments: [gen.systemDecimal, gen.systemString]
                    }]
                }));
            }
        }

        if (customElementName == "SlSelect") {
            if (property.name == "maxOptionsVisible") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
            if (property.name == "getTag" && property.type == "(option: SlOption, index: number) => TemplateResult | string | HTMLElement") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, {
                    ...gen.varType,
                    typeArguments: [{
                        ...gen.systemFunc, typeArguments: [
                            { name: "SlOption", namespace: "Metapsi.Shoelace" },
                            gen.systemInt,
                            gen.systemString
                        ]
                    }]
                }));

                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, {
                    ...gen.varType,
                    typeArguments: [{
                        ...gen.systemFunc, typeArguments: [
                            { name: "SlOption", namespace: "Metapsi.Shoelace" },
                            gen.systemInt,
                            { name: "HTMLElement", namespace: "Metapsi.Html" }
                        ]
                    }]
                }));
            }
        }

        if (customElementName == "SlSplitPanel") {
            if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }

            if (property.name == "snap") {
                //TODO:  No support for SnapFunction yet
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }

        if (customElementName == 'SlTextarea') {
            if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemInt));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemInt));
            }
        }

        if (customElementName == "SlTooltip") {
            if (property.type == "number") {
                propertySetters.push(gen.createValuePropertySetter(customElementName, property.name, gen.systemDecimal));
                propertySetters.push(gen.createConstRedirectValuePropertySetter(customElementName, property.name, gen.systemDecimal));
            }
        }
    }
    return propertySetters;
}

function createShoelacePropertySetters(customElementName: string, property: gen.WebComponentInputEntity): gen.WebComponentNode[] {
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
                        else if (constituentType.type == "Date") {
                            console.warn(`Ignoring Date property on ${customElementName}.${property.name}`)
                            // Ignore built-in Date types because ... well...
                        }
                        else throw new Error(`Unsupported type in ${property.type}`)
                    }
                    else if (constituentType.kind == "array") {
                        if (constituentType.itemType == "string") {
                            propertySetters.push(
                                gen.createValuePropertySetter(
                                    customElementName,
                                    property.name,
                                    {
                                        ...gen.varType, typeArguments: [{
                                            ...gen.systemCollectionsGenericList, typeArguments: [gen.systemString]
                                        }]
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

function createShoelaceAttributeSetters(customElementName: string, attribute: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    var outNodes: gen.MethodDefinition[] = [];
    if (attribute.kind == "attribute") {

        if (skipAttribute(customElementName, attribute))
            return [];

        if (attribute.type == "boolean") {
            outNodes.push(gen.createBoolAttributeSetter(attribute.name, customElementName));
            outNodes.push(gen.createDefaultTrueBoolAttributeSetter(attribute.name, customElementName));
        }

        if (attribute.type == "string") {
            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
        }

        if (attribute.type.includes("|")) {
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
                        else if (types.some(x => x.kind == "type" && x.type == "string")) {
                            // is part of string | other type, already handled
                        }
                        else if (type.type == "number") {
                            outNodes.push(gen.createStringValueAttributeSetter(attribute.name, customElementName))
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
                    }
                    else if (type.kind == "array" && type.itemType == "string") {
                        if (types.some(x => x.kind == "type" && x.type == "string")) {
                            // is part of string | string[], already handled
                        }
                        else throw new Error(`Unsupported type in ${attribute.type}`)
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

function createShoelaceEventSetters(customElementName: string, event: gen.WebComponentInputEntity): gen.WebComponentNode[] {
    var outNodes: gen.MethodDefinition[] = [];
    if (event.kind == "event") {
        outNodes.push(createShoelaceVarActionModelEventEventSetter(customElementName, event.name));
        outNodes.push(createShoelaceSyntaxBuilderActionModelEventEventSetter(customElementName, event.name));
        outNodes.push(createShoelaceVarActionModelEventSetter(customElementName, event.name));
        outNodes.push(createShoelaceSyntaxBuilderActionModelEventSetter(customElementName, event.name));
        // outNodes.push(gen.CreateFuncSyntaxBuilderEventEventSetter(customElementName, event.name));
        // outNodes.push(gen.createVarActionEventSetter(customElementName, event.name));
        // outNodes.push(gen.CreateFuncSyntaxBuilderEventSetter(customElementName, event.name));
        if (event.customDetailType) {
            //console.log(`Custom event detail ${event.name}: ${event.customDetailType}`)
            outNodes.push(createShoelaceVarActionModelCustomEventEventSetter(customElementName, event.name));
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
function createShoelaceVarActionModelEventEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
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
            "OnSlEvent",
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
function createShoelaceSyntaxBuilderActionModelEventEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
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
function createShoelaceVarActionModelEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
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
            "OnSlEvent",
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
function createShoelaceSyntaxBuilderActionModelEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
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

function createShoelaceVarActionModelCustomEventEventSetter(customElementName: string, eventName: string): gen.MethodDefinition {
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
                                        name: gen.toCSharpValidName(eventName) + "Detail"
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
            "OnSlEvent",
            gen.stringLiteralNode("on" + eventName),
            gen.identifierNode("action")
        )
    ])
}