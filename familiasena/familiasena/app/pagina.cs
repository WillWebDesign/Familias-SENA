using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ws = familiasena.co.edu.sena.busdatos;


public partial class pagina : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["key"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else {
                string Correo = (string)(Session["key"]);
                infoFamiliaWS(Correo);
            }
        }

    

    public void Logout(object sender, EventArgs e) {
                Session.Abandon();
                Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
                Response.Redirect("login.aspx");
            }

  

    //control de cantidad de familiares



    protected void infoFamiliaWS(string e) {

        string Cedula = "";
        string idfamiliar = "";
        string Correo = e;
        string CodAc = "5&5t3m4.k4kt0";

        ws.Kactus Consulta = new ws.Kactus();



        ws.ConsFamilia[] resultado = Consulta.Consulta_Familia(Cedula, idfamiliar, Correo, CodAc);
        ws.ConsConv[] cnv = Consulta.Consulta_Convocatoria(CodAc);

        familiares.InnerHtml = "";
        convocatoria.InnerHtml = "<h4>Convocatoria</h4><select id='SelcConv'><option value='false'>Seleccione la convocatoria...</option>";

        foreach (var opt in cnv) {
                if (opt.Nro_Registros != "0") { convocatoria.InnerHtml += "<option value='" + opt.ID + "'>" + opt.NOTA + "</option>"; }
            }

        convocatoria.InnerHtml += "</select>";
        int i = 0;
        foreach (var item in resultado)
        {
            // llamado de los valores
            i++;
            nombre.InnerText = "Nombres:" + item.NOMBRES +" "+item.APELLIDOS;
            cedula.InnerText = "Cedula:" + item.COD_EMPL;
            
            familiares.InnerHtml += "<div id='familiar' > ";
            familiares.InnerHtml += "<div style='width: 444px; margin-left: auto; margin-right:auto; padding-top:8px; text-align:center; font-size:2em;'>Familiar</div>";
            familiares.InnerHtml += "<div  style='margin-left:2em; width: 720px; padding-top:2em;'>Cedula:" + item.COD_FAMI + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:2em; width: 720px;'>Apellidos:" + item.APE_FAMI + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:2em; width: 720px;'>Nombres:" + item.NOM_FAMI + "</div>";
            string viablilidad = item.TIP_RELA.Substring(0, 9);
            string justificacion = item.TIP_RELA.Substring(9);
            familiares.InnerHtml += "<div  id='relacion"+i+"' style='margin-left:2em; width: 370px;'>Viabilidad: " + viablilidad + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:2em; width: 720px;'>Motivo: "+ justificacion +"</div>";
            familiares.InnerHtml += "<div  style='margin-left:2em; width: 720px;'>Edad:" + item.EDAD + "</div>";
            familiares.InnerHtml += "<div  style='margin-left:2em; width: 720px;'>Fecha De Nacimiento:" + item.NACIO + "</div>";
            familiares.InnerHtml += "<div style='bakcgro' class='seleccionar'>Seleccionar Familliar" + "</div><br />";
            if (item.TIP_RELA.Substring(0, 2) == "NO")
            {
                familiares.InnerHtml += "<div  style='margin:0 auto;' class='onoffswitch' value='" + i + "'><input type='hidden' id='rela" + i + "' value='" + item.TIP_RELA + "'><input type='hidden' id='docFun" + i + "' value='" + item.COD_EMPL + "'><input type = 'checkbox' value='" + i + "' name = 'onoffswitch' class='onoffswitch-checkbox' id='myonoffswitch" + i + "'><label class='onoffswitch-label' value='" + i + "' for='myonoffswitch" + i + "'><span class='onoffswitch-inner-inactive'></span><span class='onoffswitch-switch'></span></label></div>";
            }
            else
            {

                familiares.InnerHtml += "<div  style='margin:0 auto;' class='onoffswitch' value='" + i + "'><input type='hidden' id='rela" + i + "' value='" + item.TIP_RELA + "'><input type='hidden' id='docFun" + i + "' value='" + item.COD_EMPL + "'><input type='hidden' id='docFam" + i + "' value='" + item.COD_FAMI + "'><input type = 'checkbox' value='" + i + "' name = 'onoffswitch' class='onoffswitch-checkbox' id='myonoffswitch" + i + "'><label class='onoffswitch-label' value='" + i + "' for='myonoffswitch" + i + "'><span class='onoffswitch-inner'></span><span class='onoffswitch-switch'></span></label></div>";

            }
            familiares.InnerHtml += "</div> ";
        } 
        familiares.InnerHtml += "<input type='hidden' id='count' value='" + i + "' >";

    }
}
