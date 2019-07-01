
function Encrypt(passw) {
    var crypt = [];

    var key = passw.split('').reverse().join('');

    for (var i = 0; i <= key.length-1;i++) {
        

        crypt.push(key.charCodeAt(i));
    }

    return crypt;
}

function logIn() {
    let username = $("#logusrname").val();
    let passw = $("#logpass").val();

    let validar = validarLogin(username,passw);

    var userViewModel = {
        UserName: username,
        Key: Encrypt(passw)
    };

    if (validar) {
        $.ajax({
            url: "/Login/VerificarAcceso",
            type: "POST",
            data: { userViewModel },
            dataType: "json",
            success: (result) => {

                if (result != null) {
                    var usr = result.Usr;
                    if (usr.includes("Index")) {
                        window.location.href = result.Usr;
                    }
                    else {
                        $("#mlogin").modal('hide');
                        $("a#idLogin").html(usr);
                        $("a#idLogin").attr("href","#");
                        $("a#idLogin").removeAttr("data-toggle");
                        $("a#idLogin").removeAttr("data-target");
                        $("a#idsignUp").html("Cerrar Sesión");

                        $("a#idsignUp").attr("href", "/Login/CerrarSesion");
                        $("a#idsignUp").removeAttr("data-toggle");
                        $("a#idsignUp").removeAttr("data-target");
                        $("li#misReservas").removeAttr("hidden");

                        location.reload();
                    }
                }
                else {
                    $("#logusrnameVal").attr("style", "display: block");
                    $("#logusrnameVal").attr("style", "color: red");
                    $("#logusrnameVal").text("Usuario o contraseña incorrectos");
                    $("#logusrname").attr("style", "border-color: red");
                }

            },

            error: (errormessage) => {

            }

        });
    }
    $("#logusrnameVal").attr("style", "display: none");
    $("#logusrnameVal").text("Complete este campo");
    $("#logusrname").attr("style", "border-color: blue");
    
};

function validarLogin(username, passw) {
    let validar = false;

    if (username == '') {
        $("#logusrnameVal").attr("style", "display: block");
        $("#logusrnameVal").attr("style", "color: red");
        $("#logusrname").attr("style", "border-color: red");

        $("#logpass").attr("style", "border-color: blue");
s
        $("#logpassVal").attr("style", "display: none");
    }
    else if (passw == '') {
        $("#logpassVal").attr("style", "display: block");
        $("#logpassVal").attr("style", "color: red");
        $("#logpass").attr("style", "border-color: red");

        $("#logusrname").attr("style", "border-color: blue");

        $("#logusrnameVal").attr("style", "display: none");
    }
    else {
        validar = true;
    }
    return validar;
}