/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
import{e as o,w as s}from"./p-d836d43e.js";import{f as e,s as t}from"./p-06e58c4e.js";import{c as r}from"./p-b51e4004.js";import"./p-06fee233.js";const a=()=>{const a=window;a.addEventListener("statusTap",(()=>{o((()=>{const o=document.elementFromPoint(a.innerWidth/2,a.innerHeight/2);if(!o)return;const n=e(o);n&&new Promise((o=>r(n,o))).then((()=>{s((async()=>{n.style.setProperty("--overflow","hidden"),await t(n,300),n.style.removeProperty("--overflow")}))}))}))}))};export{a as startStatusTap}