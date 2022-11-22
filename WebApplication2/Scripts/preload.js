//function mostraPreload()
//{
// 	$("body").prepend('<div class="bgPreload"></div>'+'<div class="imgPreload"></div>')	
//}

function removePreload()
{
	$(".bgPreload").remove();
	$(".imgPreload").remove();
}

function mostraPreload() {
    $("body").prepend('<div class="bgPreload"></div>' + '<div class="imgPreload"></div>')
    $(".bgPreload").css("opacity", "0.3");
}

//RETIRA O GIF ANIMADO DE PRELOAD
function removePreload() {
    $(".bgPreload").remove();
    $(".imgPreload").remove();
}
function preLoad() {
    $("body").prepend(
	'<div class="bgPreload"></div>' +
	'<div class="gifAjax"></div>');

    $(".bgPreload").css
	({
	    position: "fixed",
	    zIndex: 99999,
	    background: "#fff",
	    opacity: 0.3,
	    height: "100%",
	    width: "100%",
	    top: 0,
	    left: 0
	})
    $(".gifAjax").css
	({
	    background: "url(~/Content/img/ajax-loader.gif) no-repeat center",
	    position: "fixed",
	    zIndex: 9999999999999999999,
	    left: 0,
	    top: 0,
	    height: "100%",
	    width: "100%"
	})
}

function posLoad() {
    $(".bgPreload").remove();
    $(".gifAjax").remove();
};