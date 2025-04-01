/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
import{c as o}from"./p-597ff9af.js";const s=(s,...e)=>{const n=o.get("logLevel","WARN");if(["WARN"].includes(n))return console.warn(`[Ionic Warning]: ${s}`,...e)},e=(s,...e)=>{const n=o.get("logLevel","ERROR");if(["ERROR","WARN"].includes(n))return console.error(`[Ionic Error]: ${s}`,...e)},n=(o,...s)=>console.error(`<${o.tagName.toLowerCase()}> must be used inside ${s.join(" or ")}.`);export{e as a,n as b,s as p}