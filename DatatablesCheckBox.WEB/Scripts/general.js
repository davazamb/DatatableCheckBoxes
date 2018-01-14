function notificar(mensaje, tipo, timeout) {
    if (!timeout)
        timeout = 4000;
    noty(
    {
        text: mensaje,
        theme: 'relax',
        type: tipo,
        timeout: timeout,
        dismissQueue: false,
        layout: 'topCenter',
        animation: {
            open: { height: 'toggle' }, // jQuery animate function property object
            close: { height: 'toggle' }, // jQuery animate function property object
            easing: 'swing', // easing
            speed: 250 // opening & closing animation speed
        }
    });
}

function notificarResultado(res) {
    notificar(res.Mensaje, res.Codigo <= 0 ? "error" : "success");
}

function limpiarNumero(str) {
    return str.toString().replace('.', '').replace('.', '').replace('.', '');
}

function MuestraEspera(elemento, mensaje) {
    if (!mensaje || mensaje.length == 0)
        mensaje = 'Cargando datos, espere por favor...  ';
    mensaje += "<i class='fa fa-spinner fa-spin'></i>"; 
    var defaultOption = {
        message: mensaje,
        css: { border: '1px solid gray' },
        centerX: true,
        centerY: true,
        overlayCSS: {
            opacity: 0.3
        }
    };
    if (!elemento) {
        $.blockUI(defaultOption);
    } else {
        //TODO: el block y unblock a veces da error de q no está definida para el elemento, por eso el chequeo
        if ($.isFunction(elemento.block))
            elemento.block(defaultOption);
        else if ($.isFunction(elemento.blockUI))
            elemento.blockUI(defaultOption);
    }
}

function OcultaEspera(elemento) {
    if (!elemento) {
        $.unblockUI();
    } else {
        if ($.isFunction(elemento.unblock))
            elemento.unblock();
        else if ($.isFunction(elemento.unblockUI))
            elemento.unblockUI();
    }
}

function getBase64Logo(logoStr) {
    var tipo = "";
    if (!logoStr)
        return "";
    if (logoStr.charAt(0) == '/') {
        tipo = "image/jpeg";
    } else if (logoStr.charAt(0) == 'R') {
        tipo = "image/gif";
    } else if (logoStr.charAt(0) == 'i') {
        tipo = "image/png";
    } else if (logoStr.charAt(0) == 'Q') {
        tipo = "image/bmp";
    }
    tipo = "data:" + tipo + ";base64," + logoStr;
    return tipo;
}

function scrollToElement(element) {
    var heightBarraTope = $(".navbar-fixed-top").height() != null ? $(".navbar-fixed-top").height() + 10 : 0;
    var top = element ? element.offset().top + heightBarraTope : 0;
    $('html, body').animate({
            scrollTop: top
        }, 2000);
}