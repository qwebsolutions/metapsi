import * as monaco from 'https://cdn.jsdelivr.net/npm/monaco-editor@0.39.0/+esm';

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

export const ApplyCodeFlask = () => {
    //const editorElem = document.getElementById("id-live-sample-renderer");
    //console.log(editorElem)
    //const flask = new CodeFlask(editorElem, { language: 'js' });
}

export const AddMonaco = (intoElement, props) => 
{
    console.log(intoElement);
    var editorReference = monaco.editor.create(intoElement, props);
    console.log(editorReference);
    console.log(props);
}