function enviar() {

    var nombres, apellidos, ids;
    nombres = $('#txtNombre').val();
    apellidos = $('#txtApellido').val();
    ids = $('#valueId').val();

    if (nombres.trim() !== "" && apellidos.trim() !== "") {
        $.ajax({
            url: '/Home/InsertarData',
            type: 'POST',
            data: {
                nombre: nombres,
                apellido: apellidos,
                id: ids
            },
            success: function () {
                if (ids === null || ids === '') {
                    alert("Registro Insertado Exitosamente");
                }
                else {
                    alert("Registro Actualizado Exitosamente");     
                }
                location.reload();
            },
            error: function (error) {
                alert('Ocurrio un error: ' + error);
            }
        });
    }
    else {
        alert('El nombre y el apellido son campos obligatorios!');
    }
}

function eliminar() {

    var ids;
    ids = $('#valueId').val();

    if (ids.trim() !== "") {
        $.ajax({
            url: '/Home/EliminarData',
            type: 'POST',
            data: {
                id: ids
            },
            success: function () {
                alert("Registro Eliminado Exitosamente");
                $('#valueId').val('');
                location.reload();
            },
            error: function (error) {
                alert('Ocurrio un error: ' + error);
            }
        });
    }
    
}

function limpiar() {
    $('#txtNombre').val('');
    $('#txtApellido').val('');
    $('#valueId').val('');
}


$(document).ready(function () {
    $('#txtNombre').val('');
    $('#txtApellido').val('');

    $('#cancelar').click(function () {
        window.history.back();
    });

    $("ul").on("click", "li", function () {
        var id = this.id;
        $.ajax({
            url: '/Home/GetDatos',
            type: 'GET',
            dataType: 'json', 
            data: {
                id: id
            },
            success: function (data) {
                if (data !== null) {
                    $('#txtNombre').val(data.Nombres);
                    $('#txtApellido').val(data.Apellidos);
                    $('#valueId').val(data.Id);
                }
            },
            error: function (error) {
                alert('Ocurrio un error: ' + error);
            }
        });

    });


});