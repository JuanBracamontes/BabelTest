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
            dataType:'json',
            success: function (response) {
                var apiResponse = response.data;
                if (apiResponse.CodeRequest == 200) {
                    console.log(apiResponse.Result);
                } else {
                    console.error(apiResponse.Mensaje);
                }
            },
            error: function (xhr, status, error) {
                console.error(xhr);
            }
        })
    }

    self.init = function () {
        _initJS();
    }
}