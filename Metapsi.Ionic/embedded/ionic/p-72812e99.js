/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
import{d as t}from"./p-7b30edcc.js";import{p as e}from"./p-b51e4004.js";const o=o=>{if(void 0===t)return;let s,p,u,d=0;const l=o.getBoolean("animated",!0)&&o.getBoolean("rippleEffect",!0),v=new WeakMap,m=()=>{u&&clearTimeout(u),u=void 0,s&&(h(!1),s=void 0)},b=(t,o)=>{if(t&&t===s)return;u&&clearTimeout(u),u=void 0;const{x:i,y:r}=e(o);if(s){if(v.has(s))throw new Error("internal error");s.classList.contains(a)||w(s,i,r),h(!0)}if(t){const e=v.get(t);e&&(clearTimeout(e),v.delete(t)),t.classList.remove(a);const o=()=>{w(t,i,r),u=void 0};n(t)?o():u=setTimeout(o,c)}s=t},w=(t,e,o)=>{if(d=Date.now(),t.classList.add(a),!l)return;const i=r(t);null!==i&&(T(),p=i.addRipple(e,o))},T=()=>{void 0!==p&&(p.then((t=>t())),p=void 0)},h=t=>{T();const e=s;if(!e)return;const o=f-Date.now()+d;if(t&&o>0&&!n(e)){const t=setTimeout((()=>{e.classList.remove(a),v.delete(e)}),f);v.set(e,t)}else e.classList.remove(a)};t.addEventListener("ionGestureCaptured",m),t.addEventListener("pointerdown",(t=>{s||2===t.button||b(i(t),t)}),!0),t.addEventListener("pointerup",(t=>{b(void 0,t)}),!0),t.addEventListener("pointercancel",m,!0)},i=t=>{if(void 0===t.composedPath)return t.target.closest(".ion-activatable");{const e=t.composedPath();for(let t=0;t<e.length-2;t++){const o=e[t];if(!(o instanceof ShadowRoot)&&o.classList.contains("ion-activatable"))return o}}},n=t=>t.classList.contains("ion-activatable-instant"),r=t=>{if(t.shadowRoot){const e=t.shadowRoot.querySelector("ion-ripple-effect");if(e)return e}return t.querySelector("ion-ripple-effect")},a="ion-activated",c=100,f=150;export{o as startTapClick}