import * as fs from "fs/promises";
import * as customElementManifestSchema from 'custom-elements-manifest';
import * as csharp from './CSharpContracts.js';
import * as cswc from './CSharpWebComponentContracts.js';
import path from "path";

export async function GenerateShoelace(version: string, outFolder: string): Promise<void> {
    var response = await fetch(`https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@${version}/dist/custom-elements.json`)
    var shoelaceManifest: customElementManifestSchema.Package = await response.json();
    for (const m of shoelaceManifest.modules) {
        for (const d of m.declarations!) {
            {
                switch (d.kind) {
                    case "class":
                        var dec = d as customElementManifestSchema.CustomElement;
                        var controlName = dec.name;
                        var slFilePath = path.join(outFolder, controlName + ".cs");
                        //console.log(slFilePath);
                        var csharpDefinition = cswc.fromManifest(dec, "Metapsi.Shoelace");
                        var csharpFileString = csharp.fileToCSharp(csharpDefinition);
                        await fs.writeFile(slFilePath, csharpFileString, 'utf-8');
                }
            }
        }
    }
}

// async function LoadIonic() {
//     const docs = await import('@ionic/core/dist/docs.json', { assert: { type: 'json' } });
//     console.log(docs.default);
// }
