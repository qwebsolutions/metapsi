var __awaiter=this&&this.__awaiter||function(n,t,r,e){function i(n){return n instanceof r?n:new r((function(t){t(n)}))}return new(r||(r=Promise))((function(r,u){function o(n){try{c(e.next(n))}catch(n){u(n)}}function a(n){try{c(e["throw"](n))}catch(n){u(n)}}function c(n){n.done?r(n.value):i(n.value).then(o,a)}c((e=e.apply(n,t||[])).next())}))};var __generator=this&&this.__generator||function(n,t){var r={label:0,sent:function(){if(u[0]&1)throw u[1];return u[1]},trys:[],ops:[]},e,i,u,o;return o={next:a(0),throw:a(1),return:a(2)},typeof Symbol==="function"&&(o[Symbol.iterator]=function(){return this}),o;function a(n){return function(t){return c([n,t])}}function c(a){if(e)throw new TypeError("Generator is already executing.");while(o&&(o=0,a[0]&&(r=0)),r)try{if(e=1,i&&(u=a[0]&2?i["return"]:a[0]?i["throw"]||((u=i["return"])&&u.call(i),0):i.next)&&!(u=u.call(i,a[1])).done)return u;if(i=0,u)a=[a[0]&2,u.value];switch(a[0]){case 0:case 1:u=a;break;case 4:r.label++;return{value:a[1],done:false};case 5:r.label++;i=a[1];a=[0];continue;case 7:a=r.ops.pop();r.trys.pop();continue;default:if(!(u=r.trys,u=u.length>0&&u[u.length-1])&&(a[0]===6||a[0]===2)){r=0;continue}if(a[0]===3&&(!u||a[1]>u[0]&&a[1]<u[3])){r.label=a[1];break}if(a[0]===6&&r.label<u[1]){r.label=u[1];u=a;break}if(u&&r.label<u[2]){r.label=u[2];r.ops.push(a);break}if(u[2])r.ops.pop();r.trys.pop();continue}a=t.call(n,r)}catch(n){a=[6,n];i=0}finally{e=u=0}if(a[0]&5)throw a[1];return{value:a[0]?a[1]:void 0,done:true}}};
/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */System.register(["./p-792919fd.system.js","./p-a69b9fc5.system.js","./p-25180df3.system.js"],(function(n){"use strict";var t,r;return{setters:[function(n){t=n.w},function(n){r=n.c},function(){}],execute:function(){var e=this;var i=n("shouldUseCloseWatcher",(function(){return r.get("experimentalCloseWatcher",false)&&t!==undefined&&"CloseWatcher"in t}));var u=n("blockHardwareBackButton",(function(){document.addEventListener("backbutton",(function(){}))}));var o=n("startHardwareBackButton",(function(){var n=document;var r=false;var u=function(){if(r){return}var t=0;var i=[];var u=new CustomEvent("ionBackButton",{bubbles:false,detail:{register:function(n,r){i.push({priority:n,handler:r,id:t++})}}});n.dispatchEvent(u);var o=function(n){return __awaiter(e,void 0,void 0,(function(){var t,r;return __generator(this,(function(e){switch(e.label){case 0:e.trys.push([0,3,,4]);if(!(n===null||n===void 0?void 0:n.handler))return[3,2];t=n.handler(a);if(!(t!=null))return[3,2];return[4,t];case 1:e.sent();e.label=2;case 2:return[3,4];case 3:r=e.sent();console.error(r);return[3,4];case 4:return[2]}}))}))};var a=function(){if(i.length>0){var n={priority:Number.MIN_SAFE_INTEGER,handler:function(){return undefined},id:-1};i.forEach((function(t){if(t.priority>=n.priority){n=t}}));r=true;i=i.filter((function(t){return t.id!==n.id}));o(n).then((function(){return r=false}))}};a()};if(i()){var o;var a=function(){o===null||o===void 0?void 0:o.destroy();o=new t.CloseWatcher;o.onclose=function(){u();a()}};a()}else{n.addEventListener("backbutton",u)}}));var a=n("OVERLAY_BACK_BUTTON_PRIORITY",100);var c=n("MENU_BACK_BUTTON_PRIORITY",99)}}}));