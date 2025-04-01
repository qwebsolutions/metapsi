/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
import{d as o,w as s}from"./p-66a5d6a8.js";import{f as t,s as f}from"./p-c3f9d9fe.js";import{c as r}from"./p-ece78e7b.js";import"./p-3f4327f7.js";import"./p-597ff9af.js";const a=()=>{const a=window;a.addEventListener("statusTap",(()=>{o((()=>{const o=document.elementFromPoint(a.innerWidth/2,a.innerHeight/2);if(!o)return;const e=t(o);e&&new Promise((o=>r(e,o))).then((()=>{s((async()=>{e.style.setProperty("--overflow","hidden"),await f(e,300),e.style.removeProperty("--overflow")}))}))}))}))};export{a as startStatusTap}