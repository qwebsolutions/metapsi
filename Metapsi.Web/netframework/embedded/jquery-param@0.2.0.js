/**
 * Bundled by jsDelivr using Rollup v4.62.2 and esbuild v0.28.1.
 * Original file: /npm/jquery-param@0.2.0/jquery-param.js
 *
 * Do NOT use SRI with dynamically generated files! More information: https://www.jsdelivr.com/using-sri-with-dynamic-files
 */
var o={exports:{}},f;function p(){return f||(f=1,(function(s){(function(q){var d=function(y){var i=[],m=/\[\]$/,c=function(n){return Object.prototype.toString.call(n)==="[object Array]"},l=function(n,e){e=typeof e=="function"?e():e===null||e===void 0?"":e,i[i.length]=encodeURIComponent(n)+"="+encodeURIComponent(e)},a=function(n,e){var r,u,t;if(n)if(c(e))for(r=0,u=e.length;r<u;r++)m.test(n)?l(n,e[r]):a(n+"["+(typeof e[r]=="object"?r:"")+"]",e[r]);else if(e&&String(e)==="[object Object]")for(t in e)a(n+"["+t+"]",e[t]);else l(n,e);else if(c(e))for(r=0,u=e.length;r<u;r++)l(e[r].name,e[r].value);else for(t in e)a(t,e[t]);return i};return a("",y).join("&").replace(/%20/g,"+")};s.exports=d})()})(o)),o.exports}var g=p();export{g as default};
//# sourceMappingURL=/sm/64051713455ff728b1e0c4b2b2d9cbfb2398b62fd67412239b470fea0217447e.map