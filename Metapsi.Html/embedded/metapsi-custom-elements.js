export const defineStaticCustomElement = (tagName, innerHtml) => {
    customElements.define(
        tagName,
        class extends HTMLElement {
            connectedCallback() {
                this.innerHTML = innerHtml
            }
        })
}

export const defineRACCustomElement = (tagName, render, attach, cleanup) => {
    customElements.define(
        tagName,
        class extends HTMLElement {

            constructor() {
                super();
                if (attach) {
                    attach(this)
                }
            }
            connectedCallback() {
                if (render) {
                    render(this)
                }
            }

            disconnectedCallback() {
                if (cleanup) {
                    cleanup(this)
                }
            }

            refresh() {
                if (render) {
                    render(this)
                }
            }

            _props;
            set props(value) {
                if (this._props !== value) {
                    this._props = value;
                    this.refresh()
                }
            }

            get props() {
                return this._props;
            }
        })
}