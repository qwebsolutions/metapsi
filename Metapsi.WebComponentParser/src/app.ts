import * as fs from "fs";

import * as customElementManifestSchema from 'custom-elements-manifest/schema';
import type { CustomElementDeclaration  } from 'custom-elements-manifest/schema';

import * as csharp from './CSharpContracts';
import * as cswc from './CSharpWebComponentContracts';
import { exit } from "process";

//import("@shoelace-style/shoelace");

//import shoelaceManifest from 'shoelace/custom-elements.json' assert { type: 'json' };

function LoadShoelace(){
    //const manifestJson  = await import('@shoelace-style/shoelace/dist/custom-elements.json', { assert: { type: 'json' } });
    var manifestJsonString = fs.readFileSync("C:\\github\\qwebsolutions\\metapsi\\Metapsi.Shoelace.Generate\\custom-elements2.19.0.json", "utf8");
    var manifestJson = JSON.parse(manifestJsonString);
    var shoelaceManifest: customElementManifestSchema.Package = manifestJson as customElementManifestSchema.Package;
    //console.log(shoelaceManifest.modules);
     shoelaceManifest.modules.forEach(m =>{
        m.declarations?.forEach(d=>{
            //console.log("e.kind:"+ e.kind);
            switch(d.kind){
                case "class":
                    var dec = d as customElementManifestSchema.CustomElement;
                    //console.log(dec);
                    if(dec.name == "SlButton"){
                        console.log(csharp.fileToCSharp(cswc.fromManifest(dec, "Metapsi.Shoelace")));
                }
            }
        })
     })
    }

// async function LoadIonic() {
//     const docs = await import('@ionic/core/dist/docs.json', { assert: { type: 'json' } });
//     console.log(docs.default);
// }



LoadShoelace();



// const stringType = () =>
// {
//     var stringType = new csharp.TypeDefinition();
//     stringType.name = "string";
//     return stringType;
// }

// var typeDefinition = new csharp.TypeDefinition();
// typeDefinition.name = "SlIconButton";
// typeDefinition.isPartial = true;

// var methodStaticClass = new csharp.TypeDefinition();
// methodStaticClass.name = "Method";
// methodStaticClass.isStatic = true;

// typeDefinition.body.push({ nodeType: csharp.NodeType.TypeDefinition , definition: methodStaticClass});

// var clickConstant = new csharp.ConstantDefinition();
// clickConstant.name = "Click";
// clickConstant.value = new csharp.Literal("\"click\"");
// clickConstant.type = stringType();
// methodStaticClass.body.push({nodeType: csharp.NodeType.ConstantDefinition, constant: clickConstant });

// console.log(csharp.toCSharp({nodeType: csharp.NodeType.TypeDefinition, definition: typeDefinition}, 0));

// var staticType = csharp.CreateType(
//     "SlIconButtonControl",
//     b=>
//     {
//         b.typeDef.isStatic = true;
//         b.typeDef.isPartial = true;
//         b.addProperty(
//             "abc",
//             b=>
//             {
//                 b.type = stringType();
//             });
//         b.addMethod("OnSlBlur", 
//             b=>
//             {
//                 b.isStatic = true;
//                 var tComponent = (() => {
//                         var gt = new csharp.GenericType();
//                         gt.name = "TComponent";
//                         gt.genericTypeConstraints.push("SlIconButton");
//                         gt.genericTypeConstraints.push("new()");
//                         return gt;
//                     })();

//                 var tModel = (() => {
//                         var gt = new csharp.GenericType();
//                         gt.name = "TModel";
//                         return gt;
//                     })();

//                 b.genericTypes!.push(tComponent);
//                 b.genericTypes!.push(tModel);

//                 var p1 = new csharp.Parameter("b");
//                 p1.isThis = true;
//                 p1.type = csharp.CreateType(
//                     "PropsBuilder", 
//                     b=>{ 
//                         b.typeDef.typeArguments?.push({ argType : "GenericType", genericType : tComponent });
//                     });
//                 b.parameters.push(p1);

//                 var p2 = new csharp.Parameter("action");
//                 p2.type= csharp.CreateType(
//                     "Var",
//                     b=>
//                     {

//                         var htmlEvent = new csharp.TypeDefinition();
//                         htmlEvent.namespace = "Metapsi.Html";
//                         htmlEvent.name = "Event";

//                         var hyperAction = new csharp.TypeDefinition();
//                         hyperAction.namespace = "Metapsi.Hyperapp";
//                         hyperAction.name = "HyperType.Action";
//                         hyperAction.typeArguments.push({argType: "GenericType", genericType: tModel});
//                         hyperAction.typeArguments.push({argType: "TypeDefinition", typeDefinition: htmlEvent});
//                         b.typeDef.typeArguments?.push({argType: "TypeDefinition", typeDefinition: hyperAction});
//                     }
//                 )
//                 b.parameters.push(p2);

//                 var call = new csharp.Call();
//                 call.onInstance = new csharp.Identifier("b");
//                 call.methodName = "OnEventAction";
//                 call.arguments.push({nodeType: csharp.NodeType.Literal, literal: new csharp.Literal("\"onsl-blur\"")});
//                 call.arguments.push({nodeType: csharp.NodeType.Identifier, identifier: new csharp.Identifier("action")});
//                 b.body.push({nodeType: csharp.NodeType.Call, call: call});
//             }
//         )

//         b.typeDef.body.push({nodeType: csharp.NodeType.NewLine});
//         var comment =new  csharp.Comment();
//         comment.lines.push("<summary>");
//         comment.lines.push("<para> Allows more than one option to be selected. </para>")
//         comment.lines.push("</summary>");
//         b.typeDef.body.push({nodeType: csharp.NodeType.Comment, comment: comment});
//         b.addMethod("SetMultiple",
//             b=>
//             {
//                 b.isStatic = true;
//                 var bparam = new csharp.Parameter("b");
//                 bparam.isThis = true;
//                 bparam.type = csharp.CreateType(
//                     "AttributesBuilder",
//                     b=>
//                     {
//                         var controlType = csharp.CreateType("SlSelect",
//                             b=>
//                             {
//                                 b.typeDef.namespace = "Metapsi.Shoelace";
//                             });
//                         b.typeDef.typeArguments.push({argType: "TypeDefinition", typeDefinition : controlType});
//                     });
//                 b.parameters.push(bparam);

//                 var multipleParam = new csharp.Parameter("multiple");
//                 multipleParam.type = csharp.CreateType("bool", b=>{});
//                 b.parameters.push(multipleParam);

//                 var ifStatement = new csharp.IfStatement();
//                 ifStatement.identifier = new csharp.Identifier("multiple");
//                 var setMultipleCall = new csharp.Call();
//                 setMultipleCall.onInstance = new csharp.Identifier("b");
//                 setMultipleCall.methodName = "SetAttribute";
//                 setMultipleCall.arguments.push({nodeType: csharp.NodeType.Identifier, identifier : new csharp.Identifier("multiple")});
//                 ifStatement.ifBlock?.push({nodeType: csharp.NodeType.Call, call: setMultipleCall});

//                 b.body.push({nodeType: csharp.NodeType.IfStatement, ifStatement: ifStatement});
//             });
//     });


// console.log(csharp.toCSharp({nodeType: csharp.NodeType.TypeDefinition, definition: staticType}, 0));

