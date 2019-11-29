//alert("hola");
$.get("Venta/listarTodo", function (data) {
    alert("hola");
    var contenido = "";
    contenido += "<select id='cmbVenta' class='form-control'>";

    for (var i = 0; i < data.length; i++) {

        contenido += "<option value=" + data[i].Id +
            ">" + data[i].DiaVenta +
            "</option>";
    }
    contenido += "</select>";
    document.getElementById("cmbVenta").innerHTML = contenido;
    document.getElementById("cmbVentaedt").innerHTML = contenido;

});

$.get("Producto/listarTodo", function (data) {
    var contenido2 = "";
    contenido2 += "<select id='cmbProducto' class='form-control'>";

    for (var i = 0; i < data.length; i++) {

        contenido2 += "<option value=" + data[i].Id +
            ">" + data[i].Nombre +
            "</option>";
    }
    contenido2 += "</select>";
    document.getElementById("cmbProducto").innerHTML = contenido2;
    document.getElementById("txtProductoedt").innerHTML = contenido2;
});

var elBoton = document.getElementById("btnver");
elBoton.onclick = function () {
    var idVenta = document.getElementById("cmbVenta").value;
    var idProducto = document.getElementById("cmbProducto").value;
    $.get("ListaVenta/listarVentas/?argCodigoProducto=" + idProducto + "&argCodigoVenta=" + idVenta, function (data) {
        alert("hola");
        var contenido = "";
        contenido += "<table id='miTabla' class='table'>";
        contenido += "<thead>";
        contenido += "<tr>";
        contenido += "<td>Id</td>";
        contenido += "<td>Id Venta</td>";
        contenido += "<td>Id Producto</td>";
        contenido += "<td>Cantidad</td>";
        contenido += "</tr>";
        contenido += "</thead>";

        contenido += "<tbody>";
        for (var i = 0; i < data.length; i++) {
            contenido += "<tr>";
            contenido += "<td>" + data[i].Id + "</td>";
            contenido += "<td>" + data[i].Nombres + "</td>";
            contenido += "<td>" + data[i].VentaId.Id + "</td>";
            contenido += "<td>" + data[i].ProductoId.Id + "</td>";
            contenido += "<td>" + data[i].Total + "</td>";
            contenido += "<td><button class='btn btn-primary' onclick=iniciarEdicion(" + data[i].Id + ") data-toggle='modal' data-target='#exampleModal'> <i class='glyphicon glyphicon-edit'></i></button> </td>";
            contenido += "<td><button class='btn btn-primary' onclick=iniciarEliminado(" + data[i].Id + ")>  <i class='glyphicon glyphicon-trash'></i></button> </td>";
            contenido += "</tr>";
        }
        contenido += "</tbody>";
        contenido += "</table>";
        document.getElementById("misListaVenta").innerHTML = contenido;

    })
}