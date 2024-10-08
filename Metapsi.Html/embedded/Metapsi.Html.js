import { app, h } from "/hyperapp.js";

export const defineHyperappCustomElement = (tagName, view) => {
    customElements.define(
        tagName,
        class extends HTMLElement {
            _dispatch = () => { };
            _model = null;

            constructor() {
                super();
                
                this._dispatch = app({
                    view: (model) => model ? view(model) : h(tagName, {}),
                    node: this
                });
            }

            set model(value) {
                this._model = value;
                this.refresh();
            }

            connectedCallback() {
                this.refresh();
            }

            disconnectedCallback() {
                if (this._dispatch) this._dispatch();
                this._dispatch(); // <- without arguments is cleanup
            }

            refresh() {
                var self = this;
                this._dispatch(() => self._model);
            }
        });
}

export const NewPromise = (callback) => new Promise(callback)
export const GetStaticPromise = () => Promise;

