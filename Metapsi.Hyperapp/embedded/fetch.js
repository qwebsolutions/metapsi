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
                'Content-Type': 'application/json'
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