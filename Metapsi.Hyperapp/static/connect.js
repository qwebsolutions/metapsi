
const connectors = []

export const getConnectors = () => connectors

let rendered = false;

var lines = []

export const update = () => {

    if (rendered)
        return;

    connectors.forEach((c) => {
        var line = new LeaderLine(
            document.getElementById(c.FromId),
            document.getElementById(c.ToId),
            { size: 2, startSocket: c.FromSide, endSocket: c.ToSide, color: 'rgb(12 74 110)' }
        );

        lines.push(line);
    })

    // It's not just scroll that should trigger reposition. 
    // All types of resize should, so setInterval is probably the safest way
    window.setInterval(function () {
        window.requestAnimationFrame(() => {
            lines.forEach((line) => line.position())
        });
    }, 100);

    rendered = true;
}

