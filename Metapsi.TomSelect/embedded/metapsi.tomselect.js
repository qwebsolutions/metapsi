window.customElements.define(
    'metapsi-tom-select',
    class extends HTMLElement {
        _tomSelect;
        _settings;
        _csspaths;

        _currentOptions;

        connectedCallback() {
            this.refresh();
        }

        disconnectedCallback() {
            if (this._tomSelect) {
                this._tomSelect.destroy();
            }
        }

        set settings(value) {
            this._settings = value;
            this.refresh();
        }

        set cssPaths(value) {
            if (!this._csspaths) {
                this._csspaths = value;
                this.refresh();
            }
        }

        refresh() {
            if (!this._csspaths)
                return;

            if (this._csspaths.length == 0)
                return;

            if (!this._settings)
                return;

            if (!this._tomSelect) {
                var shadow = this.attachShadow({ mode: "open" });
                var inputControl = this.createInput();

                shadow.appendChild(inputControl);

                this._csspaths.forEach((cssPath) => {
                    var stylesheet = document.createElement("link");
                    stylesheet.setAttribute("rel", "stylesheet");
                    stylesheet.setAttribute("href", cssPath);
                    shadow.appendChild(stylesheet);
                });

                this._tomSelect = new TomSelect(inputControl, this._settings);
                if (this._settings.editTsControl) {
                    this._settings.editTsControl(this._tomSelect.control);
                }
                this._tomSelect.on("type", (str) => {
                    this.dispatchEvent(new CustomEvent("type", { detail: str }));
                });

                this._tomSelect.on("change", (value) => {
                    this.dispatchEvent(new CustomEvent("change", { detail: value }));
                });
                this._tomSelect.on("load", (data) => {
                    this.dispatchEvent(new CustomEvent("load", { detail: data }));
                });
            }

            if (this._settings) {
                this._tomSelect.clear(true);
                var ts = this._tomSelect;
                this._settings.items.forEach((v) => ts.addItem(v, true));


                // Clearing options breaks scrolling to the selected one when the dropdown is opened
                if (!this._currentOptions) {
                    this._tomSelect.addOptions(this._settings.options);
                    this._tomSelect.refreshOptions(false);
                    this._currentOptions = [...this._settings.options]
                }
                else if (JSON.stringify(this._currentOptions) != JSON.stringify(this._settings.options)) {

                    this._tomSelect.clearOptions(() => true);
                    this._tomSelect.addOptions(this._settings.options);
                    this._tomSelect.refreshOptions(false);
                    this._currentOptions = [...this._settings.options]
                }
            }
        }

        createInput() {
            var select = document.createElement("select")
            return select;
        }
    });

