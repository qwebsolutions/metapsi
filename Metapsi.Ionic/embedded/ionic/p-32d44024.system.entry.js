/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
System.register(["./p-25180df3.system.js","./p-a69b9fc5.system.js","./p-0aa833fb.system.js","./p-4609d030.system.js","./p-792919fd.system.js","./p-3ad285e3.system.js","./p-9f3008d4.system.js","./p-8635f5e6.system.js","./p-20d469d0.system.js","./p-ff4b7e40.system.js"],(function(o){"use strict";var i,n,e,t,r,c,a,s;return{setters:[function(o){i=o.r;n=o.h;e=o.j;t=o.f;r=o.i},function(o){c=o.b},function(o){a=o.s},function(o){s=o.g},function(){},function(){},function(){},function(){},function(){},function(){}],execute:function(){var d=".sc-ion-select-modal-ionic-h{height:100%}ion-list.sc-ion-select-modal-ionic ion-radio.sc-ion-select-modal-ionic::part(container){display:none}ion-list.sc-ion-select-modal-ionic ion-radio.sc-ion-select-modal-ionic::part(label){margin-left:0;margin-right:0;margin-top:0;margin-bottom:0}ion-item.sc-ion-select-modal-ionic{--inner-border-width:0}.item-radio-checked.sc-ion-select-modal-ionic{--background:rgba(var(--ion-color-primary-rgb, 0, 84, 233), 0.08);--background-focused:var(--ion-color-primary, #0054e9);--background-focused-opacity:0.2;--background-hover:var(--ion-color-primary, #0054e9);--background-hover-opacity:0.12}.item-checkbox-checked.sc-ion-select-modal-ionic{--background-activated:var(--ion-item-color, var(--ion-text-color, #000));--background-focused:var(--ion-item-color, var(--ion-text-color, #000));--background-hover:var(--ion-item-color, var(--ion-text-color, #000));--color:var(--ion-color-primary, #0054e9)}";var l=d;var u='.sc-ion-select-modal-ios-h{height:100%}ion-item.sc-ion-select-modal-ios{--inner-padding-end:0}ion-radio.sc-ion-select-modal-ios::after{bottom:0;position:absolute;width:calc(100% - 0.9375rem - 16px);border-width:0px 0px 0.55px 0px;border-style:solid;border-color:var(--ion-item-border-color, var(--ion-border-color, var(--ion-color-step-250, var(--ion-background-color-step-250, #c8c7cc))));content:""}ion-radio.sc-ion-select-modal-ios::after{inset-inline-start:calc(0.9375rem + 16px)}';var m=u;var f=".sc-ion-select-modal-md-h{height:100%}ion-list.sc-ion-select-modal-md ion-radio.sc-ion-select-modal-md::part(container){display:none}ion-list.sc-ion-select-modal-md ion-radio.sc-ion-select-modal-md::part(label){margin-left:0;margin-right:0;margin-top:0;margin-bottom:0}ion-item.sc-ion-select-modal-md{--inner-border-width:0}.item-radio-checked.sc-ion-select-modal-md{--background:rgba(var(--ion-color-primary-rgb, 0, 84, 233), 0.08);--background-focused:var(--ion-color-primary, #0054e9);--background-focused-opacity:0.2;--background-hover:var(--ion-color-primary, #0054e9);--background-hover-opacity:0.12}.item-checkbox-checked.sc-ion-select-modal-md{--background-activated:var(--ion-item-color, var(--ion-text-color, #000));--background-focused:var(--ion-item-color, var(--ion-text-color, #000));--background-hover:var(--ion-item-color, var(--ion-text-color, #000));--color:var(--ion-color-primary, #0054e9)}";var b=f;var h=o("ion_select_modal",function(){function o(o){i(this,o);this.header=undefined;this.multiple=undefined;this.options=[]}o.prototype.closeModal=function(){var o=this.el.closest("ion-modal");if(o){o.dismiss()}};o.prototype.findOptionFromEvent=function(o){var i=this.options;return i.find((function(i){return i.value===o.target.value}))};o.prototype.getValues=function(o){var i=this,n=i.multiple,e=i.options;if(n){return e.filter((function(o){return o.checked})).map((function(o){return o.value}))}var t=o?this.findOptionFromEvent(o):null;return t?t.value:undefined};o.prototype.callOptionHandler=function(o){var i=this.findOptionFromEvent(o);var n=this.getValues(o);if(i===null||i===void 0?void 0:i.handler){a(i.handler,n)}};o.prototype.setChecked=function(o){var i=this.multiple;var n=this.findOptionFromEvent(o);if(i&&n){n.checked=o.detail.checked}};o.prototype.renderRadioOptions=function(){var o=this;var i=this.options.filter((function(o){return o.checked})).map((function(o){return o.value}))[0];return n("ion-radio-group",{value:i,onIonChange:function(i){return o.callOptionHandler(i)}},this.options.map((function(e){return n("ion-item",{lines:"none",class:Object.assign({"item-radio-checked":e.value===i},s(e.cssClass))},n("ion-radio",{value:e.value,disabled:e.disabled,justify:"start",labelPlacement:"end",onClick:function(){return o.closeModal()},onKeyUp:function(i){if(i.key===" "){o.closeModal()}}},e.text))})))};o.prototype.renderCheckboxOptions=function(){var o=this;return this.options.map((function(i){return n("ion-item",{class:Object.assign({"item-checkbox-checked":i.checked},s(i.cssClass))},n("ion-checkbox",{value:i.value,disabled:i.disabled,checked:i.checked,justify:"start",labelPlacement:"end",onIonChange:function(i){o.setChecked(i);o.callOptionHandler(i);e(o)}},i.text))}))};o.prototype.render=function(){var o=this;return n(t,{key:"4df42c447b4026d09d9231f09dc4bdae9a8cfe4a",class:c(this)},n("ion-header",{key:"211c4e869b858867f3d60637e570aeb01de41de7"},n("ion-toolbar",{key:"dc4b151331aecbaaaafb460802ee9b689493601d"},this.header!==undefined&&n("ion-title",{key:"ba1347a59ae0a5c6770c239b5ec02a536a445bd1"},this.header),n("ion-buttons",{key:"43c98fd25d7e7f54b94b24e53535c6d5ba599892",slot:"end"},n("ion-button",{key:"51b2b3f3eed42637b2cfc213c95d0bcf10e4b89d",onClick:function(){return o.closeModal()}},"Close")))),n("ion-content",{key:"fe721b09f80555856211f7e40dbfc31a533acae1"},n("ion-list",{key:"d0b932d137136958d896408fb2fa571023775b92"},this.multiple===true?this.renderCheckboxOptions():this.renderRadioOptions())))};Object.defineProperty(o.prototype,"el",{get:function(){return r(this)},enumerable:false,configurable:true});return o}());h.style={ionic:l,ios:m,md:b}}}}));