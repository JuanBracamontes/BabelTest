$(document).ready(function () {
    Home.init();
});

var Home = new function () {
    "use strict";
    var self = this;

    function _initJS() {
        obtenerClientes();
    }

    function obtenerClientes() {
        $.ajax({
            url: "https://localhost:44372/Clientes/ObtenerListado",
            method: "GET",
            dataType:'json',
            success: function (apiResponse) {
                debugger;
                if (apiResponse.CodeRequest == 200) {
                    console.log(apiResponse.Result);
                } else {
                    console.error(apiResponse.Mensaje);
                }
            },
            error: function (xhr, status, error) {
                debugger;
                console.error(xhr);
            }
        })
    }

    self.init = function () {
        _initJS();
    }
}