import { app } from "/hyperapp.js";

export const defineCustomElement = (tagName, view) => {
    customElements.define(
        tagName,
        class extends HTMLElement {

            _dispatch = null;

            connectedCallback() {
                var container = document.createElement("div");

                this._dispatch = app({
                    init: this.model,
                    view: (model) => view(model, this),
                    node: container
                })

                this.appendChild(container);
            }

            disconnectedCallback() {
                // https://github.com/jorgebucaran/hyperapp/blob/main/docs/api/app.md
                // Calling the dispatch function with no arguments frees the app's resources and runs every active subscription's cleanup function.
                this._dispatch();
            }
        });
}