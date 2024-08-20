function isEmpty(value) {
    if (value === null || value === undefined) {
        return true;
    }

    if (value === "") {
        return true;
    }

    if (Array.isArray(value)) {
        return value.every(isEmpty);
    }
    else if (typeof (value) === 'object') {
        return Object.values(value).every(isEmpty);
    }

    return false;
}

function replacer(key, value) {
    return isEmpty(value)
        ? undefined
        : value;
}



export const getCommand = (url, onResult, onError) =>
    fetch(url)
        .then(response => {
            if (!response.ok) {
                throw new Error(response.statusText)
            }
            else {
                onResult();
            }
        })
        .catch((error) => {
            console.log(error);
            onError(error)
        })

export const postCommand = (url, payload, onResult, onError) =>
    fetch(url,
        {
            method: 'POST', headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(payload, replacer)
        })
        .then(response => {
            if (!response.ok) {
                throw new Error(response.statusText)
            }
            else {
                onResult();
            }
        })
        .catch((error) => {
            console.log(error);
            onError(error)
        })

export const getRequest = (url, onResult, onError) =>
    fetch(url)
        .then(response => {
            if (!response.ok) {
                throw new Error(response.statusText)
            }
            else {
                return response.json()
            }
        })
        .then(data => onResult(data))
        .catch((error) => {
            console.log(error);
            onError(error)
        })

export const postRequest = (url, payload, onResult, onError) =>
    fetch(url,
        {
            method: 'POST', headers: {
                'Content-Type': 'application/json',
                'credentials': 'include'
            },
            body: JSON.stringify(payload, replacer)
        })
        .then(response => {
            if (!response.ok) {
                throw new Error(response.statusText)
            }
            else {
                return response.json()
            }
        })
        .then(data => onResult(data))
        .catch((error) => {
            console.log(error);
            onError(error)
        })


export const Fetch = (url, options, ok, err) =>
    fetch(url, options)
    .then((resp) => (resp.ok ? resp : Promise.reject(resp)))
    .then((resp) => resp.json())
    .then((result) => ok(result))
        .catch((error) => err(error))

export const DownloadFile = (url, options, ok, err) => {
    fetch(url, options)
        .then((resp) => (resp.ok ? resp : Promise.reject(resp)))
        .then((resp) => resp.blob())
        .then((result) => ok(result))
        .catch((error) => err(error))
}

export const DownloadBlob = (blob, filename) => {
    // Create an object URL for the blob object
    const url = URL.createObjectURL(blob);

    // Create a new anchor element
    const a = document.createElement('a');

    // Set the href and download attributes for the anchor element
    // You can optionally set other attributes like `title`, etc
    // Especially, if the anchor element will be attached to the DOM
    a.href = url;
    a.download = filename || 'download';

    // Click handler that releases the object URL after the element has been clicked
    // This is required for one-off downloads of the blob content
    const clickHandler = () => {
        setTimeout(() => {
            URL.revokeObjectURL(url);
            removeEventListener('click', clickHandler);
        }, 150);
    };

    // Add the click event listener on the anchor element
    // Comment out this line if you don't want a one-off download of the blob content
    a.addEventListener('click', clickHandler, false);

    // Programmatically trigger a click on the anchor element
    // Useful if you want the download to happen automatically
    // Without attaching the anchor element to the DOM
    // Comment out this line if you don't want an automatic download of the blob content
    a.click();

    // Return the anchor element
    // Useful if you want a reference to the element
    // in order to attach it to the DOM or use it in some other way
    //return a;
}