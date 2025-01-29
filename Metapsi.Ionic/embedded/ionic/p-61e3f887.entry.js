/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */
import{r as o,h as i,j as e,f as t,i as r}from"./p-d836d43e.js";import{b as c}from"./p-0574e87e.js";import{s as n}from"./p-e6635685.js";import{g as a}from"./p-47794def.js";import"./p-7b30edcc.js";import"./p-b51e4004.js";import"./p-ecceeb90.js";import"./p-3cc276f4.js";import"./p-9b97df10.js";import"./p-06fee233.js";const s=class{constructor(i){o(this,i),this.header=void 0,this.multiple=void 0,this.options=[]}closeModal(){const o=this.el.closest("ion-modal");o&&o.dismiss()}findOptionFromEvent(o){const{options:i}=this;return i.find((i=>i.value===o.target.value))}getValues(o){const{multiple:i,options:e}=this;if(i)return e.filter((o=>o.checked)).map((o=>o.value));const t=o?this.findOptionFromEvent(o):null;return t?t.value:void 0}callOptionHandler(o){const i=this.findOptionFromEvent(o),e=this.getValues(o);(null==i?void 0:i.handler)&&n(i.handler,e)}setChecked(o){const{multiple:i}=this,e=this.findOptionFromEvent(o);i&&e&&(e.checked=o.detail.checked)}renderRadioOptions(){const o=this.options.filter((o=>o.checked)).map((o=>o.value))[0];return i("ion-radio-group",{value:o,onIonChange:o=>this.callOptionHandler(o)},this.options.map((e=>i("ion-item",{lines:"none",class:Object.assign({"item-radio-checked":e.value===o},a(e.cssClass))},i("ion-radio",{value:e.value,disabled:e.disabled,justify:"start",labelPlacement:"end",onClick:()=>this.closeModal(),onKeyUp:o=>{" "===o.key&&this.closeModal()}},e.text)))))}renderCheckboxOptions(){return this.options.map((o=>i("ion-item",{class:Object.assign({"item-checkbox-checked":o.checked},a(o.cssClass))},i("ion-checkbox",{value:o.value,disabled:o.disabled,checked:o.checked,justify:"start",labelPlacement:"end",onIonChange:o=>{this.setChecked(o),this.callOptionHandler(o),e(this)}},o.text))))}render(){return i(t,{key:"4df42c447b4026d09d9231f09dc4bdae9a8cfe4a",class:c(this)},i("ion-header",{key:"211c4e869b858867f3d60637e570aeb01de41de7"},i("ion-toolbar",{key:"dc4b151331aecbaaaafb460802ee9b689493601d"},void 0!==this.header&&i("ion-title",{key:"ba1347a59ae0a5c6770c239b5ec02a536a445bd1"},this.header),i("ion-buttons",{key:"43c98fd25d7e7f54b94b24e53535c6d5ba599892",slot:"end"},i("ion-button",{key:"51b2b3f3eed42637b2cfc213c95d0bcf10e4b89d",onClick:()=>this.closeModal()},"Close")))),i("ion-content",{key:"fe721b09f80555856211f7e40dbfc31a533acae1"},i("ion-list",{key:"d0b932d137136958d896408fb2fa571023775b92"},!0===this.multiple?this.renderCheckboxOptions():this.renderRadioOptions())))}get el(){return r(this)}};s.style={ionic:".sc-ion-select-modal-ionic-h{height:100%}ion-list.sc-ion-select-modal-ionic ion-radio.sc-ion-select-modal-ionic::part(container){display:none}ion-list.sc-ion-select-modal-ionic ion-radio.sc-ion-select-modal-ionic::part(label){margin-left:0;margin-right:0;margin-top:0;margin-bottom:0}ion-item.sc-ion-select-modal-ionic{--inner-border-width:0}.item-radio-checked.sc-ion-select-modal-ionic{--background:rgba(var(--ion-color-primary-rgb, 0, 84, 233), 0.08);--background-focused:var(--ion-color-primary, #0054e9);--background-focused-opacity:0.2;--background-hover:var(--ion-color-primary, #0054e9);--background-hover-opacity:0.12}.item-checkbox-checked.sc-ion-select-modal-ionic{--background-activated:var(--ion-item-color, var(--ion-text-color, #000));--background-focused:var(--ion-item-color, var(--ion-text-color, #000));--background-hover:var(--ion-item-color, var(--ion-text-color, #000));--color:var(--ion-color-primary, #0054e9)}",ios:'.sc-ion-select-modal-ios-h{height:100%}ion-item.sc-ion-select-modal-ios{--inner-padding-end:0}ion-radio.sc-ion-select-modal-ios::after{bottom:0;position:absolute;width:calc(100% - 0.9375rem - 16px);border-width:0px 0px 0.55px 0px;border-style:solid;border-color:var(--ion-item-border-color, var(--ion-border-color, var(--ion-color-step-250, var(--ion-background-color-step-250, #c8c7cc))));content:""}ion-radio.sc-ion-select-modal-ios::after{inset-inline-start:calc(0.9375rem + 16px)}',md:".sc-ion-select-modal-md-h{height:100%}ion-list.sc-ion-select-modal-md ion-radio.sc-ion-select-modal-md::part(container){display:none}ion-list.sc-ion-select-modal-md ion-radio.sc-ion-select-modal-md::part(label){margin-left:0;margin-right:0;margin-top:0;margin-bottom:0}ion-item.sc-ion-select-modal-md{--inner-border-width:0}.item-radio-checked.sc-ion-select-modal-md{--background:rgba(var(--ion-color-primary-rgb, 0, 84, 233), 0.08);--background-focused:var(--ion-color-primary, #0054e9);--background-focused-opacity:0.2;--background-hover:var(--ion-color-primary, #0054e9);--background-hover-opacity:0.12}.item-checkbox-checked.sc-ion-select-modal-md{--background-activated:var(--ion-item-color, var(--ion-text-color, #000));--background-focused:var(--ion-item-color, var(--ion-text-color, #000));--background-hover:var(--ion-item-color, var(--ion-text-color, #000));--color:var(--ion-color-primary, #0054e9)}"};export{s as ion_select_modal}