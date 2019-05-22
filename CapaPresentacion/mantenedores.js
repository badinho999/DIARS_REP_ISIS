var sectionID = $("section").attr("id");

switch (sectionID) {
    case "listarHuesped":
        $("#Titulo").html("Mantenedor Huésped");
        $("#MantenedorHuesped").toggleClass("active");
        $(".form-header").css("padding-left", "5.5em");
        break;
    case "listarHabitaciones":
        $("#Titulo").html("Mantenedor Habitaciones");
        $("#MantenedorHabitacion").toggleClass("active");
        $(".form-header").css("padding-left", "0em");
        break;
    case "listarServicios":
        $("#Titulo").html("Mantenedor Servicios adicionales");
        $("#MantenedorServicios").toggleClass("active");
        $(".form-header").css("padding-left", "11.5em");
        break;
    case "listarTiposH":
        $("#Titulo").html("Mantenedor Tipos de habitación");
        $("#MantenedorTH").toggleClass("active");
        $(".form-header").css("padding-left", "0em");
        break;
}

$(function () {

    $("#MultiServ").multiSelect();
})

$('.fechaNac').datepicker({
    format: "yyyy/mm/dd"
});