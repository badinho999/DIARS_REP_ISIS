//Prevent modal close background
$('#maccount').modal({
    backdrop: 'static',
    keyboard: false,
    show: false
});

function Encrypt(passw) {
    var crypt = [];

    var key = passw.split('').reverse().join('');

    for (var i = 0; i <= key.length - 1; i++) {

        crypt.push(key.charCodeAt(i));
    }

    return crypt;
}

//Validar inputs
$("#email").blur(() => {

    let email = $("#email").val();

    $.ajax({
        url: "/Account/VerifyEmail",
        type: "GET",
        async: "false",
        data: { email: email },
        success: (result) => {

            if (result != null) {
                $("#emailVal").attr("style", "display: block");
                $("#emailVal").attr("style", "color: red");
                $("#emailVal").text("Este email ya está en uso");
                $("#email").attr("style", "border-color: red");
            }
            else {
                $("#emailVal").attr("style", "display: none");
                $("#emailVal").text("Complete este campo");
                $("#email").attr("style", "border-color: blue");
            }

        },

        error: (errormessage) => {

        }

    });
    $("#emailVal").attr("style", "display: none");
    $("#emailVal").text("Complete este campo");
    $("#email").attr("style", "border-color: blue");
});

$("#username").blur(() => {
    let username = $("#username").val();

    $.ajax({
        url: "/MantenedorHuesped/VirifyUsername",
        type: "GET",
        async: "false",
        data: { UserName: username },
        success: (result) => {

            if (result != null) {
                $("#usrVal").attr("style", "display: block");
                $("#usrVal").attr("style", "color: red");
                $("#usrVal").text("Este nombre de usuario ya está en uso");
                $("#username").attr("style", "border-color: red");
            }
            else {
                $("#usrVal").attr("style", "display: none");
                $("#usrVal").text("Complete este campo");
                $("#username").attr("style", "border-color: blue");
            }

        },

        error: (errormessage) => {

        }

    });
    $("#usrVal").attr("style", "display: none");
    $("#usrVal").text("Complete este campo");
    $("#username").attr("style", "border-color: blue");
});

$("#dni").blur(() => {
    let dni = $("#dni").val();

    $.ajax({
        url: "/MantenedorHuesped/VerifyDni",
        type: "GET",
        async: "false",
        data: { Dni: dni },
        success: (result) => {

            if (result != null) {
                $("#dniVal").attr("style", "display: block");
                $("#dniVal").attr("style", "color: red");
                $("#dniVal").text("Este DNI ya está en uso");
                $("#dni").attr("style", "border-color: red");
            }
            else {
                $("#dniVal").attr("style", "display: none");
                $("#dniVal").text("Complete este campo");
                $("#dni").attr("style", "border-color: blue");
            }

        },

        error: (errormessage) => {

        }

    });
    $("#dniVal").attr("style", "display: none");
    $("#dniVal").text("Complete este campo");
    $("#dni").attr("style", "border-color: blue");
});
//

//Crea huesped
function signUp() {

    var huesped = {
        UserName: $("#username").val(),
        Dni: $("#dni").val(),
        Apellidos: $("#apellidos").val(),
        Nombre: $("#nombre").val(),
        FechaNacimiento: $("#fn").val()
    };

    let validar = validarHuesped(huesped);

    if(validar) {

        $.ajax({
            url: "/MantenedorHuesped/SignUp",
            data: JSON.stringify(huesped),
            type: "POST",
            async: "false",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: (result) => {
                //Cambiar al modal para crear la cuenta
                $("#accountModal").append(`
                <input type="hidden" class="form-control" id="usr" placeholder="Username"  value="${huesped.UserName}"/>
                 `);
                $("#signUp").modal('hide');
                $("#maccount").modal('show');
            },

            error: (errormessage) => {
                $(".alert_info").append(
                    `<div class="alert alert-dismissible alert-danger">
                <strong>Ups!</strong> Al parecer este DNI ya está en uso <a href="#" class="alert-link">No nos trates de engañar amiguito</a>.
                </div>`
                );
                setTimeout(() => {
                    $('.alert_info').remove();
                }, 2000);
            }
        });
    }
    
}

//Finalizar registro (crea cuenta)
function signUpEnd() {

    var passw = $("#pass").val();
    var huesped = {
        UserName: $("#usr").val()
    };
    var cuenta = {
        Email: $("#email").val(),
        Huesped: huesped
    }

    var accountViewData = {
        Cuenta: cuenta,
        Key: Encrypt(passw)
    };

    
    let validar = validarCuenta(accountViewData);

    if(validar) {
        $.ajax({
            url: "/Account/NewAccount",
            data: JSON.stringify(accountViewData),
            type: "POST",
            async: "false",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: (result) => {
                //Se crea la cuenta
                $("#usr").remove();
                $("#maccount").modal('hide');

                $(".alert_info").append(
                    `<div class="alert alert-dismissible alert-success">
                <strong>Bienvenido ${cuenta.Huesped.UserName}!</strong> Se completó el registro <a href="#" class="alert-link">eres un capo</a>.
                </div>`
                );

                setTimeout(() => {
                    $('.alert_info').remove();
                }, 3000);
                
            },

            error: (errormessage) => {
                $(".alert_info").append(
                    `<div class="alert alert-dismissible alert-danger">
                <strong>Ups!</strong> Al parecer el nombre de usuario ya está ocupado<a href="#" class="alert-link">No nos trates de engañar amiguito</a>.
                </div>`
                );
                setTimeout(() => {
                    $('.alert_info').remove();
                }, 2000);
            }

        });
    }
}

