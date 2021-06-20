$(document).ready(function () {
    Home.init();
});

var Home = new function () {
    "use strict";
    var self = this;

    function _initJS() {
        console.log("Se ha iniciado el js del home");
        obtenerClientes();
    }

    function obtenerClientes() {
        $.ajax({
            url: "https://localhost:44372/Home/GetClientes",
            method: "GET",
            contentType: 'application/json',
            dataType: 'json',
            success: function (response) {
                if (response) {
                    console.log(response);
                }
            },
            error: function (err) {
                console.log(err);
            }

        })
    }

    self.init = function () {
        _initJS();
    }
}