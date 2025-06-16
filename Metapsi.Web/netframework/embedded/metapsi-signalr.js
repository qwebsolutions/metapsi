import signalrNoJquery from 'https://cdn.jsdelivr.net/npm/signalr-no-jquery@0.2.1/+esm'

//import { hubConnection } from "/signalr.js";

export const Connect = (hubUrl, register, onConnect) => {
    const connection = signalrNoJquery.hubConnection("/signalR");
    const hubProxy = connection.createHubProxy(hubUrl);

    register(hubProxy);

    //// set up event listeners i.e. for incoming "message" event
    //hubProxy.on('message', function (message) {
    //    console.log(message);
    //});

    // connect
    connection.start()
        .done(() => onConnect())
        .fail(() => { console.log('Could not connect'); });
}