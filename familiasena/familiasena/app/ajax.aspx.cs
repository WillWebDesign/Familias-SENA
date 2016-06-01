using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ws = familiasena.co.edu.sena.busdatos;

namespace familiasena.app
{
    public partial class ajax : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [System.Web.Services.WebMethod]
        public static string pruebaAjax(string cedulaFam, string cedulaFun , string tipoRela)
        {
            string año = "2016";
            string convocatoria = "5";
            string codAc = "5&5t3m4.k4kt0";
            string resultadoNum = "";
            string numDocFam = "";
            string rstl = "";
            //return string.Format("me llego {0} {1}", cedulaFam, cedulaFun);
            ws.Kactus Query = new ws.Kactus();

            ws.ConsFins[] resultado = Query.Consulta_FamiliaInsc(cedulaFun, año, convocatoria, codAc);

                foreach (var item in resultado){

                    resultadoNum =item.Nro_Registros;
                    numDocFam = item.COD_FAMI;
                }
                    
                int valorUni = Int32.Parse(resultadoNum.Substring(0,1));
                //return string.Format("tiene " + resultadoNum+" "+valorUni);
                if (valorUni >= 2) {
                        rstl = string.Format("no puede");
                        }
                     else {
                            if (valorUni < 2) {
                                if (cedulaFam != numDocFam)
                                {
                                    ws.Kactus ingreso = new ws.Kactus();

                                    var responde = ingreso.Actualiza_FSena(cedulaFun, cedulaFam, tipoRela, convocatoria, codAc);

                                    rstl = responde;
                                    //rstl = string.Format("puede"+cedulaFam);
                                }
                            }
                        }
                
                
            return rstl;
            }
    }
}