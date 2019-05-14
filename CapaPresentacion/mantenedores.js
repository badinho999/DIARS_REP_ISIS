$('#mostrarNav').on('click', () => {
    $('nav.side-bar').toggleClass('mostrar');
    $('section.content,header').toggleClass('moveContent');
    $('div.btn-mostrar').toggleClass('ajustarIcon')
})

var mantenedor = "mantenedor";

function changeMantenedorHuesped() {
    document.getElementById('Titulo').innerHTML = "Mantenedor Huésped";
    $('a#MantenedorHuesped').toggleClass('active');
    $("a#listar").attr("href", "/MantenedorHuesped/listarHuesped");
    $("a#nuevo").attr("href", "/MantenedorHuesped/registrarHuesped");
}

$('a#MantenedorHuesped').on('click', (e) => {
    e.preventDefault();
    changeMantenedorHuesped();
})

$('#datetime').data({
    format: 'yyyy-mm-dd',
    autoclose: true
});

$('.fechaNac').datepicker({
    format: "yyyy/mm/dd"
});