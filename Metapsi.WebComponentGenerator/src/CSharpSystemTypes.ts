import { TypeReference } from "./CSharpContracts.js";

export const systemVoid : TypeReference = {name:"void"}
export const systemString :TypeReference = {name:"string"}
export const systemInt: TypeReference = {name:"int"}
export const systemDecimal: TypeReference = {name: "decimal"};
export const systemBool: TypeReference = {name: "bool"}

export const systemAction: TypeReference = {name: "Action", namespace: "System"}
export const systemFunc: TypeReference = {name: "Func", namespace: "System"}

export const systemCollectionsGenericDictionary = {name: "Dictionary", namespace: "System.Collections.Generic"}
export const systemCollectionsGenericList = {name: "List", namespace : "System.Collections.Generic"}