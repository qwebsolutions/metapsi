export const SetIframeContent = (iframe, content) => {
    iframe.contentWindow.document.open();
    iframe.contentWindow.document.write(content);
    iframe.contentWindow.document.close();
}

export const HighlightWhenDefined = () => {
    window.customElements.whenDefined("sl-tab").then(_ => {
        window.Prism.highlightAll();
    });
}