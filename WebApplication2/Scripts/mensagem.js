function ShowMensagem(mensagem, tipomsg, tempo) {
    var tempomensagem = 500000;
    if (tempo != undefined) {
        if (tempo > 0)
            tempomensagem = tempo;
    }
    var iconMensagem = '';
    if (tipomsg.toLowerCase() == "erro") {
        var iconMensagem = '<i class="fa fa-close fa-5x" style="color:red"></i>'
    }    
    if (tipomsg.toLowerCase() != "erro") {
        var iconMensagem = '<i class="fa fa-check-circle fa-5x" style="color:rgb(93, 125, 72)"></i>'
    }

    var id = guidGenerator();
    nomediv = 'msgerro_' + id;
    if ($("#addMsnErro").length == 0)
    {
        $("body").prepend(
            '<div id="addMsnErro"style=""></div>')
    }
       $("#addMsnErro").prepend(
           '<div class="msgAlertas ' + tipomsg.toLowerCase() + '"  id="' + nomediv + '"style="text-align: center; margin: 30px; width:100%;">' +
                '<span class="closeAlerta"></span>' +
                '<div class="tituloAlertas">' +
                    '<span>' + iconMensagem + '</span>' +
                    '<h1>Atenção</h1>' +
                '</div>' +
                mensagem +
            '</div>');
    $(".closeAlerta").click(function () {
        $(this).parent('.msgAlertas').remove();
        $('#addMsnErro').remove();
    });
    if ((tipomsg.toLowerCase() != "validacao")) {
        tempomensagem = 2000;
    }
    $("#" + nomediv).fadeIn(2000);
    if ((tipomsg.toLowerCase() != "erro") && (tempomensagem > 0)) {
        $("#" + nomediv).delay(tempomensagem).fadeOut(3000, function () {
            $(this).remove();
            $('#addMsnErro').remove();
        });
    }
    if ((tipomsg.toLowerCase() == "erro") && (tempo != undefined)) {
        $("#" + nomediv).delay(tempo).fadeOut(3000, function () {
            $(this).remove();
            $('#addMsnErro').remove();
        });
    }
}

function guidGenerator() {
    var S4 = function () {
        return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
    };
    return (S4() + S4() + "" + S4() + "" + S4() + "" + S4() + "" + S4() + S4() + S4());
}
