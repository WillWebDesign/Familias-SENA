$(function () {
    document.getElementById("enviarInfo").addEventListener("click",
            function () {
                if(confirm("Señor Usuario recuerde que solo se pueden registrar 2 familiares por convocatoria una ves registrados no podran ser modificados y solo seran tomados los dos primeros familiares inscritos en la convocatoria correpondiente")){
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
                                url: "ajax.aspx/pruebaAjax",                    
                                data: '{ cedulaFam: ' + valCedulaFam + ', cedulaFun: ' + valCedulaFun + ', tipoRela: "'+ valTipoRela +'"}',
                                success: function (response) {
                                    console.log(response);
                                    //alert(response)
                                    if (response.d >= 1) {
                                        alert("Se a completado exitosamente el registro de el familiar identificado con el siguiente Nº: " + valCedulaFam);
                                    }
                                    else {
                                        alert("Cupos de registro para convocatoria llenos");
                                    }

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
            $("#relacion" + v).css("font-weight", "bold");
            if (estado == true) {
                contador++;
                //alert(contador);
                if (contador > 2) {
                    //alert("control");
                    $("#myonoffswitch" + v).removeAttr("checked");
                    alert("No se puede seleccionar mas de 2 familiares.");
                    contador--;
                }
            }
            else {
                contador--;
            }
        }
        if (porcion != "SI") {
            $("#relacion" + v).css("color", "red");
            $("#relacion" + v).css("font-weight", "bold");
            $("#myonoffswitch" + v).removeAttr("checked");
            alert("No es apto para ser elegible!!!");
        }
        
    });


});