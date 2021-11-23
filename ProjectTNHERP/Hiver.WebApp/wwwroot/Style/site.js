import { signalR } from "../microsoft/signalr/dist/browser/signalr";

$(() => {
    var connection = new signalR.HubConnectionBuilder().withUrl("/Infrastructure/signalrServer").build();
    connection.start().catch(err => console.error(err.toString()));

    connection.on("SendMessage", message => {
        document.getElementById("IdOfElementToDisplayMessage").innerHTML = message;
    });
})