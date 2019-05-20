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
        $(".form-header").css("padding-left", "2.5em");
        break;
}


$('.fechaNac').datepicker({
    format: "yyyy/mm/dd"
});