function deleteClient() {
    var huesped = {
        UserName: $("#usr").val()
    };

    $.ajax({
        url: "/MantenedorHuesped/DeleteHuesped",
        data: JSON.stringify(huesped),
        type: "POST",
        async: "false",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: (result) => {
            //Se crea la cuenta
            $("#maccount").modal('hide');

            $(".alert_info").append(
                `<div class="alert alert-dismissible alert-success">
                <strong>Fue un gusto conocerte</strong> Se candeló el registro <a href="#" class="alert-link">eres un capo</a>.
                </div>`
            );

            setTimeout(() => {
                $('.alert_info').remove();
            }, 3000);

        },

        error: (errormessage) => {
            $(".alert_info").append(
                `<div class="alert alert-dismissible alert-danger">
                <strong>Ups!</strong> Al parecer el nombre de usuario ya está ocupado<a href="#" class="alert-link">No nos trates de engañar amiguito</a>.
                </div>`
            );
            setTimeout(() => {
                $('.alert_info').remove();
            }, 2000);
        }

    });
};

function validarHuesped(huesped) {
    let validar = false;
    if (huesped.UserName == '') {
        $("#usrVal").attr("style", "display: block");
        $("#usrVal").attr("style", "color: red");
        $("#username").attr("style", "border-color: red");

        $("#dni").attr("style", "border-color: blue");
        $("#apellidos").attr("style", "border-color: blue");
        $("#nombre").attr("style", "border-color: blue");
        $("#fn").attr("style", "border-color: blue");

        $("#dniVal").attr("style", "display: none");
        $("#apeVal").attr("style", "display: none");
        $("#nameVal").attr("style", "display: none");
        $("#fn").attr("style", "display: none");
    }
    else if (huesped.Dni == '') {
        $("#dniVal").attr("style", "display: block");
        $("#dniVal").attr("style", "color: red");
        $("#dni").attr("style", "border-color: red");

        $("#apellidos").attr("style", "border-color: blue");
        $("#nombre").attr("style", "border-color: blue");
        $("#fn").attr("style", "border-color: blue");
        $("#username").attr("style", "border-color: blue");

        $("#apeVal").attr("style", "display: none");
        $("#nameVal").attr("style", "display: none");
        $("#dateVal").attr("style", "display: none");
        $("#usrVal").attr("style", "display: none");
    }
    else if (huesped.Apellidos == '') {
        $("#apeVal").attr("style", "display: block");
        $("#apeVal").attr("style", "color: red");
        $("#apellidos").attr("style", "border-color: red");

        $("#dni").attr("style", "border-color: blue");
        $("#nombre").attr("style", "border-color: blue");
        $("#fn").attr("style", "border-color: blue");
        $("#username").attr("style", "border-color: blue");

        $("#usrVal").attr("style", "display: none");
        $("#dniVal").attr("style", "display: none");
        $("#nameVal").attr("style", "display: none");
        $("#dateVal").attr("style", "display: none");
    }
    else if (huesped.Nombre == '') {
        $("#nameVal").attr("style", "display: block");
        $("#nameVal").attr("style", "color: red");
        $("#nombre").attr("style", "border-color: red");

        $("#dni").attr("style", "border-color: blue");
        $("#apellidos").attr("style", "border-color: blue");
        $("#fn").attr("style", "border-color: blue");
        $("#username").attr("style", "border-color: blue");

        $("#usrVal").attr("style", "display: none");p
        $("#dniVal").attr("style", "display: none");
        $("#apeVal").attr("style", "display: none");
        $("#dateVal").attr("style", "display: none");
    }
    else if (huesped.FechaNacimiento == '') {
        $("#dateVal").attr("style", "display: block");
        $("#dateVal").attr("style", "color: red");
        $("#fn").attr("style", "border-color: red");

        $("#dni").attr("style", "border-color: blue");
        $("#apellidos").attr("style", "border-color: blue");
        $("#nombre").attr("style", "border-color: blue");
        $("#username").attr("style", "border-color: blue");

        $("#usrVal").attr("style", "display: none"); p
        $("#dniVal").attr("style", "display: none");
        $("#apeVal").attr("style", "display: none");
        $("#nameVal").attr("style", "display: none");
    }
    else {
        validar = true;
    }

    return validar;
}

function validarCuenta(accountViewData) {
    let validar = false;

    let cuenta = accountViewData.Cuenta;
    let passw = $("#pass").val();

    if (cuenta.Email == '') {
        $("#emailVal").attr("style", "display: block");
        $("#emailVal").attr("style", "color: red");
        $("#email").attr("style", "border-color: red");

        $("#phone").attr("style", "border-color: blue");
        $("#pass").attr("style", "border-color: blue");

        $("#phoneVal").attr("style", "display: none");
        $("#passVal").attr("style", "display: none");
    }
    else if (passw == '') {
        $("#passVal").attr("style", "display: block");
        $("#passVal").attr("style", "color: red");
        $("#pass").attr("style", "border-color: red");

        $("#phone").attr("style", "border-color: blue");
        $("#email").attr("style", "border-color: blue");

        $("#phoneVal").attr("style", "display: none");
        $("#emailVal").attr("style", "display: none");
    }

    else if (cuenta.Telefono == '') {
        $("#phoneVal").attr("style", "display: block");
        $("#phoneVal").attr("style", "color: red");
        $("#phone").attr("style", "border-color: red");

        $("#email").attr("style", "border-color: blue");
        $("#pass").attr("style", "border-color: blue");

        $("#emailVal").attr("style", "display: none");
        $("#passVal").attr("style", "display: none");
    }
    else {
        validar = true;
    }
    return validar;
}