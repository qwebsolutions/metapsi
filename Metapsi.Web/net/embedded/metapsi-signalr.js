import { HubConnectionBuilder, LogLevel } from "/embedded/Metapsi.Web/0/signalr.js";

export const Connect = (hubUrl, register, onConnect) => {

    const connection = new HubConnectionBuilder()
        .withUrl(hubUrl)
        .configureLogging(LogLevel.Information)
        .build();

    register(connection);

    async function start() {
        try {
            await connection.start();
            onConnect();
            //await connection.invoke("JoinConversation", endpointId);
            console.log("SignalR Connected.");
        } catch (err) {
            console.log(err);
            setTimeout(start, 5000);
        }
    };

    connection.onclose(async () => {
        await start();
    });

    // Start the connection.
    start();
}