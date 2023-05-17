export const setGraph = (g) => graph = g;

export const plusZoom = () => {
    if (cy) {
        cy.zoom(cy.zoom() + 0.1);
    }
}

export const minusZoom = () => {
    if (cy) {
        cy.zoom(cy.zoom() - 0.1);
    }
}

let maximized = false;

export const getMaximized = () => {
    return maximized;
}

export const maximize = () => {
    maximized = true;
    cy.destroy();
    cy = null;
    //setTimeout(() => {
    //    cy.userZoomingEnabled(false);
    //    cy.fit()
    //}, 1000);
}

export const minimize = () => {
    maximized = false;
    cy.destroy();
    cy = null;
    //setTimeout(() => {
    //    cy.userZoomingEnabled(false);
    //    cy.fit();
    //}, 1000);
}

let graph = null;
let cy = null;

var lastFit = "minimized";

export const updateCy = () => {
    console.log("cy.js afterRender");

    if (!graph)
        return;

    if (cy) {
        //if (lastFit == "minimized" && maximized) {
        //    lastFit = "maximized";
        //    cy.fit();
        //}

        //if (lastFit == "maximized" && !maximized) {
        //    lastFit = "minimized";
        //    cy.fit();
        //}

        return;
    }

    lastFit = "minimized";

    cy = cytoscape({
        elements: graph,

        container: document.getElementById('cy'), // container to render in

        minZoom: 0.2,
        maxZoom: 1,
        userZoomingEnabled : maximized,

        layout: {
            name: 'preset',
            fit: true,
        },
        style: [ // the stylesheet for the graph
            {
                selector: 'node',
                style: {
                    'background-color': 'data(NodeColor)',
                    'label': 'data(id)',
                    'color': '#0ea5e9',
                    'font-family': 'poppins, Verdana, sans-serif',
                    'font-weight': 'data(FontWeight)',
                    'width': 15,
                    'height': 15
                }
            },

            {
                selector: 'edge',
                style: {
                    'width': 1,
                    'line-color': '#0c4a6e',
                    'target-arrow-color': '#0c4a6e',
                    'target-arrow-shape': 'triangle',
                    'curve-style': 'bezier'
                }
            }
        ],

    });
}

