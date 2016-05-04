$(function () {
    var contador = 0;
    $(".onoffswitch-checkbox").click(function () {

        var v = $(this).attr("value");
        var estado = $("#myonoffswitch" + v).prop("checked");
        var aplica = $("#rela" + v).attr("value");
        var porcion = aplica.substring(0, 2);
        //alert(porcion);
        //alert(estado);
        if (porcion == "SI") {
            if (estado == true) {
                contador++;
                //alert(contador);
                if (contador > 2) {
                    //alert("control");
                    $("#myonoffswitch" + v).removeAttr("checked");
                    contador--;
                }
            }
            else {
                contador--;
            }
        }
        if (porcion == "NO") {
            $("#myonoffswitch" + v).removeAttr("checked");
        }
        
    });
});