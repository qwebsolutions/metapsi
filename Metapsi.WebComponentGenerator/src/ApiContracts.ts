import { TypeReference } from "./CSharpContracts.js"

export type Entity = {
    name: string,
    properties: Property[],
    methods: Method[]
}

export type Property = {
    name: string,
    type: TypeReference
}

export type Method = {
    name: string,
    returnType: TypeReference[],
}

export type Parameter = {
    name: string,
    type: TypeReference[]
}

export type EntityDocumentation = {
    comment: string,
}

export type ParameterDocumentation = {
    name: string,
    comment: string
}

