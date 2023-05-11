// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//const { signalR } = require("./signalr/dist/browser/signalr");

// Write your JavaScript code.

$("#PictureURL").on("change", function () {
    var output = document.getElementById('PicturePreview');
    output.src = $(this).val();
})

$(document).ready(function () {
    var output = document.getElementById('PicturePreview');
    output.src = $("#PictureURL").val();
})