$('#mostrarNav').on('click', () => {
    $('nav.side-bar').toggleClass('mostrar');
    $('section.content,header').toggleClass('moveContent');
    $('div.btn-mostrar').toggleClass('ajustarIcon')
})
