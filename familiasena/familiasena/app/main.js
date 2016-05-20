$(function () {
    document.getElementById("enviarInfo").addEventListener("click",
            function () {
                var count = $("#count").attr("value");
                var cont=1
                while (cont <= count) {
                    var estado = $("#myonoffswitch" + cont).prop("checked");
                    if (estado == true) {
                        var valCedulaFun = $("#docFun" + cont).attr("value");
                        var valCedulaFam = $("#docFam" + cont).attr("value");
                        var valTipoRela = $("#rela" + cont).attr("value");

                        $.ajax({
                            type: "POST",
                            contentType: "application/json; charset=utf-8",
                            //datatype: "JSON",
                            url: "ajax.aspx/pruebaAjax",
                            //url: "/Familia/Detalle",
                            //url: "@(Url.Action('Detalle','Familia'))",
                            data: '{ cedulaFam: ' + valCedulaFam + ', cedulaFun: ' + valCedulaFun + ', tipoRela: "'+ valTipoRela +'"}',
                            success: function (response) {
                                console.log(response);
                                //alert(response)

                            },
                            failure: function (response) {
                                console.log(response);
                                //alert(response.d);
                            },
                            error: function (response) {
                                console.log('ERROR response' + response.status + ' ' + response.statusText);
                                //alert('ERROR response + result.status + ' ' + result.statusText);
                            }
                        });
                    }
                    cont++;
                }
                //alert($("#count").val());
            }
        );
    var contador = 0;
    $(".onoffswitch-checkbox").click(function () {

        var v = $(this).attr("value");
        var estado = $("#myonoffswitch" + v).prop("checked");
        var aplica = $("#rela" + v).attr("value");
        var porcion = aplica.substring(0, 2);
        //alert(porcion);
        //alert(estado);
        if (porcion == "SI") {
            $("#relacion" + v).css("color", "green");
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
            $("#relacion" + v).css("color", "red");
            $("#myonoffswitch" + v).removeAttr("checked");
        }
        
    });


});