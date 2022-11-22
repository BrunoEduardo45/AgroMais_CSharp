function ShowMensagem(mensagem, tipomsg, tempo) {
    var tempomensagem = 500000;
    if (tempo != undefined) {
        if (tempo > 0)
            tempomensagem = tempo;
    }
    //if (mensagem.indexOf("</li>") <= 0) {
    //   mensagem = "<li style='margin:5px;'>" + mensagem + "</li>";
    //}
    //if (mensagem.indexOf("</ul>") <= 0) {
    //    mensagem = "<ul class='checkvalida'>" + mensagem + "</ul>";
    //}
    var id = guidGenerator();
    nomediv = 'msgerro_' + id;
    if ($("#addMsnErro").length == 0)
    { $("body").prepend('<div id="addMsnErro"style="background-color:#fff;width:100px;height:100px;position:fixed;top:50%;left:50%;margin-top:-100px;margin-left:-100px;z-index:9999900;"></div>') }
       $("#addMsnErro").prepend(
                '<div class="msgAlertas ' + tipomsg.toLowerCase() + '"  id="' + nomediv + '">' +
                    '<span class="closeAlerta"></span>' +
                    '<div class="tituloAlertas">' +
                          '<span></span>' +
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
