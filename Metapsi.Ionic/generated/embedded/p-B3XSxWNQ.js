/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
import{f as o,w as s}from"./p-B_U9CtaY.js";import{f as t,s as r}from"./p-QwEXyOze.js";import{c as a}from"./p-Do-uqmtX.js";const n=()=>{const n=window;n.addEventListener("statusTap",(()=>{o((()=>{const o=document.elementFromPoint(n.innerWidth/2,n.innerHeight/2);if(!o)return;const e=t(o);e&&new Promise((o=>a(e,o))).then((()=>{s((async()=>{e.style.setProperty("--overflow","hidden"),await r(e,300),e.style.removeProperty("--overflow")}))}))}))}))};export{n as startStatusTap